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
            }
            else
                if(categoryComboBox.Text == "Student"){
                radioButton1Sub1.Enabled = false;
                radioButton2Sub2.Enabled = false;
                radioButton1Lec1.Enabled = false;
                radioButton2Lec2.Enabled = false;
                radioButton1Stu1.Enabled = true;
                radioButton2Stu2.Enabled = true;
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
        }

        private void radioButton1Lec1_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonVal = 1;
        }

        private void radioButton2Lec2_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonVal = 2;
        }

        private void reportGenerateBtn_Click(object sender, EventArgs e)
        {
            sql_con.Open();
            if (radioButtonVal == 1)
            {
               
                String sql = "select count(EmployeeID)as Ecount, Faculty" +
                                " from Lecturer" +
                                " group by Faculty";

                
                SQLiteCommand command = new SQLiteCommand(sql, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();

                
                while (reader.Read())
                {
                    chart1.Series["Faculty"].Points.AddXY(reader.GetString(1), reader.GetInt32(0));
                }
                
            }
        }
    }





}
