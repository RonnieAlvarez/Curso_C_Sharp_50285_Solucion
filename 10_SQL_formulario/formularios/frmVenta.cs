using _10_SQL_formulario.db;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_SQL_formulario.formularios
{
    public partial class frmVenta : Form
    {
        public frmVenta()
        {
            InitializeComponent();
        }
        private void frmVenta_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "LISTADO DE VENTAS";
            obtenerDatos();
        }
        public void obtenerDatos()
        {
            dataGridView1.DataSource = null;
            VentaData dbProducto = new VentaData();
            List<modelo.clsVenta> lstVentas = dbProducto.ListarVentas();
            dataGridView1.DataSource = lstVentas;
            dataGridView1.AutoGenerateColumns = true;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            btnBuscarVentaXiD.Visible = true;
        }

        private void btnBuscarVentaxID_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                MessageBox.Show($"No se permiten valores nulos.", $"Error en el valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                VentaData dbVenta = new VentaData();
                int id = int.Parse(txtID.Text);
                modelo.clsVenta VentaObtenido = dbVenta.ObtenerVentaPorId(@id);
                txtComentarios.Text = VentaObtenido.Comentarios.ToString();
                txtIdUsuario.Text = VentaObtenido.IdUsuario.ToString();
            }
        }
        private void btnBorrarVentaxID_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?", "Confirmación de borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.Yes)
            {
                VentaData dbVenta = new VentaData();
                int id = int.Parse(txtID.Text);

                if (dbVenta.BorraVentaPorId(@id))
                {
                    limpiarDatos();
                    obtenerDatos();
                    txtID.Enabled = true;
                    TareaCompletada("eliminación");
                }
                else TareaCompletada("eliminación no");
            }
        }
        private void limpiarDatos()
        {
            txtID.Text = string.Empty;
            txtComentarios.Text = string.Empty;
            txtIdUsuario.Text = string.Empty;
        }
        private void btnActualizaVentaxID_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas Actualizar este registro?", "Confirmación de Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirmacion == DialogResult.Yes)
            {
                int id = int.Parse(txtID.Text);
                VentaData dbVenta = new VentaData();
                modelo.clsVenta VentaActualizar = new(
                   txtComentarios.Text,
                   int.Parse(txtIdUsuario.Text)
                );
                if (dbVenta.UpdateVentaPorId(@id, VentaActualizar))
                {
                    obtenerDatos();
                    limpiarDatos();
                    TareaCompletada("actualización");
                }
                else TareaCompletada("actualización no");
            }
        }
        private void TareaCompletada(string msm)
        {
            if (msm.Contains(" no"))
                MessageBox.Show($"La {msm} se ha completado correctamente.", $"{msm} completada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show($"La {msm} se ha completado correctamente.", $"{msm} completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            limpiarDatos();
            txtID.Enabled = true;
            int fila = e.RowIndex;
            txtID.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
            txtComentarios.Text = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            txtIdUsuario.Text = dataGridView1.Rows[fila].Cells[2].Value.ToString();
        }

        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            VentaData dbVenta = new VentaData();
            modelo.clsVenta VentaNueva = new(
               (txtComentarios.Text),
               int.Parse(txtIdUsuario.Text)

            );
            if (dbVenta.AgregarVenta(VentaNueva))
            {
                obtenerDatos();
                limpiarDatos();
                txtID.Enabled = true;
                TareaCompletada("Inserción");
            }
            else TareaCompletada("Inserción no");
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            limpiarDatos();
            txtID.Enabled = false;
            txtComentarios.Focus();
        }

        private void txtAgregar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                btnAgregarVenta.Focus();
            }
        }

           private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true; // Suprime el sonido del bip
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
