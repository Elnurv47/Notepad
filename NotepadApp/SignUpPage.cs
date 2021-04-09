using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace NotepadApp
{
	public partial class SignUpPage : Form
	{
		private string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\user_information.txt";

		public SignUpPage()
		{
			InitializeComponent();
		}

		private void UsernameTextBox_Click(object sender, EventArgs e)
		{
			//SetUsernameTextBox(Properties.Resources.user_blue, Color.FromArgb(28, 170, 252));
			//SetPasswordTextBox(Properties.Resources.padlock, Color.White);
		}

		private void PasswordTextBox_Click(object sender, EventArgs e)
		{
			//SetPasswordTextBox(Properties.Resources.padlock_blue, Color.FromArgb(28, 170, 252));
			//SetUsernameTextBox(Properties.Resources.user, Color.White);
		}

		private void SetUsernameTextBox(Image image, Color color)
		{
			usernameIcon.Image = image;
			usernameBottomLinePanel.BackColor = color;
		}

		private void SetPasswordTextBox(Image image, Color color)
		{
			passwordIcon.Image = image;
			passwordBottomLinePanel.BackColor = color;
		}

		private void CloseButton_Click(object sender, EventArgs e) => Close();

		private void CloseButton_MouseEnter(object sender, EventArgs e)
		{
			closeButton.BackColor = Color.FromArgb(28, 170, 252);
		}

		private void CloseButton_MouseLeave(object sender, EventArgs e)
		{
			closeButton.BackColor = Color.White;
		}

		private void AlreadyHaveAnAccountButton_Click(object sender, EventArgs e)
		{
			LoginPage loginPage = new LoginPage();
			loginPage.Show();
			Hide();
		}

		private void SignUpButton_Click(object sender, EventArgs e)
		{
			string enteredUsername = usernameTextBox.Text;
			string enteredPassword = passwordTextBox.Text;

			using (StreamWriter streamWriter = new StreamWriter(path))
			{
				streamWriter.WriteLine($"{enteredUsername} {enteredPassword}");
			}

			MessageBox.Show("Your account is created, redirecting..");
		}

		private void UsernameTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyData == Keys.Tab)
			{
				//SetUsernameTextBox(Properties.Resources.user, Color.White);
				//SetPasswordTextBox(Properties.Resources.padlock_blue, Color.FromArgb(28, 170, 252));
			}
		}
	}
}
