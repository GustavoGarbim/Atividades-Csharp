using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    internal class Estrutura4
    {
        public static void MediaNotas(int[] notas)
        {
            var proximo = 0;
            List<int> lista = new();
            foreach (int atual in notas)
            {
                proximo += atual;
            }
            var valor = notas.Count();
            var calculo = proximo / valor;
            foreach (int atual in notas)
            {
                if (atual > calculo)
                {
                    lista.Add(atual);
                }
            }
            Console.WriteLine("Notas acima da media: " + string.Join(", ", lista));
            Console.WriteLine(calculo);
        }
    }
}
