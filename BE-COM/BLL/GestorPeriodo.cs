using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntitiesLayer;


namespace BLL
{
    public class GestorPeriodo
    {
        private UnitOfWork UoW = new UnitOfWork();

        public void agregarPeriodo(String pnombre, int pdia, int pmes){
            //try
            //{
                Periodo objPeriodo = new Periodo(pnombre, pdia, pmes);
            //    if (objTipoBeca.IsValid)
            //    {
                    UoW.PeriodoRepository.Insert(objPeriodo);
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

        public void guardarCambios()
        {
            //try
            //{
            UoW.PeriodoRepository.Save();
            //    }
            //    catch (DataAccessException ex)
            //    {
            //        throw ex;
            //    }
            //    catch (Exception ex)
            //    {
            //        //logear a la bd
            //        throw new BusinessLogicException("Ha ocurrido un error al eliminar un usuario", ex);
            //    }
        }
        //Metodo que retorna los de vigencia de los tipos de beca del sistema
        public IEnumerable<Periodo> obtenerPeriodos()
        {
            return UoW.PeriodoRepository.GetAll();
        }

        public IEnumerable<Periodo> obtenerPeriodosInaactivos()
        {
            return UoW.PeriodoRepository.GetAllInactive();
        }
        
         //Metodo que optienen un periodo de vigencia
         //de acuardo al id que reciba
        public Periodo ObtenerPeriodoPorId(int pid)
        {
            return UoW.PeriodoRepository.GetById(pid);
        }

        //Metodo que modifica la informacion de un periodo de vigencia
        public void modificarPeriodo(int pid, String pnombre, int pdia, int pmes, String pestado)
        {

            Periodo objPeriodo = new Periodo(pid, pnombre, pdia, pmes, pestado);
            UoW.PeriodoRepository.Update(objPeriodo);

        }

        public void eliminarPeriodo(int pidPeriodo)
        {
            Periodo objPeriodo = new Periodo { Id = pidPeriodo };
            UoW.PeriodoRepository.Delete(objPeriodo);
            UoW.PeriodoRepository.Save();
        }

    }
}
