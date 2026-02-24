using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidades;

namespace CapaNegocio
{
    public class BLL
    {
        private DAL dal = new DAL();

        public List<Categoria> Listar()
        {
            return dal.Listar();
        }

        public void Guardar(Categoria categoria)
        {
            if (categoria.Id_Categoria == 0)
                dal.Insertar(categoria);
            else
                dal.Actualizar(categoria);
        }
        public void Actualizar(Categoria categoria)
        {
            dal.Actualizar(categoria);
        }

        public void Eliminar(int id)
        {
            dal.Eliminar(id);
        }
    }
}
