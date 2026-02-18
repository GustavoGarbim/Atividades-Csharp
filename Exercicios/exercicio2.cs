using System;

namespace Exercicios
{
    public class exercicio2
    {
        public class Chamado
        {
            public int ID { get; set; }
            public string NomeChamado { get; set; }
            public int ResponsavelChamadoID { get; set; }
            public string StatusChamado { get; set; } = "Aberto";

            List<Chamado> chamados = new List<Chamado>();

            public void AbrirChamado(Chamado chamado)
            {
                Console.WriteLine($"Chamado '{chamado.NomeChamado}' aberto com ID {chamado.ID}.");
                chamados.Add(chamado);
            }

            public void AtribuirChamado(int chamadoId, int responsavelId)
            {
                chamados.Find(c => c.ID == chamadoId).ResponsavelChamadoID = responsavelId;
                Console.WriteLine($"Chamado: {chamadoId}, foi atribuido para: {responsavelId}.");
            }

            public void ResolverChamado(int chamadoId)
            {
                chamados.Find(c => c.ID == chamadoId).StatusChamado = "Resolvido";
                Console.WriteLine($"Chamado: {chamadoId}, foi resolvido.");
            }

            public void ListarChamados()
            {
                Console.WriteLine("Lista de Chamados:");
                foreach (var chamado in chamados)
                {
                    Console.WriteLine($"ID: {chamado.ID}, Nome: {chamado.NomeChamado}, Responsável ID: {chamado.ResponsavelChamadoID}, Status: {chamado.StatusChamado}");
                }
            }

            public void BuscarChamado(int chamadoId)
            {
                var chamado = chamados.Find(c => c.ID == chamadoId);
                if (chamado != null)
                {
                    Console.WriteLine($"ID: {chamado.ID}, Nome: {chamado.NomeChamado}, Responsável ID: {chamado.ResponsavelChamadoID}, Status: {chamado.StatusChamado}");
                }
                else
                {
                    Console.WriteLine($"Chamado com ID {chamadoId} não encontrado.");
                }
            }
        }

        static void Main3(string[] args)
        {
            Chamado chamado = new Chamado();
            while (true)
            {
                Console.WriteLine("Digite um comando (abrir, atribuir, resolver, listar, buscar, sair):");
                string comando = Console.ReadLine();
                if (comando == "sair")
                {
                    break;
                }
                else if (comando == "abrir")
                {
                    Console.WriteLine("Digite o nome do chamado:");
                    string nomeChamado = Console.ReadLine();
                    Chamado novoChamado = new Chamado { ID = new Random().Next(1, 1000), NomeChamado = nomeChamado };
                    chamado.AbrirChamado(novoChamado);
                }
                else if (comando == "atribuir")
                {
                    Console.WriteLine("Digite o ID do chamado:");
                    int chamadoId = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o ID do responsável:");
                    int responsavelId = int.Parse(Console.ReadLine());
                    chamado.AtribuirChamado(chamadoId, responsavelId);
                }
                else if (comando == "resolver")
                {
                    Console.WriteLine("Digite o ID do chamado:");
                    int chamadoId = int.Parse(Console.ReadLine());
                    chamado.ResolverChamado(chamadoId);
                }
                else if (comando == "listar")
                {
                    chamado.ListarChamados();
                }
                else if (comando == "buscar")
                {
                    Console.WriteLine("Digite o ID do chamado:");
                    int chamadoId = int.Parse(Console.ReadLine());
                    chamado.BuscarChamado(chamadoId);
                }
            }
        }
    }
}