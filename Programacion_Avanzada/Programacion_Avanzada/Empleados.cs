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
            string usuario = txtUsuario.Text;
            string nombreEmpleado = txtEmpleado.Text;
            string contraseña = txtContraseña.Text;

            objBD.AgregarEmpleado(idEmpleado, usuario, nombreEmpleado, contraseña);
            MessageBox.Show("Registro insertado correctamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Mostrar();
            ClaseEmpleados Limpiar = new ClaseEmpleados();
            Limpiar.LimpiarControles(this);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        private void txtEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
