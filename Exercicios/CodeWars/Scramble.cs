/*
    Você recebe duas str (str1 e str2), você deve ver se, organizando as letras embaralhadas da str1, forma a palavra correta da str2.
 */

namespace Exercicios.CodeWars
{
    public class Scramble
    {
        public static bool Scramble2(string str1, string str2)
        {
            Dictionary<char, int> dicionario = new();
            foreach (char i in str1)
            {
                if (dicionario.ContainsKey(i))
                {
                    dicionario[i]++;
                }
                else
                {
                    dicionario.Add(i, 1);
                }
            }

            foreach (char i in str2)
            {
                if (dicionario.ContainsKey(i) && dicionario[i] > 0)
                {
                    dicionario[i]--;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
