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
                        case "ID":
                            int parse;
                            if (!int.TryParse(CriteriotextBox.Text, out parse))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.EstudianteId == id);
                            }
                            break;
                        case "Nombres":
                            if (!System.Text.RegularExpressions.Regex.IsMatch(CriteriotextBox.Text, "^[a-zA-Z ]"))
                            {
                                MessageBox.Show("No numeros en los nombres.");
                            }
                            else
                            {
                                listado = r.GetList(p => p.Nombres.Contains(CriteriotextBox.Text));
                            }
                            break;

                        case "Balance":
                            double parsec;
                            if (!double.TryParse(CriteriotextBox.Text, out parsec))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                double c = double.Parse(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Balance == c);
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
                            MessageBox.Show("Al seleccionar uno de ID, Nombres o Balance necesita escribir algo en el criterio.");
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
