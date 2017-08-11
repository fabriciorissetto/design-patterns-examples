using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfDemeter.Certo
{
    public class OfficeBoy
    {       
        private void AlgumMetodoQualquer(Cliente cliente)
        {


            // ...




            var valorPagamento = 5.00m;

            cliente.RealizarPagamento(valorPagamento); //Lógica encapsulada aqui





            // ...


        }
    }
}
