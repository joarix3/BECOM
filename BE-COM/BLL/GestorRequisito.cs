using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntitiesLayer;
using DAL;

namespace BLL
{
    public class GestorRequisito
    {
        private UnitOfWork UoW = new UnitOfWork();

        public void agregarRequisito(string nombre, string descripcion)
        {
            try
            {
                Requisito objRequisito = new Requisito(nombre, descripcion);
                UoW.RequisitoRepository.Insert(objRequisito);
            }
            catch (Exception)
            {

            }
        }

        public IEnumerable<Requisito> consultarRequisitoPorEstado()
        {
            return UoW.RequisitoRepository.GetAll();
        }

        public void guardarCambios()
        {
            UoW.RequisitoRepository.Save();
        }

        public IEnumerable<Requisito> consultarRequisitoPorNombre(string nombre)
        {
            return UoW.RequisitoRepository.GetAllByName(nombre);
        }

        public Requisito ObtenerRequisitoPorId(int pid)
        {
            return UoW.RequisitoRepository.GetById(pid);
        }

        //Metodo que modifica la informacion de un requisito
        public void modificarRequisito(int pid, string pnombre, string pdescripcion)
        {
            Requisito objRequisito = new Requisito(pid, pnombre, pdescripcion);
            UoW.RequisitoRepository.Update(objRequisito);
        }

    }
}
