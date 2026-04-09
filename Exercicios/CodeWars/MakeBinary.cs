namespace Exercicios.CodeWars
{
    internal class MakeBinary
    {
        public static string AddBinary(int a, int b)
        {
            string resultado = "";
            int Somabinaria = a + b;
            if (Somabinaria == 0) return "0";
            while (Somabinaria > 0)
            {
                int resto = Somabinaria % 2;
                resultado = resto + resultado;
                Somabinaria = Somabinaria / 2;
            }
            return resultado;
        }
    }
}
