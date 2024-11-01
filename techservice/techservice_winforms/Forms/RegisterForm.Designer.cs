namespace techservice_winforms.Forms
{
	partial class RegisterForm
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
			labelUsername = new Label();
			labelPassword = new Label();
			tbLogin = new TextBox();
			tbPassword = new TextBox();
			labelPasswordRepeat = new Label();
			tbPasswordRepeat = new TextBox();
			btnRegister = new Button();
			SuspendLayout();
			// 
			// labelUsername
			// 
			labelUsername.AutoSize = true;
			labelUsername.Font = new Font("Segoe UI", 12F);
			labelUsername.Location = new Point(12, 9);
			labelUsername.Name = "labelUsername";
			labelUsername.Size = new Size(54, 21);
			labelUsername.TabIndex = 0;
			labelUsername.Text = "Логин";
			// 
			// labelPassword
			// 
			labelPassword.AutoSize = true;
			labelPassword.Font = new Font("Segoe UI", 12F);
			labelPassword.Location = new Point(12, 74);
			labelPassword.Name = "labelPassword";
			labelPassword.Size = new Size(63, 21);
			labelPassword.TabIndex = 1;
			labelPassword.Text = "Пароль";
			// 
			// tbLogin
			// 
			tbLogin.Location = new Point(12, 33);
			tbLogin.Name = "tbLogin";
			tbLogin.Size = new Size(220, 23);
			tbLogin.TabIndex = 2;
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(12, 98);
			tbPassword.Name = "tbPassword";
			tbPassword.PasswordChar = '*';
			tbPassword.Size = new Size(220, 23);
			tbPassword.TabIndex = 3;
			// 
			// labelPasswordRepeat
			// 
			labelPasswordRepeat.AutoSize = true;
			labelPasswordRepeat.Font = new Font("Segoe UI", 12F);
			labelPasswordRepeat.Location = new Point(12, 143);
			labelPasswordRepeat.Name = "labelPasswordRepeat";
			labelPasswordRepeat.Size = new Size(118, 21);
			labelPasswordRepeat.TabIndex = 4;
			labelPasswordRepeat.Text = "Повтор пароля";
			// 
			// tbPasswordRepeat
			// 
			tbPasswordRepeat.Location = new Point(12, 167);
			tbPasswordRepeat.Name = "tbPasswordRepeat";
			tbPasswordRepeat.PasswordChar = '*';
			tbPasswordRepeat.Size = new Size(220, 23);
			tbPasswordRepeat.TabIndex = 5;
			// 
			// btnRegister
			// 
			btnRegister.Font = new Font("Segoe UI", 12F);
			btnRegister.Location = new Point(54, 214);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(128, 31);
			btnRegister.TabIndex = 6;
			btnRegister.Text = "Регистрация";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// RegisterForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(247, 261);
			Controls.Add(btnRegister);
			Controls.Add(tbPasswordRepeat);
			Controls.Add(labelPasswordRepeat);
			Controls.Add(tbPassword);
			Controls.Add(tbLogin);
			Controls.Add(labelPassword);
			Controls.Add(labelUsername);
			Name = "RegisterForm";
			Text = "Регистрация";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelUsername;
		private Label labelPassword;
		private TextBox tbLogin;
		private TextBox tbPassword;
		private Label labelPasswordRepeat;
		private TextBox tbPasswordRepeat;
		private Button btnRegister;
	}
}