using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
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
