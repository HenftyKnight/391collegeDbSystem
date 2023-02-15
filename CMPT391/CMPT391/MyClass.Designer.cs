namespace CMPT391
{
    partial class MyClass
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
            this.stuID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.course_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.section = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.start_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.end_time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.day_of_the_week = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // stuID
            // 
            this.stuID.AutoSize = true;
            this.stuID.Location = new System.Drawing.Point(136, 15);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(18, 15);
            this.stuID.TabIndex = 0;
            this.stuID.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(10, 43);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(946, 392);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.course_name,
            this.section,
            this.start_time,
            this.end_time,
            this.day_of_the_week});
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(940, 386);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "course id";
            this.Column1.Name = "Column1";
            // 
            // course_name
            // 
            this.course_name.HeaderText = "course name";
            this.course_name.Name = "course_name";
            this.course_name.Width = 150;
            // 
            // section
            // 
            this.section.HeaderText = "section";
            this.section.Name = "section";
            // 
            // start_time
            // 
            this.start_time.HeaderText = "starts";
            this.start_time.Name = "start_time";
            this.start_time.Width = 150;
            // 
            // end_time
            // 
            this.end_time.HeaderText = "ends";
            this.end_time.Name = "end_time";
            this.end_time.Width = 150;
            // 
            // day_of_the_week
            // 
            this.day_of_the_week.HeaderText = "Day of the week";
            this.day_of_the_week.Name = "day_of_the_week";
            this.day_of_the_week.Width = 150;
            // 
            // MyClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stuID);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyClass";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyClass_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label stuID;
        private Label label1;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn course_name;
        private DataGridViewTextBoxColumn section;
        private DataGridViewTextBoxColumn start_time;
        private DataGridViewTextBoxColumn end_time;
        private DataGridViewTextBoxColumn day_of_the_week;
    }
}