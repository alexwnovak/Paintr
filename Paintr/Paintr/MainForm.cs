using System.Drawing;
﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Paintr
{
   public partial class MainForm : Form
   {
      private bool _leftMouseDown;
      private Point _mouseAnchorPoint;

      private bool _hasFileOpen;
      private bool HasFileOpen
      {
         get
         {
            return _hasFileOpen;
         }
         set
         {
            _hasFileOpen = value;
            UpdateUI();
         }
      }

      private Graphics _graphics;
      private Pen _linePen;
      private Image _backgroundImage;

      public MainForm()
      {
         InitializeComponent();
         UpdateUI();

         _linePen = new Pen( Brushes.Red, 10.0f );
      }

      private void UpdateUI()
      {
         _closeMenuItem.Enabled = HasFileOpen;
      }

      private void _exitMenuItem_Click( object sender, System.EventArgs e )
      {
         Application.Exit();
      }

      private void _openMenuItem_Click( object sender, System.EventArgs e )
      {
         var dialogResult = _openFileDialog.ShowDialog();

         if ( dialogResult == DialogResult.Cancel )
         {
            return;
         }
         
         Text = _openFileDialog.FileName + " - Paintr";

         OpenFile( _openFileDialog.FileName);
      }

      private void OpenFile( String path )
      {
         using ( var fileStream = File.OpenRead( path ) )
         {
            _backgroundImage = Image.FromStream(fileStream);
            _graphics = Graphics.FromImage(_backgroundImage);

            Invalidate();

            HasFileOpen = true;
         }
      }

      private void _closeMenuItem_Click( object sender, System.EventArgs e )
      {
         if ( _backgroundImage != null )
         {
            _backgroundImage.Dispose();
            _backgroundImage = null;
            Invalidate();

            Text = "Paintr";
         }

         HasFileOpen = false;
      }

      private void MainForm_MouseDown( object sender, MouseEventArgs e )
      {
         if ( e.Button == MouseButtons.Left )
         {
            _leftMouseDown = true;
            _mouseAnchorPoint = e.Location;
         }
      }

      private void MainForm_MouseUp( object sender, MouseEventArgs e )
      {
         if ( e.Button == MouseButtons.Left )
         {
            _leftMouseDown = false;
         }
      }

      private void MainForm_MouseMove( object sender, MouseEventArgs e )
      {
         if ( !_leftMouseDown || !HasFileOpen )
         {
            return;
         }

         _graphics.DrawLine( _linePen, _mouseAnchorPoint, e.Location );
         Invalidate();

         _mouseAnchorPoint = e.Location;
      }

      private void MainForm_Paint( object sender, PaintEventArgs e )
      {
         if ( _backgroundImage == null )
         {
            return;
         }

         e.Graphics.DrawImage( _backgroundImage, Point.Empty );
      }

      private void saveToolStripMenuItem_Click(object sender, System.EventArgs e)
      {
         saveAnnotations();
      }

      private void saveAnnotations()
      {
         _saveFileDialog.ShowDialog();

         var filename = _saveFileDialog.FileName;

         if ( !string.IsNullOrWhiteSpace(filename) )
         {
            _backgroundImage.Save(filename);
         }
      }
   }
}
