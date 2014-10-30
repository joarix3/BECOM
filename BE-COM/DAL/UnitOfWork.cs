﻿using System;
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
        private IRepository<Carrera> _carreraRepository;
<<<<<<< HEAD
        private IRepository<Periodo> _periodoRepository;
        private IRepository<TipoBeca> _tipoBecaRepository;
 
=======
        private IRepository<Curso> _cursoRepository;
        
>>>>>>> BECOMM
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

<<<<<<< HEAD
        public IRepository<Periodo> PeriodoRepository
        {
            get
            {
                if (this._periodoRepository == null)
                {
                    this._periodoRepository = new PeriodoRepository();
                }
                return _periodoRepository;
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
=======
        public IRepository<Curso> CursoRepository
        {
            get
            {
                if (this._cursoRepository == null)
                {
                    this._cursoRepository = new CursoRepository(); 
                }
                return _cursoRepository;
            }
        }

>>>>>>> BECOMM

    }
}
