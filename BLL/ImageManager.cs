using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ImageManager : IBusinessFileManager
    {
        public IFileLoader imageLoader { get; set; }
        public IFileSaver imageSaver { get; set; }

        public ImageManager()
        {
            imageLoader = new ImageLoader();
            imageSaver = new ImageSaver();
        }

        public Bitmap LoadImage(string path)
        {
            return imageLoader.LoadImage(path);
        }

        public void SaveImage(Bitmap image, string path)
        {
            imageSaver.SaveFile(image, path);
        }
    }
}
