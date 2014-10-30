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

namespace DAL
{
    public class CorreoRepository
    {
   
        // metodo para obtener la contrasena mediante el correo electronico
       static public Correo GetByCorreo(string correo)
        {
            Correo objCorreo = null;
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@Correo", correo);
            var ds = DBAccess.ExecuteSPWithDS(ref cmd, "PaRecuperarContra");

            if (ds.Tables[0].Rows.Count > 0)
            {
                var dr = ds.Tables[0].Rows[0];

                objCorreo = new Correo
                {
                    Contra = dr["Contrasenna"].ToString()
                };
            }
            return objCorreo;
        }

    
    }
}
