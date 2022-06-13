using EvTecnicaGyS.Domain.IRepository;
using EvTecnicaGyS.Domain.Models;
using EvTecnicaGyS.Persistence.Context;
using System.Threading.Tasks;

namespace EvTecnicaGyS.Persistence.Repository
{
    public class ClientRepository: IClientRepository
    {
        private readonly ApplicationDbContext _context;
        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task SaveClient(Client client)
        {
            _context.Add(client);
            await _context.SaveChangesAsync();
        }
        public async Task UpdateClient(Client client)
        {
            _context.Update(client);
            await _context.SaveChangesAsync();
        }
    }
}
