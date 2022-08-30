namespace Criptografador.data.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome {get; set; }
        public string Descricao { get; set; }
        public double Valor { get; set; }
        public string Categoria { get; set; }
        public List<Restaurante> Restaurantes { get; set; }
        public Produto Produtos { get; set; }
        public PedidoXProduto PedidoXProduto { get; set; } 
        public int IdProdutos { get; set; }
        
        public Produto (int id, string nome, string descricao, double valor, string categoria)
        {
            SetNome(nome);
            SetDescricao(descricao);
            SetValor(valor);
            SetCategoria(categoria);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public string GetDescricao()
        {
            return Descricao;
        }
        public void SetDescricao(string descricao)
        {
            Descricao = descricao;
        }
        public double GetValor()
        {
            return Valor;
        }
        public void SetValor(double valor)
        {
            Valor = valor;
        }
        public string GetCategoria()
        {
            return Categoria;
        }
        public void SetCategoria(string categoria)
        {
            Categoria = categoria;
        }
    }
}
