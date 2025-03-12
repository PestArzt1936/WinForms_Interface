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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.MainButton = new System.Windows.Forms.Button();
            this.BoxOfNames = new System.Windows.Forms.ComboBox();
            this.BoxOfTypes = new System.Windows.Forms.ComboBox();
            this.BoxOfHeads = new System.Windows.Forms.ComboBox();
            this.InfoPanel = new System.Windows.Forms.Panel();
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
            this.ChartPanel = new System.Windows.Forms.Panel();
            this.temperatureChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.MessagesPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ProgrammButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.MachineActsPanel.SuspendLayout();
            this.AxisViewPanel.SuspendLayout();
            this.ChartPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).BeginInit();
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
            this.InfoPanel.Controls.Add(this.MachineActsPanel);
            this.InfoPanel.Controls.Add(this.AxisViewPanel);
            this.InfoPanel.Location = new System.Drawing.Point(78, 639);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(270, 329);
            this.InfoPanel.TabIndex = 4;
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
            this.StatusPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(112)))), ((int)(((byte)(125)))));
            this.StatusPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StatusPanel.Location = new System.Drawing.Point(441, 64);
            this.StatusPanel.Name = "StatusPanel";
            this.StatusPanel.Size = new System.Drawing.Size(615, 675);
            this.StatusPanel.TabIndex = 5;
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
            chartArea4.Name = "ChartArea1";
            this.temperatureChart.ChartAreas.Add(chartArea4);
            this.temperatureChart.Location = new System.Drawing.Point(0, 0);
            this.temperatureChart.Name = "temperatureChart";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.IsXValueIndexed = true;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.temperatureChart.Series.Add(series4);
            this.temperatureChart.Size = new System.Drawing.Size(710, 675);
            this.temperatureChart.TabIndex = 0;
            this.temperatureChart.Text = "Температура";
            // 
            // MessagesPanel
            // 
            this.MessagesPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            this.MessagesPanel.Location = new System.Drawing.Point(440, 784);
            this.MessagesPanel.Name = "MessagesPanel";
            this.MessagesPanel.Size = new System.Drawing.Size(1395, 240);
            this.MessagesPanel.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
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
            this.ChartPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.temperatureChart)).EndInit();
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
    }
}

