using EvTecnicaGyS.Domain.Models;
using System;
using System.Threading.Tasks;

namespace EvTecnicaGyS.Domain.IServices
{
    public interface IClientService
    {
        Task SaveClient(Client client);
        Task UpdateClient(Client client);
    }
}
