using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NotepadApp
{
	public partial class NoteDetail : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		public Label NoteNameLabel => noteNameLabel;
		public TextBox NoteMessageTextBox => noteMessageTextBox;
		public NoteDetail()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, System.EventArgs e)
		{
			Notepad.OneNoteIsAlreadyOpen = false;
			Close();
		}

        private void NoteDetail_MouseDown(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Left && e.Clicks == 1)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

        private void NoteNameLabel_MouseDown(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Left && e.Clicks == 1)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
    }
}
