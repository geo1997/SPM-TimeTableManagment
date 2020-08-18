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
        
        //Auto generate employee Id
        public void EmployeeIdGenerator()
        {
            Random empIdGen = new Random();
            string r = empIdGen.Next(0, 8000).ToString();
            txtEmpId.Text = r.PadLeft(6,'0');

        }

        private void LecturerForm_Load(object sender, EventArgs e)
        {
            FillCombo();
            EmployeeIdGenerator();
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
        private void clearField()
        {
            labelLec.Text = "Add Subject";
            radioProf.Checked = true;
            labelRank.Visible = false;
            lblRank.Visible = false;
            txtLecName.Clear();
            txtCenter.Clear();
            txtDept.Clear();
            txtFac.Clear();
            cmbBuild.ResetText();
            cmbLevel.ResetText();
            btnSubmit.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
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
            string faculty = txtFac.Text;
            string department = txtDept.Text;
            string building = cmbBuild.Text;
            string center = txtCenter.Text;
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
                    EmployeeIdGenerator();
                    clearField();
                    MessageBox.Show("Lecturer Information added succesfully", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        //Fill the form from selected row
        private void tblLec_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelLec.Text = "Edit/Delete Lecturer";
            labelRank.Visible = true;
            lblRank.Visible = true;
            btnSubmit.Visible = false;
            btnEdit.Visible = true;
            btnDelete.Visible = true;

            string t = tblLec.SelectedRows[0].Cells[2].Value.ToString();
            RadioCheck(t);

            txtEmpId.Text = tblLec.SelectedRows[0].Cells[1].Value.ToString();
            txtLecName.Text = tblLec.SelectedRows[0].Cells[3].Value.ToString();
            txtFac.Text = tblLec.SelectedRows[0].Cells[4].Value.ToString();
            txtDept.Text = tblLec.SelectedRows[0].Cells[5].Value.ToString();
            cmbBuild.Text = tblLec.SelectedRows[0].Cells[6].Value.ToString();
            txtCenter.Text = tblLec.SelectedRows[0].Cells[7].Value.ToString();
            lblRank.Text = tblLec.SelectedRows[0].Cells[8].Value.ToString();
            cmbLevel.Text = tblLec.SelectedRows[0].Cells[9].Value.ToString();
        }
      
        //edit method
        private void button3_Click(object sender, EventArgs e)
        {
            string title = TitleSelector();
            string lecturerName = txtLecName.Text;
            string employeeID = txtEmpId.Text;
            string faculty = txtFac.Text;
            string department = txtDept.Text;
            string building = cmbBuild.Text;
            string center = txtCenter.Text;
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
                EmployeeIdGenerator();
                clearField();
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
            EmployeeIdGenerator();
            clearField();
            MessageBox.Show("Lecturer Information Deleted", " Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        private void label2_Click(object sender, EventArgs e)
        {

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
                txtLecName.Focus();
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
                txtLecName.Focus();
                errorProvider.SetError(txtEmpId, "Please Employee ID!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtEmpId, null);
            }
        }

        private void txtFac_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtFac.Text))
            {
                e.Cancel = false;
                txtLecName.Focus();
                errorProvider.SetError(txtFac, "Please Enter the Faculty!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtFac, null);
            }
        }

        private void txtDept_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDept.Text))
            {
                e.Cancel = false;
                txtLecName.Focus();
                errorProvider.SetError(txtDept, "Please Enter the Department!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDept, null);
            }
        }

        private void cmbBuild_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbBuild.Text))
            {
                e.Cancel = false;
                txtLecName.Focus();
                errorProvider.SetError(cmbBuild, "Please Select the building!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbBuild, null);
            }
        }

        private void txtCenter_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtCenter.Text))
            {
                e.Cancel = false;
                txtLecName.Focus();
                errorProvider.SetError(txtCenter, "Please Enter the Center!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtCenter, null);
            }
        }

        private void cmbLevel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbLevel.Text))
            {
                e.Cancel = false;
                txtLecName.Focus();
                errorProvider.SetError(cmbLevel, "Please Select the Level!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbLevel, null);
            }
        }

    }
}
