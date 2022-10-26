using ConsoleApp1.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AtividadeCarro
    {
        private static void AcelerarCarro(Carro carro)
        {
            for (int i = 0; i < 100; i++)
            {
                carro.Acelerar();
                carro.MostrarVelocidade();
            }
        }

        private static void FreiarCarro(Carro carro)
        {
            for (int i = 0; i < 100; i++)
            {
                carro.Freiar();
                carro.MostrarVelocidade();
            }
        }

        private static void LigarCarro(Carro carro)
        {
            carro.Ligar();
        }

        private static void DesligarCarro(Carro carro)
        {
            carro.Desligar();
        }

        internal class CriaCarro
        {
            public CriaCarro()
            {
                Carro gol = new Carro();
                gol.Modelo = "Gol";
                gol.Modelo = "Gol";
                gol.Ano = 2022;

                Console.WriteLine($"Modelo do carro = { gol.Modelo}");
                Console.WriteLine($"Modelo do carro = { gol.Modelo}");
                Console.WriteLine($"Ano do carro = { gol.Ano}");

                LigarCarro(gol);
                AcelerarCarro(gol);
                FreiarCarro(gol);
                DesligarCarro(gol);
            }
        }
    }
}
