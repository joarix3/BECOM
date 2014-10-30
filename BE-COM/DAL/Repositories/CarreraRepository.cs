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
    public class CarreraRepository : IRepository<Carrera>, IUser<Carrera>
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
            _deleteItems.Add(entity);
        }

        public void Update(Carrera entity)
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
        public IEnumerable<Carrera> GetAllByName(String pnombre)
        {
            List<Carrera> pcarrera = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@Nombre", pnombre));
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaBuscarCarreraPorNombre");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pcarrera = new List<Carrera>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pcarrera.Add(new Carrera
                    {
                        Id = Convert.ToInt32(dr["IdCarrera"]),
                        Codigo = dr["Codigo"].ToString(),
                        Nombre = dr["Nombre"].ToString(),
                        Universidad = Convert.ToInt32(dr["IdUniversidad"]),
                        Color = dr["Color"].ToString(),
                        BecasOtor = Convert.ToInt32(dr["CantidadBecasOtorgables"]),
                        Estado = Convert.ToInt32(dr["Estado"])
                    });
                }
            }

            return pcarrera;
        }

        public IEnumerable<Curso> GetAllCursosByUnCarrera(int pidCarrera)
        {
            List<Curso> pcursos = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@IdCarrera", pidCarrera));
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerCursosUnSeleccionados");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pcursos = new List<Curso>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pcursos.Add(new Curso
                    {
                        Id = Convert.ToInt32(dr["IdCurso"]),
                        Nombre = dr["Nombre"].ToString(),
                    });
                }
            }

            return pcursos;
        }

        public IEnumerable<Curso> GetAllCursosByCarrera(int pidCarrera)
        {
            List<Curso> pcursos = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@IdCarrera", pidCarrera));
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerCursosPorCarrera");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pcursos = new List<Curso>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pcursos.Add(new Curso
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

            return pcursos;
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
                        BecasOtor = Convert.ToInt32(dr["CantidadBecasOtorgables"]),
                        Estado = Convert.ToInt32(dr["Estado"])
                    });
                }
            }

            return objCarrera;
        }

       
        public Carrera GetById(int pid) 
        {
            Carrera objCarrera = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@IdCarrera", pid);

            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaBuscarCarreraPorId");

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objCarrera = new Carrera
                {
                    Id = Convert.ToInt32(dr["IdCarrera"]),
                    Codigo = dr["Codigo"].ToString(),
                    Nombre = dr["Nombre"].ToString(),
                    Universidad = Convert.ToInt32(dr["IdUniversidad"]),
                    Color = dr["Color"].ToString(),
                    BecasOtor = Convert.ToInt32(dr["CantidadBecasOtorgables"]),
                    Estado = Convert.ToInt32(dr["Estado"])
                };
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
                cmd.Parameters.Add(new SqlParameter("@Estado", objCarrera.Estado));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaRegistrarCarrera");

            }
            catch (Exception ex)
            {

            }

        }

        public void AsociarCursosCarrera(int pidCarrera, int pidCurso)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@IdCarrera", pidCarrera));
                cmd.Parameters.Add(new SqlParameter("@IdCurso", pidCurso));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaAsociarCursosCarrera");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateCarrera(Carrera objCarrera)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@IdCarrera", objCarrera.Id));
                cmd.Parameters.Add(new SqlParameter("@Codigo", objCarrera.Codigo));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objCarrera.Nombre));
                cmd.Parameters.Add(new SqlParameter("@IdUniversidad", objCarrera.Universidad));
                cmd.Parameters.Add(new SqlParameter("@Color", objCarrera.Color));
                cmd.Parameters.Add(new SqlParameter("@CantidadBecas", objCarrera.BecasOtor));
                cmd.Parameters.Add(new SqlParameter("@Estado", objCarrera.Estado));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaModificarCarrera");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteCarrera(Carrera objCarrera)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@IdCarrera", objCarrera.Id));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaEliminarCarrera");
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
