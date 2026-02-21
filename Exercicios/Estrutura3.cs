namespace Exercicios
{
    internal class Estrutura3
    {
        public static void InverterArray(int[] numeros)
        {
            int esquerda = 0;
            int direita = numeros.Length - 1;
            while (esquerda < direita)
            {
                var posicao = numeros[direita];
                numeros[direita] = numeros[esquerda];
                numeros[esquerda] = posicao;
                esquerda++;
                direita--;
            }
        }
    }
}
