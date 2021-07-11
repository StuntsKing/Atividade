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

        public Doador(int Id, string Nome, string Cpf, float ValorDoado, int QtdDoacoesFeitas)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Cpf = Cpf;
            this.ValorDoado = ValorDoado;
            this.QtdDoacoesFeitas = QtdDoacoesFeitas;
        }
    }
}
