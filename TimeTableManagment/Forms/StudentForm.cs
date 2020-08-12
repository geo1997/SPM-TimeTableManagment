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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private int StudentID = 0;

        private void StudentForm_Load(object sender, EventArgs e)
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
            string queryText = "select * from Student ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();



        }

        private void dw_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string insertStudent = "insert into Student (YearSem,Programme,Groups,SubGroups)values('" + buildingNameTxtBx.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            ExecuteQuery(insertStudent);
            LoadData();
            buildingNameTxtBx.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                String updateQuery = "update Student set YearSem='" + buildingNameTxtBx.Text + "',Programme='" + textBox2.Text + "',Groups='" + textBox3.Text + "',SubGroups='" + textBox4.Text + "'" +
               "where BuildingID='" + this.StudentID + "'";
                ExecuteQuery(updateQuery);
                MessageBox.Show("Student Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a student to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buildingNameTxtBx.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StudentID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            buildingNameTxtBx.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (StudentID > 0)
            {
                String deleteQuery = "delete from Student where StudentID='" + this.StudentID + "'";
                ExecuteQuery(deleteQuery);
                MessageBox.Show("Student Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a student to delete ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buildingNameTxtBx.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
