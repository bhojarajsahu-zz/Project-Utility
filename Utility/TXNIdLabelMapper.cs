using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities.UtilityClass;

namespace Utilities
{
    public partial class TXNIdLabelMapper : Form
    {
        public List<UIElement> newUiElementList = new List<UIElement>();
        string contrylType = string.Empty;
        bool IsField = true;
        public TXNIdLabelMapper()
        {
            InitializeComponent();
        }
        public void setTransactionValue(List<UIElement> uiElement, string selContrylType, bool isField = true, string title = "Label and Default value mapper")
        {
            this.Text = title;
            newUiElementList = new List<UIElement>();
            newUiElementList = uiElement;
            contrylType = selContrylType;
            IsField = isField;
        }

        private void TXNIdLabelMapper_Load(object sender, EventArgs e)
        {
            int xLocation = 30;
            int yLocation = 30;

            Label myLblId = new Label();
            myLblId.Name = "lblId";
            myLblId.Text = "Id";
            myLblId.Location = new Point(xLocation, yLocation);
            this.Controls.Add(myLblId);

            Label myLblValue = new Label();
            myLblValue.Name = "lblValue";
            myLblValue.Text = "Display Text";
            myLblValue.Location = new Point(xLocation + 100, yLocation);
            this.Controls.Add(myLblValue);

            Label myLblDef = new Label();
            myLblDef.Name = "lblDefault";
            myLblDef.Text = "Default Value";
            myLblDef.Location = new Point(xLocation + 280, yLocation);
            this.Controls.Add(myLblDef);

            Label myLblType = new Label();
            myLblType.Name = "lblControlType";
            myLblType.Text = "Control Type";
            myLblType.Location = new Point(xLocation + 460, yLocation);
            this.Controls.Add(myLblType);

            yLocation = yLocation + 25;

            foreach (UIElement item in newUiElementList)
            {
                Label myLbl = new Label();
                myLbl.Name = "lbl" + item.Id;
                myLbl.Text = item.Id;
                myLbl.Location = new Point(xLocation, yLocation);
                this.Controls.Add(myLbl);

                TextBox myText = new TextBox();
                myText.Name = "txt" + item.Id;
                myText.Size = new Size(170, 20);
                myText.Location = new Point(xLocation + 100, yLocation);
                myText.Text = item.Label == null ? string.Empty : item.Label;
                this.Controls.Add(myText);

                TextBox myTextDef = new TextBox();
                myTextDef.Name = "txtDefault" + item.Id + "Default";
                myTextDef.Size = new Size(170, 20);
                myTextDef.Location = new Point(xLocation + 280, yLocation);
                myTextDef.Text = item.Label == null ? string.Empty : item.Label;
                myTextDef.Enabled = IsField;
                this.Controls.Add(myTextDef);

                ComboBox myCombo = new ComboBox();
                myCombo.Name = "combo" + item.Id;
                myCombo.Size = new Size(170, 20);
                myCombo.Location = new Point(xLocation + 460, yLocation);
                myCombo.DropDownStyle = ComboBoxStyle.DropDownList;
                myCombo.Enabled = IsField;

                try
                {

                    foreach (Utilities.UtilityClass.ControlTypes.ControlType controlItem in Enum.GetValues(typeof(Utilities.UtilityClass.ControlTypes.ControlType)))
                        myCombo.Items.Add(controlItem.ToString());

                    myCombo.SelectedItem = contrylType;
                }
                catch (Exception ex) { }

                this.Controls.Add(myCombo);


                yLocation = yLocation + 25;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            foreach (UIElement item in newUiElementList)
            {
                foreach (Control childc in Controls)
                {
                    if (childc is TextBox && childc.Name.Contains("txt" + item.Id))
                        item.Label = ((TextBox)childc).Text;

                    if (childc is TextBox && childc.Name.Contains("txtDefault" + item.Id))
                        item.Value = ((TextBox)childc).Text;

                    if (childc is ComboBox && childc.Name.Contains("combo" + item.Id))
                    {
                        foreach (Utilities.UtilityClass.ControlTypes.ControlType controlItem in Enum.GetValues(typeof(Utilities.UtilityClass.ControlTypes.ControlType)))
                        {
                            if (controlItem.ToString() == childc.Text)
                                item.ControlType = controlItem;

                        }
                    }
                }
            }

            GenerateUI parent = (GenerateUI)this.Owner;
            if (IsField)
                parent.updatetext(newUiElementList);
            else
                parent.updateCollItem(newUiElementList);
            this.Close();
        }
    }
}
