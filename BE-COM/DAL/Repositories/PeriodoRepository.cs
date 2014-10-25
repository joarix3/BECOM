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
    public class PeriodoRepository : IRepository<Periodo>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public PeriodoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Periodo entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Periodo entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Periodo entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<Periodo> GetAll()
        {
            List<Periodo> objPeriodo = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerPeriodos");



            if (ds.Tables[0].Rows.Count > 0)
            {
                objPeriodo = new List<Periodo>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objPeriodo.Add(new Periodo
                    {
                        Id = Convert.ToInt32(dr["IdPeriodo"]),
                        Nombre = dr["Nombre"].ToString(),
                        Dia = Convert.ToInt32(dr["Dia"]),
                        Mes = Convert.ToInt32(dr["Mes"])
                    });
                }
            }

            return objPeriodo;
        }

        public Periodo GetById(int id)
        {
            Periodo objPeriodo = null;
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
            return objPeriodo;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Periodo objPeriodo in _insertItems)
                        {
                            InsertTipoBeca(objPeriodo);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Periodo p in _updateItems)
                        {
                            UpdateHueso(p);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Periodo p in _deleteItems)
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

        private void InsertTipoBeca(Periodo objPeriodo)

        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objPeriodo.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Dia", objPeriodo.Dia));
                cmd.Parameters.Add(new SqlParameter("@Mes", objPeriodo.Mes));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaAgregarPeriodo");

            }
            catch (Exception ex)

            {

            }

        }

        private void UpdateHueso(Periodo objTipoBeca)
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

        private void DeleteHueso(Periodo objTipoBeca)
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

    }
}
