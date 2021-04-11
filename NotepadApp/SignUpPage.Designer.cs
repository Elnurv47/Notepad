
namespace NotepadApp
{
	partial class SignUpPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpPage));
			this.passwordIcon = new System.Windows.Forms.PictureBox();
			this.profileIconPictureBox = new System.Windows.Forms.PictureBox();
			this.usernameIcon = new System.Windows.Forms.PictureBox();
			this.closeButton = new System.Windows.Forms.Button();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.alreadyHaveAnAccountButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.signUpMessageLabel = new System.Windows.Forms.Label();
			this.passwordLabel = new System.Windows.Forms.Label();
			this.passwordBottomLinePanel = new System.Windows.Forms.Panel();
			this.usernameLabel = new System.Windows.Forms.Label();
			this.usernameBottomLinePanel = new System.Windows.Forms.Panel();
			this.backgroundLeftPanel = new System.Windows.Forms.Panel();
			this.applicatonNameLabel = new System.Windows.Forms.Label();
			this.showPasswordCheckBox = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.profileIconPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).BeginInit();
			this.backgroundLeftPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// passwordIcon
			// 
			this.passwordIcon.Image = global::NotepadApp.Properties.Resources.padlock;
			this.passwordIcon.Location = new System.Drawing.Point(376, 297);
			this.passwordIcon.Name = "passwordIcon";
			this.passwordIcon.Size = new System.Drawing.Size(32, 32);
			this.passwordIcon.TabIndex = 40;
			this.passwordIcon.TabStop = false;
			// 
			// profileIconPictureBox
			// 
			this.profileIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profileIconPictureBox.Image")));
			this.profileIconPictureBox.Location = new System.Drawing.Point(500, 51);
			this.profileIconPictureBox.Name = "profileIconPictureBox";
			this.profileIconPictureBox.Size = new System.Drawing.Size(64, 64);
			this.profileIconPictureBox.TabIndex = 34;
			this.profileIconPictureBox.TabStop = false;
			// 
			// usernameIcon
			// 
			this.usernameIcon.Image = global::NotepadApp.Properties.Resources.user_blue;
			this.usernameIcon.Location = new System.Drawing.Point(376, 200);
			this.usernameIcon.Name = "usernameIcon";
			this.usernameIcon.Size = new System.Drawing.Size(32, 32);
			this.usernameIcon.TabIndex = 31;
			this.usernameIcon.TabStop = false;
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.White;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeButton.Location = new System.Drawing.Point(655, 0);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(46, 46);
			this.closeButton.TabIndex = 40;
			this.closeButton.TabStop = false;
			this.closeButton.Text = "X";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = System.Drawing.Color.White;
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.Location = new System.Drawing.Point(414, 297);
			this.passwordTextBox.Multiline = true;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.PasswordChar = '*';
			this.passwordTextBox.Size = new System.Drawing.Size(246, 32);
			this.passwordTextBox.TabIndex = 39;
			this.passwordTextBox.Click += new System.EventHandler(this.PasswordTextBox_Click);
			this.passwordTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.PasswordTextBox_PreviewKeyDown);
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.usernameTextBox.Location = new System.Drawing.Point(418, 198);
			this.usernameTextBox.Multiline = true;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(244, 32);
			this.usernameTextBox.TabIndex = 38;
			this.usernameTextBox.Click += new System.EventHandler(this.UsernameTextBox_Click);
			this.usernameTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.UsernameTextBox_PreviewKeyDown);
			// 
			// alreadyHaveAnAccountButton
			// 
			this.alreadyHaveAnAccountButton.BackColor = System.Drawing.Color.White;
			this.alreadyHaveAnAccountButton.FlatAppearance.BorderSize = 0;
			this.alreadyHaveAnAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.alreadyHaveAnAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.alreadyHaveAnAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.alreadyHaveAnAccountButton.Location = new System.Drawing.Point(377, 440);
			this.alreadyHaveAnAccountButton.Name = "alreadyHaveAnAccountButton";
			this.alreadyHaveAnAccountButton.Size = new System.Drawing.Size(285, 38);
			this.alreadyHaveAnAccountButton.TabIndex = 37;
			this.alreadyHaveAnAccountButton.TabStop = false;
			this.alreadyHaveAnAccountButton.Text = "Already Have an Account ?";
			this.alreadyHaveAnAccountButton.UseVisualStyleBackColor = false;
			this.alreadyHaveAnAccountButton.Click += new System.EventHandler(this.AlreadyHaveAnAccountButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.White;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.loginButton.Location = new System.Drawing.Point(473, 378);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(104, 38);
			this.loginButton.TabIndex = 36;
			this.loginButton.TabStop = false;
			this.loginButton.Text = "Sign Up";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.SignUpButton_Click);
			// 
			// signUpMessageLabel
			// 
			this.signUpMessageLabel.BackColor = System.Drawing.Color.White;
			this.signUpMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.signUpMessageLabel.ForeColor = System.Drawing.Color.Gray;
			this.signUpMessageLabel.Location = new System.Drawing.Point(410, 132);
			this.signUpMessageLabel.Name = "signUpMessageLabel";
			this.signUpMessageLabel.Size = new System.Drawing.Size(228, 23);
			this.signUpMessageLabel.TabIndex = 35;
			this.signUpMessageLabel.Text = "Sign up to create an account";
			this.signUpMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// passwordLabel
			// 
			this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.passwordLabel.Location = new System.Drawing.Point(373, 265);
			this.passwordLabel.Name = "passwordLabel";
			this.passwordLabel.Size = new System.Drawing.Size(106, 29);
			this.passwordLabel.TabIndex = 33;
			this.passwordLabel.Text = "Password";
			// 
			// passwordBottomLinePanel
			// 
			this.passwordBottomLinePanel.Location = new System.Drawing.Point(376, 335);
			this.passwordBottomLinePanel.Name = "passwordBottomLinePanel";
			this.passwordBottomLinePanel.Size = new System.Drawing.Size(286, 2);
			this.passwordBottomLinePanel.TabIndex = 32;
			// 
			// usernameLabel
			// 
			this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.usernameLabel.Location = new System.Drawing.Point(372, 166);
			this.usernameLabel.Name = "usernameLabel";
			this.usernameLabel.Size = new System.Drawing.Size(106, 29);
			this.usernameLabel.TabIndex = 29;
			this.usernameLabel.Text = "Username";
			// 
			// usernameBottomLinePanel
			// 
			this.usernameBottomLinePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.usernameBottomLinePanel.Location = new System.Drawing.Point(376, 238);
			this.usernameBottomLinePanel.Name = "usernameBottomLinePanel";
			this.usernameBottomLinePanel.Size = new System.Drawing.Size(284, 2);
			this.usernameBottomLinePanel.TabIndex = 30;
			// 
			// backgroundLeftPanel
			// 
			this.backgroundLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.backgroundLeftPanel.Controls.Add(this.applicatonNameLabel);
			this.backgroundLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
			this.backgroundLeftPanel.Location = new System.Drawing.Point(0, 0);
			this.backgroundLeftPanel.Name = "backgroundLeftPanel";
			this.backgroundLeftPanel.Size = new System.Drawing.Size(330, 550);
			this.backgroundLeftPanel.TabIndex = 42;
			// 
			// applicatonNameLabel
			// 
			this.applicatonNameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.applicatonNameLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.applicatonNameLabel.Location = new System.Drawing.Point(3, 224);
			this.applicatonNameLabel.Name = "applicatonNameLabel";
			this.applicatonNameLabel.Size = new System.Drawing.Size(324, 100);
			this.applicatonNameLabel.TabIndex = 0;
			this.applicatonNameLabel.Text = "NOTEPAD";
			this.applicatonNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// showPasswordCheckBox
			// 
			this.showPasswordCheckBox.AutoSize = true;
			this.showPasswordCheckBox.Location = new System.Drawing.Point(377, 343);
			this.showPasswordCheckBox.Name = "showPasswordCheckBox";
			this.showPasswordCheckBox.Size = new System.Drawing.Size(102, 17);
			this.showPasswordCheckBox.TabIndex = 43;
			this.showPasswordCheckBox.Text = "Show Password";
			this.showPasswordCheckBox.UseVisualStyleBackColor = true;
			this.showPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
			// 
			// SignUpPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(700, 550);
			this.Controls.Add(this.showPasswordCheckBox);
			this.Controls.Add(this.backgroundLeftPanel);
			this.Controls.Add(this.passwordIcon);
			this.Controls.Add(this.profileIconPictureBox);
			this.Controls.Add(this.usernameIcon);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.alreadyHaveAnAccountButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.signUpMessageLabel);
			this.Controls.Add(this.passwordLabel);
			this.Controls.Add(this.passwordBottomLinePanel);
			this.Controls.Add(this.usernameLabel);
			this.Controls.Add(this.usernameBottomLinePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SignUpPage";
			this.Text = "SignUpPage";
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SignupPage_MouseDown);
			((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.profileIconPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).EndInit();
			this.backgroundLeftPanel.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox passwordIcon;
		private System.Windows.Forms.PictureBox profileIconPictureBox;
		private System.Windows.Forms.PictureBox usernameIcon;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Button alreadyHaveAnAccountButton;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label signUpMessageLabel;
		private System.Windows.Forms.Label passwordLabel;
		private System.Windows.Forms.Panel passwordBottomLinePanel;
		private System.Windows.Forms.Label usernameLabel;
		private System.Windows.Forms.Panel usernameBottomLinePanel;
		private System.Windows.Forms.Panel backgroundLeftPanel;
		private System.Windows.Forms.Label applicatonNameLabel;
		private System.Windows.Forms.CheckBox showPasswordCheckBox;
	}
}