namespace Exercicios.Arrays
{
    internal class Estrutura1
    {
        public static void SomaElementos(int[] valores)
        {
            var proximo = 0;
            foreach (int atual in valores)
            {
                proximo += atual;
            }
            Console.WriteLine($"Total: {proximo}");
        }
    }
}
