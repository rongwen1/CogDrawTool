﻿
namespace CogDrawTool
{
    partial class DrawToolFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DrawToolFrm));
            this.cogDisplay1 = new Cognex.VisionPro.Display.CogDisplay();
            this.cogDisplayStatusBarV21 = new Cognex.VisionPro.CogDisplayStatusBarV2();
            this.cogDisplayToolbarV21 = new Cognex.VisionPro.CogDisplayToolbarV2();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BtnLoad = new System.Windows.Forms.ToolStripButton();
            this.BtnRect = new System.Windows.Forms.ToolStripButton();
            this.BtnAnnotation = new System.Windows.Forms.ToolStripButton();
            this.BtnPoint = new System.Windows.Forms.ToolStripButton();
            this.BtnLine = new System.Windows.Forms.ToolStripButton();
            this.btnArrow = new System.Windows.Forms.ToolStripButton();
            this.btnDraw = new System.Windows.Forms.ToolStripButton();
            this.btnDistance = new System.Windows.Forms.ToolStripButton();
            this.OpenImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.SaveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dGVDefectList = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.RBtnScratch = new System.Windows.Forms.RadioButton();
            this.RBtnCrack = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnTest = new System.Windows.Forms.Button();
            this.UpDownLineWidth = new System.Windows.Forms.NumericUpDown();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnTest2 = new System.Windows.Forms.Button();
            this.btnTest3 = new System.Windows.Forms.Button();
            this.numericUpDownTest = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTrash = new System.Windows.Forms.Button();
            this.RBtn2CircleLength = new System.Windows.Forms.RadioButton();
            this.RBtnPerpLength = new System.Windows.Forms.RadioButton();
            this.RBtn2LineAngle = new System.Windows.Forms.RadioButton();
            this.RBtnSingleRadius = new System.Windows.Forms.RadioButton();
            this.RBtnTrigAngle = new System.Windows.Forms.RadioButton();
            this.RBtnMultiPointsLength = new System.Windows.Forms.RadioButton();
            this.RBtnNone = new System.Windows.Forms.RadioButton();
            this.RBtn2Points = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.RBtnDotColor = new System.Windows.Forms.RadioButton();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RBtnLineColor = new System.Windows.Forms.RadioButton();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PBRed = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.TBFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDefectList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTest)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.SuspendLayout();
            // 
            // cogDisplay1
            // 
            this.cogDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay1.Location = new System.Drawing.Point(3, 35);
            this.cogDisplay1.Margin = new System.Windows.Forms.Padding(4);
            this.cogDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay1.MouseWheelSensitivity = 1D;
            this.cogDisplay1.Name = "cogDisplay1";
            this.cogDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay1.OcxState")));
            this.cogDisplay1.Size = new System.Drawing.Size(761, 626);
            this.cogDisplay1.TabIndex = 1;
            this.cogDisplay1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cogDisplay1_MouseDown);
            this.cogDisplay1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.cogDisplay1_MouseUp);
            this.cogDisplay1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cogDisplay1_MouseMove);
            // 
            // cogDisplayStatusBarV21
            // 
            this.cogDisplayStatusBarV21.CoordinateSpaceName = "*\\#";
            this.cogDisplayStatusBarV21.CoordinateSpaceName3D = "*\\#";
            this.cogDisplayStatusBarV21.Location = new System.Drawing.Point(109, 684);
            this.cogDisplayStatusBarV21.Margin = new System.Windows.Forms.Padding(4);
            this.cogDisplayStatusBarV21.Name = "cogDisplayStatusBarV21";
            this.cogDisplayStatusBarV21.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cogDisplayStatusBarV21.Size = new System.Drawing.Size(800, 27);
            this.cogDisplayStatusBarV21.TabIndex = 2;
            this.cogDisplayStatusBarV21.Use3DCoordinateSpaceTree = false;
            // 
            // cogDisplayToolbarV21
            // 
            this.cogDisplayToolbarV21.Location = new System.Drawing.Point(4, 4);
            this.cogDisplayToolbarV21.Margin = new System.Windows.Forms.Padding(4);
            this.cogDisplayToolbarV21.Name = "cogDisplayToolbarV21";
            this.cogDisplayToolbarV21.Size = new System.Drawing.Size(285, 32);
            this.cogDisplayToolbarV21.TabIndex = 3;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnLoad,
            this.BtnRect,
            this.BtnAnnotation,
            this.BtnPoint,
            this.BtnLine,
            this.btnArrow,
            this.btnDraw,
            this.btnDistance});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(87, 228);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Image = ((System.Drawing.Image)(resources.GetObject("BtnLoad.Image")));
            this.BtnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(85, 24);
            this.BtnLoad.Text = "LOAD";
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnRect
            // 
            this.BtnRect.Image = ((System.Drawing.Image)(resources.GetObject("BtnRect.Image")));
            this.BtnRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRect.Name = "BtnRect";
            this.BtnRect.Size = new System.Drawing.Size(85, 24);
            this.BtnRect.Text = "RECT";
            this.BtnRect.Click += new System.EventHandler(this.BtnRect_Click);
            // 
            // BtnAnnotation
            // 
            this.BtnAnnotation.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnotation.Image")));
            this.BtnAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAnnotation.Name = "BtnAnnotation";
            this.BtnAnnotation.Size = new System.Drawing.Size(85, 24);
            this.BtnAnnotation.Text = "TEXT";
            this.BtnAnnotation.ToolTipText = "TEXT";
            this.BtnAnnotation.Click += new System.EventHandler(this.BtnAnnotation_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPoint.Image")));
            this.BtnPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(85, 24);
            this.BtnPoint.Text = "POINT";
            this.BtnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.Image = ((System.Drawing.Image)(resources.GetObject("BtnLine.Image")));
            this.BtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(85, 24);
            this.BtnLine.Text = "LINE";
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // btnArrow
            // 
            this.btnArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnArrow.Image")));
            this.btnArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(85, 24);
            this.btnArrow.Text = "ARROW";
            this.btnArrow.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Image = ((System.Drawing.Image)(resources.GetObject("btnDraw.Image")));
            this.btnDraw.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(85, 24);
            this.btnDraw.Text = "DRAW";
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // btnDistance
            // 
            this.btnDistance.Image = ((System.Drawing.Image)(resources.GetObject("btnDistance.Image")));
            this.btnDistance.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDistance.Name = "btnDistance";
            this.btnDistance.Size = new System.Drawing.Size(85, 24);
            this.btnDistance.Text = "DIST";
            this.btnDistance.Click += new System.EventHandler(this.btnDistance_Click);
            // 
            // OpenImgDialog
            // 
            this.OpenImgDialog.Filter = "Bitmap|*.bmp|All files (*.*)|*.*";
            // 
            // SaveImageDialog
            // 
            this.SaveImageDialog.Filter = "Bitmap|*.bmp|All files (*.*)|*.*";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cogDisplay1);
            this.panel1.Controls.Add(this.cogDisplayToolbarV21);
            this.panel1.Location = new System.Drawing.Point(100, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 666);
            this.panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1084, 15);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(696, 690);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dGVDefectList);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(688, 661);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Defect List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dGVDefectList
            // 
            this.dGVDefectList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVDefectList.Location = new System.Drawing.Point(8, 12);
            this.dGVDefectList.Margin = new System.Windows.Forms.Padding(4);
            this.dGVDefectList.Name = "dGVDefectList";
            this.dGVDefectList.RowHeadersWidth = 51;
            this.dGVDefectList.Size = new System.Drawing.Size(669, 639);
            this.dGVDefectList.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(688, 661);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "XY List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(688, 661);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "General Notation";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // RBtnScratch
            // 
            this.RBtnScratch.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtnScratch.Checked = true;
            this.RBtnScratch.Location = new System.Drawing.Point(20, 21);
            this.RBtnScratch.Name = "RBtnScratch";
            this.RBtnScratch.Size = new System.Drawing.Size(124, 38);
            this.RBtnScratch.TabIndex = 9;
            this.RBtnScratch.TabStop = true;
            this.RBtnScratch.Tag = "Scratch";
            this.RBtnScratch.Text = "SCRATCH";
            this.RBtnScratch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBtnScratch.UseVisualStyleBackColor = true;
            this.RBtnScratch.CheckedChanged += new System.EventHandler(this.RBDefect_CheckedChanged);
            // 
            // RBtnCrack
            // 
            this.RBtnCrack.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtnCrack.Location = new System.Drawing.Point(20, 65);
            this.RBtnCrack.Name = "RBtnCrack";
            this.RBtnCrack.Size = new System.Drawing.Size(124, 38);
            this.RBtnCrack.TabIndex = 10;
            this.RBtnCrack.Tag = "Crack";
            this.RBtnCrack.Text = "CRACK";
            this.RBtnCrack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RBtnCrack.UseVisualStyleBackColor = true;
            this.RBtnCrack.CheckedChanged += new System.EventHandler(this.RBDefect_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RBtnScratch);
            this.groupBox1.Controls.Add(this.RBtnCrack);
            this.groupBox1.Location = new System.Drawing.Point(916, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 151);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(962, 247);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(80, 30);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(967, 377);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(967, 406);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(920, 554);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // UpDownLineWidth
            // 
            this.UpDownLineWidth.Location = new System.Drawing.Point(1026, 210);
            this.UpDownLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownLineWidth.Name = "UpDownLineWidth";
            this.UpDownLineWidth.Size = new System.Drawing.Size(51, 22);
            this.UpDownLineWidth.TabIndex = 16;
            this.UpDownLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UpDownLineWidth.ValueChanged += new System.EventHandler(this.UpDownLineWidth_ValueChanged);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(1006, 554);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(75, 23);
            this.btnTest2.TabIndex = 17;
            this.btnTest2.Text = "Test 2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // btnTest3
            // 
            this.btnTest3.Location = new System.Drawing.Point(967, 586);
            this.btnTest3.Name = "btnTest3";
            this.btnTest3.Size = new System.Drawing.Size(75, 23);
            this.btnTest3.TabIndex = 18;
            this.btnTest3.Text = "Test 3";
            this.btnTest3.UseVisualStyleBackColor = true;
            this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // numericUpDownTest
            // 
            this.numericUpDownTest.DecimalPlaces = 2;
            this.numericUpDownTest.Location = new System.Drawing.Point(940, 526);
            this.numericUpDownTest.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownTest.Name = "numericUpDownTest";
            this.numericUpDownTest.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTest.TabIndex = 19;
            this.numericUpDownTest.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(933, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Shape Width:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(946, 452);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 23);
            this.btnClear.TabIndex = 21;
            this.btnClear.Text = "Clear Graphics";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTrash);
            this.groupBox2.Controls.Add(this.RBtn2CircleLength);
            this.groupBox2.Controls.Add(this.RBtnPerpLength);
            this.groupBox2.Controls.Add(this.RBtn2LineAngle);
            this.groupBox2.Controls.Add(this.RBtnSingleRadius);
            this.groupBox2.Controls.Add(this.RBtnTrigAngle);
            this.groupBox2.Controls.Add(this.RBtnMultiPointsLength);
            this.groupBox2.Controls.Add(this.RBtnNone);
            this.groupBox2.Controls.Add(this.RBtn2Points);
            this.groupBox2.Location = new System.Drawing.Point(0, 247);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(96, 253);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tools";
            // 
            // btnTrash
            // 
            this.btnTrash.BackgroundImage = global::CogDrawTool.Properties.Resources.trashCan;
            this.btnTrash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTrash.Location = new System.Drawing.Point(27, 205);
            this.btnTrash.Name = "btnTrash";
            this.btnTrash.Size = new System.Drawing.Size(40, 40);
            this.btnTrash.TabIndex = 8;
            this.btnTrash.UseVisualStyleBackColor = true;
            this.btnTrash.Click += new System.EventHandler(this.btnTrash_Click);
            // 
            // RBtn2CircleLength
            // 
            this.RBtn2CircleLength.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtn2CircleLength.BackgroundImage = global::CogDrawTool.Properties.Resources.doubleCircleMidLength;
            this.RBtn2CircleLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RBtn2CircleLength.Location = new System.Drawing.Point(6, 159);
            this.RBtn2CircleLength.Name = "RBtn2CircleLength";
            this.RBtn2CircleLength.Size = new System.Drawing.Size(40, 40);
            this.RBtn2CircleLength.TabIndex = 7;
            this.RBtn2CircleLength.TabStop = true;
            this.RBtn2CircleLength.Tag = "4";
            this.RBtn2CircleLength.UseVisualStyleBackColor = true;
            this.RBtn2CircleLength.CheckedChanged += new System.EventHandler(this.MultiToolRBtn_CheckedChanged);
            // 
            // RBtnPerpLength
            // 
            this.RBtnPerpLength.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtnPerpLength.BackgroundImage = global::CogDrawTool.Properties.Resources.perpendicularLength;
            this.RBtnPerpLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RBtnPerpLength.Location = new System.Drawing.Point(52, 113);
            this.RBtnPerpLength.Name = "RBtnPerpLength";
            this.RBtnPerpLength.Size = new System.Drawing.Size(40, 40);
            this.RBtnPerpLength.TabIndex = 6;
            this.RBtnPerpLength.TabStop = true;
            this.RBtnPerpLength.Tag = "3";
            this.RBtnPerpLength.UseVisualStyleBackColor = true;
            this.RBtnPerpLength.CheckedChanged += new System.EventHandler(this.MultiToolRBtn_CheckedChanged);
            // 
            // RBtn2LineAngle
            // 
            this.RBtn2LineAngle.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtn2LineAngle.BackgroundImage = global::CogDrawTool.Properties.Resources.angle2;
            this.RBtn2LineAngle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RBtn2LineAngle.Location = new System.Drawing.Point(6, 113);
            this.RBtn2LineAngle.Name = "RBtn2LineAngle";
            this.RBtn2LineAngle.Size = new System.Drawing.Size(40, 40);
            this.RBtn2LineAngle.TabIndex = 5;
            this.RBtn2LineAngle.TabStop = true;
            this.RBtn2LineAngle.Tag = "4";
            this.RBtn2LineAngle.UseVisualStyleBackColor = true;
            this.RBtn2LineAngle.CheckedChanged += new System.EventHandler(this.MultiToolRBtn_CheckedChanged);
            // 
            // RBtnSingleRadius
            // 
            this.RBtnSingleRadius.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtnSingleRadius.BackgroundImage = global::CogDrawTool.Properties.Resources.singleRadius;
            this.RBtnSingleRadius.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RBtnSingleRadius.Location = new System.Drawing.Point(6, 67);
            this.RBtnSingleRadius.Name = "RBtnSingleRadius";
            this.RBtnSingleRadius.Size = new System.Drawing.Size(40, 40);
            this.RBtnSingleRadius.TabIndex = 4;
            this.RBtnSingleRadius.TabStop = true;
            this.RBtnSingleRadius.Tag = "2";
            this.RBtnSingleRadius.UseVisualStyleBackColor = true;
            this.RBtnSingleRadius.CheckedChanged += new System.EventHandler(this.MultiToolRBtn_CheckedChanged);
            // 
            // RBtnTrigAngle
            // 
            this.RBtnTrigAngle.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtnTrigAngle.BackgroundImage = global::CogDrawTool.Properties.Resources.angle1;
            this.RBtnTrigAngle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RBtnTrigAngle.Location = new System.Drawing.Point(52, 67);
            this.RBtnTrigAngle.Name = "RBtnTrigAngle";
            this.RBtnTrigAngle.Size = new System.Drawing.Size(40, 40);
            this.RBtnTrigAngle.TabIndex = 3;
            this.RBtnTrigAngle.TabStop = true;
            this.RBtnTrigAngle.Tag = "3";
            this.RBtnTrigAngle.UseVisualStyleBackColor = true;
            this.RBtnTrigAngle.CheckedChanged += new System.EventHandler(this.MultiToolRBtn_CheckedChanged);
            // 
            // RBtnMultiPointsLength
            // 
            this.RBtnMultiPointsLength.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtnMultiPointsLength.BackgroundImage = global::CogDrawTool.Properties.Resources.multiPointsLength;
            this.RBtnMultiPointsLength.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RBtnMultiPointsLength.Location = new System.Drawing.Point(52, 21);
            this.RBtnMultiPointsLength.Name = "RBtnMultiPointsLength";
            this.RBtnMultiPointsLength.Size = new System.Drawing.Size(40, 40);
            this.RBtnMultiPointsLength.TabIndex = 2;
            this.RBtnMultiPointsLength.TabStop = true;
            this.RBtnMultiPointsLength.Tag = "9999";
            this.RBtnMultiPointsLength.UseVisualStyleBackColor = true;
            this.RBtnMultiPointsLength.CheckedChanged += new System.EventHandler(this.MultiToolRBtn_CheckedChanged);
            this.RBtnMultiPointsLength.Click += new System.EventHandler(this.RBtnMultiPointsLength_Click);
            // 
            // RBtnNone
            // 
            this.RBtnNone.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtnNone.BackgroundImage = global::CogDrawTool.Properties.Resources.none;
            this.RBtnNone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RBtnNone.Location = new System.Drawing.Point(52, 159);
            this.RBtnNone.Name = "RBtnNone";
            this.RBtnNone.Size = new System.Drawing.Size(40, 40);
            this.RBtnNone.TabIndex = 1;
            this.RBtnNone.TabStop = true;
            this.RBtnNone.Tag = "0";
            this.RBtnNone.UseVisualStyleBackColor = true;
            this.RBtnNone.CheckedChanged += new System.EventHandler(this.MultiToolRBtn_CheckedChanged);
            // 
            // RBtn2Points
            // 
            this.RBtn2Points.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtn2Points.BackgroundImage = global::CogDrawTool.Properties.Resources._2points;
            this.RBtn2Points.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RBtn2Points.Location = new System.Drawing.Point(6, 21);
            this.RBtn2Points.Name = "RBtn2Points";
            this.RBtn2Points.Size = new System.Drawing.Size(40, 40);
            this.RBtn2Points.TabIndex = 0;
            this.RBtn2Points.TabStop = true;
            this.RBtn2Points.Tag = "2";
            this.RBtn2Points.UseVisualStyleBackColor = true;
            this.RBtn2Points.CheckedChanged += new System.EventHandler(this.MultiToolRBtn_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnColor);
            this.groupBox3.Controls.Add(this.pictureBox13);
            this.groupBox3.Controls.Add(this.pictureBox12);
            this.groupBox3.Controls.Add(this.RBtnDotColor);
            this.groupBox3.Controls.Add(this.pictureBox10);
            this.groupBox3.Controls.Add(this.pictureBox9);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.RBtnLineColor);
            this.groupBox3.Controls.Add(this.pictureBox8);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.PBRed);
            this.groupBox3.Controls.Add(this.pictureBox5);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Controls.Add(this.pictureBox6);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Controls.Add(this.pictureBox7);
            this.groupBox3.Location = new System.Drawing.Point(0, 506);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(96, 260);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Colors";
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Purple;
            this.pictureBox13.Location = new System.Drawing.Point(68, 129);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(25, 25);
            this.pictureBox13.TabIndex = 25;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.DarkGreen;
            this.pictureBox12.Location = new System.Drawing.Point(6, 191);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(25, 25);
            this.pictureBox12.TabIndex = 24;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // RBtnDotColor
            // 
            this.RBtnDotColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtnDotColor.BackColor = System.Drawing.Color.Red;
            this.RBtnDotColor.Location = new System.Drawing.Point(55, 54);
            this.RBtnDotColor.Name = "RBtnDotColor";
            this.RBtnDotColor.Size = new System.Drawing.Size(35, 35);
            this.RBtnDotColor.TabIndex = 12;
            this.RBtnDotColor.TabStop = true;
            this.RBtnDotColor.UseVisualStyleBackColor = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox10.Location = new System.Drawing.Point(36, 191);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(25, 25);
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.DarkGray;
            this.pictureBox9.Location = new System.Drawing.Point(68, 193);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(25, 25);
            this.pictureBox9.TabIndex = 13;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Dot:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Line:";
            // 
            // RBtnLineColor
            // 
            this.RBtnLineColor.Appearance = System.Windows.Forms.Appearance.Button;
            this.RBtnLineColor.BackColor = System.Drawing.Color.Blue;
            this.RBtnLineColor.Location = new System.Drawing.Point(55, 13);
            this.RBtnLineColor.Name = "RBtnLineColor";
            this.RBtnLineColor.Size = new System.Drawing.Size(35, 35);
            this.RBtnLineColor.TabIndex = 9;
            this.RBtnLineColor.TabStop = true;
            this.RBtnLineColor.UseVisualStyleBackColor = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Orange;
            this.pictureBox8.Location = new System.Drawing.Point(37, 98);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(25, 25);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Magenta;
            this.pictureBox2.Location = new System.Drawing.Point(37, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // PBRed
            // 
            this.PBRed.BackColor = System.Drawing.Color.Red;
            this.PBRed.Location = new System.Drawing.Point(6, 129);
            this.PBRed.Name = "PBRed";
            this.PBRed.Size = new System.Drawing.Size(25, 25);
            this.PBRed.TabIndex = 0;
            this.PBRed.TabStop = false;
            this.PBRed.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Black;
            this.pictureBox5.Location = new System.Drawing.Point(6, 222);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 25);
            this.pictureBox5.TabIndex = 5;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(6, 98);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(68, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Cyan;
            this.pictureBox6.Location = new System.Drawing.Point(37, 160);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Blue;
            this.pictureBox3.Location = new System.Drawing.Point(6, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Green;
            this.pictureBox7.Location = new System.Drawing.Point(68, 160);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(25, 25);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.PBColor_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(958, 338);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(91, 23);
            this.btnSelectPath.TabIndex = 24;
            this.btnSelectPath.Text = "Select Path";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // TBFileName
            // 
            this.TBFileName.Location = new System.Drawing.Point(989, 307);
            this.TBFileName.Name = "TBFileName";
            this.TBFileName.Size = new System.Drawing.Size(92, 22);
            this.TBFileName.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(916, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "File name:";
            // 
            // btnColor
            // 
            this.btnColor.Location = new System.Drawing.Point(37, 224);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(56, 23);
            this.btnColor.TabIndex = 27;
            this.btnColor.Text = "More";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // colorDialog1
            // 
            this.colorDialog1.SolidColorOnly = true;
            // 
            // DrawToolFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 769);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TBFileName);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cogDisplayStatusBarV21);
            this.Controls.Add(this.numericUpDownTest);
            this.Controls.Add(this.btnTest3);
            this.Controls.Add(this.btnTest2);
            this.Controls.Add(this.UpDownLineWidth);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DrawToolFrm";
            this.Text = "Draw Tool ";
            this.Load += new System.EventHandler(this.DrawToolFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGVDefectList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownLineWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTest)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Cognex.VisionPro.Display.CogDisplay cogDisplay1;
        private Cognex.VisionPro.CogDisplayStatusBarV2 cogDisplayStatusBarV21;
        private Cognex.VisionPro.CogDisplayToolbarV2 cogDisplayToolbarV21;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BtnLoad;
        private System.Windows.Forms.OpenFileDialog OpenImgDialog;
        private System.Windows.Forms.SaveFileDialog SaveImageDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton BtnRect;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dGVDefectList;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ToolStripButton BtnAnnotation;
        private System.Windows.Forms.RadioButton RBtnScratch;
        private System.Windows.Forms.RadioButton RBtnCrack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripButton BtnPoint;
        private System.Windows.Forms.ToolStripButton BtnLine;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.NumericUpDown UpDownLineWidth;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnTest2;
        private System.Windows.Forms.Button btnTest3;
        private System.Windows.Forms.ToolStripButton btnArrow;
        private System.Windows.Forms.NumericUpDown numericUpDownTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton btnDraw;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ToolStripButton btnDistance;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton RBtnNone;
        private System.Windows.Forms.RadioButton RBtn2Points;
        private System.Windows.Forms.RadioButton RBtnMultiPointsLength;
        private System.Windows.Forms.RadioButton RBtnTrigAngle;
        private System.Windows.Forms.RadioButton RBtnSingleRadius;
        private System.Windows.Forms.RadioButton RBtn2CircleLength;
        private System.Windows.Forms.RadioButton RBtnPerpLength;
        private System.Windows.Forms.RadioButton RBtn2LineAngle;
        private System.Windows.Forms.Button btnTrash;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox PBRed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.RadioButton RBtnLineColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton RBtnDotColor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.TextBox TBFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

