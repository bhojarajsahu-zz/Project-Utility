using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.Sql;

namespace Utilities
{
    public partial class SqlServerInstance : Form
    {
        public SqlServerInstance()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            getAllServerInstances();
        }
        public void getAllServerInstances()
        {
            this.Cursor = Cursors.WaitCursor;
            dataGridViewResult.Columns.Clear();
            dataGridViewResult.Rows.Clear();
            dataGridViewResult.Columns.Add("Server Name", "Server Name");
            dataGridViewResult.Columns.Add("Instance Name", "Instance Name");
            dataGridViewResult.Columns.Add("Version", "Version");

            try
            {
                DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
                foreach (DataRow dr in dt.Rows)
                {
                    dataGridViewResult.Rows.Add(dr["ServerName"], dr["InstanceName"], dr["Version"]);
                }
            }
            catch { }
            this.Cursor = Cursors.Default;
        }

        private void SqlServerInstance_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewResult_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string dbDetail = dataGridViewResult.SelectedRows[0].Cells[0].Value.ToString();
            string instanceDetail = dataGridViewResult.SelectedRows[0].Cells[1].Value.ToString();
            if (!string.IsNullOrEmpty(instanceDetail))
                dbDetail = dbDetail + "\\" + instanceDetail;

            CheckConnection newConnection = new CheckConnection();
            newConnection.setDbDetails(dbDetail);
            newConnection.Show();
        }
    }
}
