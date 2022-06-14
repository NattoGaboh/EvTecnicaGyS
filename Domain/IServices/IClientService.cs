using EvTecnicaGyS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EvTecnicaGyS.Domain.IServices
{
    public interface IClientService
    {
        Task<List<Client>> GetListClient();
        Task SaveClient(Client client);
        Task UpdateClient(Client client);
        Task<bool> ValidateExistence(string codClient);
        Task<Client> ValidateClient(string codClient);
        Task DeleteClient(Client client);
    }
}
