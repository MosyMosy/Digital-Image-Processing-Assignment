using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class frmMain : Form
    {
        List<Image> imagesHistory = new List<Image>();
        int currentHistIndex = -1;

        private void showImage()
        {
            if (imagesHistory.Count > 0)
            {
                if (currentHistIndex > -1)
                {
                    pcbMain.Image = imagesHistory[currentHistIndex];
                }

            }
            else
            {
                pcbMain.Image = null;
            }

        }
        public void AddNewImage(Image newImage)
        {
            // remove proceeding steps
            //imagesHistory.RemoveRange(currentHistIndex + 1, this.imagesHistory.Count - (currentHistIndex + 1));

            imagesHistory.Add(newImage);
            currentHistIndex = imagesHistory.Count - 1;
            showImage();
        }
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnBackward_Click(object sender, EventArgs e)
        {
            if (currentHistIndex > 0)
            {
                currentHistIndex--;
                showImage();
            }
        }

        private void btnFroward_Click(object sender, EventArgs e)
        {
            if (currentHistIndex < imagesHistory.Count - 1)
            {
                currentHistIndex++;
                showImage();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*currentHistIndex = -1;
            imagesHistory = new List<Image>();
            pcbMain.Image = null;*/

            if (currentHistIndex > -1)
            {
                imagesHistory.Remove(imagesHistory[currentHistIndex]);
                if (currentHistIndex > 0)
                {
                    currentHistIndex--;
                }
                else if (currentHistIndex < imagesHistory.Count - 1)
                {
                    currentHistIndex++;
                }

                showImage();
            }

        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select Image";
                dlg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    AddNewImage(Image.FromFile(dlg.FileName));
                }
            }
        }

        private void btnTransform_Click(object sender, EventArgs e)
        {
            if (currentHistIndex > -1)
            {
                frmTransformation frmTrans = new frmTransformation();
                frmTrans.pcbPreview.Image = imagesHistory[currentHistIndex];
                var DialogResult = frmTrans.ShowDialog();
                if (DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    AddNewImage(frmTrans.pcbPreview.Image);
                }
            }
            else
            {
                MessageBox.Show("There is no image to transform");
            }

        }

        private void btnSpatialFilters_Click(object sender, EventArgs e)
        {
            if (currentHistIndex > -1)
            {
                frmSpatialFilter frmSFilter = new frmSpatialFilter();
                frmSFilter.pcbPreview.Image = imagesHistory[currentHistIndex];
                var DialogResult = frmSFilter.ShowDialog();
                if (DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    AddNewImage(frmSFilter.pcbPreview.Image);
                }
            }
            else
            {
                MessageBox.Show("There is no image to transform");
            }
        }

        private void btnIntensityTransform_Click(object sender, EventArgs e)
        {
            if (currentHistIndex > -1)
            {
                frmIntensityTransform IntensityTransform = new frmIntensityTransform();
                IntensityTransform.pcbPreview.Image = imagesHistory[currentHistIndex];
                var DialogResult = IntensityTransform.ShowDialog();
                if (DialogResult == System.Windows.Forms.DialogResult.OK)
                {
                    AddNewImage(IntensityTransform.pcbPreview.Image);
                }
            }
            else
            {
                MessageBox.Show("There is no image to transform");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (pcbMain.Image != null)
            {
                using (SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.Title = "Save Image";
                    dlg.Filter = "Image files (*.jpg) | *.jpg";
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        pcbMain.Image.Save(dlg.FileName, ImageFormat.Jpeg);
                    }
                }
            }
        }
    }
}
