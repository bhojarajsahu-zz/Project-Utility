using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Utilities.UtilityClass;

namespace Utilities
{
    public partial class GenerateUI : Form
    {
        int columnCount = 0;
        List<UIElement> idList = new List<UIElement>();
        List<UIElement> collIdList = new List<UIElement>();
        bool IsField = true;
        int counter = 0;
        int ltopSpace = 30;
        int tabindex = 0;
        int rowCount = 0;
        int leftSpaceMaster = 0;
        int lleftSpace = 20, lwidth = 100, iwidth = 120, maxLength = 16, verticalGap = 30, horizontalGap = 300;
        string readOnly = string.Empty;
        string innerModel = string.Empty;
        string readOnlyStatus = string.Empty;
        string inLineStyle = string.Empty;
        string dynamicVariableName = string.Empty;
        XmlDocument xmltransactionDefination = new XmlDocument();
        List<string> collectionHTMLList = null;
        List<List<UIElement>> collectionElementList = new List<List<UIElement>>();
        bool IsAuto = false;

        string transactionNumber = string.Empty;

        StringBuilder sb = new StringBuilder();
        StringBuilder sbHtml = new StringBuilder();


        public void setTransaction(XmlDocument abc)
        {
            xmltransactionDefination = abc;
        }
        public void setFileLocation(string loc)
        {
            textBoxDestination.Text = string.Empty;
            if (string.IsNullOrEmpty(loc))
            {
                labelFile.ForeColor = Color.Red;
                labelFile.Text = "Please select a transaction file.";
            }
            else
            {
                labelFile.Text = loc;
                labelFile.ForeColor = Color.Black;
                XmlOperation.LoadFileToXML(loc, out xmltransactionDefination);

                string Destination = XmlOperation.Beautify(xmltransactionDefination);
                textBoxXMLViewer.Text = Destination;
            }
        }

        public GenerateUI()
        {
            InitializeComponent();
        }
        public void loadXML()
        {
            sb = new StringBuilder();
            sbHtml = new StringBuilder();
            collectionHTMLList = new List<string>();
            counter = 0;
            ltopSpace = 30;
            tabindex = 0;

            try
            {
                counter = 0;
                idList = new List<UIElement>();
                XmlNode newGroupNode = xmltransactionDefination.SelectSingleNode("/GROUP" + "/" + comboBoxTXRX.Text);
                XmlNodeList headerNodeList = xmltransactionDefination.SelectSingleNode("/GROUP" + "/" + comboBoxTXRX.Text).ChildNodes;
                if (headerNodeList != null)
                {
                    foreach (XmlNode headerAttribute in headerNodeList)
                    {
                        if (headerAttribute.Name.Contains("FIELD"))
                        {
                            IsField = true;
                            UIElement newelement = new UIElement();
                            XmlNode namedItem = headerAttribute.Attributes.GetNamedItem("ID");
                            newelement.Id = namedItem.InnerText;

                            XmlNode namedDF = headerAttribute.Attributes.GetNamedItem("Format");
                            newelement.DisplayFormat = namedDF.InnerText;

                            idList.Add(newelement);
                        }
                        else if (headerAttribute.Name.Contains("COLLECTION"))
                        {
                            loadCollectionItem(headerAttribute);
                            //collectionHTMLList.Add(collectionHtml);
                        }

                    }
                }

                using (TXNIdLabelMapper childform = new TXNIdLabelMapper())
                {
                    childform.setTransactionValue(idList, comboBoxControlType.Text);
                    childform.ShowDialog(this);
                }
            }
            catch { }
        }
        public void loadCollectionItem(XmlNode xmlNode)
        {
            IsField = false;
            collIdList = new List<UIElement>();
            string collectionHtml = string.Empty;
            XmlNodeList nodeLst = xmlNode.ChildNodes;
            foreach (XmlNode headerItem in nodeLst)
            {
                UIElement newelement = new UIElement();
                XmlNode namedItem = headerItem.Attributes.GetNamedItem("ID");
                newelement.Id = namedItem.InnerText;

                XmlNode namedDF = headerItem.Attributes.GetNamedItem("Format");
                newelement.DisplayFormat = namedDF.InnerText;

                collIdList.Add(newelement);
            }

            using (TXNIdLabelMapper childform = new TXNIdLabelMapper())
            {
                childform.setTransactionValue(collIdList, "TEXTBOX", false, "Collection header mapper");
                childform.ShowDialog(this);
            }
        }
        public void loadXMLOther()
        {
            sb = new StringBuilder();
            sbHtml = new StringBuilder();

            counter = 0;
            ltopSpace = 30;
            tabindex = 0;

            try
            {
                counter = 0;
                idList = new List<UIElement>();
                //xmltransactionDefination = 
                //XmlNode newGroupNode = xmltransactionDefination.SelectSingleNode("/GROUP" + "/");
                XmlNodeList headerNodeList = xmltransactionDefination.SelectSingleNode("/GROUP" + "/" + "ROOT").ChildNodes;
                if (headerNodeList != null)
                {
                    foreach (XmlNode headerAttribute in headerNodeList)
                    {
                        UIElement newelement = new UIElement();
                        //XmlNode namedItem = headerAttribute.Attributes.GetNamedItem("ID");
                        newelement.Id = headerAttribute.Name;
                        newelement.Label = headerAttribute.Name;
                        //newelement.Value = headerAttribute.InnerText;
                        //newelement.Value = 


                        //XmlNode namedDF = headerAttribute.Attributes.GetNamedItem("Format");
                        newelement.DisplayFormat = "";

                        idList.Add(newelement);

                    }
                }

                //using (TXNIdLabelMapper childform = new TXNIdLabelMapper())
                //{
                //    childform.setTransactionValue(idList, comboBoxControlType.Text);
                //    childform.ShowDialog(this);
                //}
                updatetext(idList);
            }
            catch { }
        }

        public void updateCollItem(List<UIElement> updatedElementList)
        {
            collIdList = new List<UIElement>();
            collIdList = updatedElementList;
            collectionElementList.Add(collIdList);
        }
        public void generateCollHtml()
        {
            ltopSpace = ltopSpace + verticalGap;
            lleftSpace = leftSpaceMaster;

            foreach (List<UIElement> collIdListItem in collectionElementList)
            {
                string finalCollectionString = string.Format("<DIV FNSType=\"grid\" id=\"grid{0}\" RXTransaction=\"{1}\" style=\"HEIGHT: 271px; LEFT: {7}px; POSITION: absolute; TOP: {6}px; WIDTH: 800px\" TXTransaction=\"{2}\">" +
                            "<DIV style=\"HEIGHT: 49px; OVERFLOW: hidden; POSITION: static; WIDTH: 800px; overflow-x: hidden;\">" +
                                "<TABLE border=\"1\"  cellPadding=\"1\" cellSpacing=\"1\" class=\"grid\" FNSType=\"gridtable\" frame=\"box\" id=\"T{3}\" LANGUAGE=\"javascript\" name=\"T{4}\" rules=\"all\" TXTransaction=\"\" RXCollection=\"Collection1\" RXTransaction=\"{5}\" style=\"POSITION: static; width: 800px; height: 43px; margin-bottom: 0px;\">",
                                transactionNumber, transactionNumber, transactionNumber, transactionNumber, transactionNumber, transactionNumber, ltopSpace, lleftSpace);
                //txn,txn,txn,txn,
                string colGroup = "<COLGROUP>";
                string thread = "<THEAD bgcolor=\"white\"><TR bgcolor=\"white\">";
                string tBody = "<TBODY id=\"tBody\"><TR style=\"DISPLAY: none\">";
                foreach (UIElement uiItem in collIdListItem)
                {
                    colGroup = colGroup + "<COL align=\"left\" width=\"75px\"/>";
                    thread = thread + string.Format("<TH FNSType=\"gridcolumn\" nowrap=\"true\">{0}</TH>", uiItem.Label);
                    tBody = tBody + string.Format("<TD FNSType=\"gridcolumn\" RXField=\"{0}\" DisplayFormat=\"{1}\" style=\"width:55px; height: 18px;\"></TD>", uiItem.Id, uiItem.DisplayFormat);
                }
                colGroup = colGroup + "</COLGROUP>";
                thread = thread + "</TR></THEAD>";
                tBody = tBody + "</TR></TBODY>";

                finalCollectionString = finalCollectionString + colGroup + thread + tBody;
                finalCollectionString = finalCollectionString + "</TABLE></DIV></DIV>";
                //collectionHTMLList.Add(finalCollectionString);
                sb.Append(finalCollectionString);
            }

        }
        public void updatetext(List<UIElement> updatedElementList)
        {
            idList = new List<UIElement>();
            idList = updatedElementList;

            readOnlyStatus = comboBoxReadOnly.Text;

            columnCount = Convert.ToInt32(textBoxColumn.Text);
            rowCount = idList.Count / columnCount;
            if (idList.Count % columnCount > 0)
                rowCount++;

            if (comboBoxUI.Text == "KENDO")
            {
                sb.Append("<BODY><table class=\"tableStyle\" style=\"margin:10px 10px 10px 25px; width:98%;\">");
                sbHtml.Append("<BODY><table class=\"tableStyle\" style=\"margin:10px 10px 10px 25px; width:98%;\">");
                for (int i = 0; i <= rowCount; i++)
                    designUIForKendoUI(Convert.ToInt32(textBoxColumn.Text), sb, sbHtml);

                sb.Append("</table></BODY>");
                sbHtml.Append("</table></BODY>");
            }
            else if (comboBoxUI.Text == "SBL")
            {
                using (SBLFormProperty childform = new SBLFormProperty())
                {
                    childform.ShowDialog(this);
                }
            }

            try
            {
                XmlDocument newDocument = new XmlDocument();
                newDocument.LoadXml(sb.ToString());
                string Destination = XmlOperation.Beautify(newDocument);

                if (Destination.Contains("xml version"))
                {
                    int position = Destination.IndexOf("\r\n");
                    position += 2;
                    textBoxDestination.Text = Destination.Remove(0, position);
                }

                string formattedOutput = System.Xml.Linq.XElement.Parse(textBoxDestination.Text).ToString();
                //webBrowserUI.DocumentText = @"<HTML>" + "<Head><link rel=\"stylesheet\" href=\"D:\\Resource\\css\\Screen.css\">" +
                //            "<BODY>" + formattedOutput + "</BODY>" +
                //        "</HTML>";
                string htmltext = string.Format("<Head><link rel=\"stylesheet\" href=\"D:\\Resource\\css\\Screen.css\"></Head><HTML>{0}</HTML>", formattedOutput);
                //geckoWebBrowser1.BindingContext = htmltext;
                webBrowserUI.DocumentText = htmltext;


            }
            catch
            {
                textBoxDestination.ForeColor = Color.Red;
            }
        }
        public void updateSBLSettings(string s1, string s2, string s3, string s4, string s5, string s6, string s7, string s8, string s9, string s10, string s11)
        {
            transactionNumber = s4;
            lwidth = Convert.ToInt32(s6);
            iwidth = Convert.ToInt32(s7);
            ltopSpace = Convert.ToInt32(s8);
            lleftSpace = Convert.ToInt32(s9);
            leftSpaceMaster = lleftSpace;
            maxLength = 16;
            verticalGap = Convert.ToInt32(s10);
            horizontalGap = Convert.ToInt32(s11);

            string newFormData = string.Format("<BODY id=\"FNSScreen\" bgcolor=\"#c0c0c0\" FNSType=\"SINGLEPAGESCREEN\" class=\"screen\"><FORM class=\"transaction\" style=\"WIDTH: {0}px; POSITION: absolute; HEIGHT: {1}px\" name=\"{2}\" method=\"post\" FNSType=\"transaction\" rxtransaction=\"{3}\" TXTransaction=\"{4}\" customaction=\"DefaultTransmit\">", s1, s2, s3, s4, s5);
            sb.Append(newFormData);
            for (int i = 0; i <= rowCount; i++)
                designUIForSBLUI(Convert.ToInt32(textBoxColumn.Text), sb);

            generateCollHtml();

            //foreach (string item in collectionHTMLList)
            //    sb.Append(item);

            sb.Append("</FORM></BODY>");
        }
        private void buttonGenerateUI_Click(object sender, EventArgs e)
        {
            collectionElementList = new List<List<UIElement>>();
            if (comboBoxXMLType.Text == "SBL TXN")
                loadXML();
            else
                loadXMLOther();
        }
        private void buttonGenerateUIOther_Click(object sender, EventArgs e)
        {
            loadXMLOther();

        }
        public void designUIForKendoUI(int column, StringBuilder sb, StringBuilder sbHtml)
        {
            sb.Append("<tr>");
            sbHtml.Append("<tr>");
            for (int i = 0; i < column; i++)
            {
                if (counter < idList.Count)
                {
                    if (!string.IsNullOrEmpty(idList[counter].Id))
                    {
                        string elementData = string.Empty;
                        string elementDataHtml = string.Empty;

                        if (idList[counter].ControlType.ToString() == "TEXTBOX")
                        {
                            elementData = string.Format("<label>@(Html.Kendo().TextBoxFor(model => model.{0}{1}).Name(\"{2}\"{3}).Enable({4}).HtmlAttributes({5})</label>",
                                    innerModel, idList[counter].Id, idList[counter].Id, dynamicVariableName, readOnlyStatus, inLineStyle);

                            if (readOnlyStatus != "true")
                                elementDataHtml = string.Format("<input type=\"text\" name=\"{0}\"><br>",
                                    idList[counter].Id);
                            else
                                elementDataHtml = string.Format("<input type=\"text\" name=\"{0}\" readonly><br>",
                                    idList[counter].Id);

                        }
                        else if (idList[counter].ControlType.ToString() == "COMBOBOX")
                        {
                            elementData = string.Format("<label>@(Html.Kendo().TextBoxFor(model => model.{0}{1}).Name(\"{2}\"{3}).Enable({4}).HtmlAttributes({5})</label>",
                                    innerModel, idList[counter].Id, idList[counter].Id, dynamicVariableName, readOnlyStatus, inLineStyle);

                            elementDataHtml = string.Format("<SELECT name={0}><option value=\"Select\">Select</option></SELECT>",
                                    idList[counter].Id);

                            if (readOnlyStatus != "true")
                                elementDataHtml = string.Format("<SELECT name={0}><option value=\"Select\">Select</option></SELECT>",
                                    idList[counter].Id);
                            else
                                elementDataHtml = string.Format("<SELECT name={0} disabled><option value=\"Select\">Select</option></SELECT>",
                                        idList[counter].Id);

                        }

                        string formattedTD = string.Format("<td class=\"blockStyle\">" +
                                "<table>" +
                                    "<tr>" +
                                        "<td class=\"tableLabelHeader\">{0}</td>" + //Title
                                        "<td class=\"tableLabelHeader\">:</td>" +
                                        "<td>" + elementData + "</td>" +
                                    "</tr>" +
                                "</table>" +
                            "</td>",

                            idList[counter].Label);

                        string formattedTDHtml = string.Format("<td class=\"blockStyle\">" +
                                "<table>" +
                                    "<tr>" +
                                        "<td class=\"tableLabelHeader\">{0}</td>" + //Title
                                        "<td class=\"tableLabelHeader\">:</td>" +
                                        "<td>" + elementDataHtml + "</td>" +
                                    "</tr>" +
                                "</table>" +
                            "</td>",

                            idList[counter].Label);
                        sb.Append(formattedTD);
                        sbHtml.Append(formattedTDHtml);
                        counter++;
                    }
                    else
                    {
                        string formattedTD = string.Format("<td class=\"blockStyle\">" +
                                "<table>" +
                                    "<tr>" +
                                        "<td class=\"tableLabelHeader\"></td>" + //Title
                                        "<td class=\"tableLabelHeader\"></td>" +
                                        "<td>" +
                                            "<label></label>" + //Control
                                        "</td>" +
                                    "</tr>" +
                                "</table>" +
                            "</td>");
                        sb.Append(formattedTD);
                        counter++;
                    }
                }
            }
            sb.Append("</tr>");
        }
        public void designUIForSBLUI(int column, StringBuilder sb)
        {
            //int lleftSpace = 20, lwidth = 100, iwidth = 120, readOnly = 0, maxLength = 16, verticalGap = 30, horizontalGap = 300;
            string iName = "", displayFormat = "";

            for (int i = 0; i < column; i++)
            {
                if (counter < idList.Count)
                {
                    if (!string.IsNullOrEmpty(idList[counter].Id))
                    {
                        string elementData = string.Empty;
                        string elementDataHtml = string.Empty;

                        if (idList[counter].ControlType.ToString() == "TEXTBOX")
                        {
                            iName = idList[counter].Id;
                            displayFormat = idList[counter].DisplayFormat;
                            if (IsAuto)
                            {
                                iwidth = UtilityOperations.GetInputLength(displayFormat);
                                maxLength = iwidth;
                                iwidth = maxLength * 7;
                                if (iwidth < 20)
                                    iwidth = 20;
                                if (iwidth > 250)
                                    iwidth = 250;
                            }

                            if (readOnlyStatus == "true")
                                readOnly = "readonly=\"0\"";
                            else
                                readOnly = string.Empty;

                            elementData = string.Format("<FIELDSET class=\"field\" style=\"LEFT: {0}px; WIDTH: {1}px; POSITION: absolute; TOP: {2}px; POSITION: absolute\" FNSType=\"field\"><INPUT class=\"fieldinput\" style=\"LEFT:{3}px; WIDTH: {4}px; POSITION: absolute; POSITION: absolute\" tabindex=\"{5}\" {6} maxlength=\"{7}\" name=\"{8}\" FNSType=\"fieldinput\" RXField=\"{9}\" TXField=\"{10}\" DisplayFormat=\"{11}\" Value=\"{12}\"></INPUT>{13}</FIELDSET>",
                                    lleftSpace, lwidth, ltopSpace, lwidth + 10, iwidth, tabindex, readOnly, maxLength, iName, idList[counter].Id, idList[counter].Id, displayFormat, idList[counter].Value, idList[counter].Label);

                        }
                        else if (idList[counter].ControlType.ToString() == "COMBOBOX")
                        {
                            iName = idList[counter].Id;
                            displayFormat = idList[counter].DisplayFormat;
                            //ileftSpace = lleftSpace + lwidth + 20;

                            if (readOnlyStatus == "true")
                                readOnly = "readonly=\"0\"";
                            else
                                readOnly = string.Empty;

                            elementData = string.Format("<FIELDSET class=\"combobox\" style=\"LEFT: {0}px; WIDTH: {1}px; POSITION: absolute; TOP: {2}px; POSITION: absolute\" FNSType=\"combobox\"><SELECT class=\"comboboxselect\" style=\"LEFT:{3}px; WIDTH: {4}px; POSITION: absolute; POSITION: absolute\" tabindex=\"{5}\" readonly=\"{6}\" maxlength=\"{7}\" name=\"{8}\" FNSType=\"comboboxselect\" RXField=\"{9}\" TXField=\"{10}\" DisplayFormat=\"{11}\" SelectionSet=\"default.htm\"><OPTION value=\"\" selected=\"-1\"></OPTION></SELECT>{12}</FIELDSET>",
                                    lleftSpace, lwidth, ltopSpace, lwidth + 10, iwidth, tabindex, readOnly, maxLength, iName, idList[counter].Id, idList[counter].Id, displayFormat, idList[counter].Label);

                        }

                        sb.Append(elementData);
                        counter++;
                        tabindex++;
                    }
                }
                lleftSpace = lleftSpace + horizontalGap;
            }
            ltopSpace = ltopSpace + verticalGap;
            lleftSpace = leftSpaceMaster;
        }

        private void GenerateUI_Load(object sender, EventArgs e)
        {
            foreach (Utilities.UtilityClass.ControlTypes.UIType controlItem in Enum.GetValues(typeof(Utilities.UtilityClass.ControlTypes.UIType)))
                comboBoxUI.Items.Add(controlItem.ToString());

            foreach (Utilities.UtilityClass.ControlTypes.ControlType controlItem in Enum.GetValues(typeof(Utilities.UtilityClass.ControlTypes.ControlType)))
                comboBoxControlType.Items.Add(controlItem.ToString());

            comboBoxControlType.SelectedIndex = 0;
            comboBoxTXRX.SelectedIndex = 0;
            comboBoxUI.SelectedIndex = 0;
            comboBoxReadOnly.SelectedIndex = 0;
            comboBoxXMLType.SelectedIndex = 0;
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxDestination.Text))
                Clipboard.SetText(textBoxDestination.Text, TextDataFormat.Text);
        }

        private void comboBoxUI_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxViewPane_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxViewPane.Checked)
            {
                webBrowserUI.Visible = false;
                textBoxXMLViewer.Visible = true;
            }
            else
            {
                webBrowserUI.Visible = true;
                textBoxXMLViewer.Visible = false;
            }
        }

        private void checkBoxCodeViewPane_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxCodeViewPane.Checked)
                textBoxDestination.Visible = false;
            else
                textBoxDestination.Visible = true;
        }

        private void textBoxDestination_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxTryNow_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxUI.SelectedItem.ToString() != "KENDO" && checkBoxTryNow.Checked)
            {
                textBoxDestination.ReadOnly = false;
                buttonUpdateUI.Enabled = true;
            }
            else
            {
                textBoxDestination.ReadOnly = true;
                buttonUpdateUI.Enabled = false;
            }
        }

        private void buttonChromeView_Click(object sender, EventArgs e)
        {
            if (comboBoxUI.SelectedItem.ToString() != "KENDO")
            {
                try
                {
                    string htmltext = string.Format("<HTML><Head><link rel=\"stylesheet\" href=\"D:\\Resource\\css\\Screen.css\"></Head>{0}</HTML>", sb.ToString());
                    // Write the string to a file.
                    System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\tempHtml.html");
                    file.WriteLine(htmltext);

                    file.Close();

                    Process.Start(@"chrome.exe", "--incognito D:\\tempHtml.html");
                }
                catch { }
            }
            else
            {
                try
                {
                    string htmltext = string.Format("<HTML><Head><link rel=\"stylesheet\" href=\"D:\\Resource\\css\\Screen.css\"></Head>{0}</HTML>", sb.ToString());
                    // Write the string to a file.
                    System.IO.StreamWriter file = new System.IO.StreamWriter("D:\\Resource\\tempHtml.html");
                    file.WriteLine(htmltext);

                    file.Close();

                    Process.Start(@"chrome.exe", "--incognito D:\\Resource\\tempHtml.html");
                }
                catch { }
            }
        }

        private void labelFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialogFileLocation.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
                setFileLocation(openFileDialogFileLocation.FileName);
            else
                setFileLocation("");
        }

        private void buttonUpdateUI_Click(object sender, EventArgs e)
        {
            if (comboBoxUI.SelectedItem.ToString() != "KENDO" && checkBoxTryNow.Checked)
            {
                string htmltext = string.Format("<Head><link rel=\"stylesheet\" href=\"D:\\Resource\\css\\Screen.css\"></Head><HTML>{0}</HTML>", textBoxDestination.Text);
                webBrowserUI.DocumentText = htmltext;
            }
        }

        private void checkBoxAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAuto.Checked)
            {
                IsAuto = true;
            }
            else
                IsAuto = false;
        }


    }
}
