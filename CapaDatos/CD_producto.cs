using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidades;

namespace CapaDatos
{
    public class CD_producto
    {
        public List<Producto> Listar()
        {
            List<Producto> lista = new List<Producto>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ListarProductos", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    lista.Add(new Producto()
                    {
                        Id_Producto = Convert.ToInt32(dr["Id_Producto"]),
                        Nombre_Producto = dr["Nombre_Producto"].ToString(),
                        Precio_Producto = Convert.ToDecimal(dr["Precio_Producto"]),
                        Stock = Convert.ToInt32(dr["Stock"]),
                        Id_Categoria= Convert.ToInt32(dr["Id_Categoria"]),
                        Categoria = dr["Categoria"].ToString()
                    });
                }
            }

            return lista;
        }

        public void Insertar(Producto producto)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre_Producto", producto.Nombre_Producto);
                cmd.Parameters.AddWithValue("@Precio_Producto", producto.Precio_Producto);
                cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                cmd.Parameters.AddWithValue("@Id_Categoria", producto.Categoria);

                cn.Open();
                cmd.ExecuteNonQuery();
            }

        }

        public void Eliminar(int id)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Producto", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Producto producto)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Producto", producto.Id_Producto);
                cmd.Parameters.AddWithValue("@Nombre_Producto", producto.Nombre_Producto);
                cmd.Parameters.AddWithValue("@Precio_Producto", producto.Precio_Producto);
                cmd.Parameters.AddWithValue("@Stock", producto.Stock);
                cmd.Parameters.AddWithValue("@Id_Categoria", producto.Categoria);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public Producto ObtenerPorId(int id)
        {
            Producto producto = null;

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM Productos WHERE Id_Producto = @Id",
                    cn);

                cmd.Parameters.AddWithValue("@Id", id);

                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    producto = new Producto()
                    {
                        Id_Producto = Convert.ToInt32(dr["Id_Producto"]),
                        Nombre_Producto = dr["Nombre_Producto"].ToString(),
                        Precio_Producto = Convert.ToDecimal(dr["Precio_Producto"]),
                        Stock = Convert.ToInt32(dr["Stock"])
                    };
                }
            }

            return producto;
        }


    }


}   

