namespace Exercicios.List
{
    internal class Estrutura8
    {
        public static void EncontrarElementosComuns(List<int> lista1, List<int> lista2)
        {
            List<int> ElementosComuns = new();
            foreach (int i in lista1)
            {
                if (lista2.Contains(i))
                {
                    ElementosComuns.Add(i);
                }
            }
            Console.WriteLine($"Elementos em comum encontrados: {string.Join(", ", ElementosComuns)}");
        }

    }
}
