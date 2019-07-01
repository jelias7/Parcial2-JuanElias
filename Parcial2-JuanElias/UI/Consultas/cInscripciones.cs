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
    public partial class cInscripciones : Form
    {
        public cInscripciones()
        {
            InitializeComponent();
        }

        private void Consultabutton_Click(object sender, EventArgs e)
        {
            var listado = new List<Inscripciones>();
            RepositorioBase<Inscripciones> r = new RepositorioBase<Inscripciones>();
            if (RangocheckBox.Checked == true)
            {
                if (CriteriotextBox.Text.Trim().Length > 0)
                {
                    switch (FiltrocomboBox.Text)
                    {
                        case "Todo":
                            listado = r.GetList(p => true);
                            break;
                        case "InscripcionId":
                            int parse;
                            if (!int.TryParse(CriteriotextBox.Text, out parse))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.InscripcionId == id);
                            }
                            break;
                        case "EstudianteId":
                            int parsed;
                            if (!int.TryParse(CriteriotextBox.Text, out parsed))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.EstudianteId == id);
                            }
                            break;

                        case "Monto":
                            double parsec;
                            if (!double.TryParse(CriteriotextBox.Text, out parsec))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                double c = double.Parse(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Monto == c);
                            }
                            break;
                        case "Monto de Creditos":
                            double parsecc;
                            if (!double.TryParse(CriteriotextBox.Text, out parsecc))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                double c = double.Parse(CriteriotextBox.Text);
                                listado = r.GetList(p => p.MontoCreditos == c);
                            }
                            break;

                    }
                    listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
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
                            MessageBox.Show("Al seleccionar uno de InscripcionId, EstudianteId, Monto o Monto de Creditos necesita escribir algo en el criterio.");
                        }
                    }
                    listado = r.GetList(p => true);
                    listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
                }
                ConsultadataGridView.DataSource = null;
                ConsultadataGridView.DataSource = listado;
            }
            else
            {
                if (CriteriotextBox.Text.Trim().Length > 0)
                {
                    switch (FiltrocomboBox.Text)
                    {
                        case "Todo":
                            listado = r.GetList(p => true);
                            break;
                        case "InscripcionId":
                            int parse;
                            if (!int.TryParse(CriteriotextBox.Text, out parse))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.InscripcionId == id);
                            }
                            break;
                        case "EstudianteId":
                            int parsed;
                            if (!int.TryParse(CriteriotextBox.Text, out parsed))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                int id = Convert.ToInt32(CriteriotextBox.Text);
                                listado = r.GetList(p => p.EstudianteId == id);
                            }
                            break;

                        case "Monto":
                            double parsec;
                            if (!double.TryParse(CriteriotextBox.Text, out parsec))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                double c = double.Parse(CriteriotextBox.Text);
                                listado = r.GetList(p => p.Monto == c);
                            }
                            break;
                        case "Monto de Creditos":
                            double parsecc;
                            if (!double.TryParse(CriteriotextBox.Text, out parsecc))
                            {
                                MessageBox.Show("Solo numeros.");
                            }
                            else
                            {
                                double c = double.Parse(CriteriotextBox.Text);
                                listado = r.GetList(p => p.MontoCreditos == c);
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
                            MessageBox.Show("Al seleccionar uno de InscripcionId, EstudianteId, Monto o Monto de Creditos necesita escribir algo en el criterio.");
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
}
