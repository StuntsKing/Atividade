using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    interface IBeneficiario
    {
        int Id { get; set; }
        string Nome { get; set; }
        string Cpf { get; set; }
        string Endereco { get; set; }
        float Renda { get; set; }
        int QtdPessoasFamiia { get; set; }
        int QtdDoacoesRecebidas { get; set; }
    }
}