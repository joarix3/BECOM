using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL;

namespace BLL
{
    public class GestorBitacoraTransaccion
    {
     private UnitOfWork UoW = new UnitOfWork();

        public void agregarBitacoraTransaccion(int idUsuario, string transaccion, DateTime fecha)
        {
          
            try
           
            {
                BitacoraTransaccion objBitacoraTransaccion = new BitacoraTransaccion(idUsuario, transaccion, fecha);

                UoW.BitacoraTransaccionRepository.Insert(objBitacoraTransaccion);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void guardarCambios()
        {
            UoW.BitacoraTransaccionRepository.Save();
        }

    }
}
