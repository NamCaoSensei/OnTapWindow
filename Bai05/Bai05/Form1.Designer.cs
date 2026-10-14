namespace Bai05
{
    partial class frmDonHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            splitContainer1 = new SplitContainer();
            tabThongTin = new TabControl();
            tabKhachHang = new TabPage();
            lblHoTen = new Label();
            txtHoTen = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblDiaChi = new Label();
            txtDiaChi = new TextBox();
            tabVanChuyen = new TabPage();
            lblLoaiVC = new Label();
            cboLoaiVanChuyen = new ComboBox();
            lblGhiChu = new Label();
            txtGhiChu = new TextBox();
            pnlLuoi = new Panel();
            dgvHang = new DataGridView();
            colTenHang = new DataGridViewTextBoxColumn();
            colSoLuong = new DataGridViewTextBoxColumn();
            colTrongLuong = new DataGridViewTextBoxColumn();
            colDonGia = new DataGridViewTextBoxColumn();
            colThanhTien = new DataGridViewTextBoxColumn();
            pnlNut = new Panel();
            btnThemDong = new Button();
            btnXoaDong = new Button();
            statusStrip1 = new StatusStrip();
            tsslThoiGian = new ToolStripStatusLabel();
            tsslTongSL = new ToolStripStatusLabel();
            tsslTongTL = new ToolStripStatusLabel();
            tsslTongTien = new ToolStripStatusLabel();
            tmrDongHo = new System.Windows.Forms.Timer(components);
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tabThongTin.SuspendLayout();
            tabKhachHang.SuspendLayout();
            tabVanChuyen.SuspendLayout();
            pnlLuoi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHang).BeginInit();
            pnlNut.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tabThongTin);
            splitContainer1.Panel1MinSize = 260;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pnlLuoi);
            splitContainer1.Panel2.Controls.Add(pnlNut);
            splitContainer1.Size = new Size(1143, 717);
            splitContainer1.SplitterDistance = 343;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // tabThongTin
            // 
            tabThongTin.Controls.Add(tabKhachHang);
            tabThongTin.Controls.Add(tabVanChuyen);
            tabThongTin.Dock = DockStyle.Fill;
            tabThongTin.Location = new Point(0, 0);
            tabThongTin.Margin = new Padding(3, 4, 3, 4);
            tabThongTin.Name = "tabThongTin";
            tabThongTin.SelectedIndex = 0;
            tabThongTin.Size = new Size(343, 717);
            tabThongTin.TabIndex = 0;
            // 
            // tabKhachHang
            // 
            tabKhachHang.Controls.Add(lblHoTen);
            tabKhachHang.Controls.Add(txtHoTen);
            tabKhachHang.Controls.Add(lblSDT);
            tabKhachHang.Controls.Add(txtSDT);
            tabKhachHang.Controls.Add(lblDiaChi);
            tabKhachHang.Controls.Add(txtDiaChi);
            tabKhachHang.Location = new Point(4, 29);
            tabKhachHang.Margin = new Padding(3, 4, 3, 4);
            tabKhachHang.Name = "tabKhachHang";
            tabKhachHang.Padding = new Padding(3, 4, 3, 4);
            tabKhachHang.Size = new Size(335, 684);
            tabKhachHang.TabIndex = 0;
            tabKhachHang.Text = "Khách hàng";
            tabKhachHang.UseVisualStyleBackColor = true;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(17, 27);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(136, 20);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên khách hàng:";
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtHoTen.Location = new Point(17, 56);
            txtHoTen.Margin = new Padding(3, 4, 3, 4);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(299, 27);
            txtHoTen.TabIndex = 1;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(17, 109);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(100, 20);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtSDT.Location = new Point(17, 139);
            txtSDT.Margin = new Padding(3, 4, 3, 4);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(299, 27);
            txtSDT.TabIndex = 3;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Location = new Point(17, 192);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(129, 20);
            lblDiaChi.TabIndex = 4;
            lblDiaChi.Text = "Địa chỉ giao hàng:";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtDiaChi.Location = new Point(17, 221);
            txtDiaChi.Margin = new Padding(3, 4, 3, 4);
            txtDiaChi.Multiline = true;
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(299, 105);
            txtDiaChi.TabIndex = 5;
            // 
            // tabVanChuyen
            // 
            tabVanChuyen.Controls.Add(lblLoaiVC);
            tabVanChuyen.Controls.Add(cboLoaiVanChuyen);
            tabVanChuyen.Controls.Add(lblGhiChu);
            tabVanChuyen.Controls.Add(txtGhiChu);
            tabVanChuyen.Location = new Point(4, 29);
            tabVanChuyen.Margin = new Padding(3, 4, 3, 4);
            tabVanChuyen.Name = "tabVanChuyen";
            tabVanChuyen.Padding = new Padding(3, 4, 3, 4);
            tabVanChuyen.Size = new Size(335, 684);
            tabVanChuyen.TabIndex = 1;
            tabVanChuyen.Text = "Vận chuyển";
            tabVanChuyen.UseVisualStyleBackColor = true;
            // 
            // lblLoaiVC
            // 
            lblLoaiVC.AutoSize = true;
            lblLoaiVC.Location = new Point(17, 27);
            lblLoaiVC.Name = "lblLoaiVC";
            lblLoaiVC.Size = new Size(117, 20);
            lblLoaiVC.TabIndex = 0;
            lblLoaiVC.Text = "Loại vận chuyển:";
            // 
            // cboLoaiVanChuyen
            // 
            cboLoaiVanChuyen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboLoaiVanChuyen.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiVanChuyen.FormattingEnabled = true;
            cboLoaiVanChuyen.Items.AddRange(new object[] { "Tiêu chuẩn", "Nhanh", "Hỏa tốc" });
            cboLoaiVanChuyen.Location = new Point(17, 56);
            cboLoaiVanChuyen.Margin = new Padding(3, 4, 3, 4);
            cboLoaiVanChuyen.Name = "cboLoaiVanChuyen";
            cboLoaiVanChuyen.Size = new Size(299, 28);
            cboLoaiVanChuyen.TabIndex = 1;
            // 
            // lblGhiChu
            // 
            lblGhiChu.AutoSize = true;
            lblGhiChu.Location = new Point(17, 109);
            lblGhiChu.Name = "lblGhiChu";
            lblGhiChu.Size = new Size(138, 20);
            lblGhiChu.TabIndex = 2;
            lblGhiChu.Text = "Ghi chú vận chuyển:";
            // 
            // txtGhiChu
            // 
            txtGhiChu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtGhiChu.Location = new Point(17, 139);
            txtGhiChu.Margin = new Padding(3, 4, 3, 4);
            txtGhiChu.Multiline = true;
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(299, 132);
            txtGhiChu.TabIndex = 3;
            // 
            // pnlLuoi
            // 
            pnlLuoi.Controls.Add(dgvHang);
            pnlLuoi.Dock = DockStyle.Fill;
            pnlLuoi.Location = new Point(0, 60);
            pnlLuoi.Margin = new Padding(3, 4, 3, 4);
            pnlLuoi.Name = "pnlLuoi";
            pnlLuoi.Padding = new Padding(6, 0, 34, 7);
            pnlLuoi.Size = new Size(795, 657);
            pnlLuoi.TabIndex = 1;
            // 
            // dgvHang
            // 
            dgvHang.AllowUserToAddRows = false;
            dgvHang.AllowUserToDeleteRows = false;
            dgvHang.AllowUserToResizeRows = false;
            dgvHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHang.BackgroundColor = SystemColors.Window;
            dgvHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHang.Columns.AddRange(new DataGridViewColumn[] { colTenHang, colSoLuong, colTrongLuong, colDonGia, colThanhTien });
            dgvHang.Dock = DockStyle.Fill;
            dgvHang.EditMode = DataGridViewEditMode.EditOnKeystroke;
            dgvHang.Location = new Point(6, 0);
            dgvHang.Margin = new Padding(3, 4, 3, 4);
            dgvHang.MultiSelect = false;
            dgvHang.Name = "dgvHang";
            dgvHang.RowHeadersWidth = 45;
            dgvHang.Size = new Size(755, 650);
            dgvHang.TabIndex = 0;
            dgvHang.CellValidating += dgvHang_CellValidating;
            dgvHang.CellValueChanged += dgvHang_CellValueChanged;
            dgvHang.DataError += dgvHang_DataError;
            // 
            // colTenHang
            // 
            colTenHang.FillWeight = 32F;
            colTenHang.HeaderText = "Tên hàng";
            colTenHang.MinimumWidth = 6;
            colTenHang.Name = "colTenHang";
            // 
            // colSoLuong
            // 
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Format = "N0";
            colSoLuong.DefaultCellStyle = dataGridViewCellStyle1;
            colSoLuong.FillWeight = 12F;
            colSoLuong.HeaderText = "Số lượng";
            colSoLuong.MinimumWidth = 6;
            colSoLuong.Name = "colSoLuong";
            // 
            // colTrongLuong
            // 
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            colTrongLuong.DefaultCellStyle = dataGridViewCellStyle2;
            colTrongLuong.FillWeight = 16F;
            colTrongLuong.HeaderText = "Trọng lượng (kg)";
            colTrongLuong.MinimumWidth = 6;
            colTrongLuong.Name = "colTrongLuong";
            // 
            // colDonGia
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            colDonGia.DefaultCellStyle = dataGridViewCellStyle3;
            colDonGia.FillWeight = 20F;
            colDonGia.HeaderText = "Đơn giá";
            colDonGia.MinimumWidth = 6;
            colDonGia.Name = "colDonGia";
            // 
            // colThanhTien
            // 
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle4.Format = "N0";
            colThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            colThanhTien.FillWeight = 22F;
            colThanhTien.HeaderText = "Thành tiền";
            colThanhTien.MinimumWidth = 6;
            colThanhTien.Name = "colThanhTien";
            colThanhTien.ReadOnly = true;
            // 
            // pnlNut
            // 
            pnlNut.Controls.Add(btnThemDong);
            pnlNut.Controls.Add(btnXoaDong);
            pnlNut.Dock = DockStyle.Top;
            pnlNut.Location = new Point(0, 0);
            pnlNut.Margin = new Padding(3, 4, 3, 4);
            pnlNut.Name = "pnlNut";
            pnlNut.Size = new Size(795, 60);
            pnlNut.TabIndex = 0;
            // 
            // btnThemDong
            // 
            btnThemDong.Location = new Point(9, 8);
            btnThemDong.Margin = new Padding(3, 4, 3, 4);
            btnThemDong.Name = "btnThemDong";
            btnThemDong.Size = new Size(171, 43);
            btnThemDong.TabIndex = 0;
            btnThemDong.Text = "Thêm dòng (F2)";
            btnThemDong.UseVisualStyleBackColor = true;
            btnThemDong.Click += btnThemDong_Click;
            // 
            // btnXoaDong
            // 
            btnXoaDong.Location = new Point(192, 8);
            btnXoaDong.Margin = new Padding(3, 4, 3, 4);
            btnXoaDong.Name = "btnXoaDong";
            btnXoaDong.Size = new Size(171, 43);
            btnXoaDong.TabIndex = 1;
            btnXoaDong.Text = "Xóa dòng (Delete)";
            btnXoaDong.UseVisualStyleBackColor = true;
            btnXoaDong.Click += btnXoaDong_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { tsslThoiGian, tsslTongSL, tsslTongTL, tsslTongTien });
            statusStrip1.Location = new Point(0, 717);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 16, 0);
            statusStrip1.Size = new Size(1143, 30);
            statusStrip1.TabIndex = 1;
            // 
            // tsslThoiGian
            // 
            tsslThoiGian.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tsslThoiGian.Name = "tsslThoiGian";
            tsslThoiGian.Padding = new Padding(0, 0, 10, 0);
            tsslThoiGian.Size = new Size(92, 24);
            tsslThoiGian.Text = "Thời gian: ";
            // 
            // tsslTongSL
            // 
            tsslTongSL.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tsslTongSL.Name = "tsslTongSL";
            tsslTongSL.Padding = new Padding(0, 0, 10, 0);
            tsslTongSL.Size = new Size(134, 24);
            tsslTongSL.Text = "Tổng số lượng: 0";
            // 
            // tsslTongTL
            // 
            tsslTongTL.BorderSides = ToolStripStatusLabelBorderSides.Right;
            tsslTongTL.Name = "tsslTongTL";
            tsslTongTL.Padding = new Padding(0, 0, 10, 0);
            tsslTongTL.Size = new Size(175, 24);
            tsslTongTL.Text = "Tổng trọng lượng: 0 kg";
            // 
            // tsslTongTien
            // 
            tsslTongTien.Name = "tsslTongTien";
            tsslTongTien.Size = new Size(122, 24);
            tsslTongTien.Text = "Tổng tiền: 0 VNĐ";
            // 
            // tmrDongHo
            // 
            tmrDongHo.Enabled = true;
            tmrDongHo.Interval = 1000;
            tmrDongHo.Tick += tmrDongHo_Tick;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // frmDonHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 747);
            Controls.Add(splitContainer1);
            Controls.Add(statusStrip1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(935, 651);
            Name = "frmDonHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Bảng điều khiển quản lý đơn giao hàng";
            Load += frmDonHang_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tabThongTin.ResumeLayout(false);
            tabKhachHang.ResumeLayout(false);
            tabKhachHang.PerformLayout();
            tabVanChuyen.ResumeLayout(false);
            tabVanChuyen.PerformLayout();
            pnlLuoi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHang).EndInit();
            pnlNut.ResumeLayout(false);
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TabControl tabThongTin;
        private System.Windows.Forms.TabPage tabKhachHang;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TabPage tabVanChuyen;
        private System.Windows.Forms.Label lblLoaiVC;
        private System.Windows.Forms.ComboBox cboLoaiVanChuyen;
        private System.Windows.Forms.Label lblGhiChu;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Panel pnlLuoi;
        private System.Windows.Forms.DataGridView dgvHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTrongLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colThanhTien;
        private System.Windows.Forms.Panel pnlNut;
        private System.Windows.Forms.Button btnThemDong;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslThoiGian;
        private System.Windows.Forms.ToolStripStatusLabel tsslTongSL;
        private System.Windows.Forms.ToolStripStatusLabel tsslTongTL;
        private System.Windows.Forms.ToolStripStatusLabel tsslTongTien;
        private System.Windows.Forms.Timer tmrDongHo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}