using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;

namespace NotepadApp
{
	public partial class Notepad : Form
	{
		private List<Note> notes;
		
		private static int currentNoteIndex = 0;
		public static int CurrentNoteIndex { get => currentNoteIndex; set => currentNoteIndex = value; }

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
			string[] files = CreateNotesFolderIfNotExists();

			foreach (string file in files)
			{
				FileStream fileStream = new FileStream(file, FileMode.Open);
				BinaryFormatter formatter = new BinaryFormatter();
				Note note = (Note)formatter.Deserialize(fileStream);
				notes.Add(note);
			}
		}

		private string[] CreateNotesFolderIfNotExists()
		{
			string[] files = new string[0];

			if (Directory.Exists(@"Notes\"))
			{
				files = Directory.GetFiles(@"Notes\");
			}
			else
			{
				Directory.CreateDirectory(@"Notes\");
			}
			return files;
		}

		private void SortNotes() => notes.Sort(new NoteSorter());

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

		private void AddNoteButton_Click(object sender, EventArgs e)
		{
			AddNoteMessageBox addNoteMessageBox = new AddNoteMessageBox(this);
			addNoteMessageBox.Show();
		}

		private void CloseButton_Click(object sender, EventArgs e)
		{
			SaveCurrentNoteIndex();
			
			Close();
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
