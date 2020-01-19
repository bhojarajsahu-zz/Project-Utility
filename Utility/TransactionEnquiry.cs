using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Utilities.UtilityClass;

namespace Utilities
{
    public partial class TransactionEnquiry : Form
    {
        XmlDocument xmlDoc = null;
        string fileLoc = string.Empty;
        List<TransactionSearchModel> modelList = new List<TransactionSearchModel>();
        public TransactionEnquiry()
        {
            InitializeComponent();
        }

        private void TransactionEnquiry_Load(object sender, EventArgs e)
        {
            checkFile();
        }
        public void checkFile()
        {
            try
            {
                //this.Text = DateTime.Now.ToString();
                fileLoc = textBoxFileLoc.Text;
                xmlDoc = new XmlDocument();
                xmlDoc.Load(fileLoc);

                dataGridViewAllTXN.Columns.Clear();
                dataGridViewAllTXN.Rows.Clear();

                dataGridViewAllTXN.Columns.Add("Name", "Name");
                dataGridViewAllTXN.Columns.Add("TX", "TX");
                dataGridViewAllTXN.Columns.Add("RX", "RX");


                XmlNodeList headerNodeList = xmlDoc.SelectSingleNode("/TRANSACTIONS").ChildNodes;
                if (headerNodeList != null)
                {
                    foreach (XmlNode headerAttribute in headerNodeList)
                    {
                        XmlNode namedItem;
                        if (headerAttribute.Name == "TRANSACTION")
                        {
                            namedItem = headerAttribute.Attributes.GetNamedItem("TX");//("ID");
                            dataGridViewAllTXN.Rows.Add(headerAttribute.Attributes.GetNamedItem("NAME").Value, headerAttribute.Attributes.GetNamedItem("TX").Value, headerAttribute.Attributes.GetNamedItem("RX").Value);
                        }
                    }
                }
                textBoxFileLoc.BackColor = Color.White;
            }
            catch
            {
                textBoxFileLoc.BackColor = Color.Red;
                dataGridViewAllTXN.Rows.Clear();
            }
            //this.Text = this.Text + "-----" + DateTime.Now.ToString();
        }
        public void addTransactions(string name, string tx, string rx, bool supressMSG = true)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(tx) || string.IsNullOrEmpty(rx))
            {
                if (supressMSG)
                    MessageBox.Show("Please Enter Some Value", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
            else
            {
                bool checkStatus = checkNewTxn(name, tx, rx);
                if (checkStatus)
                {
                    try
                    {
                        XmlNode RootNode = xmlDoc.SelectSingleNode("TRANSACTIONS");
                        XmlNode Data = xmlDoc.CreateNode(XmlNodeType.Element, "TRANSACTION", null);

                        XmlAttribute Name = xmlDoc.CreateAttribute("NAME");
                        Name.Value = name;

                        //Insert description
                        XmlAttribute TX = xmlDoc.CreateAttribute("TX");
                        TX.Value = tx;

                        //Insert findings
                        XmlAttribute RX = xmlDoc.CreateAttribute("RX");
                        RX.Value = rx;

                        Data.Attributes.Append(Name);
                        Data.Attributes.Append(TX);
                        Data.Attributes.Append(RX);

                        RootNode.AppendChild(Data);

                        xmlDoc.Save(fileLoc);
                        dataGridViewAllTXN.Rows.Add(name, tx, rx);
                        clearNewTXN();
                    }
                    catch { }
                }
                else
                {
                    if (supressMSG)
                        MessageBox.Show("Entry Already Present", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            addTransactions(textBoxTransactionName.Text, textBoxTX.Text, textBoxRX.Text, true);
        }
        public void clearNewTXN()
        {
            textBoxTransactionName.Text = "";
            textBoxTX.Text = "";
            textBoxRX.Text = "";
        }
        public bool checkNewTxn(string name, string tx, string rx)
        {
            bool status = true;
            foreach (DataGridViewRow row in dataGridViewAllTXN.Rows)
            {
                string tname = row.Cells[0].Value.ToString();
                string ttx = row.Cells[1].Value.ToString();
                string trx = row.Cells[2].Value.ToString();
                if (name.Contains(tname) || ttx == tx || trx == rx)
                {
                    status = false;
                    break;
                }
            }
            return status;
        }
        public void searchTXN(string name, string tx, string rx)
        {
            dataGridViewSearchResult.Columns.Clear();
            dataGridViewSearchResult.Rows.Clear();
            dataGridViewSearchResult.Columns.Add("Name", "Name");
            dataGridViewSearchResult.Columns.Add("TX", "TX");
            dataGridViewSearchResult.Columns.Add("RX", "RX");

            foreach (DataGridViewRow row in dataGridViewAllTXN.Rows)
            {
                string tname = row.Cells[0].Value.ToString();
                string ttx = row.Cells[1].Value.ToString();
                string trx = row.Cells[2].Value.ToString();

                if (!string.IsNullOrEmpty(name))
                {
                    if (tname.ToUpper().Contains(name.ToUpper()))
                        dataGridViewSearchResult.Rows.Add(tname, ttx, trx);
                }

                if (!string.IsNullOrEmpty(tx))
                {
                    if (ttx == tx)
                        dataGridViewSearchResult.Rows.Add(tname, ttx, trx);
                }

                if (!string.IsNullOrEmpty(rx))
                {
                    if (trx == rx)
                        dataGridViewSearchResult.Rows.Add(tname, ttx, trx);
                }
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            searchTXN(textBoxSName.Text, textBoxSTX.Text, textBoxSRX.Text);
        }

        private void textBoxFileLoc_TextChanged(object sender, EventArgs e)
        {
            checkFile();
        }
        public void updateModel(List<TransactionSearchModel> mList)
        {
            modelList = new List<TransactionSearchModel>();
            modelList = mList;

            foreach (TransactionSearchModel model in modelList)
            {
                addTransactions(model.Name, model.TX, model.RX, false);
            }
        }
        private void buttonSyncDb_Click(object sender, EventArgs e)
        {
            using (CheckConnection childform = new CheckConnection())
            {
                childform.setSyncDb(true);
                childform.ShowDialog(this);
            }
        }

        private void textBoxSName_TextChanged(object sender, EventArgs e)
        {
            textBoxSRX.Text = "";
            textBoxSTX.Text = "";
        }

        private void textBoxSTX_TextChanged(object sender, EventArgs e)
        {
            textBoxSRX.Text = "";
            textBoxSName.Text = "";
        }

        private void textBoxSRX_TextChanged(object sender, EventArgs e)
        {
            textBoxSTX.Text = "";
            textBoxSName.Text = "";
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
