using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace NotepadCS
{
	class TextData
	{
		public bool Modified = false;
		List<string> listData = new List<string>();

		public void LoadFrom( string filepath )
		{
			//todo thread this operation may take a lot of time and it looks cool when it loads
			foreach( var line in File.ReadLines( filepath, Encoding.ASCII ) )
			{
				listData.Add( line );
			}
		}

		public void SaveAs( string filepath )
		{
		}

		//update all listeners

		//row and column wise data manipulation
	}
}
