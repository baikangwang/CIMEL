﻿namespace CIMEL.Chart
{
    partial class fmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cimelDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.cmbDataSets = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbModes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnNextChart = new System.Windows.Forms.Button();
            this.btnNextChartSet = new System.Windows.Forms.Button();
            this.btnNextState = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRegions = new System.Windows.Forms.ComboBox();
            this.btnScan = new System.Windows.Forms.Button();
            this.cmbCharts = new System.Windows.Forms.ComboBox();
            this.chartPanel1 = new CIMEL.Chart.ChartPanel();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = global::CIMEL.Chart.Properties.Settings.Default.DEFAULT_FONT;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(686, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(58, 21);
            this.fileToolStripMenuItem.Text = global::CIMEL.Chart.Properties.Settings.Default.BTN_FILE_TEXT;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.exitToolStripMenuItem.Text = global::CIMEL.Chart.Properties.Settings.Default.BTN_EXIT_TEXT;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cimelDataToolStripMenuItem,
            this.toolStripSeparator1,
            this.optionsToolStripMenuItem,
            this.regionsToolStripMenuItem});
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(59, 21);
            this.toolToolStripMenuItem.Text = global::CIMEL.Chart.Properties.Settings.Default.BTN_TOOLS_TEXT;
            // 
            // cimelDataToolStripMenuItem
            // 
            this.cimelDataToolStripMenuItem.Name = "cimelDataToolStripMenuItem";
            this.cimelDataToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cimelDataToolStripMenuItem.Text = global::CIMEL.Chart.Properties.Settings.Default.BTN_DATA_PRO_TEXT;
            this.cimelDataToolStripMenuItem.Click += new System.EventHandler(this.cimelDataToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.optionsToolStripMenuItem.Text = global::CIMEL.Chart.Properties.Settings.Default.BTN_OPTIONS_TEXT;
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // regionsToolStripMenuItem
            // 
            this.regionsToolStripMenuItem.Name = "regionsToolStripMenuItem";
            this.regionsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.regionsToolStripMenuItem.Text = global::CIMEL.Chart.Properties.Settings.Default.BTN_REGIONS_TEXT;
            this.regionsToolStripMenuItem.Click += new System.EventHandler(this.regionsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerStripMenuItem,
            this.toolStripSeparator2,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 21);
            this.helpToolStripMenuItem.Text = global::CIMEL.Chart.Properties.Settings.Default.BTN_HELP_TEXT;
            // 
            // registerStripMenuItem
            // 
            this.registerStripMenuItem.Name = "registerStripMenuItem";
            this.registerStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.registerStripMenuItem.Text = "注册(&R)...";
            this.registerStripMenuItem.Click += new System.EventHandler(this.registerStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(122, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.aboutToolStripMenuItem.Text = global::CIMEL.Chart.Properties.Settings.Default.BTN_ABOUT_TEXT;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = global::CIMEL.Chart.Properties.Settings.Default.DEFAULT_FONT;
            this.statusStrip1.Location = new System.Drawing.Point(0, 671);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.statusStrip1.Size = new System.Drawing.Size(686, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // cmbDataSets
            // 
            this.cmbDataSets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDataSets.FormattingEnabled = true;
            this.cmbDataSets.Location = new System.Drawing.Point(80, 61);
            this.cmbDataSets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbDataSets.Name = "cmbDataSets";
            this.cmbDataSets.Size = new System.Drawing.Size(358, 25);
            this.cmbDataSets.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "数据集:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "图像类别:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cmbModes);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnNextChart);
            this.groupBox1.Controls.Add(this.btnNextChartSet);
            this.groupBox1.Controls.Add(this.btnNextState);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbRegions);
            this.groupBox1.Controls.Add(this.btnScan);
            this.groupBox1.Controls.Add(this.cmbCharts);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cmbDataSets);
            this.groupBox1.Location = new System.Drawing.Point(15, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(659, 135);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图像数据集";
            // 
            // cmbModes
            // 
            this.cmbModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModes.FormattingEnabled = true;
            this.cmbModes.Items.AddRange(new object[] {
            "2D - 线图",
            "3D - 线图",
            "3D - 面图"});
            this.cmbModes.Location = new System.Drawing.Point(399, 99);
            this.cmbModes.Name = "cmbModes";
            this.cmbModes.Size = new System.Drawing.Size(81, 25);
            this.cmbModes.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(399, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 25);
            this.button1.TabIndex = 12;
            this.button1.Text = "刷新(&R)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btRefresh_Click);
            // 
            // btnNextChart
            // 
            this.btnNextChart.BackColor = System.Drawing.Color.White;
            this.btnNextChart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextChart.Image = ((System.Drawing.Image)(resources.GetObject("btnNextChart.Image")));
            this.btnNextChart.Location = new System.Drawing.Point(365, 98);
            this.btnNextChart.Name = "btnNextChart";
            this.btnNextChart.Size = new System.Drawing.Size(28, 25);
            this.btnNextChart.TabIndex = 11;
            this.btnNextChart.UseVisualStyleBackColor = false;
            this.btnNextChart.Click += new System.EventHandler(this.btnNextChart_Click);
            // 
            // btnNextChartSet
            // 
            this.btnNextChartSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNextChartSet.BackColor = System.Drawing.Color.White;
            this.btnNextChartSet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextChartSet.Image = ((System.Drawing.Image)(resources.GetObject("btnNextChartSet.Image")));
            this.btnNextChartSet.Location = new System.Drawing.Point(444, 61);
            this.btnNextChartSet.Name = "btnNextChartSet";
            this.btnNextChartSet.Size = new System.Drawing.Size(28, 25);
            this.btnNextChartSet.TabIndex = 10;
            this.btnNextChartSet.UseVisualStyleBackColor = false;
            this.btnNextChartSet.Click += new System.EventHandler(this.btnNextDataSet_Click);
            // 
            // btnNextState
            // 
            this.btnNextState.BackColor = System.Drawing.Color.White;
            this.btnNextState.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNextState.Image = ((System.Drawing.Image)(resources.GetObject("btnNextState.Image")));
            this.btnNextState.Location = new System.Drawing.Point(365, 23);
            this.btnNextState.Name = "btnNextState";
            this.btnNextState.Size = new System.Drawing.Size(28, 25);
            this.btnNextState.TabIndex = 9;
            this.btnNextState.UseVisualStyleBackColor = false;
            this.btnNextState.Click += new System.EventHandler(this.btnNextRegion_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(546, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "站点:";
            // 
            // cmbRegions
            // 
            this.cmbRegions.FormattingEnabled = true;
            this.cmbRegions.Location = new System.Drawing.Point(80, 22);
            this.cmbRegions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbRegions.Name = "cmbRegions";
            this.cmbRegions.Size = new System.Drawing.Size(279, 25);
            this.cmbRegions.TabIndex = 7;
            // 
            // btnScan
            // 
            this.btnScan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScan.Location = new System.Drawing.Point(478, 61);
            this.btnScan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(62, 25);
            this.btnScan.TabIndex = 6;
            this.btnScan.Text = global::CIMEL.Chart.Properties.Settings.Default.BTN_SCAN_TEXT;
            this.btnScan.UseVisualStyleBackColor = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // cmbCharts
            // 
            this.cmbCharts.FormattingEnabled = true;
            this.cmbCharts.Location = new System.Drawing.Point(80, 98);
            this.cmbCharts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCharts.Name = "cmbCharts";
            this.cmbCharts.Size = new System.Drawing.Size(279, 25);
            this.cmbCharts.TabIndex = 5;
            // 
            // chartPanel1
            // 
            this.chartPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartPanel1.Font = global::CIMEL.Chart.Properties.Settings.Default.DEFAULT_FONT;
            this.chartPanel1.Location = new System.Drawing.Point(15, 180);
            this.chartPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chartPanel1.Name = "chartPanel1";
            this.chartPanel1.Size = new System.Drawing.Size(658, 481);
            this.chartPanel1.TabIndex = 6;
            // 
            // fmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 693);
            this.Controls.Add(this.chartPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = global::CIMEL.Chart.Properties.Settings.Default.DEFAULT_FONT;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(702, 732);
            this.Name = "fmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "大气气溶胶光学参数处理软件（适用于CIMEL太阳光度计数据处理）";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cimelDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox cmbDataSets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbCharts;
        private ChartPanel chartPanel1;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRegions;
        private System.Windows.Forms.ToolStripMenuItem regionsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnNextChart;
        private System.Windows.Forms.Button btnNextChartSet;
        private System.Windows.Forms.Button btnNextState;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem registerStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ComboBox cmbModes;
    }
}

