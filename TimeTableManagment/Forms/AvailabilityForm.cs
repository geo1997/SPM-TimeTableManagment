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
    public partial class AvailabilityForm : Form
    {
        public AvailabilityForm()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private int AvailabilityIDs = 0;

        //set connection
        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=TimeTable.db;version=3;");
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

        /*
         **BUILDING TAB****
         */

        //load building data
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select * from Availability ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Lecturer")
            {
                comboBox2.Items.Clear();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandType = CommandType.Text;
                sql_cmd.CommandText = "SELECT Name FROM Lecturer";
                sql_cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox2.Items.Add(dr["Name"].ToString());
                }
                sql_con.Close();
            }

            else if (comboBox1.Text == "Session")
            {
                comboBox2.Items.Clear();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandType = CommandType.Text;
                sql_cmd.CommandText = "SELECT SessionID FROM Session";
                sql_cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox2.Items.Add(dr["SessionID"].ToString());
                }
                sql_con.Close();
            }

            else if (comboBox1.Text == "Group")
            {
                comboBox2.Items.Clear();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandType = CommandType.Text;
                sql_cmd.CommandText = "SELECT GroupID FROM Student";
                sql_cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox2.Items.Add(dr["GroupID"].ToString());
                }
                sql_con.Close();
            }

            else if (comboBox1.Text == "Sub-Group")
            {
                comboBox2.Items.Clear();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandType = CommandType.Text;
                sql_cmd.CommandText = "SELECT SubGroupID FROM Student";
                sql_cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox2.Items.Add(dr["SubGroupID"].ToString());
                }
                sql_con.Close();
            }
        }

        public void fillCombo(ComboBox combo,string query,string displayMember,string valueMember) {
            sql_cmd = new SQLiteCommand(query, sql_con);
            DB = new SQLiteDataAdapter(sql_cmd);
            DT = new DataTable();
            DB.Fill(DT);
            combo.DataSource = DT;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "hh:mm";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Visible = true;
            button1.Visible = false;
            button4.Visible = true;
            label8.Visible = true;
            labelLec.Visible = false;

            AvailabilityIDs = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (AvailabilityIDs > 0)
            {
                button1.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                labelLec.Visible = true;
                label8.Visible = false;

                String updateQuery = "update Availability set Type='" + comboBox1.Text + "',Name='" + comboBox2.Text + "',Day='" + comboBox3.Text + "',Froms='" + dateTimePicker1.Text + "',Tos='" + dateTimePicker2.Text +
               "where AvailabilityID='" + this.AvailabilityIDs + "'";
                ExecuteQuery(updateQuery);
                MessageBox.Show("Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AvailabilityForm_Load(object sender, EventArgs e)
        {
            LoadData();
            button3.Visible = false;
            button4.Visible = false;
            label8.Visible = false;
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "hh:mm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertTag = "insert into Availability (Type,Name,Day,Froms,Tos) values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
            ExecuteQuery(insertTag);
            LoadData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            labelLec.Visible = true;
            label8.Visible = false;

            String deleteQuery = "delete from Availability where AvailabilityID='" + this.AvailabilityIDs + "'";
            ExecuteQuery(deleteQuery);
            MessageBox.Show("Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            labelLec.Visible = true;
            label8.Visible = false;

        }
    }
}
