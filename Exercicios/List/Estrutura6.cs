namespace Exercicios.List
{
    internal class Estrutura6
    {
        public static void RemoverElementosPorCondicao(List<int> lista)
        {
            lista.RemoveAll(c => c < 0);
            lista.Sort();
            Console.WriteLine(string.Join(", ", lista));
        }
    }
}
