﻿namespace testi2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonCurrentTime = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMain = new System.Windows.Forms.TabPage();
            this.tableLayoutPanelMainView = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxMoon = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanelClock = new System.Windows.Forms.TableLayoutPanel();
            this.labelClock = new System.Windows.Forms.Label();
            this.labelLatestTemperature = new System.Windows.Forms.Label();
            this.labelLatestHumidity = new System.Windows.Forms.Label();
            this.pictureBoxWeather = new System.Windows.Forms.PictureBox();
            this.tabPageInfo = new System.Windows.Forms.TabPage();
            this.dataGridViewInfo = new System.Windows.Forms.DataGridView();
            this.tabPageAdmin = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonClearDatabase = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.button8HoursAgo = new System.Windows.Forms.Button();
            this.buttonLastHour = new System.Windows.Forms.Button();
            this.button2HoursAgo = new System.Windows.Forms.Button();
            this.button3HoursAgo = new System.Windows.Forms.Button();
            this.button4HoursAgo = new System.Windows.Forms.Button();
            this.button5HoursAgo = new System.Windows.Forms.Button();
            this.button6HoursAgo = new System.Windows.Forms.Button();
            this.button7HoursAgo = new System.Windows.Forms.Button();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateMainview = new System.Windows.Forms.Timer(this.components);
            this.timerUpdateBackground = new System.Windows.Forms.Timer(this.components);
            this.timerColorAnimation = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMain.SuspendLayout();
            this.tableLayoutPanelMainView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).BeginInit();
            this.tableLayoutPanelClock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).BeginInit();
            this.tabPageInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).BeginInit();
            this.tabPageAdmin.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.17046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.82953F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.buttonCurrentTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.01124F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.988764F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(633, 382);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // buttonCurrentTime
            // 
            this.buttonCurrentTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCurrentTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCurrentTime.Location = new System.Drawing.Point(529, 350);
            this.buttonCurrentTime.Name = "buttonCurrentTime";
            this.buttonCurrentTime.Size = new System.Drawing.Size(101, 29);
            this.buttonCurrentTime.TabIndex = 8;
            this.buttonCurrentTime.Text = "Now";
            this.buttonCurrentTime.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMain);
            this.tabControl1.Controls.Add(this.tabPageInfo);
            this.tabControl1.Controls.Add(this.tabPageAdmin);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(520, 341);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControl1.TabIndex = 4;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPageMain
            // 
            this.tabPageMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageMain.Controls.Add(this.tableLayoutPanelMainView);
            this.tabPageMain.Location = new System.Drawing.Point(4, 22);
            this.tabPageMain.Name = "tabPageMain";
            this.tabPageMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMain.Size = new System.Drawing.Size(512, 315);
            this.tabPageMain.TabIndex = 0;
            this.tabPageMain.Text = "Main";
            this.tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelMainView
            // 
            this.tableLayoutPanelMainView.ColumnCount = 3;
            this.tableLayoutPanelMainView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMainView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMainView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelMainView.Controls.Add(this.pictureBoxMoon, 0, 2);
            this.tableLayoutPanelMainView.Controls.Add(this.tableLayoutPanelClock, 1, 2);
            this.tableLayoutPanelMainView.Controls.Add(this.labelLatestTemperature, 2, 3);
            this.tableLayoutPanelMainView.Controls.Add(this.labelLatestHumidity, 0, 3);
            this.tableLayoutPanelMainView.Controls.Add(this.pictureBoxWeather, 2, 2);
            this.tableLayoutPanelMainView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMainView.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMainView.Name = "tableLayoutPanelMainView";
            this.tableLayoutPanelMainView.RowCount = 4;
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelMainView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelMainView.Size = new System.Drawing.Size(506, 309);
            this.tableLayoutPanelMainView.TabIndex = 1;
            // 
            // pictureBoxMoon
            // 
            this.pictureBoxMoon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxMoon.Location = new System.Drawing.Point(3, 187);
            this.pictureBoxMoon.Name = "pictureBoxMoon";
            this.pictureBoxMoon.Size = new System.Drawing.Size(162, 86);
            this.pictureBoxMoon.TabIndex = 1;
            this.pictureBoxMoon.TabStop = false;
            // 
            // tableLayoutPanelClock
            // 
            this.tableLayoutPanelClock.ColumnCount = 3;
            this.tableLayoutPanelClock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelClock.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.Controls.Add(this.labelClock, 1, 1);
            this.tableLayoutPanelClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelClock.Location = new System.Drawing.Point(171, 187);
            this.tableLayoutPanelClock.Name = "tableLayoutPanelClock";
            this.tableLayoutPanelClock.RowCount = 3;
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanelClock.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanelClock.Size = new System.Drawing.Size(162, 86);
            this.tableLayoutPanelClock.TabIndex = 3;
            // 
            // labelClock
            // 
            this.labelClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClock.Location = new System.Drawing.Point(19, 8);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(123, 68);
            this.labelClock.TabIndex = 2;
            this.labelClock.Text = "00 : 00";
            this.labelClock.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelLatestTemperature
            // 
            this.labelLatestTemperature.AutoSize = true;
            this.labelLatestTemperature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLatestTemperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestTemperature.Location = new System.Drawing.Point(339, 276);
            this.labelLatestTemperature.Name = "labelLatestTemperature";
            this.labelLatestTemperature.Size = new System.Drawing.Size(164, 33);
            this.labelLatestTemperature.TabIndex = 4;
            this.labelLatestTemperature.Text = "Temperature";
            this.labelLatestTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLatestHumidity
            // 
            this.labelLatestHumidity.AutoSize = true;
            this.labelLatestHumidity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelLatestHumidity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLatestHumidity.Location = new System.Drawing.Point(3, 276);
            this.labelLatestHumidity.Name = "labelLatestHumidity";
            this.labelLatestHumidity.Size = new System.Drawing.Size(162, 33);
            this.labelLatestHumidity.TabIndex = 5;
            this.labelLatestHumidity.Text = "Humidity";
            this.labelLatestHumidity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxWeather
            // 
            this.pictureBoxWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxWeather.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxWeather.Location = new System.Drawing.Point(339, 187);
            this.pictureBoxWeather.Name = "pictureBoxWeather";
            this.pictureBoxWeather.Size = new System.Drawing.Size(164, 86);
            this.pictureBoxWeather.TabIndex = 0;
            this.pictureBoxWeather.TabStop = false;
            // 
            // tabPageInfo
            // 
            this.tabPageInfo.Controls.Add(this.dataGridViewInfo);
            this.tabPageInfo.Location = new System.Drawing.Point(4, 22);
            this.tabPageInfo.Name = "tabPageInfo";
            this.tabPageInfo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInfo.Size = new System.Drawing.Size(512, 315);
            this.tabPageInfo.TabIndex = 1;
            this.tabPageInfo.Text = "Info";
            this.tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // dataGridViewInfo
            // 
            this.dataGridViewInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewInfo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridViewInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewInfo.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewInfo.Name = "dataGridViewInfo";
            this.dataGridViewInfo.ReadOnly = true;
            this.dataGridViewInfo.Size = new System.Drawing.Size(506, 309);
            this.dataGridViewInfo.TabIndex = 2;
            // 
            // tabPageAdmin
            // 
            this.tabPageAdmin.Controls.Add(this.tableLayoutPanel2);
            this.tabPageAdmin.Location = new System.Drawing.Point(4, 22);
            this.tabPageAdmin.Name = "tabPageAdmin";
            this.tabPageAdmin.Size = new System.Drawing.Size(512, 315);
            this.tabPageAdmin.TabIndex = 2;
            this.tabPageAdmin.Text = "Admin";
            this.tabPageAdmin.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.buttonClearDatabase, 3, 3);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(512, 315);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonClearDatabase
            // 
            this.buttonClearDatabase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonClearDatabase.ForeColor = System.Drawing.Color.Red;
            this.buttonClearDatabase.Location = new System.Drawing.Point(387, 237);
            this.buttonClearDatabase.Name = "buttonClearDatabase";
            this.buttonClearDatabase.Size = new System.Drawing.Size(122, 75);
            this.buttonClearDatabase.TabIndex = 0;
            this.buttonClearDatabase.Text = "EMPTY DATABASE";
            this.buttonClearDatabase.UseVisualStyleBackColor = true;
            this.buttonClearDatabase.Click += new System.EventHandler(this.buttonClearDatabase_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.textBoxSearch);
            this.flowLayoutPanel2.Controls.Add(this.buttonSearch);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 350);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(520, 25);
            this.flowLayoutPanel2.TabIndex = 6;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(3, 3);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(135, 20);
            this.textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonSearch.Location = new System.Drawing.Point(144, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(68, 20);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.button8HoursAgo, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonLastHour, 0, 7);
            this.tableLayoutPanel3.Controls.Add(this.button2HoursAgo, 0, 6);
            this.tableLayoutPanel3.Controls.Add(this.button3HoursAgo, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.button4HoursAgo, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.button5HoursAgo, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.button6HoursAgo, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.button7HoursAgo, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(529, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 8;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(101, 341);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // button8HoursAgo
            // 
            this.button8HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button8HoursAgo.Location = new System.Drawing.Point(3, 3);
            this.button8HoursAgo.Name = "button8HoursAgo";
            this.button8HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button8HoursAgo.TabIndex = 9;
            this.button8HoursAgo.Text = "8 hours ago";
            this.button8HoursAgo.UseVisualStyleBackColor = true;
            // 
            // buttonLastHour
            // 
            this.buttonLastHour.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLastHour.Location = new System.Drawing.Point(3, 297);
            this.buttonLastHour.Name = "buttonLastHour";
            this.buttonLastHour.Size = new System.Drawing.Size(95, 41);
            this.buttonLastHour.TabIndex = 8;
            this.buttonLastHour.Text = "Last hour";
            this.buttonLastHour.UseVisualStyleBackColor = true;
            // 
            // button2HoursAgo
            // 
            this.button2HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2HoursAgo.Location = new System.Drawing.Point(3, 255);
            this.button2HoursAgo.Name = "button2HoursAgo";
            this.button2HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button2HoursAgo.TabIndex = 8;
            this.button2HoursAgo.Text = "2 hours ago";
            this.button2HoursAgo.UseVisualStyleBackColor = true;
            // 
            // button3HoursAgo
            // 
            this.button3HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3HoursAgo.Location = new System.Drawing.Point(3, 213);
            this.button3HoursAgo.Name = "button3HoursAgo";
            this.button3HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button3HoursAgo.TabIndex = 8;
            this.button3HoursAgo.Text = "3 hours ago";
            this.button3HoursAgo.UseVisualStyleBackColor = true;
            // 
            // button4HoursAgo
            // 
            this.button4HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4HoursAgo.Location = new System.Drawing.Point(3, 171);
            this.button4HoursAgo.Name = "button4HoursAgo";
            this.button4HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button4HoursAgo.TabIndex = 8;
            this.button4HoursAgo.Text = "4 hours ago";
            this.button4HoursAgo.UseVisualStyleBackColor = true;
            // 
            // button5HoursAgo
            // 
            this.button5HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5HoursAgo.Location = new System.Drawing.Point(3, 129);
            this.button5HoursAgo.Name = "button5HoursAgo";
            this.button5HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button5HoursAgo.TabIndex = 8;
            this.button5HoursAgo.Text = "5 hours ago";
            this.button5HoursAgo.UseVisualStyleBackColor = true;
            // 
            // button6HoursAgo
            // 
            this.button6HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button6HoursAgo.Location = new System.Drawing.Point(3, 87);
            this.button6HoursAgo.Name = "button6HoursAgo";
            this.button6HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button6HoursAgo.TabIndex = 8;
            this.button6HoursAgo.Text = "6 hours ago";
            this.button6HoursAgo.UseVisualStyleBackColor = true;
            // 
            // button7HoursAgo
            // 
            this.button7HoursAgo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button7HoursAgo.Location = new System.Drawing.Point(3, 45);
            this.button7HoursAgo.Name = "button7HoursAgo";
            this.button7HoursAgo.Size = new System.Drawing.Size(95, 36);
            this.button7HoursAgo.TabIndex = 8;
            this.button7HoursAgo.Text = "7 hours ago";
            this.button7HoursAgo.UseVisualStyleBackColor = true;
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // timerUpdateMainview
            // 
            this.timerUpdateMainview.Enabled = true;
            this.timerUpdateMainview.Interval = 10000;
            this.timerUpdateMainview.Tick += new System.EventHandler(this.timerUpdateMainview_Tick);
            // 
            // timerUpdateBackground
            // 
            this.timerUpdateBackground.Enabled = true;
            this.timerUpdateBackground.Interval = 300000;
            this.timerUpdateBackground.Tick += new System.EventHandler(this.timerUpdateBackground_Tick);
            // 
            // timerColorAnimation
            // 
            this.timerColorAnimation.Enabled = true;
            this.timerColorAnimation.Interval = 3000;
            this.timerColorAnimation.Tick += new System.EventHandler(this.timerColorAnimation_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 381);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(650, 420);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMain.ResumeLayout(false);
            this.tableLayoutPanelMainView.ResumeLayout(false);
            this.tableLayoutPanelMainView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMoon)).EndInit();
            this.tableLayoutPanelClock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWeather)).EndInit();
            this.tabPageInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInfo)).EndInit();
            this.tabPageAdmin.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMain;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonCurrentTime;
        private System.Windows.Forms.Button buttonLastHour;
        private System.Windows.Forms.Button button2HoursAgo;
        private System.Windows.Forms.Button button3HoursAgo;
        private System.Windows.Forms.Button button4HoursAgo;
        private System.Windows.Forms.Button button5HoursAgo;
        private System.Windows.Forms.Button button6HoursAgo;
        private System.Windows.Forms.Button button7HoursAgo;
        private System.Windows.Forms.Button button8HoursAgo;
        private System.Windows.Forms.TabPage tabPageAdmin;
        private System.Windows.Forms.DataGridView dataGridViewInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMainView;
        private System.Windows.Forms.PictureBox pictureBoxWeather;
        private System.Windows.Forms.PictureBox pictureBoxMoon;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelClock;
        private System.Windows.Forms.Label labelClock;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label labelLatestTemperature;
        private System.Windows.Forms.Timer timerUpdateMainview;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button buttonClearDatabase;
        private System.Windows.Forms.Label labelLatestHumidity;
        private System.Windows.Forms.Timer timerUpdateBackground;
        private System.Windows.Forms.Timer timerColorAnimation;
    }
}

