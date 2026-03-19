namespace Exercicios.CodeWars
{

    /*
        Implemente uma função que receba dois endereços IPv4 e retorne o número de endereços entre eles (incluindo o primeiro, excluindo o último).
        Todos os dados inseridos serão endereços IPv4 válidos em formato de string. 
        O último endereço será sempre maior que o primeiro.
     */

    public class IP
    {
        public static long IpsBetween(string start, string end)
        {
            string[] inicio = start.Split(".");
            string[] fim = end.Split(".");

            long bloco0 = long.Parse(inicio[0]);
            long bloco1 = long.Parse(inicio[1]);
            long bloco2 = long.Parse(inicio[2]);
            long bloco3 = long.Parse(inicio[3]);

            long valorInicio = (bloco0 * 16777216) + (bloco1 * 65536) + (bloco2 * 256) + bloco3;

            long bloco00 = long.Parse(fim[0]);
            long bloco01 = long.Parse(fim[1]);
            long bloco02 = long.Parse(fim[2]);
            long bloco03 = long.Parse(fim[3]);

            long valorFim = (bloco00 * 16777216) + (bloco01 * 65536) + (bloco02 * 256) + bloco03;

            return valorFim - valorInicio;
        }
    }
}
