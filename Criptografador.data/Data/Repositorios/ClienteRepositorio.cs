using Criptografador.data.Data.Interface;
using Criptografador.data.Models;
using Microsoft.EntityFrameworkCore;

namespace Criptografador.data.Data.Repositorios
{
    public class ClienteRepositorio : RepositorioBase<Cliente>, IClienteRepositorio
    {
        
        private readonly CriptografadorContext _context;

        public ClienteRepositorio(CriptografadorContext context) : base(context, context.Clientes)
        {
            _context = context;
        }
        public async Task BuscarTodosAsync(int IdClientes, string IdRestaurantes )
        {
            var item = await _context.Clientes.AsNoTracking().FirstAsync(x => x.Id == IdClientes);
            await _context.SaveChangesAsync();
            
        }
    }
}

