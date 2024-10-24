
using Consecionario.Clases;

namespace Consecionario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cIniciar_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                if (vehiculoSeleccionado is Auto auto)
                {
                    auto.Iniciar();
                }
                else if (vehiculoSeleccionado is Camion camion)
                {
                    camion.Iniciar();
                }
                else if (vehiculoSeleccionado is Motocicleta motocicleta)
                {
                    motocicleta.Iniciar();
                }
                else if (vehiculoSeleccionado is VehiculoElectrico vehiculoElectrico)
                {
                    vehiculoElectrico.Iniciar();
                }
            }
        }

        private void cMo_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                if (vehiculoSeleccionado is Auto auto)
                {
                    auto.Moverse();
                }
                else if (vehiculoSeleccionado is Camion camion)
                {
                    camion.Moverse();
                }
                else if (vehiculoSeleccionado is Motocicleta motocicleta)
                {
                    motocicleta.Moverse();
                }
                else if (vehiculoSeleccionado is VehiculoElectrico vehiculoElectrico)
                {
                    vehiculoElectrico.Moverse();
                }
            }
        }

        private void cDetener_Click(object sender, EventArgs e)
        {
            if (vehiculoSeleccionado != null)
            {
                if (vehiculoSeleccionado is Auto auto)
                {
                    auto.Detenerse();
                }
                else if (vehiculoSeleccionado is Camion camion)
                {
                    camion.Detenerse();
                }
                else if (vehiculoSeleccionado is Motocicleta motocicleta)
                {
                    motocicleta.Detenerse();
                }
                else if (vehiculoSeleccionado is VehiculoElectrico vehiculoElectrico)
                {
                    vehiculoElectrico.Detenerse();
                }
            }
        }
    }
}
