using Parcial2_JuanElias.BLL;
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
    public partial class rInscripciones : Form
    {
        public List<InscripcionesDetalle> Detalle;
        public rInscripciones()
        {
            InitializeComponent();
            EstudianteComboBox();
            AsignaturaComboBox();
            EstudiantecomboBox.Text = null;
            AsignaturacomboBox.Text = null;
            Detalle = new List<InscripcionesDetalle>();
        }
        private void EstudianteComboBox()
        {
            RepositorioBase<Estudiantes> Repositorio = new RepositorioBase<Estudiantes>();
            var list = new List<Estudiantes>();
            list = Repositorio.GetList(p => true);
            EstudiantecomboBox.DataSource = list;
            EstudiantecomboBox.DisplayMember = "Nombres";
            EstudiantecomboBox.ValueMember = "EstudianteId";
        }
        private void AsignaturaComboBox()
        {
            RepositorioBase<Asignaturas> Repositorio = new RepositorioBase<Asignaturas>();
            var list = new List<Asignaturas>();
            list = Repositorio.GetList(p => true);
            AsignaturacomboBox.DataSource = list;
            AsignaturacomboBox.DisplayMember = "Descripcion";
            AsignaturacomboBox.ValueMember = "AsignaturaId";
        }
        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = Detalle;
        }
        private void Limpiar()
        {
            InscripcionIdnumericUpDown.Value = 0;
            CostoCreditosnumericUpDown.Value = 0;
            EstudiantecomboBox.Text = string.Empty;
            AsignaturacomboBox.Text = string.Empty;
            TotalnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            this.Detalle = new List<InscripcionesDetalle>();
            MyErrorProvider.Clear();
            CargarGrid();

        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void LlenaCampo(Inscripciones Inscripcion)
        {
            InscripcionIdnumericUpDown.Value = Inscripcion.InscripcionId;
            CostoCreditosnumericUpDown.Value = (decimal)Inscripcion.MontoCreditos;
            TotalnumericUpDown.Value = (decimal)Inscripcion.Monto;
            FechadateTimePicker.Value = Inscripcion.Fecha;
            EstudiantecomboBox.Text = Inscripcion.EstudianteId.ToString();
            this.Detalle = Inscripcion.Asignatura;
            CargarGrid();

        }
        private Inscripciones LlenaClase()
        {
            Inscripciones Inscripcion = new Inscripciones();
            Inscripcion.Asignatura = this.Detalle;
            Inscripcion.EstudianteId = Convert.ToInt32(EstudiantecomboBox.SelectedValue);
            Inscripcion.InscripcionId = Convert.ToInt32(InscripcionIdnumericUpDown.Value);
            Inscripcion.MontoCreditos = (double)CostoCreditosnumericUpDown.Value;
            Inscripcion.Fecha = FechadateTimePicker.Value;
            Inscripcion.Calculo();
            Inscripcion.Monto = (double)TotalnumericUpDown.Value;
            return Inscripcion;
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Inscripciones> db = new RepositorioBase<Inscripciones>();
            Inscripciones Inscripcion = new Inscripciones();

            int id;
            int.TryParse(InscripcionIdnumericUpDown.Text, out id);
            Limpiar();

            Inscripcion = db.Buscar(id);

            if (Inscripcion != null)
            {
                LlenaCampo(Inscripcion);
            }
            else
            {
                MessageBox.Show("No existe.");
            }
        }
        private bool Validar()
        {

            bool paso = true;
            MyErrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(EstudiantecomboBox.Text))
            {
                MyErrorProvider.SetError(EstudiantecomboBox, "Tiene que haber Estudiante");
                EstudiantecomboBox.Focus();
                paso = false;

            }

            if (CostoCreditosnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CostoCreditosnumericUpDown, "No puede estar en 0");
                CostoCreditosnumericUpDown.Focus();
                paso = false;

            }

            if (FechadateTimePicker.Value > DateTime.Now)
            {
                MyErrorProvider.SetError(FechadateTimePicker, "La fecha no puede ser despues de hoy");
                FechadateTimePicker.Focus();
                paso = false;
            }

            if (Detalle.Count == 0)
            {
                MyErrorProvider.SetError(AsignaturacomboBox, "No deje vacio la Asignatura");
                AsignaturacomboBox.Focus();
                paso = false;
            }
            return paso;
        }
        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Inscripciones> Repositorio = new RepositorioBase<Inscripciones>();
            Inscripciones Inscripcion = Repositorio.Buscar((int)InscripcionIdnumericUpDown.Value);

            return (Inscripcion != null);
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Inscripciones Inscripcion;
            bool paso = false;

            Inscripcion = LlenaClase();
            Inscripcion.Calculo();

            if (!Validar())
                return;

            if (InscripcionIdnumericUpDown.Value == 0)
                paso = InscripcionesBLL.Guardar(Inscripcion);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("NO existe.", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = InscripcionesBLL.Modificar(Inscripcion);
            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Asignaturas> Repositorio = new RepositorioBase<Asignaturas>();
            Asignaturas Asignatura = Repositorio.Buscar((int)AsignaturacomboBox.SelectedValue);

            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<InscripcionesDetalle>)DetalledataGridView.DataSource;


            this.Detalle.Add(new InscripcionesDetalle()
            {
                InscripcionId = (int)InscripcionIdnumericUpDown.Value,
                AsignaturaId = (int)AsignaturacomboBox.SelectedValue,
                DetalleId = 0,
                Subtotal = (double)Asignatura.Creditos * (double)CostoCreditosnumericUpDown.Value
            });

            CargarGrid();
        }
        private bool ValidarEliminar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (InscripcionIdnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(InscripcionIdnumericUpDown, "Busquelo y luego eliminelo.");
                InscripcionIdnumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }
        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Inscripciones> db = new RepositorioBase<Inscripciones>();
            MyErrorProvider.Clear();
            if (!ValidarEliminar())
                return;

            int id;

            int.TryParse(InscripcionIdnumericUpDown.Text, out id);
            Limpiar();

            if (InscripcionesBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado.");
            }
            else
            {
                MyErrorProvider.SetError(InscripcionIdnumericUpDown, "No fue posible.");
            }
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }
    }
}
