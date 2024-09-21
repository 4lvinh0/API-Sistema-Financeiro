using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gerenciamento_Financeiro.core.entities;
using Microsoft.EntityFrameworkCore;

namespace Gerenciamento_Financeiro.infrastructure.data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Transacao> transacao { get; set; }
    }
}