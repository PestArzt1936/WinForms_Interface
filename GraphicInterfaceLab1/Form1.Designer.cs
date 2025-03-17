﻿using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraphicInterfaceLab1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        
        private void InitializeComponent()
        {
            System.Windows.Forms.Button ProgrammButton;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.MainButton = new System.Windows.Forms.Button();
            this.BoxOfNames = new System.Windows.Forms.ComboBox();
            this.BoxOfTypes = new System.Windows.Forms.ComboBox();
            this.BoxOfHeads = new System.Windows.Forms.ComboBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.MachineActsPanel = new System.Windows.Forms.Panel();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.AxisViewPanel = new System.Windows.Forms.Panel();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MessagesPanel = new System.Windows.Forms.Panel();
            this.MessagesDataGrid = new System.Windows.Forms.DataGridView();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ProgrammButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.MachineActsPanel.SuspendLayout();
            this.AxisViewPanel.SuspendLayout();
            this.StatusPanel.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
            this.MessagesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MessagesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ProgrammButton
            // 
            ProgrammButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(86)))), ((int)(((byte)(97)))));
            ProgrammButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            ProgrammButton.ForeColor = System.Drawing.Color.White;
            ProgrammButton.Image = ((System.Drawing.Image)(resources.GetObject("ProgrammButton.Image")));
            ProgrammButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            ProgrammButton.Location = new System.Drawing.Point(0, 95);
            ProgrammButton.Margin = new System.Windows.Forms.Padding(2);
            ProgrammButton.Name = "ProgrammButton";
            ProgrammButton.Size = new System.Drawing.Size(272, 62);
            ProgrammButton.TabIndex = 1;
            ProgrammButton.Text = "Программа";
            ProgrammButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            ProgrammButton.UseVisualStyleBackColor = false;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.AnalyzeButton);
            this.MainPanel.Controls.Add(ProgrammButton);
            this.MainPanel.Controls.Add(this.MainButton);
            this.MainPanel.Location = new System.Drawing.Point(78, 83);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(272, 252);
            this.MainPanel.TabIndex = 0;
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(86)))), ((int)(((byte)(97)))));
            this.AnalyzeButton.FlatAppearance.BorderSize = 0;
            this.AnalyzeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.AnalyzeButton.ForeColor = System.Drawing.Color.White;
            this.AnalyzeButton.Image = ((System.Drawing.Image)(resources.GetObject("AnalyzeButton.Image")));
            this.AnalyzeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AnalyzeButton.Location = new System.Drawing.Point(0, 190);
            this.AnalyzeButton.Margin = new System.Windows.Forms.Padding(2);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(272, 62);
            this.AnalyzeButton.TabIndex = 2;
            this.AnalyzeButton.Text = "Мониторинг";
            this.AnalyzeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AnalyzeButton.UseCompatibleTextRendering = true;
            this.AnalyzeButton.UseVisualStyleBackColor = false;
            // 
            // MainButton
            // 
            this.MainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(86)))), ((int)(((byte)(97)))));
            this.MainButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MainButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(86)))), ((int)(((byte)(97)))));
            this.MainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.MainButton.ForeColor = System.Drawing.Color.White;
            this.MainButton.Image = ((System.Drawing.Image)(resources.GetObject("MainButton.Image")));
            this.MainButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MainButton.Location = new System.Drawing.Point(0, 0);
            this.MainButton.Margin = new System.Windows.Forms.Padding(2);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(272, 62);
            this.MainButton.TabIndex = 0;
            this.MainButton.Text = "Главная";
            this.MainButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MainButton.UseCompatibleTextRendering = true;
            this.MainButton.UseVisualStyleBackColor = false;
            // 
            // BoxOfNames
            // 
            this.BoxOfNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(219)))));
            this.BoxOfNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BoxOfNames.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoxOfNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.BoxOfNames.ForeColor = System.Drawing.Color.White;
            this.BoxOfNames.ItemHeight = 39;
            this.BoxOfNames.Location = new System.Drawing.Point(78, 386);
            this.BoxOfNames.Name = "BoxOfNames";
            this.BoxOfNames.Size = new System.Drawing.Size(270, 45);
            this.BoxOfNames.TabIndex = 1;
            // 
            // BoxOfTypes
            // 
            this.BoxOfTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(219)))));
            this.BoxOfTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BoxOfTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoxOfTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.BoxOfTypes.ForeColor = System.Drawing.Color.White;
            this.BoxOfTypes.ItemHeight = 39;
            this.BoxOfTypes.Location = new System.Drawing.Point(78, 473);
            this.BoxOfTypes.Name = "BoxOfTypes";
            this.BoxOfTypes.Size = new System.Drawing.Size(270, 45);
            this.BoxOfTypes.TabIndex = 2;
            // 
            // BoxOfHeads
            // 
            this.BoxOfHeads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(219)))));
            this.BoxOfHeads.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BoxOfHeads.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoxOfHeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.BoxOfHeads.ForeColor = System.Drawing.Color.White;
            this.BoxOfHeads.ItemHeight = 39;
            this.BoxOfHeads.Location = new System.Drawing.Point(78, 561);
            this.BoxOfHeads.Name = "BoxOfHeads";
            this.BoxOfHeads.Size = new System.Drawing.Size(270, 45);
            this.BoxOfHeads.TabIndex = 3;
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(86)))), ((int)(((byte)(97)))));
            this.InfoPanel.Controls.Add(this.label5);
            this.InfoPanel.Controls.Add(this.MachineActsPanel);
            this.InfoPanel.Controls.Add(this.AxisViewPanel);
            this.InfoPanel.Location = new System.Drawing.Point(78, 639);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(270, 329);
            this.InfoPanel.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.label5.Location = new System.Drawing.Point(62, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "None";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MachineActsPanel
            // 
            this.MachineActsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.MachineActsPanel.Controls.Add(this.button13);
            this.MachineActsPanel.Controls.Add(this.button12);
            this.MachineActsPanel.Controls.Add(this.button11);
            this.MachineActsPanel.Controls.Add(this.button10);
            this.MachineActsPanel.Location = new System.Drawing.Point(3, 195);
            this.MachineActsPanel.Name = "MachineActsPanel";
            this.MachineActsPanel.Size = new System.Drawing.Size(264, 55);
            this.MachineActsPanel.TabIndex = 1;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button13.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button13.BackgroundImage")));
            this.button13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button13.Location = new System.Drawing.Point(209, 5);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(51, 44);
            this.button13.TabIndex = 3;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button12.Location = new System.Drawing.Point(142, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(51, 44);
            this.button12.TabIndex = 2;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.Location = new System.Drawing.Point(73, 5);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(51, 44);
            this.button11.TabIndex = 1;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.button10.Image = ((System.Drawing.Image)(resources.GetObject("button10.Image")));
            this.button10.Location = new System.Drawing.Point(4, 5);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(51, 44);
            this.button10.TabIndex = 0;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // AxisViewPanel
            // 
            this.AxisViewPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.AxisViewPanel.Controls.Add(this.button9);
            this.AxisViewPanel.Controls.Add(this.button8);
            this.AxisViewPanel.Controls.Add(this.button7);
            this.AxisViewPanel.Controls.Add(this.button6);
            this.AxisViewPanel.Controls.Add(this.button5);
            this.AxisViewPanel.Controls.Add(this.button4);
            this.AxisViewPanel.Location = new System.Drawing.Point(0, 282);
            this.AxisViewPanel.Name = "AxisViewPanel";
            this.AxisViewPanel.Size = new System.Drawing.Size(270, 47);
            this.AxisViewPanel.TabIndex = 0;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(38)))));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(208, 3);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 41);
            this.button9.TabIndex = 5;
            this.button9.Text = "Авто";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(167, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(41, 41);
            this.button8.TabIndex = 4;
            this.button8.Text = "C\'";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(126, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(41, 41);
            this.button7.TabIndex = 3;
            this.button7.Text = "C";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(85, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(41, 41);
            this.button6.TabIndex = 2;
            this.button6.Text = "Z";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(44, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(41, 41);
            this.button5.TabIndex = 1;
            this.button5.Text = "Y";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(41, 41);
            this.button4.TabIndex = 0;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // StatusPanel
            // 
            this.StatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.StatusPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StatusPanel.Controls.Add(this.label31);
            this.StatusPanel.Controls.Add(this.label30);
            this.StatusPanel.Controls.Add(this.label29);
            this.StatusPanel.Controls.Add(this.label28);
            this.StatusPanel.Controls.Add(this.label27);
            this.StatusPanel.Controls.Add(this.label26);
            this.StatusPanel.Controls.Add(this.label25);
            this.StatusPanel.Controls.Add(this.label24);
            this.StatusPanel.Controls.Add(this.label23);
            this.StatusPanel.Controls.Add(this.label22);
            this.StatusPanel.Controls.Add(this.label21);
            this.StatusPanel.Controls.Add(this.label20);
            this.StatusPanel.Controls.Add(this.label19);
            this.StatusPanel.Controls.Add(this.label18);
            this.StatusPanel.Controls.Add(this.label17);
            this.StatusPanel.Controls.Add(this.label16);
            this.StatusPanel.Controls.Add(this.label15);
            this.StatusPanel.Controls.Add(this.label14);
            this.StatusPanel.Controls.Add(this.label13);
            this.StatusPanel.Controls.Add(this.label12);
            this.StatusPanel.Controls.Add(this.label11);
            this.StatusPanel.Controls.Add(this.label10);
            this.StatusPanel.Location = new System.Drawing.Point(441, 64);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(615, 675);
            this.StatusPanel.TabIndex = 5;
            // 
            // label31
            // 
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label31.ForeColor = System.Drawing.Color.White;
            this.label31.Location = new System.Drawing.Point(355, 267);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(139, 30);
            this.label31.TabIndex = 21;
            this.label31.Text = "0° 0’ 0’’";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label30.ForeColor = System.Drawing.Color.White;
            this.label30.Location = new System.Drawing.Point(355, 214);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(139, 30);
            this.label30.TabIndex = 20;
            this.label30.Text = "0° 0’ 0’’";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label29
            // 
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label29.ForeColor = System.Drawing.Color.White;
            this.label29.Location = new System.Drawing.Point(355, 161);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(124, 30);
            this.label29.TabIndex = 19;
            this.label29.Text = "0.0";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label28
            // 
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(355, 108);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(124, 30);
            this.label28.TabIndex = 18;
            this.label28.Text = "0.0";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label27.ForeColor = System.Drawing.Color.White;
            this.label27.Location = new System.Drawing.Point(355, 59);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(124, 30);
            this.label27.TabIndex = 17;
            this.label27.Text = "0.0";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.Image = ((System.Drawing.Image)(resources.GetObject("label26.Image")));
            this.label26.Location = new System.Drawing.Point(85, 367);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(40, 40);
            this.label26.TabIndex = 16;
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(435, 381);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(135, 24);
            this.label25.TabIndex = 15;
            this.label25.Text = "макс.";
            this.label25.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(338, 381);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(90, 24);
            this.label24.TabIndex = 14;
            this.label24.Text = "ср.";
            this.label24.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(210, 381);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(90, 24);
            this.label23.TabIndex = 13;
            this.label23.Text = "тек.";
            this.label23.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(40, 614);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(138, 30);
            this.label22.TabIndex = 12;
            this.label22.Text = "Привод C\'";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(40, 564);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(138, 30);
            this.label21.TabIndex = 11;
            this.label21.Text = "Привод C";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(40, 514);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(138, 30);
            this.label20.TabIndex = 10;
            this.label20.Text = "Привод Z";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(40, 464);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 30);
            this.label19.TabIndex = 9;
            this.label19.Text = "Привод Y";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(40, 414);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 30);
            this.label18.TabIndex = 8;
            this.label18.Text = "Привод X";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.label17.Location = new System.Drawing.Point(154, 353);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(417, 43);
            this.label17.TabIndex = 7;
            this.label17.Text = "Значение температуры";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(40, 271);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(138, 30);
            this.label16.TabIndex = 6;
            this.label16.Text = "Привод C\'";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(40, 218);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(138, 30);
            this.label15.TabIndex = 5;
            this.label15.Text = "Привод C";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(40, 165);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(138, 30);
            this.label14.TabIndex = 4;
            this.label14.Text = "Привод Z";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(40, 112);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(138, 30);
            this.label13.TabIndex = 3;
            this.label13.Text = "Привод Y";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(40, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(138, 30);
            this.label12.TabIndex = 2;
            this.label12.Text = "Привод X";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.label11.Location = new System.Drawing.Point(324, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(182, 32);
            this.label11.TabIndex = 1;
            this.label11.Text = "Значение";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.label10.Location = new System.Drawing.Point(178, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 24);
            this.label10.TabIndex = 0;
            this.label10.Text = "Состояние";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ChartPanel
            // 
            this.ChartPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.ChartPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ChartPanel.Controls.Add(this.temperatureChart);
            this.ChartPanel.Location = new System.Drawing.Point(1125, 64);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(709, 675);
            this.ChartPanel.TabIndex = 6;
            // 
            // temperatureChart
            // 
            this.temperatureChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.temperatureChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.temperatureChart.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            chartArea7.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea7);
            this.temperatureChart.Location = new System.Drawing.Point(0, 0);
            this.temperatureChart.Name = "temperatureChart";
            series7.BorderWidth = 2;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.IsXValueIndexed = true;
            series7.Legend = "Legend1";
            series7.Name = "Series1";
            this.temperatureChart.Series.Add(series7);
            this.temperatureChart.Size = new System.Drawing.Size(710, 675);
            this.temperatureChart.TabIndex = 0;
            this.temperatureChart.Text = "Температура";
            // 
            // MessagesPanel
            // 
            this.MessagesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.MessagesPanel.Controls.Add(this.MessagesDataGrid);
            this.MessagesPanel.Controls.Add(this.button17);
            this.MessagesPanel.Controls.Add(this.button16);
            this.MessagesPanel.Controls.Add(this.button15);
            this.MessagesPanel.Controls.Add(this.button14);
            this.MessagesPanel.Controls.Add(this.button3);
            this.MessagesPanel.Controls.Add(this.button2);
            this.MessagesPanel.Controls.Add(this.button1);
            this.MessagesPanel.Location = new System.Drawing.Point(440, 784);
            this.MessagesPanel.Name = "MessagesPanel";
            this.MessagesPanel.Size = new System.Drawing.Size(1395, 226);
            this.MessagesPanel.TabIndex = 7;
            // 
            // MessagesDataGrid
            // 
            this.MessagesDataGrid.AllowUserToAddRows = false;
            this.MessagesDataGrid.AllowUserToDeleteRows = false;
            this.MessagesDataGrid.AllowUserToResizeColumns = false;
            this.MessagesDataGrid.AllowUserToResizeRows = false;
            this.MessagesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.MessagesDataGrid.Location = new System.Drawing.Point(1, 28);
            this.MessagesDataGrid.Name = "MessagesDataGrid";
            this.MessagesDataGrid.RowHeadersVisible = false;
            this.MessagesDataGrid.Size = new System.Drawing.Size(1393, 198);
            this.MessagesDataGrid.TabIndex = 22;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.button17.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button17.Location = new System.Drawing.Point(660, 0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(133, 30);
            this.button17.TabIndex = 6;
            this.button17.Text = "Шпиндель";
            this.button17.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.button16.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button16.Location = new System.Drawing.Point(555, 0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(109, 30);
            this.button16.TabIndex = 5;
            this.button16.Text = "Ось C\'";
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.button15.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(450, 0);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(109, 30);
            this.button15.TabIndex = 4;
            this.button15.Text = "Ось C";
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.button14.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(345, 0);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(109, 30);
            this.button14.TabIndex = 3;
            this.button14.Text = "Ось Z";
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.button3.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(240, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ось Y";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.button2.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(135, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 30);
            this.button2.TabIndex = 1;
            this.button2.Text = "Ось X";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(160)))), ((int)(((byte)(245)))));
            this.button1.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(52, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 0;
            this.button1.Text = "СЧПУ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(79, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 35);
            this.label1.TabIndex = 8;
            this.label1.Text = "RHINO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 26);
            this.label2.TabIndex = 9;
            this.label2.Text = "Наименование станка:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(78, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 10;
            this.label3.Text = "Тип станка:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(78, 527);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Выбор головы:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(490, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(513, 48);
            this.label6.TabIndex = 12;
            this.label6.Text = "Мониторинг значений";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(890, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(370, 31);
            this.label7.TabIndex = 13;
            this.label7.Text = "Вертикально-фрезерный ST-30F";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(1125, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(710, 44);
            this.label8.TabIndex = 14;
            this.label8.Text = "График изменения температуры привода";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(432, 742);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(508, 39);
            this.label9.TabIndex = 15;
            this.label9.Text = "Активные сообщения";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(227)))), ((int)(((byte)(232)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MessagesPanel);
            this.Controls.Add(this.ChartPanel);
            this.Controls.Add(this.StatusPanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.BoxOfHeads);
            this.Controls.Add(this.BoxOfTypes);
            this.Controls.Add(this.BoxOfNames);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.MachineActsPanel.ResumeLayout(false);
            this.AxisViewPanel.ResumeLayout(false);
            this.StatusPanel.ResumeLayout(false);
            this.ChartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            this.MessagesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MessagesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Button MainButton;
        private Button AnalyzeButton;
        private ComboBox BoxOfNames;
        private ComboBox BoxOfTypes;
        private ComboBox BoxOfHeads;
        private Panel InfoPanel;
        private Panel StatusPanel;
        private Panel ChartPanel;
        private Panel MessagesPanel;
        private Panel AxisViewPanel;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Panel MachineActsPanel;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperatureChart;
        private Button button13;
        private Button button12;
        private Button button11;
        private Button button10;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label22;
        private Label label21;
        private Label label20;
        private Label label23;
        private Label label25;
        private Label label24;
        private Label label26;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button17;
        private Button button16;
        private Button button15;
        private Button button14;
        private Label label27;
        private Label label28;
        private Label label30;
        private Label label29;
        private Label label31;
        private DataGridView MessagesDataGrid;
    }
}

