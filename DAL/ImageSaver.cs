using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ImageSaver : IFileSaver
    {
        public void SaveFile(Bitmap image, string path)
        {
            ImageFormat imgFormat;
            switch (Path.GetExtension(path).ToLower())
            {
                default:
                case "png":
                    imgFormat = ImageFormat.Png;
                    break;
                case "bmp":
                    imgFormat = ImageFormat.Bmp;
                    break;
                case "jpg":
                    imgFormat = ImageFormat.Jpeg;
                    break;
            }

            StreamWriter streamWriter = new StreamWriter(path, false);
            image.Save(streamWriter.BaseStream, imgFormat);
            streamWriter.Flush();
            streamWriter.Close();
        }
    }
}
