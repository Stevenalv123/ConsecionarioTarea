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
        private void cmbItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cmbItems.SelectedItem.ToString();

            switch (selected)
            {
                case "Camiones":
                    MostrarCampos(true, "Capacidad de Carga: ");
                    break;
                case "Auto electrico":
                    MostrarCampos(true, "Capacidad de Bateria: ");
                    break;
                default:
                    MostrarCampos(false);
                    break;
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
            if (txtTextField.Visible == true)
            {
                if (!int.TryParse(txtTextField.Text, out textField))
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido.");
                    return;
                }
            }
            Vehiculos vehiculos = CrearVehiculo(tipoVehiculo, marca, modelo, textField);
            listaVehiculos.Add(vehiculos);
            ActualizarDataGridView();
            MessageBox.Show("Registro guardado con éxito.");
            LimpiarCampos();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
