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
        private int tagID = 0;

        //When form loads execute
        private void Tag_Load(object sender, EventArgs e)
        {
            LoadData();
        }


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
            string queryText = "select * from Tag ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView2.DataSource = DT;
            sql_con.Close();



        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void buildingAddBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                string insertTag = "insert into Tag (TagName)values('" + textBox1.Text + "')";
                ExecuteQuery(insertTag);
                LoadData();

                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tagID > 0)
            {
                String updateQuery = "update Tag set TagName='" + textBox1.Text + "'" +
               "where TagID='" + this.tagID + "'";
                ExecuteQuery(updateQuery);
                MessageBox.Show("Tag Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a tag to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tagID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            textBox1.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tagID > 0)
            {
                String deleteQuery = "delete from Tag where TagID='" + this.tagID + "'";
                ExecuteQuery(deleteQuery);
                MessageBox.Show("Tag Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a tag to delete ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Clear();
        }

        private void TagForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void Tag_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "This feild should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }
    }
}
