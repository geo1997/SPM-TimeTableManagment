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
using TimeTableManagment.Properties;

namespace TimeTableManagment.Forms
{
    public partial class SessionForm : Form
    {
        private bool isCollapse;
        
        public SessionForm()
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
            string queryText = "select SessionID,Lecturer,Subject,SubjectCode,Tag,GroupID,SubGID,StudentCount,Duration from Session ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            tblSessions.DataSource = DT;
            sql_con.Close();

        }
        //load lecturer names to checkboxlist from the Database
        private void FillLectureList()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select Title,Name from Lecturer ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                lecNameList.Items.Add(dr["Title"].ToString()+dr["Name"].ToString());
            }
            sql_con.Close();
        }

       //retreive tags data from the database
        private void LoadTags()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select TagName from Tag ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
               cmbTags.Items.Add(dr["TagName"].ToString());
            }
            sql_con.Close();
        }

        //retrieve subject data from database
        private void FillSubjectComboBox()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select Subject from Subject ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                cmbSubject.Items.Add(dr["Subject"].ToString());
            }
            sql_con.Close();
        }

        //Retrieve the subject code from the given subject name
        private void FillSubjectCode()
        {
            string sub = cmbSubject.Text;
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select Code from Subject where Subject='" + sub+ "'";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
               txtSubCode.Text= dr["Code"].ToString();
            }
            sql_con.Close();
        }

         //retrieve group ids from database
        private void FillGroupIdComboBox()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select GroupID from Student ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
               cmbGroupId.Items.Add(dr["GroupID"].ToString());
            }
            sql_con.Close();
        }
        //retrieve subgroup ids for relavent group id from database
        private void FillSubGroupIdComboBox()
        {
            string groupId = cmbGroupId.Text;
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select SubGroupID from Student where GroupID='" + groupId + "'";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                cmbSubGroup.Items.Add(dr["SubGroupID"].ToString());
            }
            sql_con.Close();
        }

        private void SessionForm_Load(object sender, EventArgs e)
        {
            FillLectureList();
            FillSubjectComboBox();
            LoadTags();
            FillGroupIdComboBox();
            lblSubGrp.Visible = false;
            cmbSubGroup.Visible = false;
            LoadData();
        }
       //clear the fields
        private void ClearField()
        {
            txtLecs.Clear();
            cmbSubject.ResetText();
            txtSubCode.Clear();
            cmbTags.ResetText();
            cmbGroupId.ResetText();
            cmbSubGroup.ResetText();
            txtStudentCount.Clear();
            txtDuration.Clear();
            lblSubGrp.Visible = false;
            cmbSubGroup.Visible = false;
        }

        //Add selected lecture(s) to the text Box
        private void button1_Click(object sender, EventArgs e)
        {
            txtLecs.Text = "";
            foreach (object lecturers in lecNameList.CheckedItems)
            {
              txtLecs.Text += (txtLecs.Text == "" ? "" : ",") + lecturers.ToString();
            }
            timer1.Start();

        }

        //Animation on Lectures form
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                label6.Image = Resources.icons8_minus; 
                panelDropDown.Height += 10;
                if (panelDropDown.Size == panelDropDown.MaximumSize)
                {
                    timer1.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                label6.Image = Resources.icons8_plus_3;
                panelDropDown.Height -= 10;
                if (panelDropDown.Size == panelDropDown.MinimumSize)
                {
                    timer1.Stop();
                    isCollapse = true;
                }
            }
        }
        private void label6_Click_1(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillSubjectCode();
            LoadData();
        }

        private void cmbGroupId_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSubGroup.Items.Clear();
            FillSubGroupIdComboBox();
            LoadData();
        }

        //add Session
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string lecs = txtLecs.Text;
            string tags = cmbTags.Text;
            string sub = cmbSubject.Text;
            string subCode=txtSubCode.Text;
            string grp = cmbGroupId.Text;
            string subGroup = cmbSubGroup.Text;
            string stNo = txtStudentCount.Text;
            string duration =txtDuration.Text;


            if (ValidateChildren(ValidationConstraints.Enabled) &&
                lecs == "" ||
                tags == "" || subCode == ""
                || grp == "" || stNo =="" || duration == "" )
            {
                if (tags == "Practical"|| tags=="practical" && subGroup == "")
                {
                    MessageBox.Show("Select Sub group Id!",
                                  "Unable to Submit", MessageBoxButtons.OK,
                                                  MessageBoxIcon.Exclamation,
                                                  MessageBoxDefaultButton.Button1);

                }
                MessageBox.Show("All Fields are Compulsory!",
               "Unable to Submit", MessageBoxButtons.OK,
                              MessageBoxIcon.Exclamation,
                              MessageBoxDefaultButton.Button1);

            } 
            else
            {
                
                    if (tags=="Practical"||tags=="practical" )
                    {
                        if(Convert.ToInt32(stNo) > 60)
                        {
                          MessageBox.Show("Student Count Must Not more than 60 for practicals!", "unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                         else
                         {
                           string ses= lecs + "\n" + sub + " (" + subCode + ")" + "\n" + tags + "\n" + subGroup + "\n" + stNo + "(" + duration + ")";
                           string insertSes = "insert into Session(Lecturer,Subject,SubjectCode,Tag,GroupID,SubGID,StudentCount,Duration,Description)" +
                                 "values('" + lecs + "','" + sub + "','" + subCode + "','" + tags + "','" + grp + "','" + subGroup + "','" + stNo + "','" + duration + "','"+ses+"')";
                           ExecuteQuery(insertSes);
                           LoadData();
                           ClearField();

                    }
                         
                }
                       
                    else
                    {
                        string ses= lecs + "\n" + sub + " (" + subCode + ")" + "\n" + tags + "\n" + grp + "\n" + stNo + "(" + duration + ")";
                        string insertSes = "insert into Session(Lecturer,Subject,SubjectCode,Tag,GroupID,SubGID,StudentCount,Duration,Description)" +
                                        "values('" + lecs + "','" + sub + "','" + subCode + "','" + tags + "','" + grp + "','" + subGroup + "','" + stNo + "','" + duration + "','"+ses+"')";
                        ExecuteQuery(insertSes);
                        LoadData();

                        ClearField();
                    }


            }
                 
        }

     //display relevant session once click
        private void tblSessions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lblDisSes.Text = "";
                string lecs = tblSessions.SelectedRows[0].Cells[1].Value.ToString();
                string tags = tblSessions.SelectedRows[0].Cells[4].Value.ToString();
                string sub = tblSessions.SelectedRows[0].Cells[2].Value.ToString();
                string subCode = tblSessions.SelectedRows[0].Cells[3].Value.ToString();
                string grp = tblSessions.SelectedRows[0].Cells[5].Value.ToString();
                string subGroup = tblSessions.SelectedRows[0].Cells[6].Value.ToString();
                string stNo = tblSessions.SelectedRows[0].Cells[7].Value.ToString();
                string duration = tblSessions.SelectedRows[0].Cells[8].Value.ToString();

                if (tags == "Practical" || tags == "practical")
                {
                    lblDisSes.Text = lecs + "\n" + sub + " (" + subCode + ")" + "\n" + tags + "\n" + subGroup + "\n" + stNo + "(" + duration + ")";
                }
                else
                {
                    lblDisSes.Text = lecs + "\n" + sub + " (" + subCode + ")" + "\n" + tags + "\n" + grp + "\n" + stNo + "(" + duration + ")";
                }



            }
            catch(Exception ex)
            {
                ClearField();
                MessageBox.Show("There no details to view!",
                                  "Empty Table", MessageBoxButtons.OK,
                                                  MessageBoxIcon.Exclamation,
                                                  MessageBoxDefaultButton.Button1);
            }
           
           
        }

        // Search Function
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchVal = txtSearch.Text;
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select * from Session where Lecturer LIKE '" + searchVal + "%'OR Subject LIKE'" + searchVal + "%'OR SubjectCode LIKE'" + searchVal + "%'OR GroupID LIKE'" + searchVal + "%'OR SubGID LIKE'" + searchVal + "%'OR StudentCount LIKE'" + searchVal + "%'OR Duration LIKE'" + searchVal + "%'";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            tblSessions.DataSource = DT;
            sql_con.Close();
        }

        //Validation
        private void txtStudentCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtDuration_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }
        private void txtLecs_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLecs.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(txtLecs, "Please select Lecturer Name(s)!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtLecs, null);
            }
        }

        private void cmbSubject_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSubject.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(cmbSubject, "Please Select Subject");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbSubject, null);
            }
        }

        private void cmbGroupId_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbGroupId.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(cmbGroupId, "Please Select group id!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbGroupId, null);
            }
        }

        private void txtStudentCount_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtStudentCount.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(txtStudentCount, "Please enter student count!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtStudentCount, null);
            }
        }

        private void txtDuration_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtDuration.Text))
            {
                e.Cancel = false;
                errorProvider.SetError(txtDuration, "Please enter duration!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(txtDuration, null);
            }
        }

        private void cmbSubGroup_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(cmbSubGroup.Text) && cmbTags.Text=="Practical"|| cmbTags.Text == "practical")
            {
                e.Cancel = false;
                errorProvider.SetError(cmbSubGroup, "Please Select the sub-group id!");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(cmbSubGroup, null);
            }
        }

        //To change the visibility of sub groups Comb Box
        private void cmbTags_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbTags.Text == "Practical" || cmbTags.Text == "practical")
            {
                lblSubGrp.Visible = true;
                cmbSubGroup.Visible = true;
            }
            else
            {
                lblSubGrp.Visible = false;
                cmbSubGroup.Visible = false;
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            lblDisSes.Text = "";
            txtSearch.Clear();
        }
    }
}

