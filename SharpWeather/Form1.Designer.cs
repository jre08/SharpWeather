
using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;
using SharpWeather;
//
// Created by SharpDevelop.
// User: edenfield-john
// Date: 10/6/2015
// Time: 4:10 PM
// 
// To change this template use Tools | Options | Coding | Edit Standard Headers.
//
partial class MainForm
{

    /// <summary>
    /// Designer variable used to keep track of non-visual components.
    /// </summary>
    private System.ComponentModel.IContainer components;

    /// <summary>
    /// Disposes resources used by the form.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
 
    protected override void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (components != null)
            {
                components.Dispose();
            }
        }
        base.Dispose(disposing);
    }

    /// <summary>
    /// This method is required for Windows Forms designer support.
    /// Do not change the method contents inside the source code editor. The Forms designer might
    /// not be able to load this method if it was changed manually.
    /// </summary>
    private void InitializeComponent()
    {
    	this.components = new System.ComponentModel.Container();
    	System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
			"Heat Advisory"}, 1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))));
    	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
    	this.zipBox = new System.Windows.Forms.ComboBox();
    	this.statusStrip1 = new System.Windows.Forms.StatusStrip();
    	this.statusbarLongLat = new System.Windows.Forms.ToolStripStatusLabel();
    	this.statusbarMapZoom = new System.Windows.Forms.ToolStripStatusLabel();
    	this.toolStripDebug = new System.Windows.Forms.ToolStripStatusLabel();
    	this.metroTabControl1 = new System.Windows.Forms.TabControl();
    	this.tabPageConditions = new System.Windows.Forms.TabPage();
    	this.Condition_FlowPanel_3day = new System.Windows.Forms.FlowLayoutPanel();
    	this.Condition_grpBx_D1summary = new System.Windows.Forms.GroupBox();
    	this.picbox_conditions_icon2 = new System.Windows.Forms.PictureBox();
    	this.lbl_Condition_temp2 = new System.Windows.Forms.Label();
    	this.lbl_Condition_fctext2 = new System.Windows.Forms.Label();
    	this.Condition_grpBx_D2summary = new System.Windows.Forms.GroupBox();
    	this.picbox_conditions_icon3 = new System.Windows.Forms.PictureBox();
    	this.lbl_Condition_temp3 = new System.Windows.Forms.Label();
    	this.lbl_Condition_fctext3 = new System.Windows.Forms.Label();
    	this.Condition_grpBx_D3summary = new System.Windows.Forms.GroupBox();
    	this.picbox_conditions_icon4 = new System.Windows.Forms.PictureBox();
    	this.lbl_Condition_temp4 = new System.Windows.Forms.Label();
    	this.lbl_Condition_fctext4 = new System.Windows.Forms.Label();
    	this.metroPanel1 = new System.Windows.Forms.Panel();
    	this.panelDay1 = new System.Windows.Forms.Panel();
    	this.groupBox1 = new System.Windows.Forms.GroupBox();
    	this.lbl_Condition_wind = new System.Windows.Forms.Label();
    	this.groupBox2 = new System.Windows.Forms.GroupBox();
    	this.lbl_Condition_elevation = new System.Windows.Forms.Label();
    	this.lbl_condition_station = new System.Windows.Forms.Label();
    	this.lbl_condition_city = new System.Windows.Forms.Label();
    	this.lbl_Condition_latitude = new System.Windows.Forms.Label();
    	this.lbl_Condition_zip = new System.Windows.Forms.Label();
    	this.lbl_Condition_long = new System.Windows.Forms.Label();
    	this.Condition_grpBx_Pressure = new System.Windows.Forms.GroupBox();
    	this.lbl_Condition_pressure_mb = new System.Windows.Forms.Label();
    	this.lbl_Condition_pressure_trend = new System.Windows.Forms.Label();
    	this.lbl_Condition_pressure_in = new System.Windows.Forms.Label();
    	this.Condition_grpBx_RainFall = new System.Windows.Forms.GroupBox();
    	this.lbl_Condition_precip_today_in = new System.Windows.Forms.Label();
    	this.lbl_Condition_precip_1hr = new System.Windows.Forms.Label();
    	this.lbl_Condition_dewpoint = new System.Windows.Forms.Label();
    	this.Condition_grpBx_Temp = new System.Windows.Forms.GroupBox();
    	this.lbl_Condition_temp = new System.Windows.Forms.Label();
    	this.lbl_Condition_Day = new System.Windows.Forms.Label();
    	this.lbl_Condition_humidity = new System.Windows.Forms.Label();
    	this.lbl_Condition_feels = new System.Windows.Forms.Label();
    	this.lbl_Condition_UV = new System.Windows.Forms.Label();
    	this.picbox_conditions_icon = new System.Windows.Forms.PictureBox();
    	this.lbl_Condition_Weather = new System.Windows.Forms.Label();
    	this.lbl_Condition_visibleMi = new System.Windows.Forms.Label();
    	this.tabPage10Day = new System.Windows.Forms.TabPage();
    	this.panel2 = new SharpWeather.DoubleBufferedPanel();
    	this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
    	this.panel5 = new System.Windows.Forms.Panel();
    	this.label1 = new System.Windows.Forms.Label();
    	this.label4 = new System.Windows.Forms.Label();
    	this.label7 = new System.Windows.Forms.Label();
    	this.day1Pic = new System.Windows.Forms.PictureBox();
    	this.label57 = new System.Windows.Forms.Label();
    	this.label56 = new System.Windows.Forms.Label();
    	this.label55 = new System.Windows.Forms.Label();
    	this.label54 = new System.Windows.Forms.Label();
    	this.label25 = new System.Windows.Forms.Label();
    	this.label24 = new System.Windows.Forms.Label();
    	this.label19 = new System.Windows.Forms.Label();
    	this.label18 = new System.Windows.Forms.Label();
    	this.label13 = new System.Windows.Forms.Label();
    	this.label12 = new System.Windows.Forms.Label();
    	this.day1Desc = new System.Windows.Forms.Label();
    	this.day1Label = new System.Windows.Forms.Label();
    	this.panel6 = new System.Windows.Forms.Panel();
    	this.night2Pic = new System.Windows.Forms.PictureBox();
    	this.day2Pic = new System.Windows.Forms.PictureBox();
    	this.night2cop = new System.Windows.Forms.Label();
    	this.day2cop = new System.Windows.Forms.Label();
    	this.Night2Desc = new System.Windows.Forms.Label();
    	this.day2Desc = new System.Windows.Forms.Label();
    	this.night2Label = new System.Windows.Forms.Label();
    	this.day2Label = new System.Windows.Forms.Label();
    	this.panel7 = new System.Windows.Forms.Panel();
    	this.night3Pic = new System.Windows.Forms.PictureBox();
    	this.day3Pic = new System.Windows.Forms.PictureBox();
    	this.night3cop = new System.Windows.Forms.Label();
    	this.day3cop = new System.Windows.Forms.Label();
    	this.Night3Desc = new System.Windows.Forms.Label();
    	this.day3Desc = new System.Windows.Forms.Label();
    	this.night3Label = new System.Windows.Forms.Label();
    	this.day3Label = new System.Windows.Forms.Label();
    	this.panel9 = new System.Windows.Forms.Panel();
    	this.night4Pic = new System.Windows.Forms.PictureBox();
    	this.day4Pic = new System.Windows.Forms.PictureBox();
    	this.night4cop = new System.Windows.Forms.Label();
    	this.day4cop = new System.Windows.Forms.Label();
    	this.Night4Desc = new System.Windows.Forms.Label();
    	this.day4Desc = new System.Windows.Forms.Label();
    	this.night4Label = new System.Windows.Forms.Label();
    	this.day4Label = new System.Windows.Forms.Label();
    	this.panel12 = new System.Windows.Forms.Panel();
    	this.night5Pic = new System.Windows.Forms.PictureBox();
    	this.day5Pic = new System.Windows.Forms.PictureBox();
    	this.night5cop = new System.Windows.Forms.Label();
    	this.day5cop = new System.Windows.Forms.Label();
    	this.Night5Desc = new System.Windows.Forms.Label();
    	this.day5Desc = new System.Windows.Forms.Label();
    	this.night5Label = new System.Windows.Forms.Label();
    	this.day5Label = new System.Windows.Forms.Label();
    	this.panel10 = new System.Windows.Forms.Panel();
    	this.night6Pic = new System.Windows.Forms.PictureBox();
    	this.day6Pic = new System.Windows.Forms.PictureBox();
    	this.night6cop = new System.Windows.Forms.Label();
    	this.day6cop = new System.Windows.Forms.Label();
    	this.Night6Desc = new System.Windows.Forms.Label();
    	this.day6Desc = new System.Windows.Forms.Label();
    	this.night6Label = new System.Windows.Forms.Label();
    	this.day6Label = new System.Windows.Forms.Label();
    	this.panel13 = new System.Windows.Forms.Panel();
    	this.night7Pic = new System.Windows.Forms.PictureBox();
    	this.day7Pic = new System.Windows.Forms.PictureBox();
    	this.night7cop = new System.Windows.Forms.Label();
    	this.day7cop = new System.Windows.Forms.Label();
    	this.Night7Desc = new System.Windows.Forms.Label();
    	this.day7Desc = new System.Windows.Forms.Label();
    	this.night7Label = new System.Windows.Forms.Label();
    	this.day7Label = new System.Windows.Forms.Label();
    	this.panel14 = new System.Windows.Forms.Panel();
    	this.night8Pic = new System.Windows.Forms.PictureBox();
    	this.day8Pic = new System.Windows.Forms.PictureBox();
    	this.night8cop = new System.Windows.Forms.Label();
    	this.day8cop = new System.Windows.Forms.Label();
    	this.Night8Desc = new System.Windows.Forms.Label();
    	this.day8Desc = new System.Windows.Forms.Label();
    	this.night8Label = new System.Windows.Forms.Label();
    	this.day8Label = new System.Windows.Forms.Label();
    	this.panel11 = new System.Windows.Forms.Panel();
    	this.night9Pic = new System.Windows.Forms.PictureBox();
    	this.day9Pic = new System.Windows.Forms.PictureBox();
    	this.night9cop = new System.Windows.Forms.Label();
    	this.day9cop = new System.Windows.Forms.Label();
    	this.Night9Desc = new System.Windows.Forms.Label();
    	this.day9Desc = new System.Windows.Forms.Label();
    	this.night9Label = new System.Windows.Forms.Label();
    	this.day9Label = new System.Windows.Forms.Label();
    	this.DayPanel8 = new System.Windows.Forms.Panel();
    	this.night10Pic = new System.Windows.Forms.PictureBox();
    	this.day10Pic = new System.Windows.Forms.PictureBox();
    	this.night10cop = new System.Windows.Forms.Label();
    	this.day10cop = new System.Windows.Forms.Label();
    	this.Night10Desc = new System.Windows.Forms.Label();
    	this.day10Desc = new System.Windows.Forms.Label();
    	this.night10Label = new System.Windows.Forms.Label();
    	this.day10Label = new System.Windows.Forms.Label();
    	this.metroTabPage4 = new System.Windows.Forms.TabPage();
    	this.alertPanel = new System.Windows.Forms.FlowLayoutPanel();
    	this.tabPageBrowser = new System.Windows.Forms.TabPage();
    	this.comboBox1 = new System.Windows.Forms.ComboBox();
    	this.WEBmapbrowser = new System.Windows.Forms.WebBrowser();
    	this.tabPageDebug = new System.Windows.Forms.TabPage();
    	this.txtbox_debug_debug = new System.Windows.Forms.TextBox();
    	this.metro = new System.Windows.Forms.Button();
    	this.comboBox2 = new System.Windows.Forms.ComboBox();
    	this.textboxMapHght = new System.Windows.Forms.TextBox();
    	this.textboxMapWidth = new System.Windows.Forms.TextBox();
    	this.metroButton1 = new System.Windows.Forms.Button();
    	this.textboxLon = new System.Windows.Forms.TextBox();
    	this.textboxLat = new System.Windows.Forms.TextBox();
    	this.label16 = new System.Windows.Forms.Label();
    	this.label3 = new System.Windows.Forms.Label();
    	this.label2 = new System.Windows.Forms.Label();
    	this.label15 = new System.Windows.Forms.Label();
    	this.button1 = new System.Windows.Forms.Button();
    	this.Alert_listview = new System.Windows.Forms.ListView();
    	this.alertImgLst = new System.Windows.Forms.ImageList(this.components);
    	this.pictureBox1 = new System.Windows.Forms.PictureBox();
    	this.pictureBox2 = new System.Windows.Forms.PictureBox();
    	this.statusStrip1.SuspendLayout();
    	this.metroTabControl1.SuspendLayout();
    	this.tabPageConditions.SuspendLayout();
    	this.Condition_FlowPanel_3day.SuspendLayout();
    	this.Condition_grpBx_D1summary.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.picbox_conditions_icon2)).BeginInit();
    	this.Condition_grpBx_D2summary.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.picbox_conditions_icon3)).BeginInit();
    	this.Condition_grpBx_D3summary.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.picbox_conditions_icon4)).BeginInit();
    	this.metroPanel1.SuspendLayout();
    	this.panelDay1.SuspendLayout();
    	this.groupBox1.SuspendLayout();
    	this.groupBox2.SuspendLayout();
    	this.Condition_grpBx_Pressure.SuspendLayout();
    	this.Condition_grpBx_RainFall.SuspendLayout();
    	this.Condition_grpBx_Temp.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.picbox_conditions_icon)).BeginInit();
    	this.tabPage10Day.SuspendLayout();
    	this.panel2.SuspendLayout();
    	this.flowLayoutPanel1.SuspendLayout();
    	this.panel5.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.day1Pic)).BeginInit();
    	this.panel6.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night2Pic)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.day2Pic)).BeginInit();
    	this.panel7.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night3Pic)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.day3Pic)).BeginInit();
    	this.panel9.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night4Pic)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.day4Pic)).BeginInit();
    	this.panel12.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night5Pic)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.day5Pic)).BeginInit();
    	this.panel10.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night6Pic)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.day6Pic)).BeginInit();
    	this.panel13.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night7Pic)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.day7Pic)).BeginInit();
    	this.panel14.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night8Pic)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.day8Pic)).BeginInit();
    	this.panel11.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night9Pic)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.day9Pic)).BeginInit();
    	this.DayPanel8.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night10Pic)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.day10Pic)).BeginInit();
    	this.metroTabPage4.SuspendLayout();
    	this.tabPageBrowser.SuspendLayout();
    	this.tabPageDebug.SuspendLayout();
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
    	this.SuspendLayout();
    	// 
    	// zipBox
    	// 
    	this.zipBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.zipBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
    	this.zipBox.FormattingEnabled = true;
    	this.zipBox.Location = new System.Drawing.Point(1023, 12);
    	this.zipBox.Name = "zipBox";
    	this.zipBox.Size = new System.Drawing.Size(202, 21);
    	this.zipBox.TabIndex = 4;
    	this.zipBox.SelectedIndexChanged += new System.EventHandler(this.zipBox_SelectedIndexChanged);
    	this.zipBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
    	// 
    	// statusStrip1
    	// 
    	this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.statusbarLongLat,
			this.statusbarMapZoom,
			this.toolStripDebug});
    	this.statusStrip1.Location = new System.Drawing.Point(0, 822);
    	this.statusStrip1.Name = "statusStrip1";
    	this.statusStrip1.Size = new System.Drawing.Size(1229, 22);
    	this.statusStrip1.TabIndex = 8;
    	this.statusStrip1.Text = "statusStrip1";
    	// 
    	// statusbarLongLat
    	// 
    	this.statusbarLongLat.Name = "statusbarLongLat";
    	this.statusbarLongLat.Size = new System.Drawing.Size(59, 17);
    	this.statusbarLongLat.Text = "Long : Lat";
    	// 
    	// statusbarMapZoom
    	// 
    	this.statusbarMapZoom.Margin = new System.Windows.Forms.Padding(10, 3, 0, 2);
    	this.statusbarMapZoom.Name = "statusbarMapZoom";
    	this.statusbarMapZoom.Size = new System.Drawing.Size(88, 17);
    	this.statusbarMapZoom.Text = "Map Zoom LVL";
    	// 
    	// toolStripDebug
    	// 
    	this.toolStripDebug.Name = "toolStripDebug";
    	this.toolStripDebug.Size = new System.Drawing.Size(77, 17);
    	this.toolStripDebug.Text = "Debug Status";
    	// 
    	// metroTabControl1
    	// 
    	this.metroTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.metroTabControl1.Controls.Add(this.tabPageConditions);
    	this.metroTabControl1.Controls.Add(this.tabPage10Day);
    	this.metroTabControl1.Controls.Add(this.metroTabPage4);
    	this.metroTabControl1.Controls.Add(this.tabPageBrowser);
    	this.metroTabControl1.Controls.Add(this.tabPageDebug);
    	this.metroTabControl1.Location = new System.Drawing.Point(0, 54);
    	this.metroTabControl1.Name = "metroTabControl1";
    	this.metroTabControl1.Padding = new System.Drawing.Point(6, 8);
    	this.metroTabControl1.SelectedIndex = 0;
    	this.metroTabControl1.Size = new System.Drawing.Size(1229, 768);
    	this.metroTabControl1.TabIndex = 6;
    	// 
    	// tabPageConditions
    	// 
    	this.tabPageConditions.BackgroundImage = global::SharpWeather.weatherIcons.Cloudy_1;
    	this.tabPageConditions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
    	this.tabPageConditions.Controls.Add(this.Condition_FlowPanel_3day);
    	this.tabPageConditions.Controls.Add(this.metroPanel1);
    	this.tabPageConditions.Location = new System.Drawing.Point(4, 32);
    	this.tabPageConditions.Name = "tabPageConditions";
    	this.tabPageConditions.Size = new System.Drawing.Size(1221, 732);
    	this.tabPageConditions.TabIndex = 2;
    	this.tabPageConditions.Text = "Current Conditions";
    	// 
    	// Condition_FlowPanel_3day
    	// 
    	this.Condition_FlowPanel_3day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.Condition_FlowPanel_3day.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
    	this.Condition_FlowPanel_3day.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.Condition_FlowPanel_3day.Controls.Add(this.Condition_grpBx_D1summary);
    	this.Condition_FlowPanel_3day.Controls.Add(this.Condition_grpBx_D2summary);
    	this.Condition_FlowPanel_3day.Controls.Add(this.Condition_grpBx_D3summary);
    	this.Condition_FlowPanel_3day.Location = new System.Drawing.Point(566, 449);
    	this.Condition_FlowPanel_3day.Name = "Condition_FlowPanel_3day";
    	this.Condition_FlowPanel_3day.Size = new System.Drawing.Size(652, 277);
    	this.Condition_FlowPanel_3day.TabIndex = 7;
    	// 
    	// Condition_grpBx_D1summary
    	// 
    	this.Condition_grpBx_D1summary.BackColor = System.Drawing.Color.Transparent;
    	this.Condition_grpBx_D1summary.Controls.Add(this.picbox_conditions_icon2);
    	this.Condition_grpBx_D1summary.Controls.Add(this.lbl_Condition_temp2);
    	this.Condition_grpBx_D1summary.Controls.Add(this.lbl_Condition_fctext2);
    	this.Condition_grpBx_D1summary.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.Condition_grpBx_D1summary.Location = new System.Drawing.Point(1, 3);
    	this.Condition_grpBx_D1summary.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
    	this.Condition_grpBx_D1summary.Name = "Condition_grpBx_D1summary";
    	this.Condition_grpBx_D1summary.Size = new System.Drawing.Size(177, 334);
    	this.Condition_grpBx_D1summary.TabIndex = 4;
    	this.Condition_grpBx_D1summary.TabStop = false;
    	this.Condition_grpBx_D1summary.Text = "Day1";
    	// 
    	// picbox_conditions_icon2
    	// 
    	this.picbox_conditions_icon2.Location = new System.Drawing.Point(45, 64);
    	this.picbox_conditions_icon2.Name = "picbox_conditions_icon2";
    	this.picbox_conditions_icon2.Size = new System.Drawing.Size(91, 68);
    	this.picbox_conditions_icon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
    	this.picbox_conditions_icon2.TabIndex = 3;
    	this.picbox_conditions_icon2.TabStop = false;
    	// 
    	// lbl_Condition_temp2
    	// 
    	this.lbl_Condition_temp2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_temp2.Location = new System.Drawing.Point(6, 30);
    	this.lbl_Condition_temp2.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.lbl_Condition_temp2.Name = "lbl_Condition_temp2";
    	this.lbl_Condition_temp2.Size = new System.Drawing.Size(163, 26);
    	this.lbl_Condition_temp2.TabIndex = 2;
    	this.lbl_Condition_temp2.Text = "temp_f: 66.3";
    	this.lbl_Condition_temp2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// lbl_Condition_fctext2
    	// 
    	this.lbl_Condition_fctext2.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_fctext2.Location = new System.Drawing.Point(9, 141);
    	this.lbl_Condition_fctext2.Name = "lbl_Condition_fctext2";
    	this.lbl_Condition_fctext2.Size = new System.Drawing.Size(160, 87);
    	this.lbl_Condition_fctext2.TabIndex = 0;
    	this.lbl_Condition_fctext2.Text = "\"feelslike_string\": \"66.3 F (19.1 C)\"";
    	this.lbl_Condition_fctext2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	// 
    	// Condition_grpBx_D2summary
    	// 
    	this.Condition_grpBx_D2summary.BackColor = System.Drawing.Color.Transparent;
    	this.Condition_grpBx_D2summary.Controls.Add(this.picbox_conditions_icon3);
    	this.Condition_grpBx_D2summary.Controls.Add(this.lbl_Condition_temp3);
    	this.Condition_grpBx_D2summary.Controls.Add(this.lbl_Condition_fctext3);
    	this.Condition_grpBx_D2summary.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.Condition_grpBx_D2summary.Location = new System.Drawing.Point(180, 3);
    	this.Condition_grpBx_D2summary.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
    	this.Condition_grpBx_D2summary.Name = "Condition_grpBx_D2summary";
    	this.Condition_grpBx_D2summary.Size = new System.Drawing.Size(177, 334);
    	this.Condition_grpBx_D2summary.TabIndex = 4;
    	this.Condition_grpBx_D2summary.TabStop = false;
    	this.Condition_grpBx_D2summary.Text = "Day2";
    	// 
    	// picbox_conditions_icon3
    	// 
    	this.picbox_conditions_icon3.Location = new System.Drawing.Point(37, 64);
    	this.picbox_conditions_icon3.Name = "picbox_conditions_icon3";
    	this.picbox_conditions_icon3.Size = new System.Drawing.Size(91, 68);
    	this.picbox_conditions_icon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
    	this.picbox_conditions_icon3.TabIndex = 3;
    	this.picbox_conditions_icon3.TabStop = false;
    	// 
    	// lbl_Condition_temp3
    	// 
    	this.lbl_Condition_temp3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_temp3.Location = new System.Drawing.Point(6, 30);
    	this.lbl_Condition_temp3.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.lbl_Condition_temp3.Name = "lbl_Condition_temp3";
    	this.lbl_Condition_temp3.Size = new System.Drawing.Size(163, 26);
    	this.lbl_Condition_temp3.TabIndex = 2;
    	this.lbl_Condition_temp3.Text = "temp_f: 66.3";
    	this.lbl_Condition_temp3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// lbl_Condition_fctext3
    	// 
    	this.lbl_Condition_fctext3.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_fctext3.Location = new System.Drawing.Point(9, 141);
    	this.lbl_Condition_fctext3.Name = "lbl_Condition_fctext3";
    	this.lbl_Condition_fctext3.Size = new System.Drawing.Size(160, 87);
    	this.lbl_Condition_fctext3.TabIndex = 0;
    	this.lbl_Condition_fctext3.Text = "\"feelslike_string\": \"66.3 F (19.1 C)\"";
    	this.lbl_Condition_fctext3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	// 
    	// Condition_grpBx_D3summary
    	// 
    	this.Condition_grpBx_D3summary.BackColor = System.Drawing.Color.Transparent;
    	this.Condition_grpBx_D3summary.Controls.Add(this.picbox_conditions_icon4);
    	this.Condition_grpBx_D3summary.Controls.Add(this.lbl_Condition_temp4);
    	this.Condition_grpBx_D3summary.Controls.Add(this.lbl_Condition_fctext4);
    	this.Condition_grpBx_D3summary.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.Condition_grpBx_D3summary.Location = new System.Drawing.Point(359, 3);
    	this.Condition_grpBx_D3summary.Margin = new System.Windows.Forms.Padding(1, 3, 1, 3);
    	this.Condition_grpBx_D3summary.Name = "Condition_grpBx_D3summary";
    	this.Condition_grpBx_D3summary.Size = new System.Drawing.Size(177, 334);
    	this.Condition_grpBx_D3summary.TabIndex = 4;
    	this.Condition_grpBx_D3summary.TabStop = false;
    	this.Condition_grpBx_D3summary.Text = "Day3";
    	// 
    	// picbox_conditions_icon4
    	// 
    	this.picbox_conditions_icon4.Location = new System.Drawing.Point(44, 64);
    	this.picbox_conditions_icon4.Name = "picbox_conditions_icon4";
    	this.picbox_conditions_icon4.Size = new System.Drawing.Size(91, 68);
    	this.picbox_conditions_icon4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
    	this.picbox_conditions_icon4.TabIndex = 3;
    	this.picbox_conditions_icon4.TabStop = false;
    	// 
    	// lbl_Condition_temp4
    	// 
    	this.lbl_Condition_temp4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_temp4.Location = new System.Drawing.Point(6, 30);
    	this.lbl_Condition_temp4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.lbl_Condition_temp4.Name = "lbl_Condition_temp4";
    	this.lbl_Condition_temp4.Size = new System.Drawing.Size(163, 26);
    	this.lbl_Condition_temp4.TabIndex = 2;
    	this.lbl_Condition_temp4.Text = "temp_f: 66.3";
    	this.lbl_Condition_temp4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// lbl_Condition_fctext4
    	// 
    	this.lbl_Condition_fctext4.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_fctext4.Location = new System.Drawing.Point(9, 141);
    	this.lbl_Condition_fctext4.Name = "lbl_Condition_fctext4";
    	this.lbl_Condition_fctext4.Size = new System.Drawing.Size(160, 87);
    	this.lbl_Condition_fctext4.TabIndex = 0;
    	this.lbl_Condition_fctext4.Text = "\"feelslike_string\": \"66.3 F (19.1 C)\"";
    	this.lbl_Condition_fctext4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	// 
    	// metroPanel1
    	// 
    	this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
    	this.metroPanel1.BackColor = System.Drawing.Color.Transparent;
    	this.metroPanel1.Controls.Add(this.panelDay1);
    	this.metroPanel1.Location = new System.Drawing.Point(3, 3);
    	this.metroPanel1.Name = "metroPanel1";
    	this.metroPanel1.Size = new System.Drawing.Size(556, 723);
    	this.metroPanel1.TabIndex = 6;
    	// 
    	// panelDay1
    	// 
    	this.panelDay1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.panelDay1.AutoScroll = true;
    	this.panelDay1.AutoScrollMargin = new System.Drawing.Size(0, 9);
    	this.panelDay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
    	this.panelDay1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
    	this.panelDay1.Controls.Add(this.groupBox1);
    	this.panelDay1.Controls.Add(this.groupBox2);
    	this.panelDay1.Controls.Add(this.Condition_grpBx_Pressure);
    	this.panelDay1.Controls.Add(this.Condition_grpBx_RainFall);
    	this.panelDay1.Controls.Add(this.Condition_grpBx_Temp);
    	this.panelDay1.Controls.Add(this.lbl_Condition_UV);
    	this.panelDay1.Controls.Add(this.picbox_conditions_icon);
    	this.panelDay1.Controls.Add(this.lbl_Condition_Weather);
    	this.panelDay1.Controls.Add(this.lbl_Condition_visibleMi);
    	this.panelDay1.Location = new System.Drawing.Point(3, 3);
    	this.panelDay1.Name = "panelDay1";
    	this.panelDay1.Size = new System.Drawing.Size(550, 717);
    	this.panelDay1.TabIndex = 4;
    	// 
    	// groupBox1
    	// 
    	this.groupBox1.BackColor = System.Drawing.Color.Transparent;
    	this.groupBox1.Controls.Add(this.lbl_Condition_wind);
    	this.groupBox1.Location = new System.Drawing.Point(9, 340);
    	this.groupBox1.Name = "groupBox1";
    	this.groupBox1.Size = new System.Drawing.Size(152, 132);
    	this.groupBox1.TabIndex = 6;
    	this.groupBox1.TabStop = false;
    	this.groupBox1.Text = "Wind Info";
    	// 
    	// lbl_Condition_wind
    	// 
    	this.lbl_Condition_wind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_wind.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_wind.Location = new System.Drawing.Point(6, 16);
    	this.lbl_Condition_wind.Name = "lbl_Condition_wind";
    	this.lbl_Condition_wind.Size = new System.Drawing.Size(140, 111);
    	this.lbl_Condition_wind.TabIndex = 0;
    	this.lbl_Condition_wind.Text = "\"wind_string\": \"From the NNW at 22.0 MPH Gusting to 28.0 MPH\"";
    	// 
    	// groupBox2
    	// 
    	this.groupBox2.BackColor = System.Drawing.Color.Transparent;
    	this.groupBox2.Controls.Add(this.lbl_Condition_elevation);
    	this.groupBox2.Controls.Add(this.lbl_condition_station);
    	this.groupBox2.Controls.Add(this.lbl_condition_city);
    	this.groupBox2.Controls.Add(this.lbl_Condition_latitude);
    	this.groupBox2.Controls.Add(this.lbl_Condition_zip);
    	this.groupBox2.Controls.Add(this.lbl_Condition_long);
    	this.groupBox2.Location = new System.Drawing.Point(257, 478);
    	this.groupBox2.Name = "groupBox2";
    	this.groupBox2.Size = new System.Drawing.Size(270, 228);
    	this.groupBox2.TabIndex = 4;
    	this.groupBox2.TabStop = false;
    	this.groupBox2.Text = "Pressure";
    	// 
    	// lbl_Condition_elevation
    	// 
    	this.lbl_Condition_elevation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_elevation.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_elevation.Location = new System.Drawing.Point(29, 186);
    	this.lbl_Condition_elevation.Name = "lbl_Condition_elevation";
    	this.lbl_Condition_elevation.Size = new System.Drawing.Size(223, 23);
    	this.lbl_Condition_elevation.TabIndex = 2;
    	this.lbl_Condition_elevation.Text = "Elevation";
    	this.lbl_Condition_elevation.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	this.lbl_Condition_elevation.Click += new System.EventHandler(this.lbl_Condition_elevation_Click);
    	// 
    	// lbl_condition_station
    	// 
    	this.lbl_condition_station.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_condition_station.Font = new System.Drawing.Font("Corbel", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_condition_station.Location = new System.Drawing.Point(29, 24);
    	this.lbl_condition_station.Name = "lbl_condition_station";
    	this.lbl_condition_station.Size = new System.Drawing.Size(223, 39);
    	this.lbl_condition_station.TabIndex = 0;
    	this.lbl_condition_station.Text = "Station ID";
    	this.lbl_condition_station.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// lbl_condition_city
    	// 
    	this.lbl_condition_city.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_condition_city.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_condition_city.Location = new System.Drawing.Point(29, 67);
    	this.lbl_condition_city.Name = "lbl_condition_city";
    	this.lbl_condition_city.Size = new System.Drawing.Size(223, 27);
    	this.lbl_condition_city.TabIndex = 0;
    	this.lbl_condition_city.Text = "City: Greenwood, FL";
    	this.lbl_condition_city.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	this.lbl_condition_city.Click += new System.EventHandler(this.lbl_condition_city_Click);
    	// 
    	// lbl_Condition_latitude
    	// 
    	this.lbl_Condition_latitude.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_latitude.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_latitude.Location = new System.Drawing.Point(29, 128);
    	this.lbl_Condition_latitude.Name = "lbl_Condition_latitude";
    	this.lbl_Condition_latitude.Size = new System.Drawing.Size(223, 24);
    	this.lbl_Condition_latitude.TabIndex = 2;
    	this.lbl_Condition_latitude.Text = "Latitude: ";
    	this.lbl_Condition_latitude.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	this.lbl_Condition_latitude.Click += new System.EventHandler(this.lbl_Condition_latitude_Click);
    	// 
    	// lbl_Condition_zip
    	// 
    	this.lbl_Condition_zip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_zip.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_zip.Location = new System.Drawing.Point(29, 92);
    	this.lbl_Condition_zip.Name = "lbl_Condition_zip";
    	this.lbl_Condition_zip.Size = new System.Drawing.Size(223, 21);
    	this.lbl_Condition_zip.TabIndex = 0;
    	this.lbl_Condition_zip.Text = "Zip Code: 32443";
    	this.lbl_Condition_zip.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	this.lbl_Condition_zip.Click += new System.EventHandler(this.lbl_Condition_zip_Click);
    	// 
    	// lbl_Condition_long
    	// 
    	this.lbl_Condition_long.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_long.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_long.Location = new System.Drawing.Point(29, 158);
    	this.lbl_Condition_long.Name = "lbl_Condition_long";
    	this.lbl_Condition_long.Size = new System.Drawing.Size(223, 28);
    	this.lbl_Condition_long.TabIndex = 2;
    	this.lbl_Condition_long.Text = "Longitude:";
    	this.lbl_Condition_long.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	this.lbl_Condition_long.Click += new System.EventHandler(this.lbl_Condition_long_Click);
    	// 
    	// Condition_grpBx_Pressure
    	// 
    	this.Condition_grpBx_Pressure.BackColor = System.Drawing.Color.Transparent;
    	this.Condition_grpBx_Pressure.Controls.Add(this.lbl_Condition_pressure_mb);
    	this.Condition_grpBx_Pressure.Controls.Add(this.lbl_Condition_pressure_trend);
    	this.Condition_grpBx_Pressure.Controls.Add(this.lbl_Condition_pressure_in);
    	this.Condition_grpBx_Pressure.Location = new System.Drawing.Point(13, 478);
    	this.Condition_grpBx_Pressure.Name = "Condition_grpBx_Pressure";
    	this.Condition_grpBx_Pressure.Size = new System.Drawing.Size(240, 228);
    	this.Condition_grpBx_Pressure.TabIndex = 4;
    	this.Condition_grpBx_Pressure.TabStop = false;
    	this.Condition_grpBx_Pressure.Text = "Pressure";
    	// 
    	// lbl_Condition_pressure_mb
    	// 
    	this.lbl_Condition_pressure_mb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_pressure_mb.Location = new System.Drawing.Point(44, 65);
    	this.lbl_Condition_pressure_mb.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.lbl_Condition_pressure_mb.Name = "lbl_Condition_pressure_mb";
    	this.lbl_Condition_pressure_mb.Size = new System.Drawing.Size(150, 25);
    	this.lbl_Condition_pressure_mb.TabIndex = 2;
    	this.lbl_Condition_pressure_mb.Text = "\"pressure_mb\": \"1013\",";
    	this.lbl_Condition_pressure_mb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	this.lbl_Condition_pressure_mb.Click += new System.EventHandler(this.n1Hi_Click);
    	// 
    	// lbl_Condition_pressure_trend
    	// 
    	this.lbl_Condition_pressure_trend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_pressure_trend.Location = new System.Drawing.Point(44, 183);
    	this.lbl_Condition_pressure_trend.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.lbl_Condition_pressure_trend.Name = "lbl_Condition_pressure_trend";
    	this.lbl_Condition_pressure_trend.Size = new System.Drawing.Size(150, 26);
    	this.lbl_Condition_pressure_trend.TabIndex = 2;
    	this.lbl_Condition_pressure_trend.Text = "\"pressure_trend\": \"+\",";
    	this.lbl_Condition_pressure_trend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// lbl_Condition_pressure_in
    	// 
    	this.lbl_Condition_pressure_in.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_pressure_in.Location = new System.Drawing.Point(47, 126);
    	this.lbl_Condition_pressure_in.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.lbl_Condition_pressure_in.Name = "lbl_Condition_pressure_in";
    	this.lbl_Condition_pressure_in.Size = new System.Drawing.Size(147, 25);
    	this.lbl_Condition_pressure_in.TabIndex = 2;
    	this.lbl_Condition_pressure_in.Text = " \"pressure_in\": \"29.93\",";
    	this.lbl_Condition_pressure_in.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// Condition_grpBx_RainFall
    	// 
    	this.Condition_grpBx_RainFall.BackColor = System.Drawing.Color.Transparent;
    	this.Condition_grpBx_RainFall.Controls.Add(this.lbl_Condition_precip_today_in);
    	this.Condition_grpBx_RainFall.Controls.Add(this.lbl_Condition_precip_1hr);
    	this.Condition_grpBx_RainFall.Controls.Add(this.lbl_Condition_dewpoint);
    	this.Condition_grpBx_RainFall.Location = new System.Drawing.Point(167, 340);
    	this.Condition_grpBx_RainFall.Name = "Condition_grpBx_RainFall";
    	this.Condition_grpBx_RainFall.Size = new System.Drawing.Size(227, 132);
    	this.Condition_grpBx_RainFall.TabIndex = 4;
    	this.Condition_grpBx_RainFall.TabStop = false;
    	this.Condition_grpBx_RainFall.Text = "Rain Fall Today";
    	// 
    	// lbl_Condition_precip_today_in
    	// 
    	this.lbl_Condition_precip_today_in.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_precip_today_in.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_precip_today_in.Location = new System.Drawing.Point(7, 16);
    	this.lbl_Condition_precip_today_in.Name = "lbl_Condition_precip_today_in";
    	this.lbl_Condition_precip_today_in.Size = new System.Drawing.Size(211, 30);
    	this.lbl_Condition_precip_today_in.TabIndex = 0;
    	this.lbl_Condition_precip_today_in.Text = "\"precip_today_in\": \"0.00\".";
    	// 
    	// lbl_Condition_precip_1hr
    	// 
    	this.lbl_Condition_precip_1hr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_precip_1hr.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_precip_1hr.Location = new System.Drawing.Point(6, 55);
    	this.lbl_Condition_precip_1hr.Name = "lbl_Condition_precip_1hr";
    	this.lbl_Condition_precip_1hr.Size = new System.Drawing.Size(211, 30);
    	this.lbl_Condition_precip_1hr.TabIndex = 0;
    	this.lbl_Condition_precip_1hr.Text = "\"precip_1hr_string\": \"0.00 in ( 0 mm)\"";
    	// 
    	// lbl_Condition_dewpoint
    	// 
    	this.lbl_Condition_dewpoint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_dewpoint.Font = new System.Drawing.Font("Corbel", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_dewpoint.Location = new System.Drawing.Point(7, 97);
    	this.lbl_Condition_dewpoint.Name = "lbl_Condition_dewpoint";
    	this.lbl_Condition_dewpoint.Size = new System.Drawing.Size(211, 30);
    	this.lbl_Condition_dewpoint.TabIndex = 0;
    	this.lbl_Condition_dewpoint.Text = "\"dewpoint_string\": \"54 F (12 C)\"";
    	this.lbl_Condition_dewpoint.Click += new System.EventHandler(this.lblN1_Click);
    	// 
    	// Condition_grpBx_Temp
    	// 
    	this.Condition_grpBx_Temp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.Condition_grpBx_Temp.BackColor = System.Drawing.Color.Transparent;
    	this.Condition_grpBx_Temp.Controls.Add(this.lbl_Condition_temp);
    	this.Condition_grpBx_Temp.Controls.Add(this.lbl_Condition_Day);
    	this.Condition_grpBx_Temp.Controls.Add(this.lbl_Condition_humidity);
    	this.Condition_grpBx_Temp.Controls.Add(this.lbl_Condition_feels);
    	this.Condition_grpBx_Temp.Location = new System.Drawing.Point(137, 3);
    	this.Condition_grpBx_Temp.Name = "Condition_grpBx_Temp";
    	this.Condition_grpBx_Temp.Size = new System.Drawing.Size(284, 331);
    	this.Condition_grpBx_Temp.TabIndex = 3;
    	this.Condition_grpBx_Temp.TabStop = false;
    	this.Condition_grpBx_Temp.Text = "Weather Report";
    	// 
    	// lbl_Condition_temp
    	// 
    	this.lbl_Condition_temp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_temp.Font = new System.Drawing.Font("Corbel", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_temp.Location = new System.Drawing.Point(30, 53);
    	this.lbl_Condition_temp.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.lbl_Condition_temp.Name = "lbl_Condition_temp";
    	this.lbl_Condition_temp.Size = new System.Drawing.Size(241, 100);
    	this.lbl_Condition_temp.TabIndex = 2;
    	this.lbl_Condition_temp.Text = "temp_f: 66.3";
    	this.lbl_Condition_temp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	// 
    	// lbl_Condition_Day
    	// 
    	this.lbl_Condition_Day.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_Day.Font = new System.Drawing.Font("Corbel", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_Day.Location = new System.Drawing.Point(6, 16);
    	this.lbl_Condition_Day.Name = "lbl_Condition_Day";
    	this.lbl_Condition_Day.Size = new System.Drawing.Size(267, 35);
    	this.lbl_Condition_Day.TabIndex = 0;
    	this.lbl_Condition_Day.Text = "Day1";
    	this.lbl_Condition_Day.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	this.lbl_Condition_Day.Click += new System.EventHandler(this.lblD1_Click);
    	// 
    	// lbl_Condition_humidity
    	// 
    	this.lbl_Condition_humidity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_humidity.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_humidity.Location = new System.Drawing.Point(6, 187);
    	this.lbl_Condition_humidity.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.lbl_Condition_humidity.Name = "lbl_Condition_humidity";
    	this.lbl_Condition_humidity.Size = new System.Drawing.Size(231, 25);
    	this.lbl_Condition_humidity.TabIndex = 2;
    	this.lbl_Condition_humidity.Text = "Humidity: 65%";
    	this.lbl_Condition_humidity.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	// 
    	// lbl_Condition_feels
    	// 
    	this.lbl_Condition_feels.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_feels.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_feels.Location = new System.Drawing.Point(6, 156);
    	this.lbl_Condition_feels.Name = "lbl_Condition_feels";
    	this.lbl_Condition_feels.Size = new System.Drawing.Size(231, 27);
    	this.lbl_Condition_feels.TabIndex = 0;
    	this.lbl_Condition_feels.Text = "\"feelslike_string\": 66.3 F \"";
    	this.lbl_Condition_feels.TextAlign = System.Drawing.ContentAlignment.TopCenter;
    	this.lbl_Condition_feels.Click += new System.EventHandler(this.lbl_Condition_feels_Click);
    	// 
    	// lbl_Condition_UV
    	// 
    	this.lbl_Condition_UV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_UV.AutoSize = true;
    	this.lbl_Condition_UV.BackColor = System.Drawing.Color.Transparent;
    	this.lbl_Condition_UV.Location = new System.Drawing.Point(35, 194);
    	this.lbl_Condition_UV.Name = "lbl_Condition_UV";
    	this.lbl_Condition_UV.Size = new System.Drawing.Size(54, 13);
    	this.lbl_Condition_UV.TabIndex = 0;
    	this.lbl_Condition_UV.Text = "\"UV\": \"5\"";
    	this.lbl_Condition_UV.Click += new System.EventHandler(this.lbl_Condition_UV_Click);
    	// 
    	// picbox_conditions_icon
    	// 
    	this.picbox_conditions_icon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.picbox_conditions_icon.BackColor = System.Drawing.Color.Transparent;
    	this.picbox_conditions_icon.Location = new System.Drawing.Point(9, 3);
    	this.picbox_conditions_icon.Name = "picbox_conditions_icon";
    	this.picbox_conditions_icon.Size = new System.Drawing.Size(113, 97);
    	this.picbox_conditions_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
    	this.picbox_conditions_icon.TabIndex = 1;
    	this.picbox_conditions_icon.TabStop = false;
    	this.picbox_conditions_icon.Click += new System.EventHandler(this.picboxD1_Click);
    	// 
    	// lbl_Condition_Weather
    	// 
    	this.lbl_Condition_Weather.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_Weather.BackColor = System.Drawing.Color.Transparent;
    	this.lbl_Condition_Weather.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_Weather.Location = new System.Drawing.Point(9, 111);
    	this.lbl_Condition_Weather.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.lbl_Condition_Weather.Name = "lbl_Condition_Weather";
    	this.lbl_Condition_Weather.Size = new System.Drawing.Size(113, 42);
    	this.lbl_Condition_Weather.TabIndex = 2;
    	this.lbl_Condition_Weather.Text = "Weather: Partly Cloudy";
    	this.lbl_Condition_Weather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// lbl_Condition_visibleMi
    	// 
    	this.lbl_Condition_visibleMi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.lbl_Condition_visibleMi.BackColor = System.Drawing.Color.Transparent;
    	this.lbl_Condition_visibleMi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.lbl_Condition_visibleMi.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
    	this.lbl_Condition_visibleMi.Location = new System.Drawing.Point(400, 346);
    	this.lbl_Condition_visibleMi.Name = "lbl_Condition_visibleMi";
    	this.lbl_Condition_visibleMi.Size = new System.Drawing.Size(146, 121);
    	this.lbl_Condition_visibleMi.TabIndex = 0;
    	this.lbl_Condition_visibleMi.Text = "\"visibility_mi\": \"10.0\"";
    	this.lbl_Condition_visibleMi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// tabPage10Day
    	// 
    	this.tabPage10Day.AutoScroll = true;
    	this.tabPage10Day.BackColor = System.Drawing.SystemColors.Control;
    	this.tabPage10Day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
    	this.tabPage10Day.Controls.Add(this.panel2);
    	this.tabPage10Day.Location = new System.Drawing.Point(4, 32);
    	this.tabPage10Day.Name = "tabPage10Day";
    	this.tabPage10Day.Size = new System.Drawing.Size(1221, 732);
    	this.tabPage10Day.TabIndex = 0;
    	this.tabPage10Day.Text = "10 Day Forecast";
    	this.tabPage10Day.Visible = false;
    	// 
    	// panel2
    	// 
    	this.panel2.BackgroundImage = global::SharpWeather.weatherIcons.Cloudy_1;
    	this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
    	this.panel2.Controls.Add(this.flowLayoutPanel1);
    	this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
    	this.panel2.Location = new System.Drawing.Point(0, 0);
    	this.panel2.Name = "panel2";
    	this.panel2.Size = new System.Drawing.Size(1221, 732);
    	this.panel2.TabIndex = 9;
    	// 
    	// flowLayoutPanel1
    	// 
    	this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.flowLayoutPanel1.AutoScroll = true;
    	this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
    	this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
    	this.flowLayoutPanel1.Controls.Add(this.panel5);
    	this.flowLayoutPanel1.Controls.Add(this.panel6);
    	this.flowLayoutPanel1.Controls.Add(this.panel7);
    	this.flowLayoutPanel1.Controls.Add(this.panel9);
    	this.flowLayoutPanel1.Controls.Add(this.panel12);
    	this.flowLayoutPanel1.Controls.Add(this.panel10);
    	this.flowLayoutPanel1.Controls.Add(this.panel13);
    	this.flowLayoutPanel1.Controls.Add(this.panel14);
    	this.flowLayoutPanel1.Controls.Add(this.panel11);
    	this.flowLayoutPanel1.Controls.Add(this.DayPanel8);
    	this.flowLayoutPanel1.Location = new System.Drawing.Point(4, 3);
    	this.flowLayoutPanel1.Name = "flowLayoutPanel1";
    	this.flowLayoutPanel1.Size = new System.Drawing.Size(1221, 732);
    	this.flowLayoutPanel1.TabIndex = 4;
    	this.flowLayoutPanel1.WrapContents = false;
    	// 
    	// panel5
    	// 
    	this.panel5.AutoScroll = true;
    	this.panel5.BackColor = System.Drawing.Color.Transparent;
    	this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel5.Controls.Add(this.label1);
    	this.panel5.Controls.Add(this.label4);
    	this.panel5.Controls.Add(this.label7);
    	this.panel5.Controls.Add(this.day1Pic);
    	this.panel5.Controls.Add(this.label57);
    	this.panel5.Controls.Add(this.label56);
    	this.panel5.Controls.Add(this.label55);
    	this.panel5.Controls.Add(this.label54);
    	this.panel5.Controls.Add(this.label25);
    	this.panel5.Controls.Add(this.label24);
    	this.panel5.Controls.Add(this.label19);
    	this.panel5.Controls.Add(this.label18);
    	this.panel5.Controls.Add(this.label13);
    	this.panel5.Controls.Add(this.label12);
    	this.panel5.Controls.Add(this.day1Desc);
    	this.panel5.Controls.Add(this.day1Label);
    	this.panel5.Location = new System.Drawing.Point(10, 3);
    	this.panel5.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
    	this.panel5.Name = "panel5";
    	this.panel5.Size = new System.Drawing.Size(289, 609);
    	this.panel5.TabIndex = 6;
    	// 
    	// label1
    	// 
    	this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.label1.Location = new System.Drawing.Point(202, 120);
    	this.label1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.label1.Name = "label1";
    	this.label1.Size = new System.Drawing.Size(29, 15);
    	this.label1.TabIndex = 3;
    	this.label1.Text = "HI";
    	this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// label4
    	// 
    	this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.label4.Location = new System.Drawing.Point(202, 149);
    	this.label4.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.label4.Name = "label4";
    	this.label4.Size = new System.Drawing.Size(29, 15);
    	this.label4.TabIndex = 4;
    	this.label4.Text = "LOW";
    	this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// label7
    	// 
    	this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.label7.Location = new System.Drawing.Point(202, 132);
    	this.label7.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
    	this.label7.Name = "label7";
    	this.label7.Size = new System.Drawing.Size(29, 15);
    	this.label7.TabIndex = 5;
    	this.label7.Text = "-----------";
    	this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// day1Pic
    	// 
    	this.day1Pic.Location = new System.Drawing.Point(3, 28);
    	this.day1Pic.Name = "day1Pic";
    	this.day1Pic.Size = new System.Drawing.Size(100, 50);
    	this.day1Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.day1Pic.TabIndex = 1;
    	this.day1Pic.TabStop = false;
    	// 
    	// label57
    	// 
    	this.label57.AutoSize = true;
    	this.label57.Location = new System.Drawing.Point(6, 423);
    	this.label57.Name = "label57";
    	this.label57.Size = new System.Drawing.Size(63, 13);
    	this.label57.TabIndex = 0;
    	this.label57.Text = "minHumidity";
    	// 
    	// label56
    	// 
    	this.label56.AutoSize = true;
    	this.label56.Location = new System.Drawing.Point(7, 397);
    	this.label56.Name = "label56";
    	this.label56.Size = new System.Drawing.Size(66, 13);
    	this.label56.TabIndex = 0;
    	this.label56.Text = "maxHumidity";
    	// 
    	// label55
    	// 
    	this.label55.AutoSize = true;
    	this.label55.Location = new System.Drawing.Point(6, 374);
    	this.label55.Name = "label55";
    	this.label55.Size = new System.Drawing.Size(65, 13);
    	this.label55.TabIndex = 0;
    	this.label55.Text = "avgHumidity";
    	// 
    	// label54
    	// 
    	this.label54.AutoSize = true;
    	this.label54.Location = new System.Drawing.Point(6, 348);
    	this.label54.Name = "label54";
    	this.label54.Size = new System.Drawing.Size(88, 13);
    	this.label54.TabIndex = 0;
    	this.label54.Text = "avgWinddegrees";
    	// 
    	// label25
    	// 
    	this.label25.AutoSize = true;
    	this.label25.Location = new System.Drawing.Point(6, 323);
    	this.label25.Name = "label25";
    	this.label25.Size = new System.Drawing.Size(61, 13);
    	this.label25.TabIndex = 0;
    	this.label25.Text = "avgWinddir";
    	// 
    	// label24
    	// 
    	this.label24.AutoSize = true;
    	this.label24.Location = new System.Drawing.Point(6, 297);
    	this.label24.Name = "label24";
    	this.label24.Size = new System.Drawing.Size(73, 13);
    	this.label24.TabIndex = 0;
    	this.label24.Text = "avgWindmph ";
    	// 
    	// label19
    	// 
    	this.label19.AutoSize = true;
    	this.label19.Location = new System.Drawing.Point(6, 270);
    	this.label19.Name = "label19";
    	this.label19.Size = new System.Drawing.Size(62, 13);
    	this.label19.TabIndex = 0;
    	this.label19.Text = "maxWinddir";
    	// 
    	// label18
    	// 
    	this.label18.AutoSize = true;
    	this.label18.Location = new System.Drawing.Point(3, 242);
    	this.label18.Name = "label18";
    	this.label18.Size = new System.Drawing.Size(71, 13);
    	this.label18.TabIndex = 0;
    	this.label18.Text = "maxWindmph";
    	// 
    	// label13
    	// 
    	this.label13.AutoSize = true;
    	this.label13.Location = new System.Drawing.Point(3, 211);
    	this.label13.Name = "label13";
    	this.label13.Size = new System.Drawing.Size(74, 13);
    	this.label13.TabIndex = 0;
    	this.label13.Text = "Snow (inches)";
    	// 
    	// label12
    	// 
    	this.label12.AutoSize = true;
    	this.label12.Location = new System.Drawing.Point(3, 177);
    	this.label12.Name = "label12";
    	this.label12.Size = new System.Drawing.Size(69, 13);
    	this.label12.TabIndex = 0;
    	this.label12.Text = "Rain (inches)";
    	// 
    	// day1Desc
    	// 
    	this.day1Desc.Location = new System.Drawing.Point(111, 22);
    	this.day1Desc.Name = "day1Desc";
    	this.day1Desc.Size = new System.Drawing.Size(173, 56);
    	this.day1Desc.TabIndex = 0;
    	this.day1Desc.Text = "Day Conditions";
    	// 
    	// day1Label
    	// 
    	this.day1Label.AutoSize = true;
    	this.day1Label.Location = new System.Drawing.Point(3, 12);
    	this.day1Label.Name = "day1Label";
    	this.day1Label.Size = new System.Drawing.Size(32, 13);
    	this.day1Label.TabIndex = 0;
    	this.day1Label.Text = "Day1";
    	// 
    	// panel6
    	// 
    	this.panel6.AutoScroll = true;
    	this.panel6.BackColor = System.Drawing.Color.Transparent;
    	this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel6.Controls.Add(this.night2Pic);
    	this.panel6.Controls.Add(this.day2Pic);
    	this.panel6.Controls.Add(this.night2cop);
    	this.panel6.Controls.Add(this.day2cop);
    	this.panel6.Controls.Add(this.Night2Desc);
    	this.panel6.Controls.Add(this.day2Desc);
    	this.panel6.Controls.Add(this.night2Label);
    	this.panel6.Controls.Add(this.day2Label);
    	this.panel6.Location = new System.Drawing.Point(312, 3);
    	this.panel6.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
    	this.panel6.Name = "panel6";
    	this.panel6.Size = new System.Drawing.Size(289, 609);
    	this.panel6.TabIndex = 7;
    	// 
    	// night2Pic
    	// 
    	this.night2Pic.Location = new System.Drawing.Point(3, 205);
    	this.night2Pic.Name = "night2Pic";
    	this.night2Pic.Size = new System.Drawing.Size(100, 50);
    	this.night2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.night2Pic.TabIndex = 1;
    	this.night2Pic.TabStop = false;
    	// 
    	// day2Pic
    	// 
    	this.day2Pic.Location = new System.Drawing.Point(3, 28);
    	this.day2Pic.Name = "day2Pic";
    	this.day2Pic.Size = new System.Drawing.Size(100, 50);
    	this.day2Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.day2Pic.TabIndex = 1;
    	this.day2Pic.TabStop = false;
    	// 
    	// night2cop
    	// 
    	this.night2cop.AutoSize = true;
    	this.night2cop.Location = new System.Drawing.Point(3, 274);
    	this.night2cop.Name = "night2cop";
    	this.night2cop.Size = new System.Drawing.Size(124, 13);
    	this.night2cop.TabIndex = 0;
    	this.night2cop.Text = "Chance of Precepitation:";
    	// 
    	// day2cop
    	// 
    	this.day2cop.AutoSize = true;
    	this.day2cop.Location = new System.Drawing.Point(3, 93);
    	this.day2cop.Name = "day2cop";
    	this.day2cop.Size = new System.Drawing.Size(124, 13);
    	this.day2cop.TabIndex = 0;
    	this.day2cop.Text = "Chance of Precepitation:";
    	// 
    	// Night2Desc
    	// 
    	this.Night2Desc.Location = new System.Drawing.Point(109, 205);
    	this.Night2Desc.Name = "Night2Desc";
    	this.Night2Desc.Size = new System.Drawing.Size(173, 56);
    	this.Night2Desc.TabIndex = 0;
    	this.Night2Desc.Text = "Night one Desc.";
    	// 
    	// day2Desc
    	// 
    	this.day2Desc.Location = new System.Drawing.Point(109, 28);
    	this.day2Desc.Name = "day2Desc";
    	this.day2Desc.Size = new System.Drawing.Size(173, 56);
    	this.day2Desc.TabIndex = 0;
    	this.day2Desc.Text = "Day one Desc.";
    	// 
    	// night2Label
    	// 
    	this.night2Label.AutoSize = true;
    	this.night2Label.Location = new System.Drawing.Point(3, 189);
    	this.night2Label.Name = "night2Label";
    	this.night2Label.Size = new System.Drawing.Size(38, 13);
    	this.night2Label.TabIndex = 0;
    	this.night2Label.Text = "Night2";
    	// 
    	// day2Label
    	// 
    	this.day2Label.AutoSize = true;
    	this.day2Label.Location = new System.Drawing.Point(3, 12);
    	this.day2Label.Name = "day2Label";
    	this.day2Label.Size = new System.Drawing.Size(32, 13);
    	this.day2Label.TabIndex = 0;
    	this.day2Label.Text = "Day2";
    	// 
    	// panel7
    	// 
    	this.panel7.AutoScroll = true;
    	this.panel7.BackColor = System.Drawing.Color.Transparent;
    	this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel7.Controls.Add(this.night3Pic);
    	this.panel7.Controls.Add(this.day3Pic);
    	this.panel7.Controls.Add(this.night3cop);
    	this.panel7.Controls.Add(this.day3cop);
    	this.panel7.Controls.Add(this.Night3Desc);
    	this.panel7.Controls.Add(this.day3Desc);
    	this.panel7.Controls.Add(this.night3Label);
    	this.panel7.Controls.Add(this.day3Label);
    	this.panel7.Location = new System.Drawing.Point(614, 3);
    	this.panel7.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
    	this.panel7.Name = "panel7";
    	this.panel7.Size = new System.Drawing.Size(289, 609);
    	this.panel7.TabIndex = 8;
    	// 
    	// night3Pic
    	// 
    	this.night3Pic.Location = new System.Drawing.Point(0, 205);
    	this.night3Pic.Name = "night3Pic";
    	this.night3Pic.Size = new System.Drawing.Size(100, 50);
    	this.night3Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.night3Pic.TabIndex = 1;
    	this.night3Pic.TabStop = false;
    	// 
    	// day3Pic
    	// 
    	this.day3Pic.Location = new System.Drawing.Point(3, 28);
    	this.day3Pic.Name = "day3Pic";
    	this.day3Pic.Size = new System.Drawing.Size(100, 50);
    	this.day3Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.day3Pic.TabIndex = 1;
    	this.day3Pic.TabStop = false;
    	// 
    	// night3cop
    	// 
    	this.night3cop.AutoSize = true;
    	this.night3cop.Location = new System.Drawing.Point(0, 270);
    	this.night3cop.Name = "night3cop";
    	this.night3cop.Size = new System.Drawing.Size(124, 13);
    	this.night3cop.TabIndex = 0;
    	this.night3cop.Text = "Chance of Precepitation:";
    	// 
    	// day3cop
    	// 
    	this.day3cop.AutoSize = true;
    	this.day3cop.Location = new System.Drawing.Point(3, 93);
    	this.day3cop.Name = "day3cop";
    	this.day3cop.Size = new System.Drawing.Size(124, 13);
    	this.day3cop.TabIndex = 0;
    	this.day3cop.Text = "Chance of Precepitation:";
    	// 
    	// Night3Desc
    	// 
    	this.Night3Desc.Location = new System.Drawing.Point(103, 205);
    	this.Night3Desc.Name = "Night3Desc";
    	this.Night3Desc.Size = new System.Drawing.Size(173, 56);
    	this.Night3Desc.TabIndex = 0;
    	this.Night3Desc.Text = "Night one Desc.";
    	// 
    	// day3Desc
    	// 
    	this.day3Desc.Location = new System.Drawing.Point(107, 28);
    	this.day3Desc.Name = "day3Desc";
    	this.day3Desc.Size = new System.Drawing.Size(173, 56);
    	this.day3Desc.TabIndex = 0;
    	this.day3Desc.Text = "Day one Desc.";
    	// 
    	// night3Label
    	// 
    	this.night3Label.AutoSize = true;
    	this.night3Label.Location = new System.Drawing.Point(0, 189);
    	this.night3Label.Name = "night3Label";
    	this.night3Label.Size = new System.Drawing.Size(38, 13);
    	this.night3Label.TabIndex = 0;
    	this.night3Label.Text = "Night3";
    	// 
    	// day3Label
    	// 
    	this.day3Label.AutoSize = true;
    	this.day3Label.Location = new System.Drawing.Point(3, 12);
    	this.day3Label.Name = "day3Label";
    	this.day3Label.Size = new System.Drawing.Size(32, 13);
    	this.day3Label.TabIndex = 0;
    	this.day3Label.Text = "Day3";
    	// 
    	// panel9
    	// 
    	this.panel9.AutoScroll = true;
    	this.panel9.AutoScrollMinSize = new System.Drawing.Size(100, 100);
    	this.panel9.BackColor = System.Drawing.Color.Transparent;
    	this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel9.Controls.Add(this.night4Pic);
    	this.panel9.Controls.Add(this.day4Pic);
    	this.panel9.Controls.Add(this.night4cop);
    	this.panel9.Controls.Add(this.day4cop);
    	this.panel9.Controls.Add(this.Night4Desc);
    	this.panel9.Controls.Add(this.day4Desc);
    	this.panel9.Controls.Add(this.night4Label);
    	this.panel9.Controls.Add(this.day4Label);
    	this.panel9.Location = new System.Drawing.Point(916, 3);
    	this.panel9.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
    	this.panel9.Name = "panel9";
    	this.panel9.Size = new System.Drawing.Size(289, 609);
    	this.panel9.TabIndex = 15;
    	// 
    	// night4Pic
    	// 
    	this.night4Pic.Location = new System.Drawing.Point(0, 205);
    	this.night4Pic.Name = "night4Pic";
    	this.night4Pic.Size = new System.Drawing.Size(100, 50);
    	this.night4Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.night4Pic.TabIndex = 1;
    	this.night4Pic.TabStop = false;
    	// 
    	// day4Pic
    	// 
    	this.day4Pic.Location = new System.Drawing.Point(0, 28);
    	this.day4Pic.Name = "day4Pic";
    	this.day4Pic.Size = new System.Drawing.Size(100, 50);
    	this.day4Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.day4Pic.TabIndex = 1;
    	this.day4Pic.TabStop = false;
    	// 
    	// night4cop
    	// 
    	this.night4cop.AutoSize = true;
    	this.night4cop.Location = new System.Drawing.Point(0, 270);
    	this.night4cop.Name = "night4cop";
    	this.night4cop.Size = new System.Drawing.Size(124, 13);
    	this.night4cop.TabIndex = 0;
    	this.night4cop.Text = "Chance of Precepitation:";
    	// 
    	// day4cop
    	// 
    	this.day4cop.AutoSize = true;
    	this.day4cop.Location = new System.Drawing.Point(3, 93);
    	this.day4cop.Name = "day4cop";
    	this.day4cop.Size = new System.Drawing.Size(124, 13);
    	this.day4cop.TabIndex = 0;
    	this.day4cop.Text = "Chance of Precepitation:";
    	// 
    	// Night4Desc
    	// 
    	this.Night4Desc.Location = new System.Drawing.Point(105, 199);
    	this.Night4Desc.Name = "Night4Desc";
    	this.Night4Desc.Size = new System.Drawing.Size(173, 56);
    	this.Night4Desc.TabIndex = 0;
    	this.Night4Desc.Text = "Night one Desc.";
    	// 
    	// day4Desc
    	// 
    	this.day4Desc.Location = new System.Drawing.Point(106, 28);
    	this.day4Desc.Name = "day4Desc";
    	this.day4Desc.Size = new System.Drawing.Size(173, 56);
    	this.day4Desc.TabIndex = 0;
    	this.day4Desc.Text = "Day one Desc.";
    	// 
    	// night4Label
    	// 
    	this.night4Label.AutoSize = true;
    	this.night4Label.Location = new System.Drawing.Point(0, 189);
    	this.night4Label.Name = "night4Label";
    	this.night4Label.Size = new System.Drawing.Size(38, 13);
    	this.night4Label.TabIndex = 0;
    	this.night4Label.Text = "Night4";
    	// 
    	// day4Label
    	// 
    	this.day4Label.AutoSize = true;
    	this.day4Label.Location = new System.Drawing.Point(3, 12);
    	this.day4Label.Name = "day4Label";
    	this.day4Label.Size = new System.Drawing.Size(32, 13);
    	this.day4Label.TabIndex = 0;
    	this.day4Label.Text = "Day4";
    	// 
    	// panel12
    	// 
    	this.panel12.AutoScroll = true;
    	this.panel12.BackColor = System.Drawing.Color.Transparent;
    	this.panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel12.Controls.Add(this.night5Pic);
    	this.panel12.Controls.Add(this.day5Pic);
    	this.panel12.Controls.Add(this.night5cop);
    	this.panel12.Controls.Add(this.day5cop);
    	this.panel12.Controls.Add(this.Night5Desc);
    	this.panel12.Controls.Add(this.day5Desc);
    	this.panel12.Controls.Add(this.night5Label);
    	this.panel12.Controls.Add(this.day5Label);
    	this.panel12.Location = new System.Drawing.Point(1218, 3);
    	this.panel12.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
    	this.panel12.Name = "panel12";
    	this.panel12.Size = new System.Drawing.Size(289, 609);
    	this.panel12.TabIndex = 14;
    	// 
    	// night5Pic
    	// 
    	this.night5Pic.Location = new System.Drawing.Point(3, 205);
    	this.night5Pic.Name = "night5Pic";
    	this.night5Pic.Size = new System.Drawing.Size(100, 50);
    	this.night5Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.night5Pic.TabIndex = 1;
    	this.night5Pic.TabStop = false;
    	// 
    	// day5Pic
    	// 
    	this.day5Pic.Location = new System.Drawing.Point(0, 28);
    	this.day5Pic.Name = "day5Pic";
    	this.day5Pic.Size = new System.Drawing.Size(100, 50);
    	this.day5Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.day5Pic.TabIndex = 1;
    	this.day5Pic.TabStop = false;
    	// 
    	// night5cop
    	// 
    	this.night5cop.AutoSize = true;
    	this.night5cop.Location = new System.Drawing.Point(0, 270);
    	this.night5cop.Name = "night5cop";
    	this.night5cop.Size = new System.Drawing.Size(124, 13);
    	this.night5cop.TabIndex = 0;
    	this.night5cop.Text = "Chance of Precepitation:";
    	// 
    	// day5cop
    	// 
    	this.day5cop.AutoSize = true;
    	this.day5cop.Location = new System.Drawing.Point(3, 93);
    	this.day5cop.Name = "day5cop";
    	this.day5cop.Size = new System.Drawing.Size(124, 13);
    	this.day5cop.TabIndex = 0;
    	this.day5cop.Text = "Chance of Precepitation:";
    	// 
    	// Night5Desc
    	// 
    	this.Night5Desc.Location = new System.Drawing.Point(106, 205);
    	this.Night5Desc.Name = "Night5Desc";
    	this.Night5Desc.Size = new System.Drawing.Size(173, 56);
    	this.Night5Desc.TabIndex = 0;
    	this.Night5Desc.Text = "Night one Desc.";
    	// 
    	// day5Desc
    	// 
    	this.day5Desc.Location = new System.Drawing.Point(106, 28);
    	this.day5Desc.Name = "day5Desc";
    	this.day5Desc.Size = new System.Drawing.Size(173, 56);
    	this.day5Desc.TabIndex = 0;
    	this.day5Desc.Text = "Day one Desc.";
    	// 
    	// night5Label
    	// 
    	this.night5Label.AutoSize = true;
    	this.night5Label.Location = new System.Drawing.Point(3, 189);
    	this.night5Label.Name = "night5Label";
    	this.night5Label.Size = new System.Drawing.Size(38, 13);
    	this.night5Label.TabIndex = 0;
    	this.night5Label.Text = "Night5";
    	// 
    	// day5Label
    	// 
    	this.day5Label.AutoSize = true;
    	this.day5Label.Location = new System.Drawing.Point(3, 12);
    	this.day5Label.Name = "day5Label";
    	this.day5Label.Size = new System.Drawing.Size(32, 13);
    	this.day5Label.TabIndex = 0;
    	this.day5Label.Text = "Day5";
    	// 
    	// panel10
    	// 
    	this.panel10.AutoScroll = true;
    	this.panel10.BackColor = System.Drawing.Color.Transparent;
    	this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel10.Controls.Add(this.night6Pic);
    	this.panel10.Controls.Add(this.day6Pic);
    	this.panel10.Controls.Add(this.night6cop);
    	this.panel10.Controls.Add(this.day6cop);
    	this.panel10.Controls.Add(this.Night6Desc);
    	this.panel10.Controls.Add(this.day6Desc);
    	this.panel10.Controls.Add(this.night6Label);
    	this.panel10.Controls.Add(this.day6Label);
    	this.panel10.Location = new System.Drawing.Point(1520, 3);
    	this.panel10.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
    	this.panel10.Name = "panel10";
    	this.panel10.Size = new System.Drawing.Size(289, 609);
    	this.panel10.TabIndex = 12;
    	// 
    	// night6Pic
    	// 
    	this.night6Pic.Location = new System.Drawing.Point(0, 205);
    	this.night6Pic.Name = "night6Pic";
    	this.night6Pic.Size = new System.Drawing.Size(100, 50);
    	this.night6Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.night6Pic.TabIndex = 1;
    	this.night6Pic.TabStop = false;
    	// 
    	// day6Pic
    	// 
    	this.day6Pic.Location = new System.Drawing.Point(0, 28);
    	this.day6Pic.Name = "day6Pic";
    	this.day6Pic.Size = new System.Drawing.Size(100, 50);
    	this.day6Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.day6Pic.TabIndex = 1;
    	this.day6Pic.TabStop = false;
    	// 
    	// night6cop
    	// 
    	this.night6cop.AutoSize = true;
    	this.night6cop.Location = new System.Drawing.Point(0, 270);
    	this.night6cop.Name = "night6cop";
    	this.night6cop.Size = new System.Drawing.Size(124, 13);
    	this.night6cop.TabIndex = 0;
    	this.night6cop.Text = "Chance of Precepitation:";
    	// 
    	// day6cop
    	// 
    	this.day6cop.AutoSize = true;
    	this.day6cop.Location = new System.Drawing.Point(3, 93);
    	this.day6cop.Name = "day6cop";
    	this.day6cop.Size = new System.Drawing.Size(124, 13);
    	this.day6cop.TabIndex = 0;
    	this.day6cop.Text = "Chance of Precepitation:";
    	// 
    	// Night6Desc
    	// 
    	this.Night6Desc.Location = new System.Drawing.Point(102, 205);
    	this.Night6Desc.Name = "Night6Desc";
    	this.Night6Desc.Size = new System.Drawing.Size(173, 56);
    	this.Night6Desc.TabIndex = 0;
    	this.Night6Desc.Text = "Night one Desc.";
    	// 
    	// day6Desc
    	// 
    	this.day6Desc.Location = new System.Drawing.Point(106, 28);
    	this.day6Desc.Name = "day6Desc";
    	this.day6Desc.Size = new System.Drawing.Size(173, 56);
    	this.day6Desc.TabIndex = 0;
    	this.day6Desc.Text = "Day one Desc.";
    	// 
    	// night6Label
    	// 
    	this.night6Label.AutoSize = true;
    	this.night6Label.Location = new System.Drawing.Point(0, 189);
    	this.night6Label.Name = "night6Label";
    	this.night6Label.Size = new System.Drawing.Size(38, 13);
    	this.night6Label.TabIndex = 0;
    	this.night6Label.Text = "Night6";
    	// 
    	// day6Label
    	// 
    	this.day6Label.AutoSize = true;
    	this.day6Label.Location = new System.Drawing.Point(3, 12);
    	this.day6Label.Name = "day6Label";
    	this.day6Label.Size = new System.Drawing.Size(32, 13);
    	this.day6Label.TabIndex = 0;
    	this.day6Label.Text = "Day6";
    	// 
    	// panel13
    	// 
    	this.panel13.AutoScroll = true;
    	this.panel13.BackColor = System.Drawing.Color.Transparent;
    	this.panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel13.Controls.Add(this.night7Pic);
    	this.panel13.Controls.Add(this.day7Pic);
    	this.panel13.Controls.Add(this.night7cop);
    	this.panel13.Controls.Add(this.day7cop);
    	this.panel13.Controls.Add(this.Night7Desc);
    	this.panel13.Controls.Add(this.day7Desc);
    	this.panel13.Controls.Add(this.night7Label);
    	this.panel13.Controls.Add(this.day7Label);
    	this.panel13.Location = new System.Drawing.Point(1822, 3);
    	this.panel13.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
    	this.panel13.Name = "panel13";
    	this.panel13.Size = new System.Drawing.Size(289, 609);
    	this.panel13.TabIndex = 11;
    	// 
    	// night7Pic
    	// 
    	this.night7Pic.Location = new System.Drawing.Point(0, 205);
    	this.night7Pic.Name = "night7Pic";
    	this.night7Pic.Size = new System.Drawing.Size(100, 50);
    	this.night7Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.night7Pic.TabIndex = 1;
    	this.night7Pic.TabStop = false;
    	// 
    	// day7Pic
    	// 
    	this.day7Pic.Location = new System.Drawing.Point(0, 28);
    	this.day7Pic.Name = "day7Pic";
    	this.day7Pic.Size = new System.Drawing.Size(100, 50);
    	this.day7Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.day7Pic.TabIndex = 1;
    	this.day7Pic.TabStop = false;
    	// 
    	// night7cop
    	// 
    	this.night7cop.AutoSize = true;
    	this.night7cop.Location = new System.Drawing.Point(0, 270);
    	this.night7cop.Name = "night7cop";
    	this.night7cop.Size = new System.Drawing.Size(124, 13);
    	this.night7cop.TabIndex = 0;
    	this.night7cop.Text = "Chance of Precepitation:";
    	// 
    	// day7cop
    	// 
    	this.day7cop.AutoSize = true;
    	this.day7cop.Location = new System.Drawing.Point(0, 93);
    	this.day7cop.Name = "day7cop";
    	this.day7cop.Size = new System.Drawing.Size(124, 13);
    	this.day7cop.TabIndex = 0;
    	this.day7cop.Text = "Chance of Precepitation:";
    	// 
    	// Night7Desc
    	// 
    	this.Night7Desc.Location = new System.Drawing.Point(103, 205);
    	this.Night7Desc.Name = "Night7Desc";
    	this.Night7Desc.Size = new System.Drawing.Size(173, 56);
    	this.Night7Desc.TabIndex = 0;
    	this.Night7Desc.Text = "Night one Desc.";
    	// 
    	// day7Desc
    	// 
    	this.day7Desc.Location = new System.Drawing.Point(106, 28);
    	this.day7Desc.Name = "day7Desc";
    	this.day7Desc.Size = new System.Drawing.Size(173, 56);
    	this.day7Desc.TabIndex = 0;
    	this.day7Desc.Text = "Day one Desc.";
    	// 
    	// night7Label
    	// 
    	this.night7Label.AutoSize = true;
    	this.night7Label.Location = new System.Drawing.Point(0, 189);
    	this.night7Label.Name = "night7Label";
    	this.night7Label.Size = new System.Drawing.Size(38, 13);
    	this.night7Label.TabIndex = 0;
    	this.night7Label.Text = "Night7";
    	// 
    	// day7Label
    	// 
    	this.day7Label.AutoSize = true;
    	this.day7Label.Location = new System.Drawing.Point(3, 12);
    	this.day7Label.Name = "day7Label";
    	this.day7Label.Size = new System.Drawing.Size(32, 13);
    	this.day7Label.TabIndex = 0;
    	this.day7Label.Text = "Day7";
    	// 
    	// panel14
    	// 
    	this.panel14.AutoScroll = true;
    	this.panel14.BackColor = System.Drawing.Color.Transparent;
    	this.panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel14.Controls.Add(this.night8Pic);
    	this.panel14.Controls.Add(this.day8Pic);
    	this.panel14.Controls.Add(this.night8cop);
    	this.panel14.Controls.Add(this.day8cop);
    	this.panel14.Controls.Add(this.Night8Desc);
    	this.panel14.Controls.Add(this.day8Desc);
    	this.panel14.Controls.Add(this.night8Label);
    	this.panel14.Controls.Add(this.day8Label);
    	this.panel14.Location = new System.Drawing.Point(2124, 3);
    	this.panel14.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
    	this.panel14.Name = "panel14";
    	this.panel14.Size = new System.Drawing.Size(289, 609);
    	this.panel14.TabIndex = 13;
    	// 
    	// night8Pic
    	// 
    	this.night8Pic.Location = new System.Drawing.Point(2, 205);
    	this.night8Pic.Name = "night8Pic";
    	this.night8Pic.Size = new System.Drawing.Size(100, 50);
    	this.night8Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.night8Pic.TabIndex = 1;
    	this.night8Pic.TabStop = false;
    	// 
    	// day8Pic
    	// 
    	this.day8Pic.Location = new System.Drawing.Point(0, 28);
    	this.day8Pic.Name = "day8Pic";
    	this.day8Pic.Size = new System.Drawing.Size(100, 50);
    	this.day8Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.day8Pic.TabIndex = 1;
    	this.day8Pic.TabStop = false;
    	// 
    	// night8cop
    	// 
    	this.night8cop.AutoSize = true;
    	this.night8cop.Location = new System.Drawing.Point(0, 270);
    	this.night8cop.Name = "night8cop";
    	this.night8cop.Size = new System.Drawing.Size(124, 13);
    	this.night8cop.TabIndex = 0;
    	this.night8cop.Text = "Chance of Precepitation:";
    	// 
    	// day8cop
    	// 
    	this.day8cop.AutoSize = true;
    	this.day8cop.Location = new System.Drawing.Point(2, 93);
    	this.day8cop.Name = "day8cop";
    	this.day8cop.Size = new System.Drawing.Size(124, 13);
    	this.day8cop.TabIndex = 0;
    	this.day8cop.Text = "Chance of Precepitation:";
    	// 
    	// Night8Desc
    	// 
    	this.Night8Desc.Location = new System.Drawing.Point(105, 205);
    	this.Night8Desc.Name = "Night8Desc";
    	this.Night8Desc.Size = new System.Drawing.Size(173, 56);
    	this.Night8Desc.TabIndex = 0;
    	this.Night8Desc.Text = "Night one Desc.";
    	// 
    	// day8Desc
    	// 
    	this.day8Desc.Location = new System.Drawing.Point(106, 28);
    	this.day8Desc.Name = "day8Desc";
    	this.day8Desc.Size = new System.Drawing.Size(173, 56);
    	this.day8Desc.TabIndex = 0;
    	this.day8Desc.Text = "Day one Desc.";
    	// 
    	// night8Label
    	// 
    	this.night8Label.AutoSize = true;
    	this.night8Label.Location = new System.Drawing.Point(2, 189);
    	this.night8Label.Name = "night8Label";
    	this.night8Label.Size = new System.Drawing.Size(38, 13);
    	this.night8Label.TabIndex = 0;
    	this.night8Label.Text = "Night8";
    	// 
    	// day8Label
    	// 
    	this.day8Label.AutoSize = true;
    	this.day8Label.Location = new System.Drawing.Point(3, 12);
    	this.day8Label.Name = "day8Label";
    	this.day8Label.Size = new System.Drawing.Size(32, 13);
    	this.day8Label.TabIndex = 0;
    	this.day8Label.Text = "Day8";
    	// 
    	// panel11
    	// 
    	this.panel11.AutoScroll = true;
    	this.panel11.BackColor = System.Drawing.Color.Transparent;
    	this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.panel11.Controls.Add(this.night9Pic);
    	this.panel11.Controls.Add(this.day9Pic);
    	this.panel11.Controls.Add(this.night9cop);
    	this.panel11.Controls.Add(this.day9cop);
    	this.panel11.Controls.Add(this.Night9Desc);
    	this.panel11.Controls.Add(this.day9Desc);
    	this.panel11.Controls.Add(this.night9Label);
    	this.panel11.Controls.Add(this.day9Label);
    	this.panel11.Location = new System.Drawing.Point(2426, 3);
    	this.panel11.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
    	this.panel11.Name = "panel11";
    	this.panel11.Size = new System.Drawing.Size(289, 609);
    	this.panel11.TabIndex = 10;
    	// 
    	// night9Pic
    	// 
    	this.night9Pic.Location = new System.Drawing.Point(3, 211);
    	this.night9Pic.Name = "night9Pic";
    	this.night9Pic.Size = new System.Drawing.Size(100, 50);
    	this.night9Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.night9Pic.TabIndex = 1;
    	this.night9Pic.TabStop = false;
    	// 
    	// day9Pic
    	// 
    	this.day9Pic.Location = new System.Drawing.Point(0, 28);
    	this.day9Pic.Name = "day9Pic";
    	this.day9Pic.Size = new System.Drawing.Size(100, 50);
    	this.day9Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.day9Pic.TabIndex = 1;
    	this.day9Pic.TabStop = false;
    	// 
    	// night9cop
    	// 
    	this.night9cop.AutoSize = true;
    	this.night9cop.Location = new System.Drawing.Point(0, 276);
    	this.night9cop.Name = "night9cop";
    	this.night9cop.Size = new System.Drawing.Size(124, 13);
    	this.night9cop.TabIndex = 0;
    	this.night9cop.Text = "Chance of Precepitation:";
    	// 
    	// day9cop
    	// 
    	this.day9cop.AutoSize = true;
    	this.day9cop.Location = new System.Drawing.Point(0, 93);
    	this.day9cop.Name = "day9cop";
    	this.day9cop.Size = new System.Drawing.Size(124, 13);
    	this.day9cop.TabIndex = 0;
    	this.day9cop.Text = "Chance of Precepitation:";
    	// 
    	// Night9Desc
    	// 
    	this.Night9Desc.Location = new System.Drawing.Point(106, 211);
    	this.Night9Desc.Name = "Night9Desc";
    	this.Night9Desc.Size = new System.Drawing.Size(173, 56);
    	this.Night9Desc.TabIndex = 0;
    	this.Night9Desc.Text = "Night one Desc.";
    	// 
    	// day9Desc
    	// 
    	this.day9Desc.Location = new System.Drawing.Point(106, 28);
    	this.day9Desc.Name = "day9Desc";
    	this.day9Desc.Size = new System.Drawing.Size(173, 56);
    	this.day9Desc.TabIndex = 0;
    	this.day9Desc.Text = "Day one Desc.";
    	// 
    	// night9Label
    	// 
    	this.night9Label.AutoSize = true;
    	this.night9Label.Location = new System.Drawing.Point(3, 195);
    	this.night9Label.Name = "night9Label";
    	this.night9Label.Size = new System.Drawing.Size(38, 13);
    	this.night9Label.TabIndex = 0;
    	this.night9Label.Text = "Night9";
    	// 
    	// day9Label
    	// 
    	this.day9Label.AutoSize = true;
    	this.day9Label.Location = new System.Drawing.Point(3, 12);
    	this.day9Label.Name = "day9Label";
    	this.day9Label.Size = new System.Drawing.Size(32, 13);
    	this.day9Label.TabIndex = 0;
    	this.day9Label.Text = "Day9";
    	// 
    	// DayPanel8
    	// 
    	this.DayPanel8.AutoScroll = true;
    	this.DayPanel8.BackColor = System.Drawing.Color.Transparent;
    	this.DayPanel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
    	this.DayPanel8.Controls.Add(this.night10Pic);
    	this.DayPanel8.Controls.Add(this.day10Pic);
    	this.DayPanel8.Controls.Add(this.night10cop);
    	this.DayPanel8.Controls.Add(this.day10cop);
    	this.DayPanel8.Controls.Add(this.Night10Desc);
    	this.DayPanel8.Controls.Add(this.day10Desc);
    	this.DayPanel8.Controls.Add(this.night10Label);
    	this.DayPanel8.Controls.Add(this.day10Label);
    	this.DayPanel8.Location = new System.Drawing.Point(2728, 3);
    	this.DayPanel8.Margin = new System.Windows.Forms.Padding(3, 3, 10, 3);
    	this.DayPanel8.Name = "DayPanel8";
    	this.DayPanel8.Size = new System.Drawing.Size(289, 609);
    	this.DayPanel8.TabIndex = 9;
    	// 
    	// night10Pic
    	// 
    	this.night10Pic.Location = new System.Drawing.Point(3, 211);
    	this.night10Pic.Name = "night10Pic";
    	this.night10Pic.Size = new System.Drawing.Size(100, 50);
    	this.night10Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.night10Pic.TabIndex = 1;
    	this.night10Pic.TabStop = false;
    	// 
    	// day10Pic
    	// 
    	this.day10Pic.Location = new System.Drawing.Point(0, 28);
    	this.day10Pic.Name = "day10Pic";
    	this.day10Pic.Size = new System.Drawing.Size(100, 50);
    	this.day10Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.day10Pic.TabIndex = 1;
    	this.day10Pic.TabStop = false;
    	// 
    	// night10cop
    	// 
    	this.night10cop.AutoSize = true;
    	this.night10cop.Location = new System.Drawing.Point(0, 276);
    	this.night10cop.Name = "night10cop";
    	this.night10cop.Size = new System.Drawing.Size(124, 13);
    	this.night10cop.TabIndex = 0;
    	this.night10cop.Text = "Chance of Precepitation:";
    	// 
    	// day10cop
    	// 
    	this.day10cop.AutoSize = true;
    	this.day10cop.Location = new System.Drawing.Point(3, 93);
    	this.day10cop.Name = "day10cop";
    	this.day10cop.Size = new System.Drawing.Size(124, 13);
    	this.day10cop.TabIndex = 0;
    	this.day10cop.Text = "Chance of Precepitation:";
    	// 
    	// Night10Desc
    	// 
    	this.Night10Desc.Location = new System.Drawing.Point(106, 211);
    	this.Night10Desc.Name = "Night10Desc";
    	this.Night10Desc.Size = new System.Drawing.Size(173, 56);
    	this.Night10Desc.TabIndex = 0;
    	this.Night10Desc.Text = "Night one Desc.";
    	// 
    	// day10Desc
    	// 
    	this.day10Desc.Location = new System.Drawing.Point(106, 28);
    	this.day10Desc.Name = "day10Desc";
    	this.day10Desc.Size = new System.Drawing.Size(173, 56);
    	this.day10Desc.TabIndex = 0;
    	this.day10Desc.Text = "Day one Desc.";
    	// 
    	// night10Label
    	// 
    	this.night10Label.AutoSize = true;
    	this.night10Label.Location = new System.Drawing.Point(3, 195);
    	this.night10Label.Name = "night10Label";
    	this.night10Label.Size = new System.Drawing.Size(44, 13);
    	this.night10Label.TabIndex = 0;
    	this.night10Label.Text = "Night10";
    	// 
    	// day10Label
    	// 
    	this.day10Label.AutoSize = true;
    	this.day10Label.Location = new System.Drawing.Point(3, 12);
    	this.day10Label.Name = "day10Label";
    	this.day10Label.Size = new System.Drawing.Size(38, 13);
    	this.day10Label.TabIndex = 0;
    	this.day10Label.Text = "Day10";
    	// 
    	// metroTabPage4
    	// 
    	this.metroTabPage4.AutoScroll = true;
    	this.metroTabPage4.Controls.Add(this.alertPanel);
    	this.metroTabPage4.Location = new System.Drawing.Point(4, 32);
    	this.metroTabPage4.Name = "metroTabPage4";
    	this.metroTabPage4.Size = new System.Drawing.Size(1221, 732);
    	this.metroTabPage4.TabIndex = 3;
    	this.metroTabPage4.Text = "Alerts";
    	this.metroTabPage4.Visible = false;
    	// 
    	// alertPanel
    	// 
    	this.alertPanel.Dock = System.Windows.Forms.DockStyle.Fill;
    	this.alertPanel.Location = new System.Drawing.Point(0, 0);
    	this.alertPanel.Name = "alertPanel";
    	this.alertPanel.Size = new System.Drawing.Size(1221, 732);
    	this.alertPanel.TabIndex = 17;
    	// 
    	// tabPageBrowser
    	// 
    	this.tabPageBrowser.Controls.Add(this.comboBox1);
    	this.tabPageBrowser.Controls.Add(this.WEBmapbrowser);
    	this.tabPageBrowser.Location = new System.Drawing.Point(4, 32);
    	this.tabPageBrowser.Name = "tabPageBrowser";
    	this.tabPageBrowser.Size = new System.Drawing.Size(1221, 732);
    	this.tabPageBrowser.TabIndex = 1;
    	this.tabPageBrowser.Text = "WebBrowser";
    	this.tabPageBrowser.Visible = false;
    	// 
    	// comboBox1
    	// 
    	this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.comboBox1.FormattingEnabled = true;
    	this.comboBox1.Items.AddRange(new object[] {
			"http://api.wunderground.com/api/8390d409d9f2d532/radar/image.png?maxlat=50.00&max" +
				"lon=-67.00&minlat=23.00&minlon=-140.00&width=994&height=367&newmaps=0",
			"http://api.wunderground.com/api/8390d409d9f2d532/radar/image.png?maxlat=50.00&max" +
				"lon=-67.00&minlat=23.00&minlon=-140.00&width=994&height=367&newmaps=1"});
    	this.comboBox1.Location = new System.Drawing.Point(3, 15);
    	this.comboBox1.Name = "comboBox1";
    	this.comboBox1.Size = new System.Drawing.Size(1213, 21);
    	this.comboBox1.TabIndex = 6;
    	this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
    	this.comboBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBox1KeyPress);
    	// 
    	// WEBmapbrowser
    	// 
    	this.WEBmapbrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.WEBmapbrowser.Location = new System.Drawing.Point(3, 42);
    	this.WEBmapbrowser.MinimumSize = new System.Drawing.Size(20, 20);
    	this.WEBmapbrowser.Name = "WEBmapbrowser";
    	this.WEBmapbrowser.Size = new System.Drawing.Size(1213, 345);
    	this.WEBmapbrowser.TabIndex = 5;
    	this.WEBmapbrowser.Url = new System.Uri("http://api.wunderground.com/api/8390d409d9f2d532/radar/image.png?maxlat=50.00&max" +
		"lon=-67.00&minlat=23.00&minlon=-140.00&width=994&height=367&newmaps=0", System.UriKind.Absolute);
    	// 
    	// tabPageDebug
    	// 
    	this.tabPageDebug.Controls.Add(this.txtbox_debug_debug);
    	this.tabPageDebug.Controls.Add(this.metro);
    	this.tabPageDebug.Controls.Add(this.comboBox2);
    	this.tabPageDebug.Controls.Add(this.textboxMapHght);
    	this.tabPageDebug.Controls.Add(this.textboxMapWidth);
    	this.tabPageDebug.Controls.Add(this.metroButton1);
    	this.tabPageDebug.Controls.Add(this.textboxLon);
    	this.tabPageDebug.Controls.Add(this.textboxLat);
    	this.tabPageDebug.Controls.Add(this.label16);
    	this.tabPageDebug.Controls.Add(this.label3);
    	this.tabPageDebug.Controls.Add(this.label2);
    	this.tabPageDebug.Controls.Add(this.label15);
    	this.tabPageDebug.Location = new System.Drawing.Point(4, 32);
    	this.tabPageDebug.Name = "tabPageDebug";
    	this.tabPageDebug.Size = new System.Drawing.Size(1221, 732);
    	this.tabPageDebug.TabIndex = 4;
    	this.tabPageDebug.Text = "Debug";
    	this.tabPageDebug.Visible = false;
    	// 
    	// txtbox_debug_debug
    	// 
    	this.txtbox_debug_debug.Location = new System.Drawing.Point(285, 65);
    	this.txtbox_debug_debug.Multiline = true;
    	this.txtbox_debug_debug.Name = "txtbox_debug_debug";
    	this.txtbox_debug_debug.Size = new System.Drawing.Size(409, 368);
    	this.txtbox_debug_debug.TabIndex = 29;
    	this.txtbox_debug_debug.Text = "Debug Box";
    	// 
    	// metro
    	// 
    	this.metro.Location = new System.Drawing.Point(116, 167);
    	this.metro.Name = "metro";
    	this.metro.Size = new System.Drawing.Size(92, 23);
    	this.metro.TabIndex = 28;
    	this.metro.Text = "metroButton2";
    	// 
    	// comboBox2
    	// 
    	this.comboBox2.FormattingEnabled = true;
    	this.comboBox2.Location = new System.Drawing.Point(285, 23);
    	this.comboBox2.Name = "comboBox2";
    	this.comboBox2.Size = new System.Drawing.Size(656, 21);
    	this.comboBox2.TabIndex = 27;
    	// 
    	// textboxMapHght
    	// 
    	this.textboxMapHght.Location = new System.Drawing.Point(99, 138);
    	this.textboxMapHght.Name = "textboxMapHght";
    	this.textboxMapHght.Size = new System.Drawing.Size(138, 20);
    	this.textboxMapHght.TabIndex = 24;
    	this.textboxMapHght.Text = "Longitude";
    	// 
    	// textboxMapWidth
    	// 
    	this.textboxMapWidth.Location = new System.Drawing.Point(98, 109);
    	this.textboxMapWidth.Name = "textboxMapWidth";
    	this.textboxMapWidth.Size = new System.Drawing.Size(138, 20);
    	this.textboxMapWidth.TabIndex = 25;
    	this.textboxMapWidth.Text = "Longitude";
    	// 
    	// metroButton1
    	// 
    	this.metroButton1.Location = new System.Drawing.Point(35, 167);
    	this.metroButton1.Name = "metroButton1";
    	this.metroButton1.Size = new System.Drawing.Size(75, 23);
    	this.metroButton1.TabIndex = 18;
    	this.metroButton1.Text = "Update Map";
    	// 
    	// textboxLon
    	// 
    	this.textboxLon.Location = new System.Drawing.Point(99, 51);
    	this.textboxLon.Name = "textboxLon";
    	this.textboxLon.Size = new System.Drawing.Size(138, 20);
    	this.textboxLon.TabIndex = 26;
    	this.textboxLon.Text = "Longitude";
    	// 
    	// textboxLat
    	// 
    	this.textboxLat.Location = new System.Drawing.Point(99, 21);
    	this.textboxLat.Name = "textboxLat";
    	this.textboxLat.Size = new System.Drawing.Size(138, 20);
    	this.textboxLat.TabIndex = 23;
    	this.textboxLat.Text = "Latitude";
    	// 
    	// label16
    	// 
    	this.label16.Location = new System.Drawing.Point(29, 109);
    	this.label16.Name = "label16";
    	this.label16.Size = new System.Drawing.Size(63, 23);
    	this.label16.TabIndex = 19;
    	this.label16.Text = "Map Height";
    	this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// label3
    	// 
    	this.label3.Location = new System.Drawing.Point(30, 51);
    	this.label3.Name = "label3";
    	this.label3.Size = new System.Drawing.Size(63, 23);
    	this.label3.TabIndex = 20;
    	this.label3.Text = "Longitude";
    	this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// label2
    	// 
    	this.label2.Location = new System.Drawing.Point(30, 21);
    	this.label2.Name = "label2";
    	this.label2.Size = new System.Drawing.Size(63, 23);
    	this.label2.TabIndex = 21;
    	this.label2.Text = "Latitude";
    	this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	this.label2.Click += new System.EventHandler(this.label2_Click);
    	// 
    	// label15
    	// 
    	this.label15.Location = new System.Drawing.Point(30, 138);
    	this.label15.Name = "label15";
    	this.label15.Size = new System.Drawing.Size(63, 23);
    	this.label15.TabIndex = 22;
    	this.label15.Text = "MapWidth";
    	this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    	// 
    	// button1
    	// 
    	this.button1.Location = new System.Drawing.Point(942, 10);
    	this.button1.Name = "button1";
    	this.button1.Size = new System.Drawing.Size(75, 23);
    	this.button1.TabIndex = 9;
    	this.button1.Text = "Settings";
    	this.button1.UseVisualStyleBackColor = true;
    	// 
    	// Alert_listview
    	// 
    	this.Alert_listview.Activation = System.Windows.Forms.ItemActivation.OneClick;
    	listViewItem1.ToolTipText = resources.GetString("listViewItem1.ToolTipText");
    	this.Alert_listview.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
			listViewItem1});
    	this.Alert_listview.LabelWrap = false;
    	this.Alert_listview.LargeImageList = this.alertImgLst;
    	this.Alert_listview.Location = new System.Drawing.Point(2, 3);
    	this.Alert_listview.MultiSelect = false;
    	this.Alert_listview.Name = "Alert_listview";
    	this.Alert_listview.ShowItemToolTips = true;
    	this.Alert_listview.Size = new System.Drawing.Size(896, 45);
    	this.Alert_listview.SmallImageList = this.alertImgLst;
    	this.Alert_listview.TabIndex = 9;
    	this.Alert_listview.UseCompatibleStateImageBehavior = false;
    	this.Alert_listview.View = System.Windows.Forms.View.Tile;
    	// 
    	// alertImgLst
    	// 
    	this.alertImgLst.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("alertImgLst.ImageStream")));
    	this.alertImgLst.TransparentColor = System.Drawing.Color.Transparent;
    	this.alertImgLst.Images.SetKeyName(0, "Snow");
    	this.alertImgLst.Images.SetKeyName(1, "Hot");
    	this.alertImgLst.Images.SetKeyName(2, "TStorm");
    	// 
    	// pictureBox1
    	// 
    	this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.pictureBox1.Location = new System.Drawing.Point(37, 34);
    	this.pictureBox1.Name = "pictureBox1";
    	this.pictureBox1.Size = new System.Drawing.Size(47, 50);
    	this.pictureBox1.TabIndex = 1;
    	this.pictureBox1.TabStop = false;
    	// 
    	// pictureBox2
    	// 
    	this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
			| System.Windows.Forms.AnchorStyles.Right)));
    	this.pictureBox2.Location = new System.Drawing.Point(37, 131);
    	this.pictureBox2.Name = "pictureBox2";
    	this.pictureBox2.Size = new System.Drawing.Size(50, 50);
    	this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
    	this.pictureBox2.TabIndex = 1;
    	this.pictureBox2.TabStop = false;
    	// 
    	// MainForm
    	// 
    	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
    	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
    	this.AutoScroll = true;
    	this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
    	this.ClientSize = new System.Drawing.Size(1229, 844);
    	this.Controls.Add(this.Alert_listview);
    	this.Controls.Add(this.button1);
    	this.Controls.Add(this.metroTabControl1);
    	this.Controls.Add(this.statusStrip1);
    	this.Controls.Add(this.zipBox);
    	this.Name = "MainForm";
    	this.Text = "weatherVB";
    	this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
    	this.Load += new System.EventHandler(this.MainForm_Load);
    	this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
    	this.statusStrip1.ResumeLayout(false);
    	this.statusStrip1.PerformLayout();
    	this.metroTabControl1.ResumeLayout(false);
    	this.tabPageConditions.ResumeLayout(false);
    	this.Condition_FlowPanel_3day.ResumeLayout(false);
    	this.Condition_grpBx_D1summary.ResumeLayout(false);
    	((System.ComponentModel.ISupportInitialize)(this.picbox_conditions_icon2)).EndInit();
    	this.Condition_grpBx_D2summary.ResumeLayout(false);
    	((System.ComponentModel.ISupportInitialize)(this.picbox_conditions_icon3)).EndInit();
    	this.Condition_grpBx_D3summary.ResumeLayout(false);
    	((System.ComponentModel.ISupportInitialize)(this.picbox_conditions_icon4)).EndInit();
    	this.metroPanel1.ResumeLayout(false);
    	this.panelDay1.ResumeLayout(false);
    	this.panelDay1.PerformLayout();
    	this.groupBox1.ResumeLayout(false);
    	this.groupBox2.ResumeLayout(false);
    	this.Condition_grpBx_Pressure.ResumeLayout(false);
    	this.Condition_grpBx_RainFall.ResumeLayout(false);
    	this.Condition_grpBx_Temp.ResumeLayout(false);
    	((System.ComponentModel.ISupportInitialize)(this.picbox_conditions_icon)).EndInit();
    	this.tabPage10Day.ResumeLayout(false);
    	this.panel2.ResumeLayout(false);
    	this.flowLayoutPanel1.ResumeLayout(false);
    	this.panel5.ResumeLayout(false);
    	this.panel5.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.day1Pic)).EndInit();
    	this.panel6.ResumeLayout(false);
    	this.panel6.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night2Pic)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.day2Pic)).EndInit();
    	this.panel7.ResumeLayout(false);
    	this.panel7.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night3Pic)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.day3Pic)).EndInit();
    	this.panel9.ResumeLayout(false);
    	this.panel9.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night4Pic)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.day4Pic)).EndInit();
    	this.panel12.ResumeLayout(false);
    	this.panel12.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night5Pic)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.day5Pic)).EndInit();
    	this.panel10.ResumeLayout(false);
    	this.panel10.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night6Pic)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.day6Pic)).EndInit();
    	this.panel13.ResumeLayout(false);
    	this.panel13.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night7Pic)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.day7Pic)).EndInit();
    	this.panel14.ResumeLayout(false);
    	this.panel14.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night8Pic)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.day8Pic)).EndInit();
    	this.panel11.ResumeLayout(false);
    	this.panel11.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night9Pic)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.day9Pic)).EndInit();
    	this.DayPanel8.ResumeLayout(false);
    	this.DayPanel8.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.night10Pic)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.day10Pic)).EndInit();
    	this.metroTabPage4.ResumeLayout(false);
    	this.tabPageBrowser.ResumeLayout(false);
    	this.tabPageDebug.ResumeLayout(false);
    	this.tabPageDebug.PerformLayout();
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
    	((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
    	this.ResumeLayout(false);
    	this.PerformLayout();

    }
    private ComboBox zipBox;
    public System.Windows.Forms.StatusStrip statusStrip1;
    private ToolStripStatusLabel statusbarLongLat;
    private ToolStripStatusLabel statusbarMapZoom;
    private Panel panelDay1;
    private Label lbl_Condition_Day;
    private Label lbl_Condition_dewpoint;
    private Label lbl_Condition_wind;
    private Label lbl_Condition_feels;
    private PictureBox picbox_conditions_icon;
    private Label lbl_Condition_pressure_in;
    private Label lbl_Condition_Weather;
    private Label lbl_Condition_temp;
    private Label lbl_Condition_pressure_mb;
    private Label lbl_Condition_pressure_trend;
    private Label lbl_Condition_humidity;
    private Label lbl_Condition_long;
    private Label lbl_condition_city;
    private Label lbl_Condition_zip;
    private Label lbl_condition_station;
    private Label lbl_Condition_elevation;
    private Label lbl_Condition_latitude;
    //private GMap.NET.WindowsForms.GMapControl gMap;
    private TabControl metroTabControl1;
    private TabPage tabPage10Day;
    private FlowLayoutPanel flowLayoutPanel1;
    private Panel panel5;
    private PictureBox day1Pic;
    private Label day1Desc;
    private Label day1Label;
    private Panel panel6;
    private PictureBox night2Pic;
    private PictureBox day2Pic;
    private Label night2cop;
    private Label day2cop;
    private Label Night2Desc;
    private Label day2Desc;
    private Label night2Label;
    private Label day2Label;
    private Panel panel7;
    private PictureBox night3Pic;
    private PictureBox day3Pic;
    private Label night3cop;
    private Label day3cop;
    private Label Night3Desc;
    private Label day3Desc;
    private Label night3Label;
    private Label day3Label;
    private Panel panel9;
    private PictureBox night4Pic;
    private PictureBox day4Pic;
    private Label night4cop;
    private Label day4cop;
    private Label Night4Desc;
    private Label day4Desc;
    private Label night4Label;
    private Label day4Label;
    private Panel panel12;
    private PictureBox night5Pic;
    private PictureBox day5Pic;
    private Label night5cop;
    private Label day5cop;
    private Label Night5Desc;
    private Label day5Desc;
    private Label night5Label;
    private Label day5Label;
    private Panel panel10;
    private PictureBox night6Pic;
    private PictureBox day6Pic;
    private Label night6cop;
    private Label day6cop;
    private Label Night6Desc;
    private Label day6Desc;
    private Label night6Label;
    private Label day6Label;
    private Panel panel13;
    private PictureBox night7Pic;
    private PictureBox day7Pic;
    private Label night7cop;
    private Label day7cop;
    private Label Night7Desc;
    private Label day7Desc;
    private Label night7Label;
    private Label day7Label;
    private Panel panel14;
    private PictureBox night8Pic;
    private PictureBox day8Pic;
    private Label night8cop;
    private Label day8cop;
    private Label Night8Desc;
    private Label day8Desc;
    private Label night8Label;
    private Label day8Label;
    private Panel panel11;
    private PictureBox night9Pic;
    private PictureBox day9Pic;
    private Label night9cop;
    private Label day9cop;
    private Label Night9Desc;
    private Label day9Desc;
    private Label night9Label;
    private Label day9Label;
    private Panel DayPanel8;
    private PictureBox night10Pic;
    private PictureBox day10Pic;
    private Label night10cop;
    private Label day10cop;
    private Label Night10Desc;
    private Label day10Desc;
    private Label night10Label;
    private Label day10Label;
    private TabPage tabPageBrowser;
    private ComboBox comboBox1;
    private WebBrowser WEBmapbrowser;
    private TabPage tabPageConditions;
    private TabPage metroTabPage4;
    private TabPage tabPageDebug;
    private Button metro;
    private ComboBox comboBox2;
    private TextBox textboxMapHght;
    private TextBox textboxMapWidth;
    private Button metroButton1;
    private TextBox textboxLon;
    private TextBox textboxLat;
    private Label label16;
    private Label label3;
    private Label label2;
    private Label label15;
    private PictureBox pictureBox1;
    private PictureBox pictureBox2;
    private Panel metroPanel1;
    private Label lbl_Condition_precip_today_in;
    private Label lbl_Condition_precip_1hr;
    private Label lbl_Condition_UV;
    private Label lbl_Condition_visibleMi;
    private GroupBox Condition_grpBx_Pressure;
    private GroupBox Condition_grpBx_RainFall;
    private GroupBox Condition_grpBx_Temp;
    private TextBox txtbox_debug_debug;
    private GroupBox Condition_grpBx_D2summary;
    private PictureBox picbox_conditions_icon3;
    private Label lbl_Condition_temp3;
    private Label lbl_Condition_fctext3;
    private GroupBox Condition_grpBx_D1summary;
    private PictureBox picbox_conditions_icon2;
    private Label lbl_Condition_temp2;
    private Label lbl_Condition_fctext2;
    private GroupBox Condition_grpBx_D3summary;
    private PictureBox picbox_conditions_icon4;
    private Label lbl_Condition_temp4;
    private Label lbl_Condition_fctext4;
    private FlowLayoutPanel Condition_FlowPanel_3day;
    private Label label1;
    private Label label4;
    private Label label7;
    private Label label57;
    private Label label56;
    private Label label55;
    private Label label54;
    private Label label25;
    private Label label24;
    private Label label19;
    private Label label18;
    private Label label13;
    private Label label12;
//    private Syncfusion.Windows.Forms.Gauge.LinearGauge gauge_Condition_UV;
//    private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge3;
//    private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge2;
//    private Syncfusion.Windows.Forms.Gauge.LinearGauge linearGauge1;
//    private Syncfusion.Windows.Forms.Gauge.RadialGauge radialGauge1;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private System.Windows.Forms.Button button1;
    private ListView Alert_listview;
    private ImageList alertImgLst;
    private FlowLayoutPanel alertPanel;
    private DoubleBufferedPanel panel2;
    private System.Windows.Forms.ToolStripStatusLabel toolStripDebug;
}

//=======================================================
//Service provided by Telerik (www.telerik.com)
//Conversion powered by NRefactory.
//Twitter: @telerik
//Facebook: facebook.com/telerik
//=======================================================
