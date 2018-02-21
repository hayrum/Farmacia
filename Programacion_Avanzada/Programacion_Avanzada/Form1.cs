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
    public partial class Inventario : Form
    {
        BDFarmaciaDataContextDataContext objBD = new BDFarmaciaDataContextDataContext();
        ClaseEmpleados metodosProductos = new ClaseEmpleados();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            Mostrar();
            
        }

        public void Mostrar()
        {
            dgvInventario.DataSource = objBD.Mostrar();
        }
        public void Agregar()
        {
            int idproducto = Convert.ToInt32(txtidProducto.Text);
            string nombre = txtNombre.Text;
            string tipo = cmbTipo.Text;
            string descripcion = rtxtDescripcion.Text;
            float precio = float.Parse(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int idfarmacia = Convert.ToInt32(txtidFarmacia.Text);

            objBD.Agregar(idproducto, nombre, tipo, descripcion, precio, cantidad, idfarmacia);
            MessageBox.Show("Registro insertado correctamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Mostrar();
            ClaseEmpleados Limpiar = new ClaseEmpleados();
            Limpiar.LimpiarControles(this);
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar();
        }

        public void Modificar()
        {
            int idproducto = Convert.ToInt32(txtidProducto.Text);
            string nombre = txtNombre.Text;
            string tipo = cmbTipo.Text;
            string descripcion = rtxtDescripcion.Text;
            float precio = float.Parse(txtPrecio.Text);
            int cantidad = Convert.ToInt32(txtCantidad.Text);
            int idfarmacia = Convert.ToInt32(txtidFarmacia.Text);

            objBD.Modificar(idproducto, nombre, tipo, descripcion, precio, cantidad, idfarmacia);
            MessageBox.Show("Registro modificado correctamente", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Mostrar();
            ClaseEmpleados Limpiar = new ClaseEmpleados();
            Limpiar.LimpiarControles(this);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void dgvInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvInventario_Click(object sender, EventArgs e)
        {
            txtidProducto.Text = dgvInventario.CurrentRow.Cells["idproducto"].Value.ToString();
            txtNombre.Text = dgvInventario.CurrentRow.Cells["nombre"].Value.ToString();
            cmbTipo.Text = dgvInventario.CurrentRow.Cells["tipo"].Value.ToString();
            rtxtDescripcion.Text = dgvInventario.CurrentRow.Cells["descripcion"].Value.ToString();
            txtPrecio.Text = dgvInventario.CurrentRow.Cells["precio"].Value.ToString();
            txtCantidad.Text = dgvInventario.CurrentRow.Cells["cantidad"].Value.ToString();
            txtidFarmacia.Text = dgvInventario.CurrentRow.Cells["idfarmacia"].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
