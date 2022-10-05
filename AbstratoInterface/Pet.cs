using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoInterface
{
    internal class Pet : Passageiro
    {
        public int Registro{ get; set; }
        public void DefinirRegistro()
        {
            this.Registro = 1;
        }
    }
}
