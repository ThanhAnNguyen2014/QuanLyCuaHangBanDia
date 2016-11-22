namespace QuanLyCuaHangBanDia
{
	partial class FormKetNoi
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
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button6 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.txtcsdl = new System.Windows.Forms.TextBox();
			this.txtpass = new System.Windows.Forms.TextBox();
			this.txtname = new System.Windows.Forms.TextBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 130);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(57, 13);
			this.label4.TabIndex = 29;
			this.label4.Text = "Ten CSDL";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 91);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(53, 13);
			this.label3.TabIndex = 28;
			this.label3.Text = "Password";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(57, 13);
			this.label2.TabIndex = 27;
			this.label2.Text = "UserName";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 26;
			this.label1.Text = "Địa chi id";
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(144, 172);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(95, 24);
			this.button6.TabIndex = 25;
			this.button6.Text = "thoát";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(43, 174);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(95, 24);
			this.button5.TabIndex = 24;
			this.button5.Text = "kết nối";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// txtcsdl
			// 
			this.txtcsdl.Location = new System.Drawing.Point(80, 124);
			this.txtcsdl.Name = "txtcsdl";
			this.txtcsdl.Size = new System.Drawing.Size(158, 20);
			this.txtcsdl.TabIndex = 23;
			// 
			// txtpass
			// 
			this.txtpass.Location = new System.Drawing.Point(80, 88);
			this.txtpass.Name = "txtpass";
			this.txtpass.PasswordChar = '*';
			this.txtpass.Size = new System.Drawing.Size(158, 20);
			this.txtpass.TabIndex = 22;
			// 
			// txtname
			// 
			this.txtname.Location = new System.Drawing.Point(80, 50);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(158, 20);
			this.txtname.TabIndex = 21;
			// 
			// txtid
			// 
			this.txtid.Location = new System.Drawing.Point(80, 14);
			this.txtid.Name = "txtid";
			this.txtid.Size = new System.Drawing.Size(158, 20);
			this.txtid.TabIndex = 20;
			// 
			// FormKetNoi
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(274, 232);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.txtcsdl);
			this.Controls.Add(this.txtpass);
			this.Controls.Add(this.txtname);
			this.Controls.Add(this.txtid);
			this.Name = "FormKetNoi";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Kết Nối Server";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.TextBox txtcsdl;
		private System.Windows.Forms.TextBox txtpass;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.TextBox txtid;
	}
}