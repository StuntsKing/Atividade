using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    interface IItemDoacao
    {
        int Id { get; set; }
        string Nome { get; set; }
        float Valor { get; set; }
        string GeneroDestinado { get; set; } //O item será classificado, de acordo com sua destinação: masculino, feminino ou ambos.
        string Tamanho { get; set; } //Caso for roupa: P, M, G, GG. Caso for cesta básica: Pequena, Média ou Grande.
    }
}