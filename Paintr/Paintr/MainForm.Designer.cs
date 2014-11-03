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
         this._menuStrip.SuspendLayout();
         this.SuspendLayout();
         // 
         // _menuStrip
         // 
         this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._fileMenu});
         this._menuStrip.Location = new System.Drawing.Point(0, 0);
         this._menuStrip.Name = "_menuStrip";
         this._menuStrip.Size = new System.Drawing.Size(707, 24);
         this._menuStrip.TabIndex = 0;
         this._menuStrip.Text = "menuStrip1";
         // 
         // _fileMenu
         // 
         this._fileMenu.Name = "_fileMenu";
         this._fileMenu.Size = new System.Drawing.Size(37, 20);
         this._fileMenu.Text = "&File";
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(707, 459);
         this.Controls.Add(this._menuStrip);
         this.MainMenuStrip = this._menuStrip;
         this.MaximizeBox = false;
         this.MinimizeBox = false;
         this.Name = "MainForm";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Paintr";
         this._menuStrip.ResumeLayout(false);
         this._menuStrip.PerformLayout();
         this.ResumeLayout(false);
         this.PerformLayout();

      }

      #endregion

      private System.Windows.Forms.MenuStrip _menuStrip;
      private System.Windows.Forms.ToolStripMenuItem _fileMenu;
   }
}

