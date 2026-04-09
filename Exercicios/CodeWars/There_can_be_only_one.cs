namespace Exercicios.CodeWars
{

    /*
        https://www.codewars.com/kata/57cc2edf58a06bc4ac0000b9/train/csharp
     */

    public static class NumberExtension
    {
        public static double FeetToCentimeters(this object val)
        {
            if (val is sbyte || val is byte || val is short || val is ushort ||
        val is int || val is uint || val is long || val is ulong ||
        val is float || val is double || val is decimal)
            {
                dynamic d = val;
                return (double) d * 30.48;
            }
            throw new Exception("Type is not numeric.");
        }

        public static double CentimetersToFeet(this object val)
        {
            if (val is sbyte || val is byte || val is short || val is ushort ||
        val is int || val is uint || val is long || val is ulong ||
        val is float || val is double || val is decimal)
            {
                dynamic d = val;
                return (double)d / 30.48;
            }

            throw new Exception("Type is not numeric.");
        }
    }
}