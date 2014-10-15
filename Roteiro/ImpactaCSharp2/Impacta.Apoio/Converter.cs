using System;

namespace Impacta.Apoio
{
    // static - não precisa ser instanciado (new)
    public static class Converter
    {
        public static decimal ParaDecimal(string valor)
        {
            try
            {
                return Convert.ToDecimal(valor);
            }
            catch
            {
                // Arremessa uma nova instância da classe Exception contendo uma 
                // mensagem mais significativa para o usuário.
                throw new Exception("Digite um valor válido.");
            }
        }
    }
}