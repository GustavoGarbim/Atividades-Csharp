namespace Exercicios.List
{
    internal class Estrutura7
    {
        public static void AgruparPorCritério(List<int> lista)
        {
            List<int> listaPares = new();
            List<int> listaImpares = new();

            foreach (int i in lista)
            {
                if (i % 2 == 0)
                {
                    listaPares.Add(i);
                }
                else
                {
                    listaImpares.Add(i);
                }
            }
            var listaParesFormatada = string.Join(", ", listaPares);
            var listaImparesFormatada = string.Join(", ", listaImpares);

            Console.WriteLine($"Lista de Pares: {listaParesFormatada}");
            Console.WriteLine($"Lista de Impares: {listaImparesFormatada}");
        }
    }
}
