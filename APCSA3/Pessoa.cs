using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    class Pessoa: IPessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Pessoa(int Id, string Nome, string Cpf)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cpf = Cpf;
        }
    }
}
