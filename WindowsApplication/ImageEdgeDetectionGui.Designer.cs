
namespace WindowsApplication
{
    partial class ImageEdgeDetectionGui
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnResetSettings = new System.Windows.Forms.Button();
            this.btnSaveNewImage = new System.Windows.Forms.Button();
            this.btnOpenImage = new System.Windows.Forms.Button();
            this.groupBoxFiltersButtons = new System.Windows.Forms.GroupBox();
            this.btnFilterNone = new System.Windows.Forms.Button();
            this.btnFilterHell = new System.Windows.Forms.Button();
            this.btnFilterMiami = new System.Windows.Forms.Button();
            this.btnFilterNight = new System.Windows.Forms.Button();
            this.groupBoxEdgeDetectionSettings = new System.Windows.Forms.GroupBox();
            this.btnApplyEdgeDetection = new System.Windows.Forms.Button();
            this.cmbYAlgo = new System.Windows.Forms.ComboBox();
            this.cmbXAlgo = new System.Windows.Forms.ComboBox();
            this.labelAlgoYAxis = new System.Windows.Forms.Label();
            this.labelAlgoWholeOrX = new System.Windows.Forms.Label();
            this.groupBoxEdgeDetectionAlgorithm = new System.Windows.Forms.GroupBox();
            this.radioButtonXYAxis = new System.Windows.Forms.RadioButton();
            this.radioButtonWholeImage = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).BeginInit();
            this.groupBoxFiltersButtons.SuspendLayout();
            this.groupBoxEdgeDetectionSettings.SuspendLayout();
            this.groupBoxEdgeDetectionAlgorithm.SuspendLayout();
            this.SuspendLayout();
            // 
            // picPreview
            // 
            this.picPreview.BackColor = System.Drawing.Color.Silver;
            this.picPreview.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picPreview.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picPreview.Location = new System.Drawing.Point(6, 6);
            this.picPreview.Margin = new System.Windows.Forms.Padding(2);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(743, 537);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.TabIndex = 14;
            this.picPreview.TabStop = false;
            // 
            // btnResetSettings
            // 
            this.btnResetSettings.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetSettings.Location = new System.Drawing.Point(938, 6);
            this.btnResetSettings.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetSettings.Name = "btnResetSettings";
            this.btnResetSettings.Size = new System.Drawing.Size(54, 24);
            this.btnResetSettings.TabIndex = 32;
            this.btnResetSettings.Text = "Reset settings";
            this.btnResetSettings.UseVisualStyleBackColor = true;
            this.btnResetSettings.Click += new System.EventHandler(this.btnResetSettings_Click);
            // 
            // btnSaveNewImage
            // 
            this.btnSaveNewImage.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNewImage.Location = new System.Drawing.Point(880, 6);
            this.btnSaveNewImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveNewImage.Name = "btnSaveNewImage";
            this.btnSaveNewImage.Size = new System.Drawing.Size(54, 24);
            this.btnSaveNewImage.TabIndex = 31;
            this.btnSaveNewImage.Text = "Save Image";
            this.btnSaveNewImage.UseVisualStyleBackColor = true;
            // 
            // btnOpenImage
            // 
            this.btnOpenImage.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenImage.Location = new System.Drawing.Point(822, 6);
            this.btnOpenImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenImage.Name = "btnOpenImage";
            this.btnOpenImage.Size = new System.Drawing.Size(54, 24);
            this.btnOpenImage.TabIndex = 30;
            this.btnOpenImage.Text = "Load Image";
            this.btnOpenImage.UseVisualStyleBackColor = true;
            this.btnOpenImage.Click += new System.EventHandler(this.btnOpenOriginal_Click);
            // 
            // groupBoxFiltersButtons
            // 
            this.groupBoxFiltersButtons.Controls.Add(this.btnFilterNone);
            this.groupBoxFiltersButtons.Controls.Add(this.btnFilterHell);
            this.groupBoxFiltersButtons.Controls.Add(this.btnFilterMiami);
            this.groupBoxFiltersButtons.Controls.Add(this.btnFilterNight);
            this.groupBoxFiltersButtons.Location = new System.Drawing.Point(754, 34);
            this.groupBoxFiltersButtons.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxFiltersButtons.Name = "groupBoxFiltersButtons";
            this.groupBoxFiltersButtons.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxFiltersButtons.Size = new System.Drawing.Size(238, 81);
            this.groupBoxFiltersButtons.TabIndex = 33;
            this.groupBoxFiltersButtons.TabStop = false;
            this.groupBoxFiltersButtons.Text = "1. Filter";
            // 
            // btnFilterNone
            // 
            this.btnFilterNone.Location = new System.Drawing.Point(161, 47);
            this.btnFilterNone.Name = "btnFilterNone";
            this.btnFilterNone.Size = new System.Drawing.Size(75, 23);
            this.btnFilterNone.TabIndex = 3;
            this.btnFilterNone.Text = "No filter";
            this.btnFilterNone.UseVisualStyleBackColor = true;
            this.btnFilterNone.Click += new System.EventHandler(this.btnFilterNone_Click);
            // 
            // btnFilterHell
            // 
            this.btnFilterHell.Location = new System.Drawing.Point(161, 18);
            this.btnFilterHell.Name = "btnFilterHell";
            this.btnFilterHell.Size = new System.Drawing.Size(75, 23);
            this.btnFilterHell.TabIndex = 2;
            this.btnFilterHell.Text = "Hell";
            this.btnFilterHell.UseVisualStyleBackColor = true;
            this.btnFilterHell.Click += new System.EventHandler(this.btnFilterHell_Click);
            // 
            // btnFilterMiami
            // 
            this.btnFilterMiami.Location = new System.Drawing.Point(83, 18);
            this.btnFilterMiami.Name = "btnFilterMiami";
            this.btnFilterMiami.Size = new System.Drawing.Size(75, 23);
            this.btnFilterMiami.TabIndex = 1;
            this.btnFilterMiami.Text = "Miami";
            this.btnFilterMiami.UseVisualStyleBackColor = true;
            this.btnFilterMiami.Click += new System.EventHandler(this.btnFilterMiami_Click);
            // 
            // btnFilterNight
            // 
            this.btnFilterNight.Location = new System.Drawing.Point(5, 18);
            this.btnFilterNight.Name = "btnFilterNight";
            this.btnFilterNight.Size = new System.Drawing.Size(75, 23);
            this.btnFilterNight.TabIndex = 0;
            this.btnFilterNight.Text = "Night";
            this.btnFilterNight.UseVisualStyleBackColor = true;
            this.btnFilterNight.Click += new System.EventHandler(this.btnFilterNight_Click);
            // 
            // groupBoxEdgeDetectionSettings
            // 
            this.groupBoxEdgeDetectionSettings.Controls.Add(this.btnApplyEdgeDetection);
            this.groupBoxEdgeDetectionSettings.Controls.Add(this.cmbYAlgo);
            this.groupBoxEdgeDetectionSettings.Controls.Add(this.cmbXAlgo);
            this.groupBoxEdgeDetectionSettings.Controls.Add(this.labelAlgoYAxis);
            this.groupBoxEdgeDetectionSettings.Controls.Add(this.labelAlgoWholeOrX);
            this.groupBoxEdgeDetectionSettings.Controls.Add(this.groupBoxEdgeDetectionAlgorithm);
            this.groupBoxEdgeDetectionSettings.Location = new System.Drawing.Point(754, 120);
            this.groupBoxEdgeDetectionSettings.Name = "groupBoxEdgeDetectionSettings";
            this.groupBoxEdgeDetectionSettings.Size = new System.Drawing.Size(238, 197);
            this.groupBoxEdgeDetectionSettings.TabIndex = 34;
            this.groupBoxEdgeDetectionSettings.TabStop = false;
            this.groupBoxEdgeDetectionSettings.Text = "2. Edge detection";
            // 
            // btnApplyEdgeDetection
            // 
            this.btnApplyEdgeDetection.Location = new System.Drawing.Point(12, 166);
            this.btnApplyEdgeDetection.Name = "btnApplyEdgeDetection";
            this.btnApplyEdgeDetection.Size = new System.Drawing.Size(115, 23);
            this.btnApplyEdgeDetection.TabIndex = 36;
            this.btnApplyEdgeDetection.Text = "Apply edge detection";
            this.btnApplyEdgeDetection.UseVisualStyleBackColor = true;
            this.btnApplyEdgeDetection.Click += new System.EventHandler(this.btnApplyEdgeDetection_Click);
            // 
            // cmbYAlgo
            // 
            this.cmbYAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYAlgo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbYAlgo.FormattingEnabled = true;
            this.cmbYAlgo.Items.AddRange(new object[] {
            "",
            "Laplacian 3x3",
            "Laplacian 3x3 Grayscale",
            "Laplacian 5x5",
            "Laplacian 5x5 Grayscale",
            "Laplacian of Gaussian",
            "Laplacian 3x3 of Gaussian 3x3",
            "Laplacian 3x3 of Gaussian 5x5 - 1",
            "Laplacian 3x3 of Gaussian 5x5 - 2",
            "Laplacian 5x5 of Gaussian 3x3",
            "Laplacian 5x5 of Gaussian 5x5 - 1",
            "Laplacian 5x5 of Gaussian 5x5 - 2",
            "Sobel 3x3",
            "Sobel 3x3 Grayscale",
            "Prewitt",
            "Prewitt Grayscale",
            "Kirsch",
            "Kirsch Grayscale"});
            this.cmbYAlgo.Location = new System.Drawing.Point(12, 137);
            this.cmbYAlgo.Name = "cmbYAlgo";
            this.cmbYAlgo.Size = new System.Drawing.Size(186, 23);
            this.cmbYAlgo.TabIndex = 35;
            this.cmbYAlgo.Visible = false;
            // 
            // cmbXAlgo
            // 
            this.cmbXAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbXAlgo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbXAlgo.FormattingEnabled = true;
            this.cmbXAlgo.Items.AddRange(new object[] {
            "",
            "Laplacian 3x3",
            "Laplacian 3x3 Grayscale",
            "Laplacian 5x5",
            "Laplacian 5x5 Grayscale",
            "Laplacian of Gaussian",
            "Laplacian 3x3 of Gaussian 3x3",
            "Laplacian 3x3 of Gaussian 5x5 - 1",
            "Laplacian 3x3 of Gaussian 5x5 - 2",
            "Laplacian 5x5 of Gaussian 3x3",
            "Laplacian 5x5 of Gaussian 5x5 - 1",
            "Laplacian 5x5 of Gaussian 5x5 - 2",
            "Sobel 3x3",
            "Sobel 3x3 Grayscale",
            "Prewitt",
            "Prewitt Grayscale",
            "Kirsch",
            "Kirsch Grayscale"});
            this.cmbXAlgo.Location = new System.Drawing.Point(12, 94);
            this.cmbXAlgo.Name = "cmbXAlgo";
            this.cmbXAlgo.Size = new System.Drawing.Size(186, 23);
            this.cmbXAlgo.TabIndex = 21;
            // 
            // labelAlgoYAxis
            // 
            this.labelAlgoYAxis.AutoSize = true;
            this.labelAlgoYAxis.Location = new System.Drawing.Point(9, 120);
            this.labelAlgoYAxis.Name = "labelAlgoYAxis";
            this.labelAlgoYAxis.Size = new System.Drawing.Size(81, 13);
            this.labelAlgoYAxis.TabIndex = 2;
            this.labelAlgoYAxis.Text = "Algorithm Y axis";
            // 
            // labelAlgoWholeOrX
            // 
            this.labelAlgoWholeOrX.AutoSize = true;
            this.labelAlgoWholeOrX.Location = new System.Drawing.Point(9, 78);
            this.labelAlgoWholeOrX.Name = "labelAlgoWholeOrX";
            this.labelAlgoWholeOrX.Size = new System.Drawing.Size(50, 13);
            this.labelAlgoWholeOrX.TabIndex = 1;
            this.labelAlgoWholeOrX.Text = "Algorithm";
            // 
            // groupBoxEdgeDetectionAlgorithm
            // 
            this.groupBoxEdgeDetectionAlgorithm.Controls.Add(this.radioButtonXYAxis);
            this.groupBoxEdgeDetectionAlgorithm.Controls.Add(this.radioButtonWholeImage);
            this.groupBoxEdgeDetectionAlgorithm.Location = new System.Drawing.Point(6, 19);
            this.groupBoxEdgeDetectionAlgorithm.Name = "groupBoxEdgeDetectionAlgorithm";
            this.groupBoxEdgeDetectionAlgorithm.Size = new System.Drawing.Size(230, 45);
            this.groupBoxEdgeDetectionAlgorithm.TabIndex = 0;
            this.groupBoxEdgeDetectionAlgorithm.TabStop = false;
            this.groupBoxEdgeDetectionAlgorithm.Text = "Choice of algorithm";
            // 
            // radioButtonXYAxis
            // 
            this.radioButtonXYAxis.AutoSize = true;
            this.radioButtonXYAxis.Location = new System.Drawing.Point(146, 19);
            this.radioButtonXYAxis.Name = "radioButtonXYAxis";
            this.radioButtonXYAxis.Size = new System.Drawing.Size(65, 17);
            this.radioButtonXYAxis.TabIndex = 1;
            this.radioButtonXYAxis.Text = "X/Y axis";
            this.radioButtonXYAxis.UseVisualStyleBackColor = true;
            // 
            // radioButtonWholeImage
            // 
            this.radioButtonWholeImage.AutoSize = true;
            this.radioButtonWholeImage.Checked = true;
            this.radioButtonWholeImage.Location = new System.Drawing.Point(6, 19);
            this.radioButtonWholeImage.Name = "radioButtonWholeImage";
            this.radioButtonWholeImage.Size = new System.Drawing.Size(87, 17);
            this.radioButtonWholeImage.TabIndex = 0;
            this.radioButtonWholeImage.TabStop = true;
            this.radioButtonWholeImage.Text = "Whole image";
            this.radioButtonWholeImage.UseVisualStyleBackColor = true;
            this.radioButtonWholeImage.CheckedChanged += new System.EventHandler(this.radioButtonWholeImage_CheckedChanged);
            // 
            // ImageEdgeDetectionGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1003, 549);
            this.Controls.Add(this.groupBoxEdgeDetectionSettings);
            this.Controls.Add(this.groupBoxFiltersButtons);
            this.Controls.Add(this.btnResetSettings);
            this.Controls.Add(this.btnSaveNewImage);
            this.Controls.Add(this.btnOpenImage);
            this.Controls.Add(this.picPreview);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "ImageEdgeDetectionGui";
            this.Text = "ImageEdgeDetection - Group 15";
            ((System.ComponentModel.ISupportInitialize)(this.picPreview)).EndInit();
            this.groupBoxFiltersButtons.ResumeLayout(false);
            this.groupBoxEdgeDetectionSettings.ResumeLayout(false);
            this.groupBoxEdgeDetectionSettings.PerformLayout();
            this.groupBoxEdgeDetectionAlgorithm.ResumeLayout(false);
            this.groupBoxEdgeDetectionAlgorithm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnResetSettings;
        private System.Windows.Forms.Button btnSaveNewImage;
        private System.Windows.Forms.Button btnOpenImage;
        private System.Windows.Forms.GroupBox groupBoxFiltersButtons;
        private System.Windows.Forms.Button btnFilterNone;
        private System.Windows.Forms.Button btnFilterHell;
        private System.Windows.Forms.Button btnFilterMiami;
        private System.Windows.Forms.Button btnFilterNight;
        private System.Windows.Forms.GroupBox groupBoxEdgeDetectionSettings;
        private System.Windows.Forms.GroupBox groupBoxEdgeDetectionAlgorithm;
        private System.Windows.Forms.RadioButton radioButtonXYAxis;
        private System.Windows.Forms.RadioButton radioButtonWholeImage;
        private System.Windows.Forms.Button btnApplyEdgeDetection;
        private System.Windows.Forms.ComboBox cmbYAlgo;
        private System.Windows.Forms.ComboBox cmbXAlgo;
        private System.Windows.Forms.Label labelAlgoYAxis;
        private System.Windows.Forms.Label labelAlgoWholeOrX;
    }
}

