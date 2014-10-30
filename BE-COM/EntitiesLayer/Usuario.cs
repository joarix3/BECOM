using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer
{
    public class Usuario:IEntity
    {
        private int _idUsuario;

        public int Id
        {
            get { return _idUsuario; }
            set { _idUsuario = value; }
        }

        public String Nombre { get; set; }
        public String PrimerApellido { get; set; }
        public String SegundoApellido { get; set; }
        public int NumeroCedula { get; set; }
        public String Contrasena { get; set; }
        public String CorreoElectronico { get; set; }
        public String Genero { get; set; }
        public String Direccion { get; set; }
        public int NumeroTelefono { get; set; }
        public String FechaNacimiento { get; set; }
        public int Edad { get; set; }
        public int IdRol { get; set; }
        public Rol rol { get; set; }

        public Usuario()
        {
            Id = 0;

            Nombre = "";
            PrimerApellido = "";
            SegundoApellido = "";
            NumeroCedula = 0;
            Contrasena = "";
            CorreoElectronico = "";
            Genero = "";
            Direccion = "";
            NumeroTelefono = 0;
            FechaNacimiento = "";
            Edad = 0;
            IdRol = 0;
            rol = null;
        }

        public Usuario(int pnumeroCedula, String pnombre, String pprimerApellido, String psegundoApellido, String pgenero, int pnumeroTelefono,
            String pfechaNacimiento,int pedad, int pidRol, string pcorreoElectronico, string pdireccion, string pcontrasena)
        {
            Nombre = pnombre;
            PrimerApellido = pprimerApellido;
            SegundoApellido = psegundoApellido;
            NumeroCedula = pnumeroCedula;
            Contrasena = pcontrasena;
            CorreoElectronico = pcorreoElectronico;
            Direccion = pdireccion;
            NumeroTelefono = pnumeroTelefono;
            FechaNacimiento = pfechaNacimiento;
            Edad = pedad;
            IdRol = pidRol;
            Genero = pgenero;

        }

    }
}
