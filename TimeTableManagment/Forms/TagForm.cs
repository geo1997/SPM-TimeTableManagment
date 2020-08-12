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
    public partial class TagForm : Form
    {
        public TagForm()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private int TagID = 0;

        private void TagForm_Load(object sender, EventArgs e)
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
            string queryText = "select * from Tag ";
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

        private void buildingAddBtn_Click(object sender, EventArgs e)
        {
            string insertTag = "insert into Tag (TagName)values('" + buildingNameTxtBx.Text + "')";
            ExecuteQuery(insertTag);
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TagID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            buildingNameTxtBx.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TagID > 0)
            {
                String updateQuery = "update Tag set TagName='" + buildingNameTxtBx.Text + "'" +
               "where TagID='" + this.TagID + "'";
                ExecuteQuery(updateQuery);
                MessageBox.Show("Tag Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a tag to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buildingNameTxtBx.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TagID > 0)
            {
                String deleteQuery = "delete from Tag where TagID='" + this.TagID + "'";
                ExecuteQuery(deleteQuery);
                MessageBox.Show("Tag Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a tag to delete ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buildingNameTxtBx.Clear();
        }
    }
}
