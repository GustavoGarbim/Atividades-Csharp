namespace Exercicios.CodeWars
{

    /*
     * Desafio: Sum of Parts
     * Lógica de otimização (Complexidade de tempo O(N)):
     * Para evitar o recálculo repetitivo que causaria lentidão em listas grandes,
     * a solução utiliza matemática simples:
     * 1. Calcula a soma total do array apenas uma vez.
     * 2. Guarda essa soma total como o primeiro item do resultado.
     * 3. Percorre o array subtraindo o valor do item atual da soma anterior.
     * 4. Converte a lista dinâmica resultante de volta para um array fixo no retorno.
     */

    public class SumOfParts
    {
        public static int[] PartsSums(int[] ls)
        {
            List<int> listasoma = new();
            var soma = 0;
            foreach (int i in ls)
            {
                soma += i;
            }

            listasoma.Add(soma);

            foreach (int i in ls)
            {
                soma -= i;
                listasoma.Add(soma);
            }

            return listasoma.ToArray();
        }
    }
}
