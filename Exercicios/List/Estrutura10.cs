namespace Exercicios.List
{
    internal class Estrutura10
    {
        public static void HistoricoDeNavegacao(List<string> url)
        {
            var total = url.Count;
            if (total > 10)
            {
                url.RemoveAt(0);
                Console.WriteLine($"Limite ultrapassado, lista atualizada: " + string.Join(", ", url));
                return;
            }
            Console.WriteLine(string.Join(", ", url));
        }
    }
}
