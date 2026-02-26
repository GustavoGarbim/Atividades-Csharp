namespace Exercicios.CodeWars
{
    internal class Digital_Root
    {
        /*
         A raiz digital é a soma recursiva de todos os dígitos de um número.


         Dado um valor n, some os dígitos de n. 
         Se esse valor tiver mais de um dígito, continue reduzindo dessa forma até obter um número com um único dígito. 
         A entrada será um número inteiro não negativo.
         */

        public static void Soma(long n)
        {
            while (n >= 10)
            {
                var texto = n.ToString();
                char[] @char = texto.ToCharArray();
                var soma = 0;

                for (int i = 0; i < @char.Length; i++)
                {
                    soma += (@char[i] - '0');
                }

                n = soma;
            }
            Console.WriteLine(n);
        }
    }
}
