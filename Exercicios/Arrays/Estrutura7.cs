namespace Exercicios.Arrays
{
    internal class Estrutura7
    {
        public static void ContarOcorrencia(int[] Array)
        {
            int contagem = 0;
            int buscado = 2;
            foreach (int i in Array)
            {
                if (i == buscado)
                {
                    contagem++;
                }
            }
            Console.WriteLine($"Achei: {contagem} vezes.");
        }
    }
}
