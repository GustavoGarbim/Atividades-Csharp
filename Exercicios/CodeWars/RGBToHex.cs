namespace Exercicios.CodeWars
{
    public class RGBToHex
    {
        public static string Rgb(int r, int g, int b)
        {
            int[] @array = [r, g, b];
            string @string = "";

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    array[i] = 0;
                }
                else if (array[i] > 255)
                {
                    array[i] = 255;
                }
                @string += array[i].ToString("X2");
            }

            return @string;
        }
    }
}
