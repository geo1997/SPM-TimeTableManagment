namespace TimeTableManagment.Forms
{
    partial class LocationForm
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buildingDeleteBtn = new System.Windows.Forms.Button();
            this.buildingEditBtn = new System.Windows.Forms.Button();
            this.buildingAddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buildingNameTxtBx = new System.Windows.Forms.TextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.clearDetailsBtn = new System.Windows.Forms.Button();
            this.detailDeleteBtn = new System.Windows.Forms.Button();
            this.detailsEditBtn = new System.Windows.Forms.Button();
            this.detailsAddBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.roomTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buildingNameComboBox = new System.Windows.Forms.ComboBox();
            this.roomCapacityTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.roomNameTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1buildingDataClear = new System.Windows.Forms.Button();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 0);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(982, 653);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.SelectedIndexChanged += new System.EventHandler(this.metroTabControl1_SelectedIndexChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.metroTabPage1.Controls.Add(this.button1buildingDataClear);
            this.metroTabPage1.Controls.Add(this.panel1);
            this.metroTabPage1.Controls.Add(this.buildingDeleteBtn);
            this.metroTabPage1.Controls.Add(this.buildingEditBtn);
            this.metroTabPage1.Controls.Add(this.buildingAddBtn);
            this.metroTabPage1.Controls.Add(this.label1);
            this.metroTabPage1.Controls.Add(this.buildingNameTxtBx);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(974, 611);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Building Details";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(169, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 263);
            this.panel1.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(51, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(547, 208);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buildingDeleteBtn
            // 
            this.buildingDeleteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.buildingDeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buildingDeleteBtn.Image = global::TimeTableManagment.Properties.Resources.icons8_delete_64;
            this.buildingDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buildingDeleteBtn.Location = new System.Drawing.Point(542, 499);
            this.buildingDeleteBtn.Name = "buildingDeleteBtn";
            this.buildingDeleteBtn.Size = new System.Drawing.Size(130, 41);
            this.buildingDeleteBtn.TabIndex = 7;
            this.buildingDeleteBtn.Text = "Delete";
            this.buildingDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buildingDeleteBtn.UseVisualStyleBackColor = false;
            this.buildingDeleteBtn.Click += new System.EventHandler(this.buildingDeleteBtn_Click);
            // 
            // buildingEditBtn
            // 
            this.buildingEditBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buildingEditBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buildingEditBtn.Image = global::TimeTableManagment.Properties.Resources.icons8_edit_property_641;
            this.buildingEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buildingEditBtn.Location = new System.Drawing.Point(406, 499);
            this.buildingEditBtn.Name = "buildingEditBtn";
            this.buildingEditBtn.Size = new System.Drawing.Size(130, 41);
            this.buildingEditBtn.TabIndex = 6;
            this.buildingEditBtn.Text = "Edit";
            this.buildingEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buildingEditBtn.UseVisualStyleBackColor = false;
            this.buildingEditBtn.Click += new System.EventHandler(this.buildingEditBtn_Click);
            // 
            // buildingAddBtn
            // 
            this.buildingAddBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.buildingAddBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.buildingAddBtn.Image = global::TimeTableManagment.Properties.Resources.icons8_add_new_64;
            this.buildingAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buildingAddBtn.Location = new System.Drawing.Point(170, 138);
            this.buildingAddBtn.Name = "buildingAddBtn";
            this.buildingAddBtn.Size = new System.Drawing.Size(130, 41);
            this.buildingAddBtn.TabIndex = 4;
            this.buildingAddBtn.Text = "Add";
            this.buildingAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buildingAddBtn.UseVisualStyleBackColor = false;
            this.buildingAddBtn.Click += new System.EventHandler(this.buildingAddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(167, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Building Name";
            // 
            // buildingNameTxtBx
            // 
            this.buildingNameTxtBx.Location = new System.Drawing.Point(169, 81);
            this.buildingNameTxtBx.Name = "buildingNameTxtBx";
            this.buildingNameTxtBx.Size = new System.Drawing.Size(181, 22);
            this.buildingNameTxtBx.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.clearDetailsBtn);
            this.metroTabPage2.Controls.Add(this.detailDeleteBtn);
            this.metroTabPage2.Controls.Add(this.detailsEditBtn);
            this.metroTabPage2.Controls.Add(this.detailsAddBtn);
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.Controls.Add(this.roomTypeComboBox);
            this.metroTabPage2.Controls.Add(this.label6);
            this.metroTabPage2.Controls.Add(this.buildingNameComboBox);
            this.metroTabPage2.Controls.Add(this.roomCapacityTxtBox);
            this.metroTabPage2.Controls.Add(this.label5);
            this.metroTabPage2.Controls.Add(this.roomNameTxtBox);
            this.metroTabPage2.Controls.Add(this.label4);
            this.metroTabPage2.Controls.Add(this.label3);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(974, 611);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Room Details";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // clearDetailsBtn
            // 
            this.clearDetailsBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.clearDetailsBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.clearDetailsBtn.Image = global::TimeTableManagment.Properties.Resources.icons8_erase_48;
            this.clearDetailsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearDetailsBtn.Location = new System.Drawing.Point(752, 254);
            this.clearDetailsBtn.Name = "clearDetailsBtn";
            this.clearDetailsBtn.Size = new System.Drawing.Size(130, 41);
            this.clearDetailsBtn.TabIndex = 16;
            this.clearDetailsBtn.Text = "Clear";
            this.clearDetailsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clearDetailsBtn.UseVisualStyleBackColor = false;
            this.clearDetailsBtn.Click += new System.EventHandler(this.clearDetailsBtn_Click);
            // 
            // detailDeleteBtn
            // 
            this.detailDeleteBtn.BackColor = System.Drawing.Color.IndianRed;
            this.detailDeleteBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.detailDeleteBtn.Image = global::TimeTableManagment.Properties.Resources.icons8_delete_64;
            this.detailDeleteBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detailDeleteBtn.Location = new System.Drawing.Point(621, 254);
            this.detailDeleteBtn.Name = "detailDeleteBtn";
            this.detailDeleteBtn.Size = new System.Drawing.Size(130, 41);
            this.detailDeleteBtn.TabIndex = 15;
            this.detailDeleteBtn.Text = "Delete";
            this.detailDeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.detailDeleteBtn.UseVisualStyleBackColor = false;
            this.detailDeleteBtn.Click += new System.EventHandler(this.detailDeleteBtn_Click);
            // 
            // detailsEditBtn
            // 
            this.detailsEditBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.detailsEditBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.detailsEditBtn.Image = global::TimeTableManagment.Properties.Resources.icons8_edit_property_64;
            this.detailsEditBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detailsEditBtn.Location = new System.Drawing.Point(490, 254);
            this.detailsEditBtn.Name = "detailsEditBtn";
            this.detailsEditBtn.Size = new System.Drawing.Size(130, 41);
            this.detailsEditBtn.TabIndex = 14;
            this.detailsEditBtn.Text = "Edit";
            this.detailsEditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.detailsEditBtn.UseVisualStyleBackColor = false;
            this.detailsEditBtn.Click += new System.EventHandler(this.detailsEditBtn_Click);
            // 
            // detailsAddBtn
            // 
            this.detailsAddBtn.BackColor = System.Drawing.Color.CornflowerBlue;
            this.detailsAddBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.detailsAddBtn.Image = global::TimeTableManagment.Properties.Resources.icons8_add_new_64;
            this.detailsAddBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.detailsAddBtn.Location = new System.Drawing.Point(359, 254);
            this.detailsAddBtn.Name = "detailsAddBtn";
            this.detailsAddBtn.Size = new System.Drawing.Size(130, 41);
            this.detailsAddBtn.TabIndex = 13;
            this.detailsAddBtn.Text = "Add";
            this.detailsAddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.detailsAddBtn.UseVisualStyleBackColor = false;
            this.detailsAddBtn.Click += new System.EventHandler(this.detailsAddBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(76, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 253);
            this.panel2.TabIndex = 12;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(31, 20);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(780, 217);
            this.dataGridView2.TabIndex = 11;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // roomTypeComboBox
            // 
            this.roomTypeComboBox.FormattingEnabled = true;
            this.roomTypeComboBox.Items.AddRange(new object[] {
            "Lecture Hall",
            "Laboratory"});
            this.roomTypeComboBox.Location = new System.Drawing.Point(89, 201);
            this.roomTypeComboBox.Name = "roomTypeComboBox";
            this.roomTypeComboBox.Size = new System.Drawing.Size(137, 24);
            this.roomTypeComboBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 17);
            this.label6.TabIndex = 9;
            this.label6.Text = "Room Type";
            // 
            // buildingNameComboBox
            // 
            this.buildingNameComboBox.FormattingEnabled = true;
            this.buildingNameComboBox.Location = new System.Drawing.Point(89, 62);
            this.buildingNameComboBox.Name = "buildingNameComboBox";
            this.buildingNameComboBox.Size = new System.Drawing.Size(137, 24);
            this.buildingNameComboBox.TabIndex = 8;
            // 
            // roomCapacityTxtBox
            // 
            this.roomCapacityTxtBox.Location = new System.Drawing.Point(89, 273);
            this.roomCapacityTxtBox.Name = "roomCapacityTxtBox";
            this.roomCapacityTxtBox.Size = new System.Drawing.Size(137, 22);
            this.roomCapacityTxtBox.TabIndex = 7;
            this.roomCapacityTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roomCapacityTxtBox_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Room Capacity";
            // 
            // roomNameTxtBox
            // 
            this.roomNameTxtBox.Location = new System.Drawing.Point(89, 131);
            this.roomNameTxtBox.Name = "roomNameTxtBox";
            this.roomNameTxtBox.Size = new System.Drawing.Size(137, 22);
            this.roomNameTxtBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Room Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Building Name:";
            // 
            // button1buildingDataClear
            // 
            this.button1buildingDataClear.BackColor = System.Drawing.Color.SteelBlue;
            this.button1buildingDataClear.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold);
            this.button1buildingDataClear.Image = global::TimeTableManagment.Properties.Resources.icons8_erase_48;
            this.button1buildingDataClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1buildingDataClear.Location = new System.Drawing.Point(678, 499);
            this.button1buildingDataClear.Name = "button1buildingDataClear";
            this.button1buildingDataClear.Size = new System.Drawing.Size(130, 41);
            this.button1buildingDataClear.TabIndex = 17;
            this.button1buildingDataClear.Text = "Clear";
            this.button1buildingDataClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1buildingDataClear.UseVisualStyleBackColor = false;
            this.button1buildingDataClear.Click += new System.EventHandler(this.button1buildingDataClear_Click);
            // 
            // LocationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(982, 653);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "LocationForm";
            this.Text = "Location";
            this.Load += new System.EventHandler(this.Location_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.Button buildingAddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buildingNameTxtBx;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buildingDeleteBtn;
        private System.Windows.Forms.Button buildingEditBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox roomTypeComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox buildingNameComboBox;
        private System.Windows.Forms.TextBox roomCapacityTxtBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox roomNameTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button clearDetailsBtn;
        private System.Windows.Forms.Button detailDeleteBtn;
        private System.Windows.Forms.Button detailsEditBtn;
        private System.Windows.Forms.Button detailsAddBtn;
        private System.Windows.Forms.Button button1buildingDataClear;
    }
}