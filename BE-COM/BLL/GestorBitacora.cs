using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntitiesLayer;

namespace BLL
{
    public class GestorBitacora
    {

        private UnitOfWork UoW = new UnitOfWork();

        public IEnumerable<BitacoraError> obtenerBitacoraError()
        {
            return UoW.BitacoraErrorRepository.GetAll();

        }
        public IEnumerable<BitacoraTransaccion> obtenerBitacoraTransaccion()
        {
            return UoW.BitacoraTransaccionRepository.GetAll();

        }
    }

}
