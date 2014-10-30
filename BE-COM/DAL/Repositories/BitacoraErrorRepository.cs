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
   public class BitacoraErrorRepository : IRepository<BitacoraError>
    {
        private List<IEntity> _insertItems;
        private List<IEntity> _deleteItems;
        private List<IEntity> _updateItems;

        public BitacoraErrorRepository()
        {
            _insertItems = new List<IEntity>();
            _deleteItems = new List<IEntity>();
            _updateItems = new List<IEntity>();
        }

        public void Insert(BitacoraError entity)
        {
            _insertItems.Add(entity);
        }

        public void Delete(BitacoraError entity)
        {
        }

        public void Update(BitacoraError entity)
        {
        }


        public BitacoraError GetById(int id)
        {
            BitacoraError bitacoraError = null;
            return bitacoraError;
        }

         public IEnumerable<BitacoraError> GetAll()
        {
            List<BitacoraError> objBitacoraError = null;
            SqlCommand cmd = new SqlCommand();
            DataSet ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaObtenerBitacoraErrores");
            if (ds.Tables[0].Rows.Count > 0)
            {
                objBitacoraError = new List<BitacoraError>();
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    objBitacoraError.Add(new BitacoraError
                    {
                        Id = Convert.ToInt32(dr["IdBitacoraError"]),
                        IdUsuario = Convert.ToInt32(dr["IdUsuario"]),
                        Fecha = Convert.ToDateTime(dr["Fecha"]),
                        Descripcion = dr["Descripcion"].ToString()
                    });
                }
            }
            return objBitacoraError;
        }

         public IEnumerable<BitacoraError> GetAllByName(String pbitacora)
         {
             List<BitacoraError> objBitacora = null;
             return objBitacora;
         }
        

        public void Save()
        {
            
        }

        public void Clear()
        {
            _insertItems.Clear();
            _deleteItems.Clear();
            _updateItems.Clear();
        }

        private void UpdateBitacoraError(BitacoraError objBitacoraError)
        {
            try
            {
            }
            catch (Exception ex)
            {

            }
        }


         private void DeleteBitacoraError(BitacoraError objBitacoraError)
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
