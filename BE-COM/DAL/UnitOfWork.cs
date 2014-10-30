using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL.Repositories;

namespace DAL
{
    public class UnitOfWork
    {

        private IRepository<Permiso> _permisoRepository;
        private IRepository<Rol> _rolRepository;
        private IRepository<Carrera> _carreraRepository;
        private IRepository<BitacoraError> _bitacoraErrorRepository;
        private IRepository<BitacoraTransaccion> _bitacoraTransaccionRepository;
        public IRepository<Permiso> PermisoRepository
        {
            get
            {
                if (this._permisoRepository == null)
                {
                    this._permisoRepository = new PermisoRepository();
                }
                return _permisoRepository;
            }
        }

        public IRepository<Rol> RolRepository
        {
            get
            {
                if (this._rolRepository == null)
                {
                    this._rolRepository = new RolRepository();
                }
                return _rolRepository;
            }
        }
        public IRepository<Carrera> CarreraRepository
        {
            get
            {
                if (this._carreraRepository == null)
                {
                    this._carreraRepository = new CarreraRepository();
                }
                return _carreraRepository;
            }
        }

        public IRepository<BitacoraError> BitacoraErrorRepository
        {
            get
            {
                if (this._bitacoraErrorRepository == null)
                {
                    this._bitacoraErrorRepository = new BitacoraErrorRepository();
                }
                return _bitacoraErrorRepository;
            }
        }

        public IRepository<BitacoraTransaccion> BitacoraTransaccionRepository
        {
            get
            {
                if (this._bitacoraTransaccionRepository == null)
                {
                    this._bitacoraTransaccionRepository = new BitacoraTransaccionRepository();
                }
                return _bitacoraTransaccionRepository;
            }
        }


    }
}
