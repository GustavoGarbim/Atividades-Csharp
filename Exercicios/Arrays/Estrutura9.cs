namespace Exercicios.Arrays
{
    internal class Estrutura9
    {
        public static void SegundoMaiorElemento(int[] Array)
        {
            var maior = 0;
            var segundoMaior = 0;
            foreach (int i in Array)
            {
                if (i > maior)
                {
                    segundoMaior = maior;
                    maior = i;
                }
                else if (i > segundoMaior)
                {
                    segundoMaior = i;
                }
            }

            Console.WriteLine($"Maior: {maior}, Segundo Maior: {segundoMaior}");
        }
    }
}
