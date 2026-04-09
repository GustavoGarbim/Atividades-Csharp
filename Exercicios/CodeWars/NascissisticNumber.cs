namespace Exercicios.CodeWars
{
    public static class NascissisticNumber
    {
        public static bool Narcissistic(int value)
        {
            string coisa = value.ToString();
            char[] coisa2 = coisa.ToCharArray();

            int contagem = coisa2.Length;
            List<int> inteiros = new();
            double soma = 0;
            foreach (char i in coisa2)
            {
                int num = int.Parse(i.ToString());
                soma += Math.Pow(num, contagem);
            }
            string final = string.Join("", inteiros);
            if (soma == value) return true;
            return false;
        }
    }
}
