namespace Utilities
{
    partial class TransactionEnquiry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TransactionEnquiry));
            this.panelSearch = new System.Windows.Forms.Panel();
            this.groupBoxDatafile = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSyncDb = new System.Windows.Forms.Button();
            this.textBoxFileLoc = new System.Windows.Forms.TextBox();
            this.labelFileLoc = new System.Windows.Forms.Label();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.textBoxSRX = new System.Windows.Forms.TextBox();
            this.labelSRX = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSTX = new System.Windows.Forms.TextBox();
            this.labelSTX = new System.Windows.Forms.Label();
            this.textBoxSName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.panelAddNew = new System.Windows.Forms.Panel();
            this.groupBoxNewTransaction = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxRX = new System.Windows.Forms.TextBox();
            this.labelNRX = new System.Windows.Forms.Label();
            this.textBoxTX = new System.Windows.Forms.TextBox();
            this.labelNName = new System.Windows.Forms.Label();
            this.textBoxTransactionName = new System.Windows.Forms.TextBox();
            this.labelNTX = new System.Windows.Forms.Label();
            this.panelAllTXN = new System.Windows.Forms.Panel();
            this.groupBoxAllTransaction = new System.Windows.Forms.GroupBox();
            this.dataGridViewAllTXN = new System.Windows.Forms.DataGridView();
            this.panelSearchResult = new System.Windows.Forms.Panel();
            this.groupBoxSearchResult = new System.Windows.Forms.GroupBox();
            this.dataGridViewSearchResult = new System.Windows.Forms.DataGridView();
            this.panelSearch.SuspendLayout();
            this.groupBoxDatafile.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.panelAddNew.SuspendLayout();
            this.groupBoxNewTransaction.SuspendLayout();
            this.panelAllTXN.SuspendLayout();
            this.groupBoxAllTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllTXN)).BeginInit();
            this.panelSearchResult.SuspendLayout();
            this.groupBoxSearchResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.groupBoxDatafile);
            this.panelSearch.Controls.Add(this.groupBoxSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(0, 0);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(844, 111);
            this.panelSearch.TabIndex = 1;
            // 
            // groupBoxDatafile
            // 
            this.groupBoxDatafile.Controls.Add(this.label1);
            this.groupBoxDatafile.Controls.Add(this.buttonSyncDb);
            this.groupBoxDatafile.Controls.Add(this.textBoxFileLoc);
            this.groupBoxDatafile.Controls.Add(this.labelFileLoc);
            this.groupBoxDatafile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDatafile.Location = new System.Drawing.Point(0, 57);
            this.groupBoxDatafile.Name = "groupBoxDatafile";
            this.groupBoxDatafile.Size = new System.Drawing.Size(844, 54);
            this.groupBoxDatafile.TabIndex = 1;
            this.groupBoxDatafile.TabStop = false;
            this.groupBoxDatafile.Text = "Datafile Location";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(323, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "** Check data file location";
            // 
            // buttonSyncDb
            // 
            this.buttonSyncDb.Location = new System.Drawing.Point(669, 19);
            this.buttonSyncDb.Name = "buttonSyncDb";
            this.buttonSyncDb.Size = new System.Drawing.Size(134, 23);
            this.buttonSyncDb.TabIndex = 22;
            this.buttonSyncDb.Text = "Sync From DB";
            this.buttonSyncDb.UseVisualStyleBackColor = true;
            this.buttonSyncDb.Click += new System.EventHandler(this.buttonSyncDb_Click);
            // 
            // textBoxFileLoc
            // 
            this.textBoxFileLoc.Location = new System.Drawing.Point(117, 19);
            this.textBoxFileLoc.Name = "textBoxFileLoc";
            this.textBoxFileLoc.Size = new System.Drawing.Size(200, 20);
            this.textBoxFileLoc.TabIndex = 21;
            this.textBoxFileLoc.Text = "C:\\Transaction.xml";
            this.textBoxFileLoc.TextChanged += new System.EventHandler(this.textBoxFileLoc_TextChanged);
            // 
            // labelFileLoc
            // 
            this.labelFileLoc.AutoSize = true;
            this.labelFileLoc.Location = new System.Drawing.Point(21, 22);
            this.labelFileLoc.Name = "labelFileLoc";
            this.labelFileLoc.Size = new System.Drawing.Size(90, 13);
            this.labelFileLoc.TabIndex = 20;
            this.labelFileLoc.Text = "Datafile Location:";
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.textBoxSRX);
            this.groupBoxSearch.Controls.Add(this.labelSRX);
            this.groupBoxSearch.Controls.Add(this.buttonSearch);
            this.groupBoxSearch.Controls.Add(this.textBoxSTX);
            this.groupBoxSearch.Controls.Add(this.labelSTX);
            this.groupBoxSearch.Controls.Add(this.textBoxSName);
            this.groupBoxSearch.Controls.Add(this.labelName);
            this.groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(844, 57);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // textBoxSRX
            // 
            this.textBoxSRX.Location = new System.Drawing.Point(548, 17);
            this.textBoxSRX.Name = "textBoxSRX";
            this.textBoxSRX.Size = new System.Drawing.Size(88, 20);
            this.textBoxSRX.TabIndex = 21;
            this.textBoxSRX.TextChanged += new System.EventHandler(this.textBoxSRX_TextChanged);
            // 
            // labelSRX
            // 
            this.labelSRX.AutoSize = true;
            this.labelSRX.Location = new System.Drawing.Point(517, 20);
            this.labelSRX.Name = "labelSRX";
            this.labelSRX.Size = new System.Drawing.Size(25, 13);
            this.labelSRX.TabIndex = 20;
            this.labelSRX.Text = "RX:";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(669, 15);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 19;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSTX
            // 
            this.textBoxSTX.Location = new System.Drawing.Point(395, 17);
            this.textBoxSTX.Name = "textBoxSTX";
            this.textBoxSTX.Size = new System.Drawing.Size(88, 20);
            this.textBoxSTX.TabIndex = 18;
            this.textBoxSTX.TextChanged += new System.EventHandler(this.textBoxSTX_TextChanged);
            // 
            // labelSTX
            // 
            this.labelSTX.AutoSize = true;
            this.labelSTX.Location = new System.Drawing.Point(365, 20);
            this.labelSTX.Name = "labelSTX";
            this.labelSTX.Size = new System.Drawing.Size(24, 13);
            this.labelSTX.TabIndex = 17;
            this.labelSTX.Text = "TX:";
            // 
            // textBoxSName
            // 
            this.textBoxSName.Location = new System.Drawing.Point(117, 17);
            this.textBoxSName.Name = "textBoxSName";
            this.textBoxSName.Size = new System.Drawing.Size(200, 20);
            this.textBoxSName.TabIndex = 16;
            this.textBoxSName.TextChanged += new System.EventHandler(this.textBoxSName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(73, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(38, 13);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "Name:";
            // 
            // panelAddNew
            // 
            this.panelAddNew.Controls.Add(this.groupBoxNewTransaction);
            this.panelAddNew.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelAddNew.Location = new System.Drawing.Point(0, 111);
            this.panelAddNew.Name = "panelAddNew";
            this.panelAddNew.Size = new System.Drawing.Size(273, 241);
            this.panelAddNew.TabIndex = 2;
            // 
            // groupBoxNewTransaction
            // 
            this.groupBoxNewTransaction.Controls.Add(this.buttonSave);
            this.groupBoxNewTransaction.Controls.Add(this.textBoxRX);
            this.groupBoxNewTransaction.Controls.Add(this.labelNRX);
            this.groupBoxNewTransaction.Controls.Add(this.textBoxTX);
            this.groupBoxNewTransaction.Controls.Add(this.labelNName);
            this.groupBoxNewTransaction.Controls.Add(this.textBoxTransactionName);
            this.groupBoxNewTransaction.Controls.Add(this.labelNTX);
            this.groupBoxNewTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxNewTransaction.Location = new System.Drawing.Point(0, 0);
            this.groupBoxNewTransaction.Name = "groupBoxNewTransaction";
            this.groupBoxNewTransaction.Size = new System.Drawing.Size(273, 241);
            this.groupBoxNewTransaction.TabIndex = 3;
            this.groupBoxNewTransaction.TabStop = false;
            this.groupBoxNewTransaction.Text = "New Transaction";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(168, 191);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 20;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxRX
            // 
            this.textBoxRX.Location = new System.Drawing.Point(43, 148);
            this.textBoxRX.MaxLength = 6;
            this.textBoxRX.Name = "textBoxRX";
            this.textBoxRX.Size = new System.Drawing.Size(200, 20);
            this.textBoxRX.TabIndex = 15;
            // 
            // labelNRX
            // 
            this.labelNRX.AutoSize = true;
            this.labelNRX.Location = new System.Drawing.Point(26, 129);
            this.labelNRX.Name = "labelNRX";
            this.labelNRX.Size = new System.Drawing.Size(25, 13);
            this.labelNRX.TabIndex = 14;
            this.labelNRX.Text = "RX:";
            // 
            // textBoxTX
            // 
            this.textBoxTX.Location = new System.Drawing.Point(43, 103);
            this.textBoxTX.MaxLength = 6;
            this.textBoxTX.Name = "textBoxTX";
            this.textBoxTX.Size = new System.Drawing.Size(200, 20);
            this.textBoxTX.TabIndex = 13;
            // 
            // labelNName
            // 
            this.labelNName.AutoSize = true;
            this.labelNName.Location = new System.Drawing.Point(23, 38);
            this.labelNName.Name = "labelNName";
            this.labelNName.Size = new System.Drawing.Size(97, 13);
            this.labelNName.TabIndex = 10;
            this.labelNName.Text = "Transaction Name:";
            // 
            // textBoxTransactionName
            // 
            this.textBoxTransactionName.Location = new System.Drawing.Point(43, 56);
            this.textBoxTransactionName.Name = "textBoxTransactionName";
            this.textBoxTransactionName.Size = new System.Drawing.Size(200, 20);
            this.textBoxTransactionName.TabIndex = 11;
            // 
            // labelNTX
            // 
            this.labelNTX.AutoSize = true;
            this.labelNTX.Location = new System.Drawing.Point(23, 81);
            this.labelNTX.Name = "labelNTX";
            this.labelNTX.Size = new System.Drawing.Size(24, 13);
            this.labelNTX.TabIndex = 12;
            this.labelNTX.Text = "TX:";
            // 
            // panelAllTXN
            // 
            this.panelAllTXN.Controls.Add(this.groupBoxAllTransaction);
            this.panelAllTXN.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelAllTXN.Location = new System.Drawing.Point(550, 111);
            this.panelAllTXN.Name = "panelAllTXN";
            this.panelAllTXN.Size = new System.Drawing.Size(294, 241);
            this.panelAllTXN.TabIndex = 4;
            // 
            // groupBoxAllTransaction
            // 
            this.groupBoxAllTransaction.Controls.Add(this.dataGridViewAllTXN);
            this.groupBoxAllTransaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxAllTransaction.Location = new System.Drawing.Point(0, 0);
            this.groupBoxAllTransaction.Name = "groupBoxAllTransaction";
            this.groupBoxAllTransaction.Size = new System.Drawing.Size(294, 241);
            this.groupBoxAllTransaction.TabIndex = 2;
            this.groupBoxAllTransaction.TabStop = false;
            this.groupBoxAllTransaction.Text = "All Transactions";
            // 
            // dataGridViewAllTXN
            // 
            this.dataGridViewAllTXN.AllowUserToAddRows = false;
            this.dataGridViewAllTXN.AllowUserToDeleteRows = false;
            this.dataGridViewAllTXN.AllowUserToResizeRows = false;
            this.dataGridViewAllTXN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAllTXN.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewAllTXN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAllTXN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAllTXN.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewAllTXN.Name = "dataGridViewAllTXN";
            this.dataGridViewAllTXN.ReadOnly = true;
            this.dataGridViewAllTXN.RowHeadersVisible = false;
            this.dataGridViewAllTXN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAllTXN.Size = new System.Drawing.Size(288, 222);
            this.dataGridViewAllTXN.TabIndex = 0;
            // 
            // panelSearchResult
            // 
            this.panelSearchResult.Controls.Add(this.groupBoxSearchResult);
            this.panelSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSearchResult.Location = new System.Drawing.Point(273, 111);
            this.panelSearchResult.Name = "panelSearchResult";
            this.panelSearchResult.Size = new System.Drawing.Size(277, 241);
            this.panelSearchResult.TabIndex = 5;
            // 
            // groupBoxSearchResult
            // 
            this.groupBoxSearchResult.Controls.Add(this.dataGridViewSearchResult);
            this.groupBoxSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSearchResult.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearchResult.Name = "groupBoxSearchResult";
            this.groupBoxSearchResult.Size = new System.Drawing.Size(277, 241);
            this.groupBoxSearchResult.TabIndex = 1;
            this.groupBoxSearchResult.TabStop = false;
            this.groupBoxSearchResult.Text = "Search Result";
            // 
            // dataGridViewSearchResult
            // 
            this.dataGridViewSearchResult.AllowUserToAddRows = false;
            this.dataGridViewSearchResult.AllowUserToDeleteRows = false;
            this.dataGridViewSearchResult.AllowUserToResizeRows = false;
            this.dataGridViewSearchResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchResult.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewSearchResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSearchResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSearchResult.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewSearchResult.Name = "dataGridViewSearchResult";
            this.dataGridViewSearchResult.ReadOnly = true;
            this.dataGridViewSearchResult.RowHeadersVisible = false;
            this.dataGridViewSearchResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSearchResult.Size = new System.Drawing.Size(271, 222);
            this.dataGridViewSearchResult.TabIndex = 1;
            // 
            // TransactionEnquiry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 352);
            this.Controls.Add(this.panelSearchResult);
            this.Controls.Add(this.panelAllTXN);
            this.Controls.Add(this.panelAddNew);
            this.Controls.Add(this.panelSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(860, 390);
            this.MinimizeBox = false;
            this.Name = "TransactionEnquiry";
            this.Text = "TransactionEnquiry";
            this.Load += new System.EventHandler(this.TransactionEnquiry_Load);
            this.panelSearch.ResumeLayout(false);
            this.groupBoxDatafile.ResumeLayout(false);
            this.groupBoxDatafile.PerformLayout();
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.panelAddNew.ResumeLayout(false);
            this.groupBoxNewTransaction.ResumeLayout(false);
            this.groupBoxNewTransaction.PerformLayout();
            this.panelAllTXN.ResumeLayout(false);
            this.groupBoxAllTransaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAllTXN)).EndInit();
            this.panelSearchResult.ResumeLayout(false);
            this.groupBoxSearchResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Panel panelAddNew;
        private System.Windows.Forms.TextBox textBoxTX;
        private System.Windows.Forms.Label labelNTX;
        private System.Windows.Forms.TextBox textBoxTransactionName;
        private System.Windows.Forms.Label labelNName;
        private System.Windows.Forms.Panel panelAllTXN;
        private System.Windows.Forms.Panel panelSearchResult;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSTX;
        private System.Windows.Forms.Label labelSTX;
        private System.Windows.Forms.TextBox textBoxSName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxNewTransaction;
        private System.Windows.Forms.TextBox textBoxRX;
        private System.Windows.Forms.Label labelNRX;
        private System.Windows.Forms.GroupBox groupBoxAllTransaction;
        private System.Windows.Forms.GroupBox groupBoxSearchResult;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewAllTXN;
        private System.Windows.Forms.TextBox textBoxFileLoc;
        private System.Windows.Forms.Label labelFileLoc;
        private System.Windows.Forms.GroupBox groupBoxDatafile;
        private System.Windows.Forms.DataGridView dataGridViewSearchResult;
        private System.Windows.Forms.TextBox textBoxSRX;
        private System.Windows.Forms.Label labelSRX;
        private System.Windows.Forms.Button buttonSyncDb;
        private System.Windows.Forms.Label label1;
    }
}