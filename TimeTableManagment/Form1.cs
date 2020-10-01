using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTableManagment.Forms;
using System.Data.SQLite;

namespace TimeTableManagment
{
    public partial class Form1 : Form
    {
        //Fields

        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            btnClose.Visible = false;
        }


        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();


        private void Form1_Load(object sender, EventArgs e)
        {
            LoadRoomData();
        }

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





        private void LoadRoomData()
        {
            try
            {
                SetConnection();
                String getBuildings = "select count(*) from Location";
                String getLes = "select count(*) from Lecturer";




                sql_con.Open();
                SQLiteCommand command = new SQLiteCommand(getBuildings, sql_con);
                SQLiteCommand comman1 = new SQLiteCommand(getLes, sql_con);





                SQLiteDataReader reader = command.ExecuteReader();
                SQLiteDataReader reader1 = comman1.ExecuteReader();







                while (reader.Read())
                {
                    int buildingName = reader.GetInt32(0);

                    lblRoom.Text = buildingName.ToString();
                }

                while (reader1.Read())
                {
                    int lecCount = reader1.GetInt32(0);
                    Lecslbl.Text = lecCount.ToString();
                }

                sql_con.Close();
            }


            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }


        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            while(tempIndex == index)
            {
               index= random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if(currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F);
                    //titleBarPanel.BackColor = color;
                    btnClose.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach(Control previousBtn in sideMenuPanel.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 52, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);

                }
            }
        }

         private void OpenChildForm(Form childForm , object btnSender)
        {
            if(activeForm != null)
            {
                activeForm.Close();
            }

            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDekstopPane.Controls.Add(childForm);
            this.panelDekstopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }


        private void workingDays_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.WorkingDaysForm(), sender);
        }

        private void workingHours_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.WorkingHoursForm(), sender);
        }

        private void lectureres_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LecturerForm(), sender);
        }

        private void student_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StudentForm(), sender);
        }

        private void subject_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SubjectForm(), sender);
        }

        private void tag_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TagForm(), sender);
        }

        private void location_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LocationForm(), sender);
        }

        private void session_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SessionForm(), sender);
        }

        private void availability_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AvailabilityForm(), sender);
        }

        private void room_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.RoomForm(), sender);
        }

        private void statistics_click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.AssignTimeAndDay(), sender);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.StatisticsForm(), sender);
        }


        private void btnCloseChildForm_click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Home";
            titleBarPanel.BackColor = Color.FromArgb(50, 50, 70);
            currentButton = null;
            btnClose.Visible = false;
        }

        private void generate_timetable_Click(object sender, EventArgs e)
        {

            //GenerateTimeTable g = new GenerateTimeTable();
            //g.ShowDialog();

            Form formBackground = new Form();

            try
            {
                using (GenerateTimeTable g = new GenerateTimeTable())
                {
                    formBackground.StartPosition = FormStartPosition.Manual;
                    formBackground.FormBorderStyle = FormBorderStyle.None;
                    formBackground.Opacity = .70d;
                    formBackground.BackColor = Color.Black;
                    formBackground.WindowState = FormWindowState.Maximized;
                    formBackground.TopMost = true;
                    formBackground.Location = this.Location;
                    formBackground.ShowInTaskbar = false;
                    formBackground.Show();

                    g.Owner = formBackground;
                    g.ShowDialog();
                    formBackground.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                formBackground.Dispose();
            }



        }

        private void AssignDayandTimebutton_Click(object sender, EventArgs e)
        {
           
        }

       
    }
}
