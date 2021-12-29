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
                case "Laplacian 3x3":
                    return prOriginalBmp.Laplacian3x3Filter(false);

                case "Laplacian 3x3 Grayscale":
                    return prOriginalBmp.Laplacian3x3Filter(true);

                case "Laplacian 5x5": 
                    return prOriginalBmp.Laplacian5x5Filter(false);

                case "Laplacian 5x5 Grayscale": 
                    return prOriginalBmp.Laplacian5x5Filter(true);

                case "Laplacian of Gaussian": 
                    return prOriginalBmp.LaplacianOfGaussianFilter();

                case "Laplacian 3x3 of Gaussian 3x3": 
                    return prOriginalBmp.Laplacian3x3OfGaussian3x3Filter();

                case "Laplacian 3x3 of Gaussian 5x5 - 1": 
                    return prOriginalBmp.Laplacian3x3OfGaussian5x5Filter1();

                case "Laplacian 3x3 of Gaussian 5x5 - 2": 
                    return prOriginalBmp.Laplacian3x3OfGaussian5x5Filter2();

                case "Laplacian 5x5 of Gaussian 3x3": 
                    return prOriginalBmp.Laplacian5x5OfGaussian3x3Filter();

                case "Laplacian 5x5 of Gaussian 5x5 - 1": 
                    return prOriginalBmp.Laplacian5x5OfGaussian5x5Filter1();

                case "Laplacian 5x5 of Gaussian 5x5 - 2": 
                    return prOriginalBmp.Laplacian5x5OfGaussian5x5Filter2();

                case "Sobel 3x3": 
                    return prOriginalBmp.Sobel3x3Filter(false);

                case "Sobel 3x3 Grayscale": 
                    return prOriginalBmp.Sobel3x3Filter(true);

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
