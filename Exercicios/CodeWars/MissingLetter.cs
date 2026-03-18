namespace Exercicios.CodeWars
{

    /*
     Letra faltante = passado um array de char, se estiver faltando alguma letra ordem alfabetica, irá ser adicionado automaticamente.
     */

    public class MissingLetter
    {
        public static char LetraQueFalta(char[] array)
        {
            char quefalta = 'a';
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i + 1] - array[i] != 1)
                {
                    quefalta = (char)(array[i] + 1);
                }
            }
            return quefalta;
        }
    }
}
