namespace Exercicios.BeeCrowd
{
    internal class Media1
    {
        /*
         Leia 2 valores de ponto flutuante de dupla precisão A e B, 
        que correspondem a 2 notas de um aluno. A seguir, calcule a média do aluno, 
        sabendo que a nota A tem peso 3.5 e a nota B tem peso 7.5 (A soma dos pesos portanto é 11). 
        Assuma que cada nota pode ir de 0 até 10.0, sempre com uma casa decimal.
         */
        public static void Media()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());

            double mediapeso = (A * 3.5) + (B * 7.5);
            double somarperos = 3.5 + 7.5;
            double media = mediapeso / somarperos;
            Console.WriteLine("MEDIA = " + media.ToString("f5"));
        }
    }
}
