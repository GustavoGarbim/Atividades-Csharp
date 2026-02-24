namespace Exercicios.Arrays
{
    internal class Estrutura6
    {
        public static void BuscarLinear(int[] Array)
        {
            var valorBuscado = 782;
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] == valorBuscado)
                {
                    Console.WriteLine($"Achamos! Posição: {i}");
                    return;
                }
            }
            Console.WriteLine("Não achamos... " + -1);
        }
    }
}
