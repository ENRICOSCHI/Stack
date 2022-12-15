using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verifica22._12._13
{
    class Pila
    {
        protected int top;
        protected Lettura[] arrLettura;
        public Pila()
        {
            arrLettura = new Lettura[200];
        }
        public bool Push(string titolo, string tipo)
        {
            bool ret = false;
            if (top <= arrLettura.Length)
            {
                top++;
                arrLettura[top] = new Lettura(titolo, tipo);
                ret = true;
            }
            
            return ret;
        }
        public Lettura Pop()
        {
            Lettura v=null;
            if (top != 0 || arrLettura[top] != null)
            {
                v = arrLettura[top];
                arrLettura[top] = null;
                top--;
            }
            return v;
        }
        public string ToString()
        {
            string ret="";
            for (int j = 0; j < arrLettura.Length; j++)
            {
                if(arrLettura [j] != null)         
                 ret= ret +" Titolo: " + arrLettura[j].getTitolo() + " Tipo: " + arrLettura[j].getTipo()+"\n";
            }
            return ret;
        }
    }
}
