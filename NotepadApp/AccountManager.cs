using System;

namespace NotepadApp
{
	public static class AccountManager
	{
		private static User currentUser;
		public static User CurrentUser { get => currentUser; set => currentUser = value; }
	}
}
