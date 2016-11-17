namespace QuanLyCuaHangBanDia
{
	partial class formXemHoaDon
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
			this.label5 = new System.Windows.Forms.Label();
			this.dgvtinh = new System.Windows.Forms.DataGridView();
			this.bttinh = new System.Windows.Forms.Button();
			this.btnShowAll = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.tien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Ngaylap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mahd = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgvhoadon = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.xemloainao = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvtinh)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).BeginInit();
			this.SuspendLayout();
			// 
			// btnTrove
			// 
			this.btnTrove.BackColor = System.Drawing.SystemColors.ControlLight;
			this.btnTrove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnTrove.ForeColor = System.Drawing.Color.Black;
			this.btnTrove.Location = new System.Drawing.Point(543, 198);
			this.btnTrove.Name = "btnTrove";
			this.btnTrove.Size = new System.Drawing.Size(105, 43);
			this.btnTrove.TabIndex = 5;
			this.btnTrove.Text = "Trở Về";
			this.btnTrove.UseVisualStyleBackColor = false;
			this.btnTrove.Click += new System.EventHandler(this.btnTrove_Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(486, 126);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(214, 25);
			this.label1.TabIndex = 58;
			this.label1.Text = "Tổng Số Tiền:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Blue;
			this.label5.Location = new System.Drawing.Point(7, 57);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(186, 25);
			this.label5.TabIndex = 57;
			this.label5.Text = "Danh Sách Hóa Đơn:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// dgvtinh
			// 
			this.dgvtinh.AllowUserToAddRows = false;
			this.dgvtinh.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.dgvtinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvtinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvtinh.ColumnHeadersVisible = false;
			this.dgvtinh.GridColor = System.Drawing.SystemColors.Control;
			this.dgvtinh.Location = new System.Drawing.Point(521, 153);
			this.dgvtinh.Margin = new System.Windows.Forms.Padding(2);
			this.dgvtinh.Name = "dgvtinh";
			this.dgvtinh.RowHeadersVisible = false;
			this.dgvtinh.RowTemplate.Height = 24;
			this.dgvtinh.Size = new System.Drawing.Size(155, 30);
			this.dgvtinh.TabIndex = 56;
			// 
			// bttinh
			// 
			this.bttinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bttinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bttinh.Location = new System.Drawing.Point(513, 93);
			this.bttinh.Name = "bttinh";
			this.bttinh.Size = new System.Drawing.Size(170, 30);
			this.bttinh.TabIndex = 4;
			this.bttinh.Text = "Tổng Tiền";
			this.bttinh.UseVisualStyleBackColor = false;
			this.bttinh.Click += new System.EventHandler(this.bttinh_Click);
			// 
			// btnShowAll
			// 
			this.btnShowAll.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnShowAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnShowAll.Location = new System.Drawing.Point(565, 17);
			this.btnShowAll.Name = "btnShowAll";
			this.btnShowAll.Size = new System.Drawing.Size(118, 38);
			this.btnShowAll.TabIndex = 3;
			this.btnShowAll.Text = "&Show All";
			this.btnShowAll.UseVisualStyleBackColor = false;
			this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
			// 
			// btnOK
			// 
			this.btnOK.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.btnOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnOK.Location = new System.Drawing.Point(475, 17);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(84, 38);
			this.btnOK.TabIndex = 2;
			this.btnOK.Text = "&OK";
			this.btnOK.UseVisualStyleBackColor = false;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// tien
			// 
			this.tien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.tien.DataPropertyName = "tien";
			this.tien.HeaderText = "Tiền Thanh Toán";
			this.tien.Name = "tien";
			// 
			// Ngaylap
			// 
			this.Ngaylap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Ngaylap.DataPropertyName = "Ngaylap";
			this.Ngaylap.HeaderText = "Ngày Lập Hóa Đơn";
			this.Ngaylap.Name = "Ngaylap";
			this.Ngaylap.ReadOnly = true;
			// 
			// Mahd
			// 
			this.Mahd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
			this.Mahd.DataPropertyName = "MaHD";
			this.Mahd.HeaderText = "Mã Hóa Đơn";
			this.Mahd.Name = "Mahd";
			// 
			// dgvhoadon
			// 
			this.dgvhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvhoadon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mahd,
            this.Ngaylap,
            this.tien});
			this.dgvhoadon.Location = new System.Drawing.Point(11, 84);
			this.dgvhoadon.Margin = new System.Windows.Forms.Padding(2);
			this.dgvhoadon.Name = "dgvhoadon";
			this.dgvhoadon.RowTemplate.Height = 24;
			this.dgvhoadon.Size = new System.Drawing.Size(470, 259);
			this.dgvhoadon.TabIndex = 52;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(198, 17);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 19);
			this.label2.TabIndex = 50;
			this.label2.Text = "Tháng:";
			// 
			// xemloainao
			// 
			this.xemloainao.DisplayMember = "ma";
			this.xemloainao.FormattingEnabled = true;
			this.xemloainao.Location = new System.Drawing.Point(293, 17);
			this.xemloainao.Margin = new System.Windows.Forms.Padding(2);
			this.xemloainao.Name = "xemloainao";
			this.xemloainao.Size = new System.Drawing.Size(110, 21);
			this.xemloainao.TabIndex = 1;
			this.xemloainao.ValueMember = "ma";
			// 
			// formXemHoaDon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(702, 356);
			this.Controls.Add(this.btnTrove);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.dgvtinh);
			this.Controls.Add(this.bttinh);
			this.Controls.Add(this.btnShowAll);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.dgvhoadon);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.xemloainao);
			this.Name = "formXemHoaDon";
			this.Text = "Xem thôn tin Hóa Đơn";
			((System.ComponentModel.ISupportInitialize)(this.dgvtinh)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvhoadon)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnTrove;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DataGridView dgvtinh;
		private System.Windows.Forms.Button bttinh;
		private System.Windows.Forms.Button btnShowAll;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.DataGridViewTextBoxColumn tien;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ngaylap;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mahd;
		private System.Windows.Forms.DataGridView dgvhoadon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox xemloainao;
	}
}