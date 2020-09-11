using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;

namespace TimeTableManagment.Forms
{
    public partial class StatisticsForm : Form
    {
        public StatisticsForm()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con = new SQLiteConnection("Data Source=TimeTable.db;version=3;");
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;

        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=TimeTable.db;version=3;");
        }


        private int radioButtonVal = 0;
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(categoryComboBox.Text =="Lecturer")
            {
                radioButton1Stu1.Enabled = false;
                radioButton2Stu2.Enabled = false;
                radioButton1Sub1.Enabled = false;
                radioButton2Sub2.Enabled = false;
                radioButton1Lec1.Enabled = true;
                radioButton2Lec2.Enabled = true;
                radioButton3Lec3.Enabled = true;
                radioButton1Department.Enabled = true;
                //chart2.Visible = false;
                //chart1.Visible = false;
                chart2.Series["Series1"].Points.Clear();
                chart2.Series["Series2"].Points.Clear();
                chart2.Titles.Clear();
            }
            else
                if(categoryComboBox.Text == "Student"){
                radioButton1Sub1.Enabled = false;
                radioButton2Sub2.Enabled = false;
                radioButton1Lec1.Enabled = false;
                radioButton2Lec2.Enabled = false;
                radioButton1Stu1.Enabled = true;
                radioButton2Stu2.Enabled = true;
                radioButton3Lec3.Enabled = false;
                radioButton1Department.Enabled = false;
                //chart2.Visible = false;

                //chart1.Series["Faculty"].Points.Clear();
                //chart1.Series["Sub Count"].Points.Clear();
                chart2.Series["Series1"].Points.Clear();
                chart2.Series["Series2"].Points.Clear();
                chart2.Titles.Clear();
            }
            else
                if (categoryComboBox.Text == "Subject")
            {
                radioButton1Lec1.Enabled = false;
                radioButton2Lec2.Enabled = false;
                radioButton1Stu1.Enabled = false;
                radioButton2Stu2.Enabled = false;
                radioButton1Sub1.Enabled = true;
                radioButton2Sub2.Enabled = true;
                radioButton3Lec3.Enabled = false;
                radioButton1Department.Enabled = false;
                //chart2.Visible = false;


                //chart1.Series["Faculty"].Points.Clear();
                chart2.Series["Series1"].Points.Clear();
                chart2.Series["Series2"].Points.Clear();
                chart2.Titles.Clear();

            }
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {
            radioButton1Lec1.Enabled = false;
            radioButton2Lec2.Enabled = false;
            radioButton1Stu1.Enabled = false;
            radioButton2Stu2.Enabled = false;
            radioButton1Sub1.Enabled = false;
            radioButton2Sub2.Enabled = false;
            radioButton3Lec3.Enabled = false;
            radioButton1Department.Enabled = false;
        }

        private void radioButton1Lec1_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonVal = 1;
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series2"].Points.Clear();
            chart2.Titles.Clear();
        }

        private void radioButton2Lec2_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonVal = 2;
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series2"].Points.Clear();
            chart2.Titles.Clear();

        }
        private void radioButton1Stu1_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonVal = 3;
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series2"].Points.Clear();
            chart2.Titles.Clear();
        }
        private void radioButton2Stu2_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonVal = 4;
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series2"].Points.Clear();
            chart2.Titles.Clear();
        }
        private void radioButton1Sub1_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonVal = 5;
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series2"].Points.Clear();
            chart2.Titles.Clear();
        }
        private void radioButton2Sub2_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonVal = 6;
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series2"].Points.Clear();
            chart2.Titles.Clear();
        }

        private void radioButton3Lec3_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonVal = 7;
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series2"].Points.Clear();
            chart2.Titles.Clear();
        }
        private void radioButton1Department_CheckedChanged(object sender, EventArgs e)
        {
            this.radioButtonVal = 8;
            chart2.Series["Series1"].Points.Clear();
            chart2.Series["Series2"].Points.Clear();
            chart2.Titles.Clear();
        }

        private void reportGenerateBtn_Click(object sender, EventArgs e)
        {
            //chart2.Series["Series1"].Points.Clear();
            //chart2.Series["Series2"].Points.Clear();
           
            sql_con.Open();
            if (this.radioButtonVal == 1)
            {
                chart2.Visible = true;
                //chart1.Visible = true;
              
                String sql = "select count(EmployeeID)as Ecount, Faculty" +
                                " from Lecturer" +
                                " group by Faculty";


                SQLiteCommand command = new SQLiteCommand(sql, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();

            
                Title title = chart2.Titles.Add("Staff Count Per Faculty");
                title.Font = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.FromArgb(0, 0, 205);


                while (reader.Read())
                {
                    chart2.Series["Series1"].Points.AddXY(reader.GetString(1), reader.GetInt32(0));
                }
               
            }
            
                if(radioButtonVal == 2)
            {
               
                chart2.Visible = true;
                String sql = "select count(EmployeeID)as Employeecount, Center" +
                                " from Lecturer" +
                                " group by Center";

                SQLiteCommand command = new SQLiteCommand(sql, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();

               Title title= chart2.Titles.Add("Total Staff Per Center");
                title.Font = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.FromArgb(0, 0, 205);

                while (reader.Read())
                {
                    chart2.Series["Series1"].Points.AddXY(reader.GetString(1), reader.GetInt32(0));
                }
               
            }
            
                if(radioButtonVal == 3)
            {
               
                chart2.Visible = true;
                String sql = "Select  YearSem, count(Groups) as GroupsCount " +
                               " from Student" +
                               " group by YearSem";
                              
                               

                SQLiteCommand command = new SQLiteCommand(sql, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();

               Title title= chart2.Titles.Add("Student Groups Per Semester");
                title.Font = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.FromArgb(0, 0, 205);

                while (reader.Read())
                {
                    //String year =
                    //String onlyYear = year.Remove(2);
                    chart2.Series["Series1"].Points.AddXY(reader.GetString(0), reader.GetInt32(1));
                }
           
            }
            
                if (radioButtonVal == 4)
            {
                
                chart2.Visible = true;
                String sql = "Select  Programme, count(Groups) as SubGroupsCount " +
                               " from Student" +
                               " group by Programme";

                SQLiteCommand command = new SQLiteCommand(sql, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();

                Title title=chart2.Titles.Add("Student Groups Per Programme");
                title.Font = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.FromArgb(0, 0, 205);

                while (reader.Read())
                {
                    //String year =
                    //String onlyYear = year.Remove(2);
                    chart2.Series["Series1"].Points.AddXY(reader.GetString(0), reader.GetInt32(1));
                }
               
            }
            
                if(radioButtonVal == 5)
            {
                chart2.Visible = true;
              
                String sql = "select count(Subject)as Subcount, Year" +
                              " from Subject" +
                              " group by Year";


                SQLiteCommand command = new SQLiteCommand(sql, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();

                Title title=chart2.Titles.Add("Number of Subjects Per Year");
                title.Font = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.FromArgb(0, 0, 205);

                while (reader.Read())
                {
                    chart2.Series["Series1"].Points.AddXY(reader.GetString(1) + "st Year", reader.GetInt32(0));
                }
               
            }
                if (radioButtonVal == 6)
            {
                chart2.Visible = true;

                String sql = "select Year,(avg(Evaluation))*0.01 as Hours" +
                              " from Subject" +
                              " group by Year";


                SQLiteCommand command = new SQLiteCommand(sql, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();

                //chart2.Series["Series1"].LabelFormat ="#.##";
                Title title=chart2.Titles.Add("Average Evaluation Time Per Year");
                title.Font = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.FromArgb(0, 0, 205);


                while (reader.Read())
                {
                    chart2.Series["Series2"].Points.AddXY(reader.GetString(0) + "st Year", reader.GetDecimal(1));
                }

            }
                if(radioButtonVal == 7)
            {
                chart2.Visible = true;
                //chart1.Visible = true;

                String sql = "select Role,count(EmployeeID)as Ecount" +
                                " from Lecturer" +
                                " group by Role";


                SQLiteCommand command = new SQLiteCommand(sql, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();


                Title title = chart2.Titles.Add("Staff Acording To Role ");
                title.Font = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.FromArgb(0, 0, 205);


                while (reader.Read())
                {
                    chart2.Series["Series1"].Points.AddXY(reader.GetString(0), reader.GetInt32(1));
                }
            }
            if (this.radioButtonVal == 8)
            {
                chart2.Visible = true;
                //chart1.Visible = true;

                String sql = "select count(EmployeeID)as Ecount, Dept" +
                                " from Lecturer" +
                                " group by Dept";


                SQLiteCommand command = new SQLiteCommand(sql, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();


                Title title = chart2.Titles.Add("Staff Count Per Department");
                title.Font = new System.Drawing.Font("Arial", 18, FontStyle.Bold);
                title.ForeColor = System.Drawing.Color.FromArgb(0, 0, 205);


                while (reader.Read())
                {
                    chart2.Series["Series1"].Points.AddXY(reader.GetString(1), reader.GetInt32(0));
                }

            }
            if (radioButtonVal == 0)
            {
                MessageBox.Show("Please select an Option ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            this.radioButtonVal = 0;
          
            sql_con.Close();

        }

       
    }





}
