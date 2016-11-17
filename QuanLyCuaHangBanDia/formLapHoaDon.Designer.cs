namespace QuanLyCuaHangBanDia
{
	partial class formLapHoaDon
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
			this.btnTaomoi = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNgayLapHD = new System.Windows.Forms.DateTimePicker();
			this.cbkh = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.labMaHD = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.txtsoluong = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbmad = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.btnTrove = new System.Windows.Forms.Button();
			this.btcapnhat = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.cbmahd = new System.Windows.Forms.ComboBox();
			this.btnLuu1 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvKHACHHANG = new System.Windows.Forms.DataGridView();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnktttkh = new System.Windows.Forms.Button();
			this.dgvdia = new System.Windows.Forms.DataGridView();
			this.MaHD1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaD1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label5 = new System.Windows.Forms.Label();
			this.dgvHoaDon = new System.Windows.Forms.DataGridView();
			this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaKH1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnluu = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.button3 = new System.Windows.Forms.Button();
			this.btnxemchitiet = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvdia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTaomoi
			// 
			this.btnTaomoi.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnTaomoi.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTaomoi.ForeColor = System.Drawing.Color.Blue;
			this.btnTaomoi.Location = new System.Drawing.Point(702, 267);
			this.btnTaomoi.Name = "btnTaomoi";
			this.btnTaomoi.Size = new System.Drawing.Size(75, 34);
			this.btnTaomoi.TabIndex = 8;
			this.btnTaomoi.Text = "Tạo Mới";
			this.btnTaomoi.UseVisualStyleBackColor = false;
			this.btnTaomoi.Click += new System.EventHandler(this.btnTaomoi_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(521, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(99, 19);
			this.label1.TabIndex = 31;
			this.label1.Text = "Ngày Lập HD:";
			// 
			// txtNgayLapHD
			// 
			this.txtNgayLapHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtNgayLapHD.Location = new System.Drawing.Point(637, 12);
			this.txtNgayLapHD.Name = "txtNgayLapHD";
			this.txtNgayLapHD.Size = new System.Drawing.Size(147, 26);
			this.txtNgayLapHD.TabIndex = 30;
			// 
			// cbkh
			// 
			this.cbkh.DisplayMember = "MaKH";
			this.cbkh.FormattingEnabled = true;
			this.cbkh.Location = new System.Drawing.Point(394, 12);
			this.cbkh.Margin = new System.Windows.Forms.Padding(2);
			this.cbkh.Name = "cbkh";
			this.cbkh.Size = new System.Drawing.Size(92, 21);
			this.cbkh.TabIndex = 2;
			this.cbkh.ValueMember = "MaKH";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(261, 12);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(113, 19);
			this.label2.TabIndex = 28;
			this.label2.Text = "Mã Khách Hàng:";
			// 
			// labMaHD
			// 
			this.labMaHD.AutoSize = true;
			this.labMaHD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labMaHD.Location = new System.Drawing.Point(10, 10);
			this.labMaHD.Name = "labMaHD";
			this.labMaHD.Size = new System.Drawing.Size(93, 19);
			this.labMaHD.TabIndex = 26;
			this.labMaHD.Text = "Mã Hóa Đơn:";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.txtsoluong);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.cbmad);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Location = new System.Drawing.Point(150, 251);
			this.panel2.Margin = new System.Windows.Forms.Padding(2);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(516, 56);
			this.panel2.TabIndex = 59;
			// 
			// txtsoluong
			// 
			this.txtsoluong.Location = new System.Drawing.Point(364, 24);
			this.txtsoluong.Name = "txtsoluong";
			this.txtsoluong.Size = new System.Drawing.Size(108, 20);
			this.txtsoluong.TabIndex = 7;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(288, 25);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 17);
			this.label4.TabIndex = 33;
			this.label4.Text = "Số Lượng:";
			// 
			// cbmad
			// 
			this.cbmad.DisplayMember = "MaD";
			this.cbmad.FormattingEnabled = true;
			this.cbmad.Location = new System.Drawing.Point(99, 23);
			this.cbmad.Margin = new System.Windows.Forms.Padding(2);
			this.cbmad.Name = "cbmad";
			this.cbmad.Size = new System.Drawing.Size(161, 21);
			this.cbmad.TabIndex = 6;
			this.cbmad.ValueMember = "MaD";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(31, 25);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 17);
			this.label3.TabIndex = 31;
			this.label3.Text = "Mã Đĩa:";
			// 
			// btnTrove
			// 
			this.btnTrove.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnTrove.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrove.ForeColor = System.Drawing.Color.Black;
			this.btnTrove.Location = new System.Drawing.Point(702, 406);
			this.btnTrove.Name = "btnTrove";
			this.btnTrove.Size = new System.Drawing.Size(75, 35);
			this.btnTrove.TabIndex = 13;
			this.btnTrove.Text = "Trở Về";
			this.btnTrove.UseVisualStyleBackColor = false;
			this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
			// 
			// btcapnhat
			// 
			this.btcapnhat.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btcapnhat.Location = new System.Drawing.Point(396, 412);
			this.btcapnhat.Margin = new System.Windows.Forms.Padding(2);
			this.btcapnhat.Name = "btcapnhat";
			this.btcapnhat.Size = new System.Drawing.Size(136, 28);
			this.btcapnhat.TabIndex = 12;
			this.btcapnhat.Text = "Cập Nhật";
			this.btcapnhat.UseVisualStyleBackColor = true;
			this.btcapnhat.Click += new System.EventHandler(this.btcapnhat_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.SystemColors.ControlLight;
			this.button2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Black;
			this.button2.Location = new System.Drawing.Point(702, 341);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 32);
			this.button2.TabIndex = 9;
			this.button2.Text = "Hủy";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// cbmahd
			// 
			this.cbmahd.DisplayMember = "MaHD";
			this.cbmahd.FormattingEnabled = true;
			this.cbmahd.Location = new System.Drawing.Point(108, 10);
			this.cbmahd.Margin = new System.Windows.Forms.Padding(2);
			this.cbmahd.Name = "cbmahd";
			this.cbmahd.Size = new System.Drawing.Size(92, 21);
			this.cbmahd.TabIndex = 1;
			this.cbmahd.ValueMember = "MaHD";
			// 
			// btnLuu1
			// 
			this.btnLuu1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu1.Location = new System.Drawing.Point(307, 218);
			this.btnLuu1.Margin = new System.Windows.Forms.Padding(2);
			this.btnLuu1.Name = "btnLuu1";
			this.btnLuu1.Size = new System.Drawing.Size(136, 28);
			this.btnLuu1.TabIndex = 4;
			this.btnLuu1.Text = "Lưu";
			this.btnLuu1.UseVisualStyleBackColor = true;
			this.btnLuu1.Click += new System.EventHandler(this.btnLuu1_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.cbmahd);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txtNgayLapHD);
			this.panel1.Controls.Add(this.cbkh);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.labMaHD);
			this.panel1.Location = new System.Drawing.Point(2, 1);
			this.panel1.Margin = new System.Windows.Forms.Padding(2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(800, 54);
			this.panel1.TabIndex = 58;
			// 
			// dgvKHACHHANG
			// 
			this.dgvKHACHHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKHACHHANG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH});
			this.dgvKHACHHANG.Location = new System.Drawing.Point(472, 88);
			this.dgvKHACHHANG.Margin = new System.Windows.Forms.Padding(2);
			this.dgvKHACHHANG.Name = "dgvKHACHHANG";
			this.dgvKHACHHANG.RowTemplate.Height = 24;
			this.dgvKHACHHANG.Size = new System.Drawing.Size(330, 122);
			this.dgvKHACHHANG.TabIndex = 47;
			// 
			// MaKH
			// 
			this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaKH.DataPropertyName = "MaKH";
			this.MaKH.HeaderText = "Mã Khách Hàng";
			this.MaKH.Name = "MaKH";
			// 
			// TenKH
			// 
			this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TenKH.DataPropertyName = "TenKH";
			this.TenKH.HeaderText = "Tên Khách Hàng";
			this.TenKH.Name = "TenKH";
			// 
			// btnktttkh
			// 
			this.btnktttkh.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnktttkh.Location = new System.Drawing.Point(666, 218);
			this.btnktttkh.Margin = new System.Windows.Forms.Padding(2);
			this.btnktttkh.Name = "btnktttkh";
			this.btnktttkh.Size = new System.Drawing.Size(136, 28);
			this.btnktttkh.TabIndex = 5;
			this.btnktttkh.Text = "Kiểm Tra Thông Tin";
			this.btnktttkh.UseVisualStyleBackColor = true;
			this.btnktttkh.Click += new System.EventHandler(this.btnktttkh_Click);
			// 
			// dgvdia
			// 
			this.dgvdia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD1,
            this.MaD,
            this.MaD1,
            this.SoLuong,
            this.ThanhTien});
			this.dgvdia.Location = new System.Drawing.Point(2, 314);
			this.dgvdia.Margin = new System.Windows.Forms.Padding(2);
			this.dgvdia.Name = "dgvdia";
			this.dgvdia.RowTemplate.Height = 24;
			this.dgvdia.Size = new System.Drawing.Size(680, 91);
			this.dgvdia.TabIndex = 49;
			// 
			// MaHD1
			// 
			this.MaHD1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaHD1.DataPropertyName = "MaHD";
			this.MaHD1.HeaderText = "Mã Hóa Đơn";
			this.MaHD1.Name = "MaHD1";
			// 
			// MaD
			// 
			this.MaD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaD.DataPropertyName = "MaD";
			this.MaD.HeaderText = "Mã Đĩa";
			this.MaD.Name = "MaD";
			// 
			// MaD1
			// 
			this.MaD1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaD1.DataPropertyName = "MaD";
			this.MaD1.HeaderText = "Tên Đĩa";
			this.MaD1.Name = "MaD1";
			this.MaD1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
			this.MaD1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
			// 
			// SoLuong
			// 
			this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SoLuong.DataPropertyName = "SoLuong";
			this.SoLuong.HeaderText = "Số Lượng";
			this.SoLuong.Name = "SoLuong";
			// 
			// ThanhTien
			// 
			this.ThanhTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.ThanhTien.DataPropertyName = "ThanhTien";
			this.ThanhTien.HeaderText = "Thành Tiền";
			this.ThanhTien.Name = "ThanhTien";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(468, 61);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(198, 25);
			this.label5.TabIndex = 54;
			this.label5.Text = "Thông Tin Khách Hàng:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgvHoaDon
			// 
			this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH1,
            this.NgayLapHD,
            this.TongTien});
			this.dgvHoaDon.Location = new System.Drawing.Point(9, 88);
			this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(2);
			this.dgvHoaDon.Name = "dgvHoaDon";
			this.dgvHoaDon.RowTemplate.Height = 24;
			this.dgvHoaDon.Size = new System.Drawing.Size(434, 122);
			this.dgvHoaDon.TabIndex = 52;
			// 
			// MaHD
			// 
			this.MaHD.DataPropertyName = "MaHD";
			this.MaHD.HeaderText = "Mã Hóa Đơn";
			this.MaHD.Name = "MaHD";
			// 
			// MaKH1
			// 
			this.MaKH1.DataPropertyName = "MaKH";
			this.MaKH1.HeaderText = "Mã Khách Hàng";
			this.MaKH1.Name = "MaKH1";
			// 
			// NgayLapHD
			// 
			this.NgayLapHD.DataPropertyName = "NgayLapHD";
			this.NgayLapHD.HeaderText = "Ngày Lập Hóa Đơn";
			this.NgayLapHD.Name = "NgayLapHD";
			// 
			// TongTien
			// 
			this.TongTien.DataPropertyName = "TongTien";
			this.TongTien.HeaderText = "Tổng Tiền";
			this.TongTien.Name = "TongTien";
			// 
			// btnluu
			// 
			this.btnluu.Location = new System.Drawing.Point(995, 258);
			this.btnluu.Margin = new System.Windows.Forms.Padding(2);
			this.btnluu.Name = "btnluu";
			this.btnluu.Size = new System.Drawing.Size(136, 28);
			this.btnluu.TabIndex = 51;
			this.btnluu.Text = "Lưu";
			this.btnluu.UseVisualStyleBackColor = true;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(13, 412);
			this.button1.Margin = new System.Windows.Forms.Padding(2);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(136, 28);
			this.button1.TabIndex = 10;
			this.button1.Text = "Lưu";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Red;
			this.label7.Location = new System.Drawing.Point(-2, 283);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(140, 25);
			this.label7.TabIndex = 56;
			this.label7.Text = "Nhập Hóa Đơn:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button3.Location = new System.Drawing.Point(9, 218);
			this.button3.Margin = new System.Windows.Forms.Padding(2);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(136, 28);
			this.button3.TabIndex = 3;
			this.button3.Text = "Kiểm Tra Hóa Đơn";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// btnxemchitiet
			// 
			this.btnxemchitiet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnxemchitiet.Location = new System.Drawing.Point(240, 412);
			this.btnxemchitiet.Margin = new System.Windows.Forms.Padding(2);
			this.btnxemchitiet.Name = "btnxemchitiet";
			this.btnxemchitiet.Size = new System.Drawing.Size(136, 28);
			this.btnxemchitiet.TabIndex = 11;
			this.btnxemchitiet.Text = "Xem Chi Tiết";
			this.btnxemchitiet.UseVisualStyleBackColor = true;
			this.btnxemchitiet.Click += new System.EventHandler(this.btnxemchitiet_Click);
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Red;
			this.label6.Location = new System.Drawing.Point(4, 61);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(173, 25);
			this.label6.TabIndex = 55;
			this.label6.Text = "Thông Tin Hóa Đơn:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// formLapHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(807, 446);
			this.Controls.Add(this.btnTaomoi);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.btnTrove);
			this.Controls.Add(this.btcapnhat);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnLuu1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgvKHACHHANG);
			this.Controls.Add(this.btnktttkh);
			this.Controls.Add(this.dgvdia);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dgvHoaDon);
			this.Controls.Add(this.btnluu);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.btnxemchitiet);
			this.Controls.Add(this.label6);
			this.Name = "formLapHoaDon";
			this.Text = "formLapHoaDon";
			this.Load += new System.EventHandler(this.FormLoad);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvdia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnTaomoi;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker txtNgayLapHD;
		private System.Windows.Forms.ComboBox cbkh;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label labMaHD;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtsoluong;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cbmad;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button btnTrove;
		private System.Windows.Forms.Button btcapnhat;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ComboBox cbmahd;
		private System.Windows.Forms.Button btnLuu1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgvKHACHHANG;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
		private System.Windows.Forms.Button btnktttkh;
		private System.Windows.Forms.DataGridView dgvdia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgvHoaDon;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH1;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
		private System.Windows.Forms.Button btnluu;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button btnxemchitiet;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaHD1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaD;
		private System.Windows.Forms.DataGridViewComboBoxColumn MaD1;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
	}
}