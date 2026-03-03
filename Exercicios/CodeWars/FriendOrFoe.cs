namespace Exercicios.CodeWars
{
    public class FriendOrFoe
    {
        public static IEnumerable<string> FriendFoe(string[] names)
        {
            List<string> ListaNomesAmigos = new();
            foreach (string i in names)
            {
                if (i.Length == 4)
                {
                    ListaNomesAmigos.Add(i);
                }
            }
            return ListaNomesAmigos;
        }
    }
}
