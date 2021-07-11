using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    interface IPessoa
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Cpf { get; set; }
    }
}