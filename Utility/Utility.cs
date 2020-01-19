using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using Utilities.UtilityClass;

namespace Utilities
{
    public partial class Utility : Form
    {
        public Utility()
        {
            InitializeComponent();
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxSource.Text))
                textBoxDestination.Text = "";
            try
            {
                XmlDocument newDocument = new XmlDocument();
                newDocument.LoadXml(textBoxSource.Text);
                string Destination = XmlOperation.Beautify(newDocument);
                textBoxDestination.Text = Destination;
                toolStripStatusLabel.Text = "Status";
                toolStripStatusLabel.ForeColor = Color.Black;
                textBoxSource.ForeColor = Color.Black;
            }
            catch (Exception ex)
            {
                toolStripStatusLabel.Text = "Error: " + ex.Message;
                toolStripStatusLabel.ForeColor = Color.Red;
                textBoxSource.ForeColor = Color.Red;
            }
        }

        private void buttonCopyS_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSource.Text))
                Clipboard.SetText(textBoxSource.Text, TextDataFormat.Text);
        }

        private void buttonCopyD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxSource.Text))
                Clipboard.SetText(textBoxDestination.Text, TextDataFormat.Text);
        }

        private void buttonClearSource_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = "";
        }

        private void Utility_Load(object sender, EventArgs e)
        {

        }
    }
}
