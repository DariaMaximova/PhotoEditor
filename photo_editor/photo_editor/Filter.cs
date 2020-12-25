using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace photo_editor
{
    class Filter
    {
        public Bitmap Apply(ColorMatrix color, Image img)
        {
            Bitmap bmpinverted = new Bitmap(img.Width, img.Height);
            ImageAttributes ia = new ImageAttributes();

            ia.SetColorMatrix(color); // записываем значения фильтра
            Graphics grps = Graphics.FromImage(bmpinverted);
            grps.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia); // перерисовываем картинку
            grps.Dispose();

            return bmpinverted;
        }


        public static ColorMatrix grayColor = new ColorMatrix(new float[][] {
              new float[]{.3f, .3f, .3f, 0, 0},
              new float[]{.59f, .59f, .59f, 0, 0},
              new float[]{.11f, .11f, .11f, 0, 0},
              new float[]{0, 0, 0, 1, 0},
              new float[]{0, 0, 0, 0, 1} });


        public static ColorMatrix sepiaColor = new ColorMatrix(new float[][] {
              new float[]{.393f, .349f, .272f, 0, 0},
              new float[]{.769f, .686f, .534f, 0, 0},
              new float[]{.189f, .168f, .131f, 0, 0},
              new float[]{0, 0, 0, 1, 0},
              new float[]{0, 0, 0, 0, 1} });


        public static ColorMatrix blueColor = new ColorMatrix(new float[][] {
                new float[] {0,0,1,0,0},
             new float[] {0,1,0,0,0},
             new float[] {0,0,0,0,0},
             new float[] {0,0,0,1,0},
             new float[]{0,0,0,0,1} });


        public static ColorMatrix yellowBlueColor = new ColorMatrix(new float[][] {
                new float[] {1,1,0,0,0,0},
             new float[] {0,0,1,0,0},
             new float[] {0,0,0,0,0},
             new float[] {0,0,0,1,0},
             new float[]{0,0,0,0,1} });

    }
}
