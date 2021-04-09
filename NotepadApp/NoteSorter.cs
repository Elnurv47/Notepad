using System.Collections.Generic;

namespace NotepadApp
{
	public class NoteSorter : IComparer<Note>
	{
		public int Compare(Note first, Note second)
		{
			if (first.Index > second.Index)
			{
				return 1;
			}
			else if (first.Index < second.Index)
			{
				return -1;
			}
			else
			{
				return 0;
			}
		}
	}
}
