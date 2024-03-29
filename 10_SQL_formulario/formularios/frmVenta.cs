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
            try
            {
                dataGridView1.DataSource = null;
                List<modelo.clsVenta> lstVentas = VentaData.ListarVentas();
                dataGridView1.DataSource = lstVentas;
                dataGridView1.AutoGenerateColumns = true;
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            btnBuscarVentaXiD.Visible = true;
            
        }

        private void btnBuscarVentaxID_Click(object sender, EventArgs e)
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
                    modelo.clsVenta VentaObtenido = VentaData.ObtenerVentaPorId(@id);
                    txtComentarios.Text = VentaObtenido.Comentarios.ToString();
                    txtIdUsuario.Text = VentaObtenido.IdUsuario.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void btnBorrarVentaxID_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?", "Confirmación de borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtID.Text);

                    if (VentaData.BorraVentaPorId(@id))
                    {
                        limpiarDatos();
                        obtenerDatos();
                        txtID.Enabled = true;
                        TareaCompletada("eliminación");
                    }
                    else TareaCompletada("eliminación no");
                }
            }
            catch {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
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
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas Actualizar este registro?", "Confirmación de Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtID.Text);
                    modelo.clsVenta VentaActualizar = new(
                       txtComentarios.Text,
                       int.Parse(txtIdUsuario.Text)
                    );
                    if (VentaData.UpdateVentaPorId(@id, VentaActualizar))
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
            try
            {
                modelo.clsVenta VentaNueva = new(
                   (txtComentarios.Text),
                   int.Parse(txtIdUsuario.Text)

                );
                if (VentaData.AgregarVenta(VentaNueva))
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
