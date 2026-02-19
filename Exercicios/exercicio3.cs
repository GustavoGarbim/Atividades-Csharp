namespace Exercicios
{
    public class exercicio3
    {
        public class Compromisso
        {
            public string NomeCompromisso { get; set; }
            public TimeOnly Horario { get; set; }

            public List<Compromisso> compromissos = new List<Compromisso>();

            public void ListarCompromissos()
            {
                foreach (var compromisso in compromissos)
                {
                    Console.WriteLine($"Compromisso: {compromisso.NomeCompromisso}, Horário: {compromisso.Horario}");
                }
            }

            public void AdicionarNaLista(Compromisso compromisso)
            {
                compromissos.Add(compromisso);
            }

            public void BuscarCompromisso(string nomeCompromisso)
            {
                var compromisso = compromissos.Find(c => c.NomeCompromisso == nomeCompromisso);
                if (compromisso != null)
                {
                    Console.WriteLine($"Compromisso encontrado: {compromisso.NomeCompromisso}, Horário: {compromisso.Horario}");
                }
                else
                {
                    Console.WriteLine($"Compromisso '{nomeCompromisso}' não encontrado na lista.");
                }
            }

            public void DeletarDaLista(string nomeCompromisso)
            {
                var compromisso = compromissos.Find(c => c.NomeCompromisso == nomeCompromisso);
                if (compromisso != null)
                {
                    compromissos.Remove(compromisso);
                    Console.WriteLine($"Compromisso '{nomeCompromisso}' deletado da lista.");
                }
                else
                {
                    Console.WriteLine($"Compromisso '{nomeCompromisso}' não encontrado na lista.");
                }
            }
        }

        static void Exercicio3(string[] args)
        {
            Compromisso compromisso = new Compromisso();
            var horarioComeco = TimeOnly.Parse("08:00:00");
            var horarioFim = TimeOnly.Parse("18:00:00");

            while (true)
            {
                Console.WriteLine("Digite sua opção: (adicionar, listar, buscar, deletar, sair)");
                var opcao = Console.ReadLine();

                if (opcao == "adicionar")
                {
                    Console.WriteLine("Digite o nome do compromisso:");
                    var nomeCompromisso = Console.ReadLine();
                    Console.WriteLine("Digite o horário do compromisso (HH:mm:ss):");
                    var horarioCompromisso = TimeOnly.Parse(Console.ReadLine());
                    if (horarioCompromisso < horarioComeco || horarioCompromisso > horarioFim)
                    {
                        Console.WriteLine($"O {nomeCompromisso} não foi marcado!");
                    }
                    else
                    {
                        var podeMarcar = true;
                        foreach (var c in compromisso.compromissos)
                        {
                            double diferencaEmMinutos = Math.Abs((horarioCompromisso.ToTimeSpan() - c.Horario.ToTimeSpan()).TotalMinutes);
                            if (c.Horario == horarioCompromisso)
                            {
                                Console.WriteLine($"O {nomeCompromisso} não foi marcado, pois já existe um compromisso marcado para esse horário!: {c.NomeCompromisso}");
                                podeMarcar = false;
                            }

                            else if (diferencaEmMinutos < 30)
                            {
                                Console.WriteLine($"O {nomeCompromisso} não foi marcado, está muito proximo de {c.NomeCompromisso}, que é: {c.Horario}!");
                                podeMarcar = false;
                            }
                        }

                        if (podeMarcar)
                        {
                            Console.WriteLine($"O {nomeCompromisso} foi marcado para {horarioCompromisso}!");
                            var compromisso1 = new Compromisso { NomeCompromisso = nomeCompromisso, Horario = horarioCompromisso };
                            compromisso.AdicionarNaLista(compromisso1);
                        }
                    }
                }

                if (opcao == "listar")
                {
                    Console.WriteLine("Compromissos: ");
                    compromisso.ListarCompromissos();
                }

                if (opcao == "buscar")
                {
                    Console.WriteLine("Digite o nome do compromisso que deseja buscar:");
                    var nomeCompromisso = Console.ReadLine();
                    compromisso.BuscarCompromisso(nomeCompromisso);
                }

                if (opcao == "deletar")
                {
                    Console.WriteLine("Digite o nome do compromisso que deseja deletar:");
                    var nomeCompromisso = Console.ReadLine();
                    compromisso.DeletarDaLista(nomeCompromisso);
                }

                if (opcao == "sair")
                {
                    Console.WriteLine("Encerrando o programa...");
                    break;
                }
            }
        }
    }
}
