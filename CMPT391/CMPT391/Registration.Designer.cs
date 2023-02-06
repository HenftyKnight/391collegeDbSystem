namespace CMPT391
{
    partial class Registration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.classBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.date = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(44, 56);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 577);
            this.panel1.TabIndex = 0;
            // 
            // classBtn
            // 
            this.classBtn.Location = new System.Drawing.Point(243, 14);
            this.classBtn.Name = "classBtn";
            this.classBtn.Size = new System.Drawing.Size(153, 26);
            this.classBtn.TabIndex = 1;
            this.classBtn.Text = "My Classes";
            this.classBtn.UseVisualStyleBackColor = true;
            this.classBtn.Click += new System.EventHandler(this.classBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(66, 14);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(153, 26);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "Search Classes";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(849, 21);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(38, 19);
            this.date.TabIndex = 3;
            this.date.Text = "Date";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(1025, 21);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(38, 19);
            this.time.TabIndex = 4;
            this.time.Text = "Time";
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 656);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.classBtn);
            this.Controls.Add(this.panel1);
            this.Name = "Registration";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button classBtn;
        private Button searchBtn;
        private Label date;
        private Label time;
    }
}