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
            this.label1 = new System.Windows.Forms.Label();
            this.txtLecName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tblLec = new System.Windows.Forms.DataGridView();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblLec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ful Name:";
            // 
            // txtLecName
            // 
            this.txtLecName.Location = new System.Drawing.Point(110, 78);
            this.txtLecName.Name = "txtLecName";
            this.txtLecName.Size = new System.Drawing.Size(299, 22);
            this.txtLecName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Faculty:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.tblLec);
            this.panel1.Location = new System.Drawing.Point(-1, 351);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1139, 350);
            this.panel1.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(813, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(104, 38);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(696, 295);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(100, 39);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.button3_Click);
            // 
            // tblLec
            // 
            this.tblLec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblLec.Location = new System.Drawing.Point(78, 43);
            this.tblLec.Name = "tblLec";
            this.tblLec.RowHeadersWidth = 51;
            this.tblLec.RowTemplate.Height = 24;
            this.tblLec.Size = new System.Drawing.Size(849, 246);
            this.tblLec.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Building:";
            // 
            // cmbBuild
            // 
            this.cmbBuild.FormattingEnabled = true;
            this.cmbBuild.Location = new System.Drawing.Point(110, 204);
            this.cmbBuild.Name = "cmbBuild";
            this.cmbBuild.Size = new System.Drawing.Size(205, 24);
            this.cmbBuild.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Level:";
            // 
            // cmbLevel
            // 
            this.cmbLevel.FormattingEnabled = true;
            this.cmbLevel.Location = new System.Drawing.Point(110, 270);
            this.cmbLevel.Name = "cmbLevel";
            this.cmbLevel.Size = new System.Drawing.Size(205, 24);
            this.cmbLevel.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(549, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Employee ID:";
            // 
            // txtEmpId
            // 
            this.txtEmpId.Location = new System.Drawing.Point(552, 77);
            this.txtEmpId.Name = "txtEmpId";
            this.txtEmpId.Size = new System.Drawing.Size(278, 22);
            this.txtEmpId.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(552, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Department :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(552, 184);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Center:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(552, 261);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(119, 41);
            this.btnSubmit.TabIndex = 16;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(696, 261);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 41);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(552, 141);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(278, 22);
            this.txtDept.TabIndex = 18;
            // 
            // txtCenter
            // 
            this.txtCenter.Location = new System.Drawing.Point(552, 205);
            this.txtCenter.Name = "txtCenter";
            this.txtCenter.Size = new System.Drawing.Size(278, 22);
            this.txtCenter.TabIndex = 19;
            // 
            // txtFac
            // 
            this.txtFac.Location = new System.Drawing.Point(110, 140);
            this.txtFac.Name = "txtFac";
            this.txtFac.Size = new System.Drawing.Size(299, 22);
            this.txtFac.TabIndex = 20;
            // 
            // LecturerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1136, 699);
            this.Controls.Add(this.txtFac);
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
    }
}