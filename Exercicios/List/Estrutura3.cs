namespace Exercicios.List
{
    internal class Estrutura3
    {
        public class Produto
        {
            public int IdProduto { get; set; }
            public string NomeProduto { get; set; }
        }

        public static void AdicionarProduto(List<Produto> produtos, Produto produto)
        {
            Console.WriteLine($"Produto adicionado: {produto.NomeProduto}, com o ID: {produto.IdProduto}");
            produtos.Add(produto);
        }

        public static void RemoverProdutoPorId(List<Produto> produtos, int id)
        {
            var encontrado = produtos.Find(c => c.IdProduto == id);
            Console.WriteLine($"Produto removido: {encontrado.NomeProduto}, com o ID: {encontrado.IdProduto}");
            produtos.Remove(encontrado);
        }

        public static void BuscarProdutoPorId(List<Produto> produtos, int id)
        {
            var encontrado = produtos.Find(c => c.IdProduto == id);
            Console.WriteLine($"Produto encontrado: {encontrado.NomeProduto}");
        }

        public static void ListarProdutos(List<Produto> produtos)
        {
            foreach (Produto produto in produtos)
            {
                Console.WriteLine($"ID: {produto.IdProduto}, Nome: {produto.NomeProduto}");
            }
        }
    }
}
