using System;
using System.Globalization;
using System.Windows.Forms;

namespace Bai03
{
    public partial class frmVatTu : Form
    {
        public frmVatTu()
        {
            InitializeComponent();
        }

        // ================= THÊM MỚI =================
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!LayDuLieu(out string ma, out string ten, out string donVi, out decimal donGia))
                return;

            // Không cho thêm nếu Mã VT đã tồn tại
            if (TimViTriTheoMa(ma, -1) >= 0)
            {
                BaoLoi("Mã vật tư \"" + ma + "\" đã tồn tại trong danh sách!", txtMaVT);
                return;
            }

            ListViewItem item = new ListViewItem(ma);
            item.SubItems.Add(ten);
            item.SubItems.Add(donVi);
            item.SubItems.Add(donGia.ToString("N0"));
            item.Tag = donGia; // lưu giá trị gốc để đẩy ngược lại TextBox

            lvVatTu.Items.Add(item);
            LamMoiO();
        }

        // ================= CẬP NHẬT =================
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng trong danh sách để cập nhật!",
                                "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!LayDuLieu(out string ma, out string ten, out string donVi, out decimal donGia))
                return;

            ListViewItem item = lvVatTu.SelectedItems[0];

            // Nếu đổi mã thì mã mới không được trùng với dòng khác
            if (TimViTriTheoMa(ma, item.Index) >= 0)
            {
                BaoLoi("Mã vật tư \"" + ma + "\" đã tồn tại ở dòng khác!", txtMaVT);
                return;
            }

            item.SubItems[0].Text = ma;
            item.SubItems[1].Text = ten;
            item.SubItems[2].Text = donVi;
            item.SubItems[3].Text = donGia.ToString("N0");
            item.Tag = donGia;

            MessageBox.Show("Cập nhật thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // ================= XÓA DÒNG =================
        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            if (lvVatTu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa!",
                                "Chưa chọn dòng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ListViewItem item = lvVatTu.SelectedItems[0];
            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa vật tư \"" + item.SubItems[1].Text + "\" không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kq == DialogResult.Yes)
            {
                lvVatTu.Items.Remove(item);
                LamMoiO();
            }
        }

        // ================= XÓA TOÀN BỘ =================
        private void btnXoaTatCa_Click(object sender, EventArgs e)
        {
            if (lvVatTu.Items.Count == 0)
            {
                MessageBox.Show("Danh sách đang trống!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult kq = MessageBox.Show(
                "Bạn có chắc muốn xóa toàn bộ " + lvVatTu.Items.Count + " vật tư không?",
                "Xác nhận xóa toàn bộ", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (kq == DialogResult.Yes)
            {
                lvVatTu.Items.Clear();
                LamMoiO();
            }
        }

        // ============ CHỌN DÒNG -> ĐẨY LÊN Ô NHẬP ============
        private void lvVatTu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Khi bỏ chọn, SelectedItems rỗng nên phải kiểm tra
            if (lvVatTu.SelectedItems.Count == 0)
                return;

            ListViewItem item = lvVatTu.SelectedItems[0];
            txtMaVT.Text = item.SubItems[0].Text;
            txtTenVT.Text = item.SubItems[1].Text;
            cboDonVi.SelectedItem = item.SubItems[2].Text;

            if (item.Tag is decimal gia)
                txtDonGia.Text = gia.ToString();
            else
                txtDonGia.Text = item.SubItems[3].Text;
        }

        // ================= HÀM DÙNG CHUNG =================

        // Kiểm tra dữ liệu nhập, trả về false nếu có lỗi
        private bool LayDuLieu(out string ma, out string ten, out string donVi, out decimal donGia)
        {
            ma = txtMaVT.Text.Trim();
            ten = txtTenVT.Text.Trim();
            donVi = cboDonVi.Text;
            donGia = 0;

            if (ma == "")
            {
                BaoLoi("Vui lòng nhập mã vật tư!", txtMaVT);
                return false;
            }
            if (ten == "")
            {
                BaoLoi("Vui lòng nhập tên vật tư!", txtTenVT);
                return false;
            }
            if (cboDonVi.SelectedIndex < 0)
            {
                BaoLoi("Vui lòng chọn đơn vị tính!", cboDonVi);
                return false;
            }
            if (txtDonGia.Text.Trim() == "")
            {
                BaoLoi("Vui lòng nhập đơn giá nhập!", txtDonGia);
                return false;
            }
            if (!decimal.TryParse(txtDonGia.Text.Trim(), NumberStyles.Number,
                                  CultureInfo.CurrentCulture, out donGia))
            {
                BaoLoi("Đơn giá phải là số!", txtDonGia);
                return false;
            }
            if (donGia < 0)
            {
                BaoLoi("Đơn giá không được âm!", txtDonGia);
                return false;
            }
            return true;
        }

        // Tìm dòng có Mã VT trùng (bỏ qua dòng boQuaIndex). Trả về -1 nếu không có.
        private int TimViTriTheoMa(string ma, int boQuaIndex)
        {
            foreach (ListViewItem it in lvVatTu.Items)
            {
                if (it.Index == boQuaIndex) continue;
                if (string.Equals(it.SubItems[0].Text, ma, StringComparison.OrdinalIgnoreCase))
                    return it.Index;
            }
            return -1;
        }

        private void LamMoiO()
        {
            txtMaVT.Clear();
            txtTenVT.Clear();
            cboDonVi.SelectedIndex = -1;
            txtDonGia.Clear();
            lvVatTu.SelectedItems.Clear();
            txtMaVT.Focus();
        }

        private void BaoLoi(string thongBao, Control c)
        {
            MessageBox.Show(thongBao, "Lỗi nhập liệu",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            c.Focus();
        }
    }
}