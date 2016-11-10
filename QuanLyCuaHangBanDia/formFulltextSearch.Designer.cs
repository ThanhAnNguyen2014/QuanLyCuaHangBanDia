namespace QuanLyCuaHangBanDia
{
	partial class formFulltextSearch
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
			this.dgv = new System.Windows.Forms.DataGridView();
			this.MaS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnTim = new System.Windows.Forms.Button();
			this.txttim = new System.Windows.Forms.TextBox();
			this.btnTrove = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaS,
            this.TuaSach,
            this.TacGia,
            this.NXB,
            this.SoLuong,
            this.DonGia,
            this.KhuyenMai});
			this.dgv.Location = new System.Drawing.Point(11, 52);
			this.dgv.Margin = new System.Windows.Forms.Padding(2);
			this.dgv.Name = "dgv";
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(667, 193);
			this.dgv.TabIndex = 24;
			// 
			// MaS
			// 
			this.MaS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaS.DataPropertyName = "MaS";
			this.MaS.HeaderText = "Mã Sách";
			this.MaS.Name = "MaS";
			// 
			// TuaSach
			// 
			this.TuaSach.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TuaSach.DataPropertyName = "TuaSach";
			this.TuaSach.HeaderText = "Tựa Sách";
			this.TuaSach.Name = "TuaSach";
			// 
			// TacGia
			// 
			this.TacGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TacGia.DataPropertyName = "TacGia";
			this.TacGia.HeaderText = "Tác Giả";
			this.TacGia.Name = "TacGia";
			// 
			// NXB
			// 
			this.NXB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NXB.DataPropertyName = "NXB";
			this.NXB.HeaderText = "Nhà Xuất Bản";
			this.NXB.Name = "NXB";
			// 
			// SoLuong
			// 
			this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.SoLuong.DataPropertyName = "SoLuong";
			this.SoLuong.HeaderText = "Số Lượng";
			this.SoLuong.Name = "SoLuong";
			// 
			// DonGia
			// 
			this.DonGia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.DonGia.DataPropertyName = "DonGia";
			this.DonGia.HeaderText = "Đơn Giá";
			this.DonGia.Name = "DonGia";
			// 
			// KhuyenMai
			// 
			this.KhuyenMai.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.KhuyenMai.DataPropertyName = "KhuyenMai";
			this.KhuyenMai.HeaderText = "Khuyến Mãi";
			this.KhuyenMai.Name = "KhuyenMai";
			// 
			// btnTim
			// 
			this.btnTim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.Location = new System.Drawing.Point(546, 17);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(86, 23);
			this.btnTim.TabIndex = 22;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = true;
			// 
			// txttim
			// 
			this.txttim.Location = new System.Drawing.Point(249, 17);
			this.txttim.Margin = new System.Windows.Forms.Padding(2);
			this.txttim.Name = "txttim";
			this.txttim.Size = new System.Drawing.Size(278, 20);
			this.txttim.TabIndex = 23;
			// 
			// btnTrove
			// 
			this.btnTrove.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnTrove.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrove.ForeColor = System.Drawing.Color.Black;
			this.btnTrove.Location = new System.Drawing.Point(572, 250);
			this.btnTrove.Name = "btnTrove";
			this.btnTrove.Size = new System.Drawing.Size(93, 34);
			this.btnTrove.TabIndex = 26;
			this.btnTrove.Text = "Trở Về";
			this.btnTrove.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(223, 22);
			this.label1.TabIndex = 25;
			this.label1.Text = "Nhập Nội Dung Tìm Kiếm";
			// 
			// formFulltextSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 295);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txttim);
			this.Controls.Add(this.btnTrove);
			this.Controls.Add(this.label1);
			this.Name = "formFulltextSearch";
			this.Text = "formFulltextSearch";
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaS;
		private System.Windows.Forms.DataGridViewTextBoxColumn TuaSach;
		private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
		private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
		private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.TextBox txttim;
		private System.Windows.Forms.Button btnTrove;
		private System.Windows.Forms.Label label1;
	}
}