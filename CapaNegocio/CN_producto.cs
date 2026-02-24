    using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_producto
    {
        private CD_producto objDatos = new CD_producto();

        public void Insertar(Producto producto)
        {
            objDatos.Insertar(producto);
        }

        public List<Producto> Listar()
        {
            return objDatos.Listar();
        }

        public void Actualizar(Producto producto)
        {
            objDatos.Actualizar(producto);
        }

        public void Eliminar(int id)
        {
            objDatos.Eliminar(id);
        }

        public Producto ObtenerPorId(int id)
        {
            
            if (id <= 0)
                return null;

            return objDatos.ObtenerPorId(id);
        }
    }
}
