using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consecionario.Clases
{
    abstract public class Vehiculos
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculos(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public abstract void Moverse();

        public override string ToString()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}";
        }
    }
}
