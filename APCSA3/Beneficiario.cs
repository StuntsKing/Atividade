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
        public int QtdPessoasFamiia { get; set; }
        public int QtdDoacoesRecebidas { get; set; }

        public Beneficiario(int Id, string Nome, string Cpf, string Endereco, float Renda, int QtdPessoasFamilia, int QtdDoacoesRecebidas)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.Endereco = Endereco;
            this.Renda = Renda;
            this.QtdPessoasFamiia = QtdPessoasFamiia;
            this.QtdDoacoesRecebidas = QtdDoacoesRecebidas;
        }
    }
}
