namespace Exercicios.CodeWars
{

    /*
     Contador de vogais nas palavras.
     */

    public class VowelCount
    {
        public static void GetVowelCount(string palavra)
        {
            char[] arrayChar = palavra.ToCharArray();
            int aux = 0;
            foreach (char i in arrayChar)
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                {
                    aux++;
                }
            }
            Console.WriteLine(aux);
        }
    }
}
