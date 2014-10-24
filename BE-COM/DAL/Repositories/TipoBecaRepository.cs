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
    public class TipoBecaRepository : IRepository<TipoBeca>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public TipoBecaRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(TipoBeca entity)
        {
        }

        public void Delete(TipoBeca entity)
        {
        }

        public void Update(TipoBeca entity)
        {
        }


        public TipoBeca GetById(int id)
        {
            TipoBeca tipoBeca = null;
            return tipoBeca;
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

        public IEnumerable<TipoBeca> GetAll()
        {
            List<TipoBeca> pTipoBeca = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pTipoBeca = new List<TipoBeca>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pTipoBeca.Add(new TipoBeca
                    {
                        Id = Convert.ToInt32(dr["IdTipoBeca"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Estado = dr["Estado"].ToString(),
                        IdPeriodo = Convert.ToInt32(dr["IdTipoBeca"]),
                    });
                }
            }

            return pTipoBeca;
        }

        private void InsertTipoBeca(TipoBeca objTipoBeca)
        {

            try
            {

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateTipoBeca(TipoBeca objTipoBeca)
        {
            try
            {
            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteTipoBeca(TipoBeca objTipoBeca)
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

    }
}
