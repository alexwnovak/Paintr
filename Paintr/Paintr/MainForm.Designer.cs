namespace Paintr
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
         if ( disposing && (components != null) )
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
         this._menuStrip = new System.Windows.Forms.MenuStrip();
         this._fileMenu = new System.Windows.Forms.ToolStripMenuItem();
         this._openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._closeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
         this._exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
         this._saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._saveFileDialog = new System.Windows.Forms.SaveFileDialog();
         this._toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
         this._penMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._openFileDialog = new System.Windows.Forms.OpenFileDialog();
         this._rectangleMenuItem = new System.Windows.Forms.ToolStripMenuItem();
         this._menuStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // _menuStrip
         // 
         this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileMenu,
            this._toolsMenu});
         this._menuStrip.Location = new System.Drawing.Point(0, 0);
         this._menuStrip.Name = "_menuStrip";
         this._menuStrip.Size = new System.Drawing.Size(707, 24);
         this._menuStrip.TabIndex = 0;
         this._menuStrip.Text = "menuStrip1";
         // 
         // _fileMenu
         // 
         this._fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._openMenuItem,
            this._closeMenuItem,
            this._saveMenuItem,
            this.toolStripSeparator1,
            this._exitMenuItem});
         this._fileMenu.Name = "_fileMenu";
         this._fileMenu.Size = new System.Drawing.Size(37, 20);
         this._fileMenu.Text = "&File";
         // 
         // _openMenuItem
         // 
         this._openMenuItem.Name = "_openMenuItem";
         this._openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
         this._openMenuItem.Size = new System.Drawing.Size(191, 22);
         this._openMenuItem.Text = "&Open Image...";
         this._openMenuItem.Click += new System.EventHandler(this._openMenuItem_Click);
         // 
         // _closeMenuItem
         // 
         this._closeMenuItem.Name = "_closeMenuItem";
         this._closeMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
         this._closeMenuItem.Size = new System.Drawing.Size(191, 22);
         this._closeMenuItem.Text = "&Close";
         this._closeMenuItem.Click += new System.EventHandler(this._closeMenuItem_Click);
         // 
         // toolStripSeparator1
         // 
         this.toolStripSeparator1.Name = "toolStripSeparator1";
         this.toolStripSeparator1.Size = new System.Drawing.Size(188, 6);
         // 
         // _exitMenuItem
         // 
         this._exitMenuItem.Name = "_exitMenuItem";
         this._exitMenuItem.Size = new System.Drawing.Size(191, 22);
         this._exitMenuItem.Text = "E&xit";
         this._exitMenuItem.Click += new System.EventHandler(this._exitMenuItem_Click);
         // 
         // _openFileDialog
         // 
         this._openFileDialog.Filter = "Image files|*.bmp;*.gif;*.jpg;*.jpeg;*.png";
         this._openFileDialog.Title = "Open Image";
         // 
         // _saveMenuItem
         // 
         this._saveMenuItem.Name = "_saveMenuItem";
         this._saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
         this._saveMenuItem.Size = new System.Drawing.Size(191, 22);
         this._saveMenuItem.Text = "&Save";
         this._saveMenuItem.Click += new System.EventHandler(this._saveMenuItem_Click);
         // 
         // _saveFileDialog
         // 
         this._saveFileDialog.Filter = "Image files|*.bmp;*.gif;*.jpg;*.jpeg;*.png";
         this._saveFileDialog.Title = "Save Image";
         // _toolsMenu
         // 
         this._toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._penMenuItem,
            this._rectangleMenuItem});
         this._toolsMenu.Name = "_toolsMenu";
         this._toolsMenu.Size = new System.Drawing.Size(48, 20);
         this._toolsMenu.Text = "&Tools";
         // 
         // _penMenuItem
         // 
         this._penMenuItem.Name = "_penMenuItem";
         this._penMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
         this._penMenuItem.Size = new System.Drawing.Size(166, 22);
         this._penMenuItem.Text = "&Pen";
         this._penMenuItem.Click += new System.EventHandler(this._penMenuItem_Click);
         // 
         // _openFileDialog
         // 
         this._openFileDialog.Filter = "Image files|*.bmp;*.gif;*.jpg;*.jpeg;*.png";
         this._openFileDialog.Title = "Open Image";
         // 
         // _rectangleMenuItem
         // 
         this._rectangleMenuItem.Name = "_rectangleMenuItem";
         this._rectangleMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
         this._rectangleMenuItem.Size = new System.Drawing.Size(166, 22);
         this._rectangleMenuItem.Text = "&Rectangle";
         this._rectangleMenuItem.Click += new System.EventHandler(this._rectangleMenuItem_Click);
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.AppWorkspace;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
         this.ClientSize = new System.Drawing.Size(707, 459);
         this.Controls.Add(this._menuStrip);
         this.DoubleBuffered = true;
         this.MainMenuStrip = this._menuStrip;
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Paintr";
         this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
         this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
         this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
         this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
         this._menuStrip.ResumeLayout(false);
         this._menuStrip.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip _menuStrip;
      private System.Windows.Forms.ToolStripMenuItem _fileMenu;
      private System.Windows.Forms.ToolStripMenuItem _exitMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _openMenuItem;
      private System.Windows.Forms.OpenFileDialog _openFileDialog;
      private System.Windows.Forms.ToolStripMenuItem _closeMenuItem;
      private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
      private System.Windows.Forms.ToolStripMenuItem _saveMenuItem;
      private System.Windows.Forms.SaveFileDialog _saveFileDialog;
      private System.Windows.Forms.ToolStripMenuItem _toolsMenu;
      private System.Windows.Forms.ToolStripMenuItem _penMenuItem;
      private System.Windows.Forms.ToolStripMenuItem _rectangleMenuItem;
   }
}

