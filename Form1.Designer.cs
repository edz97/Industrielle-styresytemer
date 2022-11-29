namespace WindowsFormsApp6
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series26 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series27 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series28 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series29 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series30 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.HighAlarmTestBtn = new System.Windows.Forms.Button();
            this.HighVarningBtn = new System.Windows.Forms.Button();
            this.AlarmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TagName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AlarmLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivationTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcknowledgeTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcknowlageButton = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.DarkGray;
            this.chart1.BorderlineColor = System.Drawing.Color.Gray;
            chartArea6.BackColor = System.Drawing.Color.DimGray;
            chartArea6.BackImageTransparentColor = System.Drawing.Color.Silver;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chart1.Legends.Add(legend6);
            this.chart1.Location = new System.Drawing.Point(387, 39);
            this.chart1.Name = "chart1";
            this.chart1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            series26.ChartArea = "ChartArea1";
            series26.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series26.Color = System.Drawing.Color.LawnGreen;
            series26.Legend = "Legend1";
            series26.MarkerBorderColor = System.Drawing.Color.Green;
            series26.Name = "Temperature";
            series27.ChartArea = "ChartArea1";
            series27.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series27.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series27.Legend = "Legend1";
            series27.MarkerColor = System.Drawing.Color.Fuchsia;
            series27.Name = "TemperatureHighVarning";
            series28.ChartArea = "ChartArea1";
            series28.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series28.Color = System.Drawing.Color.Red;
            series28.Legend = "Legend1";
            series28.Name = "TemperatureHighAlarm";
            series29.ChartArea = "ChartArea1";
            series29.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series29.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            series29.Legend = "Legend1";
            series29.Name = "TemperatureLowVarning";
            series30.ChartArea = "ChartArea1";
            series30.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series30.Color = System.Drawing.Color.Red;
            series30.Legend = "Legend1";
            series30.MarkerColor = System.Drawing.Color.Cyan;
            series30.Name = "TemperatureLowAlarm";
            this.chart1.Series.Add(series26);
            this.chart1.Series.Add(series27);
            this.chart1.Series.Add(series28);
            this.chart1.Series.Add(series29);
            this.chart1.Series.Add(series30);
            this.chart1.Size = new System.Drawing.Size(843, 421);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 39);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "input arduino";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(15, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AlarmID,
            this.TagName,
            this.TextDescription,
            this.AlarmType,
            this.AlarmLimit,
            this.ActivationTime,
            this.AcknowledgeTime,
            this.AcknowlageButton});
            this.dataGridView1.Location = new System.Drawing.Point(91, 523);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(846, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // HighAlarmTestBtn
            // 
            this.HighAlarmTestBtn.Location = new System.Drawing.Point(36, 270);
            this.HighAlarmTestBtn.Name = "HighAlarmTestBtn";
            this.HighAlarmTestBtn.Size = new System.Drawing.Size(152, 23);
            this.HighAlarmTestBtn.TabIndex = 6;
            this.HighAlarmTestBtn.Text = "High alarm test";
            this.HighAlarmTestBtn.UseVisualStyleBackColor = true;
            this.HighAlarmTestBtn.Click += new System.EventHandler(this.HighAlarmTestBtn_Click);
            // 
            // HighVarningBtn
            // 
            this.HighVarningBtn.Location = new System.Drawing.Point(36, 299);
            this.HighVarningBtn.Name = "HighVarningBtn";
            this.HighVarningBtn.Size = new System.Drawing.Size(152, 23);
            this.HighVarningBtn.TabIndex = 7;
            this.HighVarningBtn.Text = "High varning test";
            this.HighVarningBtn.UseVisualStyleBackColor = true;
            this.HighVarningBtn.Click += new System.EventHandler(this.HighVarningBtn_Click);
            // 
            // AlarmID
            // 
            this.AlarmID.HeaderText = "AlarmID";
            this.AlarmID.Name = "AlarmID";
            // 
            // TagName
            // 
            this.TagName.HeaderText = "Tag Name";
            this.TagName.Name = "TagName";
            // 
            // TextDescription
            // 
            this.TextDescription.HeaderText = "Alarm Description";
            this.TextDescription.Name = "TextDescription";
            // 
            // AlarmType
            // 
            this.AlarmType.HeaderText = "AlarmType";
            this.AlarmType.Name = "AlarmType";
            // 
            // AlarmLimit
            // 
            this.AlarmLimit.HeaderText = "Alarm limit";
            this.AlarmLimit.Name = "AlarmLimit";
            // 
            // ActivationTime
            // 
            this.ActivationTime.HeaderText = "Activation Time";
            this.ActivationTime.Name = "ActivationTime";
            // 
            // AcknowledgeTime
            // 
            this.AcknowledgeTime.HeaderText = "AcknowledgeTime";
            this.AcknowledgeTime.Name = "AcknowledgeTime";
            // 
            // AcknowlageButton
            // 
            this.AcknowlageButton.HeaderText = "Acknowlage";
            this.AcknowlageButton.Name = "AcknowlageButton";
            this.AcknowlageButton.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 723);
            this.Controls.Add(this.HighVarningBtn);
            this.Controls.Add(this.HighAlarmTestBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button HighAlarmTestBtn;
        private System.Windows.Forms.Button HighVarningBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TagName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmType;
        private System.Windows.Forms.DataGridViewTextBoxColumn AlarmLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivationTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcknowledgeTime;
        private System.Windows.Forms.DataGridViewButtonColumn AcknowlageButton;
    }
}

