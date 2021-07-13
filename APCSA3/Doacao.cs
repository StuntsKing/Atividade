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
        public string Item { get; set; }
        public DateTime DataDoacao { get; set; }

        public Doacao(int Id, Doador d, Beneficiario b, ItemDoacao i, DateTime DataDoacao)
        {
            this.Id = Id;
            Doador = d.Nome;
            Beneficiario = b.Nome;
            Item = i.Nome;
            this.DataDoacao = DataDoacao;
        }
    }
}
