using EvTecnicaGyS.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvTecnicaGyS.Domain.IRepository
{
    public interface IClientRepository
    {
        Task SaveClient(Client client);
        Task UpdateClient(Client client);
    }
}
