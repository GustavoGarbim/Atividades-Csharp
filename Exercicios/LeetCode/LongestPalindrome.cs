namespace Exercicios.LeetCode
{
    public class LongestPalindrome
    {
        public int LongestPalindrome2(string s)
        {
            Dictionary<char, int> contagem = new();
            int comprimento = 0;
            bool temImpar = false;

            foreach (char c in s)
            {
                if (contagem.ContainsKey(c))
                    contagem[c]++;
                else
                    contagem[c] = 1;
            }

            foreach (var par in contagem)
            {
                int quantidade = par.Value;
                comprimento += (quantidade / 2) * 2;

                if (quantidade % 2 == 1)
                {
                    temImpar = true;
                }
            }

            return temImpar ? comprimento + 1 : comprimento;
        }
    }
}
