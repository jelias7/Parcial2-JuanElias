using Parcial2_JuanElias.UI.Consultas;
using Parcial2_JuanElias.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_JuanElias
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void AsignaturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rAsignaturas asig = new rAsignaturas();
            asig.Show();
        }

        private void EstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes est = new rEstudiantes();
            est.Show();
        }

        private void InscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rInscripciones ins = new rInscripciones();
            ins.Show();
        }

        private void AsignaturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cAsignaturas cas = new cAsignaturas();
            cas.Show();
        }
    }
}
