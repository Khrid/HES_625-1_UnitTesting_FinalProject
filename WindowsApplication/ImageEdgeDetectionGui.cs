using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication
{
    public partial class ImageEdgeDetectionGui : Form
 {
        // interface de lien présentation <-> BLL
        IBusinessFileManager businessFileManager = new ImageManager();

        public ImageEdgeDetectionGui()
        {
            InitializeComponent();
        }

        private void btnOpenOriginal_Click(object sender, EventArgs e)
        {
            try
            {
                // on appelle la BLL pour charger une image (elle même va appeler la DAL mais c'est son problème)
                Bitmap tmp = businessFileManager.LoadImage(@"C:\tmp\test2.png");
                Console.WriteLine(tmp.Width);
                picPreview.Image = tmp;
            }
            catch(FileNotFoundException fnfe)
            {
                Console.WriteLine("oops!\n -> " + fnfe.Message);
            }
        }
    }
}
