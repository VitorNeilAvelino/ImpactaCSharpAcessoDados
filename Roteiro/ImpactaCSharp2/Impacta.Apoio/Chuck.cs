namespace Impacta.Apoio
{
    public static class Chuck
    {
        public static void KickSort(int[] vetor)
        {
            KickSort(vetor, 0, vetor.Length - 1);
        }

        private static void KickSort(int[] vetor, int inicio, int fim)
        {
            if (inicio < fim)
            {
                var posicaoPivo = Particionar(vetor, inicio, fim);
                KickSort(vetor, inicio, posicaoPivo - 1);
                KickSort(vetor, posicaoPivo + 1, fim);
            }
        }

        private static int Particionar(int[] vetor, int inicio, int fim)
        {
            var pivo = vetor[inicio];
            int i = inicio + 1, f = fim;

            while (i <= f)
            {
                if (vetor[i] <= pivo)
                {
                    i++;
                }
                else if (pivo < vetor[f])
                {
                    f--;
                }
                else
                {
                    Trocar(vetor, i, f);
                    i++;
                    f--;
                }
            }
            
            Trocar(vetor, inicio, f);
            return f;
        }

        private static void Trocar(int[] vetor, int i, int f)
        {
            var aux = vetor[i];
            vetor[i] = vetor[f];
            vetor[f] = aux;
        }
    }
}