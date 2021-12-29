using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsApplication
{
    /// <summary>
    /// Représente l'étape actuelle de l'application. Etapes possible : <br/>
    /// <list type="bullet">
    /// <item>
    /// <description>NothingDone (rien n'a été fait)</description>
    /// </item>
    /// <item>
    /// <description>ImageLoaded (image chargée)</description>
    /// </item>
    /// <item>
    /// <description>FilterApplied (au moins un filtre appliqué ou no filter)</description>
    /// </item>
    /// <item>
    /// <description>EdgeDetectionApplied (edge detection appliquée)</description>
    /// </item>
    /// </list>
    /// </summary>
    enum Step
    {
        NothingDone,    
        ImageLoaded,
        FilterApplied,
        EdgeDetectionApplied
    }

    public partial class ImageEdgeDetectionGui : Form
 {
        // interface de lien présentation <-> BLL
        IBusinessFileManager businessFileManager = new ImageManager();
        IBusinessImageFilter businessImageFilter = new ImageFilter();
        IBusinessImageEdgeDetection businessImageEdgeDetection = new ImageEdgeDetection();
        bool algoEdgeDetectionWholeImage = true;

        public ImageEdgeDetectionGui()
        {
            InitializeComponent();
            // lors du chargement, on va désactiver certains boutons car pas atteignables dès le début
            manageGuiElements(Step.NothingDone);
        }
         
        // METHODES PERSO UTILISEES DANS LES ELEMENTS DE LA GUI

        /// <summary>
        /// Permet d'activer ou désactiver certains éléments de l'interface en fonction de l'étape transmise en paramètre
        /// </summary>
        /// <param name="step">l'étape actuelle de l'application</param>
        private void manageGuiElements(Step step)
        {
            Console.WriteLine("Updating GUI elements for step " + step);
            switch(step)
            {
                // par défaut + step "on a rien fait encore"
                default:
                case Step.NothingDone:
                    btnOpenImage.Enabled = true;
                    btnSaveNewImage.Enabled = false;
                    btnResetSettings.Enabled = false;
                    groupBoxFiltersButtons.Enabled = false;
                    groupBoxEdgeDetectionSettings.Enabled = false;
                    picPreview.Image = null;
                    radioButtonWholeImage.Checked = true;
                    labelAlgoYAxis.Visible = false;
                    cmbXAlgo.SelectedIndex = 0;
                    cmbYAlgo.SelectedIndex = 0;
                    break;
                // si on a chargé l'image
                case Step.ImageLoaded:
                    btnOpenImage.Enabled = false;
                    btnResetSettings.Enabled = true;
                    groupBoxFiltersButtons.Enabled = true;
                    break;
                // si on a appliqué un filtre au moins (ou clic pas de filtre)
                case Step.FilterApplied:
                    groupBoxEdgeDetectionSettings.Enabled = true;
                    break;
                // si on a appliqué l'edge detection
                case Step.EdgeDetectionApplied:
                    groupBoxFiltersButtons.Enabled = false;
                    btnSaveNewImage.Enabled = true;
                    break;
            }
        }

        /// <summary>
        /// Applique un filtre sur l'image en cours
        /// </summary>
        /// <param name="filter">le filtre à appliquer</param>
        private void ApplyFilter(string filter)
        {
            Bitmap tmp;
            switch (filter)
            {
                case "night":
                    tmp = businessImageFilter.NightFilter();
                    break;

                case "miami":
                    tmp = businessImageFilter.MiamiFilter();
                    break;

                case "hell":
                    tmp = businessImageFilter.HellFilter();
                    break;

                default:
                    tmp = businessImageFilter.NoFilter();
                    break;

            }
            
            picPreview.Image = tmp;
            businessImageEdgeDetection.originalBmp = tmp;

            Console.WriteLine("Filter applied - " + filter);
            manageGuiElements(Step.FilterApplied);
        }

        // A PARTIR D'ICI 
        // METHODES DES ELEMENTS DE LA GUI 

        private void btnOpenOriginal_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select an image file.";
            ofd.Filter = "PNG Images (*.png)|*.png";
            ofd.Filter += "|JPEG Images (*.jpg)|*.jpg";
            ofd.Filter += "|Bitmap Images (*.bmp)|*.bmp";


            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Console.WriteLine("Selected file : " + ofd.FileName);
                try
                {
                    // on appelle la BLL pour charger l'image (elle même va appeler la DAL mais c'est son problème)
                    Bitmap tmp = businessFileManager.LoadImage(ofd.FileName);
                    businessImageFilter.originalBmp = tmp;
                    picPreview.Image = tmp;

                    // on active les éléments du GOUI pour la suite
                    manageGuiElements(Step.ImageLoaded);
                }
                catch (FileNotFoundException fnfe)
                {
                    Console.WriteLine("oops!\n -> " + fnfe.Message);
                }
            } else
            {
                Console.WriteLine("File acquisition was canceled.");
            }
        }

        private void radioButtonWholeImage_CheckedChanged(object sender, EventArgs e)
        {
            // gestion dynamique des listes déroulantes & label qui vont avec

            // si le radio button "Whole image" est checké => on affiche qu'une seule liste déroulante
            if(radioButtonWholeImage.Checked)
            {
                labelAlgoWholeOrX.Text = "Algorithm for the whole image";
                labelAlgoYAxis.Visible = false;
                cmbYAlgo.Visible = false;
                algoEdgeDetectionWholeImage = true;
            }
            // sinon on affiche les deux listes déroulantes, pour l'axe X et Y
            else if(radioButtonXYAxis.Checked)
            {
                labelAlgoWholeOrX.Text = "Algorithm X axis";
                labelAlgoYAxis.Visible = true;
                cmbYAlgo.Visible = true;
                algoEdgeDetectionWholeImage = false;
            }
        }


        private void btnResetSettings_Click(object sender, EventArgs e)
        {
            // reset des différents paramètres, comme si on revenait au chargement de l'app
            manageGuiElements(Step.NothingDone);
        }

        private void btnFilterNight_Click(object sender, EventArgs e)
        {
            ApplyFilter("night");
        }

        private void btnFilterMiami_Click(object sender, EventArgs e)
        {
            ApplyFilter("miami");
        }

        private void btnFilterHell_Click(object sender, EventArgs e)
        {
            ApplyFilter("hell");
        }

        private void btnFilterNone_Click(object sender, EventArgs e)
        {
            ApplyFilter("none");
        }


        private void btnApplyEdgeDetection_Click(object sender, EventArgs e)
        {
            // Check sur le type d'EdgeDetection que l'on va appliquer (whole image ou X Y axis)
            if(algoEdgeDetectionWholeImage)
            {
                if(cmbXAlgo.SelectedIndex > 0)
                {
                    picPreview.Image = businessImageEdgeDetection.EdgeDetection(cmbXAlgo.SelectedItem.ToString());
                    Console.WriteLine("Edge detection applied - Whole image - " + cmbXAlgo.SelectedItem.ToString());
                    manageGuiElements(Step.EdgeDetectionApplied);
                } else
                {
                    MessageBox.Show("Please select an algorithm", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else
            {
                if (cmbXAlgo.SelectedIndex > 0 && cmbYAlgo.SelectedIndex > 0)
                {
                    Console.WriteLine("Fake edge detection applied - X Y axis - " + cmbXAlgo.SelectedItem.ToString() + " / " + cmbYAlgo.SelectedItem.ToString());
                    manageGuiElements(Step.EdgeDetectionApplied);
                } else
                {
                    MessageBox.Show("Please select an algorithm for X and Y axis", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveNewImage_Click(object sender, EventArgs e)
        {
            if(picPreview.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Specify a file name and file path";
                sfd.Filter = "PNG Images (*.png)|*.png";
                sfd.Filter += "|JPEG Images (*.jpg)|*.jpg";
                sfd.Filter += "|Bitmap Images (*.bmp)|*.bmp";
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    businessFileManager.SaveImage(new Bitmap(picPreview.Image), sfd.FileName);
                }
            }
        }
    }
}
