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
			this.btnTim = new System.Windows.Forms.Button();
			this.txttim = new System.Windows.Forms.TextBox();
			this.btnTrove = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.MaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TuaDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaD,
            this.TuaDia,
            this.NSX,
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
			// btnTim
			// 
			this.btnTim.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTim.Location = new System.Drawing.Point(546, 17);
			this.btnTim.Name = "btnTim";
			this.btnTim.Size = new System.Drawing.Size(86, 23);
			this.btnTim.TabIndex = 2;
			this.btnTim.Text = "Tìm";
			this.btnTim.UseVisualStyleBackColor = true;
			this.btnTim.Click += new System.EventHandler(this.btnTim_Click);
			// 
			// txttim
			// 
			this.txttim.Location = new System.Drawing.Point(249, 17);
			this.txttim.Margin = new System.Windows.Forms.Padding(2);
			this.txttim.Name = "txttim";
			this.txttim.Size = new System.Drawing.Size(278, 20);
			this.txttim.TabIndex = 1;
			// 
			// btnTrove
			// 
			this.btnTrove.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnTrove.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrove.ForeColor = System.Drawing.Color.Black;
			this.btnTrove.Location = new System.Drawing.Point(299, 250);
			this.btnTrove.Name = "btnTrove";
			this.btnTrove.Size = new System.Drawing.Size(93, 34);
			this.btnTrove.TabIndex = 3;
			this.btnTrove.Text = "Trở Về";
			this.btnTrove.UseVisualStyleBackColor = false;
			this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(22, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(164, 22);
			this.label1.TabIndex = 25;
			this.label1.Text = "Tìm Kiếm Tựa Đĩa";
			// 
			// MaD
			// 
			this.MaD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaD.DataPropertyName = "MaD";
			this.MaD.HeaderText = "Mã Đĩa";
			this.MaD.Name = "MaD";
			// 
			// TuaDia
			// 
			this.TuaDia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TuaDia.DataPropertyName = "TuaDia";
			this.TuaDia.HeaderText = "Tựa Đĩa";
			this.TuaDia.Name = "TuaDia";
			// 
			// NSX
			// 
			this.NSX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NSX.DataPropertyName = "NSX";
			this.NSX.HeaderText = "Nhà Sản Xuất";
			this.NSX.Name = "NSX";
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
			// formFulltextSearch
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(696, 291);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.btnTim);
			this.Controls.Add(this.txttim);
			this.Controls.Add(this.btnTrove);
			this.Controls.Add(this.label1);
			this.Name = "formFulltextSearch";
			this.Text = "Tìm kiếm Thông tin";
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.Button btnTim;
		private System.Windows.Forms.TextBox txttim;
		private System.Windows.Forms.Button btnTrove;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaD;
		private System.Windows.Forms.DataGridViewTextBoxColumn TuaDia;
		private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
		private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
	}
}