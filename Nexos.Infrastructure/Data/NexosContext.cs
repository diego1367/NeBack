using Microsoft.EntityFrameworkCore;
using Nexos.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nexos.Infrastructure.Data
{
    public class NexosContext : DbContext
    {
        public NexosContext(DbContextOptions<NexosContext> options) : base(options)
        {

        }

        public DbSet<Libro> Libro { get; set; }
        public DbSet<Editoriales> Editoriales { get; set; }
        public DbSet<Autores> Autores { get; set; }
    }
}
