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
            String mon = "";
            String tue = "";
            String wed = "";
            String thurs = "";
            String fri = "";
            String sat = "";
            String sun = "";

            if (check_mon.Checked)
            {
                mon = "Monday";
            }
            else if (check_tue.Checked)
            {
                tue = "Tuesday";
            }
            else if (check_wed.Checked)
            {
                wed = "Wednesday";
            }
            else if (check_thurs.Checked)
            {
                thurs = "Thursday";
            }

            //String addDays = "insert into Days (day) values"
        }
    }
}
