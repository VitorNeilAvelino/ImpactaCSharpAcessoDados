using System.Windows.Forms;

namespace Impacta.Apoio.WindowsForms.Controles
{
    static class Extensoes
    {
        public static void FocarProximoControle(this Control controle, object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{tab}");
            }
        }
    }
}