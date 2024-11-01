namespace techservice_winforms
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
			btnClients = new Button();
			labelLoginTitle = new Label();
			labelLogin = new Label();
			labelPassword = new Label();
			tbLogin = new TextBox();
			tbPassword = new TextBox();
			btnLogin = new Button();
			btnRegister = new Button();
			btnUsers = new Button();
			btnEquipment = new Button();
			btnSpareParts = new Button();
			btnRequests = new Button();
			labelUsername = new Label();
			btnEmployees = new Button();
			flpButtons = new FlowLayoutPanel();
			btnNewRequest = new Button();
			labelButtonPanel = new Label();
			btnLogout = new Button();
			flpButtons.SuspendLayout();
			SuspendLayout();
			// 
			// btnClients
			// 
			btnClients.Anchor = AnchorStyles.Top;
			btnClients.Location = new Point(3, 61);
			btnClients.Name = "btnClients";
			btnClients.Size = new Size(135, 23);
			btnClients.TabIndex = 0;
			btnClients.Text = "Клиенты";
			btnClients.UseVisualStyleBackColor = true;
			btnClients.Visible = false;
			btnClients.Click += btnClients_Click;
			// 
			// labelLoginTitle
			// 
			labelLoginTitle.AutoSize = true;
			labelLoginTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
			labelLoginTitle.Location = new Point(375, 9);
			labelLoginTitle.Name = "labelLoginTitle";
			labelLoginTitle.Size = new Size(66, 30);
			labelLoginTitle.TabIndex = 1;
			labelLoginTitle.Text = "Вход";
			// 
			// labelLogin
			// 
			labelLogin.AutoSize = true;
			labelLogin.Font = new Font("Segoe UI", 12F);
			labelLogin.Location = new Point(298, 82);
			labelLogin.Name = "labelLogin";
			labelLogin.Size = new Size(54, 21);
			labelLogin.TabIndex = 2;
			labelLogin.Text = "Логин";
			// 
			// labelPassword
			// 
			labelPassword.AutoSize = true;
			labelPassword.Font = new Font("Segoe UI", 12F);
			labelPassword.Location = new Point(298, 156);
			labelPassword.Name = "labelPassword";
			labelPassword.Size = new Size(63, 21);
			labelPassword.TabIndex = 3;
			labelPassword.Text = "Пароль";
			// 
			// tbLogin
			// 
			tbLogin.Location = new Point(298, 106);
			tbLogin.Name = "tbLogin";
			tbLogin.Size = new Size(220, 23);
			tbLogin.TabIndex = 4;
			// 
			// tbPassword
			// 
			tbPassword.Location = new Point(298, 180);
			tbPassword.Name = "tbPassword";
			tbPassword.Size = new Size(220, 23);
			tbPassword.TabIndex = 5;
			// 
			// btnLogin
			// 
			btnLogin.Font = new Font("Segoe UI", 14F);
			btnLogin.Location = new Point(360, 220);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(95, 40);
			btnLogin.TabIndex = 6;
			btnLogin.Text = "Войти";
			btnLogin.UseVisualStyleBackColor = true;
			btnLogin.Click += btnLogin_Click;
			// 
			// btnRegister
			// 
			btnRegister.Font = new Font("Segoe UI", 14F);
			btnRegister.Location = new Point(293, 315);
			btnRegister.Name = "btnRegister";
			btnRegister.Size = new Size(230, 40);
			btnRegister.TabIndex = 7;
			btnRegister.Text = "Зарегистрироваться";
			btnRegister.UseVisualStyleBackColor = true;
			btnRegister.Click += btnRegister_Click;
			// 
			// btnUsers
			// 
			btnUsers.Anchor = AnchorStyles.Top;
			btnUsers.Location = new Point(3, 3);
			btnUsers.Name = "btnUsers";
			btnUsers.Size = new Size(135, 23);
			btnUsers.TabIndex = 8;
			btnUsers.Text = "Пользователи";
			btnUsers.UseVisualStyleBackColor = true;
			btnUsers.Visible = false;
			btnUsers.Click += btnUsers_Click;
			// 
			// btnEquipment
			// 
			btnEquipment.Anchor = AnchorStyles.Top;
			btnEquipment.Location = new Point(3, 90);
			btnEquipment.Name = "btnEquipment";
			btnEquipment.Size = new Size(135, 23);
			btnEquipment.TabIndex = 9;
			btnEquipment.Text = "Оборудование";
			btnEquipment.UseVisualStyleBackColor = true;
			btnEquipment.Visible = false;
			// 
			// btnSpareParts
			// 
			btnSpareParts.Anchor = AnchorStyles.Top;
			btnSpareParts.Location = new Point(3, 119);
			btnSpareParts.Name = "btnSpareParts";
			btnSpareParts.Size = new Size(135, 23);
			btnSpareParts.TabIndex = 10;
			btnSpareParts.Text = "Детали";
			btnSpareParts.UseVisualStyleBackColor = true;
			btnSpareParts.Visible = false;
			// 
			// btnRequests
			// 
			btnRequests.Anchor = AnchorStyles.Top;
			btnRequests.Location = new Point(3, 148);
			btnRequests.Name = "btnRequests";
			btnRequests.Size = new Size(135, 23);
			btnRequests.TabIndex = 11;
			btnRequests.Text = "Запросы";
			btnRequests.UseVisualStyleBackColor = true;
			btnRequests.Visible = false;
			// 
			// labelUsername
			// 
			labelUsername.AutoSize = true;
			labelUsername.Font = new Font("Segoe UI", 9F);
			labelUsername.Location = new Point(12, 9);
			labelUsername.Name = "labelUsername";
			labelUsername.Size = new Size(183, 15);
			labelUsername.TabIndex = 12;
			labelUsername.Text = "Войдите или зарегистрируйтесь";
			// 
			// btnEmployees
			// 
			btnEmployees.Anchor = AnchorStyles.Top;
			btnEmployees.Location = new Point(3, 32);
			btnEmployees.Name = "btnEmployees";
			btnEmployees.Size = new Size(135, 23);
			btnEmployees.TabIndex = 13;
			btnEmployees.Text = "Работники";
			btnEmployees.UseVisualStyleBackColor = true;
			btnEmployees.Visible = false;
			// 
			// flpButtons
			// 
			flpButtons.Controls.Add(btnUsers);
			flpButtons.Controls.Add(btnEmployees);
			flpButtons.Controls.Add(btnClients);
			flpButtons.Controls.Add(btnEquipment);
			flpButtons.Controls.Add(btnSpareParts);
			flpButtons.Controls.Add(btnRequests);
			flpButtons.Controls.Add(btnNewRequest);
			flpButtons.Location = new Point(642, 27);
			flpButtons.Name = "flpButtons";
			flpButtons.Size = new Size(146, 411);
			flpButtons.TabIndex = 14;
			// 
			// btnNewRequest
			// 
			btnNewRequest.Anchor = AnchorStyles.Top;
			btnNewRequest.Location = new Point(3, 177);
			btnNewRequest.Name = "btnNewRequest";
			btnNewRequest.Size = new Size(135, 23);
			btnNewRequest.TabIndex = 14;
			btnNewRequest.Text = "Оставить запрос";
			btnNewRequest.UseVisualStyleBackColor = true;
			btnNewRequest.Visible = false;
			// 
			// labelButtonPanel
			// 
			labelButtonPanel.AutoSize = true;
			labelButtonPanel.Location = new Point(665, 9);
			labelButtonPanel.Name = "labelButtonPanel";
			labelButtonPanel.Size = new Size(101, 15);
			labelButtonPanel.TabIndex = 15;
			labelButtonPanel.Text = "Панель действий";
			labelButtonPanel.Visible = false;
			// 
			// btnLogout
			// 
			btnLogout.Location = new Point(12, 27);
			btnLogout.Name = "btnLogout";
			btnLogout.Size = new Size(75, 23);
			btnLogout.TabIndex = 16;
			btnLogout.Text = "Выйти";
			btnLogout.UseVisualStyleBackColor = true;
			btnLogout.Visible = false;
			btnLogout.Click += btnLogout_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(btnLogout);
			Controls.Add(labelButtonPanel);
			Controls.Add(flpButtons);
			Controls.Add(labelUsername);
			Controls.Add(btnRegister);
			Controls.Add(btnLogin);
			Controls.Add(tbPassword);
			Controls.Add(tbLogin);
			Controls.Add(labelPassword);
			Controls.Add(labelLogin);
			Controls.Add(labelLoginTitle);
			Name = "MainForm";
			Text = "Главная";
			Load += MainForm_Load;
			flpButtons.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnClients;
		private Label labelLoginTitle;
		private Label labelLogin;
		private Label labelPassword;
		private TextBox tbLogin;
		private TextBox tbPassword;
		private Button btnLogin;
		private Button btnRegister;
		private Button btnUsers;
		private Button btnEquipment;
		private Button btnSpareParts;
		private Button btnRequests;
		private Label labelUsername;
		private Button btnEmployees;
		private FlowLayoutPanel flpButtons;
		private Label labelButtonPanel;
		private Button btnLogout;
		private Button btnNewRequest;
	}
}
