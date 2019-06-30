using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JuanElias.Entidades
{
    public class Inscripciones
    {
        [Key]
        public int InscripcionId { get; set; }
        public int EstudianteId { get; set; }
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public double MontoCreditos { get; set; }
        public virtual List<InscripcionesDetalle> Asignatura { get; set; }
        public Inscripciones()
        {
            InscripcionId = 0;
            EstudianteId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            MontoCreditos = 0;
            Asignatura = new List<InscripcionesDetalle>();
        }
        public void Calculo()
        {
            double total = 0;

            foreach (var item in Asignatura)
            {
                total += item.Subtotal;
            }
            Monto = total;
        }
    }
}
