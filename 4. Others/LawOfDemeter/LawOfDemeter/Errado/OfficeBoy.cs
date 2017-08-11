using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfDemeter.Errado
{
    public class OfficeBoy
    {        
        private void AlgumMetodoQualquer(Cliente cliente)
        {


            // ...





            var pagamento = 5.00m;
            var carteira = cliente.Carteira;

            if (carteira.DinheiroTotal() > pagamento)
                carteira.RetirarDinheiro(pagamento);
            else
                throw new Exception("COMO ASSIM NÃO TEM DINHEIRO CARA?!");





            // ...

        }
    }
}
