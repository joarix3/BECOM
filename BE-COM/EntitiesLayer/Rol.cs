using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Rol : IEntity
    {
        private int _idRol;

        public int Id
        {
            get { return _idRol; }
            set { _idRol = value; }
        }

        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Permiso> permisos;

        public Rol()
        {
            Id = 0;
            Nombre = "";
            Descripcion = "";
            permisos = new List<Permiso>();
        }

        public Rol(string pnombre, string pdescripcion)
        {
            Id = 0;
            Nombre = pnombre;
            Descripcion = pdescripcion;
        }
    }
}

