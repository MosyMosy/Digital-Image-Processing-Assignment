namespace ImageEditor
{
    partial class frmIntensityTransform
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
            this.btnNegative = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.nudLog = new System.Windows.Forms.NumericUpDown();
            this.btnLog = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.nudPowerC = new System.Windows.Forms.NumericUpDown();
            this.nudPowerY = new System.Windows.Forms.NumericUpDown();
            this.btnPower = new System.Windows.Forms.Button();
            this.btnHistoEqual = new System.Windows.Forms.Button();
            this.btnHistoStreach = new System.Windows.Forms.Button();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.nudTreshHold = new System.Windows.Forms.NumericUpDown();
            this.btnTreshHold = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbPreview = new ImageEditor.CustomPictureBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.histoPanel = new Histograma.HistogramaDesenat();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLog)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPowerC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPowerY)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTreshHold)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPreview)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
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
            this.tableLayoutPanel2.Controls.Add(this.btnNegative, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.btnHistoEqual, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.btnHistoStreach, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 7);
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
            // btnNegative
            // 
            this.btnNegative.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNegative.Location = new System.Drawing.Point(3, 43);
            this.btnNegative.Name = "btnNegative";
            this.btnNegative.Size = new System.Drawing.Size(144, 24);
            this.btnNegative.TabIndex = 1;
            this.btnNegative.Text = "Negative";
            this.btnNegative.UseVisualStyleBackColor = true;
            this.btnNegative.Click += new System.EventHandler(this.btnNegative_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.66667F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.33334F));
            this.tableLayoutPanel3.Controls.Add(this.nudLog, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnLog, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 70);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(150, 30);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // nudLog
            // 
            this.nudLog.DecimalPlaces = 1;
            this.nudLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudLog.Location = new System.Drawing.Point(3, 5);
            this.nudLog.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.nudLog.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudLog.Name = "nudLog";
            this.nudLog.Size = new System.Drawing.Size(36, 20);
            this.nudLog.TabIndex = 0;
            this.nudLog.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnLog
            // 
            this.btnLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLog.Location = new System.Drawing.Point(45, 3);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(102, 24);
            this.btnLog.TabIndex = 1;
            this.btnLog.Text = "Log";
            this.btnLog.UseVisualStyleBackColor = true;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel4.Controls.Add(this.nudPowerC, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.nudPowerY, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnPower, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(150, 30);
            this.tableLayoutPanel4.TabIndex = 3;
            // 
            // nudPowerC
            // 
            this.nudPowerC.DecimalPlaces = 1;
            this.nudPowerC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPowerC.Location = new System.Drawing.Point(3, 5);
            this.nudPowerC.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.nudPowerC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPowerC.Name = "nudPowerC";
            this.nudPowerC.Size = new System.Drawing.Size(36, 20);
            this.nudPowerC.TabIndex = 2;
            this.nudPowerC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudPowerY
            // 
            this.nudPowerY.DecimalPlaces = 1;
            this.nudPowerY.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudPowerY.Location = new System.Drawing.Point(111, 5);
            this.nudPowerY.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.nudPowerY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudPowerY.Name = "nudPowerY";
            this.nudPowerY.Size = new System.Drawing.Size(36, 20);
            this.nudPowerY.TabIndex = 1;
            this.nudPowerY.Value = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            // 
            // btnPower
            // 
            this.btnPower.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPower.Location = new System.Drawing.Point(45, 3);
            this.btnPower.Name = "btnPower";
            this.btnPower.Size = new System.Drawing.Size(60, 24);
            this.btnPower.TabIndex = 3;
            this.btnPower.Text = "Power";
            this.btnPower.UseVisualStyleBackColor = true;
            this.btnPower.Click += new System.EventHandler(this.btnPower_Click);
            // 
            // btnHistoEqual
            // 
            this.btnHistoEqual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistoEqual.Location = new System.Drawing.Point(3, 133);
            this.btnHistoEqual.Name = "btnHistoEqual";
            this.btnHistoEqual.Size = new System.Drawing.Size(144, 24);
            this.btnHistoEqual.TabIndex = 4;
            this.btnHistoEqual.Text = "Histogram Equalizer";
            this.btnHistoEqual.UseVisualStyleBackColor = true;
            this.btnHistoEqual.Click += new System.EventHandler(this.btnHistoEqual_Click);
            // 
            // btnHistoStreach
            // 
            this.btnHistoStreach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHistoStreach.Location = new System.Drawing.Point(3, 163);
            this.btnHistoStreach.Name = "btnHistoStreach";
            this.btnHistoStreach.Size = new System.Drawing.Size(144, 24);
            this.btnHistoStreach.TabIndex = 5;
            this.btnHistoStreach.Text = "HistogramStreach";
            this.btnHistoStreach.UseVisualStyleBackColor = true;
            this.btnHistoStreach.Click += new System.EventHandler(this.btnHistoStreach_Click);
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel6.Controls.Add(this.nudTreshHold, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnTreshHold, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 190);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(150, 30);
            this.tableLayoutPanel6.TabIndex = 6;
            // 
            // nudTreshHold
            // 
            this.nudTreshHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudTreshHold.Location = new System.Drawing.Point(3, 5);
            this.nudTreshHold.Margin = new System.Windows.Forms.Padding(3, 5, 3, 3);
            this.nudTreshHold.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudTreshHold.Name = "nudTreshHold";
            this.nudTreshHold.Size = new System.Drawing.Size(42, 20);
            this.nudTreshHold.TabIndex = 0;
            this.nudTreshHold.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // btnTreshHold
            // 
            this.btnTreshHold.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTreshHold.Location = new System.Drawing.Point(51, 3);
            this.btnTreshHold.Name = "btnTreshHold";
            this.btnTreshHold.Size = new System.Drawing.Size(96, 24);
            this.btnTreshHold.TabIndex = 1;
            this.btnTreshHold.Text = "Treshhold";
            this.btnTreshHold.UseVisualStyleBackColor = true;
            this.btnTreshHold.Click += new System.EventHandler(this.btnTreshHold_Click);
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
            this.panel1.Size = new System.Drawing.Size(585, 592);
            this.panel1.TabIndex = 2;
            // 
            // pcbPreview
            // 
            this.pcbPreview.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pcbPreview.Cursor = System.Windows.Forms.Cursors.Default;
            this.pcbPreview.Image = null;
            this.pcbPreview.Location = new System.Drawing.Point(0, 0);
            this.pcbPreview.Name = "pcbPreview";
            this.pcbPreview.Size = new System.Drawing.Size(0, 0);
            this.pcbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcbPreview.TabIndex = 0;
            this.pcbPreview.TabStop = false;
            this.pcbPreview.ImageChanged += new System.EventHandler(this.pcbPreview_ImageChanged);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.histoPanel, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(588, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.843F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.157F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(197, 586);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // histoPanel
            // 
            this.histoPanel.BackColor = System.Drawing.SystemColors.Info;
            this.histoPanel.DisplayColor = System.Drawing.Color.Black;
            this.histoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.histoPanel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.histoPanel.Location = new System.Drawing.Point(3, 3);
            this.histoPanel.Name = "histoPanel";
            this.histoPanel.Offset = 20;
            this.histoPanel.Size = new System.Drawing.Size(191, 121);
            this.histoPanel.TabIndex = 0;
            // 
            // frmIntensityTransform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmIntensityTransform";
            this.Text = "Transformation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSpatialFilter_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLog)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudPowerC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPowerY)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudTreshHold)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPreview)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOk;
        public CustomPictureBox pcbPreview;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNegative;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.NumericUpDown nudLog;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.NumericUpDown nudPowerC;
        private System.Windows.Forms.NumericUpDown nudPowerY;
        private System.Windows.Forms.Button btnPower;
        private System.Windows.Forms.Button btnHistoEqual;
        private System.Windows.Forms.Button btnHistoStreach;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Histograma.HistogramaDesenat histoPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.NumericUpDown nudTreshHold;
        private System.Windows.Forms.Button btnTreshHold;
    }
}