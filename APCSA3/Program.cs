using System;

namespace APCSA3
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa(1, "Carlos", "12345678910");
            Pessoa p2 = new Pessoa(2, "Daniel", "98765432140");
            Pessoa p3 = new Pessoa(3, "Amanda", "45678912320");
            Pessoa p4 = new Pessoa(4, "Laís", "76598132450");
            ItemDoacao i1 = new ItemDoacao(1, "Blusa de moletom", 150.00f, "Homem", "G");
            ItemDoacao i2 = new ItemDoacao(2, "Cesta Básica", 200.00f, "Ambos", "Grande");
            Cadastro ONG = new Cadastro();
            ONG.CadastrarDoador(p1);
            ONG.CadastrarDoador(p3);
            ONG.CadastrarBeneficiario(p2, "Rua Londres, 123, Londrina", 200.00f, 4);
            ONG.CadastrarBeneficiario(p4, "Rua Haia, 231, Cambé", 260.67f, 5);

            Doador d1 = new Doador(p1);
            Doador d3 = new Doador(p3);
            Beneficiario b2 = new Beneficiario(p2, "Rua Londres, 123, Londrina", 200.00f, 4);
            Beneficiario b4 = new Beneficiario(p4, "Rua Haia, 231, Cambé", 260.67f, 5);

            ONG.CadastrarDoacao(1, d1, b2, i1, new DateTime(2021, 07, 13));
            ONG.CadastrarDoacao(2, d3, b4, i2, new DateTime(2021, 07, 14));
            ONG.MostrarDoacoesData(new DateTime(2021, 07, 14));
            ONG.MostrarDoacoesTotais();

            ONG.MostrarDoadores();
            ONG.MostrarReceptores();

            Console.Read();
        }
    }
}
