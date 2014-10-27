using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL;

namespace BLL
{
    public class GestorBeneficio
    {
        private UnitOfWork UoW = new UnitOfWork();

        public void agregarBeneficio(string nombre, double porcentaje, string descripcion)
        { 
            try
            {
                Beneficio objBeneficio = new Beneficio(nombre, porcentaje, descripcion);
                UoW.BeneficioRepository.Insert(objBeneficio);
            }
            catch (Exception)
            {

            }
        }

        public IEnumerable<Beneficio> consultarBeneficioPorEstado()
        {
            return UoW.BeneficioRepository.GetAll();
        }
        public void guardarCambios()
        {
            UoW.BeneficioRepository.Save();
        }

    }
}
