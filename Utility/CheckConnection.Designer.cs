namespace Utilities
{
    partial class CheckConnection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckConnection));
            this.textBoxConnectionString = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxConnectionString
            // 
            this.textBoxConnectionString.Location = new System.Drawing.Point(123, 9);
            this.textBoxConnectionString.Name = "textBoxConnectionString";
            this.textBoxConnectionString.Size = new System.Drawing.Size(525, 20);
            this.textBoxConnectionString.TabIndex = 0;
            this.textBoxConnectionString.Text = "Data Source=.\\SQLEXPRESS;Initial Catalog=BancsSimulator;Integrated Security=SSPI;" +
    "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection String:";
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(550, 35);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(98, 23);
            this.buttonCheck.TabIndex = 2;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonSync
            // 
            this.buttonSync.Location = new System.Drawing.Point(446, 35);
            this.buttonSync.Name = "buttonSync";
            this.buttonSync.Size = new System.Drawing.Size(98, 23);
            this.buttonSync.TabIndex = 3;
            this.buttonSync.Text = "Sync";
            this.buttonSync.UseVisualStyleBackColor = true;
            this.buttonSync.Click += new System.EventHandler(this.buttonSync_Click);
            // 
            // CheckConnection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 82);
            this.Controls.Add(this.buttonSync);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxConnectionString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(695, 120);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(695, 120);
            this.Name = "CheckConnection";
            this.Text = "CheckConnection";
            this.Load += new System.EventHandler(this.CheckConnection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxConnectionString;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonSync;
    }
}