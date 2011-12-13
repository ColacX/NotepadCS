namespace NotepadCS
{
	partial class TextView
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.SuspendLayout();
			// 
			// TextView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Name = "TextView";
			this.Size = new System.Drawing.Size( 487, 313 );
			this.SizeChanged += new System.EventHandler( this.TextView_SizeChanged );
			this.KeyDown += new System.Windows.Forms.KeyEventHandler( this.TextView_KeyDown );
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler( this.TextView_KeyPress );
			this.KeyUp += new System.Windows.Forms.KeyEventHandler( this.TextView_KeyUp );
			this.MouseClick += new System.Windows.Forms.MouseEventHandler( this.TextView_MouseClick );
			this.ResumeLayout( false );

		}

		#endregion
	}
}
