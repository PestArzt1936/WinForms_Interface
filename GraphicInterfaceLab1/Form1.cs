﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Protobuf.WellKnownTypes;
using GraphicInterfaceLab1;
using GraphicInterfaceLab1.Properties;
using MySql.Data.MySqlClient;

namespace GraphicInterfaceLab1
{
    public partial class Form1 : Form
    {
        private int timerCounter = 0;
        private SQLRuler SQLRuler;
        private MySqlDataAdapter adapter;
        private DataTable dt;
        private Button ActiveMessageState;
        private LimitedCollection<LogMessage> messages = new LimitedCollection<LogMessage>(6);
        private int Time = 1;
        Dictionary<string, int> map = new Dictionary<string, int>() { { "X", 1 }, { "Y", 2 }, { "Z", 3 }, { "C", 4 }, { "C'", 5 } };
        bool DrawChart= false;
        int TimeRowCount = 0;
        public Form1()
        {
            SQLRuler = new SQLRuler();
            adapter = new MySqlDataAdapter();
            dt = new DataTable();
            InitializeComponent();
            //Раздел активных сообщений
            this.Load += MessageDataForm;
            MessagesDataGrid.CellFormatting += MessagesDataGrid_CellFormating;
            ActiveMessageState = AM_CNCButton;
            //Инициализация левой части
            this.Load+=ComboBoxForm;
            //Инициализация формы
            this.Load += Form1_load;
            //Раздел графика
            this.Load += TemperatureChartForm;
            TemperatureValuesPanel.Paint += TemperatureValuesTable;
            //Настройка таймера
            timer1.Tick += Timer1_Tick;
            timer1.Start();
            //Раздел статусов и значений
            StatusNdValuesPanel.Paint += StatusNdValuesPanelPaint;
            StatusPanel.Paint += StatusPanelPaint;
            //Тесты
            //this.Load += ChartTest;
            //this.Load += MessageTest;
        }
        private void TemperatureChartForm(object sender, EventArgs e)
        {
            DateTime baseDate = System.DateTime.Today;

            temperatureChart.ChartAreas[0].AxisY.Minimum = 0;
            temperatureChart.ChartAreas[0].AxisY.Maximum = 120;
            temperatureChart.ChartAreas[0].AxisY.Interval = 20;
            temperatureChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(243)))));
            temperatureChart.ChartAreas[0].AxisY.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(243)))));

            temperatureChart.ChartAreas[0].AxisY.LabelStyle.Font = new Font("Calibri", 20, FontStyle.Bold, GraphicsUnit.Pixel);
            temperatureChart.ChartAreas[0].AxisY.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            temperatureChart.ChartAreas[0].AxisY.LineWidth = 2;
            temperatureChart.ChartAreas[0].AxisY.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;

            temperatureChart.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
            temperatureChart.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm";
            temperatureChart.ChartAreas[0].AxisX.Minimum = baseDate.AddHours(6).ToOADate();
            temperatureChart.ChartAreas[0].AxisX.Maximum = baseDate.AddHours(18).ToOADate();
            temperatureChart.ChartAreas[0].AxisX.Interval = 2;
            temperatureChart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(243)))));
            temperatureChart.ChartAreas[0].AxisX.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(233)))), ((int)(((byte)(243)))));

            temperatureChart.ChartAreas[0].AxisX.LabelStyle.Font = new Font("Calibri", 18, FontStyle.Bold, GraphicsUnit.Pixel);
            temperatureChart.ChartAreas[0].AxisX.LabelStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            temperatureChart.ChartAreas[0].AxisX.LineWidth = 2;
            temperatureChart.ChartAreas[0].AxisX.ArrowStyle = System.Windows.Forms.DataVisualization.Charting.AxisArrowStyle.Lines;

            temperatureChart.ChartAreas[0].BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            temperatureChart.Legends.Clear();
        }
        private async void Timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            try
            {

                if (BoxOfHeads.SelectedItem != null)
                {
                    if(SQLRuler.GetConnection().State == ConnectionState.Closed) {
                    SQLRuler.OpenConnection();
                    }
                    LabelsTempClear();
                    MySqlCommand command = new MySqlCommand("select * from dashboard.drive where id_mth=(select id_mth from dashboard.machine_tool_head where id_mtn=(select id_mtn from dashboard.machine_tool_name where id_mt=(SELECT id_mt FROM dashboard.machine_tool_type where type=\"" + BoxOfTypes.SelectedItem.ToString() + "\") and machine_tool_name=\"" + BoxOfNames.SelectedItem.ToString() + "\") and head_type=\"" + BoxOfHeads.SelectedItem.ToString() + "\");", SQLRuler.GetConnection());
                    adapter.SelectCommand = command;
                    dt.Clear();
                    adapter.Fill(dt);
                    MySqlCommand command1;
                    DataTable dt1 = new DataTable();
                    Dictionary<string, Label> CurTemp = new Dictionary<string, Label>() { { "X", AxisXTempCur }, { "Y", AxisYTempCur }, { "Z", AxisZTempCur }, { "C", AxisCTempCur }, { "C'", AxisCInvertTempCur } };
                    Dictionary<string, Label> AvgTemp = new Dictionary<string, Label>() { { "X", AxisXTempAvg }, { "Y", AxisYTempAvg }, { "Z", AxisZTempAvg }, { "C", AxisCTempAvg }, { "C'", AxisCInvertTempAvg } };
                    Dictionary<string, Label> MaxTemp = new Dictionary<string, Label>() { { "X", AxisXTempMax }, { "Y", AxisYTempMax }, { "Z", AxisZTempMax }, { "C", AxisCTempMax }, { "C'", AxisCInvertTempMax } };
                    for (int i = 1; i <= map.Count(); i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            command1 = new MySqlCommand("select * from dashboard.temperature where id_drive=" + row["id_drive"] + ";", SQLRuler.GetConnection());
                            adapter.SelectCommand = command1;
                            dt1.Clear();
                            adapter.Fill(dt1);
                            //if (row["drive_name"].ToString()=="Z")
                            //{
                           //     MessageBox.Show(row["id_drive"].ToString());
                           // }
                            if (i == map[row["drive_name"].ToString()] && dt1.Rows.Count!=0)
                            {
                                CurTemp[row["drive_name"].ToString()].Text = dt1.Rows[timerCounter]["current_temp"].ToString();
                                MySqlCommand command2 = new MySqlCommand("select avg(current_temp) from dashboard.temperature where id_drive=" + row["id_drive"] + ";",SQLRuler.GetConnection());
                                adapter.SelectCommand = command2;
                                DataTable dt2 = new DataTable();
                                adapter.Fill(dt2);
                                AvgTemp[row["drive_name"].ToString()].Text = dt2.Rows[0][0].ToString();
                                MaxTemp[row["drive_name"].ToString()].Text = dt1.Rows[timerCounter]["max_temp"].ToString();
                                break;
                            }
                        }
                    }
                    ChartAddPoint();
                    timerCounter = timerCounter==0 ? 1 : 0;
                }
                else
                {
                    timerCounter = 0;
                }
            }
            catch(Exception ex) {
                MessageBox.Show($"Ошибка:{ex.Message}");
            }
            finally
            {
                if (SQLRuler.GetConnection().State == ConnectionState.Open)
                {
                    SQLRuler.CloseConnection();
                }
                timer1.Start();
            }
        }
        void LabelsTempClear()
        {
            //Стирание данных температуры для оси X
            AxisXTempCur.Text = "0.0";
            AxisXTempCur.Invalidate();
            AxisXTempAvg.Text = "0.0";
            AxisXTempAvg.Invalidate();
            AxisXTempMax.Text = "0.0";
            AxisXTempMax.Invalidate();
            //Стирание данных температуры для оси Y
            AxisYTempCur.Text = "0.0";
            AxisYTempCur.Invalidate();
            AxisYTempAvg.Text = "0.0";
            AxisYTempAvg.Invalidate();
            AxisYTempMax.Text = "0.0";
            AxisYTempMax.Invalidate();
            //Стирание данных температуры для оси Z
            AxisZTempCur.Text = "0.0";
            AxisZTempCur.Invalidate();
            AxisZTempAvg.Text = "0.0";
            AxisZTempAvg.Invalidate();
            AxisZTempMax.Text = "0.0";
            AxisZTempMax.Invalidate();
            //Стирание данных температуры для шпинделя C
            AxisCTempCur.Text = "0.0";
            AxisCTempCur.Invalidate();
            AxisCTempAvg.Text = "0.0";
            AxisCTempAvg.Invalidate();
            AxisCTempMax.Text = "0.0";
            AxisCTempMax.Invalidate();
            //Стирание данных температуры для шпинделя C'
            AxisCInvertTempCur.Text = "0.0";
            AxisCInvertTempCur.Invalidate();
            AxisCInvertTempAvg.Text = "0.0";
            AxisCInvertTempAvg.Invalidate();
            AxisCInvertTempMax.Text = "0.0";
            AxisCInvertTempMax.Invalidate();
        }
        void LabelsPosClear()
        {
            AxisXPosValue.Text = "0.0";
            AxisXPosValue.Invalidate();
            AxisYPosValue.Text = "0.0";
            AxisYPosValue.Invalidate();
            AxisZPosValue.Text = "0.0";
            AxisZPosValue.Invalidate();
            AxisCPosValue.Text = "0° 0' 0\"";
            AxisCPosValue.Invalidate();
            AxisCInvertPosValue.Text = "0° 0' 0\"";
            AxisCInvertPosValue.Invalidate();
        }
        private void Form1_load(object sender,EventArgs e)
        {
            try
            {
                SQLRuler.OpenConnection();
                AddNewMessage("info", 0, 10, "Подключение к базе было установлено.");
                MySqlCommand command = new MySqlCommand("SELECT * FROM dashboard.machine_tool_type;", SQLRuler.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                BoxOfTypes.Items.Clear();
                foreach(DataRow row in dt.Rows)
                {
                    BoxOfTypes.Items.Add(row["type"].ToString());
                }
                BoxOfTypes.Refresh();
                if (BoxOfTypes.Items.Count > 0)
                    BoxOfTypes.SelectedIndex = 0;
            }
            catch (Exception exception)
            {
                AddNewMessage("warn", 0, 666, (string)exception.Message);
            }
            finally
            {
                if(SQLRuler.GetConnection().State  == ConnectionState.Open)
                SQLRuler.CloseConnection();
            }
        }
        private void StatusNdValuesPanelPaint(object sender, PaintEventArgs e)
        {
            StatusNdValuesPanel = (Panel)sender;
            using (Pen pen = new Pen(System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(86)))), ((int)(((byte)(97))))), 4))
            {
                e.Graphics.DrawLine(pen, 0, 343, StatusNdValuesPanel.Width, 343);
            }
            using (Brush brush = new SolidBrush(System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))))))
            {
                e.Graphics.FillEllipse(brush, 20, 20, 18, 18);
            }
            using (Brush brush = new SolidBrush(System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))))))
            {
                e.Graphics.FillEllipse(brush, 89, 20, 18, 18);
            }
        }
        private void StatusPanelPaint(object sender, PaintEventArgs e)
        {
            StatusPanel = (Panel)sender;
            Color Active = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(174)))), ((int)(((byte)(224)))));
            Color Disarmed = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(118)))), ((int)(((byte)(132)))));
            Color Choose = new Color();
            
            LabelsPosClear();
            if (BoxOfHeads.SelectedItem == null)
            {
                Choose = Disarmed;
                for (int i = 1; i < 6; i++)
                    using (Brush brush = new SolidBrush(Choose))
                    {

                        e.Graphics.FillEllipse(brush, 1, 1 + (53 * (i - 1)), 49, 30);
                    }
            }
            else
            {
                if (SQLRuler.GetConnection().State == ConnectionState.Closed)
                    SQLRuler.OpenConnection();
                MySqlCommand command;
                MySqlCommand command2;
                Dictionary<string,Label> labels = new Dictionary<string, Label>() { { "X", AxisXPosValue },{ "Y", AxisYPosValue },{ "Z", AxisZPosValue },{ "C", AxisCPosValue },{ "C'", AxisCInvertPosValue } };
                DataTable dt2 = new DataTable();
                command = new MySqlCommand("select * from dashboard.drive where id_mth=(select id_mth from dashboard.machine_tool_head where id_mtn=(select id_mtn from dashboard.machine_tool_name where id_mt=(SELECT id_mt FROM dashboard.machine_tool_type where type=\""+BoxOfTypes.SelectedItem.ToString()+"\") and machine_tool_name=\""+BoxOfNames.SelectedItem.ToString()+"\") and head_type=\""+BoxOfHeads.SelectedItem.ToString()+"\");", SQLRuler.GetConnection());
                adapter.SelectCommand = command;
                dt.Clear();
                adapter.Fill(dt);
                command2 = new MySqlCommand("select * from dashboard.position where id_drive between " + dt.Rows[0]["id_drive"] + " and " + dt.Rows[dt.Rows.Count - 1]["id_drive"].ToString() + ";", SQLRuler.GetConnection());
                adapter.SelectCommand = command2;
                adapter.Fill(dt2);
                for (int j = 1; j < 6; j++)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        if (j == map[row["drive_name"].ToString()] && Convert.ToInt32(row["drive_status"].ToString()) == 1)
                        {
                            Choose = Active;
                            foreach(DataRow rr in dt2.Rows)
                            {
                                if (rr["id_drive"].ToString() == row["id_drive"].ToString())
                                {
                                    labels[row["drive_name"].ToString()].Text=rr["value"].ToString();
                                    labels[row["drive_name"].ToString()].Invalidate();
                                    //MessageBox.Show(rr["value"].ToString());
                                    break;
                                }
                            }
                            break;
                        }
                        else if (j == map[row["drive_name"].ToString()] && Convert.ToInt32(row["drive_status"].ToString()) == 0)
                        {
                            Choose = Disarmed;
                            foreach (DataRow rr in dt2.Rows)
                            {
                                if (rr["id_drive"].ToString() == row["id_drive"].ToString())
                                {
                                    labels[row["drive_name"].ToString()].Text = rr["value"].ToString();
                                    labels[row["drive_name"].ToString()].Invalidate();
                                    //MessageBox.Show(rr["value"].ToString());
                                    break;
                                }
                            }
                            break;
                        }
                        else
                            Choose = Disarmed;
                    }
                    using (Brush brush = new SolidBrush(Choose))
                    {

                        e.Graphics.FillEllipse(brush, 1, 1 + (53 * (j - 1)), 49, 30);
                    }
                }
                labels.Clear();
                dt2.Clear();
                if (SQLRuler.GetConnection().State == ConnectionState.Open)
                    SQLRuler.CloseConnection();
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
            Image icon;
            if(Type == "warn")
            {
                icon = Properties.Resources.attention_circle;
            }
            else if(Type == "info" || Type=="set")
            {
                icon = Properties.Resources.message_checked;
            }
            else
            {
                icon = Properties.Resources.help_circle;
            }
            messages.Add(new LogMessage
            {
                ErrorType = icon,
                Time = DateTime.Now.ToString("HH:mm:ss"),
                Type = Type,
                Tunnel = Tunnel,
                Code = Code,
                Description = Description
            });
            MessagesDataGrid.FirstDisplayedScrollingRowIndex = MessagesDataGrid.RowCount-1;
            MessagesDataGrid.ClearSelection();
            MessagesDataGrid.CurrentCell = null;
        }
        private void MessageTest(object sender, EventArgs e)
        {
            AddNewMessage("warn", 1, 404, "Something went wrong");
            AddNewMessage("warn", 3, 502, "DriveController не инициализирован");
            AddNewMessage("set", 0, 2300, "Постоянный циклы загружены успешно");
            AddNewMessage("warn", 0, 333, "ArtFireLib: OS ядра - семейства Windows, но не XP. Возможны проблемы при взаимодей...");
            AddNewMessage("info", 0, 1822, "Файловая система станка в норме.");
            AddNewMessage("info", 2, 5, "Connection succesful");
            MessagesDataGrid.Invalidate();
        }
        private void MessagesDataGrid_CellFormating(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == MessagesDataGrid.Columns["Type"].Index && e.RowIndex >=0)
            {
                DataGridViewCell cell = MessagesDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex-1];
                string type = (string)e.Value;
                if(type == "warn")
                {
                    cell.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(101)))), ((int)(((byte)(101)))));
                }
                else if (type == "info" || type=="set")
                {
                    cell.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(220)))), ((int)(((byte)(146)))));
                }
                else
                {
                    cell.Style.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(136)))), ((int)(((byte)(209)))));
                }
            }
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
            MessagesDataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            MessagesDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(86)))), ((int)(((byte)(97)))));
            MessagesDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;

            DataGridViewImageColumn IconColumn = new DataGridViewImageColumn();
            IconColumn.Name = "ErrorType";
            IconColumn.HeaderText = " ";
            IconColumn.Width = 52;
            IconColumn.DataPropertyName = "ErrorType";
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
            ActiveMessageState.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(175)))), ((int)(((byte)(186)))));
            ActiveMessageState = sender as Button;
            ActiveMessageState.BackColor= System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(160)))), ((int)(((byte)(245)))));
        }
        private void ComboBoxForm(object sender, EventArgs e)
        {
            //BoxOfTypes
            BoxOfTypes.AutoCompleteSource = AutoCompleteSource.ListItems;
            BoxOfTypes.DrawItem += BoxOfTypes_DrawItem;
            BoxOfTypes.Paint += BoxOfTypes_Paint;
            BoxOfTypes.Height = 55;
            //BoxOfNames
            BoxOfNames.AutoCompleteSource = AutoCompleteSource.ListItems;
            BoxOfNames.DrawItem += BoxOfTypes_DrawItem;
            BoxOfNames.Paint += BoxOfTypes_Paint;
            //BoxOfHeads
            BoxOfHeads.AutoCompleteSource = AutoCompleteSource.ListItems;
            BoxOfHeads.DrawItem += BoxOfTypes_DrawItem;
            BoxOfHeads.Paint += BoxOfTypes_Paint;
        }
        private void BoxOfTypes_Paint(object sender, PaintEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if (box==null)
                return;

            // Текст для отображения (выбранный элемент или введённый текст)
            string text = box.SelectedItem?.ToString() ?? BoxOfTypes.Text;
            if(string.IsNullOrEmpty(text)) return;
            // Настройки выравнивания
            StringFormat boxformat = new StringFormat
            {
                Alignment = StringAlignment.Near,
                LineAlignment = StringAlignment.Center
            };

            // Рисуем текст
            using (Brush brush = new SolidBrush(BoxOfTypes.ForeColor))
            {
                e.Graphics.DrawString(
                    text,
                    box.Font,
                    brush,
                    box.ClientRectangle,
                    boxformat
                );
            }
        }
        private void BoxOfTypes_DrawItem(object sender, DrawItemEventArgs e)
        {
            ComboBox box = (ComboBox)sender;
            if(box==null || e.Index< 0) return;
            e.DrawBackground();

                StringFormat itemformat = new StringFormat
                {
                    Alignment = StringAlignment.Near,
                    LineAlignment = StringAlignment.Center
                };
                using (Brush brush = new SolidBrush(e.ForeColor))
                {
                    e.Graphics.DrawString(
                        box.Items[e.Index].ToString(),
                        e.Font,
                        brush,
                        e.Bounds,
                        itemformat
                    );
                }
            e.DrawFocusRectangle();
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

        private void BoxOfTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if(SQLRuler.GetConnection().State == ConnectionState.Closed)
                SQLRuler.OpenConnection();
                MySqlCommand command;
                command = new MySqlCommand("select * from dashboard.machine_tool_name where id_mt=(SELECT id_mt FROM dashboard.machine_tool_type where type=\"" + BoxOfTypes.SelectedItem.ToString()+"\");", SQLRuler.GetConnection());
                adapter.SelectCommand = command;
                dt.Clear();
                adapter.Fill(dt);
                BoxOfNames.Items.Clear();
                foreach (DataRow rows in dt.Rows)
                {
                    BoxOfNames.Items.Add(rows["machine_tool_name"].ToString());
                }
                BoxOfNames.Refresh();
                if (BoxOfNames.Items.Count > 0)
                    BoxOfNames.SelectedIndex = 0;
                else
                {
                    BoxOfHeads.Items.Clear();
                    LabelsPosClear();
                }
            }
            catch ( Exception ex )
            {
                AddNewMessage("warn", 0, 666, (string)ex.Message);
            }
            finally
            {
                Time = 0;
                if (SQLRuler.GetConnection().State == ConnectionState.Open)
                    SQLRuler.CloseConnection();
            }
        }
        private void GetMessages()
        {
            MySqlCommand command;
            command = new MySqlCommand("select * from dashboard.machine_tool_state where id_mtn=(select id_mtn from dashboard.machine_tool_name where id_mt=(select id_mt from dashboard.machine_tool_type where type=\"" + BoxOfTypes.SelectedItem.ToString() + "\") and machine_tool_name=\"" + BoxOfNames.SelectedItem.ToString() + "\");", SQLRuler.GetConnection());
            adapter.SelectCommand = command;
            dt.Clear();
            adapter.Fill(dt);
            foreach (DataRow rows in dt.Rows)
            {
                AddNewMessage(rows["status_type"].ToString(), Convert.ToInt32(rows["channel"].ToString()), Convert.ToInt32(rows["number"].ToString()), rows["description"].ToString());
            }
        }
        private void BoxOfNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoxOfNames.SelectedItem != null)
            {
                TextNameOfMachine.Text= BoxOfNames.SelectedItem.ToString();
                TextTypeNName.Text= BoxOfTypes.SelectedItem.ToString()+" "+ BoxOfNames.SelectedItem.ToString();
                Image machineImage = (Image)Properties.Resources.ResourceManager.GetObject(BoxOfNames.SelectedItem.ToString());
                MachineImage.Image = machineImage;
                
            }
            else
            {
                TextNameOfMachine.Text = "None";
                TextTypeNName.Text= "None";
            }
            try
            {
                if (SQLRuler.GetConnection().State == ConnectionState.Closed)
                    SQLRuler.OpenConnection();
                MySqlCommand command;
                command = new MySqlCommand("select * from dashboard.machine_tool_head where id_mtn=(select id_mtn from dashboard.machine_tool_name where machine_tool_name=\"" + BoxOfNames.SelectedItem.ToString()+"\");", SQLRuler.GetConnection());
                adapter.SelectCommand = command;
                dt.Clear();
                adapter.Fill(dt);
                BoxOfHeads.Items.Clear();
                foreach (DataRow rows in dt.Rows)
                {
                    BoxOfHeads.Items.Add(rows["head_type"].ToString());
                }
                BoxOfHeads.Refresh();
                GetMessages();
                if (BoxOfHeads.Items.Count > 0)
                    BoxOfHeads.SelectedIndex = 0;
                else
                {
                    LabelsPosClear();
                    LabelsTempClear();
                }
            }
            catch (Exception ex)
            {
                AddNewMessage("Warn", 0, 666, (string)ex.Message);
            }
            finally
            {
                Time = 0;
                if (SQLRuler.GetConnection().State == ConnectionState.Open)
                    SQLRuler.CloseConnection();
            }
        }

        private void BoxOfHeads_SelectedIndexChanged(object sender, EventArgs e)
        {
            Time = 0;
            StatusPanel.Invalidate();
            LabelsPosClear();
            LabelsTempClear();
            DrawChart = false;
        }
        void ChartAddPoint()
        {
            if (DrawChart)
            {
                try
                {
                    MySqlCommand command = new MySqlCommand("select * from dashboard.temperature where id_drive = (select id_drive from dashboard.drive where id_mth=(select id_mth from dashboard.machine_tool_head where id_mtn=(select id_mtn from dashboard.machine_tool_name where id_mt=(SELECT id_mt FROM dashboard.machine_tool_type where type=\"" + BoxOfTypes.SelectedItem.ToString() + "\") and machine_tool_name=\"" + BoxOfNames.SelectedItem.ToString() + "\") and head_type=\"" + BoxOfHeads.SelectedItem.ToString() + "\") and (drive_name=\"C\" or drive_name=\"C'\"));", SQLRuler.GetConnection());
                    adapter.SelectCommand = command;
                    dt.Clear();
                    adapter.Fill(dt);
                    if(dt.Rows.Count > 0)
                    {
                        TimeRowCount = dt.Rows.Count;
                        DateTime baseDate = new DateTime(DateTime.Parse(dt.Rows[0]["time"].ToString()).Year, DateTime.Parse(dt.Rows[0]["time"].ToString()).Month, DateTime.Parse(dt.Rows[0]["time"].ToString()).Day);
                        System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series("Температура привода");
                        series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                        series.Color = Color.Red;
                        series.BorderWidth = 2;
                        for (int i = 0; i < Time;i++) {
                            series.Points.AddXY(DateTime.Parse(dt.Rows[i]["time"].ToString()), Convert.ToDouble(dt.Rows[i]["current_temp"].ToString())); 
                        }
                        temperatureChart.ChartAreas[0].AxisX.Minimum = baseDate.AddHours(6).ToOADate();
                        temperatureChart.ChartAreas[0].AxisX.Maximum = baseDate.AddHours(18).ToOADate();
                        temperatureChart.Series.Clear();
                        temperatureChart.Series.Add(series);
                        temperatureChart.Invalidate();
                        if(Time<TimeRowCount)
                        Time++;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка:{ex.Message}");
                }
                finally
                {

                }
            }
            else
            {
                Time = 0;
                TimeRowCount = 0;
            }
        }
        private void ReloadChartButton_Click(object sender, EventArgs e)
        {
            if (BoxOfHeads.Items.Count > 0 && DrawChart==false)
            {
                DrawChart = true;
                ChartAddPoint();
            }
            else if(!(BoxOfHeads.Items.Count > 0))
            {
                DrawChart = false;
                Time = 0;
            }
            
            }
    }
}
