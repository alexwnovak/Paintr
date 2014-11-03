using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
      private Image _backgroundImage;

      public MainForm()
      {
         InitializeComponent();
         UpdateUI();
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

         _backgroundImage = Image.FromFile( _openFileDialog.FileName );
         _graphics = Graphics.FromImage( _backgroundImage );

         Invalidate();

         HasFileOpen = true;
      }

      private void _closeMenuItem_Click( object sender, System.EventArgs e )
      {
         if ( _backgroundImage != null )
         {
            _backgroundImage.Dispose();
            _backgroundImage = null;
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

         var rect = new Rectangle( _mouseAnchorPoint, new Size( 5, 5 ) );

         _graphics.DrawRectangle( Pens.Red, rect );
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
         _saveFileDialog.Filter = _openFileDialog.Filter;
         _saveFileDialog.ShowDialog();

         var filename = _saveFileDialog.FileName;

         _backgroundImage.Save(filename);
      }
   }
}
