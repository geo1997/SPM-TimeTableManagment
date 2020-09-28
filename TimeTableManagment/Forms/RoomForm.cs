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
    public partial class RoomForm : Form
    {
        public RoomForm()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        string stuYear = "";
        string sem = "";
        string stuSubject = "";
        string globalGroupId = "";
        string globalSubjectID = "";

        string lLecture = "";
        string lSubject = "";
        string lTag = "";
        string lGroupID = "";
        int lsessionID = 0;
       
        string tLecture = "";
        string tSubject = "";
        string tTag = "";
        string tGroupID = "";
        int tsessionID =0;
       

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

        private void LoadRoomAllocationData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select * from RoomAllocation ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView2.DataSource = DT;
            sql_con.Close();

        }


        private void roomData_Fill_Combobox()
        {
            try
            {
                SetConnection();
                String getBuildings = "select * from Rooms";
                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(getBuildings, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string roomName = reader.GetString(1);

                    fillRoomcomboBox.Items.Add(roomName);
                }
            }
            catch (Exception e)
            {
                Console.Write(e + "no work");
            }

        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            roomData_Fill_Combobox();
            LoadRoomAllocationData();
        }

        private void subject_Fill_Combobox()
        {
            try
            {
                stuYear = StudentYearComboBox.Text;
                stuYear = stuYear.Substring(1);
                sem = semcomboBox.Text;
                SetConnection();
                String getSubjects = "select Subject from Subject where Year='" + stuYear + "' and Sem='" + sem + "'";
                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(getSubjects, sql_con);
                SQLiteDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    stuSubject = reader.GetString(0);
                    subjectComboBox.Items.Add(stuSubject);
                }
            }
            catch (Exception)
            {
                Console.Write("no work");
            }
        }

        private void StudentYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //subjectComboBox.Items.Clear();
            //subject_Fill_Combobox();
        }


        private void semcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupIDcomboBox.Items.Clear();
            groupID_Fill_Combobox();
            subjectComboBox.Items.Clear();
            subject_Fill_Combobox();


        }

        private void groupID_Fill_Combobox()
        {
            try
            {
                string studentYear = StudentYearComboBox.Text;
                string semester = semcomboBox.Text;


                string YearSem = studentYear + ".S" + semester;

                SetConnection();
                String getGroupIds = "select GroupID from Student where YearSem='" + YearSem + "'";
                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(getGroupIds, sql_con);
                SQLiteDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string gIds = reader.GetString(0);
                    groupIDcomboBox.Items.Add(gIds);
                }



            }
            catch (Exception)
            {
                Console.Write("no work");
            }
        }

        private void groupIDcomboBox_Click(object sender, EventArgs e)
        {
            //StudentYearComboBox.Text = null;
            //semcomboBox.Text = null;
            string semester = semcomboBox.Text;
            string studentYear = StudentYearComboBox.Text;


            if (studentYear == "")
            {
                MessageBox.Show("Please select the Year  ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (semester == "")
            {
                MessageBox.Show("Please select the Semester  ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


        //load the session tag according to subject and year

        private void sessionSubGID_Fill_Combobox()
        {
            try
            {
                string gId = groupIDcomboBox.Text;
                string sub = subjectComboBox.Text;

                SetConnection();
                String getGroupids = "select SubGID from Session where GroupID='" + gId + "' and Subject='" + sub + "' and SubGID != 'N/A' ";
                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(getGroupids, sql_con);
                SQLiteDataReader reader = command.ExecuteReader();
                

                while (reader.Read())
                {
                    string sessionsubGID = reader.GetString(0);
                    subGroupcomboBox.Items.Add(sessionsubGID);
                }
            }
            catch (Exception)
            {
                Console.Write("no work");
            }

            sql_con.Close();
        }


        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subGroupcomboBox.Items.Clear();
            sessionSubGID_Fill_Combobox();
        }





        private void subjectComboBox_Click(object sender, EventArgs e)
        {
            string semester = semcomboBox.Text;
            string studentYear = StudentYearComboBox.Text;


            if (studentYear == "")
            {
                MessageBox.Show("Please select the Year  ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (semester == "")
            {
                MessageBox.Show("Please select the Semester  ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sessionTagcomboBox_Click(object sender, EventArgs e)
        {
            string gId = groupIDcomboBox.Text;
            string sub = subjectComboBox.Text;



            if (gId == "")
            {
                MessageBox.Show("Please select the Group ID  ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            if (sub == "")
            {
                MessageBox.Show("Please select the Subject  ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StudentYearComboBox_Click(object sender, EventArgs e)
        {
            groupIDcomboBox.SelectedItem = null;
            subjectComboBox.SelectedItem = null;
            groupIDcomboBox.Items.Clear();
            subjectComboBox.Items.Clear();

        }


        private void consecutiveSessions()
        {
            if (conSeccheckBox.Checked)
            {

                subGroupcomboBox.Enabled = false;
                try
                {
                    globalGroupId = groupIDcomboBox.Text;
                    globalSubjectID = subjectComboBox.Text;


                    SetConnection();
                    String lectureDet = "select Lecturer,Subject,Tag,GroupID,SessionID  from Session where GroupID='" + globalGroupId + "' and Subject='" + globalSubjectID + "'and Tag='Lecture'";

                    sql_con.Open();
                    SQLiteCommand command = new SQLiteCommand(lectureDet, sql_con);
                    SQLiteDataReader reader = command.ExecuteReader();



                    while (reader.Read())
                    {
                        lLecture = reader.GetString(0);
                        lSubject = reader.GetString(1);
                        lTag = reader.GetString(2);
                        lGroupID = reader.GetString(3);
                        lsessionID = reader.GetInt32(4);



                        lecSessionlabel.Text = lLecture + "\n" + lSubject + "\n" + lTag + "\n" + lGroupID+"\n Session ID "+lsessionID;
                    }

                    sql_con.Close();
                    String tutDet = "select Lecturer,Subject,Tag,GroupID,SessionID from Session where GroupID='" + globalGroupId + "' and Subject='" + globalSubjectID + "'and Tag='Tutorial'";
                    sql_con.Open();
                    SQLiteCommand command1 = new SQLiteCommand(tutDet, sql_con);
                    SQLiteDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        tLecture = reader1.GetString(0);
                        tSubject = reader1.GetString(1);
                        tTag = reader1.GetString(2);
                        tGroupID = reader1.GetString(3);
                        tsessionID = reader1.GetInt32(4);


                        tuteSessionlabel.Text = tLecture + "\n" + tSubject + "\n" + tTag + "\n" + tGroupID + "\n Session ID " + tsessionID;
                    }

                }
                catch (Exception)
                {
                    Console.Write("no work");
                }
            }
            else
            {
                subGroupcomboBox.Enabled = true;
                lecSessionlabel.Text = "";
                tuteSessionlabel.Text = "";
            }
        }

        private void conSeccheckBox_CheckedChanged(object sender, EventArgs e)
        {
            consecutiveSessions();
        }




        private void roomAllocatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                String semester = semcomboBox.Text;
                String studentYear = StudentYearComboBox.Text;
                String gId = groupIDcomboBox.Text;
                String sub = subjectComboBox.Text;
                String room = fillRoomcomboBox.Text;
                String subgID = subGroupcomboBox.Text;


                if (conSeccheckBox.Checked)
                {
                    if (ValidateChildren(ValidationConstraints.Enabled) &&
                            semester == "" || studentYear == "" || gId == "" || sub == "" || room == ""
                        )
                    {
                        MessageBox.Show("Complete All The Fields!",
                       "Unable to Allocate", MessageBoxButtons.OK,
                                       MessageBoxIcon.Exclamation,
                                       MessageBoxDefaultButton.Button1);
                    }
                    else
                    {


                        string insertConsecForLec = "insert into RoomAllocation (RoomName,Subject,Tag,Lecturer,GroupID,SubGroup,sessionID)values('" + room + "','" + lSubject + "','"
                      + lTag + "','" + lLecture + "','" + lGroupID + "','N/A' ,'"+lsessionID+"')";

                        string insertConsecForTut = "insert into RoomAllocation (RoomName,Subject,Tag,Lecturer,GroupID,SubGroup,sessionID)values('" + room + "','" + tSubject + "','"
                      + tTag + "','" + tLecture + "','" + tGroupID + "','N/A' ,'" + tsessionID + "')";


                        ExecuteQuery(insertConsecForLec);
                        ExecuteQuery(insertConsecForTut);
                        ClearAllFields();
                        LoadRoomAllocationData();
                        MessageBox.Show("Room Allocation For Consecutive Information added successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    if (ValidateChildren(ValidationConstraints.Enabled) &&
                         semester == "" || studentYear == "" || gId == "" || sub == "" || room == "" || subgID == ""
                        )
                    {
                        MessageBox.Show("Complete All The Fields!",
                       "Unable to Allocate", MessageBoxButtons.OK,
                                       MessageBoxIcon.Exclamation,
                                       MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        string sessionTag = "";
                        string Lect = "";
                        int sID = 0;

                        try
                        {
                            

                            SetConnection();
                            String getGroupids = "select Tag,Lecturer,SessionID from Session where GroupID='" + gId + "' and Subject='" + sub + "' and SubGID='"+subgID+"' ";
                            sql_con.Open();
                            SQLiteCommand command = new SQLiteCommand(getGroupids, sql_con);
                            SQLiteDataReader reader = command.ExecuteReader();


                            while (reader.Read())
                            {
                                 sessionTag = reader.GetString(0);
                                 Lect = reader.GetString(1);
                                sID = reader.GetInt32(2);
                            }
                        }
                        catch (Exception)
                        {
                            Console.Write("no work");
                        }

                        string insertForPrac = "insert into RoomAllocation (RoomName,Subject,Tag,Lecturer,GroupID,SubGroup,sessionID)values('" + room + "','" + sub + "','"
                      + sessionTag + "','" + Lect + "','" + gId + "','"+subgID+"','"+sID+"')";

                        


                        ExecuteQuery(insertForPrac);
                        ClearAllFields();
                        LoadRoomAllocationData();
                        MessageBox.Show("Room Allocation For Practical Information added successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

              

            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ClearAllFields()
        {
            groupIDcomboBox.SelectedItem = null;
            subjectComboBox.SelectedItem = null;
            semcomboBox.SelectedItem = null;
            StudentYearComboBox.SelectedItem = null;
             fillRoomcomboBox.SelectedItem = null;
             subGroupcomboBox.SelectedItem = null;
            lecSessionlabel.Text = "";
            tuteSessionlabel.Text = "";
            conSeccheckBox.Checked = false;
            subGroupcomboBox.Enabled = true;
        }

        private void clearDetailsBtn_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }
    }
}
    

