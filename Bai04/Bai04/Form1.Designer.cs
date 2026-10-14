namespace Bai04
{
    partial class frmDatBan
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
            this.grpSoDo = new System.Windows.Forms.GroupBox();
            this.tlpSoDo = new System.Windows.Forms.TableLayoutPanel();
            this.lblChuThichTrong = new System.Windows.Forms.Label();
            this.lblChuThichChon = new System.Windows.Forms.Label();
            this.lblChuThichDaDat = new System.Windows.Forms.Label();
            this.grpThongTin = new System.Windows.Forms.GroupBox();
            this.lblKhungGio = new System.Windows.Forms.Label();
            this.cboKhungGio = new System.Windows.Forms.ComboBox();
            this.lblSoViTri = new System.Windows.Forms.Label();
            this.lblTamTinh = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuyTatCa = new System.Windows.Forms.Button();
            this.grpSoDo.SuspendLayout();
            this.grpThongTin.SuspendLayout();
            this.SuspendLayout();
            //
            // grpSoDo
            //
            this.grpSoDo.Controls.Add(this.tlpSoDo);
            this.grpSoDo.Controls.Add(this.lblChuThichTrong);
            this.grpSoDo.Controls.Add(this.lblChuThichChon);
            this.grpSoDo.Controls.Add(this.lblChuThichDaDat);
            this.grpSoDo.Location = new System.Drawing.Point(15, 12);
            this.grpSoDo.Name = "grpSoDo";
            this.grpSoDo.Size = new System.Drawing.Size(510, 400);
            this.grpSoDo.TabIndex = 0;
            this.grpSoDo.TabStop = false;
            this.grpSoDo.Text = "Sơ đồ chỗ ngồi (4 hàng x 5 cột)";
            //
            // tlpSoDo  (các Button được sinh bằng code trong Form_Load)
            //
            this.tlpSoDo.ColumnCount = 5;
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSoDo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpSoDo.Location = new System.Drawing.Point(15, 25);
            this.tlpSoDo.Name = "tlpSoDo";
            this.tlpSoDo.RowCount = 4;
            this.tlpSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSoDo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpSoDo.Size = new System.Drawing.Size(480, 320);
            this.tlpSoDo.TabIndex = 0;
            //
            // lblChuThichTrong
            //
            this.lblChuThichTrong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblChuThichTrong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChuThichTrong.Location = new System.Drawing.Point(15, 360);
            this.lblChuThichTrong.Name = "lblChuThichTrong";
            this.lblChuThichTrong.Size = new System.Drawing.Size(100, 26);
            this.lblChuThichTrong.TabIndex = 1;
            this.lblChuThichTrong.Text = "Trống";
            this.lblChuThichTrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblChuThichChon
            //
            this.lblChuThichChon.BackColor = System.Drawing.Color.LimeGreen;
            this.lblChuThichChon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChuThichChon.Location = new System.Drawing.Point(130, 360);
            this.lblChuThichChon.Name = "lblChuThichChon";
            this.lblChuThichChon.Size = new System.Drawing.Size(100, 26);
            this.lblChuThichChon.TabIndex = 2;
            this.lblChuThichChon.Text = "Đang chọn";
            this.lblChuThichChon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // lblChuThichDaDat
            //
            this.lblChuThichDaDat.BackColor = System.Drawing.Color.Red;
            this.lblChuThichDaDat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblChuThichDaDat.ForeColor = System.Drawing.Color.White;
            this.lblChuThichDaDat.Location = new System.Drawing.Point(245, 360);
            this.lblChuThichDaDat.Name = "lblChuThichDaDat";
            this.lblChuThichDaDat.Size = new System.Drawing.Size(100, 26);
            this.lblChuThichDaDat.TabIndex = 3;
            this.lblChuThichDaDat.Text = "Đã khóa";
            this.lblChuThichDaDat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // grpThongTin
            //
            this.grpThongTin.Controls.Add(this.lblKhungGio);
            this.grpThongTin.Controls.Add(this.cboKhungGio);
            this.grpThongTin.Controls.Add(this.lblSoViTri);
            this.grpThongTin.Controls.Add(this.lblTamTinh);
            this.grpThongTin.Controls.Add(this.btnXacNhan);
            this.grpThongTin.Controls.Add(this.btnHuyTatCa);
            this.grpThongTin.Location = new System.Drawing.Point(540, 12);
            this.grpThongTin.Name = "grpThongTin";
            this.grpThongTin.Size = new System.Drawing.Size(205, 400);
            this.grpThongTin.TabIndex = 1;
            this.grpThongTin.TabStop = false;
            this.grpThongTin.Text = "Thông tin đặt chỗ";
            //
            // lblKhungGio
            //
            this.lblKhungGio.AutoSize = true;
            this.lblKhungGio.Location = new System.Drawing.Point(15, 35);
            this.lblKhungGio.Name = "lblKhungGio";
            this.lblKhungGio.TabIndex = 0;
            this.lblKhungGio.Text = "Khung giờ:";
            //
            // cboKhungGio
            //
            this.cboKhungGio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKhungGio.FormattingEnabled = true;
            this.cboKhungGio.Items.AddRange(new object[] {
            "Sáng - 100.000đ",
            "Tối - 150.000đ"});
            this.cboKhungGio.Location = new System.Drawing.Point(15, 58);
            this.cboKhungGio.Name = "cboKhungGio";
            this.cboKhungGio.Size = new System.Drawing.Size(175, 23);
            this.cboKhungGio.TabIndex = 1;
            this.cboKhungGio.SelectedIndexChanged += new System.EventHandler(this.cboKhungGio_SelectedIndexChanged);
            //
            // lblSoViTri
            //
            this.lblSoViTri.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSoViTri.Location = new System.Drawing.Point(15, 105);
            this.lblSoViTri.Name = "lblSoViTri";
            this.lblSoViTri.Size = new System.Drawing.Size(175, 50);
            this.lblSoViTri.TabIndex = 2;
            this.lblSoViTri.Text = "Số vị trí đang chọn: 0";
            //
            // lblTamTinh
            //
            this.lblTamTinh.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTamTinh.ForeColor = System.Drawing.Color.Red;
            this.lblTamTinh.Location = new System.Drawing.Point(15, 165);
            this.lblTamTinh.Name = "lblTamTinh";
            this.lblTamTinh.Size = new System.Drawing.Size(175, 50);
            this.lblTamTinh.TabIndex = 3;
            this.lblTamTinh.Text = "Tạm tính tiền: 0 VNĐ";
            //
            // btnXacNhan
            //
            this.btnXacNhan.Location = new System.Drawing.Point(15, 260);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(175, 40);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận đặt";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            //
            // btnHuyTatCa
            //
            this.btnHuyTatCa.Location = new System.Drawing.Point(15, 315);
            this.btnHuyTatCa.Name = "btnHuyTatCa";
            this.btnHuyTatCa.Size = new System.Drawing.Size(175, 40);
            this.btnHuyTatCa.TabIndex = 5;
            this.btnHuyTatCa.Text = "Hủy chọn tất cả";
            this.btnHuyTatCa.UseVisualStyleBackColor = true;
            this.btnHuyTatCa.Click += new System.EventHandler(this.btnHuyTatCa_Click);
            //
            // frmDatBan
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 430);
            this.Controls.Add(this.grpSoDo);
            this.Controls.Add(this.grpThongTin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmDatBan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sơ đồ chọn vị trí chỗ ngồi / Đặt bàn hẹn giờ";
            this.Load += new System.EventHandler(this.frmDatBan_Load);
            this.grpSoDo.ResumeLayout(false);
            this.grpThongTin.ResumeLayout(false);
            this.grpThongTin.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpSoDo;
        private System.Windows.Forms.TableLayoutPanel tlpSoDo;
        private System.Windows.Forms.Label lblChuThichTrong;
        private System.Windows.Forms.Label lblChuThichChon;
        private System.Windows.Forms.Label lblChuThichDaDat;
        private System.Windows.Forms.GroupBox grpThongTin;
        private System.Windows.Forms.Label lblKhungGio;
        private System.Windows.Forms.ComboBox cboKhungGio;
        private System.Windows.Forms.Label lblSoViTri;
        private System.Windows.Forms.Label lblTamTinh;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuyTatCa;
    }
}