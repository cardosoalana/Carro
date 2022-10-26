using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Classes
{
    class Carro
    {
        public String Marca { get; set; } 
        public String Modelo { get; set; }
        public int Ano { get; set; }
        public int Velocidade { get; private set; }

        public void Ligar()
        {
            Console.WriteLine($"{Modelo} Ligado!");
        }

        public void Desligar()
        {
            Console.WriteLine($"{Modelo} Desligado!");

        }

        public void Acelerar()
        {
            this.Velocidade++;
            System.Threading.Thread.Sleep(100);
        }

        public void Freiar()
        {
            this.Velocidade--;
            System.Threading.Thread.Sleep(50);
        }

        public void MostrarVelocidade()
        {
            Console.WriteLine($"{this.Velocidade}km/h.");
        }
    }
}
