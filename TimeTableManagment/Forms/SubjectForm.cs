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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SubjectForm_Load(object sender, EventArgs e)
        {
            LoadData();
            btnEdit.Visible = false;
            lblSub.Visible = false;
            btnDelete.Visible = false;
        }

        //add
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubName.Text;
            string subjectCode = "IT" + txtSubCode.Text;
            string year = cmbYear.Text;
            string sem = cmbSem.Text;
            int lec = Convert.ToInt32(numLecHr.Value);
            int lab = Convert.ToInt32(numLabHr.Value);
            int tute = Convert.ToInt32(numTuteHr.Value);
            int evo = Convert.ToInt32(numEvoHr.Value);
           
            if (subjectName == ""){
               
                MessageBox.Show("Subject Name Cannot be Empty",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);

            } else if (subjectCode == "IT") {
               
                MessageBox.Show("Subject code Cannot be Empty",
               "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);

            }else if (year == "")
            {
                MessageBox.Show("Offered Year Cannot be Empty",
               "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);

            }else if (sem == "")
            {
                MessageBox.Show("Offered Semester Cannot be Empty",
               "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);

            }else if (lec == 0)
            {
                MessageBox.Show("Number of Lecture Hours Cannot be Empty",
               "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);

            }else {


                string insertSub = "insert into Subject(Code,Subject,Year,Sem,Lec,Lab,Tute,Evaluation)values('" + subjectCode + "','" + subjectName + "','" + year + "','" + sem + "','" + lec + "','" + lab + "','" + tute + "','" + evo + "')";
                ExecuteQuery(insertSub);
                LoadData();

                txtSubName.Clear();
                txtSubCode.Clear();
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
            lblSub.Visible = false;
            txtSubCode.Visible = true;
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
        //edit
        private void btnEdit_Click(object sender, EventArgs e)
        {
            string subjectName = txtSubName.Text;
            string subjectCode = lblSub.Text;
            string year = cmbYear.Text;
            string sem = cmbSem.Text;
            int lec = Convert.ToInt32(numLecHr.Value);
            int lab = Convert.ToInt32(numLabHr.Value);
            int tute = Convert.ToInt32(numTuteHr.Value);
            int evo = Convert.ToInt32(numEvoHr.Value);
            if (subjectName == "")
            {

                MessageBox.Show("Subject Name Cannot be Empty",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);

            }
            else if (subjectCode == "IT")
            {

                MessageBox.Show("Subject code Cannot be Empty",
               "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);

            }
            else if (year == "")
            {
                MessageBox.Show("Offered Year Cannot be Empty",
               "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);

            }
            else if (sem == "")
            {
                MessageBox.Show("Offered Semester Cannot be Empty",
               "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);

            }
            else if (lec == 0)
            {
                MessageBox.Show("Number of Lecture Hours Cannot be Empty",
               "Unable to Submit", MessageBoxButtons.OK,
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
            string subjectCode = lblSub.Text;
            
                String deleteQuery = "delete from Subject where Code='" + subjectCode + "'";
                ExecuteQuery(deleteQuery);
                LoadData();
                clearField();

           

        }
       

        private void txtSubName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbYear_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbSem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void numLecHr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numLecMn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numTuteHr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numTuteMn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numLabHr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numLabMn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numEvoHr_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numEvoMn_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tblLec_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            labelSub.Text = "Edit/Delete Subject";
            txtSubCode.Visible = false;
            lblSub.Visible = true;
            btnSubmit.Visible = false;
            btnEdit.Visible = true;
            btnDelete.Visible = true;
            int index = e.RowIndex;
            DataGridViewRow selectedRow = tblSub.Rows[index];
            lblSub.Text = selectedRow.Cells[0].Value.ToString();
            txtSubName.Text = selectedRow.Cells[1].Value.ToString();
            cmbYear.Text = selectedRow.Cells[2].Value.ToString();
            cmbSem.Text = selectedRow.Cells[3].Value.ToString();
            numLecHr.Value = Int32.Parse(selectedRow.Cells[4].Value.ToString());
            numLabHr.Value= Int32.Parse(selectedRow.Cells[5].Value.ToString());
            numTuteHr.Value = Int32.Parse(selectedRow.Cells[6].Value.ToString());
            numEvoHr.Value = Int32.Parse(selectedRow.Cells[7].Value.ToString());


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
