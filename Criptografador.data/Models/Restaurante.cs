namespace Criptografador.data.Models
{
    public class Restaurante
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double Telefone { get; set; }
        public string Categoria { get; set; }
        public string Endereco { get; set; }
        public string Sobre { get; set; }
        public Produto Produto { get; set; }
        public int IdRestaurantes { get; set; }

        public Restaurante (int id, string nome, double telefone, string categoria, string endereco, string sobre)
        {
            SetNome(nome);
            SetTelefone(telefone);
            SetCategoria(categoria);
            SetEndereco(endereco);
            SetSobre(sobre);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public double GetTelefone()
        {
            return Telefone;
        }
        public void SetTelefone(double telefone)
        {
            Telefone = telefone;
        }
        public string GetCategoria()
        {
            return Categoria;
        }
        public void SetCategoria(string categoria)
        {
            Categoria = categoria;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }
        public string GetSobre()
        {
            return Sobre;
        }
        public void SetSobre(string sobre)
        {
            Sobre = sobre;
        }
    }
}

