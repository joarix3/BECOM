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
        private IRepository<Beneficio> _beneficioRepository;
        private IRepository<BitacoraTransaccion> _bitacoraTransaccionRepository;
        private IRepository<Requisito> _requisitoRepository;
        
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

        public IRepository<Beneficio> BeneficioRepository
        {
            get
            {
                if (this._beneficioRepository == null)
                {
                    this._beneficioRepository = new BeneficioRepository();
                }
                return _beneficioRepository;
            }
        }

        public IRepository<Requisito> RequisitoRepository
        {
            get
            {
                if (this._requisitoRepository == null)
                {
                    this._requisitoRepository = new RequisitoRepository();
                }
                return _requisitoRepository;
            }
        }


    }
}
