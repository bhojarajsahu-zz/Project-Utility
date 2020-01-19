using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities
{
    public partial class SBLFormProperty : Form
    {
        public SBLFormProperty()
        {
            InitializeComponent();
        }

        private void buttonApplySettings_Click(object sender, EventArgs e)
        {
            GenerateUI parent = (GenerateUI)this.Owner;
            parent.updateSBLSettings(textBoxWidth.Text, textBoxHeight.Text, textBoxName.Text, textBoxRX.Text, textBoxTX.Text, textBoxLWidth.Text, textBoxIWidth.Text, textBoxTSpace.Text, textBoxLSpace.Text, textBoxVGap.Text, textBoxHGap.Text);
            this.Close();
        }
    }
}
