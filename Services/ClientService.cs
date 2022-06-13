using EvTecnicaGyS.Domain.IRepository;
using EvTecnicaGyS.Domain.IServices;
using EvTecnicaGyS.Domain.Models;
using System.Threading.Tasks;

namespace EvTecnicaGyS.Services
{
    public class ClientService: IClientService
    {
        public readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }
        public async Task SaveClient(Client client)
        {
            await _clientRepository.SaveClient(client);
        }
        public async Task UpdateClient(Client client)
        {
            await _clientRepository.UpdateClient(client);
        }
    }
}
