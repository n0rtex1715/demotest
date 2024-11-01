namespace demo3.Forms
{
	partial class LoginForm
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
			buttonAuth = new Button();
			labelLogin = new Label();
			labelPassword = new Label();
			textBoxLogin = new TextBox();
			textBoxPassword = new TextBox();
			buttonCancelAuth = new Button();
			buttonHidePassword = new Button();
			SuspendLayout();
			// 
			// buttonAuth
			// 
			buttonAuth.Location = new Point(162, 118);
			buttonAuth.Name = "buttonAuth";
			buttonAuth.Size = new Size(75, 23);
			buttonAuth.TabIndex = 0;
			buttonAuth.Text = "Войти";
			buttonAuth.UseVisualStyleBackColor = true;
			buttonAuth.Click += buttonAuth_Click;
			// 
			// labelLogin
			// 
			labelLogin.AutoSize = true;
			labelLogin.Location = new Point(12, 9);
			labelLogin.Name = "labelLogin";
			labelLogin.Size = new Size(41, 15);
			labelLogin.TabIndex = 1;
			labelLogin.Text = "Логин";
			// 
			// labelPassword
			// 
			labelPassword.AutoSize = true;
			labelPassword.Location = new Point(12, 53);
			labelPassword.Name = "labelPassword";
			labelPassword.Size = new Size(49, 15);
			labelPassword.TabIndex = 2;
			labelPassword.Text = "Пароль";
			// 
			// textBoxLogin
			// 
			textBoxLogin.Location = new Point(12, 27);
			textBoxLogin.Name = "textBoxLogin";
			textBoxLogin.Size = new Size(200, 23);
			textBoxLogin.TabIndex = 3;
			textBoxLogin.TextChanged += textBoxLogin_TextChanged;
			// 
			// textBoxPassword
			// 
			textBoxPassword.Location = new Point(12, 71);
			textBoxPassword.Name = "textBoxPassword";
			textBoxPassword.PasswordChar = '*';
			textBoxPassword.Size = new Size(200, 23);
			textBoxPassword.TabIndex = 4;
			textBoxPassword.TextChanged += textBoxPassword_TextChanged;
			// 
			// buttonCancelAuth
			// 
			buttonCancelAuth.Location = new Point(243, 118);
			buttonCancelAuth.Name = "buttonCancelAuth";
			buttonCancelAuth.Size = new Size(75, 23);
			buttonCancelAuth.TabIndex = 5;
			buttonCancelAuth.Text = "Отмена";
			buttonCancelAuth.UseVisualStyleBackColor = true;
			buttonCancelAuth.Click += buttonCancelAuth_Click;
			// 
			// buttonHidePassword
			// 
			buttonHidePassword.Location = new Point(218, 71);
			buttonHidePassword.Name = "buttonHidePassword";
			buttonHidePassword.Size = new Size(75, 23);
			buttonHidePassword.TabIndex = 6;
			buttonHidePassword.Text = "Показать";
			buttonHidePassword.UseVisualStyleBackColor = true;
			buttonHidePassword.Click += buttonHidePassword_Click;
			// 
			// LoginForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(330, 153);
			Controls.Add(buttonHidePassword);
			Controls.Add(buttonCancelAuth);
			Controls.Add(textBoxPassword);
			Controls.Add(textBoxLogin);
			Controls.Add(labelPassword);
			Controls.Add(labelLogin);
			Controls.Add(buttonAuth);
			Name = "LoginForm";
			Text = "Вход в систему";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonAuth;
		private Label labelLogin;
		private Label labelPassword;
		private TextBox textBoxLogin;
		private TextBox textBoxPassword;
		private Button buttonCancelAuth;
		private Button buttonHidePassword;
	}
}