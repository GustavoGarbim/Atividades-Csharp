namespace Exercicios.List
{
    internal class Estrutura4
    {
        public static void TopNElementos(List<int> lista, int n)
        {
            List<int> listaMaiores = new();
            int aux = 0;
            for (int i = 0; i < lista.Count - 1; i++)
            {
                for (int u = 0; u < lista.Count - 1; u++)
                {
                    if (lista[u] > lista[u + 1])
                    {
                        aux = lista[u + 1];
                        lista[u + 1] = lista[u];
                        lista[u] = aux;
                    }
                }
            }
            var numeros = lista.TakeLast(n).ToList().OrderDescending();
            listaMaiores.AddRange(numeros);
            Console.WriteLine(string.Join(", ", listaMaiores));
        }
    }
}
