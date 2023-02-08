namespace CMPT391
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(657, 280);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 94);
            this.button2.TabIndex = 0;
            this.button2.Text = "Login";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(435, 280);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PlaceholderText = "Username";
            this.UsernameBox.Size = new System.Drawing.Size(178, 26);
            this.UsernameBox.TabIndex = 1;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(435, 348);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.PlaceholderText = "Password";
            this.passwordBox.Size = new System.Drawing.Size(178, 26);
            this.passwordBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(328, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(582, 62);
            this.label1.TabIndex = 3;
            this.label1.Text = "School Registration Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(935, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 76);
            this.button1.TabIndex = 4;
            this.button1.Text = "Skip Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.ClientSize = new System.Drawing.Size(1182, 656);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.button2);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

   
        private Button button2;
        private TextBox UsernameBox;
        private TextBox passwordBox;
        private Label label1;
        private Button button1;
    }
}