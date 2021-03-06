﻿using System.Drawing;
using System.Windows.Forms;

namespace Paintr
{
   public partial class MainForm : Form
   {
      private bool _leftMouseDown;
      private Point _mouseAnchorPoint;

      private ToolType _toolType = ToolType.Pen;
      private ToolType ToolType
      {
         get
         {
            return _toolType;
         }
         set
         {
            _toolType = value;
            UpdateUI();
         }
      }

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

      private Pen _linePen;
      private Rectangle _dragRect;
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
         _saveMenuItem.Enabled = HasFileOpen;

         _penMenuItem.Checked = _toolType == ToolType.Pen;
         _rectangleMenuItem.Checked = _toolType == ToolType.Rectangle;
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

         _backgroundImage = Image.FromFile( _openFileDialog.FileName );

         Invalidate();

         Text = _openFileDialog.FileName + " - Paintr";

         HasFileOpen = true;
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

            if ( ToolType == ToolType.Rectangle )
            {
               _backgroundImage.AddRectangle( _dragRect, _linePen );
               Invalidate();
            }
         }
      }

      private void MainForm_MouseMove( object sender, MouseEventArgs e )
      {
         if ( !_leftMouseDown || !HasFileOpen )
         {
            return;
         }

         if ( ToolType == ToolType.Pen )
         {
            _backgroundImage.AddLine( _mouseAnchorPoint, e.Location, _linePen );
            Invalidate();

            _mouseAnchorPoint = e.Location;
         }
         else if ( ToolType == ToolType.Rectangle )
         {
            int x = _mouseAnchorPoint.X;
            int y = _mouseAnchorPoint.Y;
            int w = e.Location.X - x;
            int h = e.Location.Y - y;
            _dragRect = new Rectangle( x, y, w, h );
         }
      }

      private void MainForm_Paint( object sender, PaintEventArgs e )
      {
         if ( _backgroundImage == null )
         {
            return;
         }

         e.Graphics.DrawImage( _backgroundImage, Point.Empty );
      }

      private void _saveMenuItem_Click( object sender, System.EventArgs e )
      {
         var dialogResult = _saveFileDialog.ShowDialog();

         if ( dialogResult == DialogResult.Cancel )
         {
            return;
         }

         _backgroundImage.Save( _saveFileDialog.FileName );
      }

      private void _penMenuItem_Click( object sender, System.EventArgs e )
      {
         ToolType = ToolType.Pen;
      }

      private void _rectangleMenuItem_Click( object sender, System.EventArgs e )
      {
         ToolType = ToolType.Rectangle;
      }
   }
}
