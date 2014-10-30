using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class BitacoraError : IEntity
    {
        private int _idBitacoraError;

        public int Id
        {
            get { return _idBitacoraError; }
            set { _idBitacoraError = value; }
        }

        public int IdUsuario { get; set; }
        public DateTime Fecha { get; set; }
        public String Descripcion { get; set; }


        public BitacoraError(int pid,int pidUsuario, DateTime pfecha, String pdescripcion)
        {
            Id = pid;
            IdUsuario = pidUsuario;
            Fecha = pfecha;
            Descripcion = pdescripcion;
        }

        public BitacoraError()
        {
            Id = 0;
            IdUsuario = 0;
            Fecha = DateTime.Now;
            Descripcion = "";
        }
    }
}
