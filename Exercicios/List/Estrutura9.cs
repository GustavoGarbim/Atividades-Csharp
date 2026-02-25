namespace Exercicios.List
{
    internal class Estrutura9
    {
        public static void RotacionarLista(List<int> lista, int n)
        {
            for (int i = 0; i < n; i++)
            {
                var ultimo = lista.Count() - 1;
                lista.Insert(0, lista[ultimo]);
                lista.RemoveAt(lista.Count() - 1);
            }
            Console.WriteLine(string.Join(", ", lista));
        }
    }
}
