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
<<<<<<< HEAD
<<<<<<< HEAD

        private IRepository<TipoBeca> _tipoBecaRepository;

        private IRepository<Beneficio> _beneficioRepository;

=======
        private IRepository<Carrera> _carreraRepository;
>>>>>>> BECOMM
=======
        private IRepository<Beneficio> _beneficioRepository;
=======
        private IRepository<Carrera> _carreraRepository;
>>>>>>> origin/BECOMM
>>>>>>> BECOMJ
        
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


        public IRepository<TipoBeca> TipoBecaRepository
        {
            get
            {
                if (this._tipoBecaRepository == null)
                {
                    this._tipoBecaRepository = new TipoBecaRepository();
                }
                return _tipoBecaRepository;
            }
        }

        //public IRepository<Beneficio> BeneficioRepository
        //{
        //    get
        //    {
        //        if (this._beneficioRepository == null)
        //        {
        //            this._beneficioRepository = new BeneficioRepository();
        //        }
        //        return _beneficioRepository;
        //    }
        //}



    }
}
