using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetHelp
{
    public class usuario
    {
        public int id { get; set; } 
        public string nome { get; set; }
        public string senha { get; set; }
        public string descricao { get; set; }
        public bool banido { get; set; }
        
        private void registrar()
        {

        }

        private void logar()
        {

        }
        private void atualizar()
        {

        }

        public usuario()
        {
            this.banido = false;
        }


        

    }
}
