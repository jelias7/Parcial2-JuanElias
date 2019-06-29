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
    public partial class rAsignaturas : Form
    {
        public rAsignaturas()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {

            AsignaturaIdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            CreditosnumericUpDown.Value = 0;
            MyErrorProvider.Clear();

        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void LlenaCampo(Asignaturas Asignatura)
        {
            AsignaturaIdnumericUpDown.Value = Asignatura.AsignaturaId;
            DescripciontextBox.Text = Asignatura.Descripcion;
            CreditosnumericUpDown.Value = (decimal)Asignatura.Creditos;
        }
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> Repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas Asignatura = new Asignaturas();
            int id;
            int.TryParse(AsignaturaIdnumericUpDown.Text, out id);
            Limpiar();

            Asignatura = Repositorio.Buscar(id);
            if (Asignatura != null)
                LlenaCampo(Asignatura);
            else
                MessageBox.Show("No encontrado.");
        }
        private Asignaturas LlenaClase()
        {
            Asignaturas Asignatura = new Asignaturas();
            Asignatura.AsignaturaId = Convert.ToInt32(AsignaturaIdnumericUpDown.Value);
            Asignatura.Descripcion = DescripciontextBox.Text;
            Asignatura.Creditos = (double)CreditosnumericUpDown.Value;
            return Asignatura;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Asignaturas> Repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas Asignatura = Repositorio.Buscar((int)AsignaturaIdnumericUpDown.Value);

            return (Asignatura != null);

        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> Repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas Asignatura = new Asignaturas();
            bool paso = false;
            Asignatura = LlenaClase();

            if (AsignaturaIdnumericUpDown.Value == 0)
                paso = Repositorio.Guardar(Asignatura);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede guardar.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = Repositorio.Modificar(Asignatura);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> Repositorio = new RepositorioBase<Asignaturas>();

            MyErrorProvider.Clear();

            int id;
            int.TryParse(AsignaturaIdnumericUpDown.Text, out id);

            Limpiar();

            if (Repositorio.Eliminar(id))
                MessageBox.Show("Eliminado");
            else
                MyErrorProvider.SetError(AsignaturaIdnumericUpDown, "No existe.");
        }
    }
}