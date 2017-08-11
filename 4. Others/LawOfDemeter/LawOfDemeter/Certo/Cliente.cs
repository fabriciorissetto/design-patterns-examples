
namespace LawOfDemeter.Certo
{
    public class Cliente
    {
        private Carteira carteira;
        public string Nome { get; set; }

        public void RealizarPagamento(decimal valor)
        {
            if (carteira.DinheiroTotal() >= valor)
            {
                carteira.RetirarDinheiro(valor);
            }
            else
            {
                //carteira.PagarComCartaoDeDebito();
            }
        }
    }
}
