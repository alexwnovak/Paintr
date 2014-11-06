using System.Drawing;

namespace Paintr
{
   public static class ImageExtensions
   {
      public static void AddLine( this Image image, Point startingPoint, Point endPoint, Pen pen )
      {
         using ( Graphics g = Graphics.FromImage( image ) )
         {
            g.DrawLine( pen, startingPoint, endPoint );
         }
      }
   }
}
