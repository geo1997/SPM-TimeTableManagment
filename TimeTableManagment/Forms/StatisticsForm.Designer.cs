namespace TimeTableManagment.Forms
{
    partial class StatisticsForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1Lec1 = new System.Windows.Forms.RadioButton();
            this.radioButton2Lec2 = new System.Windows.Forms.RadioButton();
            this.radioButton1Stu1 = new System.Windows.Forms.RadioButton();
            this.radioButton2Stu2 = new System.Windows.Forms.RadioButton();
            this.radioButton1Sub1 = new System.Windows.Forms.RadioButton();
            this.radioButton2Sub2 = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportGenerateBtn = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Lecturer",
            "Student",
            "Subject"});
            this.categoryComboBox.Location = new System.Drawing.Point(367, 43);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(178, 24);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose A Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lecturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject";
            // 
            // radioButton1Lec1
            // 
            this.radioButton1Lec1.AutoSize = true;
            this.radioButton1Lec1.Location = new System.Drawing.Point(42, 77);
            this.radioButton1Lec1.Name = "radioButton1Lec1";
            this.radioButton1Lec1.Size = new System.Drawing.Size(203, 21);
            this.radioButton1Lec1.TabIndex = 5;
            this.radioButton1Lec1.TabStop = true;
            this.radioButton1Lec1.Text = "Staff Count Per Department";
            this.radioButton1Lec1.UseVisualStyleBackColor = true;
            this.radioButton1Lec1.CheckedChanged += new System.EventHandler(this.radioButton1Lec1_CheckedChanged);
            // 
            // radioButton2Lec2
            // 
            this.radioButton2Lec2.AutoSize = true;
            this.radioButton2Lec2.Location = new System.Drawing.Point(42, 105);
            this.radioButton2Lec2.Name = "radioButton2Lec2";
            this.radioButton2Lec2.Size = new System.Drawing.Size(166, 21);
            this.radioButton2Lec2.TabIndex = 6;
            this.radioButton2Lec2.TabStop = true;
            this.radioButton2Lec2.Text = "Total Staff Per Center";
            this.radioButton2Lec2.UseVisualStyleBackColor = true;
            this.radioButton2Lec2.CheckedChanged += new System.EventHandler(this.radioButton2Lec2_CheckedChanged);
            // 
            // radioButton1Stu1
            // 
            this.radioButton1Stu1.AutoSize = true;
            this.radioButton1Stu1.Location = new System.Drawing.Point(336, 77);
            this.radioButton1Stu1.Name = "radioButton1Stu1";
            this.radioButton1Stu1.Size = new System.Drawing.Size(179, 21);
            this.radioButton1Stu1.TabIndex = 7;
            this.radioButton1Stu1.TabStop = true;
            this.radioButton1Stu1.Text = "Student Count Per Year";
            this.radioButton1Stu1.UseVisualStyleBackColor = true;
            this.radioButton1Stu1.CheckedChanged += new System.EventHandler(this.radioButton1Stu1_CheckedChanged);
            // 
            // radioButton2Stu2
            // 
            this.radioButton2Stu2.AutoSize = true;
            this.radioButton2Stu2.Location = new System.Drawing.Point(336, 104);
            this.radioButton2Stu2.Name = "radioButton2Stu2";
            this.radioButton2Stu2.Size = new System.Drawing.Size(139, 21);
            this.radioButton2Stu2.TabIndex = 8;
            this.radioButton2Stu2.TabStop = true;
            this.radioButton2Stu2.Text = "radioButton2Stu2";
            this.radioButton2Stu2.UseVisualStyleBackColor = true;
            // 
            // radioButton1Sub1
            // 
            this.radioButton1Sub1.AutoSize = true;
            this.radioButton1Sub1.Location = new System.Drawing.Point(607, 77);
            this.radioButton1Sub1.Name = "radioButton1Sub1";
            this.radioButton1Sub1.Size = new System.Drawing.Size(153, 21);
            this.radioButton1Sub1.TabIndex = 9;
            this.radioButton1Sub1.TabStop = true;
            this.radioButton1Sub1.Text = "Number of Subjects";
            this.radioButton1Sub1.UseVisualStyleBackColor = true;
            this.radioButton1Sub1.CheckedChanged += new System.EventHandler(this.radioButton1Sub1_CheckedChanged);
            // 
            // radioButton2Sub2
            // 
            this.radioButton2Sub2.AutoSize = true;
            this.radioButton2Sub2.Location = new System.Drawing.Point(607, 104);
            this.radioButton2Sub2.Name = "radioButton2Sub2";
            this.radioButton2Sub2.Size = new System.Drawing.Size(143, 21);
            this.radioButton2Sub2.TabIndex = 10;
            this.radioButton2Sub2.TabStop = true;
            this.radioButton2Sub2.Text = "radioButton2Sub2";
            this.radioButton2Sub2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1Stu1);
            this.panel1.Controls.Add(this.radioButton2Sub2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radioButton1Sub1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton2Stu2);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.radioButton1Lec1);
            this.panel1.Controls.Add(this.radioButton2Lec2);
            this.panel1.Location = new System.Drawing.Point(47, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(833, 175);
            this.panel1.TabIndex = 11;
            // 
            // reportGenerateBtn
            // 
            this.reportGenerateBtn.Location = new System.Drawing.Point(89, 384);
            this.reportGenerateBtn.Name = "reportGenerateBtn";
            this.reportGenerateBtn.Size = new System.Drawing.Size(159, 23);
            this.reportGenerateBtn.TabIndex = 12;
            this.reportGenerateBtn.Text = "Generate Button";
            this.reportGenerateBtn.UseVisualStyleBackColor = true;
            this.reportGenerateBtn.Click += new System.EventHandler(this.reportGenerateBtn_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(313, 313);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Faculty";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Sub Count";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(594, 300);
            this.chart1.TabIndex = 13;
            this.chart1.Text = "chart1";
            this.chart1.Visible = false;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(313, 313);
            this.chart2.Name = "chart2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Legend = "Legend1";
            series3.Name = "Center";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Student Count Year";
            this.chart2.Series.Add(series3);
            this.chart2.Series.Add(series4);
            this.chart2.Size = new System.Drawing.Size(594, 300);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 650);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.reportGenerateBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryComboBox);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1Lec1;
        private System.Windows.Forms.RadioButton radioButton2Lec2;
        private System.Windows.Forms.RadioButton radioButton1Stu1;
        private System.Windows.Forms.RadioButton radioButton2Stu2;
        private System.Windows.Forms.RadioButton radioButton1Sub1;
        private System.Windows.Forms.RadioButton radioButton2Sub2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button reportGenerateBtn;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}