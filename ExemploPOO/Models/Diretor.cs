namespace ExemploPOO.Models
{
    public class Diretor : Professor 
    {
        public sealed override void Apresentar() //o sealed faz comm que eu trave para as classes filhas
        {
            Console.WriteLine("Diretor");
        }
    }
}