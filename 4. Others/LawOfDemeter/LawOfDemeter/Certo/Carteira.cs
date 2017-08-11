using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LawOfDemeter.Certo
{
    public class Carteira
    {
        private decimal valor;

        public decimal DinheiroTotal()
        {
            return valor;
        }

        public void RetirarDinheiro(decimal debito)
        {
            valor -= debito;
        }
    }
}
