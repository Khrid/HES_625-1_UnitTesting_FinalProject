﻿using DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IBusinessFileManager
    {
        IFileLoader imageLoader { get; set; }
        IFileSaver imageSaver { get; set; }

        Bitmap LoadImage(string path);

        void SaveImage(Bitmap image, string path);
    }
}
