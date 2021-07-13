using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    class ItemDoacao: IItemDoacao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Valor { get; set; }
        public string GeneroDestinado { get; set; } //O item será classificado, de acordo com sua destinação: masculino, feminino ou ambos.
        public string Tamanho { get; set; } //Caso for roupa: P, M, G, GG. Caso for cesta básica: Pequena, Média ou Grande.

        public ItemDoacao(int Id, string Nome, float Valor, string GeneroDestinado, string Tamanho)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Valor = Valor;
            this.GeneroDestinado = GeneroDestinado;
            this.Tamanho = Tamanho;
        }
    }
}
