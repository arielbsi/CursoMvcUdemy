using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CursoMvc.Models;

namespace CursoMvc.Models
{
    public class CursoMvcContext : DbContext
    {
        public CursoMvcContext (DbContextOptions<CursoMvcContext> options)
            : base(options)
        {
        }

        public DbSet<CursoMvc.Models.Departamento> Departamento { get; set; }
        public DbSet<CursoMvc.Models.Funcionario> Funcionario { get; set; }
        public DbSet<CursoMvc.Models.RegistroVendas> RegistroVendas { get; set; }


    }
}
