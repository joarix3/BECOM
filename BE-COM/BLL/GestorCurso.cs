using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntitiesLayer;

namespace BLL
{
    public class GestorCurso
    {

        private UnitOfWork UoW = new UnitOfWork();

        public void agregarCurso(String pcodigo, String pnombre, int pcreditos, int pcosto, int pestado)
        {
            //try
            //{
            Curso  objCurso = new Curso(pcodigo, pnombre, pcreditos, pcosto, pestado);
            ////    if (objTipoBeca.IsValid)
            ////    {
            UoW.CursoRepository.Insert(objCurso);
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
        public IEnumerable<Curso> obtenerCursos()
        {
            return UoW.CursoRepository.GetAll();
        }
        public void modificarCurso(int pidCurso, String pcodigo, String pnombre, int pcreditos, int pcosto, int pestado)
        {
            Curso objCurso = new Curso(pidCurso, pcodigo, pnombre, pcreditos, pcosto, pestado);

            UoW.CursoRepository.Update(objCurso);
        }

        public void eliminarCurso(int pidCurso)
        {
            Curso objCurso = new Curso{Id=pidCurso};

            UoW.CursoRepository.Delete(objCurso);
        }
        public Curso ObtenerCursoPorId(int pid)
        {
            return UoW.CursoRepository.GetById(pid);
        }

        public void guardarCambios()
        {
            UoW.CursoRepository.Save();
        }

    }
}
