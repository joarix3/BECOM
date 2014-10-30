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

        public DateTime Fecha { get; set; }
        public String Descripcion { get; set; }


        public BitacoraTransaccion()
        {
            Id = 0;
            Fecha = DateTime.Now;
            Descripcion = "";
        }

        public BitacoraTransaccion(int pid, DateTime pfecha, String pdescripcion)
        {
            Id = pid;
            Fecha = pfecha;
            Descripcion = pdescripcion;
        }

    }
}
