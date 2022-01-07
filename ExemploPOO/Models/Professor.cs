using System;

namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }
        public override void Apresentar() //o virtual me permite que eu possa sobreescrevê-lo
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e meu salário é {Salario} reais");
        }
    }
}