namespace Exercicios.CodeWars
{
    public class DetectPangram
    {
        public static bool IsPangram(string str)
        {
            return str.ToLower().Where(ch => char.IsLetter(ch)).Distinct().Count() == 26;
        }

        public static bool Isnum(string letras)
        {
            string abc1 = "abcdefghijklmnopqrstuvwxyz";

            char[] @string = letras.ToCharArray();
            char[] alfabeto = abc1.ToCharArray();


            for (int i = 0; i < alfabeto.Length; i++)
            {
                bool encontrou = false;
                foreach (char u in @string)
                {
                    if (char.ToLower(u) == alfabeto[i])
                    {
                        encontrou = true;
                        break;
                    }
                }
                if (!encontrou)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
