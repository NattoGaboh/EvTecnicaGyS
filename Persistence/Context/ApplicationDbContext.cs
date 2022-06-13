using EvTecnicaGyS.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EvTecnicaGyS.Persistence.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
    }
}
