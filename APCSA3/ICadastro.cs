using System;
using System.Collections.Generic;
using System.Text;

namespace APCSA3
{
    interface ICadastro
    {
        void CadastrarDoador();
        void CadastrarBeneficiario();
        void CadastrarDoacao();
        void MostrarDoadores();
        void MostrarReceptores();
        void MostrarDoacoesData();
        void MostrarDoacoesTotais();
    }
}
