using System;

namespace ExemploPOO.Models
{
    public class Aluno : Pessoa //O " : " é usado para mostrar que, nesse contexto, Aluno herda de Pessoa
    {
        public int Nota { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e minha nota é {Nota}");
        }
    }
}