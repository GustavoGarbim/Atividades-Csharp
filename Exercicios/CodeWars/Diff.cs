namespace Exercicios.CodeWars
{
    public class Diff
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            List<int> novo = new();

            foreach (int i in a)
            {
                if (!b.Contains(i))
                {
                    novo.Add(i);
                }
            }
            return novo.ToArray();
        }
    }
}
