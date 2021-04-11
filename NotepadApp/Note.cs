using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace NotepadApp
{
	[Serializable]
	public class Note
	{
		private string name;
		public string Name => name;

		private string message;
		public string Message => message;

		private int index;
		public int Index => index;

		[NonSerialized] private NoteUI noteUI;

		public Note(string name, string message, int index, NoteUI noteUI)
		{
			this.name = name;
			this.message = message;
			this.index = index;
			this.noteUI = noteUI;
		}

		public void Create()
		{
			noteUI.NoteNameLabel.Text = name;
			noteUI.Show();
		}

		public void Save()
		{
			using (FileStream fileStream = new FileStream($@"Notes\{AccountManager.CurrentUser.Username}\{name}.dat", FileMode.Create))
			{
				BinaryFormatter formatter = new BinaryFormatter();
				formatter.Serialize(fileStream, this);
			}
		}
	}
}
