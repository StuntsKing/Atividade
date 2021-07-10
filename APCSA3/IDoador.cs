using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    interface IDoador
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Endereco { get; set; }
        float Renda { get; set; }
        int QtdDoacoesFeitas { get; set; }
    }
}
