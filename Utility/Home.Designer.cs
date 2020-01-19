namespace Utilities
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.tableLayoutPanelHome = new System.Windows.Forms.TableLayoutPanel();
            this.buttonUI = new System.Windows.Forms.Button();
            this.buttonSQLServer = new System.Windows.Forms.Button();
            this.buttonTransactionEnq = new System.Windows.Forms.Button();
            this.buttonCheckConnection = new System.Windows.Forms.Button();
            this.buttonKillVSProcess = new System.Windows.Forms.Button();
            this.buttonPropertyGenerator = new System.Windows.Forms.Button();
            this.buttonXMLFormatter = new System.Windows.Forms.Button();
            this.buttonTXNLogMgr = new System.Windows.Forms.Button();
            this.tableLayoutPanelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelHome
            // 
            this.tableLayoutPanelHome.ColumnCount = 1;
            this.tableLayoutPanelHome.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHome.Controls.Add(this.buttonTXNLogMgr, 0, 7);
            this.tableLayoutPanelHome.Controls.Add(this.buttonUI, 0, 6);
            this.tableLayoutPanelHome.Controls.Add(this.buttonSQLServer, 0, 5);
            this.tableLayoutPanelHome.Controls.Add(this.buttonTransactionEnq, 0, 4);
            this.tableLayoutPanelHome.Controls.Add(this.buttonCheckConnection, 0, 3);
            this.tableLayoutPanelHome.Controls.Add(this.buttonKillVSProcess, 0, 2);
            this.tableLayoutPanelHome.Controls.Add(this.buttonPropertyGenerator, 0, 1);
            this.tableLayoutPanelHome.Controls.Add(this.buttonXMLFormatter, 0, 0);
            this.tableLayoutPanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHome.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelHome.Name = "tableLayoutPanelHome";
            this.tableLayoutPanelHome.RowCount = 8;
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.6648F));
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.6648F));
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.6648F));
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.6648F));
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.6648F));
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.39832F));
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.2342F));
            this.tableLayoutPanelHome.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.04348F));
            this.tableLayoutPanelHome.Size = new System.Drawing.Size(504, 427);
            this.tableLayoutPanelHome.TabIndex = 0;
            // 
            // buttonUI
            // 
            this.buttonUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUI.Location = new System.Drawing.Point(3, 321);
            this.buttonUI.Name = "buttonUI";
            this.buttonUI.Size = new System.Drawing.Size(498, 46);
            this.buttonUI.TabIndex = 13;
            this.buttonUI.Text = "UI Generator";
            this.buttonUI.UseVisualStyleBackColor = true;
            this.buttonUI.Click += new System.EventHandler(this.buttonUI_Click);
            // 
            // buttonSQLServer
            // 
            this.buttonSQLServer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonSQLServer.Location = new System.Drawing.Point(3, 273);
            this.buttonSQLServer.Name = "buttonSQLServer";
            this.buttonSQLServer.Size = new System.Drawing.Size(498, 42);
            this.buttonSQLServer.TabIndex = 12;
            this.buttonSQLServer.Text = "Find Local SQL Server Instance";
            this.buttonSQLServer.UseVisualStyleBackColor = true;
            this.buttonSQLServer.Click += new System.EventHandler(this.buttonSQLServer_Click);
            // 
            // buttonTransactionEnq
            // 
            this.buttonTransactionEnq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTransactionEnq.Location = new System.Drawing.Point(3, 219);
            this.buttonTransactionEnq.Name = "buttonTransactionEnq";
            this.buttonTransactionEnq.Size = new System.Drawing.Size(498, 48);
            this.buttonTransactionEnq.TabIndex = 11;
            this.buttonTransactionEnq.Text = "Transaction Enquiry";
            this.buttonTransactionEnq.UseVisualStyleBackColor = true;
            this.buttonTransactionEnq.Click += new System.EventHandler(this.buttonTransactionEnq_Click);
            // 
            // buttonCheckConnection
            // 
            this.buttonCheckConnection.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCheckConnection.Location = new System.Drawing.Point(3, 165);
            this.buttonCheckConnection.Name = "buttonCheckConnection";
            this.buttonCheckConnection.Size = new System.Drawing.Size(498, 48);
            this.buttonCheckConnection.TabIndex = 10;
            this.buttonCheckConnection.Text = "Check Connection";
            this.buttonCheckConnection.UseVisualStyleBackColor = true;
            this.buttonCheckConnection.Click += new System.EventHandler(this.buttonCheckConnection_Click);
            // 
            // buttonKillVSProcess
            // 
            this.buttonKillVSProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonKillVSProcess.Location = new System.Drawing.Point(3, 111);
            this.buttonKillVSProcess.Name = "buttonKillVSProcess";
            this.buttonKillVSProcess.Size = new System.Drawing.Size(498, 48);
            this.buttonKillVSProcess.TabIndex = 2;
            this.buttonKillVSProcess.Text = "Kill VS Process";
            this.buttonKillVSProcess.UseVisualStyleBackColor = true;
            this.buttonKillVSProcess.Click += new System.EventHandler(this.buttonKillVSProcess_Click);
            // 
            // buttonPropertyGenerator
            // 
            this.buttonPropertyGenerator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonPropertyGenerator.Location = new System.Drawing.Point(3, 57);
            this.buttonPropertyGenerator.Name = "buttonPropertyGenerator";
            this.buttonPropertyGenerator.Size = new System.Drawing.Size(498, 48);
            this.buttonPropertyGenerator.TabIndex = 1;
            this.buttonPropertyGenerator.Text = "Property Generator";
            this.buttonPropertyGenerator.UseVisualStyleBackColor = true;
            this.buttonPropertyGenerator.Click += new System.EventHandler(this.buttonPropertyGenerator_Click);
            // 
            // buttonXMLFormatter
            // 
            this.buttonXMLFormatter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonXMLFormatter.Location = new System.Drawing.Point(3, 3);
            this.buttonXMLFormatter.Name = "buttonXMLFormatter";
            this.buttonXMLFormatter.Size = new System.Drawing.Size(498, 48);
            this.buttonXMLFormatter.TabIndex = 0;
            this.buttonXMLFormatter.Text = "XML Formatter";
            this.buttonXMLFormatter.UseVisualStyleBackColor = true;
            this.buttonXMLFormatter.Click += new System.EventHandler(this.buttonXMLFormatter_Click);
            // 
            // buttonTXNLogMgr
            // 
            this.buttonTXNLogMgr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTXNLogMgr.Location = new System.Drawing.Point(3, 373);
            this.buttonTXNLogMgr.Name = "buttonTXNLogMgr";
            this.buttonTXNLogMgr.Size = new System.Drawing.Size(498, 51);
            this.buttonTXNLogMgr.TabIndex = 14;
            this.buttonTXNLogMgr.Text = "TXN Log Manager";
            this.buttonTXNLogMgr.UseVisualStyleBackColor = true;
            this.buttonTXNLogMgr.Click += new System.EventHandler(this.buttonTXNLogMgr_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 427);
            this.Controls.Add(this.tableLayoutPanelHome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 465);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.tableLayoutPanelHome.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHome;
        private System.Windows.Forms.Button buttonXMLFormatter;
        private System.Windows.Forms.Button buttonPropertyGenerator;
        private System.Windows.Forms.Button buttonKillVSProcess;
        private System.Windows.Forms.Button buttonCheckConnection;
        private System.Windows.Forms.Button buttonTransactionEnq;
        private System.Windows.Forms.Button buttonSQLServer;
        private System.Windows.Forms.Button buttonUI;
        private System.Windows.Forms.Button buttonTXNLogMgr;
    }
}