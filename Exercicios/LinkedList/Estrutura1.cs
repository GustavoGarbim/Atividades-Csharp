namespace Exercicios.LinkedList
{
    internal class Estrutura1
    {
        public static void InsercaoOrdenada(LinkedList<int> lista, int numero)
        {
            LinkedListNode<int> atual = lista.First;

            while (atual != null)
            {
                if (atual.Value > numero)
                {
                    lista.AddBefore(atual, numero);
                    return;
                }
                else
                {
                    atual = atual.Next;
                }

            }
            lista.AddLast(numero);
        }
    }
}
