namespace Exercicios.BeeCrowd
{
    internal class ProdutoSimples
    {
        /*
         Leia dois valores inteiros. 
        A seguir, calcule o produto entre estes dois valores e atribua esta operação à variável PROD. 
        A seguir mostre a variável PROD com mensagem correspondente.
         */

        public static void ProdutoSimples1()
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var x = (a * b);
            Console.WriteLine($"PROD = " + x);
        }
    }
}
