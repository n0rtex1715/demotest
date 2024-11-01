namespace test.Forms
{
	partial class DialogForm
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
			buttonOK = new Button();
			tbLogin = new TextBox();
			tbPassword = new TextBox();
			SuspendLayout();
			// 
			// buttonOK
			// 
			buttonOK.Location = new Point(171, 72);
			buttonOK.Name = "buttonOK";
			buttonOK.Size = new Size(75, 23);
			buttonOK.TabIndex = 0;
			buttonOK.Text = "Auth";
			buttonOK.UseVisualStyleBackColor = true;
			buttonOK.Click += buttonOK_Click;
			// 
			// tbLogin
			// 
			tbLogin.Location = new Point(12, 12);
			tbLogin.Name = "tbLogin";
			tbLogin.Size = new Size(177, 23);
			tbLogin.TabIndex = 1;
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(12, 41);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(177, 23);
			tbPassword.TabIndex = 2;
			// 
			// DialogForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(258, 107);
			Controls.Add(tbPassword);
			Controls.Add(tbLogin);
			Controls.Add(buttonOK);
			Name = "DialogForm";
			Text = "DialogForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonOK;
		private TextBox tbLogin;
		private TextBox tbPassword;
	}
}