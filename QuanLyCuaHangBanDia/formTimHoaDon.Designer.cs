namespace QuanLyCuaHangBanDia
{
	partial class formTimHoaDon
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
			this.label1 = new System.Windows.Forms.Label();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayLapHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txttim = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTrove
			// 
			this.btnTrove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
			this.btnTrove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrove.ForeColor = System.Drawing.Color.Black;
			this.btnTrove.Location = new System.Drawing.Point(179, 249);
			this.btnTrove.Name = "btnTrove";
			this.btnTrove.Size = new System.Drawing.Size(105, 40);
			this.btnTrove.TabIndex = 25;
			this.btnTrove.Text = "Trở Về";
			this.btnTrove.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(11, 14);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 19);
			this.label1.TabIndex = 24;
			this.label1.Text = "Tìm Kiếm Theo Mã Hóa Đơn";
			// 
			// dgv
			// 
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaKH,
            this.NgayLapHD,
            this.TongTien});
			this.dgv.Location = new System.Drawing.Point(11, 51);
			this.dgv.Margin = new System.Windows.Forms.Padding(2);
			this.dgv.Name = "dgv";
			this.dgv.RowTemplate.Height = 24;
			this.dgv.Size = new System.Drawing.Size(453, 193);
			this.dgv.TabIndex = 23;
			// 
			// MaHD
			// 
			this.MaHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaHD.DataPropertyName = "MaHD";
			this.MaHD.HeaderText = "Mã Hóa Đơn";
			this.MaHD.Name = "MaHD";
			// 
			// MaKH
			// 
			this.MaKH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaKH.DataPropertyName = "MaKH";
			this.MaKH.HeaderText = "Mã Khách Hàng";
			this.MaKH.Name = "MaKH";
			// 
			// NgayLapHD
			// 
			this.NgayLapHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.NgayLapHD.DataPropertyName = "NgayLapHD";
			this.NgayLapHD.HeaderText = "Ngày Lập Hóa Đơn";
			this.NgayLapHD.Name = "NgayLapHD";
			// 
			// TongTien
			// 
			this.TongTien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.TongTien.DataPropertyName = "TongTien";
			this.TongTien.HeaderText = "Tổng Tiền ";
			this.TongTien.Name = "TongTien";
			// 
			// txttim
			// 
			this.txttim.Location = new System.Drawing.Point(221, 15);
			this.txttim.Margin = new System.Windows.Forms.Padding(2);
			this.txttim.Name = "txttim";
			this.txttim.Size = new System.Drawing.Size(188, 20);
			this.txttim.TabIndex = 22;
			// 
			// formTimHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 296);
			this.Controls.Add(this.btnTrove);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgv);
			this.Controls.Add(this.txttim);
			this.Name = "formTimHoaDon";
			this.Text = "Tìm kiếm hóa đơn";
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnTrove;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
		private System.Windows.Forms.TextBox txttim;
	}
}