using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImageEdgeDetection : IBusinessImageEdgeDetection
    {
        private Bitmap prOriginalBmp;

        public Bitmap originalBmp { get { return prOriginalBmp; } set { prOriginalBmp = value; } }

        public Bitmap EdgeDetection(string algo)
        {
            switch (algo)
            {
                case "Prewitt": 
                    return prOriginalBmp.PrewittFilter(false);

                case "Prewitt Grayscale": 
                    return prOriginalBmp.PrewittFilter(true);

                case "Kirsch": 
                    return prOriginalBmp.KirschFilter(false);

                case "Kirsch Grayscale": 
                    return prOriginalBmp.KirschFilter(true);

                default: 
                    return prOriginalBmp;
            }

           
        }
    }
}
