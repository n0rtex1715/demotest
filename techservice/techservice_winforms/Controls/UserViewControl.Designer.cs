namespace techservice_winforms.Controls
{
	partial class UserViewControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			labelId = new Label();
			labelName = new Label();
			labelPassword = new Label();
			tboxId = new TextBox();
			tboxLogin = new TextBox();
			tboxPassword = new TextBox();
			cboxIsEmployee = new CheckBox();
			cboxIsAdmin = new CheckBox();
			SuspendLayout();
			// 
			// labelId
			// 
			labelId.AutoSize = true;
			labelId.Location = new Point(3, 5);
			labelId.Name = "labelId";
			labelId.Size = new Size(17, 15);
			labelId.TabIndex = 0;
			labelId.Text = "Id";
			// 
			// labelName
			// 
			labelName.AutoSize = true;
			labelName.Location = new Point(58, 5);
			labelName.Name = "labelName";
			labelName.Size = new Size(41, 15);
			labelName.TabIndex = 1;
			labelName.Text = "Логин";
			// 
			// labelPassword
			// 
			labelPassword.AutoSize = true;
			labelPassword.Location = new Point(301, 5);
			labelPassword.Name = "labelPassword";
			labelPassword.Size = new Size(49, 15);
			labelPassword.TabIndex = 2;
			labelPassword.Text = "Пароль";
			// 
			// tboxId
			// 
			tboxId.Location = new Point(3, 23);
			tboxId.Name = "tboxId";
			tboxId.Size = new Size(45, 23);
			tboxId.TabIndex = 5;
			// 
			// tboxLogin
			// 
			tboxLogin.Location = new Point(58, 23);
			tboxLogin.Name = "tboxLogin";
			tboxLogin.Size = new Size(237, 23);
			tboxLogin.TabIndex = 6;
			// 
			// tboxPassword
			// 
			tboxPassword.Location = new Point(301, 23);
			tboxPassword.Name = "tboxPassword";
			tboxPassword.Size = new Size(237, 23);
			tboxPassword.TabIndex = 7;
			// 
			// cboxIsEmployee
			// 
			cboxIsEmployee.AutoSize = true;
			cboxIsEmployee.Location = new Point(544, 27);
			cboxIsEmployee.Name = "cboxIsEmployee";
			cboxIsEmployee.Size = new Size(83, 19);
			cboxIsEmployee.TabIndex = 8;
			cboxIsEmployee.Text = "Работник?";
			cboxIsEmployee.UseVisualStyleBackColor = true;
			// 
			// cboxIsAdmin
			// 
			cboxIsAdmin.AutoSize = true;
			cboxIsAdmin.Location = new Point(633, 27);
			cboxIsAdmin.Name = "cboxIsAdmin";
			cboxIsAdmin.Size = new Size(68, 19);
			cboxIsAdmin.TabIndex = 9;
			cboxIsAdmin.Text = "Админ?";
			cboxIsAdmin.UseVisualStyleBackColor = true;
			// 
			// UserViewControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(cboxIsAdmin);
			Controls.Add(cboxIsEmployee);
			Controls.Add(tboxPassword);
			Controls.Add(tboxLogin);
			Controls.Add(tboxId);
			Controls.Add(labelPassword);
			Controls.Add(labelName);
			Controls.Add(labelId);
			Name = "UserViewControl";
			Size = new Size(721, 53);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelId;
		private Label labelName;
		private Label labelPassword;
		private TextBox tboxId;
		private TextBox tboxLogin;
		private TextBox tboxPassword;
		private CheckBox cboxIsEmployee;
		private CheckBox cboxIsAdmin;
	}
}
