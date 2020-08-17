namespace TimeTableManagment.Forms
{
    partial class LecturerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LecturerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.txtLecName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblLec = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBuild = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbLevel = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmpId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.txtCenter = new System.Windows.Forms.TextBox();
            this.txtFac = new System.Windows.Forms.TextBox();
            this.labelRank = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.labelLec = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.radioDoc = new System.Windows.Forms.RadioButton();
            this.radioMister = new System.Windows.Forms.RadioButton();
            this.radioMisis = new System.Windows.Forms.RadioButton();
            this.radioMiss = new System.Windows.Forms.RadioButton();
            this.radioProf = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Full Name:";
            // 
            // txtLecName
            // 
            this.txtLecName.Location = new System.Drawing.Point(68, 78);
            this.txtLecName.Name = "txtLecName";
            this.txtLecName.Size = new System.Drawing.Size(299, 22);
            this.txtLecName.TabIndex = 1;
            this.txtLecName.Validating += new System.ComponentModel.CancelEventHandler(this.txtLecName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Faculty of:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tblLec);
            this.panel1.Location = new System.Drawing.Point(-1, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 350);
            this.panel1.TabIndex = 5;
            // 
            // tblLec
            // 
            this.tblLec.AllowUserToAddRows = false;
            this.tblLec.AllowUserToDeleteRows = false;
            this.tblLec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tblLec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLec.Location = new System.Drawing.Point(65, 30);
            this.tblLec.Name = "tblLec";
            this.tblLec.ReadOnly = true;
            this.tblLec.RowHeadersWidth = 51;
            this.tblLec.RowTemplate.Height = 24;
            this.tblLec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblLec.Size = new System.Drawing.Size(929, 246);
            this.tblLec.TabIndex = 5;
            this.tblLec.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblLec_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(752, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete the lecturer\'s details");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(494, 260);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 41);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit the Details");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Building:";
            // 
            // cmbBuild
            // 
            this.cmbBuild.FormattingEnabled = true;
            this.cmbBuild.Location = new System.Drawing.Point(68, 203);
            this.cmbBuild.Name = "cmbBuild";
            this.cmbBuild.Size = new System.Drawing.Size(205, 24);
            this.cmbBuild.TabIndex = 7;
            this.cmbBuild.Validating += new System.ComponentModel.CancelEventHandler(this.cmbBuild_Validating);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Level:";
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Items.AddRange(new object[] {
            "Professor",
            "Assistant Professor",
            "Senior Lecturer(HG)",
            "Senior Lecturer",
            "Lecturer",
            "Assistant Lecturer",
            "Instructors"});
            this.cmbLevel.Location = new System.Drawing.Point(65, 270);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(205, 24);
            this.cmbLevel.TabIndex = 9;
            this.cmbLevel.Validating += new System.ComponentModel.CancelEventHandler(this.cmbLevel_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(491, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Employee ID:";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(494, 75);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.ReadOnly = true;
            this.txtEmpId.Size = new System.Drawing.Size(278, 22);
            this.txtEmpId.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(491, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Department :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 183);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Center:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(494, 260);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 41);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSubmit, "Submit the Details");
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(630, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 41);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnClear, "To clear all the fields");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(494, 140);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(278, 22);
            this.txtDept.TabIndex = 18;
            this.txtDept.Validating += new System.ComponentModel.CancelEventHandler(this.txtDept_Validating);
            // 
            // txtCenter
            // 
            this.txtCenter.Location = new System.Drawing.Point(494, 203);
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.Size = new System.Drawing.Size(278, 22);
            this.txtCenter.TabIndex = 19;
            this.txtCenter.Validating += new System.ComponentModel.CancelEventHandler(this.txtCenter_Validating);
            // 
            // txtFac
            // 
            this.txtFac.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtFac.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtFac.Location = new System.Drawing.Point(68, 141);
            this.txtFac.Name = "txtFac";
            this.txtFac.Size = new System.Drawing.Size(299, 22);
            this.txtFac.TabIndex = 20;
            this.txtFac.Validating += new System.ComponentModel.CancelEventHandler(this.txtFac_Validating);
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRank.Location = new System.Drawing.Point(107, 23);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(57, 20);
            this.labelRank.TabIndex = 22;
            this.labelRank.Text = "Rank:";
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRank.Location = new System.Drawing.Point(170, 23);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(49, 19);
            this.lblRank.TabIndex = 23;
            this.lblRank.Text = "Rank";
            // 
            // labelLec
            // 
            this.labelLec.AutoSize = true;
            this.labelLec.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLec.Location = new System.Drawing.Point(405, 9);
            this.labelLec.Name = "labelLec";
            this.labelLec.Size = new System.Drawing.Size(189, 32);
            this.labelLec.TabIndex = 24;
            this.labelLec.Text = "Add Lecturer";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // radioDoc
            // 
            this.radioDoc.AutoSize = true;
            this.radioDoc.Location = new System.Drawing.Point(202, 53);
            this.radioDoc.Name = "radioDoc";
            this.radioDoc.Size = new System.Drawing.Size(48, 21);
            this.radioDoc.TabIndex = 25;
            this.radioDoc.TabStop = true;
            this.radioDoc.Text = "Dr.";
            this.radioDoc.UseVisualStyleBackColor = true;
            // 
            // radioMister
            // 
            this.radioMister.AutoSize = true;
            this.radioMister.Location = new System.Drawing.Point(245, 53);
            this.radioMister.Name = "radioMister";
            this.radioMister.Size = new System.Drawing.Size(49, 21);
            this.radioMister.TabIndex = 26;
            this.radioMister.TabStop = true;
            this.radioMister.Text = "Mr.";
            this.radioMister.UseVisualStyleBackColor = true;
            // 
            // radioMisis
            // 
            this.radioMisis.AutoSize = true;
            this.radioMisis.Location = new System.Drawing.Point(287, 53);
            this.radioMisis.Name = "radioMisis";
            this.radioMisis.Size = new System.Drawing.Size(56, 21);
            this.radioMisis.TabIndex = 27;
            this.radioMisis.TabStop = true;
            this.radioMisis.Text = "Mrs.";
            this.radioMisis.UseVisualStyleBackColor = true;
            // 
            // radioMiss
            // 
            this.radioMiss.AutoSize = true;
            this.radioMiss.Location = new System.Drawing.Point(339, 53);
            this.radioMiss.Name = "radioMiss";
            this.radioMiss.Size = new System.Drawing.Size(51, 21);
            this.radioMiss.TabIndex = 28;
            this.radioMiss.TabStop = true;
            this.radioMiss.Text = "Ms.";
            this.radioMiss.UseVisualStyleBackColor = true;
            // 
            // radioProf
            // 
            this.radioProf.AutoSize = true;
            this.radioProf.Location = new System.Drawing.Point(137, 53);
            this.radioProf.Name = "radioProf";
            this.radioProf.Size = new System.Drawing.Size(59, 21);
            this.radioProf.TabIndex = 29;
            this.radioProf.TabStop = true;
            this.radioProf.Text = "Prof.";
            this.radioProf.UseVisualStyleBackColor = true;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1136, 699);
            this.Controls.Add(this.radioProf);
            this.Controls.Add(this.radioMiss);
            this.Controls.Add(this.radioMisis);
            this.Controls.Add(this.radioMister);
            this.Controls.Add(this.radioDoc);
            this.Controls.Add(this.labelLec);
            this.Controls.Add(this.lblRank);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtFac);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtCenter);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmpId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbBuild);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLecName);
            this.Controls.Add(this.label1);
            this.Name = "LecturerForm";
            this.Text = "Lecturer";
            this.Load += new System.EventHandler(this.LecturerForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblLec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLecName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBuild;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView tblLec;
        private System.Windows.Forms.ComboBox cmbLevel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmpId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.TextBox txtCenter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox txtFac;
        private System.Windows.Forms.Label labelRank;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label labelLec;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.RadioButton radioMiss;
        private System.Windows.Forms.RadioButton radioMisis;
        private System.Windows.Forms.RadioButton radioMister;
        private System.Windows.Forms.RadioButton radioDoc;
        private System.Windows.Forms.RadioButton radioProf;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}