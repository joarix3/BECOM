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
    public class BitacoraTransaccionRepository : IRepository<BitacoraTransaccion>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public BitacoraTransaccionRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(BitacoraTransaccion entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(BitacoraTransaccion entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(BitacoraTransaccion entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<BitacoraTransaccion> GetAll()
        {
            List<BitacoraTransaccion> pbitacoraTransaccion = null;
            var sqlQuery = "SELECT IdUsuario, Fecha, Descripcion FROM TbBitacora";
            SqlCommand cmd = new SqlCommand(sqlQuery);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                pbitacoraTransaccion = new List<BitacoraTransaccion>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pbitacoraTransaccion.Add(new BitacoraTransaccion
                    {
                        Id = Convert.ToInt32(dr["IdUsuario"]),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        Transaccion = dr["Descripcion"].ToString()
                    });
                }
            }

            return pbitacoraTransaccion;
        }

        public IEnumerable<BitacoraTransaccion> GetAllByName(string nombre)
        {
            List<BitacoraTransaccion> pbitacora = null;
            return pbitacora;
        }

        public BitacoraTransaccion GetById(int id)
        {
            BitacoraTransaccion objBitacoraTransaccion = null;
            var sqlQuery = "SELECT IdUsuario, Fecha, Descripcion FROM TbBitacora WHERE id = @idBitacoraTransaccion";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@IdBitacora", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objBitacoraTransaccion = new BitacoraTransaccion
                {
                    Id = Convert.ToInt32(dr["IdUsuario"]),
                    Fecha = Convert.ToDateTime(dr["Fecha"]),
                    Transaccion = dr["Descripcion"].ToString()
                };
            }

            return objBitacoraTransaccion;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {

                    if (_insertItems.Count > 0)
                    {
                        foreach (BitacoraTransaccion objBitacoraTransaccion in _insertItems)
                        {
                            InsertBitacoraTransaccion(objBitacoraTransaccion);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (BitacoraTransaccion m in _updateItems)
                        {
                            UpdateBitacoraTransaccion(m);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (BitacoraTransaccion m in _deleteItems)
                        {
                            DeleteBitacoraTransaccion(m);
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

        private void InsertBitacoraTransaccion(BitacoraTransaccion objBitacoraTransaccion)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@idUsuario", objBitacoraTransaccion.Id));
                cmd.Parameters.Add(new SqlParameter("@Fecha", objBitacoraTransaccion.Fecha));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", objBitacoraTransaccion.Transaccion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaInsertarBitacora");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateBitacoraTransaccion(BitacoraTransaccion objBitacoraTransaccion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@idUsuario", objBitacoraTransaccion.Id));
                cmd.Parameters.Add(new SqlParameter("@Fecha", objBitacoraTransaccion.Fecha));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", objBitacoraTransaccion.Transaccion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaModificarBitacora");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteBitacoraTransaccion(BitacoraTransaccion objBitacoraTransaccion)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@", objBitacoraTransaccion.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaEliminarBitacora");
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

        BitacoraTransaccion IRepository<BitacoraTransaccion>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
