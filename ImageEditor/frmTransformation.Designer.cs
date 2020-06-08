namespace ImageEditor
{
    partial class frmTransformation
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.nudMoveStep = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ckbScaleInterpolation = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.nudScaleFace = new System.Windows.Forms.NumericUpDown();
            this.nudScaleDenominator = new System.Windows.Forms.NumericUpDown();
            this.btnScaleH = new System.Windows.Forms.Button();
            this.btnScaleV = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudRotateAngle = new System.Windows.Forms.NumericUpDown();
            this.pcbRotate = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnShearHR = new System.Windows.Forms.Button();
            this.btnShearVD = new System.Windows.Forms.Button();
            this.nudShear = new System.Windows.Forms.NumericUpDown();
            this.btnShearHL = new System.Windows.Forms.Button();
            this.btnShearVU = new System.Windows.Forms.Button();
            this.Mirror = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.btnMirrorH = new System.Windows.Forms.Button();
            this.btnMirrorV = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pcbPreview = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveStep)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleFace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleDenominator)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRotate)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudShear)).BeginInit();
            this.Mirror.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
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
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.groupBox2, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.groupBox3, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.groupBox4, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.Mirror, 0, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(788, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 95);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Move";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.btnMoveUp, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnMoveDown, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.btnMoveRight, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnMoveLeft, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.nudMoveStep, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(144, 76);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnMoveUp
            // 
            this.btnMoveUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveUp.Location = new System.Drawing.Point(48, 0);
            this.btnMoveUp.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(48, 26);
            this.btnMoveUp.TabIndex = 0;
            this.btnMoveUp.Text = "∧";
            this.btnMoveUp.UseVisualStyleBackColor = true;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnMoveDown
            // 
            this.btnMoveDown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveDown.Location = new System.Drawing.Point(48, 48);
            this.btnMoveDown.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(48, 28);
            this.btnMoveDown.TabIndex = 1;
            this.btnMoveDown.Text = "∨";
            this.btnMoveDown.UseVisualStyleBackColor = true;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveRight.Location = new System.Drawing.Point(96, 26);
            this.btnMoveRight.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(48, 22);
            this.btnMoveRight.TabIndex = 2;
            this.btnMoveRight.Text = ">";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveLeft.Location = new System.Drawing.Point(0, 26);
            this.btnMoveLeft.Margin = new System.Windows.Forms.Padding(0);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(48, 22);
            this.btnMoveLeft.TabIndex = 3;
            this.btnMoveLeft.Text = "<";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // nudMoveStep
            // 
            this.nudMoveStep.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudMoveStep.Location = new System.Drawing.Point(48, 26);
            this.nudMoveStep.Margin = new System.Windows.Forms.Padding(0);
            this.nudMoveStep.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMoveStep.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMoveStep.Name = "nudMoveStep";
            this.nudMoveStep.Size = new System.Drawing.Size(48, 20);
            this.nudMoveStep.TabIndex = 4;
            this.nudMoveStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbScaleInterpolation);
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 125);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 86);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scale";
            // 
            // ckbScaleInterpolation
            // 
            this.ckbScaleInterpolation.AutoSize = true;
            this.ckbScaleInterpolation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbScaleInterpolation.Location = new System.Drawing.Point(3, 58);
            this.ckbScaleInterpolation.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.ckbScaleInterpolation.Name = "ckbScaleInterpolation";
            this.ckbScaleInterpolation.Size = new System.Drawing.Size(144, 25);
            this.ckbScaleInterpolation.TabIndex = 3;
            this.ckbScaleInterpolation.Text = "With Interpolation";
            this.ckbScaleInterpolation.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnScaleH, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnScaleV, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(144, 42);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.nudScaleFace, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.nudScaleDenominator, 0, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(48, 0);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(48, 42);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // nudScaleFace
            // 
            this.nudScaleFace.Location = new System.Drawing.Point(0, 0);
            this.nudScaleFace.Margin = new System.Windows.Forms.Padding(0);
            this.nudScaleFace.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScaleFace.Name = "nudScaleFace";
            this.nudScaleFace.Size = new System.Drawing.Size(48, 20);
            this.nudScaleFace.TabIndex = 0;
            this.nudScaleFace.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudScaleDenominator
            // 
            this.nudScaleDenominator.Location = new System.Drawing.Point(0, 21);
            this.nudScaleDenominator.Margin = new System.Windows.Forms.Padding(0);
            this.nudScaleDenominator.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudScaleDenominator.Name = "nudScaleDenominator";
            this.nudScaleDenominator.Size = new System.Drawing.Size(48, 20);
            this.nudScaleDenominator.TabIndex = 1;
            this.nudScaleDenominator.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnScaleH
            // 
            this.btnScaleH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScaleH.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnScaleH.Location = new System.Drawing.Point(96, 0);
            this.btnScaleH.Margin = new System.Windows.Forms.Padding(0);
            this.btnScaleH.Name = "btnScaleH";
            this.btnScaleH.Size = new System.Drawing.Size(48, 42);
            this.btnScaleH.TabIndex = 1;
            this.btnScaleH.Text = "---";
            this.btnScaleH.UseVisualStyleBackColor = true;
            this.btnScaleH.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnScaleV
            // 
            this.btnScaleV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnScaleV.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnScaleV.Location = new System.Drawing.Point(0, 0);
            this.btnScaleV.Margin = new System.Windows.Forms.Padding(0);
            this.btnScaleV.Name = "btnScaleV";
            this.btnScaleV.Size = new System.Drawing.Size(48, 42);
            this.btnScaleV.TabIndex = 2;
            this.btnScaleV.Text = "|";
            this.btnScaleV.UseVisualStyleBackColor = true;
            this.btnScaleV.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudRotateAngle);
            this.groupBox3.Controls.Add(this.pcbRotate);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 211);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 150);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rotate";
            // 
            // nudRotateAngle
            // 
            this.nudRotateAngle.Location = new System.Drawing.Point(51, 68);
            this.nudRotateAngle.Margin = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.nudRotateAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nudRotateAngle.Minimum = new decimal(new int[] {
            360,
            0,
            0,
            -2147483648});
            this.nudRotateAngle.Name = "nudRotateAngle";
            this.nudRotateAngle.Size = new System.Drawing.Size(48, 20);
            this.nudRotateAngle.TabIndex = 0;
            this.nudRotateAngle.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRotateAngle.ValueChanged += new System.EventHandler(this.nudRotateAngle_ValueChanged);
            // 
            // pcbRotate
            // 
            this.pcbRotate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbRotate.Location = new System.Drawing.Point(3, 16);
            this.pcbRotate.Name = "pcbRotate";
            this.pcbRotate.Size = new System.Drawing.Size(144, 131);
            this.pcbRotate.TabIndex = 0;
            this.pcbRotate.TabStop = false;
            this.pcbRotate.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pcbRotate_MouseMove);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel7);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(0, 361);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 130);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Shear";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Controls.Add(this.btnShearHR, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.btnShearVD, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.nudShear, 1, 1);
            this.tableLayoutPanel7.Controls.Add(this.btnShearHL, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.btnShearVU, 2, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 3;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(144, 111);
            this.tableLayoutPanel7.TabIndex = 1;
            // 
            // btnShearHR
            // 
            this.btnShearHR.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShearHR.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShearHR.Location = new System.Drawing.Point(48, 74);
            this.btnShearHR.Margin = new System.Windows.Forms.Padding(0);
            this.btnShearHR.Name = "btnShearHR";
            this.btnShearHR.Size = new System.Drawing.Size(48, 37);
            this.btnShearHR.TabIndex = 1;
            this.btnShearHR.Text = "∨";
            this.btnShearHR.UseVisualStyleBackColor = true;
            this.btnShearHR.Click += new System.EventHandler(this.btnShear_Click);
            // 
            // btnShearVD
            // 
            this.btnShearVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShearVD.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnShearVD.Location = new System.Drawing.Point(0, 37);
            this.btnShearVD.Margin = new System.Windows.Forms.Padding(0);
            this.btnShearVD.Name = "btnShearVD";
            this.btnShearVD.Size = new System.Drawing.Size(48, 37);
            this.btnShearVD.TabIndex = 3;
            this.btnShearVD.Text = "<";
            this.btnShearVD.UseVisualStyleBackColor = true;
            this.btnShearVD.Click += new System.EventHandler(this.btnShear_Click);
            // 
            // nudShear
            // 
            this.nudShear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nudShear.Location = new System.Drawing.Point(48, 45);
            this.nudShear.Margin = new System.Windows.Forms.Padding(0, 8, 0, 0);
            this.nudShear.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudShear.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudShear.Name = "nudShear";
            this.nudShear.Size = new System.Drawing.Size(48, 20);
            this.nudShear.TabIndex = 4;
            this.nudShear.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnShearHL
            // 
            this.btnShearHL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShearHL.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShearHL.Location = new System.Drawing.Point(48, 0);
            this.btnShearHL.Margin = new System.Windows.Forms.Padding(0);
            this.btnShearHL.Name = "btnShearHL";
            this.btnShearHL.Size = new System.Drawing.Size(48, 37);
            this.btnShearHL.TabIndex = 5;
            this.btnShearHL.Text = "btnShearHL";
            this.btnShearHL.UseVisualStyleBackColor = true;
            this.btnShearHL.Click += new System.EventHandler(this.btnShear_Click);
            // 
            // btnShearVU
            // 
            this.btnShearVU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShearVU.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShearVU.Location = new System.Drawing.Point(96, 37);
            this.btnShearVU.Margin = new System.Windows.Forms.Padding(0);
            this.btnShearVU.Name = "btnShearVU";
            this.btnShearVU.Size = new System.Drawing.Size(48, 37);
            this.btnShearVU.TabIndex = 6;
            this.btnShearVU.Text = "btnShearVU";
            this.btnShearVU.UseVisualStyleBackColor = true;
            this.btnShearVU.Click += new System.EventHandler(this.btnShear_Click);
            // 
            // Mirror
            // 
            this.Mirror.Controls.Add(this.tableLayoutPanel8);
            this.Mirror.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mirror.Location = new System.Drawing.Point(3, 494);
            this.Mirror.Name = "Mirror";
            this.Mirror.Size = new System.Drawing.Size(144, 84);
            this.Mirror.TabIndex = 8;
            this.Mirror.TabStop = false;
            this.Mirror.Text = "Mirror";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.btnMirrorH, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.btnMirrorV, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(138, 65);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // btnMirrorH
            // 
            this.btnMirrorH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMirrorH.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMirrorH.Location = new System.Drawing.Point(72, 3);
            this.btnMirrorH.Name = "btnMirrorH";
            this.btnMirrorH.Size = new System.Drawing.Size(63, 59);
            this.btnMirrorH.TabIndex = 0;
            this.btnMirrorH.Text = "button1";
            this.btnMirrorH.UseVisualStyleBackColor = true;
            this.btnMirrorH.Click += new System.EventHandler(this.btnMirrorH_Click);
            // 
            // btnMirrorV
            // 
            this.btnMirrorV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMirrorV.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMirrorV.Location = new System.Drawing.Point(3, 3);
            this.btnMirrorV.Name = "btnMirrorV";
            this.btnMirrorV.Size = new System.Drawing.Size(63, 59);
            this.btnMirrorV.TabIndex = 1;
            this.btnMirrorV.Text = "button2";
            this.btnMirrorV.UseVisualStyleBackColor = true;
            this.btnMirrorV.Click += new System.EventHandler(this.btnMirrorV_Click);
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
            // frmTransformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmTransformation";
            this.Text = "Transformation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTransformation_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudMoveStep)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleFace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudScaleDenominator)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudRotateAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRotate)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudShear)).EndInit();
            this.Mirror.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnMoveRight;
        private System.Windows.Forms.Button btnMoveLeft;
        private System.Windows.Forms.NumericUpDown nudMoveStep;
        public System.Windows.Forms.PictureBox pcbPreview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.NumericUpDown nudScaleFace;
        private System.Windows.Forms.NumericUpDown nudScaleDenominator;
        private System.Windows.Forms.Button btnScaleH;
        private System.Windows.Forms.Button btnScaleV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox ckbScaleInterpolation;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown nudRotateAngle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Button btnShearHR;
        private System.Windows.Forms.Button btnShearVD;
        private System.Windows.Forms.NumericUpDown nudShear;
        private System.Windows.Forms.Button btnShearHL;
        private System.Windows.Forms.Button btnShearVU;
        private System.Windows.Forms.GroupBox Mirror;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.Button btnMirrorH;
        private System.Windows.Forms.Button btnMirrorV;
        private System.Windows.Forms.PictureBox pcbRotate;
    }
}