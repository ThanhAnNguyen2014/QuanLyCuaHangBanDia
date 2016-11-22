namespace QuanLyCuaHangBanDia
{
	partial class Login
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
			this.txtPass = new System.Windows.Forms.TextBox();
			this.btnExit = new System.Windows.Forms.Button();
			this.labPass = new System.Windows.Forms.Label();
			this.txtUser = new System.Windows.Forms.TextBox();
			this.labUser = new System.Windows.Forms.Label();
			this.btnLogin = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtPass
			// 
			this.txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
			this.txtPass.Location = new System.Drawing.Point(189, 94);
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '*';
			this.txtPass.Size = new System.Drawing.Size(172, 20);
			this.txtPass.TabIndex = 2;
			// 
			// btnExit
			// 
			this.btnExit.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnExit.Location = new System.Drawing.Point(239, 138);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(99, 33);
			this.btnExit.TabIndex = 4;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// labPass
			// 
			this.labPass.AutoSize = true;
			this.labPass.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labPass.ForeColor = System.Drawing.Color.Blue;
			this.labPass.Location = new System.Drawing.Point(68, 91);
			this.labPass.Name = "labPass";
			this.labPass.Size = new System.Drawing.Size(97, 23);
			this.labPass.TabIndex = 11;
			this.labPass.Text = "Password:";
			// 
			// txtUser
			// 
			this.txtUser.Location = new System.Drawing.Point(189, 52);
			this.txtUser.Name = "txtUser";
			this.txtUser.Size = new System.Drawing.Size(172, 20);
			this.txtUser.TabIndex = 1;
			// 
			// labUser
			// 
			this.labUser.AutoSize = true;
			this.labUser.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labUser.ForeColor = System.Drawing.Color.Blue;
			this.labUser.Location = new System.Drawing.Point(68, 49);
			this.labUser.Name = "labUser";
			this.labUser.Size = new System.Drawing.Size(107, 23);
			this.labUser.TabIndex = 9;
			this.labUser.Text = "User name:";
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Consolas", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLogin.Location = new System.Drawing.Point(108, 138);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(99, 33);
			this.btnLogin.TabIndex = 3;
			this.btnLogin.Text = "Login";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Blue;
			this.label1.Location = new System.Drawing.Point(104, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(213, 22);
			this.label1.TabIndex = 12;
			this.label1.Text = "Đăng nhập vào hệ thống.";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(425, 221);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtPass);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.labPass);
			this.Controls.Add(this.txtUser);
			this.Controls.Add(this.labUser);
			this.Controls.Add(this.btnLogin);
			this.Name = "Login";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtPass;
		private System.Windows.Forms.Button btnExit;
		private System.Windows.Forms.Label labPass;
		private System.Windows.Forms.TextBox txtUser;
		private System.Windows.Forms.Label labUser;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Label label1;
	}
}