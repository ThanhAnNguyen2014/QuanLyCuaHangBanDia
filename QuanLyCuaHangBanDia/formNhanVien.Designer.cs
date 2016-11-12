namespace QuanLyCuaHangBanDia
{
	partial class formNhanVien
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
			this.txtMaNV = new System.Windows.Forms.TextBox();
			this.btnReLoad = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.dgvKHACHHANG = new System.Windows.Forms.DataGridView();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNgaySinh = new System.Windows.Forms.DateTimePicker();
			this.txtDienthoai = new System.Windows.Forms.TextBox();
			this.txtTen = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnXoa = new System.Windows.Forms.Button();
			this.labTen = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labNV = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).BeginInit();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// txtMaNV
			// 
			this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtMaNV.ForeColor = System.Drawing.Color.Blue;
			this.txtMaNV.Location = new System.Drawing.Point(140, 17);
			this.txtMaNV.Name = "txtMaNV";
			this.txtMaNV.Size = new System.Drawing.Size(162, 26);
			this.txtMaNV.TabIndex = 1;
			this.txtMaNV.Tag = "1";
			// 
			// btnReLoad
			// 
			this.btnReLoad.BackColor = System.Drawing.Color.White;
			this.btnReLoad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReLoad.ForeColor = System.Drawing.Color.Red;
			this.btnReLoad.Location = new System.Drawing.Point(16, 352);
			this.btnReLoad.Name = "btnReLoad";
			this.btnReLoad.Size = new System.Drawing.Size(86, 43);
			this.btnReLoad.TabIndex = 5;
			this.btnReLoad.Tag = "5";
			this.btnReLoad.Text = "ReLoad";
			this.btnReLoad.UseVisualStyleBackColor = false;
			this.btnReLoad.Click += new System.EventHandler(this.NhanVien_Load);
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.White;
			this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.Red;
			this.btnThoat.Location = new System.Drawing.Point(686, 352);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(117, 43);
			this.btnThoat.TabIndex = 11;
			this.btnThoat.Tag = "11";
			this.btnThoat.Text = "Trở Về";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
			// 
			// dgvKHACHHANG
			// 
			this.dgvKHACHHANG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvKHACHHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKHACHHANG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgaySinh,
            this.DiaChi,
            this.SDT});
			this.dgvKHACHHANG.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvKHACHHANG.Location = new System.Drawing.Point(0, 149);
			this.dgvKHACHHANG.Name = "dgvKHACHHANG";
			this.dgvKHACHHANG.Size = new System.Drawing.Size(828, 184);
			this.dgvKHACHHANG.TabIndex = 45;
			// 
			// MaNV
			// 
			this.MaNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã NhânViên";
			this.MaNV.Name = "MaNV";
			// 
			// TenNV
			// 
			this.TenNV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TenNV.DataPropertyName = "TenNV";
			this.TenNV.HeaderText = "Tên Nhân Viên";
			this.TenNV.Name = "TenNV";
			// 
			// NgaySinh
			// 
			this.NgaySinh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NgaySinh.DataPropertyName = "NgaySinh";
			this.NgaySinh.HeaderText = "Ngày Sinh";
			this.NgaySinh.Name = "NgaySinh";
			// 
			// DiaChi
			// 
			this.DiaChi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DiaChi.DataPropertyName = "DiaChi";
			this.DiaChi.HeaderText = "Địa Chỉ";
			this.DiaChi.Name = "DiaChi";
			// 
			// SDT
			// 
			this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SDT.DataPropertyName = "SDT";
			this.SDT.HeaderText = "Điện Thoại";
			this.SDT.Name = "SDT";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(29, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 25);
			this.label1.TabIndex = 21;
			this.label1.Text = "Ngày Sinh:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtNgaySinh
			// 
			this.txtNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.txtNgaySinh.Location = new System.Drawing.Point(140, 89);
			this.txtNgaySinh.Name = "txtNgaySinh";
			this.txtNgaySinh.Size = new System.Drawing.Size(147, 26);
			this.txtNgaySinh.TabIndex = 20;
			// 
			// txtDienthoai
			// 
			this.txtDienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDienthoai.ForeColor = System.Drawing.Color.Blue;
			this.txtDienthoai.Location = new System.Drawing.Point(545, 53);
			this.txtDienthoai.Name = "txtDienthoai";
			this.txtDienthoai.Size = new System.Drawing.Size(203, 26);
			this.txtDienthoai.TabIndex = 4;
			this.txtDienthoai.Tag = "4";
			// 
			// txtTen
			// 
			this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTen.ForeColor = System.Drawing.Color.Blue;
			this.txtTen.Location = new System.Drawing.Point(545, 19);
			this.txtTen.Name = "txtTen";
			this.txtTen.Size = new System.Drawing.Size(203, 26);
			this.txtTen.TabIndex = 2;
			this.txtTen.Tag = "2";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(437, 53);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 25);
			this.label5.TabIndex = 8;
			this.label5.Text = "Điện thoại:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.White;
			this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.Red;
			this.btnXoa.Location = new System.Drawing.Point(561, 352);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(119, 43);
			this.btnXoa.TabIndex = 10;
			this.btnXoa.Tag = "10";
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
			// 
			// labTen
			// 
			this.labTen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTen.ForeColor = System.Drawing.Color.Blue;
			this.labTen.Location = new System.Drawing.Point(414, 16);
			this.labTen.Name = "labTen";
			this.labTen.Size = new System.Drawing.Size(114, 25);
			this.labTen.TabIndex = 6;
			this.labTen.Text = "Tên:";
			this.labTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Blue;
			this.label3.Location = new System.Drawing.Point(29, 53);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Địa chỉ:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labNV
			// 
			this.labNV.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labNV.ForeColor = System.Drawing.Color.Blue;
			this.labNV.Location = new System.Drawing.Point(12, 18);
			this.labNV.Name = "labNV";
			this.labNV.Size = new System.Drawing.Size(133, 25);
			this.labNV.TabIndex = 0;
			this.labNV.Text = "Mã Nhân Viên:";
			this.labNV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel
			// 
			this.panel.Controls.Add(this.label1);
			this.panel.Controls.Add(this.txtNgaySinh);
			this.panel.Controls.Add(this.txtDienthoai);
			this.panel.Controls.Add(this.txtTen);
			this.panel.Controls.Add(this.label5);
			this.panel.Controls.Add(this.labTen);
			this.panel.Controls.Add(this.txtDiaChi);
			this.panel.Controls.Add(this.label3);
			this.panel.Controls.Add(this.txtMaNV);
			this.panel.Controls.Add(this.labNV);
			this.panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel.Enabled = false;
			this.panel.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel.ForeColor = System.Drawing.Color.Teal;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(828, 149);
			this.panel.TabIndex = 44;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtDiaChi.ForeColor = System.Drawing.Color.Blue;
			this.txtDiaChi.Location = new System.Drawing.Point(139, 53);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(284, 26);
			this.txtDiaChi.TabIndex = 3;
			this.txtDiaChi.Tag = "3";
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.White;
			this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.ForeColor = System.Drawing.Color.Red;
			this.btnHuy.Location = new System.Drawing.Point(429, 352);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(126, 43);
			this.btnHuy.TabIndex = 9;
			this.btnHuy.Tag = "9";
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = false;
			this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.White;
			this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ForeColor = System.Drawing.Color.Red;
			this.btnLuu.Location = new System.Drawing.Point(312, 352);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(111, 43);
			this.btnLuu.TabIndex = 8;
			this.btnLuu.Tag = "8";
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = false;
			this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.White;
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.Red;
			this.btnThem.Location = new System.Drawing.Point(108, 352);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(96, 43);
			this.btnThem.TabIndex = 6;
			this.btnThem.Tag = "6";
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.White;
			this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.Red;
			this.btnSua.Location = new System.Drawing.Point(210, 352);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(96, 43);
			this.btnSua.TabIndex = 7;
			this.btnSua.Tag = "7";
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
			// 
			// formNhanVien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(828, 407);
			this.Controls.Add(this.btnReLoad);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.dgvKHACHHANG);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnSua);
			this.Name = "formNhanVien";
			this.Tag = "0";
			this.Text = "Thông tin Nhân Viên";
			((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtMaNV;
		private System.Windows.Forms.Button btnReLoad;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.DataGridView dgvKHACHHANG;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
		private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DateTimePicker txtNgaySinh;
		private System.Windows.Forms.TextBox txtDienthoai;
		private System.Windows.Forms.TextBox txtTen;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Label labTen;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label labNV;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnSua;
	}
}