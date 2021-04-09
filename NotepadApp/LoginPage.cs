using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace NotepadApp
{
	public partial class LoginPage : Form
	{
		private string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\user_information.txt";

		public LoginPage()
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
			//SetUsernameTextBox(Properties.Resources.user, Color.White);
			//SetPasswordTextBox(Properties.Resources.padlock_blue, Color.FromArgb(28, 170, 252));
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

		private void DontHaveAnAccount_Click(object sender, EventArgs e)
		{
			SignUpPage signUpPage = new SignUpPage();
			signUpPage.Show();
			Hide();
		}

		private void LoginButton_Click(object sender, EventArgs e)
		{
			string enteredUsername = usernameTextBox.Text;
			string enteredPassword = passwordTextBox.Text;

			User user = new User(enteredUsername, enteredPassword);

			TryLogin(user);
		}

		private void TryLogin(User user)
		{
			string[] userInfoArray = File.ReadAllLines(path);

			foreach (string userInfo in userInfoArray)
			{
				string[] splittedInfo = userInfo.Split(' ');

				string username = splittedInfo[0];
				string password = splittedInfo[1];

				if (username == user.Username && password == user.Password)
				{
					LoginUser();
					return;
				}
			}

			MessageBox.Show("This account doesn't exist, please create new account");
		}

		private void LoginUser()
		{
			MessageBox.Show("You Logged In");
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
