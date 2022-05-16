using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerador_de_testes._3_Entidades
{
    public class Serie
    {
        public string Numero;

        public Serie(string numero)
        {
            Numero = numero;
        }

        public override string ToString()
        {
            return $"{Numero}º";
        }
    }
}
