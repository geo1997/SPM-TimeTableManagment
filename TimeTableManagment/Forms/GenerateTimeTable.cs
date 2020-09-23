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

            String getBuildings = "select * from Rooms";
            sql_con.Open();
            SQLiteCommand command = new SQLiteCommand(getBuildings, sql_con);

            SQLiteDataReader reader = command.ExecuteReader();


            while (reader.Read())
            {
                string roomName = reader.GetString(1);

                roomNumcomboBox.Items.Add(roomName);
            }

            sql_con.Close();
        }



        private void AcademicSemcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GroupIDcomboBox.Enabled = true;

            //String program = ProgramcomboBox.Text;
            //String Year = AcademicYearcomboBox.Text;
            //String sem = AcademicSemcomboBox.Text;


            //if(program == "")
            //{
            //    MessageBox.Show("Please select the Program  ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //if(Year == "")
            //{
            //    MessageBox.Show("Please select the Year  ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //if(sem == "")
            //{
            //    MessageBox.Show("Please select the Semester  ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //if(program != "" && Year !="" && sem != "")
            //{
            //    GroupIDcomboBox.Items.Clear();
            //    fillGroupID_ComboBox();
            //}

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
    }
}
