namespace techservice_winforms.Forms
{
	partial class UsersForm
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
			btnSave = new Button();
			btnAdd = new Button();
			labelUserCount = new Label();
			labelCount = new Label();
			flpUsers = new FlowLayoutPanel();
			flpActionPanel = new FlowLayoutPanel();
			flpActionPanel.SuspendLayout();
			SuspendLayout();
			// 
			// btnSave
			// 
			btnSave.Location = new Point(3, 3);
			btnSave.Margin = new Padding(3, 3, 3, 10);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(75, 23);
			btnSave.TabIndex = 0;
			btnSave.Text = "Сохранить";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// btnAdd
			// 
			btnAdd.Location = new Point(84, 3);
			btnAdd.Margin = new Padding(3, 3, 3, 10);
			btnAdd.Name = "btnAdd";
			btnAdd.Size = new Size(75, 23);
			btnAdd.TabIndex = 1;
			btnAdd.Text = "Добавить";
			btnAdd.UseVisualStyleBackColor = true;
			btnAdd.Click += btnAdd_Click;
			// 
			// labelUserCount
			// 
			labelUserCount.AutoSize = true;
			labelUserCount.Location = new Point(662, 8);
			labelUserCount.Margin = new Padding(500, 8, 3, 10);
			labelUserCount.Name = "labelUserCount";
			labelUserCount.Size = new Size(49, 15);
			labelUserCount.TabIndex = 3;
			labelUserCount.Text = "Кол-во:";
			// 
			// labelCount
			// 
			labelCount.AutoSize = true;
			labelCount.Location = new Point(717, 8);
			labelCount.Margin = new Padding(3, 8, 3, 10);
			labelCount.Name = "labelCount";
			labelCount.Size = new Size(13, 15);
			labelCount.TabIndex = 4;
			labelCount.Text = "0";
			// 
			// flpUsers
			// 
			flpUsers.Location = new Point(12, 51);
			flpUsers.Margin = new Padding(3, 15, 3, 3);
			flpUsers.Name = "flpUsers";
			flpUsers.Size = new Size(776, 397);
			flpUsers.TabIndex = 5;
			// 
			// flpActionPanel
			// 
			flpActionPanel.Controls.Add(btnSave);
			flpActionPanel.Controls.Add(btnAdd);
			flpActionPanel.Controls.Add(labelUserCount);
			flpActionPanel.Controls.Add(labelCount);
			flpActionPanel.Location = new Point(12, 12);
			flpActionPanel.Margin = new Padding(3, 3, 3, 15);
			flpActionPanel.Name = "flpActionPanel";
			flpActionPanel.Size = new Size(776, 33);
			flpActionPanel.TabIndex = 0;
			// 
			// UsersForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 322);
			Controls.Add(flpActionPanel);
			Controls.Add(flpUsers);
			Name = "UsersForm";
			Text = "Пользователи";
			Load += UsersForm_Load;
			flpActionPanel.ResumeLayout(false);
			flpActionPanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Button btnSave;
		private Button btnAdd;
		private Label labelUserCount;
		private Label labelCount;
		private FlowLayoutPanel flpUsers;
		private FlowLayoutPanel flpActionPanel;
	}
}