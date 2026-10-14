using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai02
{
    public partial class frmSuCo : Form
    {
        private string duongDanAnh = "";

        public frmSuCo()
        {
            InitializeComponent();
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh chụp lỗi";
                ofd.Filter = "Tệp hình ảnh (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";

                if (ofd.ShowDialog() != DialogResult.OK)
                    return;

                try
                {
                    if (picAnhLoi.Image != null)
                    {
                        picAnhLoi.Image.Dispose();
                        picAnhLoi.Image = null;
                    }

                    using (Image tam = Image.FromFile(ofd.FileName))
                    {
                        picAnhLoi.Image = new Bitmap(tam);
                    }
                    picAnhLoi.SizeMode = PictureBoxSizeMode.StretchImage;
                    duongDanAnh = ofd.FileName;
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thể mở tệp ảnh này. Vui lòng chọn tệp .jpg hoặc .png hợp lệ!",
                                    "Lỗi tải ảnh", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnGuiYeuCau_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMaPhieu.Text))
            {
                BaoLoi("Vui lòng nhập mã phiếu!", txtMaPhieu);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNguoiYeuCau.Text))
            {
                BaoLoi("Vui lòng nhập tên người yêu cầu!", txtNguoiYeuCau);
                return;
            }
            if (cboLoaiSuCo.SelectedIndex < 0)
            {
                BaoLoi("Vui lòng chọn loại sự cố!", cboLoaiSuCo);
                return;
            }

            string mucDo;
            if (rdoThap.Checked) mucDo = "Thấp";
            else if (rdoKhanCap.Checked) mucDo = "Khẩn cấp";
            else mucDo = "Trung bình";

            List<string> dsThietBi = new List<string>();
            if (chkMayTinhBan.Checked) dsThietBi.Add(chkMayTinhBan.Text);
            if (chkLaptop.Checked) dsThietBi.Add(chkLaptop.Text);
            if (chkMayIn.Checked) dsThietBi.Add(chkMayIn.Text);
            if (chkDienThoai.Checked) dsThietBi.Add(chkDienThoai.Text);

            if (dsThietBi.Count == 0)
            {
                BaoLoi("Vui lòng chọn ít nhất một thiết bị bị ảnh hưởng!", chkMayTinhBan);
                return;
            }

            string anh = (picAnhLoi.Image == null)
                ? "Không đính kèm"
                : System.IO.Path.GetFileName(duongDanAnh);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Mã phiếu: " + txtMaPhieu.Text.Trim());
            sb.AppendLine("Người yêu cầu: " + txtNguoiYeuCau.Text.Trim());
            sb.AppendLine("Ngày ghi nhận: " + dtpNgayGhiNhan.Value.ToString("dd/MM/yyyy"));
            sb.AppendLine("Mức độ ưu tiên: " + mucDo);
            sb.AppendLine("Loại sự cố: " + cboLoaiSuCo.SelectedItem?.ToString());
            sb.AppendLine("Thiết bị ảnh hưởng: " + string.Join(", ", dsThietBi));
            sb.AppendLine("Ảnh chụp lỗi: " + anh);

            MessageBox.Show(sb.ToString(), "Tóm tắt phiếu sự cố",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnNhapLai_Click(object sender, EventArgs e)
        {
            txtMaPhieu.Clear();
            txtNguoiYeuCau.Clear();
            dtpNgayGhiNhan.Value = DateTime.Now;
            rdoTrungBinh.Checked = true;
            cboLoaiSuCo.SelectedIndex = -1;

            chkMayTinhBan.Checked = false;
            chkLaptop.Checked = false;
            chkMayIn.Checked = false;
            chkDienThoai.Checked = false;

            if (picAnhLoi.Image != null)
            {
                picAnhLoi.Image.Dispose();
                picAnhLoi.Image = null;
            }
            duongDanAnh = "";

            txtMaPhieu.Focus();
        }

        private void BaoLoi(string thongBao, Control c)
        {
            MessageBox.Show(thongBao, "Thiếu thông tin",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            c.Focus();
        }
    }
}