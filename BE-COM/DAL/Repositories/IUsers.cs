using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
namespace DAL.Repositories
{
    interface IUsers
    {
        void SetPrivileges(int idRol, int idPermiso);
        void UpdatePrivileges(int idRol, int idPermiso);
        int InsertRolWithPrivileges(Rol objRol);
        IEnumerable<Permiso> getPrivilegesByRol(int idRol);
        IEnumerable<Usuario> getUsersByRol(int idRol);
        IEnumerable<Usuario> getUsersByIdentifier(string cedula);
        void ClearPrivileges(int idRol);
    }
}
