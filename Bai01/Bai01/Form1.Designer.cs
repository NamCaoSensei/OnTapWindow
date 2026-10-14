namespace Bai01
{
    partial class frmTinhCuoc
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
            lblDonGia = new Label();
            txtDonGia = new TextBox();
            lblSoLuong = new Label();
            txtSoLuong = new TextBox();
            lblGiamGia = new Label();
            txtGiamGia = new TextBox();
            btnTinhTien = new Button();
            btnLamMoi = new Button();
            lblTieuDeKQ = new Label();
            lblKetQua = new Label();
            SuspendLayout();
            // 
            // lblDonGia
            // 
            lblDonGia.AutoSize = true;
            lblDonGia.Location = new Point(30, 41);
            lblDonGia.Name = "lblDonGia";
            lblDonGia.Size = new Size(161, 20);
            lblDonGia.TabIndex = 0;
            lblDonGia.Text = "Đơn giá dịch vụ (VNĐ):";
            // 
            // txtDonGia
            // 
            txtDonGia.Location = new Point(200, 38);
            txtDonGia.Margin = new Padding(3, 4, 3, 4);
            txtDonGia.Name = "txtDonGia";
            txtDonGia.Size = new Size(190, 27);
            txtDonGia.TabIndex = 1;
            // 
            // lblSoLuong
            // 
            lblSoLuong.AutoSize = true;
            lblSoLuong.Location = new Point(30, 91);
            lblSoLuong.Name = "lblSoLuong";
            lblSoLuong.Size = new Size(114, 20);
            lblSoLuong.TabIndex = 2;
            lblSoLuong.Text = "Số lượng khách:";
            // 
            // txtSoLuong
            // 
            txtSoLuong.Location = new Point(200, 88);
            txtSoLuong.Margin = new Padding(3, 4, 3, 4);
            txtSoLuong.Name = "txtSoLuong";
            txtSoLuong.Size = new Size(190, 27);
            txtSoLuong.TabIndex = 3;
            // 
            // lblGiamGia
            // 
            lblGiamGia.AutoSize = true;
            lblGiamGia.Location = new Point(30, 141);
            lblGiamGia.Name = "lblGiamGia";
            lblGiamGia.Size = new Size(98, 20);
            lblGiamGia.TabIndex = 4;
            lblGiamGia.Text = "Giảm giá (%):";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(200, 138);
            txtGiamGia.Margin = new Padding(3, 4, 3, 4);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(190, 27);
            txtGiamGia.TabIndex = 5;
            // 
            // btnTinhTien
            // 
            btnTinhTien.Location = new Point(80, 200);
            btnTinhTien.Margin = new Padding(3, 4, 3, 4);
            btnTinhTien.Name = "btnTinhTien";
            btnTinhTien.Size = new Size(110, 45);
            btnTinhTien.TabIndex = 6;
            btnTinhTien.Text = "Tính tiền";
            btnTinhTien.UseVisualStyleBackColor = true;
            btnTinhTien.Click += btnTinhTien_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(220, 200);
            btnLamMoi.Margin = new Padding(3, 4, 3, 4);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 45);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTieuDeKQ
            // 
            lblTieuDeKQ.AutoSize = true;
            lblTieuDeKQ.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold);
            lblTieuDeKQ.Location = new Point(7, 287);
            lblTieuDeKQ.Name = "lblTieuDeKQ";
            lblTieuDeKQ.Size = new Size(187, 20);
            lblTieuDeKQ.TabIndex = 8;
            lblTieuDeKQ.Text = "Tổng tiền thanh toán:";
            // 
            // lblKetQua
            // 
            lblKetQua.BorderStyle = BorderStyle.FixedSingle;
            lblKetQua.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold);
            lblKetQua.ForeColor = Color.Red;
            lblKetQua.Location = new Point(200, 271);
            lblKetQua.Name = "lblKetQua";
            lblKetQua.Size = new Size(190, 47);
            lblKetQua.TabIndex = 9;
            lblKetQua.Text = "0 VNĐ";
            lblKetQua.TextAlign = ContentAlignment.MiddleRight;
            // 
            // frmTinhCuoc
            // 
            AcceptButton = btnTinhTien;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnLamMoi;
            ClientSize = new Size(420, 350);
            Controls.Add(lblDonGia);
            Controls.Add(txtDonGia);
            Controls.Add(lblSoLuong);
            Controls.Add(txtSoLuong);
            Controls.Add(lblGiamGia);
            Controls.Add(txtGiamGia);
            Controls.Add(btnTinhTien);
            Controls.Add(btnLamMoi);
            Controls.Add(lblTieuDeKQ);
            Controls.Add(lblKetQua);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "frmTinhCuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tính cước dịch vụ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblDonGia;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label lblGiamGia;
        private System.Windows.Forms.TextBox txtGiamGia;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTieuDeKQ;
        private System.Windows.Forms.Label lblKetQua;
    }
}