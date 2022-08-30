using Criptografador.data.Data.Interface;
using Criptografador.data.Models;
using Microsoft.EntityFrameworkCore;

namespace Criptografador.data.Data.Repositorios
{
    public class RepositorioBase<T> :IRepositorioBase<T> where T : ModelBase
    {
        private readonly CriptografadorContext _context;
        private readonly DbSet<T> _dbset;
        public RepositorioBase(CriptografadorContext dbContext, DbSet<T> dbset)
        {
            _context = dbContext;
            _dbset = dbset;
        }
        public async Task<List<T>> BuscarTodosAsync()
        {
            return await _dbset.AsNoTracking().ToListAsync();
        }
      
    }
}

  