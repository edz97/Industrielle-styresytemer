using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        SerialPort serialPort;
        List<double> xValues = new List<double>();
        List<double> yValues = new List<double>();
        List<double> HighTempValues = new List<double>();
        List<double> HighHighTempValues = new List<double>();
        List<double> LowTempValues = new List<double>();
        List<double> LowLowTempValues = new List<double>();
        List<string> AlarmIDList= new List<string>();
        List<string> ActiveAlarmList = new List<string>();
        string filePath = @"C:\C# alarms\Alarm.txt";
         
        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 3000;
            timer1.Start();

            serialPort = new SerialPort("COM3", 9600);
            serialPort.Open();


        }


        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool haveTemperature = false;
            string temperature = string.Empty;

            while (!haveTemperature)
            {
                temperature = serialPort.ReadLine();
                if (!string.IsNullOrEmpty(temperature))
                {
                    haveTemperature = true;
                }
            }


            if (haveTemperature)
            {
                richTextBox1.AppendText(temperature);
            }
            double dataFixed;
            long data;
            bool result = long.TryParse(temperature, out data);

            if (result)
            {
                dataFixed = data;
                yValues.Add(dataFixed);
                // int lenght = xValues.Count + 1;
                // x .Add(lenght);
                // i know this is bad code and im 100% sure its a better way to do it but i had limited time
                HighTempValues.Add(32);
                HighHighTempValues.Add(40);
                LowTempValues.Add(15);
                LowLowTempValues.Add(10);
                uppdateTempChart();

                raiseAlarm(data);
                RaiseVarning(data);



            }

            //chart1.Series["Series1"].Points.DataBindXY(xValues, yValues);
            //chart1.Invalidate();
        }

        private void uppdateTempChart()
        {
            chart1.Series["Temperature"].Points.DataBindY(yValues);
            chart1.Series["TemperatureHighVarning"].Points.DataBindY(HighTempValues);
            chart1.Series["TemperatureHighAlarm"].Points.DataBindY(HighHighTempValues);
            chart1.Series["TemperatureLowVarning"].Points.DataBindY(LowTempValues);
            chart1.Series["TemperatureLowAlarm"].Points.DataBindY(LowLowTempValues);
            chart1.Invalidate(); // refreshes the chart

            //  only display the 10 last values
            if (yValues.Count > 10)
            {
                yValues.RemoveAt(0);
                HighTempValues.RemoveAt(0);
                HighHighTempValues.RemoveAt(0);
                LowTempValues.RemoveAt(0);
                LowLowTempValues.RemoveAt(0);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            //dataGridView1.Rows.Add("kathir", "25", "salem");
            //string alarmId = AlarmIDList.Count.ToString();
            //AlarmIDList.Add(alarmId);
            
            // dataGridView1.Rows.Add(alarmId, "temperature1", "Temperature over failsafe limit", "failsafe", "40", "todo", "todo");


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ScrollToCaret();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            string data = "";

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                // take data from row

                string alarmToRemove = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();

                for (int i = 0; i < 6; i++)
                {
                    data = data + dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString() + ",";
                    

                }
                ActiveAlarmList.Remove(alarmToRemove);


                dataGridView1.Rows.RemoveAt(e.RowIndex);
                //var Timestamp = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
                int Timestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
                string unixConvertet = UnixToDate(Timestamp, "HH:mm:ss"); // Output 16:32:52
                data = data + unixConvertet;

                WriteToFile(data); 

            }
        }


        private void WriteToFile(string text)
        {
            using (StreamWriter outputFile = new StreamWriter(filePath, true))
            {
                outputFile.WriteLine(text);
            }

        }

        internal static string UnixToDate(int Timestamp, string ConvertFormat)
        {
            DateTime ConvertedUnixTime = DateTimeOffset.FromUnixTimeSeconds(Timestamp).DateTime;
            return ConvertedUnixTime.ToString(ConvertFormat);
        }

        //int Timestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;

        private void raiseAlarm(long temperature)
        {
            bool highTempAlarm = false;
            bool lowTempAlarm = false;

            // timestamp
            int Timestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            string unixConvertet = UnixToDate(Timestamp, "HH:mm:ss"); // Output 16:32:52


            string HighTempAlarmString = "temperature1HighAlarm";

            string lowTempAlarmString = "temperature1LowAlarm";

            if (temperature > 40)
            {
                highTempAlarm = true;
            }
            if (temperature < 10)
            {
                lowTempAlarm = true;
            }

            if (highTempAlarm)
            {
                bool flag = true;
                // check if alarm is already raised

                foreach (var item in ActiveAlarmList)
                {
                    if (item.Equals(HighTempAlarmString))
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    string alarmId = AlarmIDList.Count.ToString();
                    AlarmIDList.Add(alarmId);
                    dataGridView1.Rows.Add(alarmId, HighTempAlarmString, "Temperature over failsafe limit", "failsafe", "40", unixConvertet, "not acknowlaged");

                    ActiveAlarmList.Add(HighTempAlarmString);

                    HighAlarm highAlarm = new HighAlarm("TEMPERATURE ABOVE LIMIT FAILSAFE IS ON");
                    highAlarm.Show();
                }

            }

            if (lowTempAlarm)
            {
                bool flag = true;
                // check if alarm is already raised

                foreach (var item in ActiveAlarmList)
                {
                    if (item.Equals(lowTempAlarmString))
                    {
                        flag = false;
                    }
                }

                if (flag)
                {
                    string alarmId = AlarmIDList.Count.ToString();
                    AlarmIDList.Add(alarmId);
                    dataGridView1.Rows.Add(alarmId, lowTempAlarmString, "Temperature critical low", "Critical alarm", "10", unixConvertet, "not acknowlaged");

                    ActiveAlarmList.Add(lowTempAlarmString);

                    // display alarm form
                    HighAlarm highAlarm = new HighAlarm("TEMPERATURE BELOW LIMIT");
                    highAlarm.Show();


                }

            }
        }

        private void RaiseVarning(long temperature)
        {
            bool highTempVarning = false;
            bool lowTempVarning = false;

            // timestamp
            int Timestamp = (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            string unixConvertet = UnixToDate(Timestamp, "HH:mm:ss"); // Output 16:32:52


            if (temperature > 30 & temperature < 40)
            {
                highTempVarning = true;
            }
            if (temperature < 15 & temperature > 10)
            {
                lowTempVarning = true;
            }

            string highTempvVarningString = "temperature1HighVarning";
            string lowTempString = "temperature1LowVarning";

            if (highTempVarning)
            {
                bool flag = true;
                // check if alarm is already raised

                foreach (var item in ActiveAlarmList)
                {
                    if (item.Equals(highTempvVarningString))
                    {
                        flag = false;
                    }
                }
                // adds if not in active alarm list
                if (flag)
                {
                    string alarmId = AlarmIDList.Count.ToString();
                    AlarmIDList.Add(alarmId);
                    ActiveAlarmList.Add(highTempvVarningString);
                    dataGridView1.Rows.Add(alarmId, highTempvVarningString, "Temperature over normal", "Varning", "30", unixConvertet, "not acknowlaged");
                }



            }

            if (lowTempVarning)
            {
                bool flag = true;

                foreach (var item in ActiveAlarmList)
                {
                    if (item.Equals(lowTempString))
                    {
                        flag = false;
                    }
                }
                if (flag)
                {
                    string alarmId = AlarmIDList.Count.ToString();
                    AlarmIDList.Add(alarmId);
                    ActiveAlarmList.Add(lowTempString);
                    dataGridView1.Rows.Add(alarmId, lowTempString, "Temperature below normal", "Varning", "15", unixConvertet, "not acknowlaged");
                }

            }



        }

        private void HighAlarmTestBtn_Click(object sender, EventArgs e)
        {
            raiseAlarm(45);

        }

        private void HighVarningBtn_Click(object sender, EventArgs e)
        {
            RaiseVarning(35);
        }
    }


}
