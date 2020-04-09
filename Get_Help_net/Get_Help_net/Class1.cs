using Microsoft.EntityFrameworkCore;
using System;

namespace br.com.GetHelp
{
    public class usuario
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string senha { get; set; }
        public string descricao { get; set; }
        public bool banido { get; set; }
    }

   public class psicologo : usuario
    {
        public string CRP { get; set; }
        public int avaliacao { get; set; }
        public bool status { get; set; }
    }

    public class moderador : usuario
    {
        public int nivelAcesso { get; set; }
    }
    public class mensagem
    {
        public int idMensagem { get; set; }
        public int idSala { get; set; }
        public int idUsuario { get; set; }
        public DateTime dataHorario { get; set; }
        public string texto { get; set; }
    }

    public class sala
    {
        public int id;
        public string descricao { get; set; }
        public string nome { get; set; }
        public int quantUsuario { get; set; }
        public string senha { get; set; }
        public bool privada { get; set; }
    }

    public class Conexao : DbContext
    {
        public DbSet<usuario> usuarios { get; set; }
        public DbSet<sala> salas { get; set; }
        public DbSet<mensagem> mensagems { get; set; }

        protected override void Onconfiguration(DbContextOptionsBuilder dbcob)
        {
            dbcob.UseSqlServer(@"Server=(placeholder)");
        }





    }
}
