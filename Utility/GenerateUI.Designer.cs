namespace Utilities
{
    partial class GenerateUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateUI));
            this.panelHead = new System.Windows.Forms.Panel();
            this.checkBoxAuto = new System.Windows.Forms.CheckBox();
            this.buttonUpdateUI = new System.Windows.Forms.Button();
            this.buttonChromeView = new System.Windows.Forms.Button();
            this.checkBoxTryNow = new System.Windows.Forms.CheckBox();
            this.checkBoxCodeViewPane = new System.Windows.Forms.CheckBox();
            this.checkBoxViewPane = new System.Windows.Forms.CheckBox();
            this.comboBoxTXRX = new System.Windows.Forms.ComboBox();
            this.labelTXRX = new System.Windows.Forms.Label();
            this.comboBoxReadOnly = new System.Windows.Forms.ComboBox();
            this.labelRead = new System.Windows.Forms.Label();
            this.labelExample = new System.Windows.Forms.Label();
            this.labelExam = new System.Windows.Forms.Label();
            this.textBoxColumn = new System.Windows.Forms.TextBox();
            this.labelColumns = new System.Windows.Forms.Label();
            this.buttonGenerateUI = new System.Windows.Forms.Button();
            this.buttonCopy = new System.Windows.Forms.Button();
            this.labelFile = new System.Windows.Forms.Label();
            this.comboBoxControlType = new System.Windows.Forms.ComboBox();
            this.labelControlType = new System.Windows.Forms.Label();
            this.labelUI = new System.Windows.Forms.Label();
            this.comboBoxUI = new System.Windows.Forms.ComboBox();
            this.splitContainerUIDesigner = new System.Windows.Forms.SplitContainer();
            this.webBrowserUI = new System.Windows.Forms.WebBrowser();
            this.textBoxDestination = new System.Windows.Forms.TextBox();
            this.openFileDialogFileLocation = new System.Windows.Forms.OpenFileDialog();
            this.comboBoxXMLType = new System.Windows.Forms.ComboBox();
            this.labelXMLType = new System.Windows.Forms.Label();
            this.panelButtonSet1 = new System.Windows.Forms.Panel();
            this.textBoxXMLViewer = new System.Windows.Forms.TextBox();
            this.panelHead.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUIDesigner)).BeginInit();
            this.splitContainerUIDesigner.Panel1.SuspendLayout();
            this.splitContainerUIDesigner.Panel2.SuspendLayout();
            this.splitContainerUIDesigner.SuspendLayout();
            this.panelButtonSet1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHead
            // 
            this.panelHead.Controls.Add(this.panelButtonSet1);
            this.panelHead.Controls.Add(this.comboBoxXMLType);
            this.panelHead.Controls.Add(this.labelXMLType);
            this.panelHead.Controls.Add(this.checkBoxAuto);
            this.panelHead.Controls.Add(this.buttonUpdateUI);
            this.panelHead.Controls.Add(this.checkBoxTryNow);
            this.panelHead.Controls.Add(this.comboBoxTXRX);
            this.panelHead.Controls.Add(this.labelTXRX);
            this.panelHead.Controls.Add(this.comboBoxReadOnly);
            this.panelHead.Controls.Add(this.labelRead);
            this.panelHead.Controls.Add(this.labelExample);
            this.panelHead.Controls.Add(this.labelExam);
            this.panelHead.Controls.Add(this.textBoxColumn);
            this.panelHead.Controls.Add(this.labelColumns);
            this.panelHead.Controls.Add(this.buttonGenerateUI);
            this.panelHead.Controls.Add(this.labelFile);
            this.panelHead.Controls.Add(this.comboBoxControlType);
            this.panelHead.Controls.Add(this.labelControlType);
            this.panelHead.Controls.Add(this.labelUI);
            this.panelHead.Controls.Add(this.comboBoxUI);
            this.panelHead.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHead.Location = new System.Drawing.Point(0, 0);
            this.panelHead.Name = "panelHead";
            this.panelHead.Size = new System.Drawing.Size(929, 139);
            this.panelHead.TabIndex = 1;
            // 
            // checkBoxAuto
            // 
            this.checkBoxAuto.AutoSize = true;
            this.checkBoxAuto.Location = new System.Drawing.Point(189, 68);
            this.checkBoxAuto.Name = "checkBoxAuto";
            this.checkBoxAuto.Size = new System.Drawing.Size(48, 17);
            this.checkBoxAuto.TabIndex = 36;
            this.checkBoxAuto.Text = "Auto";
            this.checkBoxAuto.UseVisualStyleBackColor = true;
            this.checkBoxAuto.CheckedChanged += new System.EventHandler(this.checkBoxAuto_CheckedChanged);
            // 
            // buttonUpdateUI
            // 
            this.buttonUpdateUI.Enabled = false;
            this.buttonUpdateUI.Location = new System.Drawing.Point(530, 104);
            this.buttonUpdateUI.Name = "buttonUpdateUI";
            this.buttonUpdateUI.Size = new System.Drawing.Size(83, 24);
            this.buttonUpdateUI.TabIndex = 35;
            this.buttonUpdateUI.Text = "Update UI";
            this.buttonUpdateUI.UseVisualStyleBackColor = true;
            this.buttonUpdateUI.Click += new System.EventHandler(this.buttonUpdateUI_Click);
            // 
            // buttonChromeView
            // 
            this.buttonChromeView.Location = new System.Drawing.Point(18, 6);
            this.buttonChromeView.Name = "buttonChromeView";
            this.buttonChromeView.Size = new System.Drawing.Size(220, 49);
            this.buttonChromeView.TabIndex = 34;
            this.buttonChromeView.Text = "View In Chrome";
            this.buttonChromeView.UseVisualStyleBackColor = true;
            this.buttonChromeView.Click += new System.EventHandler(this.buttonChromeView_Click);
            // 
            // checkBoxTryNow
            // 
            this.checkBoxTryNow.AutoSize = true;
            this.checkBoxTryNow.Location = new System.Drawing.Point(468, 109);
            this.checkBoxTryNow.Name = "checkBoxTryNow";
            this.checkBoxTryNow.Size = new System.Drawing.Size(66, 17);
            this.checkBoxTryNow.TabIndex = 33;
            this.checkBoxTryNow.Text = "Try Now";
            this.checkBoxTryNow.UseVisualStyleBackColor = true;
            this.checkBoxTryNow.CheckedChanged += new System.EventHandler(this.checkBoxTryNow_CheckedChanged);
            // 
            // checkBoxCodeViewPane
            // 
            this.checkBoxCodeViewPane.AutoSize = true;
            this.checkBoxCodeViewPane.Checked = true;
            this.checkBoxCodeViewPane.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCodeViewPane.Location = new System.Drawing.Point(131, 65);
            this.checkBoxCodeViewPane.Name = "checkBoxCodeViewPane";
            this.checkBoxCodeViewPane.Size = new System.Drawing.Size(107, 17);
            this.checkBoxCodeViewPane.TabIndex = 32;
            this.checkBoxCodeViewPane.Text = "Code View Panel";
            this.checkBoxCodeViewPane.UseVisualStyleBackColor = true;
            this.checkBoxCodeViewPane.CheckedChanged += new System.EventHandler(this.checkBoxCodeViewPane_CheckedChanged);
            // 
            // checkBoxViewPane
            // 
            this.checkBoxViewPane.AutoSize = true;
            this.checkBoxViewPane.Checked = true;
            this.checkBoxViewPane.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxViewPane.Location = new System.Drawing.Point(18, 65);
            this.checkBoxViewPane.Name = "checkBoxViewPane";
            this.checkBoxViewPane.Size = new System.Drawing.Size(103, 17);
            this.checkBoxViewPane.TabIndex = 32;
            this.checkBoxViewPane.Text = "Html View Panel";
            this.checkBoxViewPane.UseVisualStyleBackColor = true;
            this.checkBoxViewPane.CheckedChanged += new System.EventHandler(this.checkBoxViewPane_CheckedChanged);
            // 
            // comboBoxTXRX
            // 
            this.comboBoxTXRX.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTXRX.FormattingEnabled = true;
            this.comboBoxTXRX.Items.AddRange(new object[] {
            "TX",
            "RX"});
            this.comboBoxTXRX.Location = new System.Drawing.Point(313, 11);
            this.comboBoxTXRX.Name = "comboBoxTXRX";
            this.comboBoxTXRX.Size = new System.Drawing.Size(77, 21);
            this.comboBoxTXRX.TabIndex = 30;
            // 
            // labelTXRX
            // 
            this.labelTXRX.AutoSize = true;
            this.labelTXRX.Location = new System.Drawing.Point(253, 14);
            this.labelTXRX.Name = "labelTXRX";
            this.labelTXRX.Size = new System.Drawing.Size(44, 13);
            this.labelTXRX.TabIndex = 29;
            this.labelTXRX.Text = "TX/RX:";
            // 
            // comboBoxReadOnly
            // 
            this.comboBoxReadOnly.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReadOnly.FormattingEnabled = true;
            this.comboBoxReadOnly.Items.AddRange(new object[] {
            "true",
            "false"});
            this.comboBoxReadOnly.Location = new System.Drawing.Point(313, 39);
            this.comboBoxReadOnly.Name = "comboBoxReadOnly";
            this.comboBoxReadOnly.Size = new System.Drawing.Size(77, 21);
            this.comboBoxReadOnly.TabIndex = 26;
            // 
            // labelRead
            // 
            this.labelRead.AutoSize = true;
            this.labelRead.Location = new System.Drawing.Point(253, 42);
            this.labelRead.Name = "labelRead";
            this.labelRead.Size = new System.Drawing.Size(60, 13);
            this.labelRead.TabIndex = 22;
            this.labelRead.Text = "Read Only:";
            // 
            // labelExample
            // 
            this.labelExample.AutoSize = true;
            this.labelExample.Location = new System.Drawing.Point(71, 113);
            this.labelExample.Name = "labelExample";
            this.labelExample.Size = new System.Drawing.Size(50, 13);
            this.labelExample.TabIndex = 19;
            this.labelExample.Text = "Example:";
            // 
            // labelExam
            // 
            this.labelExam.AutoSize = true;
            this.labelExam.Location = new System.Drawing.Point(15, 113);
            this.labelExam.Name = "labelExam";
            this.labelExam.Size = new System.Drawing.Size(50, 13);
            this.labelExam.TabIndex = 18;
            this.labelExam.Text = "Example:";
            // 
            // textBoxColumn
            // 
            this.textBoxColumn.Location = new System.Drawing.Point(106, 66);
            this.textBoxColumn.Name = "textBoxColumn";
            this.textBoxColumn.Size = new System.Drawing.Size(77, 20);
            this.textBoxColumn.TabIndex = 17;
            this.textBoxColumn.Text = "3";
            // 
            // labelColumns
            // 
            this.labelColumns.AutoSize = true;
            this.labelColumns.Location = new System.Drawing.Point(46, 69);
            this.labelColumns.Name = "labelColumns";
            this.labelColumns.Size = new System.Drawing.Size(50, 13);
            this.labelColumns.TabIndex = 16;
            this.labelColumns.Text = "Columns:";
            // 
            // buttonGenerateUI
            // 
            this.buttonGenerateUI.Location = new System.Drawing.Point(427, 11);
            this.buttonGenerateUI.Name = "buttonGenerateUI";
            this.buttonGenerateUI.Size = new System.Drawing.Size(107, 74);
            this.buttonGenerateUI.TabIndex = 14;
            this.buttonGenerateUI.Text = "Generate UI";
            this.buttonGenerateUI.UseVisualStyleBackColor = true;
            this.buttonGenerateUI.Click += new System.EventHandler(this.buttonGenerateUI_Click);
            // 
            // buttonCopy
            // 
            this.buttonCopy.Location = new System.Drawing.Point(18, 102);
            this.buttonCopy.Name = "buttonCopy";
            this.buttonCopy.Size = new System.Drawing.Size(220, 29);
            this.buttonCopy.TabIndex = 9;
            this.buttonCopy.Text = "Copy to Clipboard";
            this.buttonCopy.UseVisualStyleBackColor = true;
            this.buttonCopy.Click += new System.EventHandler(this.buttonCopy_Click);
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelFile.Location = new System.Drawing.Point(15, 90);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(67, 13);
            this.labelFile.TabIndex = 8;
            this.labelFile.Text = "File Location";
            this.labelFile.Click += new System.EventHandler(this.labelFile_Click);
            // 
            // comboBoxControlType
            // 
            this.comboBoxControlType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxControlType.FormattingEnabled = true;
            this.comboBoxControlType.Location = new System.Drawing.Point(106, 39);
            this.comboBoxControlType.Name = "comboBoxControlType";
            this.comboBoxControlType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxControlType.TabIndex = 4;
            // 
            // labelControlType
            // 
            this.labelControlType.AutoSize = true;
            this.labelControlType.Location = new System.Drawing.Point(15, 42);
            this.labelControlType.Name = "labelControlType";
            this.labelControlType.Size = new System.Drawing.Size(70, 13);
            this.labelControlType.TabIndex = 3;
            this.labelControlType.Text = "Control Type:";
            // 
            // labelUI
            // 
            this.labelUI.AutoSize = true;
            this.labelUI.Location = new System.Drawing.Point(15, 15);
            this.labelUI.Name = "labelUI";
            this.labelUI.Size = new System.Drawing.Size(54, 13);
            this.labelUI.TabIndex = 2;
            this.labelUI.Text = "Select UI:";
            // 
            // comboBoxUI
            // 
            this.comboBoxUI.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUI.FormattingEnabled = true;
            this.comboBoxUI.Location = new System.Drawing.Point(106, 12);
            this.comboBoxUI.Name = "comboBoxUI";
            this.comboBoxUI.Size = new System.Drawing.Size(121, 21);
            this.comboBoxUI.TabIndex = 1;
            this.comboBoxUI.SelectedIndexChanged += new System.EventHandler(this.comboBoxUI_SelectedIndexChanged);
            // 
            // splitContainerUIDesigner
            // 
            this.splitContainerUIDesigner.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerUIDesigner.Location = new System.Drawing.Point(0, 139);
            this.splitContainerUIDesigner.Name = "splitContainerUIDesigner";
            // 
            // splitContainerUIDesigner.Panel1
            // 
            this.splitContainerUIDesigner.Panel1.Controls.Add(this.textBoxXMLViewer);
            this.splitContainerUIDesigner.Panel1.Controls.Add(this.webBrowserUI);
            // 
            // splitContainerUIDesigner.Panel2
            // 
            this.splitContainerUIDesigner.Panel2.Controls.Add(this.textBoxDestination);
            this.splitContainerUIDesigner.Size = new System.Drawing.Size(929, 333);
            this.splitContainerUIDesigner.SplitterDistance = 325;
            this.splitContainerUIDesigner.TabIndex = 2;
            // 
            // webBrowserUI
            // 
            this.webBrowserUI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowserUI.Location = new System.Drawing.Point(0, 0);
            this.webBrowserUI.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserUI.Name = "webBrowserUI";
            this.webBrowserUI.Size = new System.Drawing.Size(325, 333);
            this.webBrowserUI.TabIndex = 0;
            // 
            // textBoxDestination
            // 
            this.textBoxDestination.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDestination.Location = new System.Drawing.Point(0, 0);
            this.textBoxDestination.Multiline = true;
            this.textBoxDestination.Name = "textBoxDestination";
            this.textBoxDestination.ReadOnly = true;
            this.textBoxDestination.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDestination.Size = new System.Drawing.Size(600, 333);
            this.textBoxDestination.TabIndex = 1;
            this.textBoxDestination.TextChanged += new System.EventHandler(this.textBoxDestination_TextChanged);
            // 
            // openFileDialogFileLocation
            // 
            this.openFileDialogFileLocation.FileName = "Transaction File";
            this.openFileDialogFileLocation.Filter = "XML Files (*.xml)|*.xml|All files (*.*)|*.*";
            this.openFileDialogFileLocation.Title = "Transaction File Location";
            // 
            // comboBoxXMLType
            // 
            this.comboBoxXMLType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxXMLType.FormattingEnabled = true;
            this.comboBoxXMLType.Items.AddRange(new object[] {
            "SBL TXN",
            "Other"});
            this.comboBoxXMLType.Location = new System.Drawing.Point(313, 65);
            this.comboBoxXMLType.Name = "comboBoxXMLType";
            this.comboBoxXMLType.Size = new System.Drawing.Size(77, 21);
            this.comboBoxXMLType.TabIndex = 39;
            // 
            // labelXMLType
            // 
            this.labelXMLType.AutoSize = true;
            this.labelXMLType.Location = new System.Drawing.Point(253, 68);
            this.labelXMLType.Name = "labelXMLType";
            this.labelXMLType.Size = new System.Drawing.Size(59, 13);
            this.labelXMLType.TabIndex = 38;
            this.labelXMLType.Text = "XML Type:";
            // 
            // panelButtonSet1
            // 
            this.panelButtonSet1.Controls.Add(this.checkBoxViewPane);
            this.panelButtonSet1.Controls.Add(this.checkBoxCodeViewPane);
            this.panelButtonSet1.Controls.Add(this.buttonCopy);
            this.panelButtonSet1.Controls.Add(this.buttonChromeView);
            this.panelButtonSet1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelButtonSet1.Location = new System.Drawing.Point(668, 0);
            this.panelButtonSet1.Name = "panelButtonSet1";
            this.panelButtonSet1.Size = new System.Drawing.Size(261, 139);
            this.panelButtonSet1.TabIndex = 40;
            // 
            // textBoxXMLViewer
            // 
            this.textBoxXMLViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxXMLViewer.Location = new System.Drawing.Point(0, 0);
            this.textBoxXMLViewer.Multiline = true;
            this.textBoxXMLViewer.Name = "textBoxXMLViewer";
            this.textBoxXMLViewer.Size = new System.Drawing.Size(325, 333);
            this.textBoxXMLViewer.TabIndex = 1;
            // 
            // GenerateUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 472);
            this.Controls.Add(this.splitContainerUIDesigner);
            this.Controls.Add(this.panelHead);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(945, 510);
            this.Name = "GenerateUI";
            this.Text = "GenerateUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GenerateUI_Load);
            this.panelHead.ResumeLayout(false);
            this.panelHead.PerformLayout();
            this.splitContainerUIDesigner.Panel1.ResumeLayout(false);
            this.splitContainerUIDesigner.Panel1.PerformLayout();
            this.splitContainerUIDesigner.Panel2.ResumeLayout(false);
            this.splitContainerUIDesigner.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerUIDesigner)).EndInit();
            this.splitContainerUIDesigner.ResumeLayout(false);
            this.panelButtonSet1.ResumeLayout(false);
            this.panelButtonSet1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHead;
        private System.Windows.Forms.Button buttonGenerateUI;
        private System.Windows.Forms.Button buttonCopy;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.ComboBox comboBoxControlType;
        private System.Windows.Forms.Label labelControlType;
        private System.Windows.Forms.Label labelUI;
        private System.Windows.Forms.ComboBox comboBoxUI;
        private System.Windows.Forms.SplitContainer splitContainerUIDesigner;
        private System.Windows.Forms.TextBox textBoxColumn;
        private System.Windows.Forms.Label labelColumns;
        private System.Windows.Forms.TextBox textBoxDestination;
        private System.Windows.Forms.Label labelExample;
        private System.Windows.Forms.Label labelExam;
        private System.Windows.Forms.Label labelRead;
        private System.Windows.Forms.ComboBox comboBoxReadOnly;
        private System.Windows.Forms.ComboBox comboBoxTXRX;
        private System.Windows.Forms.Label labelTXRX;
        private System.Windows.Forms.WebBrowser webBrowserUI;
        private System.Windows.Forms.CheckBox checkBoxCodeViewPane;
        private System.Windows.Forms.CheckBox checkBoxViewPane;
        private System.Windows.Forms.CheckBox checkBoxTryNow;
        private System.Windows.Forms.Button buttonChromeView;
        private System.Windows.Forms.OpenFileDialog openFileDialogFileLocation;
        private System.Windows.Forms.Button buttonUpdateUI;
        private System.Windows.Forms.CheckBox checkBoxAuto;
        private System.Windows.Forms.ComboBox comboBoxXMLType;
        private System.Windows.Forms.Label labelXMLType;
        private System.Windows.Forms.Panel panelButtonSet1;
        private System.Windows.Forms.TextBox textBoxXMLViewer;
    }
}