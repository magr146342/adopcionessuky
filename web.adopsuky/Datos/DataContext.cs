using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using web.adopsuky.Datos.Entidades;

namespace web.adopsuky.Datos
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Propietario> Propietarios { get; set; }
    }
}
