using System;
using System.Windows.Forms;

namespace Impacta.Apoio.WindowsForms.Controles
{
    public class EnterMaskedTextBox : MaskedTextBox
    {
        public EnterMaskedTextBox()
        {
            base.KeyDown += this.FocarProximoControle;
            base.Click += new System.EventHandler(PosicionarCursorAEsquerda);
        }

        private void PosicionarCursorAEsquerda(object sender, EventArgs e)
        {
            var formato = this.TextMaskFormat;
            
            this.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;

            if (this.Text.Trim() == string.Empty)
            {
                this.SelectionStart = 0;
            }

            this.TextMaskFormat = formato;
        }
    }
}