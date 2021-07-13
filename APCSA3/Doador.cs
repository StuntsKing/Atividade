using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    class Doador: IDoador
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public float ValorDoado { get; set; }
        public int QtdDoacoesFeitas { get; set; }

        public Doador(Pessoa p)
        {
            Id = p.Id;
            Nome = p.Nome;
            Cpf = p.Cpf;
        }
    }
}