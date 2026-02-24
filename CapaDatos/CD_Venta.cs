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
    public class CD_Venta
    {

        public List<Ventas> Listar()
        {
            List<Ventas> lista = new List<Ventas>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ListarVentas", cn);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Ventas()
                    {
                        Id_Venta = Convert.ToInt32(dr["Id_Venta"]),
                        Fecha_venta = Convert.ToDateTime(dr["Fecha_venta"]),
                        Id_cliente = Convert.ToInt32(dr["Id_cliente"]),
                        Total_general = Convert.ToDecimal(dr["Total_general"]),
                        
                        
                    });
                }
            }

            return lista;
        }

        public int Insertar(Ventas venta)
        {
         
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                cn.Open();
                SqlTransaction transaction = cn.BeginTransaction();

                try
                {
                  
                    SqlCommand cmdVenta = new SqlCommand("sp_InsertarVenta", cn, transaction);
                    cmdVenta.CommandType = CommandType.StoredProcedure;

                    cmdVenta.Parameters.AddWithValue("@IdCliente", venta.Id_cliente);
                    cmdVenta.Parameters.AddWithValue("@Total", venta.Total_general);
                    

                    int idVentaGenerado = Convert.ToInt32(cmdVenta.ExecuteScalar());

                    
                    foreach (var item in venta.Detalles)
                    {
                        decimal subtotal = item.Cant * item.Precio;

                        SqlCommand cmdDetalle = new SqlCommand("sp_InsertarDetalleVenta", cn, transaction);
                        cmdDetalle.CommandType = CommandType.StoredProcedure;

                        cmdDetalle.Parameters.AddWithValue("@IdVenta", idVentaGenerado);
                        cmdDetalle.Parameters.AddWithValue("@IdProducto", item.Id_producto);
                        cmdDetalle.Parameters.AddWithValue("@Cant", item.Cant);
                        cmdDetalle.Parameters.AddWithValue("@Precio", item.Precio);
                        cmdDetalle.Parameters.AddWithValue("@Subtotal", subtotal);


                        cmdDetalle.ExecuteNonQuery();

                        
                        SqlCommand cmdStock = new SqlCommand("sp_DescontarStock", cn, transaction);
                        cmdStock.CommandType = CommandType.StoredProcedure;

                        cmdStock.Parameters.AddWithValue("@IdProducto", item.Id_producto);
                        cmdStock.Parameters.AddWithValue("@Cant", item.Cant);

                        cmdStock.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    return idVentaGenerado;
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public DataTable MostrarFactura(int idVenta)
        {
            DataTable dt = new DataTable();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_Mostrar_Factura", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Venta", idVenta);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }

            return dt;
        }


    }
}


    

