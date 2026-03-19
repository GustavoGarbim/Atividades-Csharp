using System.Numerics;

namespace Exercicios.CodeWars
{

    /*
        Você deve criar uma função que converta duas strings para numeros e faça a soma deles.
        nivel 4 kyu.
     */

    internal class Sum
    {
        public static string Add(string a, string b)
        {
            BigInteger a1 = BigInteger.Parse(a);
            BigInteger b1 = BigInteger.Parse(b);

            return (a1 + b1).ToString();
        }
    }
}
