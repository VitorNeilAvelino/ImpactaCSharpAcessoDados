using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Impacta.WindowsForms.Controles
{
    public class EnterTextBox : TextBox
    {
        public EnterTextBox()
        {
            base.KeyDown += FocarProximoControle;
        }

        private void FocarProximoControle(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }
    }
}
