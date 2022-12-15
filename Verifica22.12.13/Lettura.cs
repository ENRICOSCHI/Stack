using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica22._12._13
{
    class Lettura
    {
        protected string titolo;
        protected string tipo;
        public Lettura(string titolo, string tipo)
        {
            this.titolo = titolo;
            this.tipo = tipo;
        }
        public string getTitolo()
        {
            return titolo;
        }
        public string getTipo()
        {
            return tipo;
        }
    }
}
