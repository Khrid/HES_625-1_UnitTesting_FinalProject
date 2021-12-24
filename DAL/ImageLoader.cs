using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ImageLoader : IFileLoader
    {
        /// <summary>
        /// Permet de charger une image à partir d'un chemin donné
        /// </summary>
        /// <param name="path">Le chemin de l'image à charger</param>
        /// <returns></returns>
        public Bitmap LoadImage(string path)
        {
            // test si le fichier existe
            Console.WriteLine("Testing file path.");
            if (File.Exists(path))
            {
                // s'il existe, on renvoie un nouveau objet "Bitmap" contenant l'image choisie
                Console.WriteLine("Path exists, loading image.");
                return new Bitmap(path, true);
            } else
            {
                // sinon on renvoie une exception "FileNotFoundException"
                Console.WriteLine("Path does not exists, exiting!.");
                throw new FileNotFoundException("File does not exists.");
            }
        }
    }
}
