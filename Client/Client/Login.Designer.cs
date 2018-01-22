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
            this.SuspendLayout();
            // 
            // tUserName
            // 
            this.tUserName.Location = new System.Drawing.Point(81, 106);
            this.tUserName.Name = "tUserName";
            this.tUserName.Size = new System.Drawing.Size(100, 20);
            this.tUserName.TabIndex = 0;
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
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bLogIn);
            this.Controls.Add(this.tUserName);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tUserName;
        private System.Windows.Forms.Button bLogIn;
    }
}