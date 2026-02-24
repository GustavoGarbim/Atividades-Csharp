namespace Exercicios.Arrays
{
    internal class Estrutura10
    {
        public static void BubbleSort(int[] Array)
        {
            int aux = 0;
            for (int i = 0; i < Array.Length - 1; i++)
            {
                for (int u = 0; u < Array.Length - 1; u++)
                {
                    if (Array[u] > Array[u + 1])
                    {
                        aux = Array[u + 1];
                        Array[u + 1] = Array[u];
                        Array[u] = aux;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", Array));
        }
    }
}
