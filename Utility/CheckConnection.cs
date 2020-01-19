using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Utilities.UtilityClass;
using System.Threading;

namespace Utilities
{
    public partial class CheckConnection : Form
    {
        bool syndFromDb = false;
        string dbDetails = string.Empty;
        List<TransactionSearchModel> newList = new List<TransactionSearchModel>();
        public CheckConnection()
        {
            InitializeComponent();
        }

        public void setSyncDb(bool value)
        {
            syndFromDb = value;
        }
        public void setDbDetails(string value)
        {
            dbDetails = value;
        }
        private void buttonCheck_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                SqlConnection con = new SqlConnection(textBoxConnectionString.Text);
                SqlCommand cmd = new SqlCommand("select * from Output;", con);
                con.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                    this.BackColor = Color.Green;
                else
                    this.BackColor = Color.Red;
                con.Close();
            }
            catch
            {
                this.BackColor = Color.Red;
            }
            this.Cursor = Cursors.Default;
        }

        private void CheckConnection_Load(object sender, EventArgs e)
        {
            if (syndFromDb)
                buttonSync.Visible = true;
            else
                buttonSync.Visible = false;

            setDbDetailsToForm();
        }

        private void buttonSync_Click(object sender, EventArgs e)
        {
            try
            {
                newList = new List<TransactionSearchModel>();
                SqlConnection con = new SqlConnection(textBoxConnectionString.Text);
                SqlDataAdapter da = new SqlDataAdapter();
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();

                da.SelectCommand = new SqlCommand(@"select * from Output", con);
                da.Fill(ds, "Output");
                dt = ds.Tables["Output"];
                foreach (DataRow dr in dt.Rows)
                {
                    TransactionSearchModel newModel = new TransactionSearchModel();
                    string tx, rx = string.Empty;
                    tx = dr["Output_Tran_Code"].ToString();
                    rx = dr["Output_Tran_Stream"].ToString();
                    if (tx.Length > 6)
                    {
                        newModel.Name = tx.Substring(0, 6);
                        newModel.TX = tx.Substring(0, 6);
                    }
                    if (rx.Length > 62)
                    {
                        newModel.RX = rx.Substring(56, 6);
                    }
                    newList.Add(newModel);
                }

                TransactionEnquiry parent = (TransactionEnquiry)this.Owner;
                parent.updateModel(newList);
                this.Close();
            }
            catch { }
        }
        public void setDbDetailsToForm()
        {
            if (string.IsNullOrEmpty(dbDetails))
                textBoxConnectionString.Text = @"Data Source=.\SQLEXPRESS;Initial Catalog=BancsSimulator;Integrated Security=SSPI;";
            else
                textBoxConnectionString.Text = string.Format("Data Source={0};Initial Catalog=BancsSimulator;Integrated Security=SSPI;", dbDetails);

        }
    }
}
