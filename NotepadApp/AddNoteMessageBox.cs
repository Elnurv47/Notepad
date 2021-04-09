using System;
using System.Windows.Forms;

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
	}
}
