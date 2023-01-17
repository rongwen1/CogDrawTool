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
            this.btnArrow = new System.Windows.Forms.ToolStripButton();
            this.numericUpDownTest = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGVDefectList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownLineWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTest)).BeginInit();
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
            this.cogDisplay1.Size = new System.Drawing.Size(746, 626);
            this.cogDisplay1.TabIndex = 1;
            this.cogDisplay1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cogDisplay1_MouseDown);
            this.cogDisplay1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cogDisplay1_MouseMove);
            // 
            // cogDisplayStatusBarV21
            // 
            this.cogDisplayStatusBarV21.CoordinateSpaceName = "*\\#";
            this.cogDisplayStatusBarV21.CoordinateSpaceName3D = "*\\#";
            this.cogDisplayStatusBarV21.Location = new System.Drawing.Point(0, 667);
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
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnLoad,
            this.BtnRect,
            this.BtnAnnotation,
            this.BtnPoint,
            this.BtnLine,
            this.btnArrow});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(76, 736);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Image = ((System.Drawing.Image)(resources.GetObject("BtnLoad.Image")));
            this.BtnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(73, 24);
            this.BtnLoad.Text = "LOAD";
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // BtnRect
            // 
            this.BtnRect.Image = ((System.Drawing.Image)(resources.GetObject("BtnRect.Image")));
            this.BtnRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnRect.Name = "BtnRect";
            this.BtnRect.Size = new System.Drawing.Size(73, 24);
            this.BtnRect.Text = "RECT";
            this.BtnRect.Click += new System.EventHandler(this.BtnRect_Click);
            // 
            // BtnAnnotation
            // 
            this.BtnAnnotation.Image = ((System.Drawing.Image)(resources.GetObject("BtnAnnotation.Image")));
            this.BtnAnnotation.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnAnnotation.Name = "BtnAnnotation";
            this.BtnAnnotation.Size = new System.Drawing.Size(73, 24);
            this.BtnAnnotation.Text = "TEXT";
            this.BtnAnnotation.ToolTipText = "TEXT";
            this.BtnAnnotation.Click += new System.EventHandler(this.BtnAnnotation_Click);
            // 
            // BtnPoint
            // 
            this.BtnPoint.Image = ((System.Drawing.Image)(resources.GetObject("BtnPoint.Image")));
            this.BtnPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnPoint.Name = "BtnPoint";
            this.BtnPoint.Size = new System.Drawing.Size(73, 24);
            this.BtnPoint.Text = "POINT";
            this.BtnPoint.Click += new System.EventHandler(this.BtnPoint_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.Image = ((System.Drawing.Image)(resources.GetObject("BtnLine.Image")));
            this.BtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(73, 24);
            this.BtnLine.Text = "LINE";
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
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
            this.panel1.Controls.Add(this.cogDisplayStatusBarV21);
            this.panel1.Location = new System.Drawing.Point(83, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 704);
            this.panel1.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1067, 18);
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
            this.groupBox1.Location = new System.Drawing.Point(899, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(165, 151);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(946, 400);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(946, 429);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(75, 23);
            this.btnExport.TabIndex = 13;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(946, 458);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 14;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(899, 317);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(75, 23);
            this.btnTest.TabIndex = 15;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // UpDownLineWidth
            // 
            this.UpDownLineWidth.Location = new System.Drawing.Point(957, 234);
            this.UpDownLineWidth.Name = "UpDownLineWidth";
            this.UpDownLineWidth.Size = new System.Drawing.Size(51, 22);
            this.UpDownLineWidth.TabIndex = 16;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnTest2
            // 
            this.btnTest2.Location = new System.Drawing.Point(985, 317);
            this.btnTest2.Name = "btnTest2";
            this.btnTest2.Size = new System.Drawing.Size(75, 23);
            this.btnTest2.TabIndex = 17;
            this.btnTest2.Text = "Test 2";
            this.btnTest2.UseVisualStyleBackColor = true;
            this.btnTest2.Click += new System.EventHandler(this.btnTest2_Click);
            // 
            // btnTest3
            // 
            this.btnTest3.Location = new System.Drawing.Point(946, 346);
            this.btnTest3.Name = "btnTest3";
            this.btnTest3.Size = new System.Drawing.Size(75, 23);
            this.btnTest3.TabIndex = 18;
            this.btnTest3.Text = "Test 3";
            this.btnTest3.UseVisualStyleBackColor = true;
            this.btnTest3.Click += new System.EventHandler(this.btnTest3_Click);
            // 
            // btnArrow
            // 
            this.btnArrow.Image = ((System.Drawing.Image)(resources.GetObject("btnArrow.Image")));
            this.btnArrow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnArrow.Name = "btnArrow";
            this.btnArrow.Size = new System.Drawing.Size(73, 24);
            this.btnArrow.Text = "Arrow";
            this.btnArrow.Click += new System.EventHandler(this.btnArrow_Click);
            // 
            // numericUpDownTest
            // 
            this.numericUpDownTest.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownTest.Location = new System.Drawing.Point(919, 289);
            this.numericUpDownTest.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTest.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            -2147483648});
            this.numericUpDownTest.Name = "numericUpDownTest";
            this.numericUpDownTest.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownTest.TabIndex = 19;
            // 
            // DrawToolFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 736);
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
    }
}

