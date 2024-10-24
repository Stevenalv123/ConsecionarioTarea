using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Consecionario.Clases;

namespace Consecionario
{
    public partial class Form1 : Form
    {
        private List<Vehiculos> listaVehiculos = new List<Vehiculos>();
        Vehiculos vehiculoSeleccionado;
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

            ActualizarDataGridView();

            MessageBox.Show("Registro guardado con éxito.");
            LimpiarCampos();
        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void dtgVehiculos_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0)
            {
                dtgVehiculos.ClearSelection();
                dtgVehiculos.Rows[e.RowIndex].Selected = true;

                string tipoVehiculo = dtgVehiculos.Rows[e.RowIndex].Cells["Tipo"].Value.ToString();
                string marca = dtgVehiculos.Rows[e.RowIndex].Cells["Marca"].Value.ToString();
                string modelo = dtgVehiculos.Rows[e.RowIndex].Cells["Modelo"].Value.ToString();

                if (tipoVehiculo == "Auto")
                {
                    vehiculoSeleccionado = new Auto(marca, modelo); 
                    cmMetVehiculos.Show(Cursor.Position); 
                }
                else if (tipoVehiculo == "Camion")
                {
                    int capacidadCarga = Convert.ToInt32(dtgVehiculos.Rows[e.RowIndex].Cells["CapacidadCarga"].Value);
                    vehiculoSeleccionado = new Camion(marca, modelo, capacidadCarga); 
                    cmMetVehiculos.Show(Cursor.Position); 
                }
                else if (tipoVehiculo == "Motocicleta")
                {
                    vehiculoSeleccionado = new Motocicleta(marca, modelo); 
                    cmMetVehiculos.Show(Cursor.Position); 
                }
                else if (tipoVehiculo == "Auto electrico")
                {
                    int capacidadBateria = Convert.ToInt32(dtgVehiculos.Rows[e.RowIndex].Cells["CapacidadBateria"].Value);
                    vehiculoSeleccionado = new VehiculoElectrico(marca, modelo, capacidadBateria); 
                    cmMetVehElectricos.Show(Cursor.Position); 
                }
            }
        }
    }
}
