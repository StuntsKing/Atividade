using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    interface IBeneficiario
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Endereco { get; set; }
        float Renda { get; set; }
        int QtdPessoasFamiia { get; set; }
        int NivelNecessidade { get; set; } //Nível de necessidade do beneficiário, de 1 à 10.
        int QtdDoacoesRecebidas { get; set; }
    }
}
