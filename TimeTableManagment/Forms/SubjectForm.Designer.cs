namespace TimeTableManagment.Forms
{
    partial class SubjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubjectForm));
            this.label2 = new System.Windows.Forms.Label();
            this.txtSubName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numTuteHr = new System.Windows.Forms.NumericUpDown();
            this.numLecHr = new System.Windows.Forms.NumericUpDown();
            this.numLabHr = new System.Windows.Forms.NumericUpDown();
            this.numEvoHr = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSem = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tblSub = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.labelSub = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSubCode = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtDept = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numTuteHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLecHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLabHr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEvoHr)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblSub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Subject Name:";
            // 
            // txtSubName
            // 
            this.txtSubName.Location = new System.Drawing.Point(110, 79);
            this.txtSubName.Name = "txtSubName";
            this.txtSubName.Size = new System.Drawing.Size(228, 22);
            this.txtSubName.TabIndex = 1;
            this.txtSubName.Validating += new System.ComponentModel.CancelEventHandler(this.txtSubName_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Offered Year:";
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cmbYear.Location = new System.Drawing.Point(110, 141);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(156, 24);
            this.cmbYear.TabIndex = 3;
            this.cmbYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbYear_KeyPress);
            this.cmbYear.Validating += new System.ComponentModel.CancelEventHandler(this.cmbYear_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number of Lecture hours: (Hr)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Number of Lab hours:(Hr)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Subject Code:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(467, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 17);
            this.label7.TabIndex = 11;
            this.label7.Text = "Offered Semester:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(467, 178);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(195, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Number of Tutorial hours:(Hr)";
            // 
            // numTuteHr
            // 
            this.numTuteHr.Location = new System.Drawing.Point(470, 198);
            this.numTuteHr.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numTuteHr.Name = "numTuteHr";
            this.numTuteHr.Size = new System.Drawing.Size(60, 22);
            this.numTuteHr.TabIndex = 6;
            this.numTuteHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numTuteHr_KeyPress);
            // 
            // numLecHr
            // 
            this.numLecHr.Location = new System.Drawing.Point(110, 198);
            this.numLecHr.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numLecHr.Name = "numLecHr";
            this.numLecHr.Size = new System.Drawing.Size(60, 22);
            this.numLecHr.TabIndex = 5;
            this.numLecHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numLecHr_KeyPress);
            // 
            // numLabHr
            // 
            this.numLabHr.Location = new System.Drawing.Point(110, 256);
            this.numLabHr.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numLabHr.Name = "numLabHr";
            this.numLabHr.Size = new System.Drawing.Size(60, 22);
            this.numLabHr.TabIndex = 7;
            this.numLabHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numLabHr_KeyPress);
            // 
            // numEvoHr
            // 
            this.numEvoHr.Location = new System.Drawing.Point(470, 256);
            this.numEvoHr.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.numEvoHr.Name = "numEvoHr";
            this.numEvoHr.Size = new System.Drawing.Size(60, 22);
            this.numEvoHr.TabIndex = 8;
            this.numEvoHr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numEvoHr_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(467, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 17);
            this.label9.TabIndex = 23;
            this.label9.Text = "Number of Evoluation hours:(Hr)";
            // 
            // cmbSem
            // 
            this.cmbSem.FormattingEnabled = true;
            this.cmbSem.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbSem.Location = new System.Drawing.Point(470, 141);
            this.cmbSem.Name = "cmbSem";
            this.cmbSem.Size = new System.Drawing.Size(192, 24);
            this.cmbSem.TabIndex = 4;
            this.cmbSem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbSem_KeyPress);
            this.cmbSem.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSem_Validating);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tblSub);
            this.panel1.Location = new System.Drawing.Point(-1, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1045, 376);
            this.panel1.TabIndex = 25;
            // 
            // tblSub
            // 
            this.tblSub.AllowUserToAddRows = false;
            this.tblSub.AllowUserToDeleteRows = false;
            this.tblSub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblSub.Location = new System.Drawing.Point(76, 57);
            this.tblSub.Name = "tblSub";
            this.tblSub.ReadOnly = true;
            this.tblSub.RowHeadersWidth = 51;
            this.tblSub.RowTemplate.Height = 24;
            this.tblSub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tblSub.Size = new System.Drawing.Size(847, 222);
            this.tblSub.TabIndex = 0;
            this.tblSub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblSub_CellClick);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.IndianRed;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(700, 179);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnDelete, "Delete the SSubject Details");
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(700, 223);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(130, 41);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit the Details");
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Image = ((System.Drawing.Image)(resources.GetObject("btnSubmit.Image")));
            this.btnSubmit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSubmit.Location = new System.Drawing.Point(701, 224);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 41);
            this.btnSubmit.TabIndex = 26;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnSubmit, "Submit the Subject Details");
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(836, 223);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 41);
            this.btnClear.TabIndex = 27;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.toolTip1.SetToolTip(this.btnClear, "To Clear all fields");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // labelSub
            // 
            this.labelSub.AutoSize = true;
            this.labelSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSub.Location = new System.Drawing.Point(388, 9);
            this.labelSub.Name = "labelSub";
            this.labelSub.Size = new System.Drawing.Size(180, 32);
            this.labelSub.TabIndex = 0;
            this.labelSub.Text = "Add Subject";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // txtSubCode
            // 
            this.txtSubCode.Location = new System.Drawing.Point(470, 79);
            this.txtSubCode.Name = "txtSubCode";
            this.txtSubCode.ReadOnly = true;
            this.txtSubCode.Size = new System.Drawing.Size(98, 22);
            this.txtSubCode.TabIndex = 28;
            // 
            // txtDept
            // 
            this.txtDept.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDept.Location = new System.Drawing.Point(470, 79);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(40, 22);
            this.txtDept.TabIndex = 2;
            this.txtDept.Text = "IT/SE";
            this.toolTip1.SetToolTip(this.txtDept, "Enter Department Eg:- IT/IE/SE");
            this.txtDept.Enter += new System.EventHandler(this.txtDept_Enter);
            this.txtDept.Leave += new System.EventHandler(this.txtDept_Leave);
            this.txtDept.Validating += new System.ComponentModel.CancelEventHandler(this.txtDept_Validating);
            // 
            // SubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1039, 630);
            this.Controls.Add(this.txtDept);
            this.Controls.Add(this.txtSubCode);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cmbSem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.numEvoHr);
            this.Controls.Add(this.numLabHr);
            this.Controls.Add(this.numLecHr);
            this.Controls.Add(this.numTuteHr);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSubName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelSub);
            this.Name = "SubjectForm";
            this.Text = "Subjects";
            this.Load += new System.EventHandler(this.SubjectForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numTuteHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLecHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLabHr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numEvoHr)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblSub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSubName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numTuteHr;
        private System.Windows.Forms.NumericUpDown numLecHr;
        private System.Windows.Forms.NumericUpDown numLabHr;
        private System.Windows.Forms.NumericUpDown numEvoHr;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbSem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView tblSub;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label labelSub;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TextBox txtSubCode;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtDept;
    }
}