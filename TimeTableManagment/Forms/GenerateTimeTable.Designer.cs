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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.LecturerradioButton = new System.Windows.Forms.RadioButton();
            this.StudentGroupradioButton = new System.Windows.Forms.RadioButton();
            this.RoomradioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.LecturerNamecomboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ProgramcomboBox = new System.Windows.Forms.ComboBox();
            this.AcademicYearcomboBox = new System.Windows.Forms.ComboBox();
            this.AcademicSemcomboBox = new System.Windows.Forms.ComboBox();
            this.roomNumcomboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.GroupIDcomboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.weekDayradioButton = new System.Windows.Forms.RadioButton();
            this.weekEndradioButton = new System.Windows.Forms.RadioButton();
            this.closeTabbutton1 = new System.Windows.Forms.Button();
            this.clearFieldsbutton = new System.Windows.Forms.Button();
            this.generateTimeTblebutton = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dataGridView7 = new System.Windows.Forms.DataGridView();
            this.printTimebutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(349, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Option To Generate TIme Table";
            // 
            // LecturerradioButton
            // 
            this.LecturerradioButton.AutoSize = true;
            this.LecturerradioButton.Location = new System.Drawing.Point(80, 35);
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
            this.StudentGroupradioButton.Location = new System.Drawing.Point(616, 35);
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
            this.RoomradioButton.Location = new System.Drawing.Point(361, 35);
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
            this.label2.Location = new System.Drawing.Point(77, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select Lecturer Name";
            // 
            // LecturerNamecomboBox1
            // 
            this.LecturerNamecomboBox1.FormattingEnabled = true;
            this.LecturerNamecomboBox1.Location = new System.Drawing.Point(80, 106);
            this.LecturerNamecomboBox1.Name = "LecturerNamecomboBox1";
            this.LecturerNamecomboBox1.Size = new System.Drawing.Size(193, 24);
            this.LecturerNamecomboBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(613, 86);
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
            this.ProgramcomboBox.Location = new System.Drawing.Point(616, 115);
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
            this.AcademicYearcomboBox.Location = new System.Drawing.Point(616, 179);
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
            this.AcademicSemcomboBox.Location = new System.Drawing.Point(616, 233);
            this.AcademicSemcomboBox.Name = "AcademicSemcomboBox";
            this.AcademicSemcomboBox.Size = new System.Drawing.Size(193, 24);
            this.AcademicSemcomboBox.TabIndex = 86;
            this.AcademicSemcomboBox.SelectedIndexChanged += new System.EventHandler(this.AcademicSemcomboBox_SelectedIndexChanged);
            // 
            // roomNumcomboBox
            // 
            this.roomNumcomboBox.FormattingEnabled = true;
            this.roomNumcomboBox.Location = new System.Drawing.Point(361, 115);
            this.roomNumcomboBox.Name = "roomNumcomboBox";
            this.roomNumcomboBox.Size = new System.Drawing.Size(193, 24);
            this.roomNumcomboBox.TabIndex = 87;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(613, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 17);
            this.label5.TabIndex = 89;
            this.label5.Text = "Select Academic Year";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(613, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 17);
            this.label6.TabIndex = 90;
            this.label6.Text = "Select Academic Semester";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(358, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 91;
            this.label7.Text = "Select Room No";
            // 
            // GroupIDcomboBox
            // 
            this.GroupIDcomboBox.FormattingEnabled = true;
            this.GroupIDcomboBox.Location = new System.Drawing.Point(616, 304);
            this.GroupIDcomboBox.Name = "GroupIDcomboBox";
            this.GroupIDcomboBox.Size = new System.Drawing.Size(193, 24);
            this.GroupIDcomboBox.TabIndex = 93;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(613, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 17);
            this.label4.TabIndex = 94;
            this.label4.Text = "Select Group ID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.LecturerradioButton);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.StudentGroupradioButton);
            this.groupBox1.Controls.Add(this.GroupIDcomboBox);
            this.groupBox1.Controls.Add(this.RoomradioButton);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.LecturerNamecomboBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ProgramcomboBox);
            this.groupBox1.Controls.Add(this.roomNumcomboBox);
            this.groupBox1.Controls.Add(this.AcademicYearcomboBox);
            this.groupBox1.Controls.Add(this.AcademicSemcomboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(960, 361);
            this.groupBox1.TabIndex = 95;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select An Option";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.weekDayradioButton);
            this.groupBox2.Controls.Add(this.weekEndradioButton);
            this.groupBox2.Location = new System.Drawing.Point(80, 228);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 100);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select Type";
            // 
            // weekDayradioButton
            // 
            this.weekDayradioButton.AutoSize = true;
            this.weekDayradioButton.Location = new System.Drawing.Point(7, 41);
            this.weekDayradioButton.Name = "weekDayradioButton";
            this.weekDayradioButton.Size = new System.Drawing.Size(88, 21);
            this.weekDayradioButton.TabIndex = 95;
            this.weekDayradioButton.TabStop = true;
            this.weekDayradioButton.Text = "Weekday";
            this.weekDayradioButton.UseVisualStyleBackColor = true;
            // 
            // weekEndradioButton
            // 
            this.weekEndradioButton.AutoSize = true;
            this.weekEndradioButton.Location = new System.Drawing.Point(167, 41);
            this.weekEndradioButton.Name = "weekEndradioButton";
            this.weekEndradioButton.Size = new System.Drawing.Size(89, 21);
            this.weekEndradioButton.TabIndex = 96;
            this.weekEndradioButton.TabStop = true;
            this.weekEndradioButton.Text = "Weekend";
            this.weekEndradioButton.UseVisualStyleBackColor = true;
            // 
            // closeTabbutton1
            // 
            this.closeTabbutton1.Image = global::TimeTableManagment.Properties.Resources.icons8_macos_close_32;
            this.closeTabbutton1.Location = new System.Drawing.Point(910, 0);
            this.closeTabbutton1.Name = "closeTabbutton1";
            this.closeTabbutton1.Size = new System.Drawing.Size(75, 35);
            this.closeTabbutton1.TabIndex = 92;
            this.closeTabbutton1.UseVisualStyleBackColor = true;
            this.closeTabbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearFieldsbutton
            // 
            this.clearFieldsbutton.BackColor = System.Drawing.Color.SteelBlue;
            this.clearFieldsbutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold);
            this.clearFieldsbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clearFieldsbutton.Image = ((System.Drawing.Image)(resources.GetObject("clearFieldsbutton.Image")));
            this.clearFieldsbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearFieldsbutton.Location = new System.Drawing.Point(242, 539);
            this.clearFieldsbutton.Name = "clearFieldsbutton";
            this.clearFieldsbutton.Size = new System.Drawing.Size(130, 41);
            this.clearFieldsbutton.TabIndex = 82;
            this.clearFieldsbutton.Text = "Clear Fields";
            this.clearFieldsbutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearFieldsbutton.UseVisualStyleBackColor = false;
            // 
            // generateTimeTblebutton
            // 
            this.generateTimeTblebutton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.generateTimeTblebutton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.generateTimeTblebutton.Image = global::TimeTableManagment.Properties.Resources.icons8_ok_1;
            this.generateTimeTblebutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.generateTimeTblebutton.Location = new System.Drawing.Point(43, 539);
            this.generateTimeTblebutton.Name = "generateTimeTblebutton";
            this.generateTimeTblebutton.Size = new System.Drawing.Size(130, 41);
            this.generateTimeTblebutton.TabIndex = 81;
            this.generateTimeTblebutton.Text = "Generate";
            this.generateTimeTblebutton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.generateTimeTblebutton.UseVisualStyleBackColor = false;
            this.generateTimeTblebutton.Click += new System.EventHandler(this.generateTimeTblebutton_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dataGridView7);
            this.panel7.Location = new System.Drawing.Point(18, 12);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(886, 622);
            this.panel7.TabIndex = 118;
            // 
            // dataGridView7
            // 
            this.dataGridView7.AllowUserToAddRows = false;
            this.dataGridView7.AllowUserToDeleteRows = false;
            this.dataGridView7.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView7.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView7.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView7.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView7.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView7.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView7.Location = new System.Drawing.Point(3, 3);
            this.dataGridView7.Name = "dataGridView7";
            this.dataGridView7.ReadOnly = true;
            this.dataGridView7.RowHeadersVisible = false;
            this.dataGridView7.RowHeadersWidth = 51;
            this.dataGridView7.RowTemplate.Height = 24;
            this.dataGridView7.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView7.Size = new System.Drawing.Size(883, 616);
            this.dataGridView7.TabIndex = 6;
            // 
            // printTimebutton
            // 
            this.printTimebutton.Location = new System.Drawing.Point(774, 641);
            this.printTimebutton.Name = "printTimebutton";
            this.printTimebutton.Size = new System.Drawing.Size(75, 23);
            this.printTimebutton.TabIndex = 119;
            this.printTimebutton.Text = "Print";
            this.printTimebutton.UseVisualStyleBackColor = true;
            this.printTimebutton.Click += new System.EventHandler(this.printTimebutton_Click);
            // 
            // GenerateTimeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 675);
            this.Controls.Add(this.printTimebutton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.closeTabbutton1);
            this.Controls.Add(this.clearFieldsbutton);
            this.Controls.Add(this.generateTimeTblebutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateTimeTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateTimeTable";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.GenerateTimeTable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button closeTabbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton LecturerradioButton;
        private System.Windows.Forms.RadioButton StudentGroupradioButton;
        private System.Windows.Forms.RadioButton RoomradioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox LecturerNamecomboBox1;
        private System.Windows.Forms.Button generateTimeTblebutton;
        private System.Windows.Forms.Button clearFieldsbutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ProgramcomboBox;
        private System.Windows.Forms.ComboBox AcademicYearcomboBox;
        private System.Windows.Forms.ComboBox AcademicSemcomboBox;
        private System.Windows.Forms.ComboBox roomNumcomboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox GroupIDcomboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView dataGridView7;
        private System.Windows.Forms.Button printTimebutton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton weekDayradioButton;
        private System.Windows.Forms.RadioButton weekEndradioButton;
    }
}