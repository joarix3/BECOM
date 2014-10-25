using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntitiesLayer;

namespace BLL
{
    public class GestorCarrera
    {
      
            private UnitOfWork UoW = new UnitOfWork();

            public void agregarCarrera(String pcodigo,String pnombre, int pidUniversidad,String pcolor, int pbecas)
            {
                //try
                //{
                Carrera objCarrera = new Carrera(pcodigo,pnombre,pidUniversidad,pcolor,pbecas);
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
            public void modificarCarrera()
            {

            }

            public void eliminarCarrera()
            {

            }
            public void guardarCambios()
            {
                UoW.CarreraRepository.Save();
            }

        
    }
}
