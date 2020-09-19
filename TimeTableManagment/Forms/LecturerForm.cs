using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics.Eventing.Reader;
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

        //load data from the Database
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
       
        private void LecturerForm_Load(object sender, EventArgs e)
        {
            FillCombo();
            LoadData();
            radioProf.Checked = true;
            btnEdit.Visible = false;
            labelRank.Visible = false;
            lblRank.Visible = false;
            btnDelete.Visible = false;

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
            foreach (DataRow dr in DT.Rows)
            {

                cmbBuild.Items.Add(dr["BuildingName"].ToString());
            }
            sql_con.Close();
        }
        //title selection
        public string TitleSelector() {

            if (radioProf.Checked)
            {
                return radioProf.Text;
            }
            else if (radioDoc.Checked)
            {
                return radioDoc.Text;
            }
            else if (radioMister.Checked)
            {
                return radioMister.Text;
            }
            else if (radioMisis.Checked)
            {
                return radioMisis.Text;
            }
            else if (radioMiss.Checked)
            {
                return radioMiss.Text;
            }
            else
            {
                return "";
            }

        }
        //radio button checker
        public void RadioCheck(string rs)
        {
           
            if(rs=="Prof.")
            {
                radioProf.Checked=true;
            }
            else if (rs == "Dr.")
            {
                radioDoc.Checked = true;
            }
            else if (rs == "Mr.")
            {
                radioMister.Checked = true;
            }
            else if (rs == "Mrs.")
            {
                radioMisis.Checked = true;
            }
            else if (rs == "Ms.")
            {
                radioMiss.Checked = true;
            }
        }
        //clear fields
        private void ClearField()
        {
            labelLec.Text = "Add Lecturer";
            radioProf.Checked = true;
            labelRank.Visible = false;
            lblRank.Visible = false;
            txtLecName.Clear();
            txtEmpId.ReadOnly = false;
            txtEmpId.Clear();
            txtEmpId.BackColor = Color.White;
            cmbCenter.ResetText();
            cmbDept.ResetText();
            cmbDept.Items.Clear();
            cmbFac.ResetText();
            cmbBuild.ResetText();
            cmbLevel.ResetText();
            btnSubmit.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
        }
        //Change the index value of Dept combo Box
        public void DisDept()
        {
            if(cmbFac.Text== "Computing")
            {
                cmbDept.Items.Clear();
                cmbDept.ResetText();
                cmbDept.Items.Add("Information & Technology");
                cmbDept.Items.Add("Computer Sciences & Software Engineering");
                cmbDept.Items.Add("Computer System Engineering");
            }
            else if (cmbFac.Text == "Engineering")
            {
                cmbDept.Items.Clear();
                cmbDept.ResetText();
                cmbDept.Items.Add("Civil Engineering");
                cmbDept.Items.Add("Electrical & Electronic Engineering");
                cmbDept.Items.Add("Mechanical Engineering");
                cmbDept.Items.Add("Material Engineering");
                cmbDept.Items.Add("School of Architecture");
                cmbDept.Items.Add("Quantity Surveying");   
            }
            else if (cmbFac.Text == "Business")
            {
                cmbDept.Items.Clear();
                cmbDept.ResetText();
                cmbDept.Items.Add("Information Management");
                cmbDept.Items.Add("Business Management");
            }
            else if(cmbFac.Text== "Humanities and Sciences")
            {
                cmbDept.Items.Clear();
                cmbDept.ResetText();
                cmbDept.Items.Add("School of Law");
                cmbDept.Items.Add("School of Natural Sciences");
                cmbDept.Items.Add("English Language Teaching Unit");
                cmbDept.Items.Add("School of Education");
                cmbDept.Items.Add("School of Nursing ");
                cmbDept.Items.Add("School of Psychology");
                cmbDept.Items.Add("Mathamatics Unit");
            }
        }

        //Passing the level code
        public int LevelPass(string level)
        {
            int lvl = 0;
            if (level == "Professor")
            {
                lvl = 1;
                return lvl;
            }
            else if (level == "Assistant Professor")
            {
                lvl = 2;
                return lvl;
            }
            else if (level == "Senior Lecturer(HG)")
            {
                lvl = 3;
                return lvl;
            }
            else if (level == "Senior Lecturer")
            {
                lvl = 4;
                return lvl;
            }
            else if (level == "Lecturer")
            {
                lvl = 5;
                return lvl;
            }
            else if (level == "Assistant Lecturer")
            {
                lvl = 6;
                return lvl;
            }
            else if (level == "Instructors")
            {
                lvl = 7;
                return lvl;
            }

            else
            {
                return lvl;
            }

        }

        //add method
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string title = TitleSelector();
            string lecturerName = txtLecName.Text;
            string employeeID = txtEmpId.Text;
            string faculty = cmbFac.Text;
            string department = cmbDept.Text;
            string building = cmbBuild.Text;
            string center = cmbCenter.Text;
            string level = cmbLevel.Text;
            int lvl = LevelPass(level);

            if (ValidateChildren(ValidationConstraints.Enabled) &&
                lecturerName == "" || 
                faculty == "" || department == ""
                || building == "" || center == "" || level == "")
            {
                MessageBox.Show("All Fields are Compulsory!",
               "Unable to Submit", MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button1);
            }
            else
            {
               
                    string rank = lvl + "." + employeeID;

                    string insertLec = "insert into Lecturer(EmployeeID,Title,Name,Faculty,Dept,Building,Center,Rank,Role)" +
                        "values('" + employeeID + "','" + title + "','" + lecturerName + "','" + faculty + "','" + department + "','" + building + "','" + center + "','" + rank + "','" + level + "')";
                    ExecuteQuery(insertLec);
                    LoadData();
                   
                    ClearField();
                    MessageBox.Show("Lecturer Information added succesfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        //Fill the form from selected row
        private void tblLec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelLec.Text = "Edit/Delete Lecturer";
            labelRank.Visible = true;
            lblRank.Visible = true;
            txtEmpId.ReadOnly = true;
            txtEmpId.BackColor = Color.LightGray;
            btnSubmit.Visible = false;
            btnEdit.Visible = true;
            btnDelete.Visible = true;

            string t = tblLec.SelectedRows[0].Cells[2].Value.ToString();
            RadioCheck(t);

            txtEmpId.Text = tblLec.SelectedRows[0].Cells[1].Value.ToString();
            txtLecName.Text = tblLec.SelectedRows[0].Cells[3].Value.ToString();
            cmbFac.Text = tblLec.SelectedRows[0].Cells[4].Value.ToString();
            cmbDept.Text = tblLec.SelectedRows[0].Cells[5].Value.ToString();
            cmbBuild.Text = tblLec.SelectedRows[0].Cells[6].Value.ToString();
            cmbCenter.Text = tblLec.SelectedRows[0].Cells[7].Value.ToString();
            lblRank.Text = tblLec.SelectedRows[0].Cells[8].Value.ToString();
            cmbLevel.Text = tblLec.SelectedRows[0].Cells[9].Value.ToString();
        }
      
        //edit method
        private void button3_Click(object sender, EventArgs e)
        {
            string title = TitleSelector();
            string lecturerName = txtLecName.Text;
            string employeeID = txtEmpId.Text;
            string faculty = cmbFac.Text;
            string department = cmbDept.Text;
            string building = cmbBuild.Text;
            string center = cmbCenter.Text;
            string levl = cmbLevel.Text;


            if (ValidateChildren(ValidationConstraints.Enabled) &&
                lecturerName == "" || employeeID == "" ||
                faculty == "" || department == ""
                || building == "" || center == "" || levl == "")
            {
                MessageBox.Show("All Fields are Compulsory!",
               "Unable to Submit", MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button1);
            }
            else
            {
                int lvl = LevelPass(levl);

                string rank = lvl + "." + employeeID;

                String updateQuery = "update Lecturer set Title='" + title + "',Name='" + lecturerName + "',Faculty='" + faculty + "',Dept='" + department + "',Building='" + building + "',Center='" + center + "',Rank='" + rank + "',Role='" + levl + "' " +
                   "where EmployeeID='" + employeeID + "'";
                ExecuteQuery(updateQuery);
                LoadData();
                ClearField();
                MessageBox.Show("Lecturer Information Updated!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //delete method
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string employeeID = txtEmpId.Text;

            String deleteQuery = "delete from Lecturer where EmployeeID='" + employeeID + "'";
            ExecuteQuery(deleteQuery);
            LoadData();
            ClearField();
            MessageBox.Show("Lecturer Information Deleted", " Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
           ClearField();
        }

        //Validating the form
        private void txtEmpId_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtLecName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLecName.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(txtLecName, "Please Enter Lecturer's Name!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtLecName, null);
            }
        }

        private void txtEmpId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtEmpId.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmpId, "Please Employee ID!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmpId, null);
            }
        }

        private void cmbBuild_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBuild.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(cmbBuild, "Please Select the building!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbBuild, null);
            }
        }

        private void cmbLevel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbLevel.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(cmbLevel, "Please Select the Level!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbLevel, null);
            }
        }
        
        private void cmbFac_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbFac.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(cmbFac, "Please Select the Faculty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbFac, null);
            }
        }
       
        private void cmbCenter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbCenter.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(cmbCenter, "Please Select the Center!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbCenter, null);
            }
        }

        private void cmbDept_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbDept.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(cmbDept, "Please Select the Department!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbDept, null);
            }
        }

        private void cmbFac_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisDept();
        }

    }
}
