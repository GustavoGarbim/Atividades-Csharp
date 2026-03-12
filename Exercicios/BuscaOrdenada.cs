using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios
{
    public class Program2
    {
        static void Main2(string[] args)
        {
            List<Tarefas> ListaTarefas = new();

            ListaTarefas.Add(new Tarefas(1, "Tarefa1"));
            ListaTarefas.Add(new Tarefas(2, "Tarefa2"));
            ListaTarefas.Add(new Tarefas(3, "Tarefa3"));
            ListaTarefas.Add(new Tarefas(4, "Tarefa4"));
            ListaTarefas.Add(new Tarefas(5, "Tarefa5"));
            ListaTarefas.Add(new Tarefas(6, "Tarefa6"));
            ListaTarefas.Add(new Tarefas(7, "Tarefa7"));

            Console.WriteLine("Digite o ID da tarefa que você deseja: ");


            var tarefa = BuscarTarefa(ListaTarefas, 3);
            var tarefa2 = BuscarTarefas2(ListaTarefas, 5);
            Console.WriteLine($"Tarefa encontrada: ID: {tarefa?.IdTarefa}, Nome: {tarefa?.NomeTarefa}");

            Console.WriteLine($"Tarefa encontrada: ID: {tarefa2?.IdTarefa}, Nome: {tarefa2?.NomeTarefa}");
        }

        public class Tarefas
        {
            public int IdTarefa { get; set; }
            public string NomeTarefa { get; set; }

            public Tarefas(int idTarefa, string nomeTarefa)
            {
                IdTarefa = idTarefa;
                NomeTarefa = nomeTarefa;
            }
        }

        public static Tarefas? BuscarTarefas2(List<Tarefas> ListaDeTarefas, int idBusca)
        {
            Console.Write("Digite o Id da Tarefa que deseja buscar: ");
            var tarefa = ListaDeTarefas.Find(c => c.IdTarefa == idBusca);
            if (ListaDeTarefas != null)
            {
                return tarefa;
            }
            return null;
        }


        public static Tarefas? BuscarTarefa(List<Tarefas> ListaDeTarefas, int idBusca)
        {
            Console.Write("Digite o Id da Tarefa que deseja buscar: ");
            try
            {
                Tarefas? tarefaEncontrada = null;

                int inicio = 0;
                int fim = ListaDeTarefas.Count - 1;

                while (inicio <= fim)
                {
                    int meio = inicio + (fim - inicio) / 2;
                    if (ListaDeTarefas[meio].IdTarefa == idBusca)
                    {
                        tarefaEncontrada = ListaDeTarefas[meio];
                        break;
                    }

                    if (ListaDeTarefas[meio].IdTarefa < idBusca)
                    {
                        inicio = meio + 1;
                    }
                    else
                    {
                        fim = meio - 1;
                    }
                }
                if (tarefaEncontrada != null)
                {
                    return tarefaEncontrada;
                }
                else
                {
                    Console.WriteLine("Tarefa não encontrada.");
                    return null;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: Digite apenas números para o ID.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro inesperado ao buscar tarefa: {ex.Message}");
                return null;
            }
        }
    }
}
