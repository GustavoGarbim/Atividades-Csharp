namespace Exercicios
{
    public class exercicio1
    {
        public class Atividade
        {
            public int ID { get; set; }
            public string NomeAtividade { get; set; }
            public string DescricaoAtividade { get; set; }
            public int DuracaoAtividadeMinutos { get; set; }

            public Atividade(int id, string nomeAtividade, string descricaoAtividade, int duracaoAtividadeMinutos)
            {
                ID = id;
                NomeAtividade = nomeAtividade;
                DescricaoAtividade = descricaoAtividade;
                DuracaoAtividadeMinutos = duracaoAtividadeMinutos;
            }
        }

        static void Main2(string[] args)
        {
            Console.WriteLine("Quantas atividades você tem para fazer hoje?: ");
            int atividades = int.Parse(Console.ReadLine());

            List<Atividade> listaAtividades = new List<Atividade>();

            for (int i = 1; i <= atividades; i++)
            {
                Console.WriteLine("Digite o nome da atividade: ");
                string nomeAtividade = Console.ReadLine();

                Console.WriteLine("Digite a descricao da atividade: ");
                string descricaoAtividade = Console.ReadLine();

                Console.WriteLine("Digite a duração da atividade em minutos: ");
                int duracaoAtividade = int.Parse(Console.ReadLine());
                if (duracaoAtividade <= 0)
                {
                    Console.WriteLine("A duração da atividade deve ser um número positivo. Por favor, tente novamente.");
                    i--;
                    continue;
                }

                Atividade atividade = new Atividade(i, nomeAtividade, descricaoAtividade, duracaoAtividade);
                listaAtividades.Add(atividade);
            }

            foreach (Atividade atividade in listaAtividades)
            {
                Console.WriteLine($"ID: {atividade.ID}");
                Console.WriteLine($"Atividade: {atividade.NomeAtividade}");
                Console.WriteLine($"Descrição: {atividade.DescricaoAtividade}");
                Console.WriteLine($"Duração: {atividade.DuracaoAtividadeMinutos} minutos");
                Console.WriteLine();
            }
        }
    }
}