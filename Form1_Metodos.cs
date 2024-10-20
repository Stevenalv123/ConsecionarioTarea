using Consecionario.Clases;
using System.Data;
using System.Windows.Forms;

namespace Consecionario
{
    public partial class Form1 : Form
    {
        public Vehiculos CrearVehiculo(string tipoVehiculo, string marca, string modelo, int textField)
        {
            switch (tipoVehiculo)
            {
                case "Auto":
                    return new Auto(marca, modelo);
                case "Motocicleta":
                    return new Motocicleta(marca, modelo);
                case "Camiones":
                    return new Camion(marca, modelo, textField);
                case "Auto electrico":
                    return new VehiculoElectrico(marca, modelo, textField);
                default:
                    throw new InvalidOperationException("Tipo de vehículo no encontrado");
            }
        }

        public void MostrarCampos(bool mostrarTextField, string labelTextField = "", string labelMedida="")
        {
            lblMarca.Visible = true;
            txtMarca.Visible = true;
            lblModelo.Visible = true;
            txtModelo.Visible = true;
            lblTextField.Visible = mostrarTextField;
            txtTextField.Visible = mostrarTextField;
            lblMedida.Visible = mostrarTextField;

            if (mostrarTextField)
            {
                lblTextField.Text = labelTextField;
                lblMedida.Text = labelMedida;
            }
        }

        public void LimpiarCampos()
        {
            txtMarca.Visible = false;
            txtModelo.Visible = false;
            txtTextField.Visible = false;
            lblMarca.Visible = false;
            lblModelo.Visible = false;
            lblTextField.Visible = false;

            txtMarca.Clear();
            txtModelo.Clear();
            txtTextField.Clear();

            cmbItems.SelectedIndex = -1;
        }

        private bool ValidarCampos(string marca, string modelo, out int textField)
        {
            textField = 0;

            if (string.IsNullOrWhiteSpace(marca) || string.IsNullOrWhiteSpace(modelo))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return false;
            }

            if (txtTextField.Visible)
            {
                if (!int.TryParse(txtTextField.Text, out textField))
                {
                    MessageBox.Show("Por favor, ingrese un valor numérico válido en el campo adicional.");
                    return false;
                }
            }

            return true;
        }

        private void ActualizarDataGridView()
        {
            dtgVehiculos.Rows.Clear(); 

            foreach (var vehiculo in listaVehiculos)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dtgVehiculos);

                string tipoVehiculo = vehiculo switch
                {
                    Camion => "Camiones",
                    VehiculoElectrico => "Auto electrico",
                    Auto => "Auto",
                    Motocicleta => "Motocicleta",
                };

                row.Cells[0].Value = tipoVehiculo;
                row.Cells[1].Value = vehiculo.Marca;
                row.Cells[2].Value = vehiculo.Modelo;

                if (vehiculo is Camion camion)
                {
                    row.Cells[3].Value = camion.CapacidadCarga;
                    row.Cells[4].Value = "N/A";
                }
                else if (vehiculo is VehiculoElectrico vehiculoElectrico)
                {
                    row.Cells[3].Value = "N/A";
                    row.Cells[4].Value = vehiculoElectrico.CapacidadBateria;
                }
                else
                {
                    row.Cells[3].Value = "N/A";
                    row.Cells[4].Value = "N/A";
                }

                dtgVehiculos.Rows.Add(row);
            }
        }
    }
}

