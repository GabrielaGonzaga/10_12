using System;
using Polimosfirsmo_10_12;

namespace _10_12
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan jogador = new MegaMan();
            Console.WriteLine($"jogador 1 = {jogador.Correr()};");

            Zero jogador2 = new Zero();
            Console.WriteLine($"jogador 1 = {jogador2.Correr()};");

            
        }
    }
}
