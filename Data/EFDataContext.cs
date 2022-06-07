using BsMS.Classes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BsMS.Data
{
    public class EFDataContext : DbContext 
    {
        public DbSet<Usuario>? Usuario { get; set; }
        public DbSet<Itens>? Itens { get; set; }
        public DbSet<Vendas>? Vendas { get; set; }
        public DbSet<Cliente>? Cliente { get; set; }
        public DbSet<Fornecedor>? Fornecedor { get; set; }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=DataBase1;Trusted_Connection=True");
        }
    }
}

