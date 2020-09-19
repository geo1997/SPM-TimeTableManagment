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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private int AvailabilityID = 0;

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

            else if (comboBox1.Text == "Session")
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

            else if (comboBox1.Text == "Lecturer")
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

            else if (comboBox1.Text == "Lecturer")
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

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void AvailabilityForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "hh:mm";
        }
    }
}
