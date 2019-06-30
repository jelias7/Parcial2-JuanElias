using Parcial2_JuanElias.BLL;
using Parcial2_JuanElias.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_JuanElias.UI.Consultas
{
    public partial class cAsignaturas : Form
    {
        public cAsignaturas()
        {
            InitializeComponent();
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Asignaturas>();

            RepositorioBase<Asignaturas> r = new RepositorioBase<Asignaturas>();


            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.Text)
                {
                    case "Todo":
                        listado = r.GetList(p => true);
                        break;

                    case "ID":
                        int parse;
                        if (!int.TryParse(CriteriotextBox.Text, out parse))
                        {
                            MessageBox.Show("Solo numeros.");
                        }
                        else
                        {
                            int id = Convert.ToInt32(CriteriotextBox.Text);
                            listado = r.GetList(p => p.AsignaturaId == id);
                        }
                        break;

                    case "Descripcion":
                        listado = r.GetList(p => p.Descripcion.Contains(CriteriotextBox.Text));
                        break;

                    case "Creditos":
                        double parsec;
                        if (!double.TryParse(CriteriotextBox.Text, out parsec))
                        {
                            MessageBox.Show("Solo numeros.");
                        }
                        else
                        {
                            double c = double.Parse(CriteriotextBox.Text);
                            listado = r.GetList(p => p.Creditos == c);
                        }
                        break;

                }
            }
            else
            {
                if (FiltrocomboBox.Text == string.Empty)
                {
                    MessageBox.Show("El filtro no puede estar vacio.");
                }
                else
                    if ((string)FiltrocomboBox.Text != "Todo")
                {
                    if (CriteriotextBox.Text == string.Empty)
                    {
                        MessageBox.Show("Al seleccionar uno de ID, Descripcion o Creditos necesita escribir algo en el criterio.");
                    }
                }
                else
                {
                    listado = r.GetList(p => true);
                }
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
