using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHelp_Cadastrar.Domain
{
    public class Paciente
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public int Cpf { get; set; }

        public string Email { get; set; }

        public int Celular{ get; set; }
    }
}
