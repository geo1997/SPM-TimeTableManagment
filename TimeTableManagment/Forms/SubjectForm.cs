using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TimeTableManagment.Forms
{
    public partial class SubjectForm : Form
    {
        public SubjectForm()
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
            string queryText = "select * from Subject ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            tblSub.DataSource = DT;
            sql_con.Close();

        }
        //Randomly generate code for subject code
        public int GenerateRandomNumber()
        {
            Random subjectId = new Random();
            return subjectId.Next(1000,9999);
        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            LoadData();
            btnEdit.Visible = false;
            btnDelete.Visible = false;
        }

        //add
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubName.Text;
            string subjectCode = "IT " + GenerateRandomNumber();
            string year = cmbYear.Text;
            string sem = cmbSem.Text;
            int lec = Convert.ToInt32(numLecHr.Value);
            int lab = Convert.ToInt32(numLabHr.Value);
            int tute = Convert.ToInt32(numTuteHr.Value);
            int evo = Convert.ToInt32(numEvoHr.Value);

            if (ValidateChildren(ValidationConstraints.Enabled) &&
                subjectName == "" || subjectCode == "IT" || year == "" || sem == "" || lec == 0)
            {

                MessageBox.Show("Subject Name Cannot be Empty",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {


                string insertSub = "insert into Subject(Code,Subject,Year,Sem,Lec,Lab,Tute,Evaluation)" +
            "values('" + subjectCode + "','" + subjectName + "','" + year + "','" + sem + "','" + lec + "','" + lab + "','" + tute + "','" + evo + "')";
                ExecuteQuery(insertSub);
                LoadData();

                txtSubName.Clear();
                cmbYear.ResetText();
                cmbSem.ResetText();
                numLecHr.Value = 0;
                numLabHr.Value = 0;
                numTuteHr.Value = 0;
                numEvoHr.Value = 0;
            }


        }

        //clear fields
        private void clearField()
        {
            labelSub.Text = "Add Subject";
            txtSubName.Clear();
            txtSubCode.Clear();
            cmbYear.ResetText();
            cmbSem.ResetText();
            numLecHr.Value = 0;
            numLabHr.Value = 0;
            numTuteHr.Value = 0;
            numEvoHr.Value = 0;
            btnSubmit.Visible = true;
            btnEdit.Visible = false;
            btnDelete.Visible = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearField();
        }

        //On click the data load to the fields
        private void tblSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            labelSub.Text = "Edit/Delete Subject";
            btnSubmit.Visible = false;
            btnEdit.Visible = true;
            btnDelete.Visible = true;

            txtSubCode.Text = tblSub.SelectedRows[0].Cells[0].Value.ToString();
            txtSubName.Text = tblSub.SelectedRows[0].Cells[1].Value.ToString();
            cmbYear.Text = tblSub.SelectedRows[0].Cells[2].Value.ToString();
            cmbSem.Text = tblSub.SelectedRows[0].Cells[3].Value.ToString();
            numLecHr.Value =Convert.ToInt32(tblSub.SelectedRows[0].Cells[4].Value.ToString());
            numLabHr.Value = Convert.ToInt32(tblSub.SelectedRows[0].Cells[5].Value.ToString());
            numTuteHr.Value = Convert.ToInt32(tblSub.SelectedRows[0].Cells[6].Value.ToString());
            numEvoHr.Value = Convert.ToInt32(tblSub.SelectedRows[0].Cells[7].Value.ToString());
        }
       

        //edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubName.Text;
            string subjectCode = txtSubCode.Text;
            string year = cmbYear.Text;
            string sem = cmbSem.Text;
            int lec = Convert.ToInt32(numLecHr.Value);
            int lab = Convert.ToInt32(numLabHr.Value);
            int tute = Convert.ToInt32(numTuteHr.Value);
            int evo = Convert.ToInt32(numEvoHr.Value);

            if (ValidateChildren(ValidationConstraints.Enabled) &&
                subjectName == "" || year == "" || sem == "" || lec == 0)
            {

                MessageBox.Show("All Fields are Compulsory!",
                "Unable to Update", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);

            }
            else
            {
                String updateQuery = "update Subject set Subject='" + subjectName + "',Year='" + year + "',Sem='" + sem + "',Lec='" + lec + "',Lab='" + lab + "',Tute='" + tute + "',Evaluation='" + evo + "' " +
                "where Code='" + subjectCode + "'";
                ExecuteQuery(updateQuery);
                LoadData();
                clearField();
            }
        }

        //delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string subjectCode = txtSubCode.Text;

            String deleteQuery = "delete from Subject where Code='" + subjectCode + "'";
            ExecuteQuery(deleteQuery);
            LoadData();
            clearField();



        }

        //Validating the form
        private void cmbYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void cmbSem_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void numLecHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void numTuteHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void numLabHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void numEvoHr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSubName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSubName.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(txtSubName, "Please Enter the Subject!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtSubName, null);
            }
        }

        private void cmbYear_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbYear.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(cmbYear, "Please Select a year!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbYear, null);
            }
        }

        private void cmbSem_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSem.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(cmbSem, "Please select a semester!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbSem, null);
            }
        }

    }
}
