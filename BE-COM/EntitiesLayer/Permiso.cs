using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Permiso : IEntity
    {
        private int _idPermiso;

        public int Id
        {
            get { return _idPermiso; }
            set { _idPermiso = value; }
        }

        public String Nombre { get; set; }
        public String Descripcion { get; set; }

        public Permiso()
        {
            Id = 0;
            Nombre = "";
            Descripcion = "";
        }

        public Permiso(int pidPermiso, string pnombre, string pdescripcion)
        {
            Id = pidPermiso;
            Nombre = pnombre;
            Descripcion = pdescripcion;
        }
    }
}
