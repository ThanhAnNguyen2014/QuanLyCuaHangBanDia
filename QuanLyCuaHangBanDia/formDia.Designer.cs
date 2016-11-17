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
			this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NXB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaS1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvsach = new System.Windows.Forms.DataGridView();
			this.btnTrove = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.xemloainao = new System.Windows.Forms.ComboBox();
			this.soluongban = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mas = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnShowAll = new System.Windows.Forms.Button();
			this.dgvhoadon = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvsach)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
			this.SuspendLayout();
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(480, 7);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(103, 38);
			this.btnOK.TabIndex = 59;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = false;
			// 
			// DonGia
			// 
			this.DonGia.DataPropertyName = "DonGia";
			this.DonGia.HeaderText = "Đơn Giá";
			this.DonGia.Name = "DonGia";
			// 
			// SoLuong
			// 
			this.SoLuong.DataPropertyName = "SoLuong";
			this.SoLuong.HeaderText = "Số Lượng Tồn Kho ";
			this.SoLuong.Name = "SoLuong";
			// 
			// TacGia
			// 
			this.TacGia.DataPropertyName = "TacGia";
			this.TacGia.HeaderText = "Tác Giả";
			this.TacGia.Name = "TacGia";
			// 
			// NXB
			// 
			this.NXB.DataPropertyName = "NXB";
			this.NXB.HeaderText = "Nhà Xuất Bản";
			this.NXB.Name = "NXB";
			// 
			// TuaSach
			// 
			this.TuaSach.DataPropertyName = "TuaSach";
			this.TuaSach.HeaderText = "Tên Sách";
			this.TuaSach.Name = "TuaSach";
			// 
			// MaS1
			// 
			this.MaS1.DataPropertyName = "MaS";
			this.MaS1.HeaderText = "Mã Sách";
			this.MaS1.Name = "MaS1";
			// 
			// dgvsach
			// 
			this.dgvsach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvsach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaS1,
            this.TuaSach,
            this.NXB,
            this.TacGia,
            this.SoLuong,
            this.DonGia});
			this.dgvsach.Location = new System.Drawing.Point(223, 77);
			this.dgvsach.Margin = new System.Windows.Forms.Padding(2);
			this.dgvsach.Name = "dgvsach";
			this.dgvsach.RowTemplate.Height = 24;
			this.dgvsach.Size = new System.Drawing.Size(640, 207);
			this.dgvsach.TabIndex = 57;
			// 
			// btnTrove
			// 
			this.btnTrove.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnTrove.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrove.ForeColor = System.Drawing.Color.Black;
			this.btnTrove.Location = new System.Drawing.Point(740, 8);
			this.btnTrove.Name = "btnTrove";
			this.btnTrove.Size = new System.Drawing.Size(105, 37);
			this.btnTrove.TabIndex = 58;
			this.btnTrove.Text = "Trở Về";
			this.btnTrove.UseVisualStyleBackColor = false;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(12, 38);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(153, 25);
			this.label5.TabIndex = 56;
			this.label5.Text = "Danh Sách:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// xemloainao
			// 
			this.xemloainao.DisplayMember = "ma";
			this.xemloainao.FormattingEnabled = true;
			this.xemloainao.Location = new System.Drawing.Point(316, 11);
			this.xemloainao.Margin = new System.Windows.Forms.Padding(2);
			this.xemloainao.Name = "xemloainao";
			this.xemloainao.Size = new System.Drawing.Size(124, 21);
			this.xemloainao.TabIndex = 53;
			this.xemloainao.ValueMember = "ma";
			// 
			// soluongban
			// 
			this.soluongban.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.soluongban.DataPropertyName = "soluongban";
			this.soluongban.HeaderText = "Số Lượng Bán Được";
			this.soluongban.Name = "soluongban";
			this.soluongban.ReadOnly = true;
			// 
			// Mas
			// 
			this.Mas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Mas.DataPropertyName = "Mas";
			this.Mas.HeaderText = "Mã Sách";
			this.Mas.Name = "Mas";
			// 
			// btnShowAll
			// 
			this.btnShowAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnShowAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowAll.Location = new System.Drawing.Point(600, 7);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(118, 38);
			this.btnShowAll.TabIndex = 55;
			this.btnShowAll.Text = "&Show All";
			this.btnShowAll.UseVisualStyleBackColor = false;
			// 
			// dgvhoadon
			// 
			this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mas,
            this.soluongban});
			this.dgvhoadon.Location = new System.Drawing.Point(2, 77);
			this.dgvhoadon.Margin = new System.Windows.Forms.Padding(2);
			this.dgvhoadon.Name = "dgvhoadon";
			this.dgvhoadon.RowTemplate.Height = 24;
			this.dgvhoadon.Size = new System.Drawing.Size(217, 207);
			this.dgvhoadon.TabIndex = 54;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(244, 11);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(58, 19);
			this.label2.TabIndex = 52;
			this.label2.Text = "Tháng:";
			// 
			// formDia
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(870, 291);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.dgvsach);
			this.Controls.Add(this.btnTrove);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.xemloainao);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.dgvhoadon);
			this.Controls.Add(this.label2);
			this.Name = "formDia";
			this.Text = "Xem Thông tin Đĩa Theo Tháng";
			((System.ComponentModel.ISupportInitialize)(this.dgvsach)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
		private System.Windows.Forms.DataGridViewTextBoxColumn NXB;
		private System.Windows.Forms.DataGridViewTextBoxColumn TuaSach;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaS1;
		private System.Windows.Forms.DataGridView dgvsach;
		private System.Windows.Forms.Button btnTrove;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox xemloainao;
		private System.Windows.Forms.DataGridViewTextBoxColumn soluongban;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mas;
		private System.Windows.Forms.Button btnShowAll;
		private System.Windows.Forms.DataGridView dgvhoadon;
		private System.Windows.Forms.Label label2;
	}
}