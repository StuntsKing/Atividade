using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    class DoadorMensalista: IDoadorMensalista
    {
        public float ValorContribuicaoMensal { get; set; }
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public DoadorMensalista(Pessoa p, float ValorContribuicaoMensal)
        {
            Id = p.Id;
            Nome = p.Nome;
            Cpf = p.Cpf;
            this.ValorContribuicaoMensal = ValorContribuicaoMensal;
        }
    }
}
