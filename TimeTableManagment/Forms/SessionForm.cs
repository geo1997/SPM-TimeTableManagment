using System;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        private int ConsecativeID = 0;
        private int ParallelID = 0;
        private int OverlapID = 0;

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
                lecNameList.Items.Add(dr["Title"].ToString() + dr["Name"].ToString());
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
            string queryText = "select Code from Subject where Subject='" + sub + "'";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                txtSubCode.Text = dr["Code"].ToString();
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
            LoadData();
            FillGroupIdComboBox();
            
           
            //Consec_LoadData();
            //FillGroupIdComboBoxConsec();
            //FillSubjectComboBoxConsec();
            //FillSession1IdComboBoxConsec();
            //FillSession2IdComboBoxConsec();
            //FillGroupIdComboBoxPar();
            //FillSubjectComboBoxPar();
            //FillGroupIdComboBoxOver();
            //FillSubjectComboBoxOver();
            //Overlap_LoadData();
            //Parallel_LoadData();

            lblSubGrp.Visible = false;
            cmbSubGroup.Visible = false;
            button17.Visible = false;
            button4.Visible = false;
            label13.Visible = false;
            button18.Visible = false;
            button9.Visible = false;
            label21.Visible = false;
            button19.Visible = false;
            button12.Visible = false;
            label31.Visible = false;

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
            string subCode = txtSubCode.Text;
            string grp = cmbGroupId.Text;
            string subGroup = cmbSubGroup.Text;
            string stNo = txtStudentCount.Text;
            string duration = txtDuration.Text;


            if (ValidateChildren(ValidationConstraints.Enabled) &&
                lecs == "" ||
                tags == "" || subCode == ""
                || grp == "" || stNo == "" || duration == "")
            {
                if (tags == "Practical" || tags == "practical" && subGroup == "")
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

                if (tags == "Practical" || tags == "practical")
                {
                    if (Convert.ToInt32(stNo) > 60)
                    {
                        MessageBox.Show("Student Count Must Not more than 60 for practicals!", "unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        string ses = lecs + "\n" + sub + " (" + subCode + ")" + "\n" + tags + "\n" + subGroup + "\n" + stNo + "(" + duration + ")";
                        string insertSes = "insert into Session(Lecturer,Subject,SubjectCode,Tag,GroupID,SubGID,StudentCount,Duration,Description)" +
                              "values('" + lecs + "','" + sub + "','" + subCode + "','" + tags + "','" + grp + "','" + subGroup + "','" + stNo + "','" + duration + "','" + ses + "')";
                        ExecuteQuery(insertSes);
                        LoadData();
                        ClearField();

                    }

                }

                else
                {
                 
                    string ses = lecs + "\n" + sub + " (" + subCode + ")" + "\n" + tags + "\n" + grp + "\n" + stNo + "(" + duration + ")";
                    string insertSes = "insert into Session(Lecturer,Subject,SubjectCode,Tag,GroupID,SubGID,StudentCount,Duration,Description)" +
                                    "values('" + lecs + "','" + sub + "','" + subCode + "','" + tags + "','" + grp + "', 'N/A' , '" + stNo + "','" + duration + "','" + ses + "')";
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
            catch (Exception ex)
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
            if (string.IsNullOrEmpty(cmbSubGroup.Text) && cmbTags.Text == "Practical" || cmbTags.Text == "practical")
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

        //..............................................Consecative Sessions............................................................................

        private void button3_Click(object sender, EventArgs e)
        {
            if (ConsecativeID > 0)
            {
                String updateQuery = "update Consecative set Session1='" + metroComboBox4.Text + "',Session2='" + metroComboBox5.Text + "'" +
               "where ConsecativeID='" + this.ConsecativeID + "'";
                ExecuteQuery(updateQuery);
                MessageBox.Show("Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Consec_LoadData();
                metroComboBox4.ResetText();
            }
            else
            {
                MessageBox.Show("Please select a session to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button17.Visible = false;
            button13.Visible = false;
            label30.Visible = true;
            label13.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button17.Visible = false;
            button13.Visible = false;
            label30.Visible = true;
            label13.Visible = false;

            String deleteQuery = "delete from Consecative where ConsecativeID='" + this.ConsecativeID + "'";
            ExecuteQuery(deleteQuery);
            MessageBox.Show("Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Consec_LoadData();
        }

        private void Consec_LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select * from Consecative";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();

        }

        //retrieve group ids from database
        private void FillGroupIdComboBoxConsec()
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
                metroComboBox2.Items.Add(dr["GroupID"].ToString());
            }
            sql_con.Close();
        }

        //retrieve subject data from database
        private void FillSubjectComboBoxConsec()
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
                metroComboBox3.Items.Add(dr["Subject"].ToString());
            }
            sql_con.Close();
        }

        private void FillSession1IdComboBoxConsec()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select SessionID from Session";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                metroComboBox4.Items.Add(dr["SessionID"].ToString());
            }
            sql_con.Close();
        }

        private void FillSession2IdComboBoxConsec()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select SessionID from Session";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                metroComboBox5.Items.Add(dr["SessionID"].ToString());
            }
            sql_con.Close();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void metroComboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            button17.Visible = false;
            button13.Visible = false;
            label30.Visible = true;

            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select `SessionID`,`Subject`,`Tag` from Session where Subject = '" + metroComboBox3.Text + "' AND GroupID = '" + metroComboBox2.Text + "'";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView2.DataSource = DT;
            sql_con.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) &&
                metroComboBox4.Text == "" || metroComboBox5.Text == "")
            {
                MessageBox.Show("Please fill the Empty Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                string insert = "insert into Consecative (Session1,Session2)values('" + metroComboBox4.Text + "','" + metroComboBox5.Text + "')";
                ExecuteQuery(insert);
                Consec_LoadData();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button4.Visible = true;
            button17.Visible = true;
            button13.Visible = true;
            label30.Visible = false;
            label13.Visible = true;

            ConsecativeID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            metroComboBox4.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            metroComboBox5.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void metroTabPage2_Enter(object sender, EventArgs e)
        {
            Consec_LoadData();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (ConsecativeID > 0)
            {
                button4.Visible = false;
                button17.Visible = false;
                button13.Visible = false;
                label30.Visible = true;
                label13.Visible = false;

                String updateQuery = "update Consecative set Session1='" + metroComboBox4.Text + "',Session2='" + metroComboBox5.Text + "'" +
               "where ConsecativeID='" + this.ConsecativeID + "'";
                ExecuteQuery(updateQuery);
                MessageBox.Show("Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Consec_LoadData();
            }
            else
            {
                MessageBox.Show("Please select to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void metroComboBox4_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(metroComboBox4.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(metroComboBox4, "Please Enter Session");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(metroComboBox4, null);
            }
        }

        private void metroComboBox5_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(metroComboBox5.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(metroComboBox5, "Please Enter Session");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(metroComboBox5, null);
            }
        }

        //..............................................Parallel Sessions............................................................................

        private void Parallel_LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select * from Parallel";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView3.DataSource = DT;
            sql_con.Close();

        }

        //retrieve group ids from database
        private void FillGroupIdComboBoxPar()
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
                metroComboBox8.Items.Add(dr["GroupID"].ToString());
            }
            sql_con.Close();
        }

        //retrieve subject data from database
        private void FillSubjectComboBoxPar()
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
                metroComboBox1.Items.Add(dr["Subject"].ToString());
            }
            sql_con.Close();
        }

        //load lecturer names to checkboxlist from the Database
        private void FillSessionList()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select SessionID,Subject from Session";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                checkedListBox1.Items.Add("Session " + dr["SessionId"].ToString());
            }
            sql_con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select `SessionID`,`Subject`,`Tag` from Session where Subject = '" + metroComboBox1.Text + "' AND GroupID = '" + metroComboBox8.Text + "'";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView4.DataSource = DT;
            sql_con.Close();
        }

        private void txtLecs_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            foreach (object sessions in checkedListBox1.CheckedItems)
            {
                textBox1.Text += (textBox1.Text == "" ? "" : ",") + sessions.ToString();
            }
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                label22.Image = Resources.icons8_minus;
                panel7.Height += 10;
                if (panel7.Size == panel7.MaximumSize)
                {
                    timer2.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                label22.Image = Resources.icons8_plus_3;
                panel7.Height -= 10;
                if (panel7.Size == panel7.MinimumSize)
                {
                    timer2.Stop();
                    isCollapse = true;
                }
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) &&
                textBox1.Text == "")
            {
                MessageBox.Show("Please fill the Empty Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                string insert = "insert into Parallel (Sessions) values('" + textBox1.Text + "')";
                ExecuteQuery(insert);
                Parallel_LoadData();
                textBox1.Clear();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            button18.Visible = false;
            label21.Visible = false;
            label32.Visible = true;
            String deleteQuery = "delete from Parallel where ParallelID='" + this.ParallelID + "'";
            ExecuteQuery(deleteQuery);
            MessageBox.Show("Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Parallel_LoadData();
            textBox1.Clear();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button9.Visible = true;
            button18.Visible = true;
            label21.Visible = true;
            label32.Visible = false;

            ParallelID = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);
            textBox1.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void metroTabPage3_Enter(object sender, EventArgs e)
        {
            Parallel_LoadData();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (ParallelID > 0)
            {
                button9.Visible = false;
                button18.Visible = false;
                label21.Visible = false;
                label32.Visible = true;

                String updateQuery = "update Parallel set Sessions='" + textBox1.Text + "'" +
               "where ParallelID='" + this.ParallelID + "'";
                ExecuteQuery(updateQuery);
                MessageBox.Show("Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Parallel_LoadData();
                textBox1.Clear();
            }
            else
            {
                MessageBox.Show("Please select to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button9.Visible = false;
            button18.Visible = false;
            label21.Visible = false;
            label32.Visible = true;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox1, "Please Enter Session");
            }
            else
            {
                e.Cancel = false;
                errorProvider2.SetError(textBox1, null);
            }
        }

        //..............................................Overlapping Sessions............................................................................
        private void Overlap_LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select * from Overlap";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView5.DataSource = DT;
            sql_con.Close();

        }

        private void FillSession2List()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select SessionID,Subject from Session";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            foreach (DataRow dr in DT.Rows)
            {
                checkedListBox2.Items.Add("Session " + dr["SessionId"].ToString());
            }
            sql_con.Close();
        }

        private void FillGroupIdComboBoxOver()
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
                metroComboBox7.Items.Add(dr["GroupID"].ToString());
            }
            sql_con.Close();
        }

        //retrieve subject data from database
        private void FillSubjectComboBoxOver()
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
                metroComboBox6.Items.Add(dr["Subject"].ToString());
            }
            sql_con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select `SessionID`,`Subject`,`Tag` from Session where Subject = '" + metroComboBox6.Text + "' AND GroupID = '" + metroComboBox7.Text + "'";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView6.DataSource = DT;
            sql_con.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) &&
                textBox2.Text == "")
            {
                MessageBox.Show("Please fill the Empty Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                string insert = "insert into Overlap (Sessions) values('" + textBox2.Text + "')";
                ExecuteQuery(insert);
                Overlap_LoadData();
                textBox2.Clear();
            }
        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {
            Overlap_LoadData();
        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {
            Overlap_LoadData();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (isCollapse)
            {
                label28.Image = Resources.icons8_minus;
                panel8.Height += 8;
                if (panel8.Size == panel8.MaximumSize)
                {
                    timer3.Stop();
                    isCollapse = false;
                }
            }
            else
            {
                label28.Image = Resources.icons8_plus_3;
                panel8.Height -= 8;
                if (panel8.Size == panel8.MinimumSize)
                {
                    timer3.Stop();
                    isCollapse = true;
                }
            }
        }

        private void label28_Click(object sender, EventArgs e)
        {
            timer3.Start();
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            textBox2.Text = "";
            foreach (object sessions1 in checkedListBox2.CheckedItems)
            {
                textBox2.Text += (textBox2.Text == "" ? "" : ",") + sessions1.ToString();
            }
            timer3.Start();
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            button19.Visible = true;
            button12.Visible = true;
            label31.Visible = true;
            label33.Visible = true;
            OverlapID = Convert.ToInt32(dataGridView5.SelectedRows[0].Cells[0].Value);
            textBox2.Text = dataGridView5.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button19.Visible = false;
            button12.Visible = false;
            label31.Visible = false;
            String deleteQuery = "delete from Overlap where OverlapID='" + this.OverlapID + "'";
            ExecuteQuery(deleteQuery);
            MessageBox.Show("Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Overlap_LoadData();
            textBox2.Clear();
        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {
            Overlap_LoadData();
        }

        private void metroTabPage4_Enter(object sender, EventArgs e)
        {
            Overlap_LoadData();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (OverlapID > 0)
            {
                button19.Visible = false;
                button12.Visible = false;
                label31.Visible = false;

                String updateQuery = "update Overlap set Sessions='" + textBox2.Text + "'" +
               "where OverlapID='" + this.OverlapID + "'";
                ExecuteQuery(updateQuery);
                MessageBox.Show("Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Overlap_LoadData();
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Please select to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                e.Cancel = false;
                errorProvider3.SetError(textBox2, "Please Enter Session");
            }
            else
            {
                e.Cancel = false;
                errorProvider3.SetError(textBox2, null);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button19.Visible = false;
            button12.Visible = false;
            label31.Visible = false;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[0])
            {
                lecNameList.Items.Clear();
                cmbSubject.Items.Clear();
                cmbTags.Items.Clear();
                cmbGroupId.Items.Clear();
                FillLectureList();
                FillSubjectComboBox();
                LoadTags();
                FillGroupIdComboBox();
                LoadData();
            }
            else
          if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[1])
            {
                metroComboBox3.Items.Clear();
                metroComboBox2.Items.Clear();
                metroComboBox4.Items.Clear();
                metroComboBox5.Items.Clear();

                FillSubjectComboBoxConsec();
                FillGroupIdComboBoxConsec();
                FillSession1IdComboBoxConsec();
                FillSession2IdComboBoxConsec();
               
                Consec_LoadData();


            }
            else
                if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[2])
            {
                metroComboBox8.Items.Clear();
                metroComboBox1.Items.Clear();
                checkedListBox1.Items.Clear();
                FillGroupIdComboBoxPar();
                FillSubjectComboBoxPar();
                FillSessionList();
                Parallel_LoadData();

            }
            else
                if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[3])
            {

                metroComboBox7.Items.Clear();
                metroComboBox6.Items.Clear();
                checkedListBox2.Items.Clear();
                FillGroupIdComboBoxOver();
                FillSubjectComboBoxOver();
                FillSession2List();
                Overlap_LoadData();


            }



        }
    }
}

