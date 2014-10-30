using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{

    public class Curso:IEntity
    {

        private int _idCurso;

        public int Id
        {
            get { return _idCurso; }
            set { _idCurso = value; }
        }

        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public int Creditos { get; set; }
        public int Costo { get; set; }
        public int Estado { get; set; }
      

        public Curso(String pcodigo, String pnombre,int pcreditos,int pcosto,int pestado)
        {
   
            Codigo = pcodigo;
            Nombre = pnombre;
            Creditos = pcreditos;
            Costo= pcosto;
            Estado = pestado;
        }

        public Curso(int pid, string pnombre)
        {

            Id = pid;
            Nombre = pnombre;
        }
        public Curso(int pid,String pcodigo, String pnombre,int pcreditos,int pcosto,int pestado)
        {
            Id = pid;
            Codigo = pcodigo;
            Nombre = pnombre;
            Creditos = pcreditos;
            Costo= pcosto;
            Estado = pestado;
        }

        public Curso()
        {
            Id = 0;
            Nombre = "";
            Creditos = 0;
            Costo = 0;
            Estado = 0;

        }





    }
}
