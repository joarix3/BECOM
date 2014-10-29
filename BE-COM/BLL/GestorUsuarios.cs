using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using EntitiesLayer;
using DAL.Repositories;
namespace BLL
{
    public class GestorUsuarios
    {
        private UnitOfWork UoW = new UnitOfWork();
        private RolRepository Rr = new RolRepository();

        public void agregarUsuario()
        {

        }

        public void agregarRol(String pnombre, String pdescripcion, List<int> ppermisosSeleccionados)
        {
            Rol rol = new Rol (pnombre,pdescripcion);
            int idRol = Rr.InsertRolWithPrivileges(rol);
            
            foreach (int permiso in ppermisosSeleccionados){
                Rr.SetPrivileges(idRol, permiso);
            }


        }

        public void modificarUsuario()
        {

        }

        public void modificarRol(int pid, String pnombre, String pdescripcion, int pestado, List<int> ppermisosSeleccionados)
        {
            Rol rol = new Rol (pid, pnombre, pdescripcion, pestado);
            UoW.RolRepository.Update(rol);
            Rr.ClearPrivileges(pid);
            foreach (int permiso in ppermisosSeleccionados)
            {
                Rr.UpdatePrivileges(pid, permiso);
            }
        }

        public void eliminarUsuario()
        {

        }

        public void eliminarRol(int idRol)
        {
            Rol rol = new Rol {Id= idRol};
            UoW.RolRepository.Delete(rol);
        }

        public IEnumerable<Permiso> obtenerPermisos()
        {
            return UoW.PermisoRepository.GetAll();
        }

        public IEnumerable<Permiso> obtenerPermisosPorRol(int pidRol)
        {
            return Rr.getPrivilegesByRol(pidRol);
        }

        public IEnumerable<Rol> obtenerRoles()
        {
            return UoW.RolRepository.GetAll();
        }

        public IEnumerable<Rol> buscarRolPorNombre(String pnombre)
        {
            return UoW.RolRepository.GetAllByName(pnombre);
        }

        public Rol buscarRolPorId(int pidRol)
        {
            return UoW.RolRepository.GetById(pidRol);
        }

        public IEnumerable<Rol> obtenerRolesInactivos()
        {
            return UoW.RolRepository.GetAllInactive();
        }

        public void guardarCambios()
        {
            UoW.RolRepository.Save();
        }

    }
}
