using System;
using System.Drawing;

namespace DAL
{
    public interface IFileLoader
    {
        Bitmap LoadImage(String path);
    }
}
