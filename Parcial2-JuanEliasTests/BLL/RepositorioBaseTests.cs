using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial2_JuanElias.BLL;
using Parcial2_JuanElias.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2_JuanElias.BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void AsignaturaGuardarTest()
        {
            Asignaturas a = new Asignaturas();
            a.AsignaturaId = 1;
            a.Descripcion = "Matematicas";
            a.Creditos = 5;

            RepositorioBase<Asignaturas> r = new RepositorioBase<Asignaturas>();
            bool paso = false;
            paso = r.Guardar(a);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void AsignaturaModificarTest()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            bool paso = false;
            Asignaturas a = repositorio.Buscar(1);
            a.Creditos = 4;
            paso = repositorio.Modificar(a);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void AsignaturasBuscarTest()
        {
            RepositorioBase<Asignaturas> repositoriobase = new RepositorioBase<Asignaturas>();
            Asignaturas a = repositoriobase.Buscar(1);
            Assert.IsNotNull(a);
        }

        [TestMethod()]
        public void AsignaturasGetListTest()
        {
            RepositorioBase<Asignaturas> repositorio = new RepositorioBase<Asignaturas>();
            List<Asignaturas> lista = new List<Asignaturas>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }

        [TestMethod()]
        public void EstudianteGuardarTest()
        {
            Estudiantes e = new Estudiantes();
            e.EstudianteId = 1;
            e.FechaIngreso = DateTime.Now;
            e.Nombres = "Juan Elias";
            e.Balance = 10000;

            RepositorioBase<Estudiantes> r = new RepositorioBase<Estudiantes>();
            bool paso = false;
            paso = r.Guardar(e);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void EstudianteModificarTest()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            bool paso = false;
            Estudiantes e = repositorio.Buscar(1);
            e.Nombres = "Jose";
            paso = repositorio.Modificar(e);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void EstudianteBuscarTest()
        {
            RepositorioBase<Estudiantes> repositoriobase = new RepositorioBase<Estudiantes>();
            Estudiantes e = repositoriobase.Buscar(1);
            Assert.IsNotNull(e);
        }

        [TestMethod()]
        public void EstudianteGetListTest()
        {
            RepositorioBase<Estudiantes> repositorio = new RepositorioBase<Estudiantes>();
            List<Estudiantes> lista = new List<Estudiantes>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void InscripcionGuardarTest()
        {
            Inscripciones i = new Inscripciones();
            i.InscripcionId = 1;
            i.EstudianteId = 1;
            i.Fecha = DateTime.Now;
            i.MontoCreditos = 1000;
           

            RepositorioBase<Inscripciones> r = new RepositorioBase<Inscripciones>();
            bool paso = false;
            paso = r.Guardar(i);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void InscripcionModificarTest()
        {
            RepositorioBase<Inscripciones> repositorio = new RepositorioBase<Inscripciones>();
            bool paso = false;
            Inscripciones i = repositorio.Buscar(1);
            i.MontoCreditos = 500;
            paso = repositorio.Modificar(i);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void InscripcionBuscarTest()
        {
            RepositorioBase<Inscripciones> repositoriobase = new RepositorioBase<Inscripciones>();
            Inscripciones i = repositoriobase.Buscar(1);
            Assert.IsNotNull(i);
        }

        [TestMethod()]
        public void InscripcionGetListTest()
        {
            RepositorioBase<Inscripciones> repositorio = new RepositorioBase<Inscripciones>();
            List<Inscripciones> lista = new List<Inscripciones>();
            lista = repositorio.GetList(e => true);
            Assert.IsNotNull(lista);
        }
        [TestMethod()]
        public void AsignaturaEliminarTest()
        {
            RepositorioBase<Asignaturas> repositoriobase = new RepositorioBase<Asignaturas>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void EstudiantesEliminarTest()
        {
            RepositorioBase<Estudiantes> repositoriobase = new RepositorioBase<Estudiantes>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
        [TestMethod()]
        public void InscripcionEliminarTest()
        {
            RepositorioBase<Inscripciones> repositoriobase = new RepositorioBase<Inscripciones>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);
        }
    }
}