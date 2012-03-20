using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotepadCS
{
	public partial class MainForm : Form
	{
		public TextView textView;

		public MainForm()
		{
			InitializeComponent();

			textView = new TextView();
			textView.Dock = DockStyle.Fill;
			panelBody.Controls.Add( textView );
		}

		private void openToolStripMenuItem_Click( object sender, EventArgs e )
		{
			var result = openFileDialog.ShowDialog();

			if( result != System.Windows.Forms.DialogResult.OK )
				return;

			ViewFile( openFileDialog.FileName );
		}

		public void ViewFile(string filepath)
		{
			var td = new TextData();
			td.LoadFrom( filepath, System.Text.Encoding.ASCII );

			textView.TextData = td;
			textView.Invalidate();
		}

		private void exitToolStripMenuItem_Click( object sender, EventArgs e )
		{
			Environment.Exit( 1337 );
		}
	}
}
