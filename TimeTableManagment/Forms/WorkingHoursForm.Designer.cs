namespace TimeTableManagment.Forms
{
    partial class WorkingHoursForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.combo_startTime = new System.Windows.Forms.ComboBox();
            this.combo_endTime = new System.Windows.Forms.ComboBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_hour = new System.Windows.Forms.Label();
            this.lbl_nohours = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Add time slots";
            // 
            // combo_startTime
            // 
            this.combo_startTime.FormattingEnabled = true;
            this.combo_startTime.Items.AddRange(new object[] {
            "8.00",
            "8.30",
            "9.00",
            "9.30",
            "10.00",
            "10.30",
            "11.00",
            "11.30",
            "12.00",
            "12.30",
            "13.00",
            "13.30",
            "14.00",
            "14.30",
            "15.00",
            "15.30",
            "16.00",
            "16.30",
            "17.00",
            "17.30",
            "18.00",
            "18.30",
            "19.00"});
            this.combo_startTime.Location = new System.Drawing.Point(426, 114);
            this.combo_startTime.Name = "combo_startTime";
            this.combo_startTime.Size = new System.Drawing.Size(121, 24);
            this.combo_startTime.TabIndex = 3;
            // 
            // combo_endTime
            // 
            this.combo_endTime.FormattingEnabled = true;
            this.combo_endTime.Items.AddRange(new object[] {
            "9.00",
            "9.30",
            "10.00",
            "10.30",
            "11.00",
            "11.30",
            "12.00",
            "12.30",
            "13.00",
            "13.30",
            "14.00",
            "14.30",
            "15.00",
            "15.30",
            "16.00",
            "16.30",
            "17.00",
            "17.30",
            "18.00",
            "18.30",
            "19.00"});
            this.combo_endTime.Location = new System.Drawing.Point(575, 114);
            this.combo_endTime.Name = "combo_endTime";
            this.combo_endTime.Size = new System.Drawing.Size(121, 24);
            this.combo_endTime.TabIndex = 4;
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_add.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_add.Image = global::TimeTableManagment.Properties.Resources.icons8_add_new_64;
            this.btn_add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add.Location = new System.Drawing.Point(536, 206);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 41);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Submit";
            this.btn_add.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_addHours);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_hour);
            this.panel1.Controls.Add(this.lbl_nohours);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(272, 262);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(705, 346);
            this.panel1.TabIndex = 6;
            // 
            // lbl_hour
            // 
            this.lbl_hour.AutoSize = true;
            this.lbl_hour.Location = new System.Drawing.Point(378, 13);
            this.lbl_hour.Name = "lbl_hour";
            this.lbl_hour.Size = new System.Drawing.Size(46, 17);
            this.lbl_hour.TabIndex = 2;
            this.lbl_hour.Text = "Hours";
            this.lbl_hour.Visible = false;
            // 
            // lbl_nohours
            // 
            this.lbl_nohours.AutoSize = true;
            this.lbl_nohours.Location = new System.Drawing.Point(271, 13);
            this.lbl_nohours.Name = "lbl_nohours";
            this.lbl_nohours.Size = new System.Drawing.Size(100, 17);
            this.lbl_nohours.TabIndex = 1;
            this.lbl_nohours.Text = "No. of Hours : ";
            this.lbl_nohours.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(71, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(572, 281);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_edit.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_edit.Image = global::TimeTableManagment.Properties.Resources.icons8_edit_property_64;
            this.btn_edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_edit.Location = new System.Drawing.Point(366, 206);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(130, 41);
            this.btn_edit.TabIndex = 8;
            this.btn_edit.Text = "Edit";
            this.btn_edit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.click_editBtn);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.IndianRed;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_delete.Image = global::TimeTableManagment.Properties.Resources.icons8_delete_64;
            this.btn_delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_delete.Location = new System.Drawing.Point(685, 206);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(130, 41);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // WorkingHoursForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 661);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.combo_endTime);
            this.Controls.Add(this.combo_startTime);
            this.Controls.Add(this.label2);
            this.Name = "WorkingHoursForm";
            this.Text = "Working Hours";
            this.Load += new System.EventHandler(this.workingHoursForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_startTime;
        private System.Windows.Forms.ComboBox combo_endTime;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_nohours;
        private System.Windows.Forms.Label lbl_hour;
    }
}