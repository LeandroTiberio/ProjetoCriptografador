using Criptografador.data.Models;

namespace Criptografador.data.Data.Interface
{
    public interface IClienteRepositorio : IRepositorioBase<Cliente>
    {
        Task BuscarTodosAsync(int IdClientes, string IdRestaurantes );           
    }
}


