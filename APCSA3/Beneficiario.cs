using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    class Beneficiario: IBeneficiario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public float Renda { get; set; }
        public int QtdPessoasFamilia { get; set; }

        public Beneficiario(Pessoa p, string Endereco, float Renda, int QtdPessoasFamilia)
        {
            Id = p.Id;
            Nome = p.Nome;
            Cpf = p.Cpf;
            this.Endereco = Endereco;
            this.Renda = Renda;
            this.QtdPessoasFamilia = QtdPessoasFamilia;
        }
    }
}