namespace TimeTableManagment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sideMenuPanel = new System.Windows.Forms.Panel();
            this.titleBarPanel = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDekstopPane = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnWorkingDays = new System.Windows.Forms.Button();
            this.sideMenuPanel.SuspendLayout();
            this.titleBarPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideMenuPanel
            // 
            this.sideMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.sideMenuPanel.Controls.Add(this.button10);
            this.sideMenuPanel.Controls.Add(this.button9);
            this.sideMenuPanel.Controls.Add(this.button8);
            this.sideMenuPanel.Controls.Add(this.button7);
            this.sideMenuPanel.Controls.Add(this.button6);
            this.sideMenuPanel.Controls.Add(this.button5);
            this.sideMenuPanel.Controls.Add(this.button4);
            this.sideMenuPanel.Controls.Add(this.button3);
            this.sideMenuPanel.Controls.Add(this.button2);
            this.sideMenuPanel.Controls.Add(this.button1);
            this.sideMenuPanel.Controls.Add(this.btnWorkingDays);
            this.sideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.sideMenuPanel.Name = "sideMenuPanel";
            this.sideMenuPanel.Size = new System.Drawing.Size(220, 673);
            this.sideMenuPanel.TabIndex = 0;
            // 
            // titleBarPanel
            // 
            this.titleBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.titleBarPanel.Controls.Add(this.btnClose);
            this.titleBarPanel.Controls.Add(this.lblTitle);
            this.titleBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBarPanel.Location = new System.Drawing.Point(220, 0);
            this.titleBarPanel.Name = "titleBarPanel";
            this.titleBarPanel.Size = new System.Drawing.Size(875, 80);
            this.titleBarPanel.TabIndex = 1;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Engravers MT", 15F);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(385, 31);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(111, 29);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "HOME";
            // 
            // panelDekstopPane
            // 
            this.panelDekstopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDekstopPane.Location = new System.Drawing.Point(220, 80);
            this.panelDekstopPane.Name = "panelDekstopPane";
            this.panelDekstopPane.Size = new System.Drawing.Size(875, 593);
            this.panelDekstopPane.TabIndex = 2;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::TimeTableManagment.Properties.Resources.icons8_macos_close_32;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 80);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnCloseChildForm_click);
            // 
            // button10
            // 
            this.button10.Dock = System.Windows.Forms.DockStyle.Top;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.ForeColor = System.Drawing.Color.Gainsboro;
            this.button10.Image = global::TimeTableManagment.Properties.Resources.icons8_statistics_32;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(0, 600);
            this.button10.Name = "button10";
            this.button10.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button10.Size = new System.Drawing.Size(220, 60);
            this.button10.TabIndex = 11;
            this.button10.Text = "  Statistics";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.statistics_click);
            // 
            // button9
            // 
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.ForeColor = System.Drawing.Color.Gainsboro;
            this.button9.Image = global::TimeTableManagment.Properties.Resources.icons8_room_32;
            this.button9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.Location = new System.Drawing.Point(0, 540);
            this.button9.Name = "button9";
            this.button9.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button9.Size = new System.Drawing.Size(220, 60);
            this.button9.TabIndex = 10;
            this.button9.Text = "  Room";
            this.button9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button9.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.room_click);
            // 
            // button8
            // 
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.ForeColor = System.Drawing.Color.Gainsboro;
            this.button8.Image = global::TimeTableManagment.Properties.Resources.icons8_available_updates_32;
            this.button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.Location = new System.Drawing.Point(0, 480);
            this.button8.Name = "button8";
            this.button8.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button8.Size = new System.Drawing.Size(220, 60);
            this.button8.TabIndex = 9;
            this.button8.Text = "  Availability";
            this.button8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button8.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.availability_click);
            // 
            // button7
            // 
            this.button7.Dock = System.Windows.Forms.DockStyle.Top;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.ForeColor = System.Drawing.Color.Gainsboro;
            this.button7.Image = global::TimeTableManagment.Properties.Resources.icons8_more_details_32;
            this.button7.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.Location = new System.Drawing.Point(0, 420);
            this.button7.Name = "button7";
            this.button7.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button7.Size = new System.Drawing.Size(220, 60);
            this.button7.TabIndex = 8;
            this.button7.Text = "  Session";
            this.button7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.session_click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.Gainsboro;
            this.button6.Image = global::TimeTableManagment.Properties.Resources.icons8_marker_32;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(0, 360);
            this.button6.Name = "button6";
            this.button6.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button6.Size = new System.Drawing.Size(220, 60);
            this.button6.TabIndex = 7;
            this.button6.Text = "  Location";
            this.button6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.location_click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.Gainsboro;
            this.button5.Image = global::TimeTableManagment.Properties.Resources.icons8_tag_window_32;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.Location = new System.Drawing.Point(0, 300);
            this.button5.Name = "button5";
            this.button5.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button5.Size = new System.Drawing.Size(220, 60);
            this.button5.TabIndex = 6;
            this.button5.Text = "  Tags";
            this.button5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.tag_click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.Gainsboro;
            this.button4.Image = global::TimeTableManagment.Properties.Resources.icons8_physics_book_32;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 240);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button4.Size = new System.Drawing.Size(220, 60);
            this.button4.TabIndex = 5;
            this.button4.Text = "  Subject";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.subject_click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Image = global::TimeTableManagment.Properties.Resources.icons8_student_male_32;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 180);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(220, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = "  Student";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.student_click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Image = global::TimeTableManagment.Properties.Resources.icons8_teacher_32;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 120);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(220, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = "  Lecturer";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.lectureres_click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Image = global::TimeTableManagment.Properties.Resources.icons8_hourglass_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 60);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(220, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = "  Working Hours";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.workingHours_click);
            // 
            // btnWorkingDays
            // 
            this.btnWorkingDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWorkingDays.FlatAppearance.BorderSize = 0;
            this.btnWorkingDays.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWorkingDays.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWorkingDays.Image = global::TimeTableManagment.Properties.Resources.icons8_day_view_32__2_;
            this.btnWorkingDays.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkingDays.Location = new System.Drawing.Point(0, 0);
            this.btnWorkingDays.Name = "btnWorkingDays";
            this.btnWorkingDays.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnWorkingDays.Size = new System.Drawing.Size(220, 60);
            this.btnWorkingDays.TabIndex = 1;
            this.btnWorkingDays.Text = "  Working Days ";
            this.btnWorkingDays.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWorkingDays.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWorkingDays.UseVisualStyleBackColor = true;
            this.btnWorkingDays.Click += new System.EventHandler(this.workingDays_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 673);
            this.Controls.Add(this.panelDekstopPane);
            this.Controls.Add(this.titleBarPanel);
            this.Controls.Add(this.sideMenuPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.sideMenuPanel.ResumeLayout(false);
            this.titleBarPanel.ResumeLayout(false);
            this.titleBarPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sideMenuPanel;
        private System.Windows.Forms.Button btnWorkingDays;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Panel titleBarPanel;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDekstopPane;
        private System.Windows.Forms.Button btnClose;
    }
}

