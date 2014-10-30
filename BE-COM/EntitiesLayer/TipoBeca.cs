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
        public String IdPeriodo { get; set; }


        public TipoBeca(){
            Nombre = "";
            Descripcion = "";
            Estado = "1";
            IdPeriodo = "1";
        }

        public TipoBeca(String pnombre, String pdescripcion, String pidPeriodo){
            Nombre = pnombre;
            Descripcion = pdescripcion;
            IdPeriodo = pidPeriodo;
        }

        public TipoBeca(String pnombre, String pdescripcion, String pidPeriodo, String pestado){
            Nombre = pnombre;
            Descripcion = pdescripcion;
            IdPeriodo = pidPeriodo;
            Estado = pestado;
        }
        public TipoBeca(int pidTipoBeca, String pnombre, String pdescripcion, String pidPeriodo, String pestado)
        {
            Id = pidTipoBeca;
            Nombre = pnombre;
            Descripcion = pdescripcion;
            IdPeriodo = pidPeriodo;
            Estado = pestado;
        }
    }
}
