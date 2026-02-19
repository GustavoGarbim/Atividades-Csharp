namespace Exercicios
{
    public class exercicio4
    {
        public class Lote
        {
            public int ID { get; set; }
            public string Nome { get; set; }
            public DateOnly DataValidade { get; set; }
            public int Quantidade { get; set; }

            public Lote(int iD, string nome, DateOnly dataValidade, int quantidade)
            {
                ID = iD;
                Nome = nome;
                DataValidade = dataValidade;
                Quantidade = quantidade;
            }
        }

        public class ControleEstoque
        {
            public List<Lote> Lotes = new List<Lote>();

            public void AdicionarLote(Lote lote)
            {
                Lotes.Add(lote);
            }

            public void RetirarEstoque(int quantidadeSolicitada)
            {
                if (Lotes.Count == 0)
                {
                    Console.WriteLine("Estoque vazio.");
                    return;
                }
                else if (quantidadeSolicitada <= 0)
                {
                    Console.WriteLine("Quantidade solicitada deve ser maior que zero.");
                    return;
                }
                else if (quantidadeSolicitada > Lotes.Sum(x => x.Quantidade))
                {
                    Console.WriteLine("Quantidade solicitada excede o estoque disponível.");
                    return;
                }
                else
                {
                    var lot = Lotes.OrderBy(x => x.DataValidade).ToList();
                    foreach (Lote lote in lot)
                    {
                        if (quantidadeSolicitada >= lote.Quantidade)
                        {
                            quantidadeSolicitada -= lote.Quantidade;
                            Lotes.Remove(lote);
                        }
                        else
                        {
                            lote.Quantidade -= quantidadeSolicitada;
                            break;
                        }
                    }
                }
            }
            public void ListarEstoque()
            {
                foreach (var item in Lotes.ToList().OrderBy(x => x.DataValidade))
                {
                    Console.WriteLine($"ID: {item.ID}, Nome: {item.Nome}, Quantidade: {item.Quantidade}, Validade: {item.DataValidade}.");
                }
            }
        }
        static void Exercicio4(string[] args)
        {
            ControleEstoque controle = new ControleEstoque();
            while (true)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Adicionar Lote");
                Console.WriteLine("2 - Retirar Estoque");
                Console.WriteLine("3 - Listar Estoque");

                string opcao = Console.ReadLine();
                if (opcao == "1")
                {
                    Random random = new Random();
                    var id = random.Next(1, 1000);
                    Console.WriteLine("Digite o nome do lote a ser adicionado");
                    string nome = Console.ReadLine();

                    Console.WriteLine("Digite a data de validade do lote a ser adicionado");
                    DateOnly dataValidade = DateOnly.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a quantidade do lote a ser adicionado");
                    int quantidade = int.Parse(Console.ReadLine());

                    controle.AdicionarLote(new Lote(id, nome, dataValidade, quantidade));
                }
                else if (opcao == "2")
                {
                    Console.WriteLine("Digite a quantidade a ser retirada do estoque");
                    int quantidadeSolicitada = int.Parse(Console.ReadLine());
                    controle.RetirarEstoque(quantidadeSolicitada);
                }
                else if (opcao == "3")
                {
                    controle.ListarEstoque();
                }
            }
        }
    }
}
