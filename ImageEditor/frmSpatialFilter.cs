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
    public partial class frmSpatialFilter : Form
    {
        public frmSpatialFilter()
        {
            InitializeComponent();
        }
        private void frmSpatialFilter_Load(object sender, EventArgs e)
        {
            pcbPreview.Image = Util.MakeGrayscale3(pcbPreview.Image);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnSmooth_Click(object sender, EventArgs e)
        {
            /*int[,] Filter = new int[3, 3] { { 1, 2, 1 },
                                            { 2, 4, 2 },
                                            { 1, 2, 1 } };*/
            int[,] Filter = new int[5, 5] {  { 1,1, 1, 1 ,1},
                                             { 1,1, 2, 1 ,1},
                                             { 1,2, 4, 2,1 },
                                             { 1,1, 2, 1 ,1},
                                             { 1,1, 1, 1 ,1}};

            pcbPreview.Image = Util.ApplyFilter(pcbPreview.Image, Filter, 15);
        }


        private void btnLaplacianSharp_Click(object sender, EventArgs e)
        {
            int[,] Filter = new int[3, 3] { { 0, -1, 0 },
                                            { -1, 4, -1 }, 
                                            { 0, -1, 0 } };

            pcbPreview.Image = Util.AddImages(pcbPreview.Image, Util.ApplyFilter(pcbPreview.Image, Filter, 1));
        }

        private void btnUnsharpMaskSharpen_Click(object sender, EventArgs e)
        {
            int[,] Filter = new int[5, 5] {  { 1,1, 1, 1 ,1},
                                             { 1,1, 2, 1 ,1},
                                             { 1,2, 4, 2,1 },
                                             { 1,1, 2, 1 ,1},
                                             { 1,1, 1, 1 ,1}};
            Image smoothed = Util.ApplyFilter(pcbPreview.Image, Filter, 15);

            Image difference = Util.Difference(pcbPreview.Image, smoothed);

            pcbPreview.Image = Util.AddImages(pcbPreview.Image, difference);
        }

        private void btnSobleH_Click(object sender, EventArgs e)
        {
            int[,] Filter = new int[3, 3] { { -1, 0, 1 },
                                            { -2, 0, 2 }, 
                                            { -1, 0, 1 } };

            pcbPreview.Image = Util.ApplyFilter(pcbPreview.Image, Filter, 1);
        }

        private void btnSobelV_Click(object sender, EventArgs e)
        {
            int[,] Filter = new int[3, 3] { { -1, -2, -1 },
                                            { 0, 0, 0 }, 
                                            { 1, 2, 1 } };

            pcbPreview.Image = Util.ApplyFilter(pcbPreview.Image, Filter, 1);
        }

        private void btnLaplacian_Click(object sender, EventArgs e)
        {
            int[,] Filter = new int[3, 3] { { 0, -1, 0 },
                                            { -1, 4, -1 }, 
                                            { 0, -1, 0 } };

            pcbPreview.Image = Util.ApplyFilter(pcbPreview.Image, Filter, 1);
        }

        private void btnUnsharpMask_Click(object sender, EventArgs e)
        {
            int[,] Filter = new int[5, 5] {  { 1,1, 1, 1 ,1},
                                             { 1,1, 2, 1 ,1},
                                             { 1,2, 4, 2,1 },
                                             { 1,1, 2, 1 ,1},
                                             { 1,1, 1, 1 ,1}};
            Image smoothed = Util.ApplyFilter(pcbPreview.Image, Filter, 15);

            pcbPreview.Image = Util.Difference(pcbPreview.Image, smoothed);

        }

    }
}
