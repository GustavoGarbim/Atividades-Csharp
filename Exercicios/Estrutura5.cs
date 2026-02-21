namespace Exercicios
{
    internal class Estrutura5
    {
            //  int[,] matriz =
            //  {
            //      { 1, 2, 3 },
            //      { 4, 5, 6 },
            //      { 7, 8, 9 }
            //  };
            //  MatrizBidimensional(matriz);

        public static void MatrizBidimensional(int[,] matriz)
        {
            List<int> lista = new();
            foreach (int i in matriz)
            {
                if (i == matriz[0, 0])
                {
                    lista.Add(i);
                }
                else if (i == matriz[1, 1])
                {
                    lista.Add(i);
                }
                else if (i == matriz[2, 2])
                {
                    lista.Add(i);
                }
            }
            var proximo = 0;
            foreach(int i in lista)
            {
                proximo += i;
            }
            Console.WriteLine(proximo);
        }
    }
}
