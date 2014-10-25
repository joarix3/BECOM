using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntitiesLayer;
namespace BLL
{
    public class GestorUsuarios
    {
        private UnitOfWork UoW = new UnitOfWork();

        public void agregarUsuario()
        {

        }

        public void agregarRol(String pnombre, String pdescripcion, List<int> ppermisosSeleccionados)
        {
            Rol rol = new Rol (pnombre,pdescripcion);
            UoW.RolRepository.Insert(rol);

        }

        public void modificarUsuario()
        {

        }

        public void modificarRol()
        {

        }

        public void eliminarUsuario()
        {

        }

        public void eliminarRol()
        {

        }

        public IEnumerable<Permiso> obtenerPermisos()
        {
            return UoW.PermisoRepository.GetAll();
        }

        public void guardarCambios()
        {
            UoW.RolRepository.Save();
        }

    }
}
