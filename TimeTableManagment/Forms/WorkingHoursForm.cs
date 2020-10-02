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
using System.Configuration;

namespace TimeTableManagment.Forms
{
    public partial class WorkingHoursForm : Form
    {
        public WorkingHoursForm()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private int hourId = 0;

        private void workingHoursForm_Load(object sender, EventArgs e)
        {
            btn_delete.Visible = false;
            btn_edit.Visible = false;
            LoadData();
            //lbl_nohours.Visible = false;
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
            string queryText = "select id, startTime, endTime from Hours ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
        }

        private void btn_addHours(object sender, EventArgs e)
        {
            string addHours = "insert into Hours (startTime,endTime)values('" + combo_startTime.Text + "','" + combo_endTime.Text + "')";
            ExecuteQuery(addHours);
            LoadData();
            clearData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_delete.Visible = true;
            btn_edit.Visible = true;
            hourId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            combo_startTime.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            combo_endTime.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            btn_add.Visible = false;
        }

        private void click_editBtn(object sender, EventArgs e)
        {
            if (hourId > 0)
            {
                String updateQuery = "update Hours set startTime='" + combo_startTime.Text + "', " +
                    "endTime='" + combo_endTime.Text + "'" + "where id='" + this.hourId + "'";
                ExecuteQuery(updateQuery);
               
                LoadData();
                MessageBox.Show("The time is updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hourId = 0;
            }
            else
            {
                MessageBox.Show("Please enter a Time slot to update ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearData();
        }

        private void clearData()
        {
            combo_startTime.SelectedItem = null;
            combo_endTime.SelectedItem = null;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (hourId > 0)
            {
                String deleteHour = "delete from Hours where id='" + this.hourId + "'";
                ExecuteQuery(deleteHour);
               
                LoadData();
                MessageBox.Show("Time slot deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                hourId = 0;
            }
            else
            {
                MessageBox.Show("Please select a time slot to delete ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearData();
        }
    }
}
