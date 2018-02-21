using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programacion_Avanzada
{
    public partial class Empleados : Form
    {
        BDFarmaciaDataContextDataContext objBD = new BDFarmaciaDataContextDataContext();
        ClaseEmpleados metodosEmpleados = new ClaseEmpleados();

        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        public void Mostrar()
        {
            dgvEmpleados.DataSource = objBD.Mostrar();
        }

        public void Agregar()
        {
            int idEmpleado = Convert.ToInt32(txtIdEmpleado.Text);
            string nombre = txtNombre.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            string domicilio = txtDomicilio.Text;
            decimal sueldo = decimal.Parse(txtSueldo.Text);
            string puesto = txtPuesto.Text;
            DateTime horarioEntrada = Convert.ToDateTime(dateTimeHorarioEntrada.Value);
            DateTime horarioSalida = Convert.ToDateTime(dateTimeHorarioSalida.Value);

            objBD.AgregarEmpleados(idEmpleado, nombre, edad, domicilio, sueldo, horarioEntrada, horarioSalida, puesto);
            MessageBox.Show("Registro insertado correctamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Mostrar();
            ClaseEmpleados Limpiar = new ClaseEmpleados();
            Limpiar.LimpiarControles(this);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }
    }
}
