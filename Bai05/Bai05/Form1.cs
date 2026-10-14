using System;
using System.Globalization;
using System.Windows.Forms;

namespace Bai05
{
    public partial class frmDonHang : Form
    {
        private bool dangTinh = false;

        public frmDonHang()
        {
            InitializeComponent();
        }

        private void frmDonHang_Load(object sender, EventArgs e)
        {
            cboLoaiVanChuyen.SelectedIndex = 0;
            CapNhatDongHo();

            ThemHang("Thùng sách", 2, 5.5m, 120000m);
            ThemHang("Bàn phím cơ", 1, 1.2m, 850000m);
        }

        private void tmrDongHo_Tick(object sender, EventArgs e)
        {
            CapNhatDongHo();
        }

        private void CapNhatDongHo()
        {
            tsslThoiGian.Text = "Thời gian: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // F2: thêm nhanh dòng mới
            if (keyData == Keys.F2)
            {
                ThemDong();
                return true; 
            }

            if (keyData == Keys.Delete && dgvHang.ContainsFocus && !dgvHang.IsCurrentCellInEditMode)
            {
                XoaDong();
                return true;
            }

            if (keyData == Keys.Escape)
                XoaLoi();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnThemDong_Click(object sender, EventArgs e)
        {
            ThemDong();
        }

        private void btnXoaDong_Click(object sender, EventArgs e)
        {
            XoaDong();
        }

        private void ThemDong()
        {
            if (!ValidateChildren())
                return;

            int i = ThemHang("", 1, 1m, 0m);

            dgvHang.CurrentCell = dgvHang.Rows[i].Cells[colTenHang.Index];
            dgvHang.Focus();
            dgvHang.BeginEdit(true);
        }

        private void XoaDong()
        {
            if (dgvHang.CurrentRow == null)
            {
                MessageBox.Show("Không có dòng nào để xóa!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            dgvHang.Rows.RemoveAt(dgvHang.CurrentRow.Index);
            XoaLoi();
            TinhLai();
        }

        private int ThemHang(string ten, int soLuong, decimal trongLuong, decimal donGia)
        {
            int i;
            dangTinh = true; 
            try
            {
                i = dgvHang.Rows.Add(ten, soLuong, trongLuong, donGia, 0m);
            }
            finally
            {
                dangTinh = false;
            }
            TinhLai();
            return i;
        }

        private void dgvHang_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            int c = e.ColumnIndex;
            if (e.RowIndex < 0 ||
                (c != colSoLuong.Index && c != colTrongLuong.Index && c != colDonGia.Index))
                return;

            string tenCot = dgvHang.Columns[c].HeaderText;
            string text = (Convert.ToString(e.FormattedValue) ?? "").Trim();
            string loi = "";

            if (text == "")
                loi = tenCot + " không được để trống!";
            else if (!decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal so))
                loi = tenCot + " phải là số!";
            else if (c == colSoLuong.Index && so != Math.Floor(so))
                loi = "Số lượng phải là số nguyên!";
            else if ((c == colSoLuong.Index || c == colTrongLuong.Index) && so <= 0)
                loi = tenCot + " phải lớn hơn 0!";
            else if (c == colDonGia.Index && so < 0)
                loi = "Đơn giá không được âm!";

            if (loi != "")
            {
                e.Cancel = true; 
                dgvHang.Rows[e.RowIndex].Cells[c].ErrorText = loi;                      
                errorProvider1.SetError(dgvHang, "Dòng " + (e.RowIndex + 1) + ": " + loi);
            }
            else
            {
                XoaLoi();
            }
        }

        private void XoaLoi()
        {
            errorProvider1.SetError(dgvHang, "");
            foreach (DataGridViewRow row in dgvHang.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                    cell.ErrorText = "";
            }
        }

        private void dgvHang_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dangTinh || e.RowIndex < 0) return;

            if (e.ColumnIndex == colSoLuong.Index ||
                e.ColumnIndex == colTrongLuong.Index ||
                e.ColumnIndex == colDonGia.Index)
            {
                TinhLai();
            }
        }

        private void dgvHang_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void TinhLai()
        {
            if (dangTinh) return;
            dangTinh = true;
            try
            {
                decimal tongSL = 0, tongTL = 0, tongTien = 0;

                foreach (DataGridViewRow row in dgvHang.Rows)
                {
                    decimal sl = LaySo(row, colSoLuong.Index);
                    decimal tl = LaySo(row, colTrongLuong.Index);
                    decimal dg = LaySo(row, colDonGia.Index);

                    decimal thanhTien = sl * dg;
                    row.Cells[colThanhTien.Index].Value = thanhTien;

                    tongSL += sl;
                    tongTL += sl * tl;
                    tongTien += thanhTien;
                }

                tsslTongSL.Text = "Tổng số lượng: " + tongSL.ToString("N0");
                tsslTongTL.Text = "Tổng trọng lượng: " + tongTL.ToString("N2") + " kg";
                tsslTongTien.Text = "Tổng tiền: " + tongTien.ToString("N0") + " VNĐ";
            }
            finally
            {
                dangTinh = false;
            }
        }

        private decimal LaySo(DataGridViewRow row, int cot)
        {
            object? v = row.Cells[cot].Value;
            if (v == null) return 0;
            if (v is decimal d) return d;
            if (v is int n) return n;

            string s = Convert.ToString(v, CultureInfo.CurrentCulture) ?? "";
            if (decimal.TryParse(s, NumberStyles.Number, CultureInfo.CurrentCulture, out decimal kq))
                return kq;
            return 0;
        }
    }
}