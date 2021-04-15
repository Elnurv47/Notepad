using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NotepadApp
{
	public partial class LoginPage : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void LoginPage_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks == 1)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks == 1)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\user_information.txt";

		public LoginPage()
		{
			InitializeComponent();
		}

		private void UsernameTextBox_Click(object sender, EventArgs e)
		{
			SetUsernameTextBox(Properties.Resources.user_blue, Color.FromArgb(28, 170, 252));
			SetPasswordTextBox(Properties.Resources.padlock, Color.White);
		}

		private void PasswordTextBox_Click(object sender, EventArgs e)
		{
			SetUsernameTextBox(Properties.Resources.user, Color.White);
			SetPasswordTextBox(Properties.Resources.padlock_blue, Color.FromArgb(28, 170, 252));
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
			ResetWarningLabels();

			if (user.Username == string.Empty)
			{
				usernameWarningLabel.Text = "Please, enter your username";
				return;
			}
			else if (user.Password == string.Empty)
			{
				passwordWarningLabel.Text = "Please, enter your password";
				return;
			}

			User userAccountInDatabase = SearchDatabaseForUsername(user);

			GiveFeedbackAboutInputs(user, userAccountInDatabase);
		}

		private void ResetWarningLabels()
		{
			usernameWarningLabel.Text = string.Empty;
			passwordWarningLabel.Text = string.Empty;
		}

		private User SearchDatabaseForUsername(User user)
		{
			string[] userInfoArray = File.ReadAllLines(path);

			User userAccountInDatabase = new User("", "");

			foreach (string userInfo in userInfoArray)
			{
				string[] splittedInfo = userInfo.Split(' ');

				string username = splittedInfo[0];
				string password = splittedInfo[1];

				if (username == user.Username)
				{
					userAccountInDatabase = new User(username, password);
				}
			}

			return userAccountInDatabase;
		}

		private void GiveFeedbackAboutInputs(User user, User userAccountInDatabase)
		{
			if (userAccountInDatabase == null)
			{
				usernameWarningLabel.Text = "Your username is invalid";
			}
			else
			{
				if (user.Password == userAccountInDatabase.Password)
				{
					LoginUser(user);
					ResetWarningLabels();
				}
				else
				{
					passwordWarningLabel.Text = "Your password is invalid";
				}
			}
		}

		private void LoginUser(User user)
		{
			AccountManager.CurrentUser = user;
			Notepad notepad = new Notepad();
			notepad.Show();
			Hide();
		}

		private void UsernameTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyData == Keys.Tab)
			{
				SetUsernameTextBox(Properties.Resources.user, Color.White);
				SetPasswordTextBox(Properties.Resources.padlock_blue, Color.FromArgb(28, 170, 252));
			}
		}

		private void PasswordTextBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			if (e.KeyData == Keys.Tab)
			{
				SetUsernameTextBox(Properties.Resources.user_blue, Color.FromArgb(28, 170, 252));
				SetPasswordTextBox(Properties.Resources.padlock, Color.White);
			}
		}

		private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (passwordTextBox.PasswordChar == '\0')
			{
				passwordTextBox.PasswordChar = '*';
			}
			else
			{
				passwordTextBox.PasswordChar = '\0';
			}
		}
	}
}
