namespace demo3.Forms
{
	partial class ClientsForm
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
			dgvClients = new DataGridView();
			buttonSave = new Button();
			buttonAdd = new Button();
			labelCount = new Label();
			labelSearch = new Label();
			textBoxSearchBar = new TextBox();
			labelSortTitle = new Label();
			rbName = new RadioButton();
			rbId = new RadioButton();
			flpSortPanel = new FlowLayoutPanel();
			rbPhone = new RadioButton();
			((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
			flpSortPanel.SuspendLayout();
			SuspendLayout();
			// 
			// dgvClients
			// 
			dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvClients.Location = new Point(12, 41);
			dgvClients.Name = "dgvClients";
			dgvClients.Size = new Size(921, 411);
			dgvClients.TabIndex = 0;
			// 
			// buttonSave
			// 
			buttonSave.Location = new Point(12, 12);
			buttonSave.Name = "buttonSave";
			buttonSave.Size = new Size(75, 23);
			buttonSave.TabIndex = 1;
			buttonSave.Text = "Сохранить";
			buttonSave.UseVisualStyleBackColor = true;
			// 
			// buttonAdd
			// 
			buttonAdd.Location = new Point(93, 12);
			buttonAdd.Name = "buttonAdd";
			buttonAdd.Size = new Size(75, 23);
			buttonAdd.TabIndex = 2;
			buttonAdd.Text = "Добавить";
			buttonAdd.UseVisualStyleBackColor = true;
			// 
			// labelCount
			// 
			labelCount.AutoSize = true;
			labelCount.Location = new Point(186, 16);
			labelCount.Name = "labelCount";
			labelCount.Size = new Size(96, 15);
			labelCount.TabIndex = 4;
			labelCount.Text = "Кол-во записей:";
			// 
			// labelSearch
			// 
			labelSearch.AutoSize = true;
			labelSearch.Location = new Point(481, 15);
			labelSearch.Name = "labelSearch";
			labelSearch.Size = new Size(45, 15);
			labelSearch.TabIndex = 5;
			labelSearch.Text = "Поиск:";
			// 
			// textBoxSearchBar
			// 
			textBoxSearchBar.Location = new Point(532, 12);
			textBoxSearchBar.Name = "textBoxSearchBar";
			textBoxSearchBar.Size = new Size(256, 23);
			textBoxSearchBar.TabIndex = 6;
			textBoxSearchBar.TextChanged += textBoxSearchBar_TextChanged;
			// 
			// labelSortTitle
			// 
			labelSortTitle.AutoSize = true;
			labelSortTitle.Location = new Point(939, 20);
			labelSortTitle.Name = "labelSortTitle";
			labelSortTitle.Size = new Size(73, 15);
			labelSortTitle.TabIndex = 8;
			labelSortTitle.Text = "Сортировка";
			// 
			// rbName
			// 
			rbName.AutoSize = true;
			rbName.Location = new Point(3, 28);
			rbName.Name = "rbName";
			rbName.Size = new Size(80, 19);
			rbName.TabIndex = 1;
			rbName.TabStop = true;
			rbName.Text = "По имени";
			rbName.UseVisualStyleBackColor = true;
			rbName.CheckedChanged += rbName_CheckedChanged;
			// 
			// rbId
			// 
			rbId.AutoSize = true;
			rbId.Location = new Point(3, 3);
			rbId.Name = "rbId";
			rbId.Size = new Size(110, 19);
			rbId.TabIndex = 0;
			rbId.TabStop = true;
			rbId.Text = "По умолчанию";
			rbId.UseVisualStyleBackColor = true;
			rbId.CheckedChanged += rbId_CheckedChanged;
			// 
			// flpSortPanel
			// 
			flpSortPanel.Controls.Add(rbId);
			flpSortPanel.Controls.Add(rbName);
			flpSortPanel.Controls.Add(rbPhone);
			flpSortPanel.Location = new Point(939, 38);
			flpSortPanel.Name = "flpSortPanel";
			flpSortPanel.Size = new Size(127, 85);
			flpSortPanel.TabIndex = 7;
			// 
			// rbPhone
			// 
			rbPhone.AutoSize = true;
			rbPhone.Location = new Point(3, 53);
			rbPhone.Name = "rbPhone";
			rbPhone.Size = new Size(97, 19);
			rbPhone.TabIndex = 2;
			rbPhone.TabStop = true;
			rbPhone.Text = "По телефону";
			rbPhone.UseVisualStyleBackColor = true;
			rbPhone.CheckedChanged += rbPhone_CheckedChanged;
			// 
			// ClientsForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1254, 464);
			Controls.Add(labelSortTitle);
			Controls.Add(flpSortPanel);
			Controls.Add(textBoxSearchBar);
			Controls.Add(labelSearch);
			Controls.Add(labelCount);
			Controls.Add(buttonAdd);
			Controls.Add(buttonSave);
			Controls.Add(dgvClients);
			Name = "ClientsForm";
			Text = "ClientsForm";
			Load += ClientsForm_Load;
			((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
			flpSortPanel.ResumeLayout(false);
			flpSortPanel.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private DataGridView dgvClients;
		private Button buttonSave;
		private Button buttonAdd;
		private Button button3;
		private Label labelCount;
		private Label labelSearch;
		private TextBox textBoxSearchBar;
		private Label labelSortTitle;
		private RadioButton rbName;
		private RadioButton rbId;
		private FlowLayoutPanel flpSortPanel;
		private RadioButton rbPhone;
	}
}