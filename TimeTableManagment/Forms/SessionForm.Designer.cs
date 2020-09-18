namespace TimeTableManagment.Forms
{
    partial class SessionForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblDisSes = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.tblSessions = new System.Windows.Forms.DataGridView();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStudentCount = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbSubGroup = new System.Windows.Forms.ComboBox();
            this.cmbGroupId = new System.Windows.Forms.ComboBox();
            this.lblSubGrp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSubCode = new System.Windows.Forms.TextBox();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelDropDown = new System.Windows.Forms.Panel();
            this.txtLecs = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lecNameList = new System.Windows.Forms.CheckedListBox();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cmbTags = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnClr = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSessions)).BeginInit();
            this.panelDropDown.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(444, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Session";
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.cmbTags);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSubmit);
            this.panel1.Controls.Add(this.txtDuration);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtStudentCount);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.cmbSubGroup);
            this.panel1.Controls.Add(this.cmbGroupId);
            this.panel1.Controls.Add(this.lblSubGrp);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtSubCode);
            this.panel1.Controls.Add(this.cmbSubject);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panelDropDown);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-15, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 661);
            this.panel1.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(600, 146);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(308, 34);
            this.label12.TabIndex = 20;
            this.label12.Text = "* If the session is a practical,\r\n maximum number of students must be 60";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.tblSessions);
            this.panel2.Location = new System.Drawing.Point(-19, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1109, 350);
            this.panel2.TabIndex = 19;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(723, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 29);
            this.label14.TabIndex = 3;
            this.label14.Text = "Session Details";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnClr);
            this.panel3.Controls.Add(this.lblDisSes);
            this.panel3.Location = new System.Drawing.Point(645, 70);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(377, 198);
            this.panel3.TabIndex = 2;
            // 
            // lblDisSes
            // 
            this.lblDisSes.AutoSize = true;
            this.lblDisSes.Location = new System.Drawing.Point(15, 12);
            this.lblDisSes.MaximumSize = new System.Drawing.Size(350, 170);
            this.lblDisSes.MinimumSize = new System.Drawing.Size(350, 170);
            this.lblDisSes.Name = "lblDisSes";
            this.lblDisSes.Size = new System.Drawing.Size(350, 170);
            this.lblDisSes.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.Location = new System.Drawing.Point(169, 33);
            this.txtSearch.MaximumSize = new System.Drawing.Size(374, 26);
            this.txtSearch.MinimumSize = new System.Drawing.Size(374, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(374, 22);
            this.txtSearch.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtSearch, "Search by Lecturer/Subject/Subject Code/Group ID/Sub Group ID/No. of Students/Dur" +
        "ation");
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // tblSessions
            // 
            this.tblSessions.AllowUserToAddRows = false;
            this.tblSessions.AllowUserToDeleteRows = false;
            this.tblSessions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.tblSessions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSessions.Location = new System.Drawing.Point(58, 70);
            this.tblSessions.Name = "tblSessions";
            this.tblSessions.ReadOnly = true;
            this.tblSessions.RowHeadersWidth = 51;
            this.tblSessions.RowTemplate.Height = 24;
            this.tblSessions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSessions.Size = new System.Drawing.Size(500, 198);
            this.tblSessions.TabIndex = 0;
            this.tblSessions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSessions_CellClick);
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(557, 196);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(100, 22);
            this.txtDuration.TabIndex = 16;
            this.txtDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDuration_KeyPress);
            this.txtDuration.Validating += new System.ComponentModel.CancelEventHandler(this.txtDuration_Validating);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(357, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 17);
            this.label11.TabIndex = 15;
            this.label11.Text = "Duration(Hours per session) :";
            // 
            // txtStudentCount
            // 
            this.txtStudentCount.Location = new System.Drawing.Point(472, 154);
            this.txtStudentCount.Name = "txtStudentCount";
            this.txtStudentCount.Size = new System.Drawing.Size(100, 22);
            this.txtStudentCount.TabIndex = 14;
            this.txtStudentCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStudentCount_KeyPress);
            this.txtStudentCount.Validating += new System.ComponentModel.CancelEventHandler(this.txtStudentCount_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(355, 154);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "No of Students :";
            // 
            // cmbSubGroup
            // 
            this.cmbSubGroup.FormattingEnabled = true;
            this.cmbSubGroup.Location = new System.Drawing.Point(748, 101);
            this.cmbSubGroup.Name = "cmbSubGroup";
            this.cmbSubGroup.Size = new System.Drawing.Size(121, 24);
            this.cmbSubGroup.TabIndex = 12;
            this.cmbSubGroup.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSubGroup_Validating);
            // 
            // cmbGroupId
            // 
            this.cmbGroupId.FormattingEnabled = true;
            this.cmbGroupId.Location = new System.Drawing.Point(457, 97);
            this.cmbGroupId.Name = "cmbGroupId";
            this.cmbGroupId.Size = new System.Drawing.Size(121, 24);
            this.cmbGroupId.TabIndex = 11;
            this.cmbGroupId.SelectedIndexChanged += new System.EventHandler(this.cmbGroupId_SelectedIndexChanged);
            this.cmbGroupId.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGroupId_Validating);
            // 
            // lblSubGrp
            // 
            this.lblSubGrp.AutoSize = true;
            this.lblSubGrp.Location = new System.Drawing.Point(642, 104);
            this.lblSubGrp.Name = "lblSubGrp";
            this.lblSubGrp.Size = new System.Drawing.Size(100, 17);
            this.lblSubGrp.TabIndex = 10;
            this.lblSubGrp.Text = "Sub-group ID :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(353, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Group ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(869, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Tags:";
            // 
            // txtSubCode
            // 
            this.txtSubCode.Location = new System.Drawing.Point(748, 49);
            this.txtSubCode.Name = "txtSubCode";
            this.txtSubCode.ReadOnly = true;
            this.txtSubCode.Size = new System.Drawing.Size(115, 22);
            this.txtSubCode.TabIndex = 6;
            // 
            // cmbSubject
            // 
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(455, 49);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(172, 24);
            this.cmbSubject.TabIndex = 5;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            this.cmbSubject.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSubject_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(648, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subject Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject :";
            // 
            // panelDropDown
            // 
            this.panelDropDown.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDropDown.Controls.Add(this.label6);
            this.panelDropDown.Controls.Add(this.button1);
            this.panelDropDown.Controls.Add(this.txtLecs);
            this.panelDropDown.Controls.Add(this.label3);
            this.panelDropDown.Controls.Add(this.label2);
            this.panelDropDown.Controls.Add(this.lecNameList);
            this.panelDropDown.Location = new System.Drawing.Point(38, 40);
            this.panelDropDown.MaximumSize = new System.Drawing.Size(297, 261);
            this.panelDropDown.MinimumSize = new System.Drawing.Size(297, 60);
            this.panelDropDown.Name = "panelDropDown";
            this.panelDropDown.Size = new System.Drawing.Size(297, 60);
            this.panelDropDown.TabIndex = 2;
            // 
            // txtLecs
            // 
            this.txtLecs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLecs.Location = new System.Drawing.Point(6, 28);
            this.txtLecs.Name = "txtLecs";
            this.txtLecs.ReadOnly = true;
            this.txtLecs.Size = new System.Drawing.Size(244, 22);
            this.txtLecs.TabIndex = 4;
            this.txtLecs.Validating += new System.ComponentModel.CancelEventHandler(this.txtLecs_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Lecturer(s) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(288, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "* Select Relevent Lecturer(s) name(s).";
            // 
            // lecNameList
            // 
            this.lecNameList.FormattingEnabled = true;
            this.lecNameList.Location = new System.Drawing.Point(1, 108);
            this.lecNameList.Name = "lecNameList";
            this.lecNameList.Size = new System.Drawing.Size(292, 123);
            this.lecNameList.TabIndex = 1;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1079, 699);
            this.metroTabControl1.TabIndex = 2;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.Color.Tan;
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1071, 657);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Normal Session";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1071, 657);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // cmbTags
            // 
            this.cmbTags.FormattingEnabled = true;
            this.cmbTags.Location = new System.Drawing.Point(919, 45);
            this.cmbTags.Name = "cmbTags";
            this.cmbTags.Size = new System.Drawing.Size(85, 24);
            this.cmbTags.TabIndex = 21;
            this.cmbTags.SelectedValueChanged += new System.EventHandler(this.cmbTags_SelectedValueChanged);
            // 
            // btnClr
            // 
            this.btnClr.BackColor = System.Drawing.Color.Peru;
            this.btnClr.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnClr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClr.Image = global::TimeTableManagment.Properties.Resources.icons8_broom;
            this.btnClr.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClr.Location = new System.Drawing.Point(272, 156);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(102, 39);
            this.btnClr.TabIndex = 5;
            this.btnClr.Text = "Clear";
            this.btnClr.UseVisualStyleBackColor = false;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Image = global::TimeTableManagment.Properties.Resources.icons8_search;
            this.label9.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Location = new System.Drawing.Point(59, 34);
            this.label9.MaximumSize = new System.Drawing.Size(150, 25);
            this.label9.MinimumSize = new System.Drawing.Size(105, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Search";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Image = global::TimeTableManagment.Properties.Resources.icons8_erase_48;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(884, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(110, 45);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Image = global::TimeTableManagment.Properties.Resources.icons8_add_new_64;
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(737, 196);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(132, 45);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Image = global::TimeTableManagment.Properties.Resources.icons8_plus_3;
            this.label6.Location = new System.Drawing.Point(255, 21);
            this.label6.MaximumSize = new System.Drawing.Size(33, 33);
            this.label6.MinimumSize = new System.Drawing.Size(33, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 33);
            this.label6.TabIndex = 23;
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // button1
            // 
            this.button1.Image = global::TimeTableManagment.Properties.Resources.icons8_ok_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(227, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Done!";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1079, 699);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "SessionForm";
            this.Text = "Session";
            this.Load += new System.EventHandler(this.SessionForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSessions)).EndInit();
            this.panelDropDown.ResumeLayout(false);
            this.panelDropDown.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelDropDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckedListBox lecNameList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtLecs;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSubCode;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.ComboBox cmbGroupId;
        private System.Windows.Forms.Label lblSubGrp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSubGroup;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView tblSessions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtStudentCount;
        private System.Windows.Forms.Label label12;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblDisSes;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.ComboBox cmbTags;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClr;
    }
}