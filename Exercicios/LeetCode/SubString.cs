namespace Exercicios.LeetCode
{
    internal class SubString
    {
        public static int SubCadeia(string texto)
        {
            List<char> aux = new();
            int maiorTamanho = 0;

            char[] @char = texto.ToCharArray();
            foreach (char i in @char)
            {
                while (aux.Contains(i))
                {
                    aux.RemoveAt(0);
                }
                aux.Add(i);
                maiorTamanho = Math.Max(maiorTamanho, aux.Count());
            }
            return maiorTamanho;
        }
    }
}
