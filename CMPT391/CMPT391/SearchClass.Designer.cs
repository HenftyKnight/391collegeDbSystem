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
            this.searchBtn = new System.Windows.Forms.Button();
            this.enrollBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // searchBox
            // 
            this.searchBox.Location = new System.Drawing.Point(119, 22);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(142, 26);
            this.searchBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 497);
            this.panel1.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(267, 22);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(97, 26);
            this.searchBtn.TabIndex = 3;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // enrollBtn
            // 
            this.enrollBtn.Location = new System.Drawing.Point(986, 22);
            this.enrollBtn.Name = "enrollBtn";
            this.enrollBtn.Size = new System.Drawing.Size(86, 26);
            this.enrollBtn.TabIndex = 4;
            this.enrollBtn.Text = "Enroll";
            this.enrollBtn.UseVisualStyleBackColor = true;
            // 
            // SearchClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 622);
            this.Controls.Add(this.enrollBtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Name = "SearchClass";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox searchBox;
        private Panel panel1;
        private Button searchBtn;
        private Button enrollBtn;
    }
}