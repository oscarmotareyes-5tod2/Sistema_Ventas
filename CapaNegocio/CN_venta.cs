using CapaDatos;
using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class CN_venta
    {

        private CD_Venta cd = new CD_Venta();

        public List<Ventas> Listar()
        {
            return cd.Listar();
        }

        public int Insertar(Ventas venta)
        {
            
            if (venta.Id_cliente <= 0)
                throw new Exception("Debe seleccionar un cliente.");

            if (venta.Detalles == null || venta.Detalles.Count == 0)
                throw new Exception("Debe agregar al menos un producto a la venta.");

            if (venta.Total_general <= 0)
                throw new Exception("El total de la venta no puede ser 0.");

            // Si pasa validaciones → guarda
            cd.Insertar(venta);
            return cd.Insertar(venta);
        }



        //public void Actualizar(Ventas venta)
        //{
        //    if (venta.Id_Venta <= 0)
        //        throw new Exception("Venta inválida.");

        //    cd.Actualizar(venta);
        //}

        //public void Eliminar(int idVenta)
        //{
        //    if (idVenta <= 0)
        //        throw new Exception("Id inválido.");

        //    cd.Eliminar(idVenta);
        //}

        public DataTable MostrarFactura(int idVenta)
        {
            CD_Venta datos = new CD_Venta();
            return datos.MostrarFactura(idVenta);
        }

    }
}
