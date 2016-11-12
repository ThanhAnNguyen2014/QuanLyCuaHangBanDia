namespace QuanLyCuaHangBanDia
{
	partial class formGiamDoc
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
			this.btnReLoad = new System.Windows.Forms.Button();
			this.btnThoat = new System.Windows.Forms.Button();
			this.dgvKHACHHANG = new System.Windows.Forms.DataGridView();
			this.MaGD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnXoa = new System.Windows.Forms.Button();
			this.panel = new System.Windows.Forms.Panel();
			this.txtDienthoai = new System.Windows.Forms.TextBox();
			this.txtThanhPho = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.labTen = new System.Windows.Forms.Label();
			this.txtDiaChi = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtMaGD = new System.Windows.Forms.TextBox();
			this.labGD = new System.Windows.Forms.Label();
			this.btnLuu = new System.Windows.Forms.Button();
			this.btnThem = new System.Windows.Forms.Button();
			this.btnHuy = new System.Windows.Forms.Button();
			this.btnSua = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).BeginInit();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnReLoad
			// 
			this.btnReLoad.BackColor = System.Drawing.Color.Silver;
			this.btnReLoad.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReLoad.ForeColor = System.Drawing.Color.Navy;
			this.btnReLoad.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnReLoad.Location = new System.Drawing.Point(12, 285);
			this.btnReLoad.Name = "btnReLoad";
			this.btnReLoad.Size = new System.Drawing.Size(69, 32);
			this.btnReLoad.TabIndex = 38;
			this.btnReLoad.Text = "ReLoad";
			this.btnReLoad.UseVisualStyleBackColor = false;
			// 
			// btnThoat
			// 
			this.btnThoat.BackColor = System.Drawing.Color.Silver;
			this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThoat.ForeColor = System.Drawing.Color.Red;
			this.btnThoat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnThoat.Location = new System.Drawing.Point(543, 342);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new System.Drawing.Size(100, 32);
			this.btnThoat.TabIndex = 37;
			this.btnThoat.Text = "Trở Về";
			this.btnThoat.UseVisualStyleBackColor = false;
			// 
			// dgvKHACHHANG
			// 
			this.dgvKHACHHANG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvKHACHHANG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvKHACHHANG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaGD,
            this.Ten,
            this.Diachi,
            this.SoDT});
			this.dgvKHACHHANG.Dock = System.Windows.Forms.DockStyle.Top;
			this.dgvKHACHHANG.Location = new System.Drawing.Point(0, 149);
			this.dgvKHACHHANG.Name = "dgvKHACHHANG";
			this.dgvKHACHHANG.Size = new System.Drawing.Size(665, 120);
			this.dgvKHACHHANG.TabIndex = 36;
			// 
			// MaGD
			// 
			this.MaGD.Frozen = true;
			this.MaGD.HeaderText = "Mã Giám Đốc";
			this.MaGD.Name = "MaGD";
			this.MaGD.Width = 97;
			// 
			// Ten
			// 
			this.Ten.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.Ten.DataPropertyName = "Ten";
			this.Ten.HeaderText = "Tên";
			this.Ten.Name = "Ten";
			this.Ten.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.Ten.Width = 150;
			// 
			// Diachi
			// 
			this.Diachi.DataPropertyName = "Diachi";
			this.Diachi.HeaderText = "Địa Chỉ";
			this.Diachi.Name = "Diachi";
			this.Diachi.Width = 66;
			// 
			// SoDT
			// 
			this.SoDT.HeaderText = "Số Điện Thoại";
			this.SoDT.Name = "SoDT";
			// 
			// btnXoa
			// 
			this.btnXoa.BackColor = System.Drawing.Color.Silver;
			this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnXoa.ForeColor = System.Drawing.Color.Maroon;
			this.btnXoa.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnXoa.Location = new System.Drawing.Point(247, 285);
			this.btnXoa.Name = "btnXoa";
			this.btnXoa.Size = new System.Drawing.Size(102, 32);
			this.btnXoa.TabIndex = 39;
			this.btnXoa.Text = "Xóa";
			this.btnXoa.UseVisualStyleBackColor = false;
			// 
			// panel
			// 
			this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.panel.CausesValidation = false;
			this.panel.Controls.Add(this.txtDienthoai);
			this.panel.Controls.Add(this.txtThanhPho);
			this.panel.Controls.Add(this.label5);
			this.panel.Controls.Add(this.labTen);
			this.panel.Controls.Add(this.txtDiaChi);
			this.panel.Controls.Add(this.label3);
			this.panel.Controls.Add(this.txtMaGD);
			this.panel.Controls.Add(this.labGD);
			this.panel.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel.Enabled = false;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(665, 149);
			this.panel.TabIndex = 35;
			// 
			// txtDienthoai
			// 
			this.txtDienthoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.txtDienthoai.ForeColor = System.Drawing.Color.Blue;
			this.txtDienthoai.Location = new System.Drawing.Point(446, 72);
			this.txtDienthoai.Name = "txtDienthoai";
			this.txtDienthoai.Size = new System.Drawing.Size(205, 26);
			this.txtDienthoai.TabIndex = 10;
			// 
			// txtThanhPho
			// 
			this.txtThanhPho.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.txtThanhPho.ForeColor = System.Drawing.Color.Blue;
			this.txtThanhPho.Location = new System.Drawing.Point(446, 18);
			this.txtThanhPho.Name = "txtThanhPho";
			this.txtThanhPho.Size = new System.Drawing.Size(205, 26);
			this.txtThanhPho.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label5.Location = new System.Drawing.Point(343, 75);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(118, 25);
			this.label5.TabIndex = 8;
			this.label5.Text = "Điện thoại:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labTen
			// 
			this.labTen.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.labTen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labTen.Location = new System.Drawing.Point(343, 20);
			this.labTen.Name = "labTen";
			this.labTen.Size = new System.Drawing.Size(114, 25);
			this.labTen.TabIndex = 6;
			this.labTen.Text = "Tên:";
			this.labTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtDiaChi
			// 
			this.txtDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.txtDiaChi.ForeColor = System.Drawing.Color.Blue;
			this.txtDiaChi.Location = new System.Drawing.Point(130, 75);
			this.txtDiaChi.Name = "txtDiaChi";
			this.txtDiaChi.Size = new System.Drawing.Size(207, 26);
			this.txtDiaChi.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.label3.Location = new System.Drawing.Point(29, 73);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(92, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Địa chỉ:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txtMaGD
			// 
			this.txtMaGD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
			this.txtMaGD.ForeColor = System.Drawing.Color.Blue;
			this.txtMaGD.Location = new System.Drawing.Point(131, 19);
			this.txtMaGD.Name = "txtMaGD";
			this.txtMaGD.Size = new System.Drawing.Size(206, 26);
			this.txtMaGD.TabIndex = 1;
			// 
			// labGD
			// 
			this.labGD.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labGD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.labGD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.labGD.Location = new System.Drawing.Point(12, 18);
			this.labGD.Name = "labGD";
			this.labGD.Size = new System.Drawing.Size(133, 25);
			this.labGD.TabIndex = 0;
			this.labGD.Text = "Mã Giám Đốc:";
			this.labGD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnLuu
			// 
			this.btnLuu.BackColor = System.Drawing.Color.Silver;
			this.btnLuu.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLuu.ForeColor = System.Drawing.Color.Maroon;
			this.btnLuu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnLuu.Location = new System.Drawing.Point(559, 285);
			this.btnLuu.Name = "btnLuu";
			this.btnLuu.Size = new System.Drawing.Size(94, 32);
			this.btnLuu.TabIndex = 43;
			this.btnLuu.Text = "Lưu";
			this.btnLuu.UseVisualStyleBackColor = false;
			// 
			// btnThem
			// 
			this.btnThem.BackColor = System.Drawing.Color.Silver;
			this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnThem.ForeColor = System.Drawing.Color.Maroon;
			this.btnThem.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnThem.Location = new System.Drawing.Point(355, 285);
			this.btnThem.Name = "btnThem";
			this.btnThem.Size = new System.Drawing.Size(79, 32);
			this.btnThem.TabIndex = 41;
			this.btnThem.Text = "Thêm";
			this.btnThem.UseVisualStyleBackColor = false;
			// 
			// btnHuy
			// 
			this.btnHuy.BackColor = System.Drawing.Color.Silver;
			this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnHuy.ForeColor = System.Drawing.Color.Red;
			this.btnHuy.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnHuy.Location = new System.Drawing.Point(413, 342);
			this.btnHuy.Name = "btnHuy";
			this.btnHuy.Size = new System.Drawing.Size(109, 32);
			this.btnHuy.TabIndex = 42;
			this.btnHuy.Text = "Hủy";
			this.btnHuy.UseVisualStyleBackColor = false;
			// 
			// btnSua
			// 
			this.btnSua.BackColor = System.Drawing.Color.Silver;
			this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.btnSua.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.btnSua.Location = new System.Drawing.Point(457, 285);
			this.btnSua.Name = "btnSua";
			this.btnSua.Size = new System.Drawing.Size(79, 32);
			this.btnSua.TabIndex = 40;
			this.btnSua.Text = "Sửa";
			this.btnSua.UseVisualStyleBackColor = false;
			// 
			// formGiamDoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(665, 382);
			this.Controls.Add(this.btnReLoad);
			this.Controls.Add(this.btnThoat);
			this.Controls.Add(this.dgvKHACHHANG);
			this.Controls.Add(this.btnXoa);
			this.Controls.Add(this.panel);
			this.Controls.Add(this.btnLuu);
			this.Controls.Add(this.btnThem);
			this.Controls.Add(this.btnHuy);
			this.Controls.Add(this.btnSua);
			this.Name = "formGiamDoc";
			this.Text = "formGiamDoc";
			((System.ComponentModel.ISupportInitialize)(this.dgvKHACHHANG)).EndInit();
			this.panel.ResumeLayout(false);
			this.panel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnReLoad;
		private System.Windows.Forms.Button btnThoat;
		private System.Windows.Forms.DataGridView dgvKHACHHANG;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaGD;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
		private System.Windows.Forms.DataGridViewTextBoxColumn Diachi;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoDT;
		private System.Windows.Forms.Button btnXoa;
		private System.Windows.Forms.Panel panel;
		private System.Windows.Forms.TextBox txtDienthoai;
		private System.Windows.Forms.TextBox txtThanhPho;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label labTen;
		private System.Windows.Forms.TextBox txtDiaChi;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtMaGD;
		private System.Windows.Forms.Label labGD;
		private System.Windows.Forms.Button btnLuu;
		private System.Windows.Forms.Button btnThem;
		private System.Windows.Forms.Button btnHuy;
		private System.Windows.Forms.Button btnSua;
	}
}