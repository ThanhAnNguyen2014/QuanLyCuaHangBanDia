namespace QuanLyCuaHangBanDia
{
	partial class formChiTietHoaDon
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnTrove = new System.Windows.Forms.Button();
			this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaHD1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label3 = new System.Windows.Forms.Label();
			this.dgvcthd = new System.Windows.Forms.DataGridView();
			this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaKH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.dgvkhachhang = new System.Windows.Forms.DataGridView();
			this.label5 = new System.Windows.Forms.Label();
			this.xemloainao = new System.Windows.Forms.ComboBox();
			this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnShowAll = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.dgvhoadon = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvcthd)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTrove
			// 
			this.btnTrove.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnTrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrove.ForeColor = System.Drawing.Color.Black;
			this.btnTrove.Location = new System.Drawing.Point(755, 308);
			this.btnTrove.Name = "btnTrove";
			this.btnTrove.Size = new System.Drawing.Size(106, 42);
			this.btnTrove.TabIndex = 59;
			this.btnTrove.Text = "Trở Về";
			this.btnTrove.UseVisualStyleBackColor = false;
			// 
			// ThanhTien
			// 
			this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ThanhTien.DataPropertyName = "ThanhTien";
			this.ThanhTien.HeaderText = "Thành Tiền";
			this.ThanhTien.Name = "ThanhTien";
			// 
			// SoLuong
			// 
			this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SoLuong.DataPropertyName = "SoLuong";
			this.SoLuong.HeaderText = "Số Lượng";
			this.SoLuong.Name = "SoLuong";
			this.SoLuong.ReadOnly = true;
			// 
			// MaS
			// 
			this.MaS.DataPropertyName = "MaS";
			this.MaS.HeaderText = "Mã Sách";
			this.MaS.Name = "MaS";
			// 
			// MaHD1
			// 
			this.MaHD1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaHD1.DataPropertyName = "MaHD";
			this.MaHD1.HeaderText = "Mã Hóa Đơn";
			this.MaHD1.Name = "MaHD1";
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(2, 255);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(187, 25);
			this.label3.TabIndex = 58;
			this.label3.Text = "Chi Tiết Hóa Đơn:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgvcthd
			// 
			this.dgvcthd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvcthd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD1,
            this.MaS,
            this.SoLuong,
            this.ThanhTien});
			this.dgvcthd.Location = new System.Drawing.Point(242, 255);
			this.dgvcthd.Margin = new System.Windows.Forms.Padding(2);
			this.dgvcthd.Name = "dgvcthd";
			this.dgvcthd.RowTemplate.Height = 24;
			this.dgvcthd.Size = new System.Drawing.Size(470, 151);
			this.dgvcthd.TabIndex = 57;
			// 
			// SDT
			// 
			this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SDT.DataPropertyName = "SDT";
			this.SDT.HeaderText = "Số Điện Thoại";
			this.SDT.Name = "SDT";
			// 
			// DiaChi
			// 
			this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DiaChi.DataPropertyName = "DiaChi";
			this.DiaChi.HeaderText = "Địa Chỉ";
			this.DiaChi.Name = "DiaChi";
			this.DiaChi.ReadOnly = true;
			// 
			// TenKH
			// 
			this.TenKH.DataPropertyName = "TenKH";
			this.TenKH.HeaderText = "Tên Khách Hàng";
			this.TenKH.Name = "TenKH";
			// 
			// MaKH1
			// 
			this.MaKH1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaKH1.DataPropertyName = "MaKH";
			this.MaKH1.HeaderText = "Mã Khách Hàng";
			this.MaKH1.Name = "MaKH1";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(689, 41);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(158, 25);
			this.label1.TabIndex = 56;
			this.label1.Text = "Khách Hàng:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgvkhachhang
			// 
			this.dgvkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvkhachhang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH1,
            this.TenKH,
            this.DiaChi,
            this.SDT});
			this.dgvkhachhang.Location = new System.Drawing.Point(482, 79);
			this.dgvkhachhang.Margin = new System.Windows.Forms.Padding(2);
			this.dgvkhachhang.Name = "dgvkhachhang";
			this.dgvkhachhang.RowTemplate.Height = 24;
			this.dgvkhachhang.Size = new System.Drawing.Size(470, 165);
			this.dgvkhachhang.TabIndex = 55;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(79, 45);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(214, 25);
			this.label5.TabIndex = 54;
			this.label5.Text = "Danh Sách Hóa Đơn:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// xemloainao
			// 
			this.xemloainao.FormattingEnabled = true;
			this.xemloainao.Location = new System.Drawing.Point(308, 14);
			this.xemloainao.Margin = new System.Windows.Forms.Padding(2);
			this.xemloainao.Name = "xemloainao";
			this.xemloainao.Size = new System.Drawing.Size(118, 21);
			this.xemloainao.TabIndex = 50;
			this.xemloainao.ValueMember = "MaHD";
			// 
			// TongTien
			// 
			this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TongTien.DataPropertyName = "TongTien";
			this.TongTien.HeaderText = "Tiền Thanh Toán";
			this.TongTien.Name = "TongTien";
			// 
			// NgayLapHD
			// 
			this.NgayLapHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NgayLapHD.DataPropertyName = "NgayLapHD";
			this.NgayLapHD.HeaderText = "Ngày Lập Hóa Đơn";
			this.NgayLapHD.Name = "NgayLapHD";
			this.NgayLapHD.ReadOnly = true;
			// 
			// MaKH
			// 
			this.MaKH.DataPropertyName = "MaKH";
			this.MaKH.HeaderText = "Mã Khách Hàng";
			this.MaKH.Name = "MaKH";
			// 
			// Mahd
			// 
			this.Mahd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Mahd.DataPropertyName = "MaHD";
			this.Mahd.HeaderText = "Mã Hóa Đơn";
			this.Mahd.Name = "Mahd";
			// 
			// btnShowAll
			// 
			this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowAll.Location = new System.Drawing.Point(565, 9);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(118, 38);
			this.btnShowAll.TabIndex = 53;
			this.btnShowAll.Text = "&Show All";
			this.btnShowAll.UseVisualStyleBackColor = false;
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(475, 9);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(84, 38);
			this.btnOK.TabIndex = 52;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = false;
			// 
			// dgvhoadon
			// 
			this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahd,
            this.MaKH,
            this.NgayLapHD,
            this.TongTien});
			this.dgvhoadon.Location = new System.Drawing.Point(5, 79);
			this.dgvhoadon.Margin = new System.Windows.Forms.Padding(2);
			this.dgvhoadon.Name = "dgvhoadon";
			this.dgvhoadon.RowTemplate.Height = 24;
			this.dgvhoadon.Size = new System.Drawing.Size(470, 165);
			this.dgvhoadon.TabIndex = 51;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(217, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(76, 19);
			this.label2.TabIndex = 49;
			this.label2.Text = "Hóa Đơn:";
			// 
			// formChiTietHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(959, 446);
			this.Controls.Add(this.btnTrove);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.dgvcthd);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvkhachhang);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.xemloainao);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.dgvhoadon);
			this.Controls.Add(this.label2);
			this.Name = "formChiTietHoaDon";
			this.Text = "Thông tin chi tiết Hóa Đơn";
			((System.ComponentModel.ISupportInitialize)(this.dgvcthd)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvkhachhang)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnTrove;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaS;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaHD1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dgvcthd;
		private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgvkhachhang;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox xemloainao;
		private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mahd;
		private System.Windows.Forms.Button btnShowAll;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.DataGridView dgvhoadon;
		private System.Windows.Forms.Label label2;
	}
}