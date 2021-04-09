
namespace NotepadApp
{
	partial class LoginPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
			this.closeButton = new System.Windows.Forms.Button();
			this.passwordIcon = new System.Windows.Forms.PictureBox();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.dontHaveAnAccountButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.loginMessageLabel = new System.Windows.Forms.Label();
			this.profileIconPictureBox = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.passwordBottomLinePanel = new System.Windows.Forms.Panel();
			this.usernameIcon = new System.Windows.Forms.PictureBox();
			this.label2 = new System.Windows.Forms.Label();
			this.usernameBottomLinePanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.applicationNameLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.profileIconPictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// closeButton
			// 
			this.closeButton.BackColor = System.Drawing.Color.White;
			this.closeButton.FlatAppearance.BorderSize = 0;
			this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.closeButton.Location = new System.Drawing.Point(657, -2);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(46, 46);
			this.closeButton.TabIndex = 27;
			this.closeButton.Text = "X";
			this.closeButton.UseVisualStyleBackColor = false;
			this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// passwordIcon
			// 
			this.passwordIcon.Location = new System.Drawing.Point(376, 301);
			this.passwordIcon.Name = "passwordIcon";
			this.passwordIcon.Size = new System.Drawing.Size(32, 32);
			this.passwordIcon.TabIndex = 26;
			this.passwordIcon.TabStop = false;
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.BackColor = System.Drawing.Color.White;
			this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.passwordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.passwordTextBox.Location = new System.Drawing.Point(414, 301);
			this.passwordTextBox.Multiline = true;
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(246, 32);
			this.passwordTextBox.TabIndex = 25;
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.usernameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.usernameTextBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.usernameTextBox.Location = new System.Drawing.Point(416, 204);
			this.usernameTextBox.Multiline = true;
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(244, 32);
			this.usernameTextBox.TabIndex = 24;
			this.usernameTextBox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.UsernameTextBox_PreviewKeyDown);
			// 
			// dontHaveAnAccountButton
			// 
			this.dontHaveAnAccountButton.BackColor = System.Drawing.Color.White;
			this.dontHaveAnAccountButton.FlatAppearance.BorderSize = 0;
			this.dontHaveAnAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.dontHaveAnAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dontHaveAnAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.dontHaveAnAccountButton.Location = new System.Drawing.Point(377, 444);
			this.dontHaveAnAccountButton.Name = "dontHaveAnAccountButton";
			this.dontHaveAnAccountButton.Size = new System.Drawing.Size(285, 38);
			this.dontHaveAnAccountButton.TabIndex = 23;
			this.dontHaveAnAccountButton.Text = "Don\'t Have an Account ?";
			this.dontHaveAnAccountButton.UseVisualStyleBackColor = false;
			this.dontHaveAnAccountButton.Click += new System.EventHandler(this.DontHaveAnAccount_Click);
			// 
			// loginButton
			// 
			this.loginButton.BackColor = System.Drawing.Color.White;
			this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.loginButton.Location = new System.Drawing.Point(473, 374);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(104, 38);
			this.loginButton.TabIndex = 22;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = false;
			this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
			// 
			// loginMessageLabel
			// 
			this.loginMessageLabel.BackColor = System.Drawing.Color.White;
			this.loginMessageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.loginMessageLabel.ForeColor = System.Drawing.Color.Gray;
			this.loginMessageLabel.Location = new System.Drawing.Point(410, 136);
			this.loginMessageLabel.Name = "loginMessageLabel";
			this.loginMessageLabel.Size = new System.Drawing.Size(228, 23);
			this.loginMessageLabel.TabIndex = 21;
			this.loginMessageLabel.Text = "Login below to get started";
			this.loginMessageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// profileIconPictureBox
			// 
			this.profileIconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("profileIconPictureBox.Image")));
			this.profileIconPictureBox.Location = new System.Drawing.Point(498, 57);
			this.profileIconPictureBox.Name = "profileIconPictureBox";
			this.profileIconPictureBox.Size = new System.Drawing.Size(64, 64);
			this.profileIconPictureBox.TabIndex = 20;
			this.profileIconPictureBox.TabStop = false;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.label1.Location = new System.Drawing.Point(373, 269);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 29);
			this.label1.TabIndex = 19;
			this.label1.Text = "Password";
			// 
			// passwordBottomLinePanel
			// 
			this.passwordBottomLinePanel.Location = new System.Drawing.Point(376, 339);
			this.passwordBottomLinePanel.Name = "passwordBottomLinePanel";
			this.passwordBottomLinePanel.Size = new System.Drawing.Size(286, 2);
			this.passwordBottomLinePanel.TabIndex = 17;
			// 
			// usernameIcon
			// 
			this.usernameIcon.Location = new System.Drawing.Point(376, 204);
			this.usernameIcon.Name = "usernameIcon";
			this.usernameIcon.Size = new System.Drawing.Size(32, 32);
			this.usernameIcon.TabIndex = 18;
			this.usernameIcon.TabStop = false;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.label2.Location = new System.Drawing.Point(372, 170);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(106, 29);
			this.label2.TabIndex = 15;
			this.label2.Text = "Username";
			// 
			// usernameBottomLinePanel
			// 
			this.usernameBottomLinePanel.Location = new System.Drawing.Point(376, 242);
			this.usernameBottomLinePanel.Name = "usernameBottomLinePanel";
			this.usernameBottomLinePanel.Size = new System.Drawing.Size(284, 2);
			this.usernameBottomLinePanel.TabIndex = 16;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(170)))), ((int)(((byte)(252)))));
			this.panel1.Controls.Add(this.applicationNameLabel);
			this.panel1.Location = new System.Drawing.Point(1, -2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(330, 551);
			this.panel1.TabIndex = 28;
			// 
			// applicationNameLabel
			// 
			this.applicationNameLabel.Font = new System.Drawing.Font("Viner Hand ITC", 38.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.applicationNameLabel.ForeColor = System.Drawing.SystemColors.Control;
			this.applicationNameLabel.Location = new System.Drawing.Point(0, 206);
			this.applicationNameLabel.Name = "applicationNameLabel";
			this.applicationNameLabel.Size = new System.Drawing.Size(327, 100);
			this.applicationNameLabel.TabIndex = 1;
			this.applicationNameLabel.Text = "NOTEPAD";
			this.applicationNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// LoginPage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(700, 550);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.closeButton);
			this.Controls.Add(this.passwordIcon);
			this.Controls.Add(this.passwordTextBox);
			this.Controls.Add(this.usernameTextBox);
			this.Controls.Add(this.dontHaveAnAccountButton);
			this.Controls.Add(this.loginButton);
			this.Controls.Add(this.loginMessageLabel);
			this.Controls.Add(this.profileIconPictureBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.passwordBottomLinePanel);
			this.Controls.Add(this.usernameIcon);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.usernameBottomLinePanel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LoginPage";
			this.Text = "LoginPage";
			((System.ComponentModel.ISupportInitialize)(this.passwordIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.profileIconPictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.usernameIcon)).EndInit();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.PictureBox passwordIcon;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.Button dontHaveAnAccountButton;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label loginMessageLabel;
		private System.Windows.Forms.PictureBox profileIconPictureBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel passwordBottomLinePanel;
		private System.Windows.Forms.PictureBox usernameIcon;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel usernameBottomLinePanel;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label applicationNameLabel;
	}
}