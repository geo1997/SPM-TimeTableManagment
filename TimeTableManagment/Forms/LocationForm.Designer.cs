namespace TimeTableManagment.Forms
{
    partial class Location
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
            this.buildingAddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buildingNameTxtBx = new System.Windows.Forms.TextBox();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buildingEditBtn = new System.Windows.Forms.Button();
            this.buildingDeleteBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.idTxtxBox = new System.Windows.Forms.TextBox();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.metroTabControl1.Size = new System.Drawing.Size(975, 627);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.label2);
            this.metroTabPage1.Controls.Add(this.idTxtxBox);
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
            this.metroTabPage1.Size = new System.Drawing.Size(967, 585);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Building Details";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // buildingAddBtn
            // 
            this.buildingAddBtn.Location = new System.Drawing.Point(170, 162);
            this.buildingAddBtn.Name = "buildingAddBtn";
            this.buildingAddBtn.Size = new System.Drawing.Size(119, 32);
            this.buildingAddBtn.TabIndex = 4;
            this.buildingAddBtn.Text = "Add Building";
            this.buildingAddBtn.UseVisualStyleBackColor = true;
            this.buildingAddBtn.Click += new System.EventHandler(this.buildingAddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Building Name";
            // 
            // buildingNameTxtBx
            // 
            this.buildingNameTxtBx.Location = new System.Drawing.Point(169, 115);
            this.buildingNameTxtBx.Name = "buildingNameTxtBx";
            this.buildingNameTxtBx.Size = new System.Drawing.Size(181, 22);
            this.buildingNameTxtBx.TabIndex = 2;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(967, 585);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Room Details";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
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
            this.dataGridView1.Size = new System.Drawing.Size(547, 208);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buildingEditBtn
            // 
            this.buildingEditBtn.Location = new System.Drawing.Point(607, 499);
            this.buildingEditBtn.Name = "buildingEditBtn";
            this.buildingEditBtn.Size = new System.Drawing.Size(101, 46);
            this.buildingEditBtn.TabIndex = 6;
            this.buildingEditBtn.Text = "Edit";
            this.buildingEditBtn.UseVisualStyleBackColor = true;
            this.buildingEditBtn.Click += new System.EventHandler(this.buildingEditBtn_Click);
            // 
            // buildingDeleteBtn
            // 
            this.buildingDeleteBtn.Location = new System.Drawing.Point(714, 499);
            this.buildingDeleteBtn.Name = "buildingDeleteBtn";
            this.buildingDeleteBtn.Size = new System.Drawing.Size(101, 46);
            this.buildingDeleteBtn.TabIndex = 7;
            this.buildingDeleteBtn.Text = "Delete";
            this.buildingDeleteBtn.UseVisualStyleBackColor = true;
            this.buildingDeleteBtn.Click += new System.EventHandler(this.buildingDeleteBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(169, 217);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 263);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "ID";
            // 
            // idTxtxBox
            // 
            this.idTxtxBox.Enabled = false;
            this.idTxtxBox.Location = new System.Drawing.Point(169, 54);
            this.idTxtxBox.Name = "idTxtxBox";
            this.idTxtxBox.Size = new System.Drawing.Size(181, 22);
            this.idTxtxBox.TabIndex = 9;
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 627);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Location";
            this.Text = "Location";
            this.Load += new System.EventHandler(this.Location_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxtxBox;
    }
}