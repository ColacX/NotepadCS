using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace NotepadCS
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main( string[] args )
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );

			//check if program is already active
			//use args as filepaths

			var mf = new MainForm();

			var td = new TextData();
			td.LoadFrom( "../../Program.cs", System.Text.Encoding.ASCII );

			var tv0 = new TextView();
			tv0.TextData = td;
			tv0.Dock = DockStyle.Fill;
			mf.Controls.Add( tv0 );
			
			Application.Run( mf );
		}
	}
}
