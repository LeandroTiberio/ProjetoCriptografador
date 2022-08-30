using Criptografador.data.Models;

namespace Criptografador.data.Data.Interface
{
    public interface IRepositorioBase<T> where T : ModelBase
    {
        Task<List<T>> BuscarTodosAsync();
    }
}


 
