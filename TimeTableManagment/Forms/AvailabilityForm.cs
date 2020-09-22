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
    public partial class AvailabilityForm : Form
    {
        public AvailabilityForm()
        {
            InitializeComponent();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();
        private int AvailabilityIDs = 0;
        private int roomID = 0;

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
            string queryText = "select * from Availability ";
            DB = new SQLiteDataAdapter(queryText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dataGridView1.DataSource = DT;
            sql_con.Close();
            }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Lecturer")
            {
                comboBox2.Items.Clear();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandType = CommandType.Text;
                sql_cmd.CommandText = "SELECT GroupID FROM Student";
                sql_cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox2.Items.Add(dr["GroupID"].ToString());
                }
                sql_con.Close();
            }

            else if (comboBox1.Text == "Session")
            {
                comboBox2.Items.Clear();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandType = CommandType.Text;
                sql_cmd.CommandText = "SELECT SubGroupID FROM Student";
                sql_cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox2.Items.Add(dr["SubGroupID"].ToString());
                }
                sql_con.Close();
            }

            else if (comboBox1.Text == "Lecturer")
            {
                comboBox2.Items.Clear();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandType = CommandType.Text;
                sql_cmd.CommandText = "SELECT GroupID FROM Student";
                sql_cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox2.Items.Add(dr["GroupID"].ToString());
                }
                sql_con.Close();
            }

            else if (comboBox1.Text == "Lecturer")
            {
                comboBox2.Items.Clear();
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
                sql_cmd.CommandType = CommandType.Text;
                sql_cmd.CommandText = "SELECT GroupID FROM Student";
                sql_cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SQLiteDataAdapter da = new SQLiteDataAdapter(sql_cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    comboBox2.Items.Add(dr["GroupID"].ToString());
                }
                sql_con.Close();
            }
        }

        public void fillCombo(ComboBox combo,string query,string displayMember,string valueMember) {
            sql_cmd = new SQLiteCommand(query, sql_con);
            DB = new SQLiteDataAdapter(sql_cmd);
            DT = new DataTable();
            DB.Fill(DT);
            combo.DataSource = DT;
            combo.DisplayMember = displayMember;
            combo.ValueMember = valueMember;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "hh:mm";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            button3.Visible = true;
            button1.Visible = false;
            button4.Visible = true;
            label15.Visible = true;
            labelLec.Visible = false;

            AvailabilityIDs = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            comboBox3.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            dateTimePicker2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

    }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();

            if (AvailabilityIDs > 0)
            {
                button1.Visible = true;
                button3.Visible = false;
                button4.Visible = false;
                labelLec.Visible = true;
                label15.Visible = false;

                String updateQuery = "update Availability set Type='" + comboBox1.Text + "',Name='" + comboBox2.Text + "',Day='" + comboBox3.Text + "',Froms='" + dateTimePicker1.Text + "',Tos='" + dateTimePicker2.Text + "'" +
               "where AvailabilityID='" + this.AvailabilityIDs + "'";
                ExecuteQuery(updateQuery);
                MessageBox.Show("Information updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select to update ", "Select", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void AvailabilityForm_Load(object sender, EventArgs e)
        {
            LoadData();
            button3.Visible = false;
            button4.Visible = false;
            label15.Visible = false;

            RoomAvailablityLoad();
            roomData_Fill_Combobox();

          

        }

        private void dateTimePicker1_MouseDown(object sender, MouseEventArgs e)
        {
            dateTimePicker1.CustomFormat = "hh:mm";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled) &&
                comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Please fill the Empty Field(s)",
                "Unable to Submit", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation,
                                MessageBoxDefaultButton.Button1);
            }
            else
            {
                comboBox1.ResetText();
                comboBox2.ResetText();
                comboBox3.ResetText();
                dateTimePicker1.ResetText();
                dateTimePicker2.ResetText();

                string insertTag = "insert into Availability (Type,Name,Day,Froms,Tos) values('" + comboBox1.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
                ExecuteQuery(insertTag);
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

            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();

            String deleteQuery = "delete from Availability where AvailabilityID='" + this.AvailabilityIDs + "'";
            ExecuteQuery(deleteQuery);
            MessageBox.Show("Information deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();

        }


        private void button2_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            button3.Visible = false;
            button4.Visible = false;
            labelLec.Visible = true;
            label15.Visible = false;

            comboBox1.ResetText();
            comboBox2.ResetText();
            comboBox3.ResetText();
            dateTimePicker1.ResetText();
            dateTimePicker2.ResetText();

        }

        private void comboBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox1.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox1, "Please Enter Type");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox1, null);
            }
        }

        private void comboBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox2.Text))
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox2, "Please Enter Name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(comboBox2, null);
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
            string queryText = "select r.id,r.RoomName,r.StartTime,r.EndTime from RoomAvailability r"; /*,Location l where r.BuildingID=l.BuildingID*/
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

        }

        private void detailsAddBtn_Click(object sender, EventArgs e)
        {
            try
            {

                String startTime = combo_startTime.Text;
                String endTime = combo_endTime.Text;
                String roomName = roomSelectComboBox.Text;

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
                    string insertUnRoom = "insert into RoomAvailability (RoomName,StartTime,EndTime)values('" + roomName + "','" + startTime + "','"
                  + endTime + "')";
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

            detailsAddBtn.Enabled = false;
        }

        private void detailsEditBtn_Click(object sender, EventArgs e)
        {
            if (roomID > 0)
            {


                String startTime = combo_startTime.Text;
                String endTime = combo_endTime.Text;
                String roomName = roomSelectComboBox.Text;

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
                    String updateQuery = "update RoomAvailability set RoomName='" + roomName + "', " +
                                       "StartTime='" + startTime + "',EndTime='" + endTime + "'" +
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
    }
}
