namespace QuanLyCuaHangBanDia
{
	partial class formDia
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
			this.btnOK = new System.Windows.Forms.Button();
			this.btnTrove = new System.Windows.Forms.Button();
			this.dgvdia = new System.Windows.Forms.DataGridView();
			this.MaD1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TuaDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label5 = new System.Windows.Forms.Label();
			this.btnShowAll = new System.Windows.Forms.Button();
			this.dgvhoadon = new System.Windows.Forms.DataGridView();
			this.MaD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.soluongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.xemloainao = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvdia)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnOK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(312, 11);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(103, 38);
			this.btnOK.TabIndex = 59;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// btnTrove
			// 
			this.btnTrove.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnTrove.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrove.ForeColor = System.Drawing.Color.Black;
			this.btnTrove.Location = new System.Drawing.Point(580, 12);
			this.btnTrove.Name = "btnTrove";
			this.btnTrove.Size = new System.Drawing.Size(118, 37);
			this.btnTrove.TabIndex = 58;
			this.btnTrove.Text = "Trở Về";
			this.btnTrove.UseVisualStyleBackColor = false;
			this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
			// 
			// dgvdia
			// 
			this.dgvdia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvdia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaD1,
            this.TuaDia,
            this.NSX,
            this.SoLuong,
            this.DonGia});
			this.dgvdia.Location = new System.Drawing.Point(226, 80);
			this.dgvdia.Margin = new System.Windows.Forms.Padding(2);
			this.dgvdia.Name = "dgvdia";
			this.dgvdia.RowTemplate.Height = 24;
			this.dgvdia.Size = new System.Drawing.Size(561, 259);
			this.dgvdia.TabIndex = 57;
			// 
			// MaD1
			// 
			this.MaD1.DataPropertyName = "MaD";
			this.MaD1.HeaderText = "Mã Đĩa";
			this.MaD1.Name = "MaD1";
			// 
			// TuaDia
			// 
			this.TuaDia.DataPropertyName = "TuaDia";
			this.TuaDia.HeaderText = "Tên Đĩa";
			this.TuaDia.Name = "TuaDia";
			// 
			// NSX
			// 
			this.NSX.DataPropertyName = "NSX";
			this.NSX.HeaderText = "Nhà Sản Xuất";
			this.NSX.Name = "NSX";
			// 
			// SoLuong
			// 
			this.SoLuong.DataPropertyName = "SoLuong";
			this.SoLuong.HeaderText = "Số Lượng Tồn Kho ";
			this.SoLuong.Name = "SoLuong";
			// 
			// DonGia
			// 
			this.DonGia.DataPropertyName = "DonGia";
			this.DonGia.HeaderText = "Đơn Giá";
			this.DonGia.Name = "DonGia";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Red;
			this.label5.Location = new System.Drawing.Point(1, 44);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(146, 25);
			this.label5.TabIndex = 56;
			this.label5.Text = "Danh Sách:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnShowAll
			// 
			this.btnShowAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnShowAll.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowAll.Location = new System.Drawing.Point(434, 11);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(118, 38);
			this.btnShowAll.TabIndex = 55;
			this.btnShowAll.Text = "&Show All";
			this.btnShowAll.UseVisualStyleBackColor = false;
			this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
			// 
			// dgvhoadon
			// 
			this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaD,
            this.soluongban});
			this.dgvhoadon.Location = new System.Drawing.Point(5, 80);
			this.dgvhoadon.Margin = new System.Windows.Forms.Padding(2);
			this.dgvhoadon.Name = "dgvhoadon";
			this.dgvhoadon.RowTemplate.Height = 24;
			this.dgvhoadon.Size = new System.Drawing.Size(217, 259);
			this.dgvhoadon.TabIndex = 54;
			this.dgvhoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvhoadon_CellClick);
			// 
			// MaD
			// 
			this.MaD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.MaD.DataPropertyName = "Mad";
			this.MaD.HeaderText = "Mã Đĩa";
			this.MaD.Name = "MaD";
			// 
			// soluongban
			// 
			this.soluongban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.soluongban.DataPropertyName = "soluongban";
			this.soluongban.HeaderText = "Số Lượng Bán Được";
			this.soluongban.Name = "soluongban";
			this.soluongban.ReadOnly = true;
			// 
			// xemloainao
			// 
			this.xemloainao.DisplayMember = "ten";
			this.xemloainao.FormattingEnabled = true;
			this.xemloainao.Location = new System.Drawing.Point(153, 11);
			this.xemloainao.Margin = new System.Windows.Forms.Padding(2);
			this.xemloainao.Name = "xemloainao";
			this.xemloainao.Size = new System.Drawing.Size(124, 21);
			this.xemloainao.TabIndex = 53;
			this.xemloainao.ValueMember = "ma";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(87, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 19);
			this.label2.TabIndex = 52;
			this.label2.Text = "Tháng:";
			// 
			// formDia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(792, 339);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnTrove);
			this.Controls.Add(this.dgvdia);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.dgvhoadon);
			this.Controls.Add(this.xemloainao);
			this.Controls.Add(this.label2);
			this.Name = "formDia";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Thống Kê Đĩa";
			((System.ComponentModel.ISupportInitialize)(this.dgvdia)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.Button btnTrove;
		private System.Windows.Forms.DataGridView dgvdia;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button btnShowAll;
		private System.Windows.Forms.DataGridView dgvhoadon;
		private System.Windows.Forms.ComboBox xemloainao;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaD;
		private System.Windows.Forms.DataGridViewTextBoxColumn soluongban;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaD1;
		private System.Windows.Forms.DataGridViewTextBoxColumn TuaDia;
		private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
	}
}