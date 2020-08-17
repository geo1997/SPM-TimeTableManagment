namespace TimeTableManagment.Forms
{
    partial class WorkingDaysForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.check_mon = new System.Windows.Forms.CheckBox();
            this.check_tue = new System.Windows.Forms.CheckBox();
            this.check_wed = new System.Windows.Forms.CheckBox();
            this.check_thurs = new System.Windows.Forms.CheckBox();
            this.check_fri = new System.Windows.Forms.CheckBox();
            this.check_sat = new System.Windows.Forms.CheckBox();
            this.check_sun = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of working days per week";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(228, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(278, 22);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Select the working days";
            // 
            // check_mon
            // 
            this.check_mon.AutoSize = true;
            this.check_mon.Location = new System.Drawing.Point(279, 99);
            this.check_mon.Name = "check_mon";
            this.check_mon.Size = new System.Drawing.Size(80, 21);
            this.check_mon.TabIndex = 3;
            this.check_mon.Text = "Monday";
            this.check_mon.UseVisualStyleBackColor = true;
            // 
            // check_tue
            // 
            this.check_tue.AutoSize = true;
            this.check_tue.Location = new System.Drawing.Point(279, 126);
            this.check_tue.Name = "check_tue";
            this.check_tue.Size = new System.Drawing.Size(85, 21);
            this.check_tue.TabIndex = 4;
            this.check_tue.Text = "Tuesday";
            this.check_tue.UseVisualStyleBackColor = true;
            // 
            // check_wed
            // 
            this.check_wed.AutoSize = true;
            this.check_wed.Location = new System.Drawing.Point(279, 153);
            this.check_wed.Name = "check_wed";
            this.check_wed.Size = new System.Drawing.Size(105, 21);
            this.check_wed.TabIndex = 5;
            this.check_wed.Text = "Wednesday";
            this.check_wed.UseVisualStyleBackColor = true;
            // 
            // check_thurs
            // 
            this.check_thurs.AutoSize = true;
            this.check_thurs.Location = new System.Drawing.Point(279, 180);
            this.check_thurs.Name = "check_thurs";
            this.check_thurs.Size = new System.Drawing.Size(90, 21);
            this.check_thurs.TabIndex = 6;
            this.check_thurs.Text = "Thursday";
            this.check_thurs.UseVisualStyleBackColor = true;
            // 
            // check_fri
            // 
            this.check_fri.AutoSize = true;
            this.check_fri.Location = new System.Drawing.Point(279, 207);
            this.check_fri.Name = "check_fri";
            this.check_fri.Size = new System.Drawing.Size(69, 21);
            this.check_fri.TabIndex = 7;
            this.check_fri.Text = "Friday";
            this.check_fri.UseVisualStyleBackColor = true;
            // 
            // check_sat
            // 
            this.check_sat.AutoSize = true;
            this.check_sat.Location = new System.Drawing.Point(279, 234);
            this.check_sat.Name = "check_sat";
            this.check_sat.Size = new System.Drawing.Size(87, 21);
            this.check_sat.TabIndex = 8;
            this.check_sat.Text = "Saturday";
            this.check_sat.UseVisualStyleBackColor = true;
            // 
            // check_sun
            // 
            this.check_sun.AutoSize = true;
            this.check_sun.Location = new System.Drawing.Point(279, 261);
            this.check_sun.Name = "check_sun";
            this.check_sun.Size = new System.Drawing.Size(78, 21);
            this.check_sun.TabIndex = 9;
            this.check_sun.Text = "Sunday";
            this.check_sun.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.submit__Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(27, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(480, 171);
            this.dataGridView1.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(136, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 231);
            this.panel1.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(461, 563);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 31);
            this.button2.TabIndex = 13;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(589, 563);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 14;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // WorkingDaysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 622);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.check_sun);
            this.Controls.Add(this.check_sat);
            this.Controls.Add(this.check_fri);
            this.Controls.Add(this.check_thurs);
            this.Controls.Add(this.check_wed);
            this.Controls.Add(this.check_tue);
            this.Controls.Add(this.check_mon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "WorkingDaysForm";
            this.Text = "Working Days";
            this.Load += new System.EventHandler(this.WorkingDaysForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox check_mon;
        private System.Windows.Forms.CheckBox check_tue;
        private System.Windows.Forms.CheckBox check_wed;
        private System.Windows.Forms.CheckBox check_thurs;
        private System.Windows.Forms.CheckBox check_fri;
        private System.Windows.Forms.CheckBox check_sat;
        private System.Windows.Forms.CheckBox check_sun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}