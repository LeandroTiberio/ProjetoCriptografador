namespace Criptografador.data.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public string FormaDePagamento { get; set; }
        public List<Cliente> Clientes { get; set; }
        public List<Entregador> Entregadores { get; set; }
        public PedidoXProduto PedidoXProduto { get; set;}
        public int IdPedidos { get; set; }
        

        public Pedido (int id, string formaDePagamento)
        {
            SetFormaDePagamento(formaDePagamento);
        }
        public string GetFormaDePagamento()
        {
            return FormaDePagamento;
        }
        public void SetFormaDePagamento(string formaDePagamento)
        {
            FormaDePagamento = formaDePagamento;
        }
    }
}
