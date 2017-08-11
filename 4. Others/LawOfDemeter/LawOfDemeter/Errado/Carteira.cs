
namespace LawOfDemeter.Errado
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
