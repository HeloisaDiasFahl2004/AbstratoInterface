using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoInterface
{
    internal class Humano : Passageiro
    {
        public string CPF { get; set; }

        public void DefinirCPF()
        {
            this.CPF = "12345678912";
        }
    }
}
