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
using DGVPrinterHelper;

namespace TimeTableManagment.Forms
{
    public partial class GenerateTimeTable : Form
    {
        public GenerateTimeTable()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void SetConnection()
        {
            sql_con = new SQLiteConnection("Data Source=TimeTable.db;version=3;");
        }


        private void GenerateTimeTable_Load(object sender, EventArgs e)
        {
            LecturerNamecomboBox1.Enabled = false;
            ProgramcomboBox.Enabled = false;
            AcademicYearcomboBox.Enabled = false;
            AcademicSemcomboBox.Enabled = false;
            roomNumcomboBox.Enabled = false;
            GroupIDcomboBox.Enabled = false;

            LecturerradioButton.Checked = false;
            panel7.Visible = false;
            dataGridView7.Visible = false;
            printTimebutton.Visible = false;
            topicForTimeTable.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LecturerradioButton_CheckedChanged(object sender, EventArgs e)
        {
            LecturerNamecomboBox1.Enabled = true;
            ProgramcomboBox.Enabled = false;
            AcademicYearcomboBox.Enabled = false;
            AcademicSemcomboBox.Enabled = false;
            roomNumcomboBox.Enabled = false;
            GroupIDcomboBox.Enabled = false;
            LecturerNamecomboBox1.Items.Clear();
            FillLectureList();
        }

        private void StudentGroupradioButton_CheckedChanged(object sender, EventArgs e)
        {
            ProgramcomboBox.Enabled = true;
            AcademicYearcomboBox.Enabled = true;
            AcademicSemcomboBox.Enabled = true;
            roomNumcomboBox.Enabled = false;
            GroupIDcomboBox.Enabled = false;
            LecturerNamecomboBox1.Enabled = false;

        }

        private void RoomradioButton_CheckedChanged(object sender, EventArgs e)
        {
            roomNumcomboBox.Enabled = true;
            GroupIDcomboBox.Enabled = false;
            LecturerNamecomboBox1.Enabled = false;
            AcademicYearcomboBox.Enabled = false;
            AcademicSemcomboBox.Enabled = false;
            ProgramcomboBox.Enabled = false;
            roomNumcomboBox.Items.Clear();
            roomData_Fill_Combobox();
        }

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
                LecturerNamecomboBox1.Items.Add(dr["Title"].ToString() + dr["Name"].ToString());
            }
            sql_con.Close();
        }


        private void roomData_Fill_Combobox()
        {
            SetConnection();
            String getBuildings = "select RoomName from Rooms";
            sql_con.Open();
            SQLiteCommand command = new SQLiteCommand(getBuildings, sql_con);

            SQLiteDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string roomName = reader.GetString(0);

                roomNumcomboBox.Items.Add(roomName);
            }

            sql_con.Close();
        }



        private void AcademicSemcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupIDcomboBox.Enabled = true;
            GroupIDcomboBox.Items.Clear();
            fillGroupID_ComboBox();
        }


        private void fillGroupID_ComboBox()
        {
            String program = ProgramcomboBox.Text;
            String Year = AcademicYearcomboBox.Text;
            String sem = AcademicSemcomboBox.Text;

            String YearSem = Year + "." + sem;
            SetConnection();
            sql_con.Open();
            String getGids = "Select GroupID from Student where YearSem='" + YearSem + "' and Programme='" + program + "'";

           
            SQLiteCommand command = new SQLiteCommand(getGids, sql_con);

            SQLiteDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string roomName = reader.GetString(0);

               GroupIDcomboBox.Items.Add(roomName);
            }

            sql_con.Close();




        }

        private void AcademicYearcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            AcademicSemcomboBox.SelectedItem = null;
            GroupIDcomboBox.Enabled = false;
        }

        private void changeVisibility()
        {

            panel7.Visible = true;
            dataGridView7.Visible = true;
            printTimebutton.Visible = true;

            AcademicSemcomboBox.Visible = false;
            AcademicYearcomboBox.Visible = false;
            clearFieldsbutton.Visible = false;
            topicForTimeTable.Visible = true;
          
            generateTimeTblebutton.Visible = false;
            groupBox1.Visible = false;
            GroupIDcomboBox.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            LecturerNamecomboBox1.Visible = false;
            LecturerradioButton.Visible = false;
            LecturerradioButton.Visible = false;
            ProgramcomboBox.Visible = false;
            roomNumcomboBox.Visible = false;
            RoomradioButton.Visible = false;
            StudentGroupradioButton.Visible = false;
            weekDayradioButton.Visible = false;
            weekEndradioButton.Visible = false;


           

        }



      

        private void generateTimeTblebutton_Click(object sender, EventArgs e)
        {
            
            string lecName = LecturerNamecomboBox1.Text;
            string room = roomNumcomboBox.Text;
            string groupID = GroupIDcomboBox.Text;
          
            Boolean type = true;


         
                if (LecturerradioButton.Checked)
                {
                    if (LecturerNamecomboBox1.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select a Lecturer", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    type = false;
                }
                    else
                    if (type)
                    {

                       
                        if (weekDayradioButton.Checked)
                        {
                        changeVisibility();
                        generateTimeTableForLecturerWeekDay(lecName);
                        }
                        else
                             if (weekEndradioButton.Checked)
                        {
                        changeVisibility();
                        generateTimeTableForLecturerWeekEnd(lecName);
                        }
                        else
                        {
                        MessageBox.Show("Please Select WeekDay or Weekend", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        type = false;

                    }
                    }






                }
                else if (RoomradioButton.Checked)
                {

                    if (roomNumcomboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select a Room", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    type = false;
                }
                    else
                     if ( type)
                    {
                        
                        if (weekDayradioButton.Checked)
                        {
                        changeVisibility();
                        generateTimeTableForRoomWeekDay(room);

                        }
                        else
                       if (weekEndradioButton.Checked)
                        {
                        changeVisibility();
                        generateTimeTableForRoomWeekEnd(room);
                        }
                        else
                    {
                        MessageBox.Show("Please Select WeekDay or Weekend", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        type = false;

                    }

                }



                }
                else if (StudentGroupradioButton.Checked)
                {
                    if (GroupIDcomboBox.SelectedItem == null)
                    {
                        MessageBox.Show("Please Select a Group ID", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    type = false;
                }
                    else
                     if (  type)
                    {
                       
                        if (weekDayradioButton.Checked)
                        {
                        changeVisibility();
                        generateTimeTableForGroupWeekDay(groupID);
                        }
                        else
                      if (weekEndradioButton.Checked)
                        {
                        changeVisibility();
                        generateTimeTableForGroupWeekEnd(groupID);
                        }
                        else
                    {
                        MessageBox.Show("Please Select WeekDay or Weekend", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        type = false;

                    }
                }


            }
            else
            {
                MessageBox.Show("Please Fill All The Fields", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                type = false;
            }

            //}






        }



        private void generateTimeTableForLecturerWeekDay(string lecName)
        {

            creeateDataTable(lecName, lecName);

        }

        private void generateTimeTableForLecturerWeekEnd(string lecName)
        {

            creeateWeekEndDataTable(lecName, lecName);

        }

        private void generateTimeTableForRoomWeekDay(string room)
        {
            createDataTableForWeekDayRoom(room);
        }

        private void generateTimeTableForRoomWeekEnd(string room)
        {
            createDataTableForWeekEndRoom(room);
        }

        private void generateTimeTableForGroupWeekDay(string gid)
        {
            createDataTableForWeekDayGroup(gid);
        }

        private void generateTimeTableForGroupWeekEnd(string gid)
        {
            createDataTableForWeekEndGroup(gid);
        }


        private void creeateDataTable(string title,string lName)
        {
            DataTable dt = new DataTable(title);

            topicForTimeTable.Text = title;

            DataColumn cltime = new DataColumn("Time");
            dt.Columns.Add(cltime);

            DataColumn cl1 = new DataColumn("Monday");
            dt.Columns.Add(cl1);

            DataColumn cl2 = new DataColumn("Tuesday");
            dt.Columns.Add(cl2);

            DataColumn cl3 = new DataColumn("Wednesday");
            dt.Columns.Add(cl3);

            DataColumn cl4 = new DataColumn("Thursday");
            dt.Columns.Add(cl4);

            DataColumn cl5 = new DataColumn("Friday");
            dt.Columns.Add(cl5);


  

            DataRow dr1 = dt.NewRow();
            dr1["Time"] = "8.30";
            dr1["Monday"] = retrieveData("8.30", "Monday",lName);
            dr1["Tuesday"] = retrieveData("8.30", "Tuesday", lName);
            dr1["Wednesday"] = retrieveData("8.30", "Wednesday", lName);
            dr1["Thursday"] = retrieveData("8.30", "Thursday", lName);
            dr1["Friday"] = retrieveData("8.30", "Friday", lName);
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["Time"] = "9.30";
            dr2["Monday"] = retrieveData("9.30", "Monday", lName);
            dr2["Tuesday"] = retrieveData("9.30", "Tuesday", lName);
            dr2["Wednesday"] = retrieveData("9.30", "Wednesday", lName);
            dr2["Thursday"] = retrieveData("9.30", "Thursday", lName);
            dr2["Friday"] = retrieveData("9.30", "Friday", lName);
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["Time"] = "10.30";
            dr3["Monday"] = retrieveData("10.30", "Monday", lName);
            dr3["Tuesday"] = retrieveData("10.30", "Tuesday", lName);
            dr3["Wednesday"] = retrieveData("10.30", "Wednesday", lName);
            dr3["Thursday"] = retrieveData("10.30", "Thursday", lName);
            dr3["Friday"] = retrieveData("10.30", "Friday", lName);
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["Time"] = "11.30";
            dr4["Monday"] = retrieveData("11.30", "Monday", lName);
            dr4["Tuesday"] = retrieveData("11.30", "Tuesday", lName);
            dr4["Wednesday"] = retrieveData("11.30", "Wednesday", lName);
            dr4["Thursday"] = retrieveData("11.30", "Thursday", lName);
            dr4["Friday"] = retrieveData("11.30", "Friday", lName);
            dt.Rows.Add(dr4);

            DataRow dr5 = dt.NewRow();
            dr5["Time"] = "12.30";
            dr5["Monday"] = retrieveData("12.30", "Monday", lName);
            dr5["Tuesday"] = retrieveData("12.30", "Tuesday", lName);
            dr5["Wednesday"] = retrieveData("12.30", "Wednesday", lName);
            dr5["Thursday"] = retrieveData("12.30", "Thursday", lName);
            dr5["Friday"] = retrieveData("12.30", "Friday", lName);
            dt.Rows.Add(dr5);

            DataRow dr6 = dt.NewRow();
            dr6["Time"] = "13.30";
            dr6["Monday"] = retrieveData("13.30", "Monday", lName);
            dr6["Tuesday"] = retrieveData("13.30", "Tuesday", lName);
            dr6["Wednesday"] = retrieveData("13.30", "Wednesday", lName);
            dr6["Thursday"] = retrieveData("13.30", "Thursday", lName);
            dr6["Friday"] = retrieveData("13.30", "Friday", lName);
            dt.Rows.Add(dr6);

            DataRow dr7 = dt.NewRow();
            dr7["Time"] = "14.30";
            dr7["Monday"] = retrieveData("14.30", "Monday", lName);
            dr7["Tuesday"] = retrieveData("14.30", "Tuesday", lName);
            dr7["Wednesday"] = retrieveData("14.30", "Wednesday", lName);
            dr7["Thursday"] = retrieveData("14.30", "Thursday", lName);
            dr7["Friday"] = retrieveData("14.30", "Friday", lName);
            dt.Rows.Add(dr7);

            DataRow dr8 = dt.NewRow();
            dr8["Time"] = "15.30";
            dr8["Monday"] = retrieveData("15.30", "Monday", lName);
            dr8["Tuesday"] = retrieveData("15.30", "Tuesday", lName);
            dr8["Wednesday"] = retrieveData("15.30", "Wednesday", lName);
            dr8["Thursday"] = retrieveData("15.30", "Thursday", lName);
            dr8["Friday"] = retrieveData("15.30", "Friday", lName);
            dt.Rows.Add(dr8);

            DataRow dr9 = dt.NewRow();
            dr9["Time"] = "16.30";
            dr9["Monday"] = retrieveData("16.30", "Monday", lName);
            dr9["Tuesday"] = retrieveData("16.30", "Tuesday", lName);
            dr9["Wednesday"] = retrieveData("16.30", "Wednesday", lName);
            dr9["Thursday"] = retrieveData("16.30", "Thursday", lName);
            dr9["Friday"] = retrieveData("16.30", "Friday", lName);
            dt.Rows.Add(dr9);

            DataRow dr10 = dt.NewRow();
            dr10["Time"] = "17.30";
            dr10["Monday"] = retrieveData("17.30", "Monday", lName);
            dr10["Tuesday"] = retrieveData("17.30", "Tuesday", lName);
            dr10["Wednesday"] = retrieveData("17.30", "Wednesday", lName);
            dr10["Thursday"] = retrieveData("17.30", "Thursday", lName);
            dr10["Friday"] = retrieveData("17.30", "Friday", lName);
            dt.Rows.Add(dr10);


            this.dataGridView7.DataSource = dt;
        }




        private void creeateWeekEndDataTable(string title, string lName)
        {

            topicForTimeTable.Text = title;

            DataTable dt = new DataTable(title);


            DataColumn cltime = new DataColumn("Time");
            dt.Columns.Add(cltime);

            DataColumn cl1 = new DataColumn("Saturday");
            dt.Columns.Add(cl1);

            DataColumn cl2 = new DataColumn("Sunday");
            dt.Columns.Add(cl2);


            DataRow dr1 = dt.NewRow();
            dr1["Time"] = "8.30";
            dr1["Saturday"] = retrieveData("8.30", "Saturday", lName);
            dr1["Sunday"] = retrieveData("8.30", "Sunday", lName);
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["Time"] = "9.30";
            dr2["Saturday"] = retrieveData("9.30", "Saturday", lName);
            dr2["Sunday"] = retrieveData("9.30", "Sunday", lName);
            dt.Rows.Add(dr2);


            DataRow dr3 = dt.NewRow();
            dr3["Time"] = "10.30";
            dr3["Saturday"] = retrieveData("10.30", "Saturday", lName);
            dr3["Sunday"] = retrieveData("10.30", "Sunday", lName);
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["Time"] = "11.30";
            dr4["Saturday"] = retrieveData("11.30", "Saturday", lName);
            dr4["Sunday"] = retrieveData("11.30", "Sunday", lName);
            dt.Rows.Add(dr4);

            DataRow dr5 = dt.NewRow();
            dr5["Time"] = "12.30";
            dr5["Saturday"] = retrieveData("12.30", "Saturday", lName);
            dr5["Sunday"] = retrieveData("12.30", "Sunday", lName);
            dt.Rows.Add(dr5);

            DataRow dr6 = dt.NewRow();
            dr6["Time"] = "13.00";
            dr6["Saturday"] = retrieveData("13.00", "Saturday", lName);
            dr6["Sunday"] = retrieveData("13.300", "Sunday", lName);
            dt.Rows.Add(dr6);

            DataRow dr7 = dt.NewRow();
            dr7["Time"] = "14.00";
            dr7["Saturday"] = retrieveData("14.00", "Saturday", lName);
            dr7["Sunday"] = retrieveData("14.00", "Sunday", lName);
            dt.Rows.Add(dr7);

            DataRow dr8 = dt.NewRow();
            dr8["Time"] = "15.00";
            dr8["Saturday"] = retrieveData("15.00", "Saturday", lName);
            dr8["Sunday"] = retrieveData("15.00", "Sunday", lName);
            dt.Rows.Add(dr8);

            DataRow dr9 = dt.NewRow();
            dr9["Time"] = "16.00";
            dr9["Saturday"] = retrieveData("16.00", "Saturday", lName);
            dr9["Sunday"] = retrieveData("16.00", "Sunday", lName);
          
            dt.Rows.Add(dr9);

            DataRow dr10 = dt.NewRow();
            dr10["Time"] = "17.00";
            dr10["Saturday"] = retrieveData("17.00", "Saturday", lName);
            dr10["Sunday"] = retrieveData("17.00", "Sunday", lName);
            dt.Rows.Add(dr10);

            DataRow dr11 = dt.NewRow();
            dr11["Time"] = "18.00";
            dr11["Saturday"] = retrieveData("18.00", "Saturday", lName);
            dr11["Sunday"] = retrieveData("18.00", "Sunday", lName);
            dt.Rows.Add(dr11);

            DataRow dr12 = dt.NewRow();
            dr10["Time"] = "19.00";
            dr10["Saturday"] = retrieveData("19.00", "Saturday", lName);
            dr10["Sunday"] = retrieveData("19.00", "Sunday", lName);
            dt.Rows.Add(dr12);

            this.dataGridView7.DataSource = dt;

        }

        private string FormatData(string subCode, string subName, string groupID, string subgroupID, string roomName,string tag)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(subCode + "-" + subName+"("+tag+")");

            if(tag == "Practical")
            {
                sb.AppendLine(subgroupID);
            }
            else
            {
                sb.AppendLine(groupID);
            }

            sb.AppendLine(roomName);

            return sb.ToString();
        }


        private string retrieveData(string time, string date,string lec)
        {


            string subCode = "";
            string subName = "";
            string gID = "";
            string subgroupID = "";
            string roomName = "";
            string tag = "";
            string lecturers = "";

           
                try
                {
                    SetConnection();
                    String getlecData = "select SubjectCode,Room,SubjectName,GroupID,SubGroupID,Tag,Lecturers from allData where Lecturers LIKE'" + lec + "%'  and StartTime='" + time + "' and Day='" + date + "'";
                    sql_con.Open();
                    SQLiteCommand command = new SQLiteCommand(getlecData, sql_con);

                    SQLiteDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        subCode = reader.GetString(0);
                        roomName = reader.GetString(1);
                        subName = reader.GetString(2);
                        gID = reader.GetString(3);
                        subgroupID = reader.GetString(4);
                        tag = reader.GetString(5);
                    lecturers = reader.GetString(6);
                    }



                }
                catch (Exception e)
                {
                    Console.Write(e.ToString() + "Problem here");

                }
                sql_con.Close();

                return this.FormatData(subCode, subName, gID, subgroupID, roomName, tag);
     

        }


        private void createDataTableForWeekDayRoom(string room)
        {
            topicForTimeTable.Text = room;
            DataTable dt = new DataTable(room);

            DataColumn cltime = new DataColumn("Time");
            dt.Columns.Add(cltime);

            DataColumn cl1 = new DataColumn("Monday");
            dt.Columns.Add(cl1);

            DataColumn cl2 = new DataColumn("Tuesday");
            dt.Columns.Add(cl2);

            DataColumn cl3 = new DataColumn("Wednesday");
            dt.Columns.Add(cl3);

            DataColumn cl4 = new DataColumn("Thursday");
            dt.Columns.Add(cl4);

            DataColumn cl5 = new DataColumn("Friday");
            dt.Columns.Add(cl5);



            DataRow dr1 = dt.NewRow();
            dr1["Time"] = "8.30";
            dr1["Monday"] = retrieveDataForRoom("8.30", "Monday", room);
            dr1["Tuesday"] = retrieveDataForRoom("8.30", "Tuesday", room);
            dr1["Wednesday"] =  retrieveDataForRoom("8.30", "Wednesday", room);
            dr1["Thursday"] =  retrieveDataForRoom("8.30", "Thursday", room);
            dr1["Friday"] =  retrieveDataForRoom("8.30", "Friday", room);
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["Time"] = "9.30";
            dr2["Monday"] =  retrieveDataForRoom("9.30", "Monday", room);
            dr2["Tuesday"] =  retrieveDataForRoom("9.30", "Tuesday", room);
            dr2["Wednesday"] =  retrieveDataForRoom("9.30", "Wednesday", room);
            dr2["Thursday"] =  retrieveDataForRoom("9.30", "Thursday", room);
            dr2["Friday"] =  retrieveDataForRoom("9.30", "Friday", room);
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["Time"] = "10.30";
            dr3["Monday"] =  retrieveDataForRoom("10.30", "Monday", room);
            dr3["Tuesday"] =  retrieveDataForRoom("10.30", "Tuesday", room);
            dr3["Wednesday"] =  retrieveDataForRoom("10.30", "Wednesday", room);
            dr3["Thursday"] =  retrieveDataForRoom("10.30", "Thursday", room);
            dr3["Friday"] =  retrieveDataForRoom("10.30", "Friday", room);
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["Time"] = "11.30";
            dr4["Monday"] =  retrieveDataForRoom("11.30", "Monday", room);
            dr4["Tuesday"] =  retrieveDataForRoom("11.30", "Tuesday", room);
            dr4["Wednesday"] =  retrieveDataForRoom("11.30", "Wednesday", room);
            dr4["Thursday"] =  retrieveDataForRoom("11.30", "Thursday", room);
            dr4["Friday"] =  retrieveDataForRoom("11.30", "Friday", room);
            dt.Rows.Add(dr4);

            DataRow dr5 = dt.NewRow();
            dr5["Time"] = "12.30";
            dr5["Monday"] =  retrieveDataForRoom("12.30", "Monday", room);
            dr5["Tuesday"] =  retrieveDataForRoom("12.30", "Tuesday", room);
            dr5["Wednesday"] =  retrieveDataForRoom("12.30", "Wednesday", room);
            dr5["Thursday"] =  retrieveDataForRoom("12.30", "Thursday", room);
            dr5["Friday"] =  retrieveDataForRoom("12.30", "Friday", room);
            dt.Rows.Add(dr5);

            DataRow dr6 = dt.NewRow();
            dr6["Time"] = "13.30";
            dr6["Monday"] =  retrieveDataForRoom("13.30", "Monday", room);
            dr6["Tuesday"] =  retrieveDataForRoom("13.30", "Tuesday", room);
            dr6["Wednesday"] =  retrieveDataForRoom("13.30", "Wednesday", room);
            dr6["Thursday"] =  retrieveDataForRoom("13.30", "Thursday", room);
            dr6["Friday"] =  retrieveDataForRoom("13.30", "Friday", room);
            dt.Rows.Add(dr6);

            DataRow dr7 = dt.NewRow();
            dr7["Time"] = "14.30";
            dr7["Monday"] =  retrieveDataForRoom("14.30", "Monday", room);
            dr7["Tuesday"] =  retrieveDataForRoom("14.30", "Tuesday", room);
            dr7["Wednesday"] =  retrieveDataForRoom("14.30", "Wednesday", room);
            dr7["Thursday"] =  retrieveDataForRoom("14.30", "Thursday", room);
            dr7["Friday"] =  retrieveDataForRoom("14.30", "Friday", room);
            dt.Rows.Add(dr7);

            DataRow dr8 = dt.NewRow();
            dr8["Time"] = "15.30";
            dr8["Monday"] =  retrieveDataForRoom("15.30", "Monday", room);
            dr8["Tuesday"] =  retrieveDataForRoom("15.30", "Tuesday", room);
            dr8["Wednesday"] =  retrieveDataForRoom("15.30", "Wednesday", room);
            dr8["Thursday"] =  retrieveDataForRoom("15.30", "Thursday", room);
            dr8["Friday"] =  retrieveDataForRoom("15.30", "Friday", room);
            dt.Rows.Add(dr8);

            DataRow dr9 = dt.NewRow();
            dr9["Time"] = "16.30";
            dr9["Monday"] =  retrieveDataForRoom("16.30", "Monday", room);
            dr9["Tuesday"] =  retrieveDataForRoom("16.30", "Tuesday", room);
            dr9["Wednesday"] =  retrieveDataForRoom("16.30", "Wednesday", room);
            dr9["Thursday"] =  retrieveDataForRoom("16.30", "Thursday", room);
            dr9["Friday"] =  retrieveDataForRoom("16.30", "Friday", room);
            dt.Rows.Add(dr9);

            DataRow dr10 = dt.NewRow();
            dr10["Time"] = "17.30";
            dr10["Monday"] =  retrieveDataForRoom("17.30", "Monday", room);
            dr10["Tuesday"] =  retrieveDataForRoom("17.30", "Tuesday", room);
            dr10["Wednesday"] =  retrieveDataForRoom("17.30", "Wednesday", room);
            dr10["Thursday"] =  retrieveDataForRoom("17.30", "Thursday", room);
            dr10["Friday"] =  retrieveDataForRoom("17.30", "Friday", room);
            dt.Rows.Add(dr10);


            this.dataGridView7.DataSource = dt;
        }

        private void createDataTableForWeekEndRoom(string room)
        {
            topicForTimeTable.Text = room;
            DataTable dt = new DataTable(room);

            DataColumn cltime = new DataColumn("Time");
            dt.Columns.Add(cltime);

            DataColumn cl1 = new DataColumn("Saturday");
            dt.Columns.Add(cl1);

            DataColumn cl2 = new DataColumn("Sunday");
            dt.Columns.Add(cl2);


            DataRow dr1 = dt.NewRow();
            dr1["Time"] = "8.30";
            dr1["Saturday"] = retrieveDataForRoom("8.30", "Saturday", room);
            dr1["Sunday"] = retrieveDataForRoom("8.30", "Sunday", room);
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["Time"] = "9.30";
            dr2["Saturday"] = retrieveDataForRoom("9.30", "Saturday", room);
            dr2["Sunday"] = retrieveDataForRoom("9.30", "Sunday", room);
            dt.Rows.Add(dr2);


            DataRow dr3 = dt.NewRow();
            dr3["Time"] = "10.30";
            dr3["Saturday"] = retrieveDataForRoom("10.30", "Saturday", room);
            dr3["Sunday"] = retrieveDataForRoom("10.30", "Sunday", room);
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["Time"] = "11.30";
            dr4["Saturday"] = retrieveDataForRoom("11.30", "Saturday", room);
            dr4["Sunday"] = retrieveDataForRoom("11.30", "Sunday", room);
            dt.Rows.Add(dr4);

            DataRow dr5 = dt.NewRow();
            dr5["Time"] = "12.30";
            dr5["Saturday"] = retrieveDataForRoom("12.30", "Saturday", room);
            dr5["Sunday"] = retrieveDataForRoom("12.30", "Sunday", room);
            dt.Rows.Add(dr5);

            DataRow dr6 = dt.NewRow();
            dr6["Time"] = "13.00";
            dr6["Saturday"] = retrieveDataForRoom("13.00", "Saturday", room);
            dr6["Sunday"] = retrieveDataForRoom("13.300", "Sunday", room);
            dt.Rows.Add(dr6);

            DataRow dr7 = dt.NewRow();
            dr7["Time"] = "14.00";
            dr7["Saturday"] = retrieveDataForRoom("14.00", "Saturday", room);
            dr7["Sunday"] = retrieveDataForRoom("14.00", "Sunday", room);
            dt.Rows.Add(dr7);

            DataRow dr8 = dt.NewRow();
            dr8["Time"] = "15.00";
            dr8["Saturday"] = retrieveDataForRoom("15.00", "Saturday", room);
            dr8["Sunday"] = retrieveDataForRoom("15.00", "Sunday", room);
            dt.Rows.Add(dr8);

            DataRow dr9 = dt.NewRow();
            dr9["Time"] = "16.00";
            dr9["Saturday"] = retrieveDataForRoom("16.00", "Saturday", room);
            dr9["Sunday"] = retrieveDataForRoom("16.00", "Sunday", room);

            dt.Rows.Add(dr9);

            DataRow dr10 = dt.NewRow();
            dr10["Time"] = "17.00";
            dr10["Saturday"] = retrieveDataForRoom("17.00", "Saturday", room);
            dr10["Sunday"] = retrieveDataForRoom("17.00", "Sunday", room);
            dt.Rows.Add(dr10);

            DataRow dr11 = dt.NewRow();
            dr11["Time"] = "18.00";
            dr11["Saturday"] = retrieveDataForRoom("18.00", "Saturday", room);
            dr11["Sunday"] = retrieveDataForRoom("18.00", "Sunday", room);
            dt.Rows.Add(dr11);

            DataRow dr12 = dt.NewRow();
            dr10["Time"] = "19.00";
            dr10["Saturday"] = retrieveDataForRoom("19.00", "Saturday", room);
            dr10["Sunday"] = retrieveDataForRoom("19.00", "Sunday", room);
            dt.Rows.Add(dr12);

            this.dataGridView7.DataSource = dt;

        }

        private string retrieveDataForRoom(string time, string date, string room)
        {

            string subCode = "";
            string subName = "";
            string gID = "";
            string subgroupID = "";
            string tag = "";
            string lecturs = "";

           
                try
                {
                    SetConnection();
                    String getRoomData = "select SubjectCode,SubjectName,GroupID,SubGroupID,Tag,Lecturers from allData where room='" + room + "'and StartTime='" + time + "' and Day='" + date + "'";
                    sql_con.Open();
                    SQLiteCommand command = new SQLiteCommand(getRoomData, sql_con);

                    SQLiteDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        subCode = reader.GetString(0);

                        subName = reader.GetString(1);
                        gID = reader.GetString(2);
                        subgroupID = reader.GetString(3);
                        tag = reader.GetString(4);
                    lecturs = reader.GetString(5);
                    }



                }
                catch (Exception e)
                {
                    Console.Write(e.ToString() + "Problem here");

                }
                sql_con.Close();

                return this.FormatDataForRoom(subCode, subName, gID, subgroupID, tag,lecturs);
            


        }

        private string FormatDataForRoom(string subCode, string subName, string groupID, string subgroupID, string tag,string lecturers)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(subCode + "-" + subName + "(" + tag + ")");
            sb.AppendLine(lecturers);

            if (tag == "Practical")
            {
                sb.AppendLine(subgroupID);
            }
            else
            {
                sb.AppendLine(groupID);
            }

            return sb.ToString();
        }

        private void createDataTableForWeekDayGroup(string gid)
        {
            topicForTimeTable.Text = gid;
            DataTable dt = new DataTable(gid);

            DataColumn cltime = new DataColumn("Time");
            dt.Columns.Add(cltime);

            DataColumn cl1 = new DataColumn("Monday");
            dt.Columns.Add(cl1);

            DataColumn cl2 = new DataColumn("Tuesday");
            dt.Columns.Add(cl2);

            DataColumn cl3 = new DataColumn("Wednesday");
            dt.Columns.Add(cl3);

            DataColumn cl4 = new DataColumn("Thursday");
            dt.Columns.Add(cl4);

            DataColumn cl5 = new DataColumn("Friday");
            dt.Columns.Add(cl5);



            DataRow dr1 = dt.NewRow();
            dr1["Time"] = "8.30";
            dr1["Monday"] = retrieveDataForGroup("8.30", "Monday", gid);
            dr1["Tuesday"] =  retrieveDataForGroup("8.30", "Tuesday", gid);
            dr1["Wednesday"] =  retrieveDataForGroup("8.30", "Wednesday", gid);
            dr1["Thursday"] =  retrieveDataForGroup("8.30", "Thursday", gid);
            dr1["Friday"] =  retrieveDataForGroup("8.30", "Friday", gid);
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["Time"] = "9.30";
            dr2["Monday"] =  retrieveDataForGroup("9.30", "Monday", gid);
            dr2["Tuesday"] =  retrieveDataForGroup("9.30", "Tuesday", gid);
            dr2["Wednesday"] =  retrieveDataForGroup("9.30", "Wednesday", gid);
            dr2["Thursday"] =  retrieveDataForGroup("9.30", "Thursday", gid);
            dr2["Friday"] =  retrieveDataForGroup("9.30", "Friday", gid);
            dt.Rows.Add(dr2);

            DataRow dr3 = dt.NewRow();
            dr3["Time"] = "10.30";
            dr3["Monday"] =  retrieveDataForGroup("10.30", "Monday", gid);
            dr3["Tuesday"] =  retrieveDataForGroup("10.30", "Tuesday", gid);
            dr3["Wednesday"] =  retrieveDataForGroup("10.30", "Wednesday", gid);
            dr3["Thursday"] =  retrieveDataForGroup("10.30", "Thursday", gid);
            dr3["Friday"] =  retrieveDataForGroup("10.30", "Friday", gid);
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["Time"] = "11.30";
            dr4["Monday"] =  retrieveDataForGroup("11.30", "Monday", gid);
            dr4["Tuesday"] =  retrieveDataForGroup("11.30", "Tuesday", gid);
            dr4["Wednesday"] =  retrieveDataForGroup("11.30", "Wednesday", gid);
            dr4["Thursday"] =  retrieveDataForGroup("11.30", "Thursday", gid);
            dr4["Friday"] =  retrieveDataForGroup("11.30", "Friday", gid);
            dt.Rows.Add(dr4);

            DataRow dr5 = dt.NewRow();
            dr5["Time"] = "12.30";
            dr5["Monday"] =  retrieveDataForGroup("12.30", "Monday", gid);
            dr5["Tuesday"] =  retrieveDataForGroup("12.30", "Tuesday", gid);
            dr5["Wednesday"] =  retrieveDataForGroup("12.30", "Wednesday", gid);
            dr5["Thursday"] =  retrieveDataForGroup("12.30", "Thursday", gid);
            dr5["Friday"] =  retrieveDataForGroup("12.30", "Friday", gid);
            dt.Rows.Add(dr5);

            DataRow dr6 = dt.NewRow();
            dr6["Time"] = "13.30";
            dr6["Monday"] =  retrieveDataForGroup("13.30", "Monday", gid);
            dr6["Tuesday"] =  retrieveDataForGroup("13.30", "Tuesday", gid);
            dr6["Wednesday"] =  retrieveDataForGroup("13.30", "Wednesday", gid);
            dr6["Thursday"] =  retrieveDataForGroup("13.30", "Thursday", gid);
            dr6["Friday"] =  retrieveDataForGroup("13.30", "Friday", gid);
            dt.Rows.Add(dr6);

            DataRow dr7 = dt.NewRow();
            dr7["Time"] = "14.30";
            dr7["Monday"] =  retrieveDataForGroup("14.30", "Monday", gid);
            dr7["Tuesday"] =  retrieveDataForGroup("14.30", "Tuesday", gid);
            dr7["Wednesday"] =  retrieveDataForGroup("14.30", "Wednesday", gid);
            dr7["Thursday"] =  retrieveDataForGroup("14.30", "Thursday", gid);
            dr7["Friday"] =  retrieveDataForGroup("14.30", "Friday", gid);
            dt.Rows.Add(dr7);

            DataRow dr8 = dt.NewRow();
            dr8["Time"] = "15.30";
            dr8["Monday"] =  retrieveDataForGroup("15.30", "Monday", gid);
            dr8["Tuesday"] =  retrieveDataForGroup("15.30", "Tuesday", gid);
            dr8["Wednesday"] =  retrieveDataForGroup("15.30", "Wednesday", gid);
            dr8["Thursday"] =  retrieveDataForGroup("15.30", "Thursday", gid);
            dr8["Friday"] =  retrieveDataForGroup("15.30", "Friday", gid);
            dt.Rows.Add(dr8);

            DataRow dr9 = dt.NewRow();
            dr9["Time"] = "16.30";
            dr9["Monday"] =  retrieveDataForGroup("16.30", "Monday", gid);
            dr9["Tuesday"] =  retrieveDataForGroup("16.30", "Tuesday", gid);
            dr9["Wednesday"] =  retrieveDataForGroup("16.30", "Wednesday", gid);
            dr9["Thursday"] =  retrieveDataForGroup("16.30", "Thursday", gid);
            dr9["Friday"] =  retrieveDataForGroup("16.30", "Friday", gid);
            dt.Rows.Add(dr9);

            DataRow dr10 = dt.NewRow();
            dr10["Time"] = "17.30";
            dr10["Monday"] =  retrieveDataForGroup("17.30", "Monday", gid);
            dr10["Tuesday"] =  retrieveDataForGroup("17.30", "Tuesday", gid);
            dr10["Wednesday"] =  retrieveDataForGroup("17.30", "Wednesday", gid);
            dr10["Thursday"] =  retrieveDataForGroup("17.30", "Thursday", gid);
            dr10["Friday"] =  retrieveDataForGroup("17.30", "Friday", gid);
            dt.Rows.Add(dr10);


            this.dataGridView7.DataSource = dt;
        }

        private void createDataTableForWeekEndGroup(string gid)
        {
            topicForTimeTable.Text = gid;
            DataTable dt = new DataTable(gid);

            DataColumn cltime = new DataColumn("Time");
            dt.Columns.Add(cltime);

            DataColumn cl1 = new DataColumn("Saturday");
            dt.Columns.Add(cl1);

            DataColumn cl2 = new DataColumn("Sunday");
            dt.Columns.Add(cl2);


            DataRow dr1 = dt.NewRow();
            dr1["Time"] = "8.30";
            dr1["Saturday"] = retrieveDataForGroup("8.30", "Saturday", gid);
            dr1["Sunday"] = retrieveDataForGroup("8.30", "Sunday", gid);
            dt.Rows.Add(dr1);

            DataRow dr2 = dt.NewRow();
            dr2["Time"] = "9.30";
            dr2["Saturday"] = retrieveDataForGroup("9.30", "Saturday", gid);
            dr2["Sunday"] = retrieveDataForGroup("9.30", "Sunday", gid);
            dt.Rows.Add(dr2);


            DataRow dr3 = dt.NewRow();
            dr3["Time"] = "10.30";
            dr3["Saturday"] = retrieveDataForGroup("10.30", "Saturday", gid);
            dr3["Sunday"] = retrieveDataForGroup("10.30", "Sunday", gid);
            dt.Rows.Add(dr3);

            DataRow dr4 = dt.NewRow();
            dr4["Time"] = "11.30";
            dr4["Saturday"] = retrieveDataForGroup("11.30", "Saturday", gid);
            dr4["Sunday"] = retrieveDataForGroup("11.30", "Sunday", gid);
            dt.Rows.Add(dr4);

            DataRow dr5 = dt.NewRow();
            dr5["Time"] = "12.30";
            dr5["Saturday"] = retrieveDataForGroup("12.30", "Saturday", gid);
            dr5["Sunday"] = retrieveDataForGroup("12.30", "Sunday", gid);
            dt.Rows.Add(dr5);

            DataRow dr6 = dt.NewRow();
            dr6["Time"] = "13.00";
            dr6["Saturday"] = retrieveDataForGroup("13.00", "Saturday", gid);
            dr6["Sunday"] = retrieveDataForGroup("13.300", "Sunday", gid);
            dt.Rows.Add(dr6);

            DataRow dr7 = dt.NewRow();
            dr7["Time"] = "14.00";
            dr7["Saturday"] = retrieveDataForGroup("14.00", "Saturday", gid);
            dr7["Sunday"] = retrieveDataForGroup("14.00", "Sunday", gid);
            dt.Rows.Add(dr7);

            DataRow dr8 = dt.NewRow();
            dr8["Time"] = "15.00";
            dr8["Saturday"] = retrieveDataForGroup("15.00", "Saturday", gid);
            dr8["Sunday"] = retrieveDataForGroup("15.00", "Sunday", gid);
            dt.Rows.Add(dr8);

            DataRow dr9 = dt.NewRow();
            dr9["Time"] = "16.00";
            dr9["Saturday"] = retrieveDataForGroup("16.00", "Saturday", gid);
            dr9["Sunday"] = retrieveDataForGroup("16.00", "Sunday", gid);

            dt.Rows.Add(dr9);

            DataRow dr10 = dt.NewRow();
            dr10["Time"] = "17.00";
            dr10["Saturday"] = retrieveDataForGroup("17.00", "Saturday", gid);
            dr10["Sunday"] = retrieveDataForGroup("17.00", "Sunday", gid);
            dt.Rows.Add(dr10);

            DataRow dr11 = dt.NewRow();
            dr11["Time"] = "18.00";
            dr11["Saturday"] = retrieveDataForGroup("18.00", "Saturday", gid);
            dr11["Sunday"] = retrieveDataForGroup("18.00", "Sunday", gid);
            dt.Rows.Add(dr11);

            DataRow dr12 = dt.NewRow();
            dr10["Time"] = "19.00";
            dr10["Saturday"] = retrieveDataForGroup("19.00", "Saturday", gid);
            dr10["Sunday"] = retrieveDataForGroup("19.00", "Sunday", gid);
            dt.Rows.Add(dr12);

            this.dataGridView7.DataSource = dt;

        }

        private string retrieveDataForGroup(string time, string date, string gid)
        {

            string subCode = "";
            string subName = "";
           // string gID = "";
            string subgroupID = "";
            string tag = "";
            string room = "";
            string lecturs = "";


            try
            {
                SetConnection();
                String getRoomData = "select SubjectCode,SubjectName,SubGroupID,Tag,Room,Lecturers from allData where GroupID='" + gid + "'and StartTime='" + time + "' and Day='" + date + "'";
                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(getRoomData, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    subCode = reader.GetString(0);

                    subName = reader.GetString(1);
                    subgroupID = reader.GetString(2);
                    tag = reader.GetString(3);
                    room = reader.GetString(4);
                    lecturs = reader.GetString(5);
                }



            }
            catch (Exception e)
            {
                Console.Write(e.ToString() + "Problem here");

            }
            sql_con.Close();

            return this.FormatDataForGroup(subCode, subName,  subgroupID, tag,room,lecturs);



        }


        private string FormatDataForGroup(string subCode, string subName,string subgroupID, string tag,string room, string lecturers)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(subCode + "-" + subName + "(" + tag + ")");
            sb.AppendLine(lecturers);

            if (tag == "Practical")
            {
                sb.AppendLine(subgroupID);
            }

            sb.AppendLine(room);

            return sb.ToString();
        }


        private void printTimebutton_Click(object sender, EventArgs e)
        {

            DGVPrinter printer = new DGVPrinter();
            printer.Title = "Time Table";
            printer.SubTitle = topicForTimeTable.Text;

            printer.Footer = string.Format("Date :{0}", DateTime.Now.Date);
            printer.PrintDataGridView(dataGridView7);

           

        }
    }
}
