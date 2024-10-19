using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecionario.Clases
{
    public class Auto : Vehiculos, ITransporte
    {
        public Auto(string marca, string modelo) : base(marca, modelo)
        {
        }

        public void Detenerse()
        {
            Console.WriteLine($"{Marca} {Modelo} está detenida.");
        }

        public void Iniciar()
        {
            Console.WriteLine($"{Marca} {Modelo} está encendido.");
        }

        public override void Moverse()
        {
            Console.WriteLine($"{Marca} {Modelo} se esta moviendo.");
        }
    }
}
