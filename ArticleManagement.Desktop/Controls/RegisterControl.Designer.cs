namespace ArticleManagement.Desktop.Controls
{
	partial class RegisterControl
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
			tableLayoutPanel2 = new TableLayoutPanel();
			loginLabel = new Label();
			passwordPanel = new Panel();
			passwordTextBox = new TextBox();
			passwordLabel = new Label();
			errorLabel = new Label();
			RegisterButton = new Button();
			registerLabel = new LinkLabel();
			emailPanel = new Panel();
			emailTextBox = new TextBox();
			emailLabel = new Label();
			namePanel = new Panel();
			nameTextBox = new TextBox();
			label1 = new Label();
			tableLayoutPanel2.SuspendLayout();
			passwordPanel.SuspendLayout();
			emailPanel.SuspendLayout();
			namePanel.SuspendLayout();
			SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			tableLayoutPanel2.ColumnCount = 1;
			tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle());
			tableLayoutPanel2.Controls.Add(loginLabel, 0, 0);
			tableLayoutPanel2.Controls.Add(passwordPanel, 0, 3);
			tableLayoutPanel2.Controls.Add(errorLabel, 0, 4);
			tableLayoutPanel2.Controls.Add(RegisterButton, 0, 5);
			tableLayoutPanel2.Controls.Add(registerLabel, 0, 6);
			tableLayoutPanel2.Controls.Add(emailPanel, 0, 2);
			tableLayoutPanel2.Controls.Add(namePanel, 0, 1);
			tableLayoutPanel2.Dock = DockStyle.Fill;
			tableLayoutPanel2.Location = new Point(0, 0);
			tableLayoutPanel2.Name = "tableLayoutPanel2";
			tableLayoutPanel2.RowCount = 7;
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle());
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
			tableLayoutPanel2.Size = new Size(450, 400);
			tableLayoutPanel2.TabIndex = 9;
			// 
			// loginLabel
			// 
			loginLabel.Anchor = AnchorStyles.None;
			loginLabel.AutoSize = true;
			loginLabel.Font = new Font("Segoe UI", 22F);
			loginLabel.Location = new Point(162, 19);
			loginLabel.Name = "loginLabel";
			loginLabel.RightToLeft = RightToLeft.No;
			loginLabel.Size = new Size(125, 41);
			loginLabel.TabIndex = 0;
			loginLabel.Text = "Register";
			loginLabel.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// passwordPanel
			// 
			passwordPanel.Anchor = AnchorStyles.None;
			passwordPanel.Controls.Add(passwordTextBox);
			passwordPanel.Controls.Add(passwordLabel);
			passwordPanel.Location = new Point(125, 195);
			passwordPanel.Name = "passwordPanel";
			passwordPanel.Size = new Size(200, 50);
			passwordPanel.TabIndex = 8;
			// 
			// passwordTextBox
			// 
			passwordTextBox.Dock = DockStyle.Top;
			passwordTextBox.Font = new Font("Segoe UI", 12F);
			passwordTextBox.Location = new Point(0, 21);
			passwordTextBox.Margin = new Padding(3, 2, 3, 2);
			passwordTextBox.Name = "passwordTextBox";
			passwordTextBox.PasswordChar = '●';
			passwordTextBox.Size = new Size(200, 29);
			passwordTextBox.TabIndex = 5;
			// 
			// passwordLabel
			// 
			passwordLabel.AutoSize = true;
			passwordLabel.Dock = DockStyle.Top;
			passwordLabel.Font = new Font("Segoe UI", 12F);
			passwordLabel.Location = new Point(0, 0);
			passwordLabel.Name = "passwordLabel";
			passwordLabel.Size = new Size(79, 21);
			passwordLabel.TabIndex = 4;
			passwordLabel.Text = "Password:";
			// 
			// errorLabel
			// 
			errorLabel.Anchor = AnchorStyles.None;
			errorLabel.AutoSize = true;
			errorLabel.Font = new Font("Segoe UI", 10F);
			errorLabel.ForeColor = Color.Red;
			errorLabel.Location = new Point(225, 248);
			errorLabel.Name = "errorLabel";
			errorLabel.Size = new Size(0, 19);
			errorLabel.TabIndex = 9;
			// 
			// RegisterButton
			// 
			RegisterButton.Anchor = AnchorStyles.None;
			RegisterButton.AutoSize = true;
			RegisterButton.Font = new Font("Segoe UI", 12F);
			RegisterButton.Location = new Point(186, 280);
			RegisterButton.Margin = new Padding(3, 2, 3, 2);
			RegisterButton.Name = "RegisterButton";
			RegisterButton.Size = new Size(77, 31);
			RegisterButton.TabIndex = 3;
			RegisterButton.Text = "Register";
			RegisterButton.UseVisualStyleBackColor = true;
			// 
			// registerLabel
			// 
			registerLabel.Anchor = AnchorStyles.Top;
			registerLabel.AutoSize = true;
			registerLabel.Location = new Point(134, 323);
			registerLabel.Name = "registerLabel";
			registerLabel.Size = new Size(181, 15);
			registerLabel.TabIndex = 4;
			registerLabel.TabStop = true;
			registerLabel.Text = "Already have an account? Sign In";
			registerLabel.LinkClicked += registerLabel_LinkClicked;
			// 
			// emailPanel
			// 
			emailPanel.Anchor = AnchorStyles.None;
			emailPanel.Controls.Add(emailTextBox);
			emailPanel.Controls.Add(emailLabel);
			emailPanel.Location = new Point(125, 139);
			emailPanel.Name = "emailPanel";
			emailPanel.Size = new Size(200, 50);
			emailPanel.TabIndex = 8;
			// 
			// emailTextBox
			// 
			emailTextBox.Dock = DockStyle.Top;
			emailTextBox.Font = new Font("Segoe UI", 12F);
			emailTextBox.Location = new Point(0, 21);
			emailTextBox.Margin = new Padding(3, 2, 3, 2);
			emailTextBox.Name = "emailTextBox";
			emailTextBox.Size = new Size(200, 29);
			emailTextBox.TabIndex = 2;
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Dock = DockStyle.Top;
			emailLabel.Font = new Font("Segoe UI", 12F);
			emailLabel.Location = new Point(0, 0);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new Size(57, 21);
			emailLabel.TabIndex = 1;
			emailLabel.Text = "E-mail:";
			// 
			// namePanel
			// 
			namePanel.Anchor = AnchorStyles.None;
			namePanel.Controls.Add(nameTextBox);
			namePanel.Controls.Add(label1);
			namePanel.Location = new Point(125, 83);
			namePanel.Name = "namePanel";
			namePanel.Size = new Size(200, 50);
			namePanel.TabIndex = 8;
			// 
			// nameTextBox
			// 
			nameTextBox.Dock = DockStyle.Top;
			nameTextBox.Font = new Font("Segoe UI", 12F);
			nameTextBox.Location = new Point(0, 21);
			nameTextBox.Margin = new Padding(3, 2, 3, 2);
			nameTextBox.Name = "nameTextBox";
			nameTextBox.Size = new Size(200, 29);
			nameTextBox.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Dock = DockStyle.Top;
			label1.Font = new Font("Segoe UI", 12F);
			label1.Location = new Point(0, 0);
			label1.Name = "label1";
			label1.Size = new Size(55, 21);
			label1.TabIndex = 1;
			label1.Text = "Name:";
			// 
			// RegisterControl
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(tableLayoutPanel2);
			Name = "RegisterControl";
			Size = new Size(450, 400);
			tableLayoutPanel2.ResumeLayout(false);
			tableLayoutPanel2.PerformLayout();
			passwordPanel.ResumeLayout(false);
			passwordPanel.PerformLayout();
			emailPanel.ResumeLayout(false);
			emailPanel.PerformLayout();
			namePanel.ResumeLayout(false);
			namePanel.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private TableLayoutPanel tableLayoutPanel2;
		private Label loginLabel;
		private Panel emailPanel;
		private TextBox emailTextBox;
		private Label emailLabel;
		private Panel passwordPanel;
		private TextBox passwordTextBox;
		private Label passwordLabel;
		private Label errorLabel;
		private Button RegisterButton;
		private LinkLabel registerLabel;
		private Panel namePanel;
		private TextBox nameTextBox;
		private Label label1;
	}
}
