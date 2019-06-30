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
        private List<InscripcionesDetalle> Detalle;
        public rInscripciones()
        {
            InitializeComponent();
            Detalle = new List<InscripcionesDetalle>();
        }

    }
}
