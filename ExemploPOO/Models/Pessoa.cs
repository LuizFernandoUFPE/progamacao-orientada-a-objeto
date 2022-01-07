using System;

namespace ExemploPOO.Models
{
    public class Pessoa
    {
        public string? Nome {get; set; }

        public int Idade {get; set; }

        public string? Documento {get; set; }

        public virtual void Apresentar() //o virtual me permite que eu possa sobreescrevê-lo
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}