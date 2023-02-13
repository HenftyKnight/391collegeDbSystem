namespace CMPT391
{
    partial class SearchClass
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
            this.searchBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.courseList = new System.Windows.Forms.ListView();
            this.course_name = new System.Windows.Forms.ColumnHeader();
            this.section = new System.Windows.Forms.ColumnHeader();
            this.instructor = new System.Windows.Forms.ColumnHeader();
            this.start_time = new System.Windows.Forms.ColumnHeader();
            this.end_time = new System.Windows.Forms.ColumnHeader();
            this.day_of_the_week = new System.Windows.Forms.ColumnHeader();
            this.max_capacity = new System.Windows.Forms.ColumnHeader();
            this.seats_available = new System.Windows.Forms.ColumnHeader();
            this.searchBtn = new System.Windows.Forms.Button();
            this.enrollBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(119, 23);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(142, 27);
            this.searchBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.courseList);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 523);
            this.panel1.TabIndex = 2;
            // 
            // courseList
            // 
            this.courseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.course_name,
            this.section,
            this.start_time,
            this.end_time,
            this.day_of_the_week,
            this.max_capacity,
            this.seats_available,
            this.instructor});
            this.courseList.GridLines = true;
            this.courseList.Location = new System.Drawing.Point(-1, -2);
            this.courseList.Name = "courseList";
            this.courseList.Size = new System.Drawing.Size(1081, 524);
            this.courseList.TabIndex = 0;
            this.courseList.UseCompatibleStateImageBehavior = false;
            this.courseList.View = System.Windows.Forms.View.Details;
            // 
            // course_name
            // 
            this.course_name.Text = "Course Name";
            this.course_name.Width = 120;
            // 
            // section
            // 
            this.section.Text = "Section";
            this.section.Width = 90;
            // 
            // instructor
            // 
            this.instructor.Text = "Instructor";
            this.instructor.Width = 150;
            // 
            // start_time
            // 
            this.start_time.Text = "Start Time";
            this.start_time.Width = 130;
            // 
            // end_time
            // 
            this.end_time.Text = "End Time";
            this.end_time.Width = 130;
            // 
            // day_of_the_week
            // 
            this.day_of_the_week.Text = "Day of Week";
            this.day_of_the_week.Width = 115;
            // 
            // max_capacity
            // 
            this.max_capacity.Text = "Max Capacity";
            this.max_capacity.Width = 115;
            // 
            // seats_available
            // 
            this.seats_available.Text = "Seats Available";
            this.seats_available.Width = 120;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(267, 23);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(97, 27);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // enrollBtn
            // 
            this.enrollBtn.Location = new System.Drawing.Point(986, 23);
            this.enrollBtn.Name = "enrollBtn";
            this.enrollBtn.Size = new System.Drawing.Size(86, 27);
            this.enrollBtn.TabIndex = 4;
            this.enrollBtn.Text = "Enroll";
            this.enrollBtn.UseVisualStyleBackColor = true;
            // 
            // SearchClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 655);
            this.Controls.Add(this.enrollBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchClass";
            this.Text = "Search Class";
            this.Load += new System.EventHandler(this.SearchClass_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox searchBox;
        private Panel panel1;
        private Button searchBtn;
        private Button enrollBtn;
        private ListView courseList;
        private ColumnHeader course_name;
        private ColumnHeader section;
        private ColumnHeader start_time;
        private ColumnHeader end_time;
        private ColumnHeader day_of_the_week;
        private ColumnHeader max_capacity;
        private ColumnHeader seats_available;
        private ColumnHeader instructor;
    }
}