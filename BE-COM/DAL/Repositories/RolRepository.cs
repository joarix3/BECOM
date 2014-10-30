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
using System.Data.Sql;
using System.Windows.Forms;

namespace DAL.Repositories
{
    public class RolRepository : IRepository<Rol> , IUsers
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public RolRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Rol entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Rol entity)
        {
        }

        public void Update(Rol entity)
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
                        foreach (Rol objRol in _insertItems)
                        {
                            InsertRolWithPrivileges(objRol);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Rol objRol in _updateItems)
                        {
                            UpdateRol(objRol);
                        }
                    }
                    scope.Complete();
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

        public Rol GetById(int pidRol)
        {
            Rol pRol = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@IdRol", pidRol));
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaBuscarRolPorId");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pRol = new Rol();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pRol.Id = Convert.ToInt32(dr["IdRol"]);
                    pRol.Nombre = dr["Nombre"].ToString();
                    pRol.Descripcion = dr["Descripcion"].ToString();
                    pRol.Estado = Convert.ToInt32(dr["Estado"]);
                }
            }

            return pRol;
        }

        public IEnumerable<Rol> GetAll()
        {
            List<Rol> pRol = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerRoles");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pRol = new List<Rol>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pRol.Add(new Rol
                    {
                        Id = Convert.ToInt32(dr["IdRol"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                    });
                }
            }

            return pRol;
        }

        public IEnumerable<Rol> GetAllInactive()
        {
            List<Rol> objRol = null;

            //SqlCommand cmd = new SqlCommand();
            //DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerRolsInactivos");



            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    objRol = new List<Rol>();
            //    foreach (DataRow dr in ds.Tables[0].Rows)
            //    {
            //        objRol.Add(new Rol
            //        {
            //            Id = Convert.ToInt32(dr["IdRol"]),
            //            Nombre = dr["Nombre"].ToString(),
            //            Dia = Convert.ToInt32(dr["Dia"]),
            //            Mes = Convert.ToInt32(dr["Mes"]),
            //            Estado = dr["Estado"].ToString()
            //        });
            //    }
            //}

            return objRol;
        }

        public IEnumerable<Rol> GetAllByName(String pnombre)
        {
            List<Rol> pRol = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@Nombre", pnombre));
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaBuscarRolPorNombre");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pRol = new List<Rol>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pRol.Add(new Rol
                    {
                        Id = Convert.ToInt32(dr["IdRol"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                    });
                }
            }

            return pRol;
        }

        public IEnumerable<Rol> GetAllInactive()
        {
            List<Rol> pRol = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerRolesInactivos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pRol = new List<Rol>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pRol.Add(new Rol
                    {
                        Id = Convert.ToInt32(dr["IdRol"]),
                        Nombre = dr["Nombre"].ToString(),
                        Descripcion = dr["Descripcion"].ToString(),
                    });
                }
            }

            return pRol;
        }

        private void InsertRol(Rol objRol)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objRol.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", objRol.Descripcion));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaRegistrarRol");
            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateRol(Rol objRol)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@IdRol", objRol.Id));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objRol.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", objRol.Descripcion));
                cmd.Parameters.Add(new SqlParameter("@Estado", objRol.Estado));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaModificarRol");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteRol(Rol objRol)
        {
            try
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.Parameters.Add(new SqlParameter("@IdRol", objRol.Id));

                    DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaEliminarRol");

                }
                catch (Exception ex)
                {

                }
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

        public int InsertRolWithPrivileges(Rol objRol)
        {
            int idRol = 0;

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Nombre", objRol.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", objRol.Descripcion));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaRegistrarRol");

                IDataReader lectorId = ds.CreateDataReader();
                lectorId.Read();
                idRol = Convert.ToInt32(lectorId.GetValue(0));


            }
            catch (Exception ex)
            {

            }
            return idRol;
        }
        
        public void SetPrivileges(int pidRol, int pidPermiso)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@IdRol", pidRol));
                cmd.Parameters.Add(new SqlParameter("@IdPermiso", pidPermiso));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaAsignarPermisosARol");

            }
            catch (Exception ex)
            {

            }
    }

        public void UpdatePrivileges(int pidRol, int pidPermiso)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@IdRol", pidRol));
                cmd.Parameters.Add(new SqlParameter("@IdPermiso", pidPermiso));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaModificarPermisosARol");

            }
            catch (Exception ex)
            {

            }
        }

        public IEnumerable<Permiso> getPrivilegesByRol(int pidRol)
        {
            List<Permiso> pPermiso = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@IdRol", pidRol));
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaBuscarPermisosPorRol");

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

        public void ClearPrivileges(int pidRol)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@IdRol", pidRol));
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaClearTbPermisos");
        }

        public IEnumerable<Usuario> getUsersByRol(int idRol)
        {
            List<Usuario> pUsuario = null;
            return pUsuario;
        }

        public IEnumerable<Usuario> getUsersByIdentifier(string idRol)
        {
            List<Usuario> pUsuario = null;
            return pUsuario;
        }

    }
}