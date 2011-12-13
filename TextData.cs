using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NotepadCS
{
	public class TextData
	{
		private List<string> listText = new List<string>();
		private List<ITextDataListener> listListener = new List<ITextDataListener>();

		private bool modified = false;
		public bool Modified { get { return modified; } }

		public int Rows { get { return listText.Count; } }
		
		public int columns = 0;
		public int Columns { get { return columns; } }

		private string title = "Default";
		public string Title
		{
			get { return title; }
			set
			{
				if( title != value )
				{
					title = value;
					//update all listeners thread this?
				}
			}
		}

		public void LoadFrom( string filepath, Encoding encoding )
		{
			//todo thread this operation may take a lot of time and make it look cool when it loads
			listText.Clear();
			InsertRange( 0, File.ReadLines( filepath, encoding ) );
			modified = false;
		}

		public void SaveTo( string filepath, Encoding encoding )
		{
			//save only modified lines?
			File.WriteAllLines( filepath, listText, encoding );
			modified = false;
		}

		public void InsertRange( int rowNumber, IEnumerable<string> rows )
		{
			listText.InsertRange( rowNumber, rows );
			modified = true;

			foreach( var listener in listListener )
			{
				listener.TextDataInsert( rowNumber, rows );
			}
		}

		public void RemoveRange( int rowNumber, int rowCount )
		{
			listText.RemoveRange( rowNumber, rowCount );
			modified = true;

			foreach( var listener in listListener )
			{
				listener.TextDataRemove( rowNumber, rowCount );
			}
		}

		public List<string> ReadRange( int rowNumber, int rowCount )
		{
			return listText.GetRange( rowNumber, rowCount );
		}

		public void AppendListener( ITextDataListener listener )
		{
			listListener.Add( listener );
		}

		public void RemoveListener( ITextDataListener listener )
		{
			listListener.Remove( listener );
		}

		//stream so regex can use it?

		//check if outside program modified the file?
	}
}
