namespace QuanLyCuaHangBanDia
{
	partial class formKhachHang
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
			this.txtTenKH = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtSoDT = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.panel = new System.Windows.Forms.Panel();
			this.txtMaKH = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.btnTrove = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnXoa = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnReload = new System.Windows.Forms.Button();
			this.dgvKHACHHANG = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).BeginInit();
			this.SuspendLayout();
			// 
			// txtTenKH
			// 
			this.txtTenKH.Location = new System.Drawing.Point(160, 90);
			this.txtTenKH.Name = "txtTenKH";
			this.txtTenKH.Size = new System.Drawing.Size(202, 20);
			this.txtTenKH.TabIndex = 17;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(88, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 19);
			this.label3.TabIndex = 16;
			this.label3.Text = "Địa Chỉ:";
			// 
			// txtSoDT
			// 
			this.txtSoDT.Location = new System.Drawing.Point(472, 91);
			this.txtSoDT.Name = "txtSoDT";
			this.txtSoDT.Size = new System.Drawing.Size(202, 20);
			this.txtSoDT.TabIndex = 15;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(391, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 19);
			this.label6.TabIndex = 14;
			this.label6.Text = "Số ĐT:";
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Location = new System.Drawing.Point(472, 42);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(202, 20);
			this.txtDiaChi.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(391, 42);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(65, 19);
			this.label7.TabIndex = 12;
			this.label7.Text = "Địa Chỉ:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(88, 41);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(66, 19);
			this.label8.TabIndex = 10;
			this.label8.Text = "Mã KH:";
			// 
			// panel
			// 
			this.panel.BackColor = System.Drawing.Color.Silver;
			this.panel.Controls.Add(this.label1);
			this.panel.Controls.Add(this.txtTenKH);
			this.panel.Controls.Add(this.label3);
			this.panel.Controls.Add(this.txtSoDT);
			this.panel.Controls.Add(this.label6);
			this.panel.Controls.Add(this.txtDiaChi);
			this.panel.Controls.Add(this.label7);
			this.panel.Controls.Add(this.txtMaKH);
			this.panel.Controls.Add(this.label8);
			this.panel.Enabled = false;
			this.panel.Location = new System.Drawing.Point(1, 1);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(787, 149);
			this.panel.TabIndex = 45;
			// 
			// txtMaKH
			// 
			this.txtMaKH.Location = new System.Drawing.Point(160, 41);
			this.txtMaKH.Name = "txtMaKH";
			this.txtMaKH.Size = new System.Drawing.Size(202, 20);
			this.txtMaKH.TabIndex = 11;
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(622, 273);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 35);
			this.btnOK.TabIndex = 44;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = false;
			// 
			// btnTrove
			// 
			this.btnTrove.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnTrove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrove.ForeColor = System.Drawing.Color.Black;
			this.btnTrove.Location = new System.Drawing.Point(703, 314);
			this.btnTrove.Name = "btnTrove";
			this.btnTrove.Size = new System.Drawing.Size(75, 35);
			this.btnTrove.TabIndex = 43;
			this.btnTrove.Text = "Trở Về";
			this.btnTrove.UseVisualStyleBackColor = false;
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCancel.Location = new System.Drawing.Point(622, 314);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 35);
			this.btnCancel.TabIndex = 41;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = false;
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Yellow;
			this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.Location = new System.Drawing.Point(622, 224);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(75, 35);
			this.btnXoa.TabIndex = 40;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Yellow;
			this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.Location = new System.Drawing.Point(703, 224);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(75, 35);
			this.btnSua.TabIndex = 39;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.Yellow;
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.Location = new System.Drawing.Point(661, 174);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(75, 35);
			this.btnThem.TabIndex = 38;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			// 
			// SDT
			// 
			this.SDT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SDT.DataPropertyName = "SDT";
			this.SDT.HeaderText = "Số Điện Thoại";
			this.SDT.Name = "SDT";
			// 
			// Diachi
			// 
			this.Diachi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Diachi.DataPropertyName = "Diachi";
			this.Diachi.HeaderText = "Địa Chỉ";
			this.Diachi.Name = "Diachi";
			// 
			// TenKH
			// 
			this.TenKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TenKH.DataPropertyName = "TenKH";
			this.TenKH.HeaderText = "Tên Khách Hàng";
			this.TenKH.Name = "TenKH";
			// 
			// MaKH
			// 
			this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaKH.DataPropertyName = "MaKH";
			this.MaKH.HeaderText = "Mã Khách Hàng";
			this.MaKH.Name = "MaKH";
			// 
			// btnReload
			// 
			this.btnReload.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReload.Location = new System.Drawing.Point(703, 273);
			this.btnReload.Name = "btnReload";
			this.btnReload.Size = new System.Drawing.Size(75, 35);
			this.btnReload.TabIndex = 42;
			this.btnReload.Text = "Reload";
			this.btnReload.UseVisualStyleBackColor = false;
			// 
			// dgvKHACHHANG
			// 
			this.dgvKHACHHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKHACHHANG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.Diachi,
            this.SDT});
			this.dgvKHACHHANG.Location = new System.Drawing.Point(1, 150);
			this.dgvKHACHHANG.Name = "dgvKHACHHANG";
			this.dgvKHACHHANG.Size = new System.Drawing.Size(603, 232);
			this.dgvKHACHHANG.TabIndex = 37;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(11, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(162, 20);
			this.label1.TabIndex = 18;
			this.label1.Text = "Thông tin khách hàng";
			// 
			// formKhachHang
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(789, 386);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnTrove);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.btnSua);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnReload);
			this.Controls.Add(this.dgvKHACHHANG);
			this.Name = "formKhachHang";
			this.Text = "Thông tin Khách Hàng";
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox txtTenKH;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtSoDT;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtMaKH;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnTrove;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Button btnSua;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
		private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
		private System.Windows.Forms.Button btnReload;
		private System.Windows.Forms.DataGridView dgvKHACHHANG;
	}
}