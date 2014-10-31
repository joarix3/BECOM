using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Beneficio : IEntity
    {
        private int idBeneficio;
        public int Id
        {
            get { return idBeneficio; }
            set { idBeneficio = value; }
        }
        public String Nombre { get; set; }
        public double Porcentaje { get; set; }
        public String Descripcion { get; set; }


        public Beneficio()
        {
            Id = 0;
            Nombre = "";
            Porcentaje = 0;
            Descripcion = "";
        }

        public Beneficio(string pnombre, double pporcentaje, string pdescripcion)
        {
            Id = 0;
            Nombre = pnombre;
            Porcentaje = pporcentaje;
            Descripcion = pdescripcion;
        }

        public Beneficio(int idBeneficio, string pnombre, double pporcentaje, string pdescripcion)
        {
            Id = idBeneficio;
            Nombre = pnombre;
            Porcentaje = pporcentaje;
            Descripcion = pdescripcion;
        }

    }
}
