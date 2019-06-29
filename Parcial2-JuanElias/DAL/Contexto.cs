using Parcial2_JuanElias.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JuanElias.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Asignaturas> Asignatura { get; set; }
        public DbSet<Estudiantes> Estudiante { get; set; }
        public DbSet<Inscripciones> Inscripcion { get; set; }
        public DbSet<InscripcionesDetalle> InscripcionDetalle { get; set; }
        public Contexto() : base("ConStr") { }
    }
}
