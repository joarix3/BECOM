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
    public class CursoRepository: IRepository<Curso>
    {
     private List<IEntity> _insertItems;
     private List<IEntity> _deleteItems;
     private List<IEntity> _updateItems;

        public CursoRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Curso entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Curso entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Curso entity)
        {
            _updateItems.Add(entity);
        }


       

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Curso objCurso in _insertItems)
                        {
                            InsertCurso(objCurso);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Curso objCurso in _updateItems)
                        {
                            UpdateCurso(objCurso);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Curso p in _deleteItems)
                        {
                            DeleteCurso(p);
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
        public IEnumerable<Curso> GetAllByName(String pnombre)
        {
            List<Curso> pcurso = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Nombre", pnombre);
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaBuscarCarreraPorNombre");


            if (ds.Tables[0].Rows.Count > 0)
            {
                pcurso = new List<Curso>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pcurso.Add(new Curso
                    {
                        Id = Convert.ToInt32(dr["IdCurso"]),
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Creditos = Convert.ToInt32(dr["Creditos"]),
                        Costo = Convert.ToInt32(dr["Costo"]),
                        Estado = Convert.ToInt32(dr["Estado"])
                    });
                }
            }

            return pcurso;
        }
        public IEnumerable<Curso> GetAll()
        {
            List<Curso> objCurso = null;

            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerCursos");



            if (ds.Tables[0].Rows.Count > 0)
            {
                objCurso = new List<Curso>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objCurso.Add(new Curso
                    {
                        Id = Convert.ToInt32(dr["IdCurso"]),
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Creditos = Convert.ToInt32(dr["Creditos"]),
                        Costo = Convert.ToInt32(dr["Costo"]),
                        Estado = Convert.ToInt32(dr["Estado"])
                    });
                }
            }

            return objCurso;
        }

        public Curso GetById(int pid) 
        {
            Curso objCurso = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdCurso", pid);
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaBuscarCursoPorId");

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objCurso = new Curso
                {
                    Id = Convert.ToInt32(dr["IdCurso"]),
                    Codigo = dr["Codigo"].ToString(),
                    Nombre = dr["Nombre"].ToString(),
                    Creditos = Convert.ToInt32(dr["Creditos"]),
                    Costo = Convert.ToInt32(dr["Costo"]),
                    Estado = Convert.ToInt32(dr["Estado"])
                };
            }

            return objCurso;
        }


        private void InsertCurso(Curso objCurso)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Codigo", objCurso.Codigo));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objCurso.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Creditos", objCurso.Creditos));
                cmd.Parameters.Add(new SqlParameter("@Costo", objCurso.Costo));
                cmd.Parameters.Add(new SqlParameter("@Estado", objCurso.Estado));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaRegistrarCursos");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateCurso(Curso objCurso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@IdCurso", objCurso.Id));
                cmd.Parameters.Add(new SqlParameter("@Codigo", objCurso.Codigo));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objCurso.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Creditos", objCurso.Creditos));
                cmd.Parameters.Add(new SqlParameter("@Costo", objCurso.Costo));
                cmd.Parameters.Add(new SqlParameter("@Estado", objCurso.Estado));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaModificarCurso");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteCurso(Curso objCurso)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@IdCurso", objCurso.Id));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaEliminarCurso");
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
