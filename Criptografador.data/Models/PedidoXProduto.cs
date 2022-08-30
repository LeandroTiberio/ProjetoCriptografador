namespace Criptografador.data.Models
{
    public class PedidoXProduto
    {
        public int Id { get; set; }
        public int IdPedido { get; set; }
        public int IdProduto { get; set; }
        public List<Pedido> Pedidos { get; set; }
        public List<Produto> Produtos { get; set; }
        
    }
}
