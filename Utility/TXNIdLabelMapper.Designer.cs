namespace Utilities
{
    partial class TXNIdLabelMapper
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
            this.panelHead = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.panelHead.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.buttonSave);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelHead.Location = new System.Drawing.Point(0, 403);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(704, 44);
            this.panelHead.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(277, 9);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(129, 23);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save Values";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // TXNIdLabelMapper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(704, 447);
            this.Controls.Add(this.panelHead);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(720, 485);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(720, 485);
            this.Name = "TXNIdLabelMapper";
            this.Text = "TXNIdLabelMapper";
            this.Load += new System.EventHandler(this.TXNIdLabelMapper_Load);
            this.panelHead.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Button buttonSave;

    }
}