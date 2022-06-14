using EvTecnicaGyS.Domain.IRepository;
using EvTecnicaGyS.Domain.IServices;
using EvTecnicaGyS.Domain.Models;
using System.Collections.Generic;
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

        public async Task<List<Client>> GetListClient()
        {
            return await _clientRepository.GetListClient();
        }
        public async Task SaveClient(Client client)
        {
            await _clientRepository.SaveClient(client);
        }
        public async Task UpdateClient(Client client)
        {
            await _clientRepository.UpdateClient(client);
        }
        public async Task<bool> ValidateExistence(string codClient)
        {
            return await _clientRepository.ValidateExistence(codClient);
        }
        public async Task DeleteClient(Client client)
        {
            await _clientRepository.DeleteClient(client);
        }
        public async Task<Client> ValidateClient(string codClient)
        {
            return await _clientRepository.ValidateClient(codClient);
        }

    }
}
