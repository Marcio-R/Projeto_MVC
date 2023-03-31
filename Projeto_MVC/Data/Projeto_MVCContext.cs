using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_MVC.Models;

namespace Projeto_MVC.Data
{
    public class Projeto_MVCContext : DbContext
    {
        public Projeto_MVCContext (DbContextOptions<Projeto_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<Curso> Curso { get; set; } = default!;
    }
}
