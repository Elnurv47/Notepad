using System;
using System.Drawing;
using System.Windows.Forms;

namespace NotepadApp
{
	public partial class NoteUI : Control
	{
		private Label noteNameLabel;
		public Label NoteNameLabel => noteNameLabel;

		private Note note;
		public NoteUI()
		{
			InitializeComponent();

			Size = new Size(200, 200);
			BackColor = Color.FromArgb(28, 170, 252);
			Click += NoteUI_Click;

			CreateNoteNameLabel();
		}

		private void CreateNoteNameLabel()
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
			NoteDetail noteDetail = new NoteDetail();
			noteDetail.NoteNameLabel.Text = note.Name;
			noteDetail.NoteMessageTextBox.Text = note.Message;
			noteDetail.Show();
		}
	}
}
