using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecionario.Clases
{
    public class Camion : Vehiculos, ITransporte
    {
        public int CapacidadCarga { get; set; }

        public Camion(string marca, string modelo, int capacidadCarga):base(marca, modelo)
        {
            CapacidadCarga = capacidadCarga;
        }

        public void Detenerse()
        {
            Console.WriteLine($"{Marca} {Modelo} está detenido.");
        }

        public void Iniciar()
        {
            Console.WriteLine($"{Marca} {Modelo} está encendido.");
        }

        public override void Moverse()
        {
            Console.WriteLine($"{Marca} {Modelo} está transportando con capacidad de carga {CapacidadCarga} kg.");
        }
    }
}
