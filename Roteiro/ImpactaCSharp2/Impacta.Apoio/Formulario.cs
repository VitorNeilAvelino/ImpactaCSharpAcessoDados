using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Impacta.Apoio
{
    public static class Formulario
    {
        public static bool ValidarCamposObrigatorios(Form formulario, ErrorProvider provedorDeErro)
        {
            bool validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                if (controle.Tag != null && controle.Tag.ToString().Contains("*"))
                {
                    provedorDeErro.SetError(controle, string.Empty);

                    if (controle.Text.Trim() == string.Empty || controle.ObterTextoSemMascara() == string.Empty)
                    {
                        validacao = false;
                        provedorDeErro.SetError(controle, "Campo obrigatório.");
                        controle.Focus();
                    }
                }
            }

            return validacao;
        }

        public static bool ValidarTipoDosDados(Form formulario, ErrorProvider provedorDeErro)
        {
            bool validacao = true;

            foreach (Control controle in formulario.Controls)
            {
                provedorDeErro.SetError(controle, "");

                try
                {
                    if (controle.Tag == null) continue;

                    if (controle.Tag.ToString().ToUpper().Contains("DECIMAL"))
                    {
                        Convert.ToDecimal(controle.Text);
                    }
                    else if (controle.Tag.ToString().ToUpper().Contains("EMAIL"))
                    {
                        if (!Regex.IsMatch(controle.Text, @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9._-]+\.[a-zA-Z]+$"))
                        //if (!Regex.IsMatch(controle.Text, @"^(.+)@(.+).(.+)$"))
                        {
                            throw new FormatException("EMAIL");
                        }
                    }
                    else if (controle.Tag.ToString().ToUpper().Contains("DATETIME"))
                    {
                        Convert.ToDateTime(controle.Text);
                    }
                    else if (controle.Tag.ToString().ToUpper().Contains("CPF"))
                    {
                        if (!Validar.Cpf(controle.Text))
                        {
                            throw new FormatException("CPF");
                        }
                    }
                    else if (controle.Tag.ToString().ToUpper().Contains("TEXTOSEMNUMEROS"))
                    {
                        if (Regex.IsMatch(controle.Text, @"[0-9]"))
                        {
                            throw new FormatException("TEXTOSEMNUMEROS");
                        }
                    }
                }
                catch
                {
                    validacao = false;
                    provedorDeErro.SetError(controle, "Valor inválido");
                    controle.Focus();
                }
            }

            return validacao;
        }

        public static bool ValidarTipoDosDados(IFormularioComErrorProvider formulario)
        {
            return ValidarTipoDosDados((Form)formulario, formulario.ProvedorDeErro);
        }

        public static void Limpar(this Form formulario)
        {
            foreach (Control controle in formulario.Controls)
            {
                if (controle is TextBox || controle is MaskedTextBox)
                {
                    controle.Text = string.Empty;
                }
                else if (controle is ComboBox)
                {
                    ((ComboBox)controle).SelectedIndex = -1;
                }
            }
        }
    }
}