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
using System.Windows.Forms.VisualStyles;

namespace TimeTableManagment.Forms
{
    public partial class AvailabilityForm : Form
    {
        public AvailabilityForm()
        {
            InitializeComponent();
           
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private int AvailabilityIDs = 0;
        private int roomID = 0;


        string lLecturer = "";
        string lSubject = "";
        string lTag = "";
        string lGroupID = "";
       

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
        /*
         **BUILDING TAB****
         */

        //load building data

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select * from Availability ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
            }

       



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            AvailabilityIDs = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            comboBox3.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            startTimecomboBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            endTimecomboBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            loadSessioncomboBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();

            button3.Visible = true;
            button1.Visible = false;
            button4.Visible = true;
            label15.Visible = true;
            labelLec.Visible = false;
        }


        private void label7_Click(object sender, EventArgs e)
        {

        }

        


        private void button3_Click(object sender, EventArgs e)
        {


            String startTime = startTimecomboBox.Text;
            String endTime = endTimecomboBox.Text;
            int sesID = int.Parse(loadSessioncomboBox.Text);

            if (AvailabilityIDs > 0)
            {
                button1.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                labelLec.Visible = true;
                label15.Visible = false;

                String updateQuery = "update Availability set sessionID='" + sesID + "',Day='" + comboBox3.Text + "',Froms='" + startTime + "',Tos='" + endTime + "'" +
               "where AvailabilityID='" + this.AvailabilityIDs + "'";
                ExecuteQuery(updateQuery);
                MessageBox.Show("Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearDetails();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AvailabilityForm_Load(object sender, EventArgs e)
        {
          
            button3.Visible = false;
            button4.Visible = false;
            label15.Visible = false;

            session_load();
            LoadData();



        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            int lsessionID = 0;
            lsessionID = int.Parse(loadSessioncomboBox.Text);
            String startTime = startTimecomboBox.Text;
            String endTime = endTimecomboBox.Text;
           
           

            if (ValidateChildren(ValidationConstraints.Enabled) &&
                loadSessioncomboBox.Text == "" || comboBox3.Text == "" || startTime=="" || endTime=="" || lsessionID==0)
            {
                MessageBox.Show("Please fill the Empty Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {



                string insertTag = "insert into Availability (Day,Froms,Tos,sessionID) values('" + comboBox3.Text + "','" + startTime + "','" + endTime + "','" + lsessionID +  "')";
                ExecuteQuery(insertTag);

                ClearDetails();
                LoadData();


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            labelLec.Visible = true;
            label15.Visible = false;

           

            String deleteQuery = "delete from Availability where AvailabilityID='" + this.AvailabilityIDs + "'";
            ExecuteQuery(deleteQuery);
            MessageBox.Show("Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearDetails();
            LoadData();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            labelLec.Visible = true;
            label15.Visible = false;

            ClearDetails();

        }

        private void ClearDetails()
        {
           
            loadSessioncomboBox.SelectedItem = null;
            comboBox3.SelectedItem = null;
            startTimecomboBox.SelectedItem = null;
            endTimecomboBox.SelectedItem = null;
            sessionDetailslabel.Text = "";
        }


       

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(loadSessioncomboBox.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(loadSessioncomboBox, "Please Enter Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(loadSessioncomboBox, null);
            }
        }

        private void comboBox3_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox3.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox3, "Please Enter Day");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox3, null);
            }
        }




































































































































































        //Room availability


        //load room avilability data on  table
        private void RoomAvailablityLoad()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select r.id,r.RoomName,r.StartTime,r.EndTime,r.Day from RoomAvailability r"; /*,Location l where r.BuildingID=l.BuildingID*/
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            roomAvailabilityTable.DataSource = DT;
            sql_con.Close();
        }

        //load room data from db to combobox
        private void roomData_Fill_Combobox()
        {

                    String getBuildings = "select * from Rooms";
                    sql_con.Open();
                    SQLiteCommand command = new SQLiteCommand(getBuildings, sql_con);

                    SQLiteDataReader reader = command.ExecuteReader();


                    while (reader.Read())
                    {
                        string roomName = reader.GetString(1);

                        roomSelectComboBox.Items.Add(roomName);
                    }
        }

      

        //clear text field data
        private void clearData()
        {

            combo_startTime.SelectedItem = null;
            combo_endTime.SelectedItem = null;
            roomSelectComboBox.SelectedItem = null;
            daycomboBox.SelectedItem = null;

        }

        private void detailsAddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                String startTime = combo_startTime.Text;
                String endTime = combo_endTime.Text;
                String roomName = roomSelectComboBox.Text;
                String day = daycomboBox.Text;

                if (ValidateChildren(ValidationConstraints.Enabled) &&
                roomName == "" || startTime == "" || endTime == ""
                 )
                {
                    MessageBox.Show("Complete All The Fields!",
                   "Unable to Submit", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation,
                                   MessageBoxDefaultButton.Button1);
                }
                else
                {
                    string insertUnRoom = "insert into RoomAvailability (RoomName,StartTime,EndTime,day)values('" + roomName + "','" + startTime + "','"
                  + endTime + "', '"+day+"')";
                    ExecuteQuery(insertUnRoom);
                    RoomAvailablityLoad();
                    MessageBox.Show("Room Availability Information added successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception)
            {
                MessageBox.Show("Error", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clearData();
        }

        private void roomAvailabilityTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomID = Convert.ToInt32(roomAvailabilityTable.SelectedRows[0].Cells[0].Value);
            roomSelectComboBox.Text = roomAvailabilityTable.SelectedRows[0].Cells[1].Value.ToString();
            combo_startTime.Text = roomAvailabilityTable.SelectedRows[0].Cells[2].Value.ToString();
            combo_endTime.Text = roomAvailabilityTable.SelectedRows[0].Cells[3].Value.ToString();
            daycomboBox.Text= roomAvailabilityTable.SelectedRows[0].Cells[4].Value.ToString();

            detailsAddBtn.Enabled = false;
        }

        private void detailsEditBtn_Click(object sender, EventArgs e)
        {
            if (roomID > 0)
            {


                String startTime = combo_startTime.Text;
                String endTime = combo_endTime.Text;
                String roomName = roomSelectComboBox.Text;
                String day = daycomboBox.Text;

                if (ValidateChildren(ValidationConstraints.Enabled) &&
                roomName == "" || startTime == "" || endTime == "" || day==""
                 )
                {
                    MessageBox.Show("Complete All The Fields!",
                   "Unable to Submit", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation,
                                   MessageBoxDefaultButton.Button1);
                }
                else
                {
                    String updateQuery = "update RoomAvailability set RoomName='" + roomName + "', " +
                                       "StartTime='" + startTime + "',EndTime='" + endTime + "' ,Day='"+day+"'"  + 
                                  "where id='" + this.roomID + "'";
                    ExecuteQuery(updateQuery);
                    MessageBox.Show("Room Availability Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RoomAvailablityLoad();
                    detailsAddBtn.Enabled = true;
                }


            }
            else
            {
                MessageBox.Show("Please select a value to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearData();
        }

        private void detailDeleteBtn_Click(object sender, EventArgs e)
        {
            if (roomID > 0)
            {

                String deleteQuery = "delete from RoomAvailability where id='" + this.roomID + "'";
                ExecuteQuery(deleteQuery);
                MessageBox.Show("Room Availability Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RoomAvailablityLoad();
                detailsAddBtn.Enabled = true;

            }
            else
            {
                MessageBox.Show("Please select a value to delete ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearData();
        }

        private void clearDetailsBtn_Click(object sender, EventArgs e)
        {
            clearData();
            detailsAddBtn.Enabled = true;
        }

        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[0])
            {
                LoadData();
                loadSessioncomboBox.Items.Clear();
                session_load();
                sessionDetailslabel.Text = "";
            }
            else
           if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[1])
            {
                RoomAvailablityLoad();
                roomSelectComboBox.Items.Clear();
                roomData_Fill_Combobox();
                daycomboBox.SelectedItem = null;

            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }


        private void session_load()
        {
            //SetConnection();
            //sql_con.Open();
            //sql_cmd = sql_con.CreateCommand();
            //sql_cmd.CommandType = CommandType.Text;
            //sql_cmd.CommandText = "SELECT SessionID FROM Session";
            //sql_cmd.ExecuteNonQuery();
            //DataTable dt = new DataTable();
            //SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
            //da.Fill(dt);

            //foreach (DataRow dr in dt.Rows)
            //{
            //   loadSessioncomboBox.Items.Add(dr["SessionID"].ToString());
            //}
            //sql_con.Close();


            try
            {
                SetConnection();
                String sessiodIDs = "select SessionID FROM Session";
                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(sessiodIDs, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    int sids = reader.GetInt32(0);

                    loadSessioncomboBox.Items.Add(sids);
                }
            }
            catch (Exception e)
            {
                Console.Write(e + "no work");
            }

        }

        private void loadSessioncomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           


            try
            {
                int lsessionID = 0;
                string sid = loadSessioncomboBox.Text;
                lsessionID = int.Parse(sid);

                SetConnection();
                String lectureDet = "select Lecturer,Subject,Tag,GroupID,SessionID  from Session where SessionID='" + lsessionID + "'";

                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(lectureDet, sql_con);
                SQLiteDataReader reader = command.ExecuteReader();



                while (reader.Read())
                {
                    lLecturer = reader.GetString(0);
                    lSubject = reader.GetString(1);
                    lTag = reader.GetString(2);
                    lGroupID = reader.GetString(3);
                    lsessionID = reader.GetInt32(4);



                    sessionDetailslabel.Text = lLecturer + "\n" + lSubject + "\n" + lTag + "\n" + lGroupID + "\nSession ID " + lsessionID;
                }

                sql_con.Close();
                lsessionID = 0;

            }
            catch (Exception)
            {
                Console.Write("no work");

            }
        }

       
    }
}
