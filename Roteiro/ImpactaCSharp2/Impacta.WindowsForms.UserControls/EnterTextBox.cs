using System.Windows.Forms;

namespace Impacta.Apoio.WindowsForms.Controles
{
    public class EnterTextBox : TextBox
    {
        public EnterTextBox()
        {
            base.KeyDown += this.FocarProximoControle;
        }

        //private static void FocarProximoControle(object sender, KeyEventArgs e)
        //{
        //    if (e.KeyCode == Keys.Enter)
        //    {
        //        SendKeys.Send("{tab}");
        //    }
        //}
    }
}