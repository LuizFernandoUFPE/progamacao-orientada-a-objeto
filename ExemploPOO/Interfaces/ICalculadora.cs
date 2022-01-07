namespace ExemploPOO.Interfaces
{
    public interface ICalculadora //é uma boa prática colocar i no começo do nome da interface
    {
        int Somar(int num1, int num2);
        int Subtrair(int num1, int num2);
        int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }

        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}