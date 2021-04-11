using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NotepadApp
{
	public partial class SignUpPage : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\user_information.txt";

		public SignUpPage()
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
			SetPasswordTextBox(Properties.Resources.padlock_blue, Color.FromArgb(28, 170, 252));
			SetUsernameTextBox(Properties.Resources.user, Color.White);
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

		private void CloseButton_Click(object sender, EventArgs e) => Application.Exit();

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
			Close();
		}

		private void SignUpButton_Click(object sender, EventArgs e)
		{
			string enteredUsername = usernameTextBox.Text;
			string enteredPassword = passwordTextBox.Text;

			using (StreamWriter streamWriter = new StreamWriter(path))
			{
				streamWriter.WriteLine($"{enteredUsername} {enteredPassword}");
			}

			Notepad notepad = new Notepad();
			notepad.Show();
			Close();
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
	}
}
