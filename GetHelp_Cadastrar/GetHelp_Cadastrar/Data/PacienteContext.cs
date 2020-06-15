﻿using GetHelp_Cadastrar.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHelp_Cadastrar.Data
{
    public class PacienteContext : DbContext
    {
        private DbContextOptionsBuilder optionsBuilder;

        public DbSet<Paciente> Pacientes { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Data Source=(localdb)MSSQLLocalDB;Initial Catalog=AppMonoWeb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}