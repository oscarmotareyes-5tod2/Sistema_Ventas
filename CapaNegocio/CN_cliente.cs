using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_cliente
    {
            public CD_Cliente obj = new CD_Cliente();

            public void Insertar(Cliente c)
            {
                obj.Insertar(c);
            }

            public List<Cliente> Listar()
            {
                return obj.Listar();
            }

            public void Actualizar(Cliente c)
            {
                obj.Actualizar(c);
            }

            public void Eliminar(int id)
            {
                obj.Eliminar(id);
            }
        

    }
}
