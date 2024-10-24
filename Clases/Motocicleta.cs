using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecionario.Clases
{
    public class Motocicleta : Vehiculos, ITransporte
    {
        public Motocicleta(string marca, string modelo) : base(marca, modelo)
        {
        }

        public void Detenerse()
        {
            MessageBox.Show($"{Marca} {Modelo} está detenida.");
        }

        public void Iniciar()
        {
            MessageBox.Show($"{Marca} {Modelo} está encendida.");
        }

        public override void Moverse()
        {
            MessageBox.Show($"{Marca} {Modelo} se esta moviendo.");
        }
    }
}
