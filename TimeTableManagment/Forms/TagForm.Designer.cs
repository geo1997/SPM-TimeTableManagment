namespace TimeTableManagment.Forms
{
    partial class TagForm
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
            this.idTxtxBox = new System.Windows.Forms.TextBox();
            this.buildingAddBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buildingNameTxtBx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "ID";
            // 
            // idTxtxBox
            // 
            this.idTxtxBox.Enabled = false;
            this.idTxtxBox.Location = new System.Drawing.Point(160, 82);
            this.idTxtxBox.Name = "idTxtxBox";
            this.idTxtxBox.Size = new System.Drawing.Size(181, 22);
            this.idTxtxBox.TabIndex = 14;
            // 
            // buildingAddBtn
            // 
            this.buildingAddBtn.Location = new System.Drawing.Point(161, 190);
            this.buildingAddBtn.Name = "buildingAddBtn";
            this.buildingAddBtn.Size = new System.Drawing.Size(119, 32);
            this.buildingAddBtn.TabIndex = 13;
            this.buildingAddBtn.Text = "Add Tag";
            this.buildingAddBtn.UseVisualStyleBackColor = true;
            this.buildingAddBtn.Click += new System.EventHandler(this.buildingAddBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(157, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tag";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buildingNameTxtBx
            // 
            this.buildingNameTxtBx.Location = new System.Drawing.Point(160, 143);
            this.buildingNameTxtBx.Name = "buildingNameTxtBx";
            this.buildingNameTxtBx.Size = new System.Drawing.Size(181, 22);
            this.buildingNameTxtBx.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(79, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 205);
            this.panel1.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(38, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(608, 165);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(496, 493);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "Edit Tag";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(641, 493);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 32);
            this.button2.TabIndex = 18;
            this.button2.Text = "Delete Tag";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // TagForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 546);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTxtxBox);
            this.Controls.Add(this.buildingAddBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buildingNameTxtBx);
            this.Name = "TagForm";
            this.Text = "TagForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox idTxtxBox;
        private System.Windows.Forms.Button buildingAddBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buildingNameTxtBx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}