using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Repositories
{
    public class CarreraRepository : IRepository<Carrera>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public CarreraRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Carrera entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Carrera entity)
        {
        }

        public void Update(Carrera entity)
        {
        }


        public Carrera GetById(int id)
        {
            Carrera carrera = null;
            return carrera;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Carrera objCarrera in _insertItems)
                        {
                            InsertCarrera(objCarrera);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Carrera p in _updateItems)
                        {
                            UpdateCarrera(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Carrera p in _deleteItems)
                        {
                            DeleteCarrera(p);
                        }
                    }

                    scope.Complete();
                }
                catch (TransactionAbortedException ex)
                {

                }
                catch (ApplicationException ex)
                {

                }
                finally
                {
                    Clear();
                }

            }
        }

        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        public IEnumerable<Carrera> GetAll()
        {
            List<Carrera> objCarrera = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerCarreras");



            if (ds.Tables[0].Rows.Count > 0)
            {
                objCarrera = new List<Carrera>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objCarrera.Add(new Carrera
                    {
                        Id = Convert.ToInt32(dr["IdCarrera"]),
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Universidad = Convert.ToInt32(dr["IdUniversidad"]),
                        Color = dr["Color"].ToString(),
                        BecasOtor = Convert.ToInt32(dr["CantidadBecasOtorgables"])
                    });
                }
            }

            return objCarrera;
        }


        public IEnumerable<Carrera> GetAllByName(String pcarrera)
        {
            List<Carrera> objCarrera = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerCarreras");



            if (ds.Tables[0].Rows.Count > 0)
            {
                objCarrera = new List<Carrera>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objCarrera.Add(new Carrera
                    {
                        Id = Convert.ToInt32(dr["IdCarrera"]),
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Universidad = Convert.ToInt32(dr["IdUniversidad"]),
                        Color = dr["Color"].ToString(),
                        BecasOtor = Convert.ToInt32(dr["CantidadBecasOtorgables"])
                    });
                }
            }

            return objCarrera;
        }


        private void InsertCarrera(Carrera objCarrera)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Codigo", objCarrera.Codigo));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objCarrera.Nombre));
                cmd.Parameters.Add(new SqlParameter("@IdUniversidad", objCarrera.Universidad));
                cmd.Parameters.Add(new SqlParameter("@Color", objCarrera.Color));
                cmd.Parameters.Add(new SqlParameter("@CantidadBecas", objCarrera.BecasOtor));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaRegistrarCarrera");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateCarrera(Carrera objRol)
        {
            try
            {
            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteCarrera(Carrera objRol)
        {
            try
            {
            }
            catch (SqlException ex)
            {
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);

            }
            catch (Exception ex)
            {
                //logear la excepcion a la bd con un Exception
                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);
            }
        }

        public IEnumerable<Carrera> GetAllInactive()
        {
            List<Carrera> pRol = null;
            return pRol;
        }

    }
}
