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
    public partial class frmIntensityTransform : Form
    {
        public frmIntensityTransform()
        {
            InitializeComponent();
        }
        private void frmSpatialFilter_Load(object sender, EventArgs e)
        {
            pcbPreview.Image = Util.MakeGrayscale3(pcbPreview.Image);
        }

        private void pcbPreview_ImageChanged(object sender, EventArgs e)
        {
            histoPanel.DrawHistogram(Util.Histogram(pcbPreview.Image));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            pcbPreview.Image = Util.Negative(pcbPreview.Image);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            pcbPreview.Image = Util.Log(pcbPreview.Image,(double)nudLog.Value);
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            pcbPreview.Image = Util.Power(pcbPreview.Image, (double)nudPowerC.Value, (double)nudPowerY.Value);
        }

        private void btnHistoEqual_Click(object sender, EventArgs e)
        {
            pcbPreview.Image = Util.HistoEqualizer(pcbPreview.Image);
        }

        private void btnHistoStreach_Click(object sender, EventArgs e)
        {
            pcbPreview.Image = Util.HistoStreach(pcbPreview.Image);
        }
               

        private void btnTreshHold_Click(object sender, EventArgs e)
        {
            pcbPreview.Image = Util.Treshhold(pcbPreview.Image, (int)nudTreshHold.Value);
        }


        
    }
}
