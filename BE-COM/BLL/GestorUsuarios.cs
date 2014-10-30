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
        private UsuarioRepository Ur = new UsuarioRepository();

        public void agregarUsuario(int pcedula, String pnombre, String pprimerApellido, String psegundoApellido, String pgenero, int pnumeroTelefono, String pfechaNacimiento, int pedad, int pidRol, String pcorreoElectronico, String pdireccion, String pcontrasena)
        {

            Usuario usuario = new Usuario(pcedula, pnombre, pprimerApellido, psegundoApellido, pgenero, pnumeroTelefono,pfechaNacimiento, pedad,pidRol,pcorreoElectronico,pdireccion,pcontrasena);
            UoW.UsuarioRepository.Insert(usuario);
        
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

        public IEnumerable<Usuario> obtenerUsuarios()
        {
            return UoW.UsuarioRepository.GetAll();
        }

        public IEnumerable<Usuario> obtenerUsuariosInactivos()
        {
            return UoW.UsuarioRepository.GetAllInactive();
        }

        public IEnumerable<Usuario> buscarUsuarioPorNombre(string pnombre)
        {
            return UoW.UsuarioRepository.GetAllByName(pnombre);
        }

        public IEnumerable<Usuario> buscarUsuarioPorCedula(string pcedula)
        {
            return Ur.GetAllByIdentifier(pcedula);
        }

        public IEnumerable<Usuario> buscarUsuariosPorRol(int pidRol)
        {
            return Ur.GetUsersByRol(pidRol);
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
            UoW.UsuarioRepository.Save();
        }

    }
}
