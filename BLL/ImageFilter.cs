using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImageFilter : IBusinessImageFilter
    {
        private Bitmap prOriginalBmp;

        public Bitmap originalBmp { get { return prOriginalBmp; } set { prOriginalBmp = value; } }

        public Bitmap HellFilter()
        {
            return ApplyFilter(prOriginalBmp, 1, 1, 10, 15);
        }

        public Bitmap MiamiFilter()
        {
            return ApplyFilter(prOriginalBmp, 1, 1, 10, 1);
        }

        public Bitmap NightFilter()
        {
            return ApplyFilter(prOriginalBmp, 1, 1, 1, 25);
        }

        public Bitmap NoFilter()
        {
            return prOriginalBmp;
        }


        //apply color filter at your own taste
        private Bitmap ApplyFilter(Bitmap bmp, int alpha, int red, int blue, int green)
        {

            Bitmap temp = new Bitmap(bmp.Width, bmp.Height);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int x = 0; x < bmp.Height; x++)
                {
                    Color c = bmp.GetPixel(i, x);
                    Color cLayer = Color.FromArgb(c.A / alpha, c.R / red, c.G / green, c.B / blue);
                    temp.SetPixel(i, x, cLayer);
                }

            }
            return temp;
        }
    }
}
