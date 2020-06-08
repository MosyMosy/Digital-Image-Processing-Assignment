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
    public partial class frmTransformation : Form
    {
        public frmTransformation()
        {
            InitializeComponent();
        }

        private void frmTransformation_Load(object sender, EventArgs e)
        {
            btnScaleH.Text = "\u2b64";
            btnScaleV.Text = "\u2b65";


            btnShearHL.Text = "\u21bc";
            btnShearHR.Text = "\u21c0";
            btnShearVU.Text = "\u21be";
            btnShearVD.Text = "\u21c3";

            btnMirrorH.Text = "\u21cb";
            btnMirrorV.Text = "\u296f";

            Bitmap bmp = new Bitmap(pcbRotate.Width, pcbRotate.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawEllipse(new Pen(Color.Black), new Rectangle(0, 0, bmp.Width - 1, bmp.Height - 1));
            g.DrawLine(new Pen(Color.Red), new Point((bmp.Width - 1) / 2, (bmp.Width - 1) / 2), new Point(150, (bmp.Width - 1) / 2));
            g.Dispose();
            pcbRotate.Image = bmp;
            pcbRotate.Refresh();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        private void pcbRotate_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Bitmap bmp = new Bitmap(pcbRotate.Width, pcbRotate.Height);
                Graphics g = Graphics.FromImage(bmp);
                g.DrawEllipse(new Pen(Color.Black), new Rectangle(0, 0, bmp.Width - 1, bmp.Height - 1));
                // Calculamos el punto de interseccion entre la recta generada por dos puntos
                //Trasladamos las coordenadas a 0,0
                double mouseX = e.X - (bmp.Width - 1) / 2;
                double mouseY = e.Y - (bmp.Width - 1) / 2;
                double calc = Math.Pow((bmp.Width - 1) / 2, 2) / Math.Sqrt(Math.Pow((bmp.Width - 1) / 2, 2) * (Math.Pow(mouseY, 2) + Math.Pow(mouseX, 2)));
                // Calculamos y trasladamos otra vez el origen del circulo
                int finalX = (int)(mouseX * calc + (bmp.Width - 1) / 2);
                int finalY = (int)(mouseY * calc + (bmp.Width - 1) / 2);
                // Dibujamos la linea
                g.DrawLine(new Pen(Color.Red), new Point((bmp.Width - 1) / 2, (bmp.Width - 1) / 2), new Point(finalX, finalY));
                g.Dispose();
                pcbRotate.Image = bmp;
                pcbRotate.Refresh();
                // Calculamos el angulo de rotacion
                double Dy = e.Y - (bmp.Width - 1) / 2;
                double Dx = e.X - (bmp.Width - 1) / 2;
                double angle = Math.Atan2(Dy, Dx);
                angle *= -180 / Math.PI;
                //Cache.SetMainformPictureBox(Rotate.FreeRotationNearestNeighbor(bitmap, angle));
                // Mostramos el angulo
                nudRotateAngle.Value = (Decimal)angle;
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            int Tx = 0;
            int Ty = 0;
            switch (((Button)sender).Name)
            {
                case "btnMoveUp":
                    Ty = ((int)nudMoveStep.Value) * -1;
                    break;
                case "btnMoveLeft":
                    Tx = ((int)nudMoveStep.Value) * -1;
                    break;
                case "btnMoveDown":
                    Ty = ((int)nudMoveStep.Value);
                    break;
                case "btnMoveRight":
                    Tx = ((int)nudMoveStep.Value);
                    break;
                default:
                    break;
            }
            pcbPreview.Image = Util.MoveTransform(pcbPreview.Image, Tx, Ty);
        }



        private void btnScale_Click(object sender, EventArgs e)
        {
            float Cx = 1;
            float Cy = 1;
            decimal scale = nudScaleFace.Value / nudScaleDenominator.Value;
            switch (((Button)sender).Name)
            {
                case "btnScaleH":
                    Cx = ((float)scale);
                    break;
                case "btnScaleV":
                    Cy = ((float)scale);
                    break;
                default:
                    break;
            }
            Bitmap bmp = null;
            bmp = Util.ScaleTransform((Bitmap)pcbPreview.Image, (int)(Cx * pcbPreview.Image.Width), (int)(Cy * pcbPreview.Image.Height));
            if (bmp != null)
            {
                pcbPreview.Image = bmp;
            }
        }

        private void nudRotateAngle_ValueChanged(object sender, EventArgs e)
        {
            pcbPreview.Image = Util.RotationNearestNeighbor((Bitmap)pcbPreview.Image, (double)nudRotateAngle.Value);
        }

        private void btnShear_Click(object sender, EventArgs e)
        {
            float Sv = 0;
            float Sh = 0;
            switch (((Button)sender).Name)
            {                
                case "btnShearHR":
                    Sv = ((float)nudShear.Value)/10;
                    break;
                case "btnShearHL":
                    Sv = -((float)nudShear.Value) / 10;
                    break;
                case "btnShearVD":
                    Sh = ((float)nudShear.Value)/10;                    
                    break;               
                case "btnShearVU":
                    Sh = -((float)nudShear.Value) / 10;
                    break;
                default:
                    break;
            }
            
            pcbPreview.Image = Util.ShearTransform(pcbPreview.Image,Sh,Sv);
        }

        private void btnMirrorV_Click(object sender, EventArgs e)
        {
            pcbPreview.Image = Util.Mirror(pcbPreview.Image, true);
        }

        private void btnMirrorH_Click(object sender, EventArgs e)
        {
            pcbPreview.Image = Util.Mirror(pcbPreview.Image, false);
        }

        

        
    }
}
