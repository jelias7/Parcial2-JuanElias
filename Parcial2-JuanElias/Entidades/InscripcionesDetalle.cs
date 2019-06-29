using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JuanElias.Entidades
{
    public class InscripcionesDetalle
    {
        [Key]
        public int DetalleId { get; set; }
        public int InscripcionId { get; set; }
        public int AsignaturaId { get; set; }
        public double Subtotal { get; set; }
        public InscripcionesDetalle()
        {
            DetalleId = 0;
            InscripcionId = 0;
            AsignaturaId = 0;
            Subtotal = 0;
        }
    }
}
