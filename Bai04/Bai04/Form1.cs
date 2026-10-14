using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Bai04
{
    public partial class frmDatBan : Form
    {
        private enum TrangThai { Trong, DangChon, DaDat }

        private const int SoHang = 4;
        private const int SoCot = 5;

        private static readonly Color MauTrong = Color.WhiteSmoke;
        private static readonly Color MauDangChon = Color.LimeGreen;
        private static readonly Color MauDaDat = Color.Red;

        private readonly decimal[] giaKhungGio = { 100000m, 150000m };

        private readonly string[] viTriDaDat = { "A2", "B4", "C1", "D3" };

        public frmDatBan()
        {
            InitializeComponent();
        }

        private void frmDatBan_Load(object sender, EventArgs e)
        {
            for (int h = 0; h < SoHang; h++)
            {
                for (int c = 0; c < SoCot; c++)
                {
                    string ten = ((char)('A' + h)).ToString() + (c + 1); // A1, A2, ..., D5

                    Button btn = new Button();
                    btn.Name = "btn" + ten;
                    btn.Text = ten;
                    btn.Dock = DockStyle.Fill;
                    btn.Margin = new Padding(4);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                    btn.Click += Ghe_Click;

                    bool daCoNguoi = Array.IndexOf(viTriDaDat, ten) >= 0;
                    DatTrangThai(btn, daCoNguoi ? TrangThai.DaDat : TrangThai.Trong);

                    tlpSoDo.Controls.Add(btn, c, h);
                }
            }

            cboKhungGio.SelectedIndex = 0;
            CapNhatThongKe();
        }

        private void Ghe_Click(object sender, EventArgs e)
        {
            if (sender is not Button btn) return;

            if (btn.Tag is TrangThai.DaDat)
            {
                MessageBox.Show("Vị trí " + btn.Text + " đã có người đặt / đã bị khóa!",
                                "Không thể chọn", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (btn.Tag is TrangThai.DangChon)
                DatTrangThai(btn, TrangThai.Trong);
            else
                DatTrangThai(btn, TrangThai.DangChon);

            CapNhatThongKe();
        }

        private void cboKhungGio_SelectedIndexChanged(object sender, EventArgs e)
        {
            CapNhatThongKe();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            int soLuong = DemDangChon();
            if (soLuong == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một vị trí!",
                                "Chưa chọn vị trí", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Khung giờ: " + cboKhungGio.Text);
            sb.AppendLine("Vị trí đã chọn: " + LayDanhSachDangChon());
            sb.AppendLine("Số lượng: " + soLuong);
            sb.AppendLine("Tổng tiền: " + TinhTien(soLuong).ToString("N0") + " VNĐ");
            sb.AppendLine();
            sb.Append("Bạn có chắc muốn đặt chỗ không?");

            DialogResult kq = MessageBox.Show(sb.ToString(), "Xác nhận đặt chỗ",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (kq != DialogResult.Yes) return;

            foreach (Control ctl in tlpSoDo.Controls)
            {
                if (ctl is Button btn && btn.Tag is TrangThai.DangChon)
                    DatTrangThai(btn, TrangThai.DaDat);
            }

            CapNhatThongKe();
            MessageBox.Show("Đặt chỗ thành công!", "Thông báo",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuyTatCa_Click(object sender, EventArgs e)
        {
            if (DemDangChon() == 0)
            {
                MessageBox.Show("Hiện chưa có vị trí nào đang chọn!", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (Control ctl in tlpSoDo.Controls)
            {
                if (ctl is Button btn && btn.Tag is TrangThai.DangChon)
                    DatTrangThai(btn, TrangThai.Trong);
            }
            CapNhatThongKe();
        }

        private void DatTrangThai(Button btn, TrangThai tt)
        {
            btn.Tag = tt;
            switch (tt)
            {
                case TrangThai.Trong:
                    btn.BackColor = MauTrong;
                    btn.ForeColor = Color.Black;
                    break;
                case TrangThai.DangChon:
                    btn.BackColor = MauDangChon;
                    btn.ForeColor = Color.Black;
                    break;
                case TrangThai.DaDat:
                    btn.BackColor = MauDaDat;
                    btn.ForeColor = Color.White;
                    break;
            }
        }

        private int DemDangChon()
        {
            int dem = 0;
            foreach (Control ctl in tlpSoDo.Controls)
            {
                if (ctl is Button btn && btn.Tag is TrangThai.DangChon)
                    dem++;
            }
            return dem;
        }

        private string LayDanhSachDangChon()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Control ctl in tlpSoDo.Controls)
            {
                if (ctl is Button btn && btn.Tag is TrangThai.DangChon)
                {
                    if (sb.Length > 0) sb.Append(", ");
                    sb.Append(btn.Text);
                }
            }
            return sb.ToString();
        }

        private decimal TinhTien(int soLuong)
        {
            int i = cboKhungGio.SelectedIndex;
            if (i < 0 || i >= giaKhungGio.Length) return 0;
            return soLuong * giaKhungGio[i];
        }

        private void CapNhatThongKe()
        {
            int soLuong = DemDangChon();
            lblSoViTri.Text = "Số vị trí đang chọn: " + soLuong;
            lblTamTinh.Text = "Tạm tính tiền: " + TinhTien(soLuong).ToString("N0") + " VNĐ";
        }
    }
}