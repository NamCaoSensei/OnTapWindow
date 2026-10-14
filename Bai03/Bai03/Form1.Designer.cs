namespace Bai03
{
    partial class frmVatTu
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
            this.grpNhap = new System.Windows.Forms.GroupBox();
            this.lblMaVT = new System.Windows.Forms.Label();
            this.txtMaVT = new System.Windows.Forms.TextBox();
            this.lblTenVT = new System.Windows.Forms.Label();
            this.txtTenVT = new System.Windows.Forms.TextBox();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.cboDonVi = new System.Windows.Forms.ComboBox();
            this.lblDonGia = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoaDong = new System.Windows.Forms.Button();
            this.btnXoaTatCa = new System.Windows.Forms.Button();
            this.grpDanhSach = new System.Windows.Forms.GroupBox();
            this.lvVatTu = new System.Windows.Forms.ListView();
            this.colMaVT = new System.Windows.Forms.ColumnHeader();
            this.colTenVT = new System.Windows.Forms.ColumnHeader();
            this.colDonVi = new System.Windows.Forms.ColumnHeader();
            this.colDonGia = new System.Windows.Forms.ColumnHeader();
            this.grpNhap.SuspendLayout();
            this.grpDanhSach.SuspendLayout();
            this.SuspendLayout();
            //
            // grpNhap
            //
            this.grpNhap.Controls.Add(this.lblMaVT);
            this.grpNhap.Controls.Add(this.txtMaVT);
            this.grpNhap.Controls.Add(this.lblTenVT);
            this.grpNhap.Controls.Add(this.txtTenVT);
            this.grpNhap.Controls.Add(this.lblDonVi);
            this.grpNhap.Controls.Add(this.cboDonVi);
            this.grpNhap.Controls.Add(this.lblDonGia);
            this.grpNhap.Controls.Add(this.txtDonGia);
            this.grpNhap.Controls.Add(this.btnThem);
            this.grpNhap.Controls.Add(this.btnCapNhat);
            this.grpNhap.Controls.Add(this.btnXoaDong);
            this.grpNhap.Controls.Add(this.btnXoaTatCa);
            this.grpNhap.Location = new System.Drawing.Point(15, 12);
            this.grpNhap.Name = "grpNhap";
            this.grpNhap.Size = new System.Drawing.Size(340, 305);
            this.grpNhap.TabIndex = 0;
            this.grpNhap.TabStop = false;
            this.grpNhap.Text = "Thông tin vật tư";
            //
            // lblMaVT
            //
            this.lblMaVT.AutoSize = true;
            this.lblMaVT.Location = new System.Drawing.Point(20, 38);
            this.lblMaVT.Name = "lblMaVT";
            this.lblMaVT.TabIndex = 0;
            this.lblMaVT.Text = "Mã vật tư:";
            //
            // txtMaVT
            //
            this.txtMaVT.Location = new System.Drawing.Point(130, 35);
            this.txtMaVT.Name = "txtMaVT";
            this.txtMaVT.Size = new System.Drawing.Size(190, 23);
            this.txtMaVT.TabIndex = 1;
            //
            // lblTenVT
            //
            this.lblTenVT.AutoSize = true;
            this.lblTenVT.Location = new System.Drawing.Point(20, 78);
            this.lblTenVT.Name = "lblTenVT";
            this.lblTenVT.TabIndex = 2;
            this.lblTenVT.Text = "Tên vật tư:";
            //
            // txtTenVT
            //
            this.txtTenVT.Location = new System.Drawing.Point(130, 75);
            this.txtTenVT.Name = "txtTenVT";
            this.txtTenVT.Size = new System.Drawing.Size(190, 23);
            this.txtTenVT.TabIndex = 3;
            //
            // lblDonVi
            //
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Location = new System.Drawing.Point(20, 118);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.TabIndex = 4;
            this.lblDonVi.Text = "Đơn vị tính:";
            //
            // cboDonVi
            //
            this.cboDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonVi.FormattingEnabled = true;
            this.cboDonVi.Items.AddRange(new object[] {
            "Cái",
            "Bộ",
            "Kg",
            "Mét"});
            this.cboDonVi.Location = new System.Drawing.Point(130, 115);
            this.cboDonVi.Name = "cboDonVi";
            this.cboDonVi.Size = new System.Drawing.Size(190, 23);
            this.cboDonVi.TabIndex = 5;
            //
            // lblDonGia
            //
            this.lblDonGia.AutoSize = true;
            this.lblDonGia.Location = new System.Drawing.Point(20, 158);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.TabIndex = 6;
            this.lblDonGia.Text = "Đơn giá nhập:";
            //
            // txtDonGia
            //
            this.txtDonGia.Location = new System.Drawing.Point(130, 155);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(190, 23);
            this.txtDonGia.TabIndex = 7;
            //
            // btnThem
            //
            this.btnThem.Location = new System.Drawing.Point(20, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(145, 36);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            //
            // btnCapNhat
            //
            this.btnCapNhat.Location = new System.Drawing.Point(175, 207);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(145, 36);
            this.btnCapNhat.TabIndex = 9;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            //
            // btnXoaDong
            //
            this.btnXoaDong.Location = new System.Drawing.Point(20, 254);
            this.btnXoaDong.Name = "btnXoaDong";
            this.btnXoaDong.Size = new System.Drawing.Size(145, 36);
            this.btnXoaDong.TabIndex = 10;
            this.btnXoaDong.Text = "Xóa dòng";
            this.btnXoaDong.UseVisualStyleBackColor = true;
            this.btnXoaDong.Click += new System.EventHandler(this.btnXoaDong_Click);
            //
            // btnXoaTatCa
            //
            this.btnXoaTatCa.Location = new System.Drawing.Point(175, 254);
            this.btnXoaTatCa.Name = "btnXoaTatCa";
            this.btnXoaTatCa.Size = new System.Drawing.Size(145, 36);
            this.btnXoaTatCa.TabIndex = 11;
            this.btnXoaTatCa.Text = "Xóa toàn bộ";
            this.btnXoaTatCa.UseVisualStyleBackColor = true;
            this.btnXoaTatCa.Click += new System.EventHandler(this.btnXoaTatCa_Click);
            //
            // grpDanhSach
            //
            this.grpDanhSach.Controls.Add(this.lvVatTu);
            this.grpDanhSach.Location = new System.Drawing.Point(365, 12);
            this.grpDanhSach.Name = "grpDanhSach";
            this.grpDanhSach.Size = new System.Drawing.Size(520, 305);
            this.grpDanhSach.TabIndex = 1;
            this.grpDanhSach.TabStop = false;
            this.grpDanhSach.Text = "Danh sách vật tư";
            //
            // lvVatTu
            //
            this.lvVatTu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaVT,
            this.colTenVT,
            this.colDonVi,
            this.colDonGia});
            this.lvVatTu.FullRowSelect = true;
            this.lvVatTu.GridLines = true;
            this.lvVatTu.HideSelection = false;
            this.lvVatTu.Location = new System.Drawing.Point(15, 25);
            this.lvVatTu.MultiSelect = false;
            this.lvVatTu.Name = "lvVatTu";
            this.lvVatTu.Size = new System.Drawing.Size(490, 265);
            this.lvVatTu.TabIndex = 0;
            this.lvVatTu.UseCompatibleStateImageBehavior = false;
            this.lvVatTu.View = System.Windows.Forms.View.Details;
            this.lvVatTu.SelectedIndexChanged += new System.EventHandler(this.lvVatTu_SelectedIndexChanged);
            //
            // colMaVT
            //
            this.colMaVT.Text = "Mã VT";
            this.colMaVT.Width = 90;
            //
            // colTenVT
            //
            this.colTenVT.Text = "Tên VT";
            this.colTenVT.Width = 180;
            //
            // colDonVi
            //
            this.colDonVi.Text = "Đơn vị tính";
            this.colDonVi.Width = 100;
            //
            // colDonGia
            //
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.colDonGia.Width = 100;
            //
            // frmVatTu
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 332);
            this.Controls.Add(this.grpNhap);
            this.Controls.Add(this.grpDanhSach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmVatTu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý danh mục vật tư / linh kiện";
            this.grpNhap.ResumeLayout(false);
            this.grpNhap.PerformLayout();
            this.grpDanhSach.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhap;
        private System.Windows.Forms.Label lblMaVT;
        private System.Windows.Forms.TextBox txtMaVT;
        private System.Windows.Forms.Label lblTenVT;
        private System.Windows.Forms.TextBox txtTenVT;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.ComboBox cboDonVi;
        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoaDong;
        private System.Windows.Forms.Button btnXoaTatCa;
        private System.Windows.Forms.GroupBox grpDanhSach;
        private System.Windows.Forms.ListView lvVatTu;
        private System.Windows.Forms.ColumnHeader colMaVT;
        private System.Windows.Forms.ColumnHeader colTenVT;
        private System.Windows.Forms.ColumnHeader colDonVi;
        private System.Windows.Forms.ColumnHeader colDonGia;
    }
}