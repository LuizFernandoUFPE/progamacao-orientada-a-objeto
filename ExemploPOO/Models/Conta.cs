namespace ExemploPOO.Models
{
    public abstract class Conta
    {
        protected double saldo; //apenas a própria classe e as classes filhas podem trabalhar com essa propriedade

        public abstract void Creditar(double valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("Seu saldo é: " + saldo);
        }
    }
}