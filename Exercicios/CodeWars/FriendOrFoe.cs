namespace Exercicios.CodeWars
{

    /*
     Amigo ou Inimigo? = se o nome tiver 4 letras, é amigos, qualquer coisa fora isso é inimigo.
     */

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
