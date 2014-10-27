using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Requisito : IEntity
    {
        private int idRequisito;
        public int Id
        {
            get { return idRequisito; }
            set { idRequisito = value; }
        }
        public String Nombre { get; set; }
        public String Descripcion { get; set; }


        public Requisito()
        {
            Id = 0;
            Nombre = "";
            Descripcion = "";
        }

        public Requisito(string pnombre, string pdescripcion)
        {
            Id = 0;
            Nombre = pnombre;
            Descripcion = pdescripcion;
        }

    }
}
