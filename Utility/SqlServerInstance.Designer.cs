namespace Utilities
{
    partial class SqlServerInstance
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
            this.groupBoxMenu = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxBody = new System.Windows.Forms.GroupBox();
            this.dataGridViewResult = new System.Windows.Forms.DataGridView();
            this.groupBoxMenu.SuspendLayout();
            this.groupBoxBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxMenu
            // 
            this.groupBoxMenu.Controls.Add(this.buttonSearch);
            this.groupBoxMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxMenu.Location = new System.Drawing.Point(0, 0);
            this.groupBoxMenu.Name = "groupBoxMenu";
            this.groupBoxMenu.Size = new System.Drawing.Size(679, 100);
            this.groupBoxMenu.TabIndex = 0;
            this.groupBoxMenu.TabStop = false;
            this.groupBoxMenu.Text = "Search";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(208, 40);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(221, 23);
            this.buttonSearch.TabIndex = 0;
            this.buttonSearch.Text = "Find All Local Instance";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxBody
            // 
            this.groupBoxBody.Controls.Add(this.dataGridViewResult);
            this.groupBoxBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxBody.Location = new System.Drawing.Point(0, 100);
            this.groupBoxBody.Name = "groupBoxBody";
            this.groupBoxBody.Size = new System.Drawing.Size(679, 262);
            this.groupBoxBody.TabIndex = 1;
            this.groupBoxBody.TabStop = false;
            this.groupBoxBody.Text = "Result";
            // 
            // dataGridViewResult
            // 
            this.dataGridViewResult.AllowUserToAddRows = false;
            this.dataGridViewResult.AllowUserToDeleteRows = false;
            this.dataGridViewResult.AllowUserToResizeRows = false;
            this.dataGridViewResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewResult.Location = new System.Drawing.Point(3, 16);
            this.dataGridViewResult.Name = "dataGridViewResult";
            this.dataGridViewResult.ReadOnly = true;
            this.dataGridViewResult.RowHeadersVisible = false;
            this.dataGridViewResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResult.Size = new System.Drawing.Size(673, 243);
            this.dataGridViewResult.TabIndex = 0;
            this.dataGridViewResult.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewResult_CellContentDoubleClick);
            // 
            // SqlServerInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 362);
            this.Controls.Add(this.groupBoxBody);
            this.Controls.Add(this.groupBoxMenu);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(695, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(695, 400);
            this.Name = "SqlServerInstance";
            this.Text = "SqlServerInstance";
            this.Load += new System.EventHandler(this.SqlServerInstance_Load);
            this.groupBoxMenu.ResumeLayout(false);
            this.groupBoxBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMenu;
        private System.Windows.Forms.GroupBox groupBoxBody;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.DataGridView dataGridViewResult;
    }
}