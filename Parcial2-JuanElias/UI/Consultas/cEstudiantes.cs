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

namespace Parcial2_JuanElias.UI.Consultas
{
    public partial class cEstudiantes : Form
    {
        public cEstudiantes()
        {
            InitializeComponent();
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Estudiantes>();
            RepositorioBase<Estudiantes> r = new RepositorioBase<Estudiantes>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.Text)
                {
                    case "Todo":
                        listado = r.GetList(p => true);
                        break;
                }
            }
            else
            {
                listado = r.GetList(p => true);
            }
            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
