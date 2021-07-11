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

        public DoadorMensalista(float ValorContribuicaoMensal, int Id, string Nome, string Cpf, float ValorDoado, int QtdDoacoesFeitas)
        {
            this.ValorContribuicaoMensal = ValorContribuicaoMensal;
            this.Id = Id;
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.ValorDoado = ValorDoado;
            this.QtdDoacoesFeitas = QtdDoacoesFeitas;
        }
    }
}
