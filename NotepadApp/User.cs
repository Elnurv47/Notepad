namespace NotepadApp
{
	public class User
	{
		private string username;
		private string password;

		public string Username => username;
		public string Password => password;

		public User(string username, string password)
		{
			this.username = username;
			this.password = password;
		}
	}
}
