using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Demostracao.Models
{
    public class Connection : DbContext
    {
        public Connection(DbContextOptions<Connection> options) : base(options)
        {

        }

        //Elemento responsavel pela criação das tabelas no campo de dados junto com o MIgration do Entity Framework

        public DbSet<Produto> Produto { get; set; }
    }
}