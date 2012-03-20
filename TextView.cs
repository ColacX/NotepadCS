using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NotepadCS
{
	public partial class TextView : UserControl, ITextDataListener
	{
		private TextCaret Caret = new TextCaret();
		private List<string> viewedRows = null;
		private int row;
		private int column;
		private Font font = new Font( FontFamily.GenericSansSerif, 8.0f );
		private Brush brush = Brushes.Black;
		private Pen pen = Pens.Black;
		private StringFormat stringFormat = new StringFormat()
		{
			Alignment = StringAlignment.Center,
			LineAlignment = StringAlignment.Center
		};
		private Brush selectedBrush = new SolidBrush( Color.FromArgb( 128, 0, 0, 255 ) );
		
		private TextData textData = null;
		public TextData TextData
		{
			get { return textData; }
			set
			{
				if( textData != value )
				{
					if( textData != null)
						textData.RemoveListener(this);

					textData = value;
					textData.AppendListener(this);
					//redraw view from textData
				}
			}
		}

		public float CellWidth = 10;
		public float CellHeight = 12;

		public TextView()
		{
			InitializeComponent();
			this.SetStyle( ControlStyles.OptimizedDoubleBuffer, true );
		}

		protected override void OnPaint( PaintEventArgs e )
		{
			if( textData == null )
				return;

			e.Graphics.Clear( Color.White );
			var listText = textData.ReadRange( 0, textData.Rows );

			var oxs = 5.0f;
			var oys = 5.0f;

			var ox = oxs;
			var oy = oys;

			foreach( var rowText in listText )
			{
				foreach( var character in rowText )
				{
					//e.Graphics.DrawRectangle( pen, ox, oy, CellWidth, CellHeight );
					e.Graphics.DrawString( character.ToString(), font, brush, ox + CellWidth/2 , oy + CellHeight/2, stringFormat );
					//e.Graphics.FillRectangle( selectedBrush, ox, oy, CellWidth, CellHeight );
					ox += CellWidth;
				}

				ox = oxs;
				oy += CellHeight;
			}

			Caret.Draw(e.Graphics);

			e.Graphics.DrawRectangle( Pens.Black, 0, 0, this.Width-1, this.Height-1 );
		}

		protected override void OnPaintBackground( PaintEventArgs e )
		{
			//not needed if on paint fills entire background
			//if only a small region is invalidated this will paint its background?
		}

		public void TextDataInsert( int rowNumber, IEnumerable<string> rows )
		{
			this.Invalidate();
		}

		public void TextDataRemove( int rowNumber, int rowCount )
		{
			//redraw only the updated rows from textdata and only if they are currently being looked at
			//? or lets keep it simple for now and just fetch and draw all viewed rows
			this.Invalidate();
		}

		private void TextView_MouseClick( object sender, MouseEventArgs e )
		{
			
		}

		private void TextView_KeyPress( object sender, KeyPressEventArgs e )
		{
			//get selected rowText
			//modify selected rowText
			textData.InsertRange( 0, new string[]{e.KeyChar + ""} );

			e.Handled = true;
			//todo invalidate only a small region
			this.Invalidate();
		}

		private void TextView_KeyDown( object sender, KeyEventArgs e )
		{
		}

		private void TextView_KeyUp( object sender, KeyEventArgs e )
		{
		}

		private void TextView_SizeChanged( object sender, EventArgs e )
		{
			this.Invalidate();
		}
	}

	class TextCaret
	{
		public int x, y, w = 1, h = 10;
		private Pen pen = Pens.Black;

		//draw caret
		public void Draw(Graphics g)
		{
			g.DrawRectangle( pen, x, y, x + w, y + h );
		}
	}
}
