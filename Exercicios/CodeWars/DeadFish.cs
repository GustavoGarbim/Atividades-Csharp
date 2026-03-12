namespace Exercicios.CodeWars
{

    /*
     Crie um analisador sintático para interpretar e executar a linguagem Deadfish.

     O Deadfish opera com um único valor na memória, que inicialmente é definido como 0.

    Ele utiliza quatro comandos de um único caractere:

    i: Incrementar o valor
    d: Diminua o valor
    s: Eleve o valor ao quadrado
    o: Exibir o valor em uma matriz de resultados
    Todas as outras instruções são nulas e não têm efeito.

    Exemplos:

    "iiisdoso" deve retornar números [8, 64].
    "iiisdosodddddiso" deve retornar números [8, 64, 3600].
     */
    public class DeadFish
    {
        public static int[] Parse(string data)
        {
            List<int> Lista = new();
            int temp = 0;

            foreach (char letra in data)
            {
                switch (letra)
                {
                    case 'i':
                        temp++;
                        break;
                    case 'd':
                        temp--;
                        break;
                    case 's':
                        temp = (temp * temp);
                        break;
                    case 'o':
                        Lista.Add(temp);
                        break;
                }
            }
            return Lista.ToArray();
        }
    }
}
