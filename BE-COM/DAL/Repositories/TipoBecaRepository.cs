using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntitiesLayer;
using System.Collections;
using System.Transactions;
using System.Data.SqlClient;
using System.Data;
using DAL.Repositories;
//using TIL.CustomExceptions;


namespace DAL
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
            _insertItems.Add(entity);
        }

        public void Delete(TipoBeca entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(TipoBeca entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<TipoBeca> GetAll()
        {


            List<TipoBeca> phueso = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_listar_huesos");



            if (ds.Tables[0].Rows.Count > 0)
            {
                phueso = new List<TipoBeca>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    phueso.Add(new TipoBeca
                    {
                        Id = Convert.ToInt32(dr["IdTipoBeca"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Estado = dr["Estado"].ToString()
                    });
                }
            }

            return phueso;
        }

        public IEnumerable<TipoBeca> GetAllByName(string ptipobeca)
        {


            List<TipoBeca> phueso = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_listar_huesos");



            if (ds.Tables[0].Rows.Count > 0)
            {
                phueso = new List<TipoBeca>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    phueso.Add(new TipoBeca
                    {
                        Id = Convert.ToInt32(dr["IdTipoBeca"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                        Estado = dr["Estado"].ToString()
                    });
                }
            }

            return phueso;
        }

        public TipoBeca GetById(int id)
        {
            TipoBeca objHueso = null;
            ////var sqlQuery = "SELECT Id, Nombre, Precio FROM Producto WHERE id = @idProducto";
            ////SqlCommand cmd = new SqlCommand(sqlQuery);
            ////cmd.Parameters.AddWithValue("@idProducto", id);

            ////var ds = DBAccess.ExecuteQuery(cmd);

            ////if (ds.Tables[0].Rows.Count > 0)
            ////{
            ////    var dr = ds.Tables[0].Rows[0];

            ////    objTipoBeca = new TipoBeca
            ////    {
            ////        Id = Convert.ToInt32(dr["Id"]),
            ////        Nombre = dr["Nombre"].ToString(),
            ////        Descripcion = dr["Descripcion"].ToString(),
            ////        Estado = dr["Estado"].ToString()
            ////    };
            ////}
            return objHueso;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (TipoBeca objTipoBeca in _insertItems)
                        {
                            InsertTipoBeca(objTipoBeca);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (TipoBeca p in _updateItems)
                        {
                            UpdateHueso(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (TipoBeca p in _deleteItems)
                        {
                            DeleteHueso(p);
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

        private void InsertTipoBeca(TipoBeca objTipoBeca)

        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nombre", objTipoBeca.Nombre));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objTipoBeca.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@idPeriodo", objTipoBeca.IdPeriodo));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaAgregearTipoBeca");

            }
            catch (Exception ex)

            {

            }

        }

        private void UpdateHueso(TipoBeca objTipoBeca)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand();

            //    cmd.Parameters.Add(new SqlParameter("@nomb", objHueso.Nombre));
            //    cmd.Parameters.Add(new SqlParameter("@tipo", objHueso.Tipo));
            //    cmd.Parameters.Add(new SqlParameter("@ubicacion", objHueso.Ubicacion));


            //    DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_modificar_hueso");

            //}
            //catch (Exception ex)
            //{
            //    throw new DataAccessException("No se pudó modificar el hueso", ex);
            //}
        }

        private void DeleteHueso(TipoBeca objTipoBeca)
        {
            //try
            //{
            //    SqlCommand cmd = new SqlCommand();
            //    cmd.Parameters.Add(new SqlParameter("@", objHueso.Id));
            //    DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_borrar_hueso");

            //}
            //catch (SqlException ex)
            //{
            //    //logear la excepcion a la bd con un Exception
            //    throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);

            //}
            //catch (Exception ex)
            //{
            //    //logear la excepcion a la bd con un Exception
            //    throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);
            //}
        }

        public IEnumerable<TipoBeca> GetAllInactive()
        {
            List<TipoBeca> pRol = null;
            return pRol;
        }

    }
}
