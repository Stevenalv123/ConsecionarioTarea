using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consecionario.Clases;

namespace Consecionario
{
    public partial class Form1 : Form
    {
        private List<Vehiculos> listaVehiculos = new List<Vehiculos>();
        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!(cmbItems.SelectedItem == null))
            {
                string selected = cmbItems.SelectedItem.ToString();
                switch (selected)
                {
                    case "Camiones":
                        MostrarCampos(true, "Capacidad de Carga: ", "Toneladas");
                        break;
                    case "Auto electrico":
                        MostrarCampos(true, "Capacidad de Bateria: ", "kWh");
                        break;
                    default:
                        MostrarCampos(false);
                        break;
                }
            }  
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (cmbItems.SelectedItem == null)
            {
                MessageBox.Show("Por favor, seleccione un tipo de vehículo.");
                return;
            }

            string tipoVehiculo = cmbItems.SelectedItem.ToString();
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            int textField = 0;

            if (!ValidarCampos(marca, modelo, out textField))
            {
                return;
            }

            Vehiculos vehiculos = CrearVehiculo(tipoVehiculo, marca, modelo, textField);
            listaVehiculos.Add(vehiculos);

            ActualizarDataGridView(tipoVehiculo);

            MessageBox.Show("Registro guardado con éxito.");
            LimpiarCampos();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
