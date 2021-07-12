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
        public float ValorDoado { get; set; }
        public int QtdDoacoesFeitas { get; set; }

        public DoadorMensalista(Pessoa p, float ValorContribuicaoMensal)
        {
            p.Id = Id;
            p.Nome = Nome;
            p.Cpf = Cpf;
            this.ValorContribuicaoMensal = ValorContribuicaoMensal;
        }
    }
}
