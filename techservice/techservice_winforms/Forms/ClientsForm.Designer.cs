namespace techservice_winforms.Forms
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
            btnSave = new Button();
            dgvClients = new DataGridView();
            btnAddClient = new Button();
            labelColumnCount = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            rbSortId = new RadioButton();
            rbSortName = new RadioButton();
            labelSortType = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            ((System.ComponentModel.ISupportInitialize)dgvClients).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvClients
            // 
            dgvClients.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClients.Location = new Point(12, 41);
            dgvClients.Name = "dgvClients";
            dgvClients.Size = new Size(776, 397);
            dgvClients.TabIndex = 1;
            // 
            // btnAddClient
            // 
            btnAddClient.Location = new Point(93, 12);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new Size(75, 23);
            btnAddClient.TabIndex = 2;
            btnAddClient.Text = "Добавить";
            btnAddClient.UseVisualStyleBackColor = true;
            btnAddClient.Click += btnAddClient_Click;
            // 
            // labelColumnCount
            // 
            labelColumnCount.AutoSize = true;
            labelColumnCount.Location = new Point(699, 20);
            labelColumnCount.Name = "labelColumnCount";
            labelColumnCount.Size = new Size(49, 15);
            labelColumnCount.TabIndex = 5;
            labelColumnCount.Text = "Кол-во:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(rbSortId);
            flowLayoutPanel1.Controls.Add(rbSortName);
            flowLayoutPanel1.Location = new Point(807, 73);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(104, 171);
            flowLayoutPanel1.TabIndex = 6;
            // 
            // rbSortId
            // 
            rbSortId.AutoSize = true;
            rbSortId.Location = new Point(3, 3);
            rbSortId.Name = "rbSortId";
            rbSortId.Size = new Size(54, 19);
            rbSortId.TabIndex = 7;
            rbSortId.TabStop = true;
            rbSortId.Text = "По Id";
            rbSortId.UseVisualStyleBackColor = true;
            rbSortId.CheckedChanged += rbSortId_CheckedChanged;
            // 
            // rbSortName
            // 
            rbSortName.AutoSize = true;
            rbSortName.Location = new Point(3, 28);
            rbSortName.Name = "rbSortName";
            rbSortName.Size = new Size(80, 19);
            rbSortName.TabIndex = 8;
            rbSortName.TabStop = true;
            rbSortName.Text = "По имени";
            rbSortName.UseVisualStyleBackColor = true;
            rbSortName.CheckedChanged += rbSortName_CheckedChanged;
            // 
            // labelSortType
            // 
            labelSortType.AutoSize = true;
            labelSortType.Location = new Point(807, 55);
            labelSortType.Name = "labelSortType";
            labelSortType.Size = new Size(73, 15);
            labelSortType.TabIndex = 7;
            labelSortType.Text = "Сортировка";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // ClientsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 452);
            Controls.Add(labelSortType);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(labelColumnCount);
            Controls.Add(btnAddClient);
            Controls.Add(dgvClients);
            Controls.Add(btnSave);
            Name = "ClientsForm";
            Text = "Клиенты";
            Load += ClientsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClients).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
		private DataGridView dgvClients;
		private Button btnAddClient;
		private Label labelColumnCount;
        private FlowLayoutPanel flowLayoutPanel1;
        private RadioButton rbSortId;
        private RadioButton rbSortName;
        private Label labelSortType;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
    }
}