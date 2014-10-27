using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Periodo : IEntity
    {
        private int _idPeriodo;

        public int Id
        {
            get { return _idPeriodo; }
            set { _idPeriodo = value; }
        }
        public String Nombre { get; set; }
        public int Dia { get; set; }
        public int Mes { get; set; }
        public String Estado { get; set; }

        public Periodo(String pnombre, int pdia, int pmes, String pestado){
            Nombre = pnombre;
            Dia = pdia;
            Mes = pmes;
            Estado = pestado;
        }
        
        public Periodo(String pnombre, int pdia, int pmes){
            Nombre = pnombre;
            Dia = pdia;
            Mes = pmes;
        }

        public Periodo(int pid, String pnombre, int pdia, int pmes, String pestado)
        {
            Id = pid;
            Nombre = pnombre;
            Dia = pdia;
            Mes = pmes;
            Estado = pestado;
        }

        public Periodo()
        {
            Id = 0;
            Nombre = "";
            Dia = 0;
            Mes = 0;
        }
    }
}
