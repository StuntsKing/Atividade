using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    interface IDoacao
    {
        int Id { get; set; }
        string Doador { get; set; }
        string Beneficiario { get; set; }
        DateTime DataDoacao { get; set; }
    }
}