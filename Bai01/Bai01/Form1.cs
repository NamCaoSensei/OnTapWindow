using System;
using System.Globalization;
using System.Windows.Forms;

namespace Bai01
{
    public partial class frmTinhCuoc : Form
    {
        public frmTinhCuoc()
        {
            InitializeComponent();
        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDonGia.Text))
            {
                BaoLoi("Vui lòng nhập đơn giá dịch vụ!", txtDonGia);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtSoLuong.Text))
            {
                BaoLoi("Vui lòng nhập số lượng khách!", txtSoLuong);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtGiamGia.Text))
            {
                BaoLoi("Vui lòng nhập % giảm giá (nhập 0 nếu không giảm)!", txtGiamGia);
                return;
            }

            if (!decimal.TryParse(txtDonGia.Text.Trim(), NumberStyles.Number,
                                  CultureInfo.CurrentCulture, out decimal donGia))
            {
                BaoLoi("Đơn giá phải là số, không được nhập chữ hoặc ký tự đặc biệt!", txtDonGia);
                return;
            }
            if (!int.TryParse(txtSoLuong.Text.Trim(), out int soLuong))
            {
                BaoLoi("Số lượng khách phải là số nguyên!", txtSoLuong);
                return;
            }
            if (!decimal.TryParse(txtGiamGia.Text.Trim(), NumberStyles.Number,
                                  CultureInfo.CurrentCulture, out decimal phanTramGiam))
            {
                BaoLoi("% giảm giá phải là số!", txtGiamGia);
                return;
            }

            if (donGia <= 0)
            {
                BaoLoi("Đơn giá phải lớn hơn 0!", txtDonGia);
                return;
            }
            if (soLuong <= 0)
            {
                BaoLoi("Số lượng khách phải lớn hơn 0!", txtSoLuong);
                return;
            }
            if (phanTramGiam < 0 || phanTramGiam > 100)
            {
                BaoLoi("% giảm giá phải nằm trong khoảng từ 0 đến 100!", txtGiamGia);
                return;
            }

            decimal tongTien = (donGia * soLuong) * ((100 - phanTramGiam) / 100);

            lblKetQua.Text = tongTien.ToString("N0") + " VNĐ";
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDonGia.Clear();
            txtSoLuong.Clear();
            txtGiamGia.Clear();
            lblKetQua.Text = "0 VNĐ";
            txtDonGia.Focus();
        }

        private void BaoLoi(string thongBao, TextBox o)
        {
            MessageBox.Show(thongBao, "Lỗi nhập liệu",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
            o.Focus();
            o.SelectAll();
        }
    }
}