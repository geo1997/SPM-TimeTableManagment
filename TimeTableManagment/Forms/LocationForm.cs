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
    public partial class Location : Form
    {
        public Location()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void Location_Load(object sender, EventArgs e)
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
            string queryText= "select * from Location ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();



        }

        private void buildingAddBtn_Click(object sender, EventArgs e)
        {
            string insertLoc = "insert into Location (BuildingName)values('"+buildingNameTxtBx.Text+"')";
            ExecuteQuery(insertLoc);
            LoadData();
            buildingNameTxtBx.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[index];
            idTxtxBox.Text = selectedRow.Cells[0].Value.ToString();
            buildingNameTxtBx.Text = selectedRow.Cells[1].Value.ToString();

        }

        private void buildingEditBtn_Click(object sender, EventArgs e)
        {
            String updateQuery = "update Location set BuildingName='" + buildingNameTxtBx.Text + "'" +
                "where BuildingID='" + idTxtxBox.Text+ "'";
            ExecuteQuery(updateQuery);
            LoadData();
        }

        private void buildingDeleteBtn_Click(object sender, EventArgs e)
        {
            String deleteQuery = "delete from Location where BuildingID='" + idTxtxBox.Text + "'";
            ExecuteQuery(deleteQuery);
            LoadData();
        }
    }
}
