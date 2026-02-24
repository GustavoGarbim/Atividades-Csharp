namespace Exercicios.List
{
    internal class Estrutura5
    {
        public static void MesclarListasOrdenadas(List<int> lista1, List<int> lista2)
        {
            List<int> listaFinal = new();

            listaFinal.AddRange(lista1);
            listaFinal.AddRange(lista2);
            var final = listaFinal.Order();
            Console.WriteLine(string.Join(", ", final));
        }

        public static void MesclarListasOrdenadas2(List<int> lista1, List<int> lista2)
        {
            List<int> listaFinal = lista1.Concat(lista2).OrderBy(x => x).ToList();
            Console.WriteLine(string.Join(", ", listaFinal));
        }
    }
}
