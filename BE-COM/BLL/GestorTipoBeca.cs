using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntitiesLayer;

namespace BLL
{
    public class GestorTipoBeca
    {

        private UnitOfWork UoW = new UnitOfWork();

        public void agregarTipoBeca(String pnombre, String pdescripcion, String pestado, int pidperiodo)
        {
            TipoBeca tipoBeca = new TipoBeca(pnombre, pdescripcion, pestado, pidperiodo);
            UoW.TipoBecaRepository.Insert(tipoBeca);
        }

        public void modificarTipoBeca()
        {

        }

        public void eliminarTipoBeca()
        {

        }

        public IEnumerable<TipoBeca> obtenerTipoBecas()
        {
            return UoW.TipoBecaRepository.GetAll();
        }

        public void guardarCambios()
        {
            UoW.RolRepository.Save();
        }

    }
}
