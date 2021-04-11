using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotepadApp
{
	public partial class NoteUI : Control
	{
		private Label noteNameLabel;
		private Button deleteNoteButton;
		public Label NoteNameLabel => noteNameLabel;

		private Note note;
		public NoteUI()
		{
			InitializeComponent();

			Size = new Size(200, 200);
			BackColor = Color.FromArgb(28, 170, 252);
			Click += NoteUI_Click;

			InitializeDeleteNoteButton();

			InitializeNoteNameLabel();
		}

		private void InitializeDeleteNoteButton()
		{
			deleteNoteButton = new Button();

			deleteNoteButton.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			deleteNoteButton.ForeColor = Color.White;
			deleteNoteButton.Location = new Point(160, 0);
			deleteNoteButton.FlatStyle = FlatStyle.Flat;
			deleteNoteButton.FlatAppearance.BorderColor = Color.White;
			deleteNoteButton.Size = new Size(40, 40);
			deleteNoteButton.Text = "X";
			deleteNoteButton.Click += DeleteNoteButton_Click;

			Controls.Add(deleteNoteButton);
		}

		private void DeleteNoteButton_Click(object sender, EventArgs e)
		{
			Dispose();
			File.Delete($@"Notes\{note.Name}");
		}

		private void InitializeNoteNameLabel()
		{
			noteNameLabel = new Label();

			noteNameLabel.ForeColor = Color.White;
			noteNameLabel.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			noteNameLabel.Location = new Point(0, 0);
			noteNameLabel.Name = "noteNameLabel";
			noteNameLabel.Size = new Size(200, 45);
			noteNameLabel.TabIndex = 2;
			noteNameLabel.Text = "My Note";
			noteNameLabel.TextAlign = ContentAlignment.MiddleCenter;

			Controls.Add(noteNameLabel);
		}

		public void SetNote(Note note) => this.note = note;

		private void NoteUI_Click(object sender, EventArgs e)
		{
			if (!Notepad.OneNoteIsAlreadyOpen)
			{
				NoteDetail noteDetail = new NoteDetail();
				noteDetail.NoteNameLabel.Text = note.Name;
				noteDetail.NoteMessageTextBox.Text = note.Message;
				noteDetail.Show();
				Notepad.OneNoteIsAlreadyOpen = true;
			}
		}
	}
}
