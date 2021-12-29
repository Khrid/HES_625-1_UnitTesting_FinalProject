using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IFileSaver
    {
        void SaveFile(Bitmap image, string path);
    }
}
