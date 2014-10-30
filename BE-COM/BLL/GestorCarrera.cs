using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntitiesLayer;
using DAL.Repositories;

namespace BLL
{
    public class GestorCarrera
    {


        private UnitOfWork UoW = new UnitOfWork();
        private CarreraRepository cr = new CarreraRepository();
        public void agregarCarrera(String pcodigo, String pnombre, int pidUniversidad, String pcolor, int pbecas, int pestado)
        {
            //try
            //{
            Carrera objCarrera = new Carrera(pcodigo, pnombre, pidUniversidad, pcolor, pbecas, pestado);
            //    if (objTipoBeca.IsValid)
            //    {
            UoW.CarreraRepository.Insert(objCarrera);
            //    }
            //    else
            //    {
            //        StringBuilder sb = new StringBuilder();
            //        foreach (RuleViolation rv in objTipoBeca.GetRuleViolations())
            //        {
            //            sb.AppendLine(rv.ErrorMessage);
            //        }
            //        throw new ApplicationException(sb.ToString());
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }
        public IEnumerable<Carrera> obtenerCarreras()
        {
            return UoW.CarreraRepository.GetAll();
        }
        public void modificarCarrera(int pidCarrera, String pcodigo, String pnombre, int pidUniversidad, String pcolor, int pbecas, int pestado)
        {
            Carrera objCarrera = new Carrera(pidCarrera, pcodigo, pnombre, pidUniversidad, pcolor, pbecas, pestado);

            UoW.CarreraRepository.Update(objCarrera);
        }
        public Carrera ObtenerCarreraPorId(int pid)
        {
            return UoW.CarreraRepository.GetById(pid);
        }
        public void eliminarCarrera(int pidCarrera)
        {
            Carrera objCarrera = new Carrera { Id = pidCarrera };

            UoW.CarreraRepository.Delete(objCarrera);
        }
        public void asociarCursosCarrera(int pidCarrera, int pidCurso)
        {
            cr.AsociarCursosCarrera(pidCarrera, pidCurso);
        }

        public IEnumerable<Curso> obtenerCursosUnSeleccionados(int pidCarrera)
        {
            return cr.GetAllCursosByUnCarrera(pidCarrera);
        }
        public IEnumerable<Curso> obtenerCursosByCarrera(int pidCarrera)
        {
            return cr.GetAllCursosByCarrera(pidCarrera);
        }
        public void guardarCambios()
        {
            UoW.CarreraRepository.Save();
        }
        public IEnumerable<Carrera> buscarCarreraPorNombre(String pnombre)
        {
            return UoW.CarreraRepository.GetAllByName(pnombre);
        }
        

    }
}
