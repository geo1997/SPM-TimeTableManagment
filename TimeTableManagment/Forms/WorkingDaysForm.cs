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

namespace TimeTableManagment.Forms
{
    public partial class WorkingDaysForm : Form
    {
        public WorkingDaysForm()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

       private int workingDayId = 0;

        private void WorkingDaysForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }


        //set connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=TimeTable.db;version=3;New=False;Compress=True");
        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //load data
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select * from Days ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        private void submit__Click(object sender, EventArgs e)
        {


            //if (check_mon.CheckState == CheckState.Checked)
            //{
            //    dayCheck = "Monday";
            //}
            //else if (check_tue.Checked)
            //{
            //    tue = "Tuesday";
            //}
            //else if (check_wed.Checked)
            //{
            //    wed = "Wednesday";
            //}
            //else if (check_thurs.Checked)
            //{
            //    thurs = "Thursday";
            //}

            //String addDays = "insert into Days (day) values"

            //if(check_mon.CheckState == CheckState.Checked)
            //{
            //    string insertDay = "insert into Days (day)values('Monday')";
            //    ExecuteQuery(insertDay);

            //}
            //if (check_tue.CheckState == CheckState.Checked)
            //{
            //    string insertDay = "insert into Days (day)values('Tuesday')";
            //    ExecuteQuery(insertDay);

            //}
            //LoadData();
            int workingDays = Convert.ToInt32(numericUpDown1WorkingDays.Value);
            decimal workingHours = Convert.ToDecimal(numericUpDown1WorkingHours.Value);
            String dayCheck = "";

            foreach (Control c in this.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox b = (CheckBox)c;
                    if (b.Checked)
                    {
                        dayCheck = b.Text +","+ dayCheck;
                    }
                }
            }

            String insertDay = "insert into Days(WorkingDays,NoOfWorkingDays,NoOfWorkingHours)values('" + dayCheck + "','"+workingDays+"','"+workingHours+"')";
            ExecuteQuery(insertDay);
            LoadData();
            ClearCheckBoxes();
           
        }


        public void ClearCheckBoxes()
        {
            check_mon.Checked = false;
            check_tue.Checked = false;
            check_wed.Checked = false;
            check_thurs.Checked = false;
            check_fri.Checked = false;
            check_sat.Checked = false;
            check_sun.Checked = false;
            numericUpDown1WorkingDays.Value = 0;
            numericUpDown1WorkingHours.Value = 0;
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearCheckBoxes();
            String dayNames = "";
            workingDayId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            numericUpDown1WorkingDays.Value = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[2].Value);
            numericUpDown1WorkingHours.Value = Convert.ToDecimal(dataGridView1.SelectedRows[0].Cells[3].Value);

            String getWDays = "Select WorkingDays from Days where id='" + this.workingDayId + "'";
            sql_con.Open();
            SQLiteCommand command = new SQLiteCommand(getWDays, sql_con);

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                dayNames = reader.GetString(0);

            }

            sql_con.Close();

            char[] spearator = { ',' };

            String[] strlist = dayNames.Split(spearator,
           StringSplitOptions.RemoveEmptyEntries);

            foreach (String s in strlist)
            {
                if (s == "Monday")
                {
                    check_mon.Checked = true;
                }
                if (s == "Tuesday")
                {
                    check_tue.Checked = true;
                }
                if (s == "Wednesday")
                {
                    check_wed.Checked = true;
                }
                if (s == "Thursday")
                {
                    check_thurs.Checked = true;
                }
                if (s == "Friday")
                {
                    check_fri.Checked = true;
                }
                if (s == "Saturday")
                {
                    check_sat.Checked = true;
                }
                if (s == "Sunday")
                {
                    check_sun.Checked = true;
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (workingDayId > 0)
            {
                String dayCheck = "";
                int workingDays = Convert.ToInt32(numericUpDown1WorkingDays.Value);
                decimal workingHours = Convert.ToDecimal(numericUpDown1WorkingHours.Value);

                foreach (Control c in this.Controls)
                {
                    if (c is CheckBox)
                    {
                        CheckBox b = (CheckBox)c;
                        if (b.Checked)
                        {
                            dayCheck = b.Text + "," + dayCheck;
                        }
                    }
                }


                String updateQuery = "Update Days set  WorkingDays='" + dayCheck + "',NoOfWorkingDays='" + workingDays + "'" +
                    ", NoOfWorkingHours='" + workingHours + "' where id='"+workingDayId+"'";
                ExecuteQuery(updateQuery);
                LoadData();
                ClearCheckBoxes();
                workingDayId = 0;
            }
            else
            {
                MessageBox.Show("Please select a row to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearCheckBoxes();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (workingDayId > 0)
            {
              

                String deleteQuery = "Delete from Days where id='" + workingDayId + "'";
                ExecuteQuery(deleteQuery);
                LoadData();
                ClearCheckBoxes();
                workingDayId = 0;
            }
            else
            {
                MessageBox.Show("Please select a row to delete ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ClearCheckBoxes();
        }
    }
}
