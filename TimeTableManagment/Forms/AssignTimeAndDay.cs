using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;

namespace TimeTableManagment.Forms
{
    public partial class AssignTimeAndDay : Form
    {
        public AssignTimeAndDay()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;

        private DataSet DS = new DataSet();
        private DataSet DS1 = new DataSet();
        private DataSet DS2 = new DataSet();
        private DataSet DS3 = new DataSet();

        private DataTable DT = new DataTable();
        private DataTable DT1 = new DataTable();
        private DataTable DT2 = new DataTable();
        private DataTable DT3 = new DataTable();


        string year = "";
        string sem = "";
        string tag = "";

        string lecturer = "";
        string subject = "";
        string subCode = "";
        string duration = "";
        string grpID = "";
        string subGrpID = "";
        int sessionID = 0;
        string roomName = "";

        //cs variables
        string lLecture = "";
        string lSubject = "";
        string lTag = "";
        string lduration = "";
        string lGroupID = "";
        string lroomName = "";
        int lsessionID = 0;

        //cs variables
        string tLecture = "";
        string tSubject = "";
        string tduration = "";
        string tTag = "";
        string tGroupID = "";
        string troomName = "";
        int tsessionID = 0;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void semcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subGroupcomboBox.Enabled = true;
            subGroupcomboBox.Items.Clear();

            try
            {
                year = StudentYearComboBox.Text;
                sem = semcomboBox.Text;
                String yearsem = year + ".S" + sem;

                SetConnection();
                String subGid = "select SubGroupID from Student where YearSem='" + yearsem + "'";

                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(subGid, sql_con);
                SQLiteDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {
                    if (reader.GetString(0) == null)
                    {
                        MessageBox.Show("Error", "No data in the database", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        string subGrpID = reader.GetString(0);

                        subGroupcomboBox.Items.Add(subGrpID);
                    }


                }

                sql_con.Close();


            }
            catch (Exception)
            {
                Console.Write("no work");
            }

            //tagcomboBox.Enabled = true;
        }

        private void AssignTimeAndDay_Load(object sender, EventArgs e)
        {
            subGroupcomboBox.Enabled = false;
      
            subjectComboBox.Enabled = false;

    
            loadAllData();
           

        }

       private void loadSessionIDs()
        {
            try
            { 


                SetConnection();
                String sub = "select SessionID from Session ";

                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(sub, sql_con);
                SQLiteDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {

                    int subj = reader.GetInt32(0);

                    loadSessionIDcomboBoxCS.Items.Add(subj);


                }

                sql_con.Close();
            }
            catch (Exception)
            {
                Console.Write("no work");
            }
        }

        private void semcomboBox_Click(object sender, EventArgs e)
        {
            allDatalabel.Text = "";

            //groupIDcomboBox.SelectedItem = null;
            //groupIDcomboBox.Items.Clear();
            //groupIDcomboBox.Enabled = false;

            subGroupcomboBox.SelectedItem = null;
            subGroupcomboBox.Items.Clear();
            subGroupcomboBox.Enabled = false;

            subjectComboBox.SelectedItem = null;
            subjectComboBox.Items.Clear();
            subjectComboBox.Enabled = false;

            //tagcomboBox.SelectedItem = null;
            //tagcomboBox.Enabled = false;


        }

       

        

        

        private void subGroupcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectComboBox.Enabled =true;
            try
            {
                string subgID = subGroupcomboBox.Text;


                SetConnection();
                String sub = "select Subject from Session where SubGID='" + subgID + "' and Tag='Practical'";

                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(sub, sql_con);
                SQLiteDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {

                    string subj = reader.GetString(0);

                    subjectComboBox.Items.Add(subj);


                }

                sql_con.Close();
            }
            catch (Exception)
            {
                Console.Write("no work");
            }

        }

        private void subjectComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (tag == "Practical")
            //{
                try
                {
                    string subjct = subjectComboBox.Text;
                    string sid = subGroupcomboBox.Text;


                    SetConnection();
                    String lectureDet = "select s.Lecturer,s.Subject,s.Tag,s.SubjectCode,s.SubGID,s.SessionID,s.Duration,ra.RoomName " +
                        "from Session s inner join RoomAllocation ra on s.SessionID=ra.sessionID " +
                        " where s.SubGID='" + sid + "' and s.Subject='" + subjct + "'and s.Tag='Practical'";

                    sql_con.Open();
                    SQLiteCommand command = new SQLiteCommand(lectureDet, sql_con);
                    SQLiteDataReader reader = command.ExecuteReader();



                    while (reader.Read())
                    {
                        lecturer = reader.GetString(0);
                        subject = reader.GetString(1);
                        tag = reader.GetString(2);
                        subCode = reader.GetString(3);
                        subGrpID = reader.GetString(4);
                        sessionID = reader.GetInt32(5);
                        duration = reader.GetString(6);
                        roomName = reader.GetString(7);




                        allDatalabel.Text = "Lecturer Names: " + lecturer + "\nSubject Name: " + subject + "\nSubject Code: " + subCode + "\nSubject Tag: Practical \nSub Group ID: " +
                            subGrpID + "\nSession ID: " + sessionID + "\nSession Duration: " + duration + "\nRoom Allocated: " + roomName;
                    }

               

                roomNamelbl.Text = "Unavailable Time For room :" + roomName;
                LoadRoomData(roomName);

                sessionUnlabel.Text = "Unavailable Time For Session :" + sessionID;
                LoadsessionUnavailableTime(sessionID);

                sql_con.Close();


              
            }
                catch (Exception ex)
                {
                MessageBox.Show(ex.ToString());
                }
            }
        //else
        //{
        //    try
        //    {
        //        string subjct = subjectComboBox.Text;
        //        string gid = groupIDcomboBox.Text;


        //        SetConnection(); 
        //        String lectureDet = "select s.Lecturer,s.Subject,s.Tag,s.SubjectCode,s.GroupID,s.SessionID,s.Duration,ra.RoomName " +
        //            "from Session s inner join RoomAllocation ra on s.SessionID=ra.sessionID " +
        //            " where s.GroupID='" + gid + "' and s.Subject='" + subjct + "'and s.Tag='" + tag + "'";

        //        sql_con.Open();
        //        SQLiteCommand command = new SQLiteCommand(lectureDet, sql_con);
        //        SQLiteDataReader reader = command.ExecuteReader();



        //        while (reader.Read())
        //        {
        //            lecturer = reader.GetString(0);
        //            subject = reader.GetString(1);
        //            tag = reader.GetString(2);
        //            subCode = reader.GetString(3);
        //            grpID = reader.GetString(4);
        //            sessionID = reader.GetInt32(5);
        //            duration = reader.GetString(6);
        //            roomName = reader.GetString(7);




        //            allDatalabel.Text = "Lecturer Names: " + lecturer + "\nSubject Name: " + subject + "\nSubject Code: " + subCode + "\nSubject Tag: " + tag + "\nGroup ID: " +
        //                grpID + "\nSession ID: " + sessionID + "\nSession Duration: " + duration + "\nRoom Allocated: " + roomName;
        //        }

        //        roomNamelbl.Text = "Unavailable Time For room :" + roomName;


        //        LoadRoomData(roomName);

        //        sql_con.Close();

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}




        // }


        private void LoadRoomData(String roomName)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select StartTime,EndTime,Day from RoomAvailability where RoomName='" + roomName + "' ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView2.DataSource = DT;
            sql_con.Close();



        }

        private void LoadsessionUnavailableTime(int id)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select Froms,Tos,Day from Availability where sessionID='" + id + "' ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS1.Reset();
            DB.Fill(DS1);
            DT1 = DS1.Tables[0];
            dataGridView3.DataSource = DT1;
            sql_con.Close();



        }

       

        private void buildingAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string subjct = subjectComboBox.Text;
                string sid = subGroupcomboBox.Text;
                string startTime = timeStartSelectcomboBoxP.Text;
                string endTime = timeEndSelectcomboBoxP.Text;
                string day = daySelectcomboBoxP.Text;

                if (ValidateChildren(ValidationConstraints.Enabled) &&
                subjct == "" || sid == "" || startTime == "" || endTime =="" || day ==""
                 )
                {
                    MessageBox.Show("Complete All The Fields!",
                   "Unable to Submit", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation,
                                   MessageBoxDefaultButton.Button1);
                }
                else
                {
                    string insertRoom = "insert into allData (GroupID,SubGroupID,StartTime,EndTime,Day,Lecturers,SubjectName,Room,Tag,SubjectCode,sessionID)values('N/A','" + sid + "','"
                  + startTime + "','" + endTime+ "','" + day + "','" + lecturer + "','" + subjct + "','" + roomName + "','" + tag + "','" + subCode + "','" + sessionID + "')";
                    ExecuteQuery(insertRoom);
                    loadAllData();
                    MessageBox.Show("Time and Date Information Added For Practical Session", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString(), "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine(ex.ToString());
            }

        }


        private void loadAllData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select GroupID,SubGroupID,StartTime,EndTime,Day,Lecturers,SubjectName,Tag,Room from allData ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS2.Reset();
            DB.Fill(DS2);
            DT2 = DS2.Tables[0];
            dataGridView1.DataSource = DT2;
            sql_con.Close();
        }


        //Consecutive Sessions

        private void loadConsecSessions()
        {

            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select * from Consecative  ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS3.Reset();
            DB.Fill(DS3);
            DT3 = DS3.Tables[0];
            dataGridView4.DataSource = DT3;
            sql_con.Close();
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[0])
            {
                subGroupcomboBox.Enabled = false;
                subjectComboBox.Enabled = false;
                loadAllData();
            }
            else
            if(metroTabControl1.SelectedTab == metroTabControl1.TabPages[1])
            {
                loadConsecSessions();
                loadSessionIDs();
                loadAllDataCS();
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string sessionID1 = dataGridView4.SelectedRows[0].Cells[1].Value.ToString();
            string sessionID2 = dataGridView4.SelectedRows[0].Cells[2].Value.ToString();


            try
            {

            


                SetConnection();
                String lectureDet = "select s.Lecturer,s.Subject,s.Tag,s.GroupID,s.SessionID,s.Duration,ra.RoomName " +
                    "from Session s inner join RoomAllocation ra on s.SessionID=ra.sessionID " +
                    "where s.SessionID='" + int.Parse(sessionID1) + "'";

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
                    lduration = reader.GetString(5);
                    lroomName = reader.GetString(6);




                    session1labelCS.Text = "Lecturer Names: " + lLecture + "\nSubject Name: " + lSubject + "\nSubject Tag: " + lTag + "\nGroup ID: " +
                        lGroupID + "\nSession ID: " + lsessionID + "\nSession Duration: " + lduration + "\nRoom Allocated: " + lroomName;
                }

                sql_con.Close();

              



                String tutDet = "select s.Lecturer,s.Subject,s.Tag,s.GroupID,s.SessionID,s.Duration,ra.RoomName  " +
                    "from Session s inner join RoomAllocation ra on s.SessionID=ra.sessionID  " +
                    "where s.SessionID='" + int.Parse(sessionID2) + "'";
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
                    tduration = reader1.GetString(5);
                    troomName = reader1.GetString(6);


                    session2labelCS.Text = "Lecturer Names: " + tLecture + "\nSubject Name: " + tSubject + "\nSubject Tag: " + tTag + "\nGroup ID: " +
                        tGroupID + "\nSession ID: " + tsessionID + "\nSession Duration: " + tduration + "\nRoom Allocated: " + troomName;
                }

                roomNamelblCS.Text = "Unavailable Time For room :" + troomName;
                LoadRoomDataCS(troomName);

                sessionUnlabelCS.Text = "Search For Unavailable Times for :" + sessionID1+ " and "+sessionID2;
                allLoadSessionUnavailableTime();

                sql_con.Close();
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.ToString());
            }

        }


        private void LoadRoomDataCS(String roomName)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select StartTime,EndTime,Day from RoomAvailability where RoomName='" + roomName + "' ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView6.DataSource = DT;
            sql_con.Close();



        }

        private void allLoadSessionUnavailableTime()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select Froms,Tos,Day,sessionID from Availability ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS1.Reset();
            DB.Fill(DS1);
            DT1 = DS1.Tables[0];
            dataGridView5.DataSource = DT1;
            sql_con.Close();
        }

        private void addDatabuttonCS_Click(object sender, EventArgs e)
        {
           

            try
            {
                int sID = int.Parse(loadSessionIDcomboBoxCS.Text);
                string startTime = startTimecomboBoxCS.Text;
                string endTime = endTimecomboBoxCS.Text;
                string day = selectDaycomboBoxCS.Text;
                string groupID = "";
                string Lecs = "";
                string tgs = "";
                string subjcode = "";
                string Roomname = "";
                string subName = "";


                if (ValidateChildren(ValidationConstraints.Enabled) &&
                sID == 0 || startTime == "" || endTime == "" || day == ""
                 )
                {
                    MessageBox.Show("Complete All The Fields!",
                   "Unable to Submit", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation,
                                   MessageBoxDefaultButton.Button1);
                }
                else
                {



                    String sessionDet = "select s.GroupID,s.Lecturer,s.Tag,s.SubjectCode,ra.RoomName,s.Subject " +
                 "from Session s inner join RoomAllocation ra on s.SessionID=ra.sessionID  " +
                 "where s.SessionID='" + sID + "'";
                    sql_con.Open();
                    SQLiteCommand command1 = new SQLiteCommand(sessionDet, sql_con);
                    SQLiteDataReader reader1 = command1.ExecuteReader();

                    while (reader1.Read())
                    {
                        groupID= reader1.GetString(0);
                        Lecs = reader1.GetString(1);
                        tgs = reader1.GetString(2);
                        subjcode = reader1.GetString(3);
                        Roomname = reader1.GetString(4);
                        subName = reader1.GetString(5);


                    }



                    string insertallDataCS = "insert into allData (GroupID,SubGroupID,StartTime,EndTime,Day,Lecturers,SubjectName,Room,Tag,SubjectCode,sessionID)values('" + groupID+"','N/A','"
                  + startTime + "','" + endTime + "','" + day + "','" + Lecs + "','" + subName + "','" + Roomname + "','" + tgs+ "','" + subjcode + "','" + sID + "')";
                    ExecuteQuery(insertallDataCS);
                    loadAllDataCS();
                    clearAllFieldsCS();
                    MessageBox.Show("Time and Date Information Added For  Session", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                //MessageBox.Show(ex.ToString(),"Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
            }





        }

        private void loadAllDataCS()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select GroupID,SubGroupID,StartTime,EndTime,Day,Lecturers,SubjectName,Tag,Room from allData ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS2.Reset();
            DB.Fill(DS2);
            DT2 = DS2.Tables[0];
            dataGridView7.DataSource = DT2;
            sql_con.Close();
        }

        private void clearAllFieldsCS()
        {
             loadSessionIDcomboBoxCS.SelectedItem = null;
           startTimecomboBoxCS.SelectedItem = null;
            endTimecomboBoxCS.SelectedItem = null;
             selectDaycomboBoxCS.SelectedItem = null;
        }


        private void resetAllData()
        {
            clearAllFieldsCS();

            session1labelCS.Text = "";
            session2labelCS.Text = "";
            roomNamelblCS.Text = "";
            sessionUnlabelCS.Text = "";
            dataGridView6.DataSource = null;
            dataGridView5.DataSource = null;
        }

        private void clearFieldsbuttonCS_Click(object sender, EventArgs e)
        {
            resetAllData();
        }
    }
}
    
        

