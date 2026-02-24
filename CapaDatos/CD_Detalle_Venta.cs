using CapaEntidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class CD_Detalle_Venta
    {
        public List<Detalle_Venta> ListarPorVenta(int idVenta)
        {
            List<Detalle_Venta> lista = new List<Detalle_Venta>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarDetallePorVenta", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdVenta", idVenta);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Detalle_Venta()
                    {
                        Id_detalle = Convert.ToInt32(dr["Id_detalle"]),
                        Id_venta = Convert.ToInt32(dr["Id_venta"]),
                        N_Producto = Convert.ToString(dr["Id_producto"]),
                        Cant = Convert.ToInt32(dr["Cant"]),
                        Precio = Convert.ToDecimal(dr["Precio"]),
                        Subtotal = Convert.ToDecimal(dr["Subtotal"])
                    });
                }
            }

            return lista;
        }

    }
}
