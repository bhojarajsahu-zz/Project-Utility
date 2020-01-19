namespace Utilities
{
    partial class Utility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Utility));
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttonClearSource = new System.Windows.Forms.Button();
            this.buttonCopyS = new System.Windows.Forms.Button();
            this.buttonCopyD = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBoxSource = new System.Windows.Forms.TextBox();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelControl.SuspendLayout();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl
            // 
            this.panelControl.Controls.Add(this.statusStrip);
            this.panelControl.Controls.Add(this.buttonClearSource);
            this.panelControl.Controls.Add(this.buttonCopyS);
            this.panelControl.Controls.Add(this.buttonCopyD);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl.Location = new System.Drawing.Point(0, 403);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(1161, 75);
            this.panelControl.TabIndex = 0;
            // 
            // buttonClearSource
            // 
            this.buttonClearSource.Location = new System.Drawing.Point(258, 8);
            this.buttonClearSource.Name = "buttonClearSource";
            this.buttonClearSource.Size = new System.Drawing.Size(240, 37);
            this.buttonClearSource.TabIndex = 2;
            this.buttonClearSource.Text = "Clear Source Box";
            this.buttonClearSource.UseVisualStyleBackColor = true;
            this.buttonClearSource.Click += new System.EventHandler(this.buttonClearSource_Click);
            // 
            // buttonCopyS
            // 
            this.buttonCopyS.Location = new System.Drawing.Point(12, 8);
            this.buttonCopyS.Name = "buttonCopyS";
            this.buttonCopyS.Size = new System.Drawing.Size(240, 37);
            this.buttonCopyS.TabIndex = 1;
            this.buttonCopyS.Text = "Copy Source To Clipboard";
            this.buttonCopyS.UseVisualStyleBackColor = true;
            this.buttonCopyS.Click += new System.EventHandler(this.buttonCopyS_Click);
            // 
            // buttonCopyD
            // 
            this.buttonCopyD.Location = new System.Drawing.Point(711, 8);
            this.buttonCopyD.Name = "buttonCopyD";
            this.buttonCopyD.Size = new System.Drawing.Size(240, 37);
            this.buttonCopyD.TabIndex = 0;
            this.buttonCopyD.Text = "Copy Formatted XML To Clipboard";
            this.buttonCopyD.UseVisualStyleBackColor = true;
            this.buttonCopyD.Click += new System.EventHandler(this.buttonCopyD_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.splitContainer1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1161, 403);
            this.panelMain.TabIndex = 1;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSource);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxDestination);
            this.splitContainer1.Size = new System.Drawing.Size(1161, 403);
            this.splitContainer1.SplitterDistance = 505;
            this.splitContainer1.TabIndex = 0;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSource.Location = new System.Drawing.Point(0, 0);
            this.textBoxSource.Multiline = true;
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxSource.Size = new System.Drawing.Size(505, 403);
            this.textBoxSource.TabIndex = 2;
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDestination.Location = new System.Drawing.Point(0, 0);
            this.textBoxDestination.Multiline = true;
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.ReadOnly = true;
            this.textBoxDestination.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDestination.Size = new System.Drawing.Size(652, 403);
            this.textBoxDestination.TabIndex = 1;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 53);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1161, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // Utility
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 478);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Utility";
            this.Text = "XML Formatting";
            this.Load += new System.EventHandler(this.Utility_Load);
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelMain.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControl;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox textBoxSource;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Button buttonCopyD;
        private System.Windows.Forms.Button buttonCopyS;
        private System.Windows.Forms.Button buttonClearSource;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;

    }
}

