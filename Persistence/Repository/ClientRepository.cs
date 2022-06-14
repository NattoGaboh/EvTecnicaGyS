using EvTecnicaGyS.Domain.IRepository;
using EvTecnicaGyS.Domain.Models;
using EvTecnicaGyS.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
        public async Task<List<Client>> GetListClient()
        {
            var list = await _context.Client.Where(x => x.Estado=="1").ToListAsync();
            return list;
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
        public async Task<bool> ValidateExistence(string codClient)
        {
            var validateExistence = await _context.Client.AnyAsync(x => x.CodCliente.Equals(codClient));
            return validateExistence;
        }
        
        public async Task DeleteClient(Client client)
        {
            client.Estado = "0";
            _context.Entry(client).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task<Client> ValidateClient(string codClient)
        {
            var _client = await _context.Client.Where(x => x.CodCliente.Equals(codClient) && x.Estado.Equals("1")).FirstOrDefaultAsync();
            return _client;
        }
    }
}
