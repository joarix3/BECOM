<<<<<<< HEAD
﻿using System;
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
    public class BeneficioRepository : IRepository<Beneficio>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public BeneficioRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(Beneficio entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(Beneficio entity)
        {
            _deleteItems.Add(entity);
        }

        public void Update(Beneficio entity)
        {
            _updateItems.Add(entity);
        }

        public IEnumerable<Beneficio> GetAll()
        {
            List<Beneficio> pbeneficio = null;
            var sqlQuery = "SELECT IdBeneficio, Nombre, Porcentaje FROM TbBeneficio";
            SqlCommand cmd = new SqlCommand(sqlQuery);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                pbeneficio = new List<Beneficio>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    pbeneficio.Add(new Beneficio
                    {
                        Id = Convert.ToInt32(dr["IdBeneficio"]),
                        Nombre = dr["Nombre"].ToString(),
                        Porcentaje = Convert.ToDouble(dr["Porcentaje"])
                    });
                }
            }
            
            return pbeneficio;
        }

        public Beneficio GetById(int id)
        {
            Beneficio objBeneficio = null;
            var sqlQuery = "SELECT IdBeneficio, Nombre, porcentaje, descripcion FROM TbBeneficio WHERE id = @idBeneficio";
            SqlCommand cmd = new SqlCommand(sqlQuery);
            cmd.Parameters.AddWithValue("@idBeneficio", id);

            var ds = DBAccess.ExecuteQuery(cmd);

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objBeneficio = new Beneficio
                {
                    Id = Convert.ToInt32(dr["Id"]),
                    Nombre = dr["Nombre"].ToString(),
                    Porcentaje = Convert.ToInt32(dr["Porcentaje"]),
                    Descripcion = dr["Descripcion"].ToString()
                };
            }

            return objBeneficio;
        }

        public void Save()
        {
            using (TransactionScope scope = new TransactionScope())
            {
                try
                {
                    if (_insertItems.Count > 0)
                    {
                        foreach (Beneficio objBeneficio in _insertItems)
                        {
                            InsertBeneficio(objBeneficio);
                        }
                    }

                    if (_updateItems.Count > 0)
                    {
                        foreach (Beneficio m in _updateItems)
                        {
                            UpdateBeneficio(m);
                        }
                    }

                    if (_deleteItems.Count > 0)
                    {
                        foreach (Beneficio m in _deleteItems)
                        {
                            DeleteBeneficio(m);
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

        private void InsertBeneficio(Beneficio objBeneficio)
        {

            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nomb", objBeneficio.Nombre));
                cmd.Parameters.Add(new SqlParameter("@porcentaje", objBeneficio.Porcentaje));
                cmd.Parameters.Add(new SqlParameter("@descripcion", objBeneficio.Descripcion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_agregar_beneficio");

            }
            catch (Exception ex)
            {

            }

        }

        private void UpdateBeneficio(Beneficio objBeneficio)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Parameters.Add(new SqlParameter("@nomb", objBeneficio.Nombre));
                cmd.Parameters.Add(new SqlParameter("@ubicacion", objBeneficio.Porcentaje));
                cmd.Parameters.Add(new SqlParameter("@origen", objBeneficio.Descripcion));

                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_modificar_beneficio");

            }
            catch (Exception ex)
            {

            }
        }

        private void DeleteBeneficio(Beneficio objBeneficio)
        {
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Parameters.Add(new SqlParameter("@", objBeneficio.Id));
                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_borrar_beneficio");

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

        Beneficio IRepository<Beneficio>.GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
=======
﻿//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using EntitiesLayer;
//using System.Collections;
//using System.Transactions;
//using System.Data.SqlClient;
//using System.Data;

//namespace DAL.Repositories
//{
//    public class BeneficioRepository : IRepository<Beneficio>
//    {
//        private List<IEntity> _insertItems;
//        private List<IEntity> _deleteItems;
//        private List<IEntity> _updateItems;

//        public BeneficioRepository()
//        {
//            _insertItems = new List<IEntity>();
//            _deleteItems = new List<IEntity>();
//            _updateItems = new List<IEntity>();
//        }

//        public void Insert(Beneficio entity)
//        {
//            _insertItems.Add(entity);
//        }

//        public void Delete(Beneficio entity)
//        {
//            _deleteItems.Add(entity);
//        }

//        public void Update(Beneficio entity)
//        {
//            _updateItems.Add(entity);
//        }

//        public IEnumerable<Beneficio> GetAll()
//        {
//            List<Beneficio> pbeneficio = null;
//            var sqlQuery = "SELECT Id, Nombre, porcentaje, descripcion FROM TbBeneficio";
//            SqlCommand cmd = new SqlCommand(sqlQuery);

//            var ds = DBAccess.ExecuteQuery(cmd);

//            if (ds.Tables[0].Rows.Count > 0)
//            {
//                pbeneficio = new List<Beneficio>();
//                foreach (DataRow dr in ds.Tables[0].Rows)
//                {
//                    pbeneficio.Add(new Beneficio
//                    {
//                        Id = Convert.ToInt32(dr["Id"]),
//                        Nombre = dr["Nombre"].ToString(),
//                        Porcentaje = Convert.ToInt32(dr["Porcentaje"]),
//                        Descripcion = dr["Descripcion"].ToString()
//                    });
//                }
//            }

//            return pbeneficio;
//        }

//        public Beneficio GetById(int id)
//        {
//            Beneficio objBeneficio = null;
//            var sqlQuery = "SELECT IdBeneficio, Nombre, porcentaje, descripcion FROM TbBeneficio WHERE id = @idBeneficio";
//            SqlCommand cmd = new SqlCommand(sqlQuery);
//            cmd.Parameters.AddWithValue("@idBeneficio", id);

//            var ds = DBAccess.ExecuteQuery(cmd);

//            if (ds.Tables[0].Rows.Count > 0)
//            {
//                var dr = ds.Tables[0].Rows[0];

//                objBeneficio = new Beneficio
//                {
//                    Id = Convert.ToInt32(dr["Id"]),
//                    Nombre = dr["Nombre"].ToString(),
//                    Porcentaje = Convert.ToInt32(dr["Porcentaje"]),
//                    Descripcion = dr["Descripcion"].ToString()
//                };
//            }

//            return objBeneficio;
//        }

//        public void Save()
//        {
//            using (TransactionScope scope = new TransactionScope())
//            {
//                try
//                {
//                    if (_insertItems.Count > 0)
//                    {
//                        foreach (Beneficio objBeneficio in _insertItems)
//                        {
//                            InsertBeneficio(objBeneficio);
//                        }
//                    }

//                    if (_updateItems.Count > 0)
//                    {
//                        foreach (Beneficio m in _updateItems)
//                        {
//                            UpdateBeneficio(m);
//                        }
//                    }

//                    if (_deleteItems.Count > 0)
//                    {
//                        foreach (Beneficio m in _deleteItems)
//                        {
//                            DeleteBeneficio(m);
//                        }
//                    }

//                    scope.Complete();
//                }
//                catch (TransactionAbortedException ex)
//                {

//                }
//                catch (ApplicationException ex)
//                {

//                }
//                finally
//                {
//                    Clear();
//                }

//            }
//        }

//        public void Clear()
//        {
//            _insertItems.Clear();
//            _deleteItems.Clear();
//            _updateItems.Clear();
//        }

//        private void InsertBeneficio(Beneficio objBeneficio)
//        {

//            try
//            {
//                SqlCommand cmd = new SqlCommand();

//                cmd.Parameters.Add(new SqlParameter("@nomb", objBeneficio.Nombre));
//                cmd.Parameters.Add(new SqlParameter("@porcentaje", objBeneficio.Porcentaje));
//                cmd.Parameters.Add(new SqlParameter("@descripcion", objBeneficio.Descripcion));

//                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_agregar_beneficio");

//            }
//            catch (Exception ex)
//            {

//            }

//        }

//        private void UpdateBeneficio(Beneficio objBeneficio)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand();

//                cmd.Parameters.Add(new SqlParameter("@nomb", objBeneficio.Nombre));
//                cmd.Parameters.Add(new SqlParameter("@ubicacion", objBeneficio.Porcentaje));
//                cmd.Parameters.Add(new SqlParameter("@origen", objBeneficio.Descripcion));

//                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_modificar_beneficio");

//            }
//            catch (Exception ex)
//            {

//            }
//        }

//        private void DeleteBeneficio(Beneficio objBeneficio)
//        {
//            try
//            {
//                SqlCommand cmd = new SqlCommand();
//                cmd.Parameters.Add(new SqlParameter("@", objBeneficio.Id));
//                DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "pa_borrar_beneficio");

//            }
//            catch (SqlException ex)
//            {
//                //logear la excepcion a la bd con un Exception
//                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);

//            }
//            catch (Exception ex)
//            {
//                //logear la excepcion a la bd con un Exception
//                //throw new DataAccessException("Ha ocurrido un error al eliminar un usuario", ex);
//            }
//        }

//        Beneficio IRepository<Beneficio>.GetById(int id)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
>>>>>>> BECOMJ
