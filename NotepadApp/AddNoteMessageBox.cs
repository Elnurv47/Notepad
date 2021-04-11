using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace NotepadApp
{
	public partial class AddNoteMessageBox : Form
	{
		private Notepad notepad;

		public AddNoteMessageBox(Notepad notepad)
		{
			InitializeComponent();
			this.notepad = notepad;
		}

		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void CloseButton_Click(object sender, EventArgs e) => Close();

		private void SaveNoteButton_Click(object sender, EventArgs e)
		{
			string noteName = noteNameTextBox.Text;
			string noteText = noteMessageTextBox.Text;

			NoteUI noteUI = new NoteUI();
			notepad.AddNoteToLayout(noteUI);

			Note note = new Note(noteName, noteText, Notepad.CurrentNoteIndex, noteUI);
			Notepad.CurrentNoteIndex++;

			noteUI.SetNote(note);
			
			note.Create();
			note.Save();

			Close();
		}

        private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
        {
			if (e.Button == MouseButtons.Left && e.Clicks == 1)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}
    }
}
