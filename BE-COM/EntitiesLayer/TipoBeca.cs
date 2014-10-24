using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class TipoBeca : IEntity
    {
        private int _idTipoBeca;

        public int Id
        {
            get { return _idTipoBeca; }
            set { _idTipoBeca = value; }
        }

        public String Nombre { get; set; }
        public String Descripcion { get; set; }
        public String Estado { get; set; }
        public int IdPeriodo { get; set; }

        public TipoBeca()
        {
            Id = 0;
            Nombre = "";
            Descripcion = "";
            Estado = "";
            IdPeriodo = 0;
        }

        public TipoBeca(string pnombre, string pdescripcion, string pestado, int pidperiodo)
        {
            Id = 0;
            Nombre = pnombre;
            Descripcion = pdescripcion;
            Estado = pestado;
            IdPeriodo = pidperiodo;
        }





    }
}
