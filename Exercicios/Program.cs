namespace Exercicios
{
    public class Program
    {
        static void Main(string[] args)
        {
            string palin = "racecar";
            LongestPalindrome(palin);
        }

        public static void LongestPalindrome(string s)
        {
            List<char> aux = new();
            for(int i = 1; i<s.Length - 1; i++)
            {
                int esquerda = i-1;
                int direita = i+1;
                while (esquerda >= 0 && direita < s.Length && s[esquerda] == s[direita])
                {
                    aux.Add(s[i]);
                    esquerda--;
                    direita++;
                }
            }
            Console.WriteLine(string.Join(", ", aux));
        }
    }
}