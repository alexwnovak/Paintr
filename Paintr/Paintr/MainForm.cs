using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Paintr
{
   public partial class MainForm : Form
   {
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

         BackgroundImage = Image.FromFile( _openFileDialog.FileName );
         HasFileOpen = true;
      }

      private void _closeMenuItem_Click( object sender, System.EventArgs e )
      {

      }
   }
}
