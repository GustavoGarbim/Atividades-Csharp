namespace Exercicios.List
{
    internal class Estrutura1
    {
        static void Estrutura(string[] args)
        {
            List<string> Lista = new();
            var frase = "alguma coisa";
            var frase2 = "qualquer coisa";
            AdicionarNaLista(Lista, frase);
            Console.WriteLine("-------------------------------------");
            AdicionarNaLista(Lista, frase2);
            Console.WriteLine("-------------------------------------");
            ListarTarefas(Lista);
            Console.WriteLine("-------------------------------------");
            RemoverDaLista(Lista, 1);
            Console.WriteLine("-------------------------------------");
            ListarTarefas(Lista);
        }

        public static void AdicionarNaLista(List<string> Lista, string frase)
        {
            Lista.Add(frase);
            Console.WriteLine($"Adicionado: {frase}");
        }

        public static void RemoverDaLista(List<string> Lista, int indice)
        {
            Console.WriteLine($"Tarefa removida da Lista: {indice}");
            Lista.RemoveAt(indice);
        }

        public static void ListarTarefas(List<string> Lista)
        {
            int u = 0;
            foreach (string i in Lista)
            {
                Console.WriteLine($"Tarefa{u}: {i}");
                u++;
            }
        }
    }
}
