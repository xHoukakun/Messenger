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
            this.bEinloggen = new System.Windows.Forms.Button();
            this.tEinloggen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bEinloggen
            // 
            this.bEinloggen.Location = new System.Drawing.Point(275, 162);
            this.bEinloggen.Name = "bEinloggen";
            this.bEinloggen.Size = new System.Drawing.Size(75, 23);
            this.bEinloggen.TabIndex = 0;
            this.bEinloggen.Text = "Einloggen";
            this.bEinloggen.UseVisualStyleBackColor = true;
            // 
            // tEinloggen
            // 
            this.tEinloggen.Location = new System.Drawing.Point(99, 106);
            this.tEinloggen.Name = "tEinloggen";
            this.tEinloggen.Size = new System.Drawing.Size(173, 20);
            this.tEinloggen.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 251);
            this.Controls.Add(this.tEinloggen);
            this.Controls.Add(this.bEinloggen);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bEinloggen;
        private System.Windows.Forms.TextBox tEinloggen;
    }
}