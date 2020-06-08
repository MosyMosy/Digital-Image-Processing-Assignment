namespace ImageEditor
{
    partial class frmSpatialFilter
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnSmooth = new System.Windows.Forms.Button();
            this.btnLaplacianSharp = new System.Windows.Forms.Button();
            this.btnUnsharpMaskSharpen = new System.Windows.Forms.Button();
            this.btnSobleH = new System.Windows.Forms.Button();
            this.btnSobelV = new System.Windows.Forms.Button();
            this.btnLaplacian = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbPreview = new System.Windows.Forms.PictureBox();
            this.btnUnsharpMask = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 592);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.btnOk, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSmooth, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.btnLaplacianSharp, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.btnUnsharpMaskSharpen, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnSobleH, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnSobelV, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.btnLaplacian, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.btnUnsharpMask, 0, 8);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(788, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(150, 592);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOk.Location = new System.Drawing.Point(3, 3);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(144, 24);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSmooth
            // 
            this.btnSmooth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSmooth.Location = new System.Drawing.Point(3, 43);
            this.btnSmooth.Name = "btnSmooth";
            this.btnSmooth.Size = new System.Drawing.Size(144, 24);
            this.btnSmooth.TabIndex = 1;
            this.btnSmooth.Text = "Smooth";
            this.btnSmooth.UseVisualStyleBackColor = true;
            this.btnSmooth.Click += new System.EventHandler(this.btnSmooth_Click);
            // 
            // btnLaplacianSharp
            // 
            this.btnLaplacianSharp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLaplacianSharp.Location = new System.Drawing.Point(3, 73);
            this.btnLaplacianSharp.Name = "btnLaplacianSharp";
            this.btnLaplacianSharp.Size = new System.Drawing.Size(144, 24);
            this.btnLaplacianSharp.TabIndex = 2;
            this.btnLaplacianSharp.Text = "Laplacian Sharp";
            this.btnLaplacianSharp.UseVisualStyleBackColor = true;
            this.btnLaplacianSharp.Click += new System.EventHandler(this.btnLaplacianSharp_Click);
            // 
            // btnUnsharpMaskSharpen
            // 
            this.btnUnsharpMaskSharpen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnsharpMaskSharpen.Location = new System.Drawing.Point(3, 103);
            this.btnUnsharpMaskSharpen.Name = "btnUnsharpMaskSharpen";
            this.btnUnsharpMaskSharpen.Size = new System.Drawing.Size(144, 24);
            this.btnUnsharpMaskSharpen.TabIndex = 3;
            this.btnUnsharpMaskSharpen.Text = "UnsharpMask Sharp";
            this.btnUnsharpMaskSharpen.UseVisualStyleBackColor = true;
            this.btnUnsharpMaskSharpen.Click += new System.EventHandler(this.btnUnsharpMaskSharpen_Click);
            // 
            // btnSobleH
            // 
            this.btnSobleH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSobleH.Location = new System.Drawing.Point(3, 133);
            this.btnSobleH.Name = "btnSobleH";
            this.btnSobleH.Size = new System.Drawing.Size(144, 24);
            this.btnSobleH.TabIndex = 4;
            this.btnSobleH.Text = "Sobel H";
            this.btnSobleH.UseVisualStyleBackColor = true;
            this.btnSobleH.Click += new System.EventHandler(this.btnSobleH_Click);
            // 
            // btnSobelV
            // 
            this.btnSobelV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSobelV.Location = new System.Drawing.Point(3, 163);
            this.btnSobelV.Name = "btnSobelV";
            this.btnSobelV.Size = new System.Drawing.Size(144, 24);
            this.btnSobelV.TabIndex = 5;
            this.btnSobelV.Text = "Sobel V";
            this.btnSobelV.UseVisualStyleBackColor = true;
            this.btnSobelV.Click += new System.EventHandler(this.btnSobelV_Click);
            // 
            // btnLaplacian
            // 
            this.btnLaplacian.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLaplacian.Location = new System.Drawing.Point(3, 193);
            this.btnLaplacian.Name = "btnLaplacian";
            this.btnLaplacian.Size = new System.Drawing.Size(144, 24);
            this.btnLaplacian.TabIndex = 6;
            this.btnLaplacian.Text = "Laplacian";
            this.btnLaplacian.UseVisualStyleBackColor = true;
            this.btnLaplacian.Click += new System.EventHandler(this.btnLaplacian_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pcbPreview);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(788, 592);
            this.panel1.TabIndex = 2;
            // 
            // pcbPreview
            // 
            this.pcbPreview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pcbPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcbPreview.Location = new System.Drawing.Point(0, 0);
            this.pcbPreview.Name = "pcbPreview";
            this.pcbPreview.Size = new System.Drawing.Size(0, 0);
            this.pcbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbPreview.TabIndex = 0;
            this.pcbPreview.TabStop = false;
            // 
            // btnUnsharpMask
            // 
            this.btnUnsharpMask.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUnsharpMask.Location = new System.Drawing.Point(3, 223);
            this.btnUnsharpMask.Name = "btnUnsharpMask";
            this.btnUnsharpMask.Size = new System.Drawing.Size(144, 24);
            this.btnUnsharpMask.TabIndex = 7;
            this.btnUnsharpMask.Text = "UnsharpMask Difference";
            this.btnUnsharpMask.UseVisualStyleBackColor = true;
            this.btnUnsharpMask.Click += new System.EventHandler(this.btnUnsharpMask_Click);
            // 
            // frmSpatialFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmSpatialFilter";
            this.Text = "Transformation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSpatialFilter_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOk;
        public System.Windows.Forms.PictureBox pcbPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSmooth;
        private System.Windows.Forms.Button btnLaplacianSharp;
        private System.Windows.Forms.Button btnUnsharpMaskSharpen;
        private System.Windows.Forms.Button btnSobleH;
        private System.Windows.Forms.Button btnSobelV;
        private System.Windows.Forms.Button btnLaplacian;
        private System.Windows.Forms.Button btnUnsharpMask;
    }
}