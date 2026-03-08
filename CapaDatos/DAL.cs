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
    public class DAL
    {
        public List<Categoria> Listar()
        {
            List<Categoria> lista = new List<Categoria>();

            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("SP_ListarCategorias",cn);
                cn.Open();

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    lista.Add(new Categoria
                    {
                        Id_Categoria = (int)dr["Id_Categoria"],
                        Nombre_Categoria = dr["Nombre_Categoria"].ToString(),
                        Descripcion = dr["Descripcion"].ToString()
                    });
                }
            }
            return lista;
        }

        public void Insertar(Categoria categoria)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_InsertarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Nombre_Categoria", categoria.Nombre_Categoria);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        public void Actualizar(Categoria categoria)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_ActualizarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Categoria", categoria.Id_Categoria);
                cmd.Parameters.AddWithValue("@Nombre_Categoria", categoria.Nombre_Categoria);
                cmd.Parameters.AddWithValue("@Descripcion", categoria.Descripcion);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
      
        }

        public void Eliminar(int id)
        {
            using (SqlConnection cn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarCategoria", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Id_Categoria", id);

                cn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
