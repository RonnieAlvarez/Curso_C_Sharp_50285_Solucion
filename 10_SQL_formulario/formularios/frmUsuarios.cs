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
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = "LISTADO DE USUARIOS";
            obtenerDatos();
        }
        public void obtenerDatos()
        {
            try
            {
                dataGridView1.DataSource = null;
                List<modelo.clsUsuario> lstUsuarios = UsuarioData.ListarUsuarios();
                dataGridView1.DataSource = lstUsuarios;
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
            btnBuscarUsuarioXiD.Visible = true;
        }
        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        private void btnBuscarUsuarioxID_Click(object sender, EventArgs e)
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
                    modelo.clsUsuario usuarioObtenido = UsuarioData.ObtenerUsuarioPorId(@id);
                    txtNombre.Text = usuarioObtenido.Nombre.ToString();
                    txtApellido.Text = usuarioObtenido.Apellido.ToString();
                    txtNombreUsuario.Text = usuarioObtenido.NombreUsuario.ToString();
                    txtContrasena.Text = usuarioObtenido.Password.ToString();
                    txtEmail.Text = usuarioObtenido.Email;
                }
            }
            catch
            {
                MessageBox.Show("Error en tiempo de ejecución, intente más tarde", "Error de ejecución", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            }
        }
        private void btnBorrarUsuarioxID_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas borrar este registro?", "Confirmación de borrado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtID.Text);

                    if (UsuarioData.BorraUsuarioPorId(@id))
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
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtNombreUsuario.Text = string.Empty;
            txtContrasena.Text = string.Empty;
            txtEmail.Text = string.Empty;

        }
        private void btnActualizaUsuarioxID_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult confirmacion = MessageBox.Show("¿Estás seguro de que deseas Actualizar este registro?", "Confirmación de Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (confirmacion == DialogResult.Yes)
                {
                    int id = int.Parse(txtID.Text);

                    modelo.clsUsuario usuarioActualizar = new(
                       txtNombre.Text,
                       txtApellido.Text,
                       txtNombreUsuario.Text,
                       txtContrasena.Text,
                       txtEmail.Text
                    );
                    if (UsuarioData.UpdateUsuarioPorId(@id, usuarioActualizar))
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
            limpiarDatos();
            txtID.Enabled = true;
            int fila = e.RowIndex;
            txtID.Text = dataGridView1.Rows[fila].Cells[0].Value.ToString();
            txtNombre.Text = dataGridView1.Rows[fila].Cells[1].Value.ToString();
            txtApellido.Text = dataGridView1.Rows[fila].Cells[2].Value.ToString();
            txtNombreUsuario.Text = dataGridView1.Rows[fila].Cells[3].Value.ToString();
            txtContrasena.Text = dataGridView1.Rows[fila].Cells[4].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[fila].Cells[5].Value.ToString();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            modelo.clsUsuario usuarioNuevo = new(
               txtNombre.Text,
               txtApellido.Text,
               txtNombreUsuario.Text,
               txtContrasena.Text,
               txtEmail.Text
            );
            if (UsuarioData.AgregarUsuario(usuarioNuevo))
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
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                e.SuppressKeyPress = true;
                btnAgregarUsuario.Focus();
            }
        }
    }
}
