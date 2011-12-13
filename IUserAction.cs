using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotepadCS
{
	interface IUserAction
	{
		void Redo();
		void Undo();
	}
}
