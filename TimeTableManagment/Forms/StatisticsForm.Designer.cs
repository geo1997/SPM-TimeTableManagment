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
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.reportGenerateBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Items.AddRange(new object[] {
            "Lecturer",
            "Student",
            "Subject"});
            this.categoryComboBox.Location = new System.Drawing.Point(369, 51);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(286, 24);
            this.categoryComboBox.TabIndex = 0;
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose A Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(109, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lecturer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(455, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(822, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subject";
            // 
            // radioButton1Lec1
            // 
            this.radioButton1Lec1.AutoSize = true;
            this.radioButton1Lec1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1Lec1.Location = new System.Drawing.Point(42, 77);
            this.radioButton1Lec1.Name = "radioButton1Lec1";
            this.radioButton1Lec1.Size = new System.Drawing.Size(204, 24);
            this.radioButton1Lec1.TabIndex = 5;
            this.radioButton1Lec1.TabStop = true;
            this.radioButton1Lec1.Text = "Staff Count Per Faculty";
            this.radioButton1Lec1.UseVisualStyleBackColor = true;
            this.radioButton1Lec1.CheckedChanged += new System.EventHandler(this.radioButton1Lec1_CheckedChanged);
            // 
            // radioButton2Lec2
            // 
            this.radioButton2Lec2.AutoSize = true;
            this.radioButton2Lec2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2Lec2.Location = new System.Drawing.Point(42, 105);
            this.radioButton2Lec2.Name = "radioButton2Lec2";
            this.radioButton2Lec2.Size = new System.Drawing.Size(193, 24);
            this.radioButton2Lec2.TabIndex = 6;
            this.radioButton2Lec2.TabStop = true;
            this.radioButton2Lec2.Text = "Total Staff Per Center";
            this.radioButton2Lec2.UseVisualStyleBackColor = true;
            this.radioButton2Lec2.CheckedChanged += new System.EventHandler(this.radioButton2Lec2_CheckedChanged);
            // 
            // radioButton1Stu1
            // 
            this.radioButton1Stu1.AutoSize = true;
            this.radioButton1Stu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1Stu1.Location = new System.Drawing.Point(386, 77);
            this.radioButton1Stu1.Name = "radioButton1Stu1";
            this.radioButton1Stu1.Size = new System.Drawing.Size(255, 24);
            this.radioButton1Stu1.TabIndex = 7;
            this.radioButton1Stu1.TabStop = true;
            this.radioButton1Stu1.Text = "Student Groups Per Semester";
            this.radioButton1Stu1.UseVisualStyleBackColor = true;
            this.radioButton1Stu1.CheckedChanged += new System.EventHandler(this.radioButton1Stu1_CheckedChanged);
            // 
            // radioButton2Stu2
            // 
            this.radioButton2Stu2.AutoSize = true;
            this.radioButton2Stu2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2Stu2.Location = new System.Drawing.Point(386, 104);
            this.radioButton2Stu2.Name = "radioButton2Stu2";
            this.radioButton2Stu2.Size = new System.Drawing.Size(275, 24);
            this.radioButton2Stu2.TabIndex = 8;
            this.radioButton2Stu2.TabStop = true;
            this.radioButton2Stu2.Text = "Student  Groups Per Programme";
            this.radioButton2Stu2.UseVisualStyleBackColor = true;
            this.radioButton2Stu2.CheckedChanged += new System.EventHandler(this.radioButton2Stu2_CheckedChanged);
            // 
            // radioButton1Sub1
            // 
            this.radioButton1Sub1.AutoSize = true;
            this.radioButton1Sub1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1Sub1.Location = new System.Drawing.Point(752, 77);
            this.radioButton1Sub1.Name = "radioButton1Sub1";
            this.radioButton1Sub1.Size = new System.Drawing.Size(248, 24);
            this.radioButton1Sub1.TabIndex = 9;
            this.radioButton1Sub1.TabStop = true;
            this.radioButton1Sub1.Text = "Number of Subjects Per Year";
            this.radioButton1Sub1.UseVisualStyleBackColor = true;
            this.radioButton1Sub1.CheckedChanged += new System.EventHandler(this.radioButton1Sub1_CheckedChanged);
            // 
            // radioButton2Sub2
            // 
            this.radioButton2Sub2.AutoSize = true;
            this.radioButton2Sub2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2Sub2.Location = new System.Drawing.Point(752, 104);
            this.radioButton2Sub2.Name = "radioButton2Sub2";
            this.radioButton2Sub2.Size = new System.Drawing.Size(285, 24);
            this.radioButton2Sub2.TabIndex = 10;
            this.radioButton2Sub2.TabStop = true;
            this.radioButton2Sub2.Text = "Average Evaluation Time Per Year";
            this.radioButton2Sub2.UseVisualStyleBackColor = true;
            this.radioButton2Sub2.CheckedChanged += new System.EventHandler(this.radioButton2Sub2_CheckedChanged);
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
            this.panel1.Location = new System.Drawing.Point(11, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1050, 179);
            this.panel1.TabIndex = 11;
            // 
            // chart2
            // 
            chartArea1.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart2.Legends.Add(legend1);
            this.chart2.Location = new System.Drawing.Point(286, 315);
            this.chart2.Name = "chart2";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.IsValueShownAsLabel = true;
            series2.LabelFormat = "#.##%";
            series2.Legend = "Legend1";
            series2.Name = "Series2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "Legend1";
            series3.Name = "Student Sub Groups Per Semester";
            this.chart2.Series.Add(series1);
            this.chart2.Series.Add(series2);
            this.chart2.Series.Add(series3);
            this.chart2.Size = new System.Drawing.Size(594, 300);
            this.chart2.TabIndex = 14;
            this.chart2.Text = "chart2";
            this.chart2.Visible = false;
            // 
            // reportGenerateBtn
            // 
            this.reportGenerateBtn.BackColor = System.Drawing.Color.Aqua;
            this.reportGenerateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportGenerateBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.reportGenerateBtn.Image = global::TimeTableManagment.Properties.Resources.icons8_chart_60px;
            this.reportGenerateBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportGenerateBtn.Location = new System.Drawing.Point(60, 384);
            this.reportGenerateBtn.Name = "reportGenerateBtn";
            this.reportGenerateBtn.Size = new System.Drawing.Size(179, 64);
            this.reportGenerateBtn.TabIndex = 12;
            this.reportGenerateBtn.Text = "Generate Graph";
            this.reportGenerateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reportGenerateBtn.UseVisualStyleBackColor = false;
            this.reportGenerateBtn.Click += new System.EventHandler(this.reportGenerateBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1091, 211);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Category Criteria";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1090, 650);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.reportGenerateBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categoryComboBox);
            this.Name = "StatisticsForm";
            this.Text = "Statistics";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox1.ResumeLayout(false);
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}