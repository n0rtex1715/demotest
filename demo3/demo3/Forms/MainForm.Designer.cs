namespace demo3
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			buttonTestConnection = new Button();
			labelCurrentUser = new Label();
			buttonLogin = new Button();
			buttonClients = new Button();
			SuspendLayout();
			// 
			// buttonTestConnection
			// 
			buttonTestConnection.Location = new Point(713, 12);
			buttonTestConnection.Name = "buttonTestConnection";
			buttonTestConnection.Size = new Size(75, 23);
			buttonTestConnection.TabIndex = 0;
			buttonTestConnection.Text = "Test";
			buttonTestConnection.UseVisualStyleBackColor = true;
			buttonTestConnection.Click += buttonTestConnection_Click;
			// 
			// labelCurrentUser
			// 
			labelCurrentUser.AutoSize = true;
			labelCurrentUser.Location = new Point(12, 9);
			labelCurrentUser.Name = "labelCurrentUser";
			labelCurrentUser.Size = new Size(145, 15);
			labelCurrentUser.TabIndex = 1;
			labelCurrentUser.Text = "Авторизуйтесь в системе";
			// 
			// buttonLogin
			// 
			buttonLogin.Location = new Point(12, 27);
			buttonLogin.Name = "buttonLogin";
			buttonLogin.Size = new Size(75, 23);
			buttonLogin.TabIndex = 2;
			buttonLogin.Text = "Вход";
			buttonLogin.UseVisualStyleBackColor = true;
			buttonLogin.Click += buttonLogin_Click;
			// 
			// buttonClients
			// 
			buttonClients.Location = new Point(12, 56);
			buttonClients.Name = "buttonClients";
			buttonClients.Size = new Size(75, 23);
			buttonClients.TabIndex = 3;
			buttonClients.Text = "Клиенты";
			buttonClients.UseVisualStyleBackColor = true;
			buttonClients.Click += buttonClients_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonClients);
			Controls.Add(buttonLogin);
			Controls.Add(labelCurrentUser);
			Controls.Add(buttonTestConnection);
			Name = "MainForm";
			Text = "Главная форма";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button buttonTestConnection;
		private Label labelCurrentUser;
		private Button buttonLogin;
		private Button buttonClients;
	}
}
