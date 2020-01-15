using APICore.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICore.Context
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions opt) : base(opt)
        {

        }

        public DbSet<Fornecedor> Fornecedores { get; set; }
    }
}
