namespace techservice_winforms.Forms
{
	partial class AddClientForm
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
			labelClientName = new Label();
			labelClientContactInfo = new Label();
			tbClientName = new TextBox();
			btnConfirm = new Button();
			btnCancel = new Button();
			tbClientContactInfo = new TextBox();
			SuspendLayout();
			// 
			// labelClientName
			// 
			labelClientName.AutoSize = true;
			labelClientName.Location = new Point(12, 9);
			labelClientName.Name = "labelClientName";
			labelClientName.Size = new Size(82, 15);
			labelClientName.TabIndex = 0;
			labelClientName.Text = "ФИО Клиента";
			// 
			// labelClientContactInfo
			// 
			labelClientContactInfo.AutoSize = true;
			labelClientContactInfo.Location = new Point(12, 53);
			labelClientContactInfo.Name = "labelClientContactInfo";
			labelClientContactInfo.Size = new Size(144, 15);
			labelClientContactInfo.TabIndex = 1;
			labelClientContactInfo.Text = "Контактная информация";
			// 
			// tbClientName
			// 
			tbClientName.Location = new Point(12, 27);
			tbClientName.Name = "tbClientName";
			tbClientName.Size = new Size(250, 23);
			tbClientName.TabIndex = 2;
			tbClientName.TextChanged += tbClientName_TextChanged;
			// 
			// btnConfirm
			// 
			btnConfirm.Location = new Point(268, 81);
			btnConfirm.Name = "btnConfirm";
			btnConfirm.Size = new Size(75, 23);
			btnConfirm.TabIndex = 4;
			btnConfirm.Text = "Добавить";
			btnConfirm.UseVisualStyleBackColor = true;
			btnConfirm.Click += btnConfirm_Click;
			// 
			// btnCancel
			// 
			btnCancel.Location = new Point(347, 81);
			btnCancel.Name = "btnCancel";
			btnCancel.Size = new Size(75, 23);
			btnCancel.TabIndex = 5;
			btnCancel.Text = "Отмена";
			btnCancel.UseVisualStyleBackColor = true;
			btnCancel.Click += btnCancel_Click;
			// 
			// tbClientContactInfo
			// 
			tbClientContactInfo.Location = new Point(12, 71);
			tbClientContactInfo.Name = "tbClientContactInfo";
			tbClientContactInfo.Size = new Size(250, 23);
			tbClientContactInfo.TabIndex = 6;
			tbClientContactInfo.TextChanged += tbClientContactInfo_TextChanged;
			// 
			// AddClientForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(434, 116);
			Controls.Add(tbClientContactInfo);
			Controls.Add(btnCancel);
			Controls.Add(btnConfirm);
			Controls.Add(tbClientName);
			Controls.Add(labelClientContactInfo);
			Controls.Add(labelClientName);
			Name = "AddClientForm";
			Text = "Добавить клиента";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label labelClientName;
		private Label labelClientContactInfo;
		private TextBox tbClientName;
		private Button btnConfirm;
		private Button btnCancel;
		private TextBox tbClientContactInfo;
	}
}