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

        //Metodo que consulta la informacion de un beneficio que esten en estado activo 
        public IEnumerable<Beneficio> consultarBeneficioPorEstado()
        {
            return UoW.BeneficioRepository.GetAll();
        }
        public void guardarCambios()
        {
            UoW.BeneficioRepository.Save();
        }

        //Metodo que consulta la informacion de un beneficio por medio del nombre
        public IEnumerable<Beneficio> consultarBeneficioPorNombre(string nombre)
        {
            return UoW.BeneficioRepository.GetAllByName(nombre);
        }

        //Metodo que consulta la informacion de un beneficio por medio del id
        public Beneficio ObtenerBeneficioPorId(int pid)
        {
            return UoW.BeneficioRepository.GetById(pid);
        }

        //Metodo que modifica la informacion de un beneficio
        public void modificarBeneficio(int pid, string pnombre, double pporcentaje, string pdescripcion)
        {
            Beneficio objBeneficio = new Beneficio(pid, pnombre, pporcentaje, pdescripcion);
            UoW.BeneficioRepository.Update(objBeneficio);
        }

        public void eliminarBeneficio(int pid)
        {
            Beneficio objBeneficio = new Beneficio {Id = pid};
            UoW.BeneficioRepository.Delete(objBeneficio);
        }

    }
}
