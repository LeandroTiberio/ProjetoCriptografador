namespace Criptografador.data.Models
{
    public class Cliente : ModelBase
    {
        public int Id {get; set;}
        public string Nome {get; set; }
        public string Email {get; set; }
        public string Senha { get; set; }
        public double Telefone { get; set; }
        public string Endereco { get; set; }
        public Pedido Pedido { get; set; }
        public int IdClientes { get; set; }
       
        public Cliente (int id, string nome, string email, string senha, double telefone, string endereco)
        {
            SetNome(nome);
            SetEmail(email);
            SetSenha(senha);
            SetTelefone(telefone);
            SetEndereco(endereco);
        }
        public string GetNome()
        {
            return Nome;
        }
        public void SetNome(string nome)
        {
            Nome = Nome;
        }
        public string GetEmail()
        {
            return Email;
        }
        public void SetEmail(string email)
        {
            Email = email;
        }
        public string GetSenha()
        {
            return Senha;
        }
        public void SetSenha(string senha)
        {
            Senha = senha;
        }
        public double GetTelefone()
        {
            return Telefone;
        }
        public void SetTelefone(double telefone)
        {
            Telefone = telefone;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
        public void SetEndereco(string endereco)
        {
            Endereco = endereco;
        }


    }
    

}