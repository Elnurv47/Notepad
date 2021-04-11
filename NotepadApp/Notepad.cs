using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;

namespace NotepadApp
{
	public partial class Notepad : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void HeaderPanel_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left && e.Clicks == 1)
			{
				ReleaseCapture();
				SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
			}
		}

		private List<Note> notes;
		
		private static int currentNoteIndex = 0;
		public static int CurrentNoteIndex { get => currentNoteIndex; set => currentNoteIndex = value; }

		private static bool oneNoteIsAlreadyOpen = false;
		public static bool OneNoteIsAlreadyOpen { get => oneNoteIsAlreadyOpen; set => oneNoteIsAlreadyOpen = value; }

		private const string CURRENT_NOTE_INDEX_FILE_PATH = "currentNoteIndex.txt";

		public Notepad()
		{
			InitializeComponent();
			notes = new List<Note>();
		}
		private void Notepad_Load(object sender, EventArgs e)
		{
			SetLastNoteIndex();

			DeserializeAllNotes();

			SortNotes();

			DisplayNotes();
		}

		private void SetLastNoteIndex()
		{
			currentNoteIndex = int.Parse(File.ReadAllText(CURRENT_NOTE_INDEX_FILE_PATH));
		}

		private void DeserializeAllNotes()
		{
			CreateNotesFolderIfNotExists();
			string[] files = Directory.GetFiles($@"Notes\{AccountManager.CurrentUser.Username}");

			foreach (string file in files)
			{
				FileStream fileStream = new FileStream(file, FileMode.Open);
				BinaryFormatter formatter = new BinaryFormatter();
				Note note = (Note)formatter.Deserialize(fileStream);
				fileStream.Close();
				notes.Add(note);
			}
		}
		private void CreateNotesFolderIfNotExists()
		{
			if (!Directory.Exists($@"Notes\{AccountManager.CurrentUser.Username}"))
			{
				Directory.CreateDirectory($@"Notes\{AccountManager.CurrentUser.Username}");
			}
		}

		private void DisplayNotes()
		{
			foreach (Note note in notes)
			{
				NoteUI noteUI = new NoteUI();
				noteUI.SetNote(note);
				noteLayoutPanel.Controls.Add(noteUI);
				noteUI.NoteNameLabel.Text = note.Name;
				noteUI.Show();
			}
		}

		private void SortNotes() => notes.Sort(new NoteSorter());


		private void AddNoteButton_Click(object sender, EventArgs e)
		{
			AddNoteMessageBox addNoteMessageBox = new AddNoteMessageBox(this);
			addNoteMessageBox.Show();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			SaveCurrentNoteIndex();

			Application.Exit();
		}

		private void SaveCurrentNoteIndex()
		{
			using (StreamWriter streamWriter = new StreamWriter(CURRENT_NOTE_INDEX_FILE_PATH))
			{
				streamWriter.WriteLine(currentNoteIndex);
			}
		}

		public void AddNoteToLayout(NoteUI noteUI) => noteLayoutPanel.Controls.Add(noteUI);
    }
}
