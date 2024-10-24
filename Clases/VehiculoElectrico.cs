using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecionario.Clases
{
    public class VehiculoElectrico : Vehiculos, ITransporte, IElectrico
    {
        public int CapacidadBateria { get; set; }

        public VehiculoElectrico(string marca, string modelo, int capacidadBateria) : base(marca, modelo)
        {
            CapacidadBateria = capacidadBateria;
        }

        public void CargarBateria()
        {
            MessageBox.Show($"{Marca} {Modelo} está cargando la batería (Capacidad: {CapacidadBateria} kWh).");
        }

        public override void Moverse()
        {
            MessageBox.Show($"{Marca} {Modelo} está conduciendo en modo eléctrico.");
        }

        public void Iniciar()
        {
            MessageBox.Show($"{Marca} {Modelo} está encendido.");
        }

        public void Detenerse()
        {
            MessageBox.Show($"{Marca} {Modelo} está apagado.");
        }
    }
}
