using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstratoInterface
{
    internal interface IPassageiro//prototipação/assinatura dos métodos utilizados em determinadas classes.
                              //(maneira pré definida de como os métodos vão trabalhar)
                              //Não é possível criar uma instânca do tipo interface
                              //Garante a integridade dos métodos
    {
        void Cadastrar();
        void Consultar();
        void ListarTudo();
    }
}
