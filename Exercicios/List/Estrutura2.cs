namespace Exercicios.List
{
    internal class Estrutura2
    {
        public static void FiltrarNumerosPares(List<int> lista)
        {
            List<int> listaPares = new();
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] % 2 == 0)
                {
                    listaPares.Add(lista[i]);
                }
            }
            Console.WriteLine(string.Join(", ", listaPares));
        }
    }
}
