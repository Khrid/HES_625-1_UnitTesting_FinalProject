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
        bool algoEdgeDetectionWholeImage = true;

        public ImageEdgeDetectionGui()
        {
            InitializeComponent();
            // lors du chargement, on va désactiver certains boutons car pas atteignables dès le début
            manageGuiElements(Step.NothingDone);
        }
         
        // METHODES PERSO UTILISEES DANS LES ELEMENTS DE LA GUI

        private void manageGuiElements(Step step)
        {
            Console.WriteLine("Updating GUI elements for step " + step);
            switch(step)
            {
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
                case Step.ImageLoaded:
                    btnOpenImage.Enabled = false;
                    btnResetSettings.Enabled = true;
                    groupBoxFiltersButtons.Enabled = true;
                    break;
                case Step.FilterApplied:
                    groupBoxEdgeDetectionSettings.Enabled = true;
                    break;
                case Step.EdgeDetectionApplied:
                    groupBoxFiltersButtons.Enabled = false;
                    btnSaveNewImage.Enabled = true;
                    break;
            }
        }
        private void ApplyFilter(string filter)
        {
            Console.WriteLine("Fake filter applied - " + filter);
            manageGuiElements(Step.FilterApplied);
        }

        // A PARTIR D'ICI 
        // METHODES DES ELEMENTS DE LA GUI 

        private void btnOpenOriginal_Click(object sender, EventArgs e)
        {
            try
            {
                // on appelle la BLL pour charger une image (elle même va appeler la DAL mais c'est son problème)
                Bitmap tmp = businessFileManager.LoadImage(@"C:\tmp\test.png");
                picPreview.Image = tmp;

                // on active les éléments du GOUI pour la suite
                manageGuiElements(Step.ImageLoaded);
            }
            catch(FileNotFoundException fnfe)
            {
                Console.WriteLine("oops!\n -> " + fnfe.Message);
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
                    Console.WriteLine("Fake edge detection applied - Whole image - " + cmbXAlgo.SelectedItem.ToString());
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
    }
}
