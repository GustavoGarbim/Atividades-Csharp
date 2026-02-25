namespace Exercicios.LinkedList
{
    internal class Estrutura2
    {
        public static void RemoverNosDuplicados(LinkedList<int> lista)
        {
            LinkedListNode<int> atual = lista.First;
            List<int> listaNormal = new();

            while (atual != null)
            {
                var proximo = atual.Next;
                if (listaNormal.Contains(atual.Value))
                {
                    lista.Remove(atual);
                }
                else
                {
                    listaNormal.Add(atual.Value);
                }
                atual = proximo;
            }
            Console.WriteLine(string.Join(", ", lista));
        }
    }
}
