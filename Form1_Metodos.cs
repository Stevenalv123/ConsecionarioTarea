using Consecionario.Clases;

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

        public void MostrarCampos(bool mostrarTextField, string labelTextField = "")
        {
            lblMarca.Visible = true;
            txtMarca.Visible = true;
            lblModelo.Visible = true;
            txtModelo.Visible = true;
            lblTextField.Visible = mostrarTextField;
            txtTextField.Visible = mostrarTextField;

            if (mostrarTextField)
            {
                lblTextField.Text = labelTextField;
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

            cmbItems.SelectedIndex = 0;
        }
    }
}
