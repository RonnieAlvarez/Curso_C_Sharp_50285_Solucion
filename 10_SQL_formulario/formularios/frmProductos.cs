﻿using _10_SQL_formulario.db;
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
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }
        private void frmProductos_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "LISTADO DE PRODUCTOS";
            obtenerDatos();
        }
        public void obtenerDatos()
        {
            try
            {
                dataGridView1.DataSource = null;
                List<modelo.clsProducto> lstProductos = ProductoData.ListarProductos();
                dataGridView1.DataSource = lstProductos;
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.Columns[2].DefaultCellStyle.Format = "N2";
                dataGridView1.Columns[3].DefaultCellStyle.Format = "N2";
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            btnBuscarProductoXiD.Visible = true;
        }
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void btnBuscarProductoxID_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text))
                {
                    MessageBox.Show($"No se permiten valores nulos.", $"Error en el valor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int id = int.Parse(txtID.Text);
                    modelo.clsProducto ProductoObtenido = ProductoData.ObtenerProductoPorId(@id);
                    txtDescripciones.Text = ProductoObtenido.Descripciones.ToString();
                    txtCosto.Text = ProductoObtenido.Costo.ToString("F2");
                    txtPrecioVenta.Text = ProductoObtenido.PrecioVenta.ToString("F2");
                    txtStock.Text = ProductoObtenido.Stock.ToString();
                    txtIdUsuario.Text = ProductoObtenido.IdUsuario.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void btnBorrarProductoxID_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?", "Confirmación de borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtID.Text);

                    if (ProductoData.BorraProductoPorId(@id))
                    {
                        limpiarDatos();
                        obtenerDatos();
                        txtID.Enabled = true;
                        TareaCompletada("eliminación");
                    }
                    else TareaCompletada("eliminación no");
                }
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void limpiarDatos()
        {
            txtID.Text = string.Empty;
            txtDescripciones.Text = string.Empty;
            txtCosto.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtStock.Text = string.Empty;
            txtIdUsuario.Text = string.Empty;

        }
        private void btnActualizaProductoxID_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas Actualizar este registro?", "Confirmación de Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtID.Text);
                    modelo.clsProducto ProductoActualizar = new(
                       txtDescripciones.Text,
                       decimal.Parse(txtCosto.Text),
                       decimal.Parse(txtPrecioVenta.Text),
                       int.Parse(txtStock.Text),
                       int.Parse(txtIdUsuario.Text)
                    );
                    if (ProductoData.UpdateProductoPorId(@id, ProductoActualizar))
                    {
                        obtenerDatos();
                        limpiarDatos();
                        TareaCompletada("actualización");
                    }
                    else TareaCompletada("actualización no");
                }
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void TareaCompletada(string msm)
        {
            if (msm.Contains(" no"))
                MessageBox.Show($"La {msm} se ha completado correctamente.", $"{msm} completada", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                MessageBox.Show($"La {msm} se ha completado correctamente.", $"{msm} completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true; // Suprime el sonido del bip
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                limpiarDatos();
                txtID.Enabled = true;
                int fila = e.RowIndex;
                txtID.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
                txtDescripciones.Text = dataGridView1.Rows[fila].Cells[1].Value.ToString();
                decimal valorCosto = Convert.ToDecimal(dataGridView1.Rows[fila].Cells[2].Value);
                txtCosto.Text = valorCosto.ToString("N2");
                decimal valorPreciaVenta = Convert.ToDecimal(dataGridView1.Rows[fila].Cells[3].Value);
                txtPrecioVenta.Text = valorPreciaVenta.ToString("N2");
                txtStock.Text = dataGridView1.Rows[fila].Cells[4].Value.ToString();
                txtIdUsuario.Text = dataGridView1.Rows[fila].Cells[5].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                modelo.clsProducto ProductoNuevo = new(
                   txtDescripciones.Text,
                   decimal.Parse(txtCosto.Text),
                   decimal.Parse(txtPrecioVenta.Text),
                   int.Parse(txtStock.Text),
                   int.Parse(txtIdUsuario.Text)
                );
                if (ProductoData.AgregarProducto(ProductoNuevo))
                {
                    obtenerDatos();
                    limpiarDatos();
                    txtID.Enabled = true;
                    TareaCompletada("Inserción");
                }
                else TareaCompletada("Inserción no");
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnLimpiarDatos_Click(object sender, EventArgs e)
        {
            limpiarDatos();
            txtID.Enabled = false;
        }

        private void txtIdUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                btnAgregarProducto.Focus();
            }
        }
    }
}
