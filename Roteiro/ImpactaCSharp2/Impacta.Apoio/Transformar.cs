namespace Impacta.Apoio
{
    public static class Transformar
    {
        public static string RemoverAcentuacao(string texto)
        {
            const string comAcento = "çÇáàâãäÁÀÂÃÄëéèêËÉÈÊiíïîìÍÏÌÎöóòôõÖÓÒÔÕüúùûÜÚÙÛ";
            const string semAcento = "cCaaaaaAAAAAeeeeEEEEiiiiiIIIIoooooOOOOOuuuuUUUU";

            for (var i = 0; i < comAcento.Length - 1; i++)
            {
                texto = texto.Replace(comAcento[i], semAcento[i]);
            }

            return texto;
        }

        public static void Ordenar(int[] vetor)
        {
            Ordenar(vetor, 0, vetor.Length - 1);
        }

        /// <summary>
        /// http://pt.wikipedia.org/wiki/Quicksort#C.23
        /// </summary>
        /// <param name="vetor"></param>
        /// <param name="inicio"></param>
        /// <param name="fim"></param>
        private static void Ordenar(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                var posicaoPivo = Particionar(vetor, inicio, fim);
                Ordenar(vetor, inicio, posicaoPivo - 1);
                Ordenar(vetor, posicaoPivo + 1, fim);
            }
        }

        private static int Particionar(int[] vetor, int inicio, int fim)
        {
            var pivo = vetor[inicio];
            int i = inicio + 1, f = fim;
            while (i <= f)
            {
                if (vetor[i] <= pivo)
                    i++;
                else if (pivo < vetor[f])
                    f--;
                else
                {
                    int troca = vetor[i];
                    vetor[i] = vetor[f];
                    vetor[f] = troca;
                    i++;
                    f--;
                }
            }
            vetor[inicio] = vetor[f];
            vetor[f] = pivo;
            return f;
        }
    }
}