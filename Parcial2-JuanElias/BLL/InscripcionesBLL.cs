using Parcial2_JuanElias.DAL;
using Parcial2_JuanElias.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JuanElias.BLL
{
    public class InscripcionesBLL
    {
        public static bool Guardar(Inscripciones Inscripcion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                RepositorioBase<Estudiantes> Repositorio = new RepositorioBase<Estudiantes>();

                if (contexto.Inscripcion.Add(Inscripcion) != null)
                {
                    var estudiante = Repositorio.Buscar(Inscripcion.EstudianteId);

                    Inscripcion.Calculo();

                    estudiante.Balance += Inscripcion.Monto;

                    paso = contexto.SaveChanges() > 0;

                    Repositorio.Modificar(estudiante);
                }

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Modificar(Inscripciones Inscripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            RepositorioBase<Estudiantes> Repositorio = new RepositorioBase<Estudiantes>();

            try
            {
                var estudiante = Repositorio.Buscar(Inscripcion.EstudianteId);
                var anterior = new RepositorioBase<Inscripciones>().Buscar(Inscripcion.InscripcionId);

                estudiante.Balance -= anterior.Monto;

                foreach (var item in anterior.Asignatura)
                {
                    if (!Inscripcion.Asignatura.Any(A => A.DetalleId == item.DetalleId))
                    {
                        db.Entry(item).State = EntityState.Deleted;
                    }
                }

                foreach (var item in Inscripcion.Asignatura)
                {
                    if (item.DetalleId == 0)
                    {
                        db.Entry(item).State = EntityState.Added;
                    }
                    else
                    {
                        db.Entry(item).State = EntityState.Modified;
                    }
                }

                Inscripcion.Calculo();
                estudiante.Balance += Inscripcion.Monto;

                Repositorio.Modificar(estudiante);
                db.Entry(Inscripcion).State = EntityState.Modified;
                paso = db.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            RepositorioBase<Estudiantes> Repositorio = new RepositorioBase<Estudiantes>();
            Contexto contexto = new Contexto();

            try
            {
                var Inscripcion = contexto.Inscripcion.Find(id);
                var Estudiante = Repositorio.Buscar(Inscripcion.EstudianteId);

                Estudiante.Balance = Estudiante.Balance - Inscripcion.Monto;
                Repositorio.Modificar(Estudiante);

                contexto.Entry(Inscripcion).State = EntityState.Deleted;
                paso = (contexto.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
    }
}
