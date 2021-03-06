﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Carrera: IEntity
    {
        private int _idCarrera;

        public int Id
        {
            get { return _idCarrera; }
            set { _idCarrera = value; }
        }

        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public int Universidad { get; set; }
        public int Director { get; set; }
        public String Color { get; set; }
        public int BecasOtor { get; set; }
        public int Estado { get; set; }
      

        public Carrera(String pcodigo, String pnombre,int puniversidad,String pcolor,int pbecas,int pestado)
        {
   
            Codigo = pcodigo;
            Nombre = pnombre;
            Universidad = puniversidad;
            //Director = pdirector;
            Color= pcolor;
            BecasOtor = pbecas;
            Estado = pestado;
        }
        public Carrera(int pid,String pcodigo, String pnombre, int puniversidad, String pcolor, int pbecas,int pestado)
        {
            Id = pid;
            Codigo = pcodigo;
            Nombre = pnombre;
            Universidad = puniversidad;
            //Director = pdirector;
            Color = pcolor;
            BecasOtor = pbecas;
            Estado = pestado;
        }

        public Carrera()
        {
            // TODO: Complete member initialization
        }
    }

    }

