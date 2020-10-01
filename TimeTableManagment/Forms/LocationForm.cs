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
using System.Data.SqlClient;

namespace TimeTableManagment.Forms
{
    public partial class LocationForm : Form
    {
        public LocationForm()
        {
            InitializeComponent();
            
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private int buildingID =0;
        private int roomID = 0;
     
        //When form loads execute
        private void Location_Load(object sender, EventArgs e)
        {

               LoadData();//loads the room details


        }


        //set connection
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

        /*
         **BUILDING TAB****
         */

        //load building data
        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select * from Location ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();



        }

       //insert building data to db
        private void buildingAddBtn_Click(object sender, EventArgs e)
        {
            String bName = buildingNameTxtBx.Text;

            if (ValidateChildren(ValidationConstraints.Enabled) &&
             bName == "" 
              )
            {
                MessageBox.Show("Complete The Field!",
               "Unable to Submit", MessageBoxButtons.OK,
                               MessageBoxIcon.Exclamation,
                               MessageBoxDefaultButton.Button1);
            }
            else
            {
                string insertLoc = "insert into Location (BuildingName)values('" + buildingNameTxtBx.Text + "')";
                ExecuteQuery(insertLoc);
                LoadData();
                MessageBox.Show("Building Information added successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                buildingNameTxtBx.Clear();

            }

           
        }

        //onlick datagrid view raw fill the textboxes with building details
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
         
            buildingID = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            buildingNameTxtBx.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            buildingAddBtn.Enabled = false;

        }

        //edit building data
        private void buildingEditBtn_Click(object sender, EventArgs e)
        {

            if(buildingID > 0)
            {

                String bName = buildingNameTxtBx.Text;

                if (ValidateChildren(ValidationConstraints.Enabled) &&
                 bName == ""
                  )
                {
                    MessageBox.Show("Complete The Field!",
                   "Unable to Submit", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation,
                                   MessageBoxDefaultButton.Button1);
                }
                else
                {
                    String updateQuery = "update Location set BuildingName='" + buildingNameTxtBx.Text + "'" +
              "where BuildingID='" + this.buildingID + "'";
                    ExecuteQuery(updateQuery);
                    LoadData();
                    MessageBox.Show("Building Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    buildingAddBtn.Enabled = true;
                }

               
            }
            else
            {
                MessageBox.Show("Please select a building to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buildingNameTxtBx.Clear();

        }

        //delete bulding data
        private void buildingDeleteBtn_Click(object sender, EventArgs e)
        {

            if (buildingID > 0)
            {
              
                    String deleteQuery = "delete from Location where BuildingID='" + this.buildingID + "'";
                    ExecuteQuery(deleteQuery);
                    LoadData();
                    MessageBox.Show("Building Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   buildingAddBtn.Enabled = true;



            }
            else
            {
                MessageBox.Show("Please select a building to delete ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            buildingNameTxtBx.Clear();


        }
        private void button1buildingDataClear_Click(object sender, EventArgs e)
        {
            buildingID = 0;
            buildingNameTxtBx.Clear();
            buildingAddBtn.Enabled = true;
        }

        /*
         
         *** ROOM TAB***
         */

        //load room data
        private void RoomLoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string queryText = "select r.id,r.RoomName,r.RoomType,r.RoomCapacity,r.BuildingName from Rooms r"; /*,Location l where r.BuildingID=l.BuildingID*/
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView2.DataSource = DT;
            sql_con.Close();
        }

        //fill the combobox with building names
        private void buildingName_Fill_Combobox()
        {
            try
            {
                String getBuildings = "select * from Location";
                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(getBuildings, sql_con);

                SQLiteDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    string buildingName = reader.GetString(1);
                   
                    buildingNameComboBox.Items.Add(buildingName);
                }
            }
            catch (Exception e)
            {
                Console.Write(e+"no work");
            }
           
        }

      //method to clear data on inputs
        private void clearData()
        {
           
            roomNameTxtBox.Clear();
            roomCapacityTxtBox.Clear();
            buildingNameComboBox.SelectedItem = null;
            roomTypeComboBox.SelectedItem = null;
          
        }

        //add room data
        private void detailsAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                String roomName = roomNameTxtBox.Text;
                String roomType = roomTypeComboBox.Text;
                String roomCap = roomCapacityTxtBox.Text;
                String buildingName = buildingNameComboBox.Text;

                if (ValidateChildren(ValidationConstraints.Enabled) &&
                roomName == "" || roomType == "" || roomCap == "" || buildingName == ""
                 )
                {
                    MessageBox.Show("Complete All The Fields!",
                   "Unable to Submit", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation,
                                   MessageBoxDefaultButton.Button1);
                }
                else
                {
                    string insertRoom = "insert into Rooms (RoomName,RoomType,RoomCapacity,BuildingName)values('" + roomNameTxtBox.Text + "','" + roomTypeComboBox.Text + "','"
                  + int.Parse(roomCapacityTxtBox.Text) + "','" + buildingNameComboBox.Text + "')";
                    ExecuteQuery(insertRoom);
                    RoomLoadData();
                    MessageBox.Show("Room Information added successfully", "Inserted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

              
            }
            catch (Exception )
            {
                MessageBox.Show("Error", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            clearData();
           
        }

        //method to only allow enter digits to room capacity input
        private void roomCapacityTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //depedning on the tab load the required data from db
        private void metroTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[0])
            {
                LoadData();
            }
            else
            if (metroTabControl1.SelectedTab == metroTabControl1.TabPages[1])
            {
                RoomLoadData();
                buildingNameComboBox.Items.Clear();
                buildingName_Fill_Combobox();

         
            }

            
        }

      //edit room data
        private void detailsEditBtn_Click(object sender, EventArgs e)
        {
            if (roomID > 0)
            {
                String roomName = roomNameTxtBox.Text;
                String roomType = roomTypeComboBox.Text;
                String roomCap = roomCapacityTxtBox.Text;
                String buildingName = buildingNameComboBox.Text;

                if (ValidateChildren(ValidationConstraints.Enabled) &&
                roomName == "" || roomType == "" || roomCap == "" || buildingName == ""
                 )
                {
                    MessageBox.Show("Complete All The Fields!",
                   "Unable to Submit", MessageBoxButtons.OK,
                                   MessageBoxIcon.Exclamation,
                                   MessageBoxDefaultButton.Button1);
                }
                else
                {
                    String updateQuery = "update Rooms set RoomName='" + roomNameTxtBox.Text + "', " +
                                       "RoomType='" + roomTypeComboBox.Text + "',RoomCapacity='" + int.Parse(roomCapacityTxtBox.Text) + "',BuildingName='" + buildingNameComboBox.Text + "'" +
                                  "where id='" + this.roomID + "'";
                    ExecuteQuery(updateQuery);
                    MessageBox.Show("Room Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RoomLoadData();
                    detailsAddBtn.Enabled = true;
                }
               
            }
            else
            {
                MessageBox.Show("Please select a Room to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearData();
        }

        //datagridview data to inputs
        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            roomID = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
            roomNameTxtBox.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            this.roomTypeComboBox.Text = dataGridView2.SelectedRows[0].Cells[2].Value.ToString();
            roomCapacityTxtBox.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
            this.buildingNameComboBox.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
          
            detailsAddBtn.Enabled = false;
        }

        private void clearDetailsBtn_Click(object sender, EventArgs e)
        {
            clearData();
            detailsAddBtn.Enabled = true;
        }

        //delete room data
        private void detailDeleteBtn_Click(object sender, EventArgs e)
        {
            if (roomID > 0)
            {
                String deleteQuery = "delete from Rooms where id='" + this.roomID + "'";
                ExecuteQuery(deleteQuery);
                MessageBox.Show("Room Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RoomLoadData();
                detailsAddBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Please select a Room to delete ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            clearData();
        }

       
       

       
    }
}
