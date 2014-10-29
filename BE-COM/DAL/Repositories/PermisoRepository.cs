using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;

namespace DAL.Repositories
{
    public class PermisoRepository : IRepository<Permiso>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public PermisoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Permiso entity)
        {
        }

        public void Delete(Permiso entity)
        {
        }

        public void Update(Permiso entity)
        {
        }


        public Permiso GetById(int id)
        {
            Permiso permiso = null;
            return permiso;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
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

        public IEnumerable<Permiso> GetAll()
        {
            List<Permiso> pPermiso = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerPermisos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pPermiso = new List<Permiso>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pPermiso.Add(new Permiso
                    {
                        Id = Convert.ToInt32(dr["IdPermiso"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                    });
                }
            }

            return pPermiso;
        }

        public IEnumerable<Permiso> GetAllByName(String pnombre)
        {
            List<Permiso> pPermiso = null;
            return pPermiso;
        }

        private void InsertPermiso(Permiso objPermiso)
        {

            try
            {

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdatePermiso(Permiso objPermiso)
        {
            try
            {
            }
            catch (Exception ex)
            {

            }
        }

        private void DeletePermiso(Permiso objPermiso)
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

        public IEnumerable<Permiso> GetAllInactive()
        {
            List<Permiso> pRol = null;
            return pRol;
        }

    }
}