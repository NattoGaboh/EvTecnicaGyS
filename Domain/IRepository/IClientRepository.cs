using EvTecnicaGyS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvTecnicaGyS.Domain.IRepository
{
    public interface IClientRepository
    {
        Task<List<Client>> GetListClient();
        Task SaveClient(Client client);
        Task UpdateClient(Client client);
        Task<bool> ValidateExistence(string codClient);
        Task<Client> ValidateClient(string codClient);
        Task DeleteClient(Client client);
    }
}
