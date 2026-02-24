namespace Exercicios.Arrays
{
    internal class Exercicio8
    {
        public static void RemoverDuplicata(int[] Array)
        {
            List<int> lista = new();

            foreach (int i in Array)
            {
                if (!lista.Contains(i))
                {
                    lista.Add(i);
                }
            }
            Console.WriteLine(string.Join(", ", lista));
        }
    }
}
