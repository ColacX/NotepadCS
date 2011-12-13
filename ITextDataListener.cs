using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NotepadCS
{
	public interface ITextDataListener
	{
		void TextDataInsert( int rowNumber, IEnumerable<string> rows );
		void TextDataRemove( int rowNumber, int rowCount );
	}
}