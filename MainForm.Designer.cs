namespace NotepadCS
{
	partial class MainForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveCopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.columnModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.anotherWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.highligthingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.cToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
			this.javaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.panelBody = new System.Windows.Forms.Panel();
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.helpToolStripMenuItem} );
			this.menuStrip.Location = new System.Drawing.Point( 0, 0 );
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size( 1387, 24 );
			this.menuStrip.TabIndex = 0;
			this.menuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.saveCopyToolStripMenuItem,
            this.reloadToolStripMenuItem,
            this.exitToolStripMenuItem} );
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size( 37, 20 );
			this.fileToolStripMenuItem.Text = "File";
			// 
			// openToolStripMenuItem
			// 
			this.openToolStripMenuItem.Name = "openToolStripMenuItem";
			this.openToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.openToolStripMenuItem.Text = "Open";
			this.openToolStripMenuItem.Click += new System.EventHandler( this.openToolStripMenuItem_Click );
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.saveToolStripMenuItem.Text = "Save";
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.saveAsToolStripMenuItem.Text = "Save As";
			// 
			// saveCopyToolStripMenuItem
			// 
			this.saveCopyToolStripMenuItem.Name = "saveCopyToolStripMenuItem";
			this.saveCopyToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.saveCopyToolStripMenuItem.Text = "Save Copy";
			// 
			// reloadToolStripMenuItem
			// 
			this.reloadToolStripMenuItem.Name = "reloadToolStripMenuItem";
			this.reloadToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.reloadToolStripMenuItem.Text = "Reload";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler( this.exitToolStripMenuItem_Click );
			// 
			// editToolStripMenuItem
			// 
			this.editToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.replaceToolStripMenuItem,
            this.findToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.cutToolStripMenuItem,
            this.pasteToolStripMenuItem} );
			this.editToolStripMenuItem.Name = "editToolStripMenuItem";
			this.editToolStripMenuItem.Size = new System.Drawing.Size( 39, 20 );
			this.editToolStripMenuItem.Text = "Edit";
			// 
			// replaceToolStripMenuItem
			// 
			this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
			this.replaceToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.replaceToolStripMenuItem.Text = "Replace";
			// 
			// findToolStripMenuItem
			// 
			this.findToolStripMenuItem.Name = "findToolStripMenuItem";
			this.findToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.findToolStripMenuItem.Text = "Find";
			// 
			// copyToolStripMenuItem
			// 
			this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
			this.copyToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.copyToolStripMenuItem.Text = "Copy";
			// 
			// cutToolStripMenuItem
			// 
			this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
			this.cutToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.cutToolStripMenuItem.Text = "Cut";
			// 
			// pasteToolStripMenuItem
			// 
			this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
			this.pasteToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.pasteToolStripMenuItem.Text = "Paste";
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.columnModeToolStripMenuItem,
            this.anotherWindowToolStripMenuItem,
            this.highligthingToolStripMenuItem} );
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
			this.viewToolStripMenuItem.Text = "View";
			// 
			// columnModeToolStripMenuItem
			// 
			this.columnModeToolStripMenuItem.Name = "columnModeToolStripMenuItem";
			this.columnModeToolStripMenuItem.Size = new System.Drawing.Size( 178, 22 );
			this.columnModeToolStripMenuItem.Text = "Column Mode";
			// 
			// anotherWindowToolStripMenuItem
			// 
			this.anotherWindowToolStripMenuItem.Name = "anotherWindowToolStripMenuItem";
			this.anotherWindowToolStripMenuItem.Size = new System.Drawing.Size( 178, 22 );
			this.anotherWindowToolStripMenuItem.Text = "Another Form";
			// 
			// highligthingToolStripMenuItem
			// 
			this.highligthingToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.xmlToolStripMenuItem,
            this.cToolStripMenuItem,
            this.cToolStripMenuItem1,
            this.cToolStripMenuItem2,
            this.javaToolStripMenuItem} );
			this.highligthingToolStripMenuItem.Name = "highligthingToolStripMenuItem";
			this.highligthingToolStripMenuItem.Size = new System.Drawing.Size( 178, 22 );
			this.highligthingToolStripMenuItem.Text = "Syntax Highlighting";
			// 
			// xmlToolStripMenuItem
			// 
			this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
			this.xmlToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.xmlToolStripMenuItem.Text = "XML";
			// 
			// cToolStripMenuItem
			// 
			this.cToolStripMenuItem.Name = "cToolStripMenuItem";
			this.cToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.cToolStripMenuItem.Text = "C";
			// 
			// cToolStripMenuItem1
			// 
			this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
			this.cToolStripMenuItem1.Size = new System.Drawing.Size( 152, 22 );
			this.cToolStripMenuItem1.Text = "C++";
			// 
			// cToolStripMenuItem2
			// 
			this.cToolStripMenuItem2.Name = "cToolStripMenuItem2";
			this.cToolStripMenuItem2.Size = new System.Drawing.Size( 152, 22 );
			this.cToolStripMenuItem2.Text = "C#";
			// 
			// javaToolStripMenuItem
			// 
			this.javaToolStripMenuItem.Name = "javaToolStripMenuItem";
			this.javaToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.javaToolStripMenuItem.Text = "Java";
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem} );
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size( 44, 20 );
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size( 152, 22 );
			this.aboutToolStripMenuItem.Text = "About";
			// 
			// openFileDialog
			// 
			this.openFileDialog.DefaultExt = "txt";
			this.openFileDialog.FileName = "default.txt";
			this.openFileDialog.Filter = "All|*.*|Text|*.txt";
			this.openFileDialog.InitialDirectory = ".";
			this.openFileDialog.Multiselect = true;
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange( new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1} );
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size( 48, 20 );
			this.settingsToolStripMenuItem.Text = "Tools";
			// 
			// settingsToolStripMenuItem1
			// 
			this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
			this.settingsToolStripMenuItem1.Size = new System.Drawing.Size( 152, 22 );
			this.settingsToolStripMenuItem1.Text = "Settings";
			// 
			// panelBody
			// 
			this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelBody.Location = new System.Drawing.Point( 0, 24 );
			this.panelBody.Name = "panelBody";
			this.panelBody.Size = new System.Drawing.Size( 1387, 391 );
			this.panelBody.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size( 1387, 415 );
			this.Controls.Add( this.panelBody );
			this.Controls.Add( this.menuStrip );
			this.MainMenuStrip = this.menuStrip;
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.menuStrip.ResumeLayout( false );
			this.menuStrip.PerformLayout();
			this.ResumeLayout( false );
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveCopyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem columnModeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem anotherWindowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reloadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem highligthingToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem xmlToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem javaToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
		private System.Windows.Forms.Panel panelBody;
	}
}