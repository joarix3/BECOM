﻿using System;
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
            char estado = '1';
            Rol rol = new Rol (pnombre,pdescripcion,estado);
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

        public void eliminarRol(int idRol)
        {
            Rol rol = new Rol {Id= idRol};
            UoW.RolRepository.Update(rol);
        }

        public IEnumerable<Permiso> obtenerPermisos()
        {
            return UoW.PermisoRepository.GetAll();
        }

        public IEnumerable<Rol> obtenerRoles()
        {
            return UoW.RolRepository.GetAll();
        }

        public IEnumerable<Rol> buscarRolPorNombre(String pnombre)
        {
            return UoW.RolRepository.GetAllByName(pnombre);
        }

        public void guardarCambios()
        {
            UoW.RolRepository.Save();
        }

    }
}
