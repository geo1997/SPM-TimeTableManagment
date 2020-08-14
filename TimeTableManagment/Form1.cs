using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ActivateButton(sender);
        }

        private void availability_click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void room_click(object sender, EventArgs e)
        {
            ActivateButton(sender);
        }

        private void statistics_click(object sender, EventArgs e)
        {
            ActivateButton(sender);
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
            titleBarPanel.BackColor = Color.FromArgb(0, 150, 136);
            currentButton = null;
            btnClose.Visible = false;
        }
    }
}
