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
    public class UsuarioRepository : IRepository<Usuario>
    {

        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public UsuarioRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Usuario entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Usuario entity)
        {
        }

        public void Update(Usuario entity)
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
                        foreach (Usuario objUsuario in _insertItems)
                        {
                            InsertUsuario(objUsuario);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Usuario objUsuario in _updateItems)
                        {
                            UpdateUsuario(objUsuario);
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

        public Usuario GetById(int pidUsuario)
        {
            Usuario pUsuario = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@IdUsuario", pidUsuario));
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaBuscarUsuarioPorId");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pUsuario = new Usuario();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pUsuario.Id = Convert.ToInt32(dr["IdUsuario"]);
                    pUsuario.Nombre = dr["Nombre"].ToString();

                }
            }

            return pUsuario;
        }

        public IEnumerable<Usuario> GetAll()
        {
            List<Usuario> pUsuario = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerUsuarios");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pUsuario = new List<Usuario>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pUsuario.Add(new Usuario
                    {
                        Id = Convert.ToInt32(dr["IdUsuario"]),
                        NumeroCedula = Convert.ToInt32(dr["Cedula"]),
                        Nombre = dr["NombreCompleto"].ToString(),
                        NumeroTelefono = Convert.ToInt32(dr["Telefono"]),
                        Direccion = dr["Direccion"].ToString(),
                        CorreoElectronico = dr["CorreoElectronico"].ToString(),
                        Contrasena = dr["Nombre"].ToString(),
                    });
                }
            }

            return pUsuario;
        }

        public IEnumerable<Usuario> GetAllByName(String pnombre)
        {
            List<Usuario> pUsuario = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@Nombre", pnombre));

            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaBuscarUsuarioPorNombre");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pUsuario = new List<Usuario>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pUsuario.Add(new Usuario
                    {
                        Id = Convert.ToInt32(dr["IdUsuario"]),
                        NumeroCedula = Convert.ToInt32(dr["Cedula"]),
                        Nombre = dr["NombreCompleto"].ToString(),
                        NumeroTelefono = Convert.ToInt32(dr["Telefono"]),
                        Direccion = dr["Direccion"].ToString(),
                        CorreoElectronico = dr["CorreoElectronico"].ToString(),
                        Contrasena = dr["Nombre"].ToString(),
                    });
                }
            }

            return pUsuario;
        }

        public IEnumerable<Usuario> GetAllByIdentifier(String pcedula)
        {
            List<Usuario> pUsuario = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@Cedula", pcedula));

            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaBuscarUsuarioPorCedula");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pUsuario = new List<Usuario>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pUsuario.Add(new Usuario
                    {
                        Id = Convert.ToInt32(dr["IdUsuario"]),
                        NumeroCedula = Convert.ToInt32(dr["Cedula"]),
                        Nombre = dr["NombreCompleto"].ToString(),
                        NumeroTelefono = Convert.ToInt32(dr["Telefono"]),
                        Direccion = dr["Direccion"].ToString(),
                        CorreoElectronico = dr["CorreoElectronico"].ToString(),
                        Contrasena = dr["Nombre"].ToString(),
                    });
                }
            }

            return pUsuario;
        }

        public IEnumerable<Usuario> GetAllInactive()
        {
            List<Usuario> pUsuario = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerUsuariosInactivos");

            if (ds.Tables[0].Rows.Count > 0)
            {
                pUsuario = new List<Usuario>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pUsuario.Add(new Usuario
                    {
                        Id = Convert.ToInt32(dr["IdUsuario"]),
                        NumeroCedula = Convert.ToInt32(dr["Cedula"]),
                        Nombre = dr["NombreCompleto"].ToString(),
                        NumeroTelefono = Convert.ToInt32(dr["Telefono"]),
                        Direccion = dr["Direccion"].ToString(),
                        CorreoElectronico = dr["CorreoElectronico"].ToString(),
                        Contrasena = dr["Nombre"].ToString(),
                    });
                }
            }

            return pUsuario;
        }

        public IEnumerable<Usuario> GetUsersByRol(int pidRol)
        {
            List<Usuario> pUsuario = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.Add(new SqlParameter("@IdRol", pidRol));
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaBuscarUsuariosPorRol");
            if (ds.Tables[0].Rows.Count > 0)
            {
                pUsuario = new List<Usuario>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pUsuario.Add(new Usuario
                    {
                        Id = Convert.ToInt32(dr["IdUsuario"]),
                        NumeroCedula = Convert.ToInt32(dr["Cedula"]),
                        Nombre = dr["NombreCompleto"].ToString(),
                        NumeroTelefono = Convert.ToInt32(dr["Telefono"]),
                        Direccion = dr["Direccion"].ToString(),
                        CorreoElectronico = dr["CorreoElectronico"].ToString(),
                        Contrasena = dr["Nombre"].ToString(),
                    });
                }
            }

            return pUsuario;
        }

        private void InsertUsuario(Usuario objUsuario)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@Cedula", objUsuario.NumeroCedula));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objUsuario.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Apellido1", objUsuario.PrimerApellido));
                cmd.Parameters.Add(new SqlParameter("@Apellido2", objUsuario.SegundoApellido));
                cmd.Parameters.Add(new SqlParameter("@Telefono", objUsuario.NumeroTelefono));
                cmd.Parameters.Add(new SqlParameter("@Direccion", objUsuario.Direccion));
                cmd.Parameters.Add(new SqlParameter("@IdRol", objUsuario.IdRol));
                cmd.Parameters.Add(new SqlParameter("@FechaNacimiento", objUsuario.FechaNacimiento));
                cmd.Parameters.Add(new SqlParameter("@Genero", objUsuario.Genero));
                cmd.Parameters.Add(new SqlParameter("@CorreoElectronico", objUsuario.CorreoElectronico));
                cmd.Parameters.Add(new SqlParameter("@Contrasenna", objUsuario.Contrasena));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaRegistrarUsuario");
            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateUsuario(Usuario objUsuario)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@IdUsuario", objUsuario.Id));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objUsuario.Nombre));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaModificarUsuario");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteUsuario(Usuario objUsuario)
        {
            try
            {
                try
                {
                    SqlCommand cmd = new SqlCommand();

                    cmd.Parameters.Add(new SqlParameter("@IdUsuario", objUsuario.Id));

                    DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaEliminarUsuario");

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
        
   }
}