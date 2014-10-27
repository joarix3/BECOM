using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repositories;
using EntitiesLayer;
using DAL;

namespace BLL
{
    public class GestorTipoBeca
    {
        private UnitOfWork UoW = new UnitOfWork();

        public void agregarTipoBeca(string pnombre, string pdescripcion , string pidPeriodo){
            //try
            //{
                TipoBeca objTipoBeca = new TipoBeca(pnombre, pdescripcion, pidPeriodo);
            //    if (objTipoBeca.IsValid)
            //    {
                    UoW.TipoBecaRepository.Insert(objTipoBeca);
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
            UoW.TipoBecaRepository.Save();
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

    }
}
