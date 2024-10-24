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
            MessageBox.Show($"{Marca} {Modelo} está detenido.");
        }

        public void Iniciar()
        {
            MessageBox.Show($"{Marca} {Modelo} está encendido.");
        }

        public override void Moverse()
        {
            MessageBox.Show($"{Marca} {Modelo} está transportando con capacidad de carga {CapacidadCarga} Tonaledas.");
        }
    }
}
