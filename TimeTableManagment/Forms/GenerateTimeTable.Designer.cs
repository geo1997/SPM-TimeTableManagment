namespace TimeTableManagment.Forms
{
    partial class GenerateTimeTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateTimeTable));
            this.label1 = new System.Windows.Forms.Label();
            this.LecturerradioButton = new System.Windows.Forms.RadioButton();
            this.StudentGroupradioButton = new System.Windows.Forms.RadioButton();
            this.RoomradioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LecturerNamecomboBox1 = new System.Windows.Forms.ComboBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgramcomboBox = new System.Windows.Forms.ComboBox();
            this.AcademicYearcomboBox = new System.Windows.Forms.ComboBox();
            this.AcademicSemcomboBox = new System.Windows.Forms.ComboBox();
            this.roomNumcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupIDcomboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Option To Generate TIme Table";
            // 
            // LecturerradioButton
            // 
            this.LecturerradioButton.AutoSize = true;
            this.LecturerradioButton.Location = new System.Drawing.Point(43, 134);
            this.LecturerradioButton.Name = "LecturerradioButton";
            this.LecturerradioButton.Size = new System.Drawing.Size(182, 21);
            this.LecturerradioButton.TabIndex = 1;
            this.LecturerradioButton.Text = "For a partciular Lecturer";
            this.LecturerradioButton.UseVisualStyleBackColor = true;
            this.LecturerradioButton.CheckedChanged += new System.EventHandler(this.LecturerradioButton_CheckedChanged);
            // 
            // StudentGroupradioButton
            // 
            this.StudentGroupradioButton.AutoSize = true;
            this.StudentGroupradioButton.Location = new System.Drawing.Point(579, 134);
            this.StudentGroupradioButton.Name = "StudentGroupradioButton";
            this.StudentGroupradioButton.Size = new System.Drawing.Size(222, 21);
            this.StudentGroupradioButton.TabIndex = 2;
            this.StudentGroupradioButton.Text = "For a partciular Student Group";
            this.StudentGroupradioButton.UseVisualStyleBackColor = true;
            this.StudentGroupradioButton.CheckedChanged += new System.EventHandler(this.StudentGroupradioButton_CheckedChanged);
            // 
            // RoomradioButton
            // 
            this.RoomradioButton.AutoSize = true;
            this.RoomradioButton.Location = new System.Drawing.Point(324, 134);
            this.RoomradioButton.Name = "RoomradioButton";
            this.RoomradioButton.Size = new System.Drawing.Size(166, 21);
            this.RoomradioButton.TabIndex = 3;
            this.RoomradioButton.Text = "For a partciular Room";
            this.RoomradioButton.UseVisualStyleBackColor = true;
            this.RoomradioButton.CheckedChanged += new System.EventHandler(this.RoomradioButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Lecturer Name";
            // 
            // LecturerNamecomboBox1
            // 
            this.LecturerNamecomboBox1.FormattingEnabled = true;
            this.LecturerNamecomboBox1.Location = new System.Drawing.Point(43, 205);
            this.LecturerNamecomboBox1.Name = "LecturerNamecomboBox1";
            this.LecturerNamecomboBox1.Size = new System.Drawing.Size(193, 24);
            this.LecturerNamecomboBox1.TabIndex = 5;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button10.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button10.Image = global::TimeTableManagment.Properties.Resources.icons8_ok_1;
            this.button10.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button10.Location = new System.Drawing.Point(43, 403);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(130, 41);
            this.button10.TabIndex = 81;
            this.button10.Text = "Generate";
            this.button10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.SteelBlue;
            this.button11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Image = ((System.Drawing.Image)(resources.GetObject("button11.Image")));
            this.button11.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button11.Location = new System.Drawing.Point(244, 403);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(130, 41);
            this.button11.TabIndex = 82;
            this.button11.Text = "Clear Fields";
            this.button11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(576, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 83;
            this.label3.Text = "Select Program";
            // 
            // ProgramcomboBox
            // 
            this.ProgramcomboBox.FormattingEnabled = true;
            this.ProgramcomboBox.Items.AddRange(new object[] {
            "IT"});
            this.ProgramcomboBox.Location = new System.Drawing.Point(579, 214);
            this.ProgramcomboBox.Name = "ProgramcomboBox";
            this.ProgramcomboBox.Size = new System.Drawing.Size(193, 24);
            this.ProgramcomboBox.TabIndex = 84;
            // 
            // AcademicYearcomboBox
            // 
            this.AcademicYearcomboBox.FormattingEnabled = true;
            this.AcademicYearcomboBox.Items.AddRange(new object[] {
            "Y1",
            "Y2",
            "Y3",
            "Y4"});
            this.AcademicYearcomboBox.Location = new System.Drawing.Point(579, 278);
            this.AcademicYearcomboBox.Name = "AcademicYearcomboBox";
            this.AcademicYearcomboBox.Size = new System.Drawing.Size(193, 24);
            this.AcademicYearcomboBox.TabIndex = 85;
            this.AcademicYearcomboBox.SelectedIndexChanged += new System.EventHandler(this.AcademicYearcomboBox_SelectedIndexChanged);
            // 
            // AcademicSemcomboBox
            // 
            this.AcademicSemcomboBox.FormattingEnabled = true;
            this.AcademicSemcomboBox.Items.AddRange(new object[] {
            "S1",
            "S2"});
            this.AcademicSemcomboBox.Location = new System.Drawing.Point(579, 332);
            this.AcademicSemcomboBox.Name = "AcademicSemcomboBox";
            this.AcademicSemcomboBox.Size = new System.Drawing.Size(193, 24);
            this.AcademicSemcomboBox.TabIndex = 86;
            this.AcademicSemcomboBox.SelectedIndexChanged += new System.EventHandler(this.AcademicSemcomboBox_SelectedIndexChanged);
            // 
            // roomNumcomboBox
            // 
            this.roomNumcomboBox.FormattingEnabled = true;
            this.roomNumcomboBox.Location = new System.Drawing.Point(324, 214);
            this.roomNumcomboBox.Name = "roomNumcomboBox";
            this.roomNumcomboBox.Size = new System.Drawing.Size(193, 24);
            this.roomNumcomboBox.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(576, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 89;
            this.label5.Text = "Select Academic Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(576, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Select Academic Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 91;
            this.label7.Text = "Select Room No";
            // 
            // button1
            // 
            this.button1.Image = global::TimeTableManagment.Properties.Resources.icons8_macos_close_32;
            this.button1.Location = new System.Drawing.Point(749, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 92;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(576, 383);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 94;
            this.label4.Text = "Select Group ID";
            // 
            // GroupIDcomboBox
            // 
            this.GroupIDcomboBox.FormattingEnabled = true;
            this.GroupIDcomboBox.Location = new System.Drawing.Point(579, 403);
            this.GroupIDcomboBox.Name = "GroupIDcomboBox";
            this.GroupIDcomboBox.Size = new System.Drawing.Size(193, 24);
            this.GroupIDcomboBox.TabIndex = 93;
            // 
            // GenerateTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(824, 565);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.GroupIDcomboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomNumcomboBox);
            this.Controls.Add(this.AcademicSemcomboBox);
            this.Controls.Add(this.AcademicYearcomboBox);
            this.Controls.Add(this.ProgramcomboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.LecturerNamecomboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RoomradioButton);
            this.Controls.Add(this.StudentGroupradioButton);
            this.Controls.Add(this.LecturerradioButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateTimeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateTimeTable";
            this.Load += new System.EventHandler(this.GenerateTimeTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton LecturerradioButton;
        private System.Windows.Forms.RadioButton StudentGroupradioButton;
        private System.Windows.Forms.RadioButton RoomradioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LecturerNamecomboBox1;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProgramcomboBox;
        private System.Windows.Forms.ComboBox AcademicYearcomboBox;
        private System.Windows.Forms.ComboBox AcademicSemcomboBox;
        private System.Windows.Forms.ComboBox roomNumcomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox GroupIDcomboBox;
    }
}