using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GraphicInterfaceLab1;
using GraphicInterfaceLab1.Properties;

namespace GraphicInterfaceLab1
{
    public partial class Form1 : Form
    {
        private byte ActiveMessageState;
        private Button[] ActiveMessagesButtons = new Button[7];
        private LimitedCollection<LogMessage> messages = new LimitedCollection<LogMessage>(6);

        private void Initialization()
        {
            ActiveMessagesButtons[0] = AM_CNCButton;
            ActiveMessagesButtons[1] = AM_AxisXButton;
            ActiveMessagesButtons[2] = AM_AxisYButton;
            ActiveMessagesButtons[3] = AM_AxisZButton;
            ActiveMessagesButtons[4] = AM_AxisCButton;
            ActiveMessagesButtons[5] = AM_AxisCRevButton;
            ActiveMessagesButtons[6] = AM_SpiendelButton;
            ActiveMessageState = 0;
        }
        public Form1()
        {
            InitializeComponent();
            Initialization();
            this.Load += Form1_load;
            this.Load += ChartTest;
            this.Load += MessageDataForm;
            this.Load += MessageTest;
            TemperatureValuesPanel.Paint += TemperatureValuesTable;
            StatusPanel.Paint += StatusPanelPaint;
        }
        private void Form1_load(object sender,EventArgs e)
        {
            DateTime baseDate = System.DateTime.Today;
            temperatureChart.ChartAreas[0].AxisY.Title = "T, C";
            temperatureChart.ChartAreas[0].AxisY.Minimum = 0;
            temperatureChart.ChartAreas[0].AxisY.Maximum = 120;
            temperatureChart.ChartAreas[0].AxisY.Interval = 20;
            temperatureChart.ChartAreas[0].AxisY.MajorGrid.LineColor= System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(243)))));
            temperatureChart.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(243)))));

            temperatureChart.ChartAreas[0].AxisX.Title = "t, cек";
            temperatureChart.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            temperatureChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
            temperatureChart.ChartAreas[0].AxisX.Minimum =baseDate.AddHours(6).ToOADate();
           temperatureChart.ChartAreas[0].AxisX.Maximum = baseDate.AddHours(18).ToOADate();
            temperatureChart.ChartAreas[0].AxisX.Interval = 2;
            temperatureChart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(243)))));
            temperatureChart.ChartAreas[0].AxisX.LineColor= System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(243)))));

            temperatureChart.ChartAreas[0].BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            temperatureChart.Legends.Clear();
        }
        private void StatusPanelPaint(object sender, PaintEventArgs e)
        {
            StatusPanel = (Panel)sender;
            using (Pen pen = new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(86)))), ((int)(((byte)(97))))), 4))
            {
                e.Graphics.DrawLine(pen, 0, 343, StatusPanel.Width, 343);
            }
        }
        private void TemperatureValuesTable(object sender, PaintEventArgs e)
        {
            TemperatureValuesPanel = (Panel)sender;
            using (Pen pen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawLine(pen, 126, 0, 126, TemperatureValuesPanel.Height-10);
                e.Graphics.DrawLine(pen, 247, 0, 247, TemperatureValuesPanel.Height-10);
                int i = 0;
                for (int y = 47; y < TemperatureValuesPanel.Height; y += 49)
                {
                    i++;
                    e.Graphics.DrawLine(pen, 0, y, TemperatureValuesPanel.Width, y);
                    if (i == 4)
                        break;
                }
            }
        }
        private void ChartTest(object sender,EventArgs e)
        {
            System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Температура привода");
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series.Color = Color.Red;
            series.BorderWidth = 2;
            DateTime Test = System.DateTime.Today;
            series.Points.AddXY(Test.AddHours(6), 20);
            series.Points.AddXY(Test.AddHours(7), 20);
            series.Points.AddXY(Test.AddHours(8), 40);
            series.Points.AddXY(Test.AddHours(9), 60);
            series.Points.AddXY(Test.AddHours(10), 65);
            series.Points.AddXY(Test.AddHours(12), 80);
            series.Points.AddXY(Test.AddHours(14), 76);
            series.Points.AddXY(Test.AddHours(16), 40);
            series.Points.AddXY(Test.AddHours(18), 20);
            temperatureChart.Series.Add(series);
        }
        public void AddNewMessage(string Type,int Tunnel, int Code, string Description)
        {
            Image icon = (Type == "Warn")
                 ? Properties.Resources.attention_circle
                 : Properties.Resources.help_circle;
            messages.Add(new LogMessage
            {
                Image = icon,
                Time = DateTime.Now.ToString("HH:mm:ss"),
                Type = Type,
                Tunnel = Tunnel,
                Code = Code,
                Description = Description
            });
            MessagesDataGrid.FirstDisplayedScrollingRowIndex = MessagesDataGrid.RowCount-1;
        }
        private void MessageTest(object sender, EventArgs e)
        {
            AddNewMessage("Warn", 1, 404, "Something went wrong");
            AddNewMessage("Info", 2, 5, "Connection succesful");
            AddNewMessage("Info", 2, 5, "Connection succesful");
            AddNewMessage("Info", 2, 5, "Connection succesful");
            AddNewMessage("Info", 2, 5, "Connection succesful");
            AddNewMessage("Info", 2, 5, "Connection succesful");
        }
        private void MessageDataForm(object sender, EventArgs e)
        {
            MessagesDataGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            MessagesDataGrid.AutoGenerateColumns = false;
            MessagesDataGrid.Columns.Clear();
            MessagesDataGrid.ReadOnly = true;

            MessagesDataGrid.DefaultCellStyle.NullValue = null;
            MessagesDataGrid.EnableHeadersVisualStyles = false;
            MessagesDataGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(121)))), ((int)(((byte)(136)))));
            MessagesDataGrid.RowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(207)))), ((int)(((byte)(207)))));
            MessagesDataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            MessagesDataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.Transparent;
            MessagesDataGrid.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            MessagesDataGrid.ColumnHeadersHeight = 27;
            MessagesDataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            DataGridViewImageColumn IconColumn = new DataGridViewImageColumn();
            IconColumn.Name = "ErrorType";
            IconColumn.HeaderText = " ";
            IconColumn.Width = 52;
            IconColumn.DataPropertyName = "Image";
            IconColumn.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            MessagesDataGrid.Columns.Add(IconColumn);

            DataGridViewTextBoxColumn ViewColumn = new DataGridViewTextBoxColumn();
            ViewColumn.Name = "Type";
            ViewColumn.HeaderText = "Вид";
            ViewColumn.Width = 83;
            ViewColumn.DataPropertyName = "Type";
            ViewColumn.DefaultCellStyle.SelectionBackColor= System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(196)))), ((int)(((byte)(238)))));
            MessagesDataGrid.Columns.Add(ViewColumn);

            DataGridViewTextBoxColumn TimeColumn = new DataGridViewTextBoxColumn();
            TimeColumn.Name = "Time";
            TimeColumn.HeaderText = "Время";
            TimeColumn.Width = 105;
            TimeColumn.DataPropertyName = "Time";
            TimeColumn.DefaultCellStyle.SelectionBackColor= System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(196)))), ((int)(((byte)(238)))));
            MessagesDataGrid.Columns.Add(TimeColumn);

            DataGridViewTextBoxColumn TunnelColumn = new DataGridViewTextBoxColumn();
            TunnelColumn.Name = "Tunnel";
            TunnelColumn.HeaderText = "Канал";
            TunnelColumn.Width = 105;
            TunnelColumn.DataPropertyName = "Tunnel";
            TunnelColumn.DefaultCellStyle.SelectionBackColor= System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(196)))), ((int)(((byte)(238)))));
            MessagesDataGrid.Columns.Add(TunnelColumn);

            DataGridViewTextBoxColumn CodeColumn = new DataGridViewTextBoxColumn();
            CodeColumn.Name = "Code";
            CodeColumn.HeaderText = "Номер";
            CodeColumn.Width = 105;
            CodeColumn.DataPropertyName = "Code";
            CodeColumn.DefaultCellStyle.SelectionBackColor= System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(196)))), ((int)(((byte)(238)))));
            MessagesDataGrid.Columns.Add(CodeColumn);

            DataGridViewTextBoxColumn DescColumn = new DataGridViewTextBoxColumn();
            DescColumn.Name = "Description";
            DescColumn.HeaderText = "Текст";
            DescColumn.Width = 940;
            DescColumn.DataPropertyName = "Description";
            DescColumn.DefaultCellStyle.SelectionBackColor= System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(196)))), ((int)(((byte)(238)))));
            MessagesDataGrid.Columns.Add(DescColumn);

            MessagesDataGrid.RowTemplate.Height = 28;
            MessagesDataGrid.DataSource = messages;

        }
        private void ChangeActiveMessageState(object sender)
        {
            ActiveMessagesButtons[Convert.ToInt32(ActiveMessageState)].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            for(int j = 0; j < ActiveMessagesButtons.Length; j++)
            {
                if (ActiveMessagesButtons[j] == sender) {
                    ActiveMessageState = Convert.ToByte(j);
                    ActiveMessagesButtons[j].BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(160)))), ((int)(((byte)(245)))));
                }
            }
            
        }
        private void AM_CNCButton_Click(object sender, EventArgs e)
        {
            ChangeActiveMessageState(sender);
        }

        private void AM_AxisXButton_Click(object sender, EventArgs e)
        {
            ChangeActiveMessageState(sender);
        }

        private void AM_AxisYButton_Click(object sender, EventArgs e)
        {
            ChangeActiveMessageState(sender);
        }

        private void AM_AxisZButton_Click(object sender, EventArgs e)
        {
            ChangeActiveMessageState(sender);
        }

        private void AM_AxisCButton_Click(object sender, EventArgs e)
        {
            ChangeActiveMessageState(sender);
        }

        private void AM_AxisCRevButton_Click(object sender, EventArgs e)
        {
            ChangeActiveMessageState(sender);
        }

        private void AM_SpiendelButton_Click(object sender, EventArgs e)
        {
            ChangeActiveMessageState(sender);
        }
    }
}
