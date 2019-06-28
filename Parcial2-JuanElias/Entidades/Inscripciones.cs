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
        public DateTime Fecha { get; set; }
        public double Monto { get; set; }
        public Inscripciones()
        {
            InscripcionId = 0;
            Fecha = DateTime.Now;
            Monto = 0;
        }
    }
}
