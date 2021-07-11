using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    class Doacao: IDoacao
    {
        public int Id { get; set; }
        public string Doador { get; set; }
        public string Beneficiario { get; set; }
        public DateTime DataDoacao { get; set; }

        public Doacao(int Id, string Doador, string Beneficiario, DateTime DataDoacao)
        {
            this.Id = Id;
            this.Doador = Doador;
            this.Beneficiario = Beneficiario;
            this.DataDoacao = DataDoacao;
        }
    }
}
