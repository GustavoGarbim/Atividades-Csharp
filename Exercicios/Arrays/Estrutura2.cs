namespace Exercicios.Arrays
{
    internal class Estrutura2
    {
        public static void MaiorElemento(double[] fileira)
        {
            var maior = fileira[0];
            foreach (double atual in fileira)
            {
                if (atual > maior)
                {
                    maior = atual;
                }
            }
            Console.WriteLine(maior);
        }
    }
}
