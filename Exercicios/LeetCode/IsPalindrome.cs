namespace Exercicios.LeetCode
{
    internal class IsPalindrome
    {
        public static bool Palindrome(int x)
        {
            string numeroTexto = x.ToString();
            var reverso = numeroTexto.Reverse();
            var reverso2 = string.Concat(reverso);

            if (reverso2 == numeroTexto)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
