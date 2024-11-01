namespace test
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
			buttonTest = new Button();
			buttonDialog = new Button();
			SuspendLayout();
			// 
			// buttonTest
			// 
			buttonTest.Location = new Point(12, 12);
			buttonTest.Name = "buttonTest";
			buttonTest.Size = new Size(75, 23);
			buttonTest.TabIndex = 0;
			buttonTest.Text = "Conn";
			buttonTest.UseVisualStyleBackColor = true;
			buttonTest.Click += buttonTest_Click;
			// 
			// buttonDialog
			// 
			buttonDialog.Location = new Point(93, 12);
			buttonDialog.Name = "buttonDialog";
			buttonDialog.Size = new Size(75, 23);
			buttonDialog.TabIndex = 1;
			buttonDialog.Text = "Dialog";
			buttonDialog.UseVisualStyleBackColor = true;
			buttonDialog.Click += buttonDialog_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(354, 85);
			Controls.Add(buttonDialog);
			Controls.Add(buttonTest);
			Name = "MainForm";
			Text = "MainForm";
			ResumeLayout(false);
		}

		#endregion

		private Button buttonTest;
		private Button buttonDialog;
	}
}
