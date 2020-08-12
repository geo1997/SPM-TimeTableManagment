using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTableManagment.Forms
{
    public partial class LecturerForm : Form
    {
        public LecturerForm()
        {
            InitializeComponent();
        }
        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

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
            string queryText = "select * from Lecturer ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            tblLec.DataSource = DT;
            sql_con.Close();
        }
        //Load data to combo box
        private void FillCombo()
        {
            cmbBuild.Items.Clear();
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select BuildingName from Location ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows) {

                cmbBuild.Items.Add(dr["BuildingName"].ToString());
            }
            sql_con.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            LoadData();
            FillCombo();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
//add
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string lecturerName = txtLecName.Text;
            string employeeID = txtEmpId.Text;
            string faculty = txtFac.Text;
            string department = txtDept.Text;
            string building = cmbBuild.Text;
            string center = txtCenter.Text;
            string level = cmbLevel.Text;

            string insertSub = "insert into Lecturer(Name,EmployeeID,)values('" + subjectCode + "','" + subjectName + "','" + year + "','" + sem + "','" + lec + "','" + lab + "','" + tute + "','" + evo + "')";
            ExecuteQuery(insertSub);
            LoadData();

        }
    }
}
