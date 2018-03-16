namespace Client
{
    partial class Login
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
            this.tUserName = new System.Windows.Forms.TextBox();
            this.bLogIn = new System.Windows.Forms.Button();
            this.tServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tUserName
            // 
            this.tUserName.Location = new System.Drawing.Point(70, 106);
            this.tUserName.Name = "tUserName";
            this.tUserName.Size = new System.Drawing.Size(100, 20);
            this.tUserName.TabIndex = 0;
            this.tUserName.TextChanged += new System.EventHandler(this.tUserName_TextChanged);
            // 
            // bLogIn
            // 
            this.bLogIn.Location = new System.Drawing.Point(195, 189);
            this.bLogIn.Name = "bLogIn";
            this.bLogIn.Size = new System.Drawing.Size(75, 23);
            this.bLogIn.TabIndex = 1;
            this.bLogIn.Text = "LogIn";
            this.bLogIn.UseVisualStyleBackColor = true;
            this.bLogIn.Click += new System.EventHandler(this.bLogIn_Click);
            // 
            // tServerIP
            // 
            this.tServerIP.Location = new System.Drawing.Point(70, 132);
            this.tServerIP.Name = "tServerIP";
            this.tServerIP.Size = new System.Drawing.Size(100, 20);
            this.tServerIP.TabIndex = 2;
            this.tServerIP.TextChanged += new System.EventHandler(this.tServerIP_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "ServerIP:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(26, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tServerIP);
            this.Controls.Add(this.bLogIn);
            this.Controls.Add(this.tUserName);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tUserName;
        private System.Windows.Forms.Button bLogIn;
        private System.Windows.Forms.TextBox tServerIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}