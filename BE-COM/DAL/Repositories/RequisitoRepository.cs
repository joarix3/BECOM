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
    public class RequisitoRepository : IRepository<Requisito>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public RequisitoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Requisito entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Requisito entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Requisito entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<Requisito> GetAll()
        {
            List<Requisito> prequisito = null;
            var sqlQuery = "SELECT IdRequisito, Nombre, Descripcion FROM TbRequisito";
            SqlCommand cmd = new SqlCommand(sqlQuery);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                prequisito = new List<Requisito>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    prequisito.Add(new Requisito
                    {
                        Id = Convert.ToInt32(dr["IdRequisito"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString()
                    });
                }
            }

            return prequisito;
        }
        
        public IEnumerable<Requisito> GetAllByName(string pnombre)
        {
            List<Requisito> prequisito = null;
            var sqlQuery = "SELECT IdRequisito, Nombre, Descripcion FROM TbRequisito";
            SqlCommand cmd = new SqlCommand(sqlQuery);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                prequisito = new List<Requisito>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    prequisito.Add(new Requisito
                    {
                        Id = Convert.ToInt32(dr["IdRequisito"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString()
                    });
                }
            }

            return prequisito;
        }

        public Requisito GetById(int id)
        {
            Requisito objRequisito = null;
            var sqlQuery = "SELECT IdRequisito, Nombre, Descripcion FROM TbRequisito WHERE id = @idRequisito";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idRequisito", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objRequisito = new Requisito
                {
                    Id = Convert.ToInt32(dr["IdRequisito"]),
                    Nombre = dr["Nombre"].ToString(),
                    Descripcion = dr["Descripcion"].ToString()
                };
            }

            return objRequisito;
        }

        public IEnumerable<Requisito> GetByEstado() //Se trae los beneficios que no estan borrados
        {
            List<Requisito> prequisito = null;
            var sqlQuery = "SELECT IdRequisito, Nombre, Descripcion FROM TbRequisito"; //Aqui va la condición si está borrada osea where estado = 1
            SqlCommand cmd = new SqlCommand(sqlQuery);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                prequisito = new List<Requisito>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    prequisito.Add(new Requisito
                    {
                        Id = Convert.ToInt32(dr["Id"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString()
                    });
                }
            }
            return prequisito;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {

                    if (_insertItems.Count > 0)
                    {
                        foreach (Requisito objRequisito in _insertItems)
                        {
                            InsertRequisito(objRequisito);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Requisito m in _updateItems)
                        {
                            UpdateRequisito(m);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Requisito m in _deleteItems)
                        {
                            DeleteRequisito(m);
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

        private void InsertRequisito(Requisito objRequisito)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nombre", objRequisito.Nombre));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objRequisito.Descripcion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaInsertarRequisito");

            }
            catch (Exception ex)
            {
            }

        }

        private void UpdateRequisito(Requisito objRequisito)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nombre", objRequisito.Nombre));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objRequisito.Descripcion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaModificarRequisito");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteRequisito(Requisito objRequisito)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@", objRequisito.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaEliminarRequisito");

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

        Requisito IRepository<Requisito>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
