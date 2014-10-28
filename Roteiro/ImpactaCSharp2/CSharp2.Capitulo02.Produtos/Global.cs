using System;
using System.Windows.Forms;

namespace CSharp2.Capitulo02.Produtos
{
    public class Global
    {
        private static readonly log4net.ILog _log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void TratarErro(string mensagem, Exception ex)
        {
            MessageBox.Show(mensagem);
            _log.Error(ex);
        }
    }
}