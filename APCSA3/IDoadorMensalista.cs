using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    interface IDoadorMensalista: IDoador
    {
        float ValorContribuicaoMensal { get; set; }
    }
}
