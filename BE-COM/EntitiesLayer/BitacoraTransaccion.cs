using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class BitacoraTransaccion : IEntity
    {
        private int idUsuario;

        public int Id
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public String Transaccion { get; set; }
        public DateTime Fecha { get; set; }


        public BitacoraTransaccion()
        {
            Id = 0;
            Transaccion = "";
            Fecha = DateTime.Now;
        }

        public BitacoraTransaccion(int pid, string ptransaccion, DateTime pfecha)
        {
            Id = pid;
            Transaccion = ptransaccion;
            Fecha = pfecha;
        }

    }
}
