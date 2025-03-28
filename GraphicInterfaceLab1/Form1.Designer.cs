using System.Windows.Forms;
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.MainButton = new System.Windows.Forms.Button();
            this.BoxOfTypes = new System.Windows.Forms.ComboBox();
            this.BoxOfNames = new System.Windows.Forms.ComboBox();
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
            this.StatusNdValuesPanel = new System.Windows.Forms.Panel();
            this.label53 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.StatusPanel = new System.Windows.Forms.Panel();
            this.TemperatureValuesPanel = new System.Windows.Forms.Panel();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.AxisCInvertPosValue = new System.Windows.Forms.Label();
            this.AxisCPosValue = new System.Windows.Forms.Label();
            this.AxisZPosValue = new System.Windows.Forms.Label();
            this.AxisYPosValue = new System.Windows.Forms.Label();
            this.AxisXPosValue = new System.Windows.Forms.Label();
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
            this.label55 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.ReloadChartButton = new System.Windows.Forms.Button();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MessagesPanel = new System.Windows.Forms.Panel();
            this.MessagesDataGrid = new System.Windows.Forms.DataGridView();
            this.AM_SpiendelButton = new System.Windows.Forms.Button();
            this.AM_AxisCRevButton = new System.Windows.Forms.Button();
            this.AM_AxisCButton = new System.Windows.Forms.Button();
            this.AM_AxisZButton = new System.Windows.Forms.Button();
            this.AM_AxisYButton = new System.Windows.Forms.Button();
            this.AM_AxisXButton = new System.Windows.Forms.Button();
            this.AM_CNCButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ProgrammButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.MachineActsPanel.SuspendLayout();
            this.AxisViewPanel.SuspendLayout();
            this.StatusNdValuesPanel.SuspendLayout();
            this.TemperatureValuesPanel.SuspendLayout();
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
            // BoxOfTypes
            // 
            this.BoxOfTypes.AllowDrop = true;
            this.BoxOfTypes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(219)))));
            this.BoxOfTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BoxOfTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxOfTypes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoxOfTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.BoxOfTypes.ForeColor = System.Drawing.Color.White;
            this.BoxOfTypes.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.BoxOfTypes.ItemHeight = 55;
            this.BoxOfTypes.Location = new System.Drawing.Point(78, 386);
            this.BoxOfTypes.Name = "BoxOfTypes";
            this.BoxOfTypes.Size = new System.Drawing.Size(270, 61);
            this.BoxOfTypes.TabIndex = 1;
            this.BoxOfTypes.SelectedIndexChanged += new System.EventHandler(this.BoxOfTypes_SelectedIndexChanged);
            // 
            // BoxOfNames
            // 
            this.BoxOfNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(219)))));
            this.BoxOfNames.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BoxOfNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxOfNames.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoxOfNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.BoxOfNames.ForeColor = System.Drawing.Color.White;
            this.BoxOfNames.ItemHeight = 39;
            this.BoxOfNames.Location = new System.Drawing.Point(78, 491);
            this.BoxOfNames.Name = "BoxOfNames";
            this.BoxOfNames.Size = new System.Drawing.Size(270, 45);
            this.BoxOfNames.TabIndex = 2;
            this.BoxOfNames.SelectedIndexChanged += new System.EventHandler(this.BoxOfNames_SelectedIndexChanged);
            // 
            // BoxOfHeads
            // 
            this.BoxOfHeads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(219)))));
            this.BoxOfHeads.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.BoxOfHeads.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BoxOfHeads.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BoxOfHeads.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.BoxOfHeads.ForeColor = System.Drawing.Color.White;
            this.BoxOfHeads.ItemHeight = 39;
            this.BoxOfHeads.Location = new System.Drawing.Point(78, 578);
            this.BoxOfHeads.Name = "BoxOfHeads";
            this.BoxOfHeads.Size = new System.Drawing.Size(270, 45);
            this.BoxOfHeads.TabIndex = 3;
            this.BoxOfHeads.SelectedIndexChanged += new System.EventHandler(this.BoxOfHeads_SelectedIndexChanged);
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
            // StatusNdValuesPanel
            // 
            this.StatusNdValuesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.StatusNdValuesPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StatusNdValuesPanel.Controls.Add(this.label53);
            this.StatusNdValuesPanel.Controls.Add(this.label52);
            this.StatusNdValuesPanel.Controls.Add(this.StatusPanel);
            this.StatusNdValuesPanel.Controls.Add(this.TemperatureValuesPanel);
            this.StatusNdValuesPanel.Controls.Add(this.label36);
            this.StatusNdValuesPanel.Controls.Add(this.label35);
            this.StatusNdValuesPanel.Controls.Add(this.label34);
            this.StatusNdValuesPanel.Controls.Add(this.label33);
            this.StatusNdValuesPanel.Controls.Add(this.label32);
            this.StatusNdValuesPanel.Controls.Add(this.AxisCInvertPosValue);
            this.StatusNdValuesPanel.Controls.Add(this.AxisCPosValue);
            this.StatusNdValuesPanel.Controls.Add(this.AxisZPosValue);
            this.StatusNdValuesPanel.Controls.Add(this.AxisYPosValue);
            this.StatusNdValuesPanel.Controls.Add(this.AxisXPosValue);
            this.StatusNdValuesPanel.Controls.Add(this.label26);
            this.StatusNdValuesPanel.Controls.Add(this.label25);
            this.StatusNdValuesPanel.Controls.Add(this.label24);
            this.StatusNdValuesPanel.Controls.Add(this.label23);
            this.StatusNdValuesPanel.Controls.Add(this.label22);
            this.StatusNdValuesPanel.Controls.Add(this.label21);
            this.StatusNdValuesPanel.Controls.Add(this.label20);
            this.StatusNdValuesPanel.Controls.Add(this.label19);
            this.StatusNdValuesPanel.Controls.Add(this.label18);
            this.StatusNdValuesPanel.Controls.Add(this.label17);
            this.StatusNdValuesPanel.Controls.Add(this.label16);
            this.StatusNdValuesPanel.Controls.Add(this.label15);
            this.StatusNdValuesPanel.Controls.Add(this.label14);
            this.StatusNdValuesPanel.Controls.Add(this.label13);
            this.StatusNdValuesPanel.Controls.Add(this.label12);
            this.StatusNdValuesPanel.Controls.Add(this.label11);
            this.StatusNdValuesPanel.Controls.Add(this.label10);
            this.StatusNdValuesPanel.Location = new System.Drawing.Point(441, 64);
            this.StatusNdValuesPanel.Name = "StatusNdValuesPanel";
            this.StatusNdValuesPanel.Size = new System.Drawing.Size(615, 675);
            this.StatusNdValuesPanel.TabIndex = 5;
            // 
            // label53
            // 
            this.label53.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label53.ForeColor = System.Drawing.Color.White;
            this.label53.Location = new System.Drawing.Point(107, 22);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(67, 16);
            this.label53.TabIndex = 30;
            this.label53.Text = "Не готов";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.Font = new System.Drawing.Font("Calibri", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label52.ForeColor = System.Drawing.Color.White;
            this.label52.Location = new System.Drawing.Point(38, 22);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(48, 16);
            this.label52.TabIndex = 29;
            this.label52.Text = "Готов";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StatusPanel
            // 
            this.StatusPanel.Location = new System.Drawing.Point(240, 58);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(52, 244);
            this.StatusPanel.TabIndex = 28;
            // 
            // TemperatureValuesPanel
            // 
            this.TemperatureValuesPanel.Controls.Add(this.label51);
            this.TemperatureValuesPanel.Controls.Add(this.label50);
            this.TemperatureValuesPanel.Controls.Add(this.label49);
            this.TemperatureValuesPanel.Controls.Add(this.label48);
            this.TemperatureValuesPanel.Controls.Add(this.label47);
            this.TemperatureValuesPanel.Controls.Add(this.label46);
            this.TemperatureValuesPanel.Controls.Add(this.label45);
            this.TemperatureValuesPanel.Controls.Add(this.label44);
            this.TemperatureValuesPanel.Controls.Add(this.label43);
            this.TemperatureValuesPanel.Controls.Add(this.label42);
            this.TemperatureValuesPanel.Controls.Add(this.label41);
            this.TemperatureValuesPanel.Controls.Add(this.label40);
            this.TemperatureValuesPanel.Controls.Add(this.label39);
            this.TemperatureValuesPanel.Controls.Add(this.label38);
            this.TemperatureValuesPanel.Controls.Add(this.label37);
            this.TemperatureValuesPanel.Location = new System.Drawing.Point(197, 407);
            this.TemperatureValuesPanel.Name = "TemperatureValuesPanel";
            this.TemperatureValuesPanel.Size = new System.Drawing.Size(366, 247);
            this.TemperatureValuesPanel.TabIndex = 27;
            // 
            // label51
            // 
            this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label51.ForeColor = System.Drawing.Color.White;
            this.label51.Location = new System.Drawing.Point(250, 196);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(118, 45);
            this.label51.TabIndex = 34;
            this.label51.Text = "0.0";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label50
            // 
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label50.ForeColor = System.Drawing.Color.White;
            this.label50.Location = new System.Drawing.Point(250, 147);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(118, 45);
            this.label50.TabIndex = 33;
            this.label50.Text = "0.0";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label49
            // 
            this.label49.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label49.ForeColor = System.Drawing.Color.White;
            this.label49.Location = new System.Drawing.Point(250, 98);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(118, 45);
            this.label49.TabIndex = 32;
            this.label49.Text = "0.0";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label48
            // 
            this.label48.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label48.ForeColor = System.Drawing.Color.White;
            this.label48.Location = new System.Drawing.Point(250, 49);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(118, 45);
            this.label48.TabIndex = 31;
            this.label48.Text = "0.0";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label47
            // 
            this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label47.ForeColor = System.Drawing.Color.White;
            this.label47.Location = new System.Drawing.Point(250, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(118, 45);
            this.label47.TabIndex = 30;
            this.label47.Text = "0.0";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label46
            // 
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label46.ForeColor = System.Drawing.Color.White;
            this.label46.Location = new System.Drawing.Point(128, 196);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(118, 45);
            this.label46.TabIndex = 29;
            this.label46.Text = "0.0";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label45
            // 
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label45.ForeColor = System.Drawing.Color.White;
            this.label45.Location = new System.Drawing.Point(128, 147);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(118, 45);
            this.label45.TabIndex = 28;
            this.label45.Text = "0.0";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label44
            // 
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label44.ForeColor = System.Drawing.Color.White;
            this.label44.Location = new System.Drawing.Point(128, 98);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(118, 45);
            this.label44.TabIndex = 27;
            this.label44.Text = "0.0";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label43
            // 
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label43.ForeColor = System.Drawing.Color.White;
            this.label43.Location = new System.Drawing.Point(128, 49);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(118, 45);
            this.label43.TabIndex = 26;
            this.label43.Text = "0.0";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label42
            // 
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label42.ForeColor = System.Drawing.Color.White;
            this.label42.Location = new System.Drawing.Point(128, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(118, 45);
            this.label42.TabIndex = 25;
            this.label42.Text = "0.0";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label41
            // 
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label41.ForeColor = System.Drawing.Color.White;
            this.label41.Location = new System.Drawing.Point(0, 196);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(118, 45);
            this.label41.TabIndex = 24;
            this.label41.Text = "0.0";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label40
            // 
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label40.ForeColor = System.Drawing.Color.White;
            this.label40.Location = new System.Drawing.Point(0, 147);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(118, 45);
            this.label40.TabIndex = 23;
            this.label40.Text = "0.0";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label39
            // 
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label39.ForeColor = System.Drawing.Color.White;
            this.label39.Location = new System.Drawing.Point(0, 98);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(118, 45);
            this.label39.TabIndex = 22;
            this.label39.Text = "0.0";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label38.ForeColor = System.Drawing.Color.White;
            this.label38.Location = new System.Drawing.Point(0, 49);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(118, 45);
            this.label38.TabIndex = 21;
            this.label38.Text = "0.0";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label37.ForeColor = System.Drawing.Color.White;
            this.label37.Location = new System.Drawing.Point(0, 0);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(118, 45);
            this.label37.TabIndex = 20;
            this.label37.Text = "0.0";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label36.ForeColor = System.Drawing.Color.White;
            this.label36.Location = new System.Drawing.Point(492, 267);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(120, 35);
            this.label36.TabIndex = 26;
            this.label36.Text = "град.";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label35
            // 
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label35.ForeColor = System.Drawing.Color.White;
            this.label35.Location = new System.Drawing.Point(492, 209);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(120, 35);
            this.label35.TabIndex = 25;
            this.label35.Text = "град.";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label34
            // 
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label34.ForeColor = System.Drawing.Color.White;
            this.label34.Location = new System.Drawing.Point(492, 161);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(66, 35);
            this.label34.TabIndex = 24;
            this.label34.Text = "мм";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label33
            // 
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label33.ForeColor = System.Drawing.Color.White;
            this.label33.Location = new System.Drawing.Point(492, 108);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(66, 35);
            this.label33.TabIndex = 23;
            this.label33.Text = "мм";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label32
            // 
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label32.ForeColor = System.Drawing.Color.White;
            this.label32.Location = new System.Drawing.Point(492, 59);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(66, 35);
            this.label32.TabIndex = 22;
            this.label32.Text = "мм";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AxisCInvertPosValue
            // 
            this.AxisCInvertPosValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AxisCInvertPosValue.ForeColor = System.Drawing.Color.White;
            this.AxisCInvertPosValue.Location = new System.Drawing.Point(319, 267);
            this.AxisCInvertPosValue.Name = "AxisCInvertPosValue";
            this.AxisCInvertPosValue.Size = new System.Drawing.Size(175, 30);
            this.AxisCInvertPosValue.TabIndex = 21;
            this.AxisCInvertPosValue.Text = "0° 0’ 0’’";
            this.AxisCInvertPosValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AxisCPosValue
            // 
            this.AxisCPosValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AxisCPosValue.ForeColor = System.Drawing.Color.White;
            this.AxisCPosValue.Location = new System.Drawing.Point(324, 214);
            this.AxisCPosValue.Name = "AxisCPosValue";
            this.AxisCPosValue.Size = new System.Drawing.Size(170, 30);
            this.AxisCPosValue.TabIndex = 20;
            this.AxisCPosValue.Text = "0° 0’ 0’’";
            this.AxisCPosValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AxisZPosValue
            // 
            this.AxisZPosValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AxisZPosValue.ForeColor = System.Drawing.Color.White;
            this.AxisZPosValue.Location = new System.Drawing.Point(324, 161);
            this.AxisZPosValue.Name = "AxisZPosValue";
            this.AxisZPosValue.Size = new System.Drawing.Size(155, 30);
            this.AxisZPosValue.TabIndex = 19;
            this.AxisZPosValue.Text = "0.0";
            this.AxisZPosValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AxisYPosValue
            // 
            this.AxisYPosValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AxisYPosValue.ForeColor = System.Drawing.Color.White;
            this.AxisYPosValue.Location = new System.Drawing.Point(324, 108);
            this.AxisYPosValue.Name = "AxisYPosValue";
            this.AxisYPosValue.Size = new System.Drawing.Size(155, 30);
            this.AxisYPosValue.TabIndex = 18;
            this.AxisYPosValue.Text = "0.0";
            this.AxisYPosValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AxisXPosValue
            // 
            this.AxisXPosValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AxisXPosValue.ForeColor = System.Drawing.Color.White;
            this.AxisXPosValue.Location = new System.Drawing.Point(324, 59);
            this.AxisXPosValue.Name = "AxisXPosValue";
            this.AxisXPosValue.Size = new System.Drawing.Size(155, 30);
            this.AxisXPosValue.TabIndex = 17;
            this.AxisXPosValue.Text = "0.0";
            this.AxisXPosValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(38)))), ((int)(((byte)(44)))));
            this.label17.Location = new System.Drawing.Point(154, 343);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(417, 53);
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
            this.ChartPanel.Controls.Add(this.label55);
            this.ChartPanel.Controls.Add(this.label54);
            this.ChartPanel.Controls.Add(this.ReloadChartButton);
            this.ChartPanel.Controls.Add(this.temperatureChart);
            this.ChartPanel.Location = new System.Drawing.Point(1125, 64);
            this.ChartPanel.Name = "ChartPanel";
            this.ChartPanel.Size = new System.Drawing.Size(709, 675);
            this.ChartPanel.TabIndex = 6;
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("Calibri", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label55.Location = new System.Drawing.Point(632, 575);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(59, 39);
            this.label55.TabIndex = 3;
            this.label55.Text = "t, ч";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("Calibri", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label54.Location = new System.Drawing.Point(25, 19);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(66, 39);
            this.label54.TabIndex = 2;
            this.label54.Text = "T,°C";
            // 
            // ReloadChartButton
            // 
            this.ReloadChartButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ReloadChartButton.BackgroundImage")));
            this.ReloadChartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ReloadChartButton.Location = new System.Drawing.Point(604, 61);
            this.ReloadChartButton.Name = "ReloadChartButton";
            this.ReloadChartButton.Size = new System.Drawing.Size(30, 30);
            this.ReloadChartButton.TabIndex = 1;
            this.ReloadChartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ReloadChartButton.UseVisualStyleBackColor = true;
            // 
            // temperatureChart
            // 
            this.temperatureChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.temperatureChart.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.temperatureChart.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            chartArea3.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea3);
            this.temperatureChart.Location = new System.Drawing.Point(41, 69);
            this.temperatureChart.Name = "temperatureChart";
            series3.BorderWidth = 2;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.IsXValueIndexed = true;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.temperatureChart.Series.Add(series3);
            this.temperatureChart.Size = new System.Drawing.Size(610, 551);
            this.temperatureChart.TabIndex = 0;
            this.temperatureChart.Text = "Температура";
            // 
            // MessagesPanel
            // 
            this.MessagesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.MessagesPanel.Controls.Add(this.MessagesDataGrid);
            this.MessagesPanel.Controls.Add(this.AM_SpiendelButton);
            this.MessagesPanel.Controls.Add(this.AM_AxisCRevButton);
            this.MessagesPanel.Controls.Add(this.AM_AxisCButton);
            this.MessagesPanel.Controls.Add(this.AM_AxisZButton);
            this.MessagesPanel.Controls.Add(this.AM_AxisYButton);
            this.MessagesPanel.Controls.Add(this.AM_AxisXButton);
            this.MessagesPanel.Controls.Add(this.AM_CNCButton);
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
            // AM_SpiendelButton
            // 
            this.AM_SpiendelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.AM_SpiendelButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AM_SpiendelButton.Location = new System.Drawing.Point(660, 0);
            this.AM_SpiendelButton.Name = "AM_SpiendelButton";
            this.AM_SpiendelButton.Size = new System.Drawing.Size(133, 30);
            this.AM_SpiendelButton.TabIndex = 6;
            this.AM_SpiendelButton.Text = "Шпиндель";
            this.AM_SpiendelButton.UseVisualStyleBackColor = false;
            this.AM_SpiendelButton.Click += new System.EventHandler(this.AM_SpiendelButton_Click);
            // 
            // AM_AxisCRevButton
            // 
            this.AM_AxisCRevButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.AM_AxisCRevButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AM_AxisCRevButton.Location = new System.Drawing.Point(555, 0);
            this.AM_AxisCRevButton.Name = "AM_AxisCRevButton";
            this.AM_AxisCRevButton.Size = new System.Drawing.Size(109, 30);
            this.AM_AxisCRevButton.TabIndex = 5;
            this.AM_AxisCRevButton.Text = "Ось C\'";
            this.AM_AxisCRevButton.UseVisualStyleBackColor = false;
            this.AM_AxisCRevButton.Click += new System.EventHandler(this.AM_AxisCRevButton_Click);
            // 
            // AM_AxisCButton
            // 
            this.AM_AxisCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.AM_AxisCButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AM_AxisCButton.Location = new System.Drawing.Point(450, 0);
            this.AM_AxisCButton.Name = "AM_AxisCButton";
            this.AM_AxisCButton.Size = new System.Drawing.Size(109, 30);
            this.AM_AxisCButton.TabIndex = 4;
            this.AM_AxisCButton.Text = "Ось C";
            this.AM_AxisCButton.UseVisualStyleBackColor = false;
            this.AM_AxisCButton.Click += new System.EventHandler(this.AM_AxisCButton_Click);
            // 
            // AM_AxisZButton
            // 
            this.AM_AxisZButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.AM_AxisZButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AM_AxisZButton.Location = new System.Drawing.Point(345, 0);
            this.AM_AxisZButton.Name = "AM_AxisZButton";
            this.AM_AxisZButton.Size = new System.Drawing.Size(109, 30);
            this.AM_AxisZButton.TabIndex = 3;
            this.AM_AxisZButton.Text = "Ось Z";
            this.AM_AxisZButton.UseVisualStyleBackColor = false;
            this.AM_AxisZButton.Click += new System.EventHandler(this.AM_AxisZButton_Click);
            // 
            // AM_AxisYButton
            // 
            this.AM_AxisYButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.AM_AxisYButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AM_AxisYButton.Location = new System.Drawing.Point(240, 0);
            this.AM_AxisYButton.Name = "AM_AxisYButton";
            this.AM_AxisYButton.Size = new System.Drawing.Size(109, 30);
            this.AM_AxisYButton.TabIndex = 2;
            this.AM_AxisYButton.Text = "Ось Y";
            this.AM_AxisYButton.UseVisualStyleBackColor = false;
            this.AM_AxisYButton.Click += new System.EventHandler(this.AM_AxisYButton_Click);
            // 
            // AM_AxisXButton
            // 
            this.AM_AxisXButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.AM_AxisXButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AM_AxisXButton.Location = new System.Drawing.Point(135, 0);
            this.AM_AxisXButton.Name = "AM_AxisXButton";
            this.AM_AxisXButton.Size = new System.Drawing.Size(109, 30);
            this.AM_AxisXButton.TabIndex = 1;
            this.AM_AxisXButton.Text = "Ось X";
            this.AM_AxisXButton.UseVisualStyleBackColor = false;
            this.AM_AxisXButton.Click += new System.EventHandler(this.AM_AxisXButton_Click);
            // 
            // AM_CNCButton
            // 
            this.AM_CNCButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(160)))), ((int)(((byte)(245)))));
            this.AM_CNCButton.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.AM_CNCButton.Location = new System.Drawing.Point(52, 0);
            this.AM_CNCButton.Name = "AM_CNCButton";
            this.AM_CNCButton.Size = new System.Drawing.Size(88, 30);
            this.AM_CNCButton.TabIndex = 0;
            this.AM_CNCButton.Text = "СЧПУ";
            this.AM_CNCButton.UseVisualStyleBackColor = false;
            this.AM_CNCButton.Click += new System.EventHandler(this.AM_CNCButton_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Тип станка:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(76, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Наименование станка:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(80, 549);
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
            this.label7.Text = "None";
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
            this.Controls.Add(this.StatusNdValuesPanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.BoxOfHeads);
            this.Controls.Add(this.BoxOfNames);
            this.Controls.Add(this.BoxOfTypes);
            this.Controls.Add(this.MainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MainPanel.ResumeLayout(false);
            this.InfoPanel.ResumeLayout(false);
            this.MachineActsPanel.ResumeLayout(false);
            this.AxisViewPanel.ResumeLayout(false);
            this.StatusNdValuesPanel.ResumeLayout(false);
            this.TemperatureValuesPanel.ResumeLayout(false);
            this.ChartPanel.ResumeLayout(false);
            this.ChartPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
            this.MessagesPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MessagesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Button MainButton;
        private Button AnalyzeButton;
        private ComboBox BoxOfTypes;
        private ComboBox BoxOfNames;
        private ComboBox BoxOfHeads;
        private Panel InfoPanel;
        private Panel StatusNdValuesPanel;
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
        private Button AM_CNCButton;
        private Button AM_AxisXButton;
        private Button AM_AxisYButton;
        private Button AM_SpiendelButton;
        private Button AM_AxisCRevButton;
        private Button AM_AxisCButton;
        private Button AM_AxisZButton;
        private Label AxisXPosValue;
        private Label AxisYPosValue;
        private Label AxisCPosValue;
        private Label AxisZPosValue;
        private Label AxisCInvertPosValue;
        private DataGridView MessagesDataGrid;
        private Label label32;
        private Label label36;
        private Label label35;
        private Label label34;
        private Label label33;
        private Panel TemperatureValuesPanel;
        private Label label41;
        private Label label40;
        private Label label39;
        private Label label38;
        private Label label37;
        private Label label42;
        private Label label51;
        private Label label50;
        private Label label49;
        private Label label48;
        private Label label47;
        private Label label46;
        private Label label45;
        private Label label44;
        private Label label43;
        private Button ReloadChartButton;
        private Panel StatusPanel;
        private Label label53;
        private Label label52;
        private Label label54;
        private Label label55;
    }
}

