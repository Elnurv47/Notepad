using System.Windows.Forms;

namespace NotepadApp
{
	public partial class NoteDetail : Form
	{
		public Label NoteNameLabel => noteNameLabel;
		public TextBox NoteMessageTextBox => noteMessageTextBox;
		public NoteDetail()
		{
			InitializeComponent();
		}

		private void CloseButton_Click(object sender, System.EventArgs e) => Close();
	}
}
