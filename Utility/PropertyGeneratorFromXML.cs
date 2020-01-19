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
    public partial class PropertyGeneratorFromXML : Form
    {
        string fileLoc = string.Empty;
        XmlDocument newDocument = new XmlDocument();
        public PropertyGeneratorFromXML()
        {
            InitializeComponent();
        }

        private void buttonLoadXML_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogXML.ShowDialog();
            fileLoc = openFileDialogXML.FileName;
            if (result == DialogResult.OK) // Test result.
            {
                labelFile.Text = fileLoc;
                string xmlRawText = string.Empty;
                try
                {
                    try
                    {
                        textBoxSource.Text = XmlOperation.LoadFileToXML(fileLoc, out newDocument);
                        textBoxSource.ForeColor = Color.Black;


                    }
                    catch { }
                }
                catch
                {
                    textBoxSource.Text = xmlRawText;
                    textBoxSource.ForeColor = Color.Red;
                }

            }
        }
        //static private string Beautify(XmlDocument doc)
        //{
        //    try
        //    {
        //        StringBuilder sb = new StringBuilder();
        //        XmlWriterSettings settings = new XmlWriterSettings
        //        {
        //            Indent = true,
        //            IndentChars = "\t",
        //            NewLineChars = "\r\n",
        //            NewLineHandling = NewLineHandling.Replace
        //        };
        //        using (XmlWriter writer = XmlWriter.Create(sb, settings))
        //        {
        //            doc.Save(writer);
        //        }

        //        return sb.ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        //Once log enabled .. ErrorModel will be having error data
        //        //Console.WriteLine(ex.Message);
        //        return null;
        //    }
        //}
        public void processXMLNodes(XmlNode xmlNode)
        {
            try
            {
                if (xmlNode.HasChildNodes)
                {
                    XmlNodeList headerNodeList = xmlNode.ChildNodes;
                    if (headerNodeList != null)
                    {
                        foreach (XmlNode headerAttribute in headerNodeList)
                        {
                            processXMLNodes(headerAttribute);
                        }
                    }

                }
                else if (xmlNode.Name == "FIELD")
                {
                    string am = comboBoxAM.Text;
                    string returnType = comboBoxReturn.Text;
                    string getSet = string.Empty;
                    if (comboBoxProperty.Text == "GET/SET")
                        getSet = "{get; set;}";
                    else if (comboBoxProperty.Text == "GET")
                        getSet = "{get;}";
                    if (comboBoxProperty.Text == "SET")
                        getSet = "{set;}";

                    XmlNode namedItem = xmlNode.Attributes.GetNamedItem(textBoxElement.Text);//("ID");
                    string formattedProperty = "\r\t" + am + " " + returnType + " " + namedItem.InnerText + " " + getSet;
                    textBoxDestination.Text = textBoxDestination.Text + Environment.NewLine + formattedProperty;
                }
            }
            catch { }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            if (comboBoxAM.SelectedIndex == -1 || comboBoxProperty.SelectedIndex == -1 || comboBoxReturn.SelectedIndex == -1 || labelFile.Text == "" || textBoxClass.Text == "" || textBoxElement.Text == "")
                MessageBox.Show("Please load a file using load XML. Also select \"Access Specifier, Return Type, Property Type, Class Name & Element for Property\" for the same.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            else
            {
                textBoxDestination.Text = comboBoxAM.Text + " " + "class " + textBoxClass.Text + "\r\n" + "{";
                try
                {
                    XmlDocument docIn = new XmlDocument();
                    docIn.Load(fileLoc);

                    XmlNodeList headerNodeList = docIn.SelectSingleNode("/GROUP").ChildNodes;
                    if (headerNodeList != null)
                    {
                        foreach (XmlNode headerAttribute in headerNodeList)
                        {
                            processXMLNodes(headerAttribute);
                        }
                    }
                }
                catch { }
                textBoxDestination.Text = textBoxDestination.Text + "\r\n" + "}";
            }
        }

        private void PropertyGeneratorFromXML_Load(object sender, EventArgs e)
        {
            labelFile.Text = "";
            comboBoxAM.SelectedIndex = 0;
            comboBoxProperty.SelectedIndex = 0;
            comboBoxReturn.SelectedIndex = 0;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDestination.Text))
                Clipboard.SetText(textBoxDestination.Text, TextDataFormat.Text);
        }

        private void buttonUIDesign_Click(object sender, EventArgs e)
        {
            GenerateUI newUIGenerate = new GenerateUI();
            newUIGenerate.setTransaction(newDocument);
            newUIGenerate.setFileLocation(labelFile.Text);
            newUIGenerate.Show();
        }
    }
}
