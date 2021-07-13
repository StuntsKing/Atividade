using System;

namespace APCSA3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando pessoas para cadastrar como doadora ou beneficiária.
            Pessoa p1 = new Pessoa(1, "Carlos", "12345678910");
            Pessoa p2 = new Pessoa(2, "Daniel", "98765432140");
            Pessoa p3 = new Pessoa(3, "Amanda", "45678912320");
            Pessoa p4 = new Pessoa(4, "Laís", "76598132450");
            Cadastro ONG = new Cadastro();
            ONG.CadastrarDoador(p1);
            ONG.CadastrarDoador(p3);
            ONG.CadastrarBeneficiario(p2, "Rua Londres, 123, Londrina", 200.00f, 4);
            ONG.CadastrarBeneficiario(p4, "Rua Haia, 231, Cambé", 260.67f, 5);
            //Mostrando a lista de doadores e receptores.
            ONG.MostrarDoadores();
            ONG.MostrarReceptores();
            //Criando doadores e beneficiários(com os atributos das pessoas já cadastradas), e itens para cadastrar uma doação.
            Doador d1 = new Doador(p1);
            Doador d2 = new Doador(p3);
            Beneficiario b1 = new Beneficiario(p2, "Rua Londres, 123, Londrina", 200.00f, 4);
            Beneficiario b2 = new Beneficiario(p4, "Rua Haia, 231, Cambé", 260.67f, 5);
            ItemDoacao i1 = new ItemDoacao(1, "Blusa de moletom", 150.00f, "Homem", "G");
            ItemDoacao i2 = new ItemDoacao(2, "Cesta Básica", 200.00f, "Ambos", "Grande");
            ONG.CadastrarDoacao(1, d1, b1, i1, new DateTime(2021, 07, 13));
            ONG.CadastrarDoacao(2, d2, b2, i2, new DateTime(2021, 07, 14));
            //Mostrando a lista de doações feitas na data 14/07/2021 e as doações totais.
            ONG.MostrarDoacoesData(new DateTime(2021, 07, 14));
            ONG.MostrarDoacoesTotais();
            //Doador Mensalista(Contribui com um valor mensal, auxiliando no orçamento da ONG).
            Pessoa p5 = new Pessoa(5, "Luís", "23984567140");
            ONG.CadastrarDoadorMensalista(p5, 100.00f);
            ONG.MostrarDoadoresMensalistas();
            Console.Read();
        }
    }
}
