using AR.Pasta.Interfaces;
using AR.Domain;

using System.Linq;
using System.Threading.Tasks;
using AR.Pasta;

namespace AR.Data.Imp
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly ContextoPrincipal _db;

        public ClienteRepository(ContextoPrincipal db)
        {
            _db = db;
        }

        public async Task Add(Cliente entity)
        {
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();
        }

        public IQueryable<Cliente> GetAll()
        {
            return _db.Cliente;
        }
    }
}