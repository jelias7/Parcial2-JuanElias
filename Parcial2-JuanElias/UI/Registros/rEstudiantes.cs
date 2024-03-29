﻿using Parcial2_JuanElias.BLL;
using Parcial2_JuanElias.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_JuanElias.UI.Registros
{
    public partial class rEstudiantes : Form
    {
        public rEstudiantes()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {

            EstudianteIdnumericUpDown.Value = 0;
            FechaIngresodateTimePicker.Value = DateTime.Now;
            NombrestextBox.Text = string.Empty;
            BalancenumericUpDown.Value = 0;
            MyErrorProvider.Clear();

        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();
            estudiante.EstudianteId = Convert.ToInt32(EstudianteIdnumericUpDown.Value);
            estudiante.Nombres = NombrestextBox.Text;
            estudiante.FechaIngreso = FechaIngresodateTimePicker.Value;
            estudiante.Balance = (double)BalancenumericUpDown.Value;
            return estudiante;
        }

        private void LlenaCampo(Estudiantes estudiante)
        {
            EstudianteIdnumericUpDown.Value = estudiante.EstudianteId;
            NombrestextBox.Text = estudiante.Nombres;
            FechaIngresodateTimePicker.Value = estudiante.FechaIngreso;
            BalancenumericUpDown.Value = (decimal)estudiante.Balance;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Estudiantes> Repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes estudiante = Repositorio.Buscar((int)EstudianteIdnumericUpDown.Value);
            return (estudiante != null);
        }
        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(NombrestextBox.Text))
            {
                MyErrorProvider.SetError(NombrestextBox, "No puede ser vacio.");
                paso = false;
            }

            if (FechaIngresodateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechaIngresodateTimePicker, "No se puede registrar esta fecha.");
                paso = false;
            }

            return paso;
        }
        private bool ValidarEliminar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (EstudianteIdnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(EstudianteIdnumericUpDown, "Busquelo y luego eliminelo.");
                EstudianteIdnumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> Repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes Estudiante = new Estudiantes();
            bool paso = false;
            Estudiante = LlenaClase();

            if (!Validar())
                return;

            if (EstudianteIdnumericUpDown.Value == 0)
                paso = Repositorio.Guardar(Estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar.","Fallo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    return;
                }
                paso = Repositorio.Modificar(Estudiante);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> Repositorio = new RepositorioBase<Estudiantes>();

            MyErrorProvider.Clear();
            if (!ValidarEliminar())
                return;

            int id;
            int.TryParse(EstudianteIdnumericUpDown.Text, out id);

            Limpiar();

            if (Repositorio.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                MyErrorProvider.SetError(EstudianteIdnumericUpDown, "No existe.");
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Estudiantes> Repositorio = new RepositorioBase<Estudiantes>();
            Estudiantes Estudiante = new Estudiantes();
            int id;
            int.TryParse(EstudianteIdnumericUpDown.Text, out id);
            Limpiar();

            Estudiante = Repositorio.Buscar(id);
            if (Estudiante != null)
                LlenaCampo(Estudiante);
            else
                MessageBox.Show("No encontrado.");
        }

        private void NombrestextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }
    }
}
