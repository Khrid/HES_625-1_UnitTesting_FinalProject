using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IBusinessImageFilter
    {
        Bitmap originalBmp { get; set; }

        Bitmap NightFilter();
        Bitmap MiamiFilter();
        Bitmap HellFilter();
        Bitmap NoFilter();

    }
}
