using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Impacta.WindowsForms.UserControls
{
    public partial class EnterTextBoxUserControl : UserControl
    {
        public EnterTextBoxUserControl()
        {
            InitializeComponent();
        }

        [Browsable(true)]
        public override string Text { get { return enterTextBox.Text; } set { enterTextBox.Text = value; } }

        private void enterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }
    }
}
