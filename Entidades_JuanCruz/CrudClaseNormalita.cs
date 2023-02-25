using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace Entidades_JuanCruz
{
    public static class CrudClaseNormalita
    {
        private static String rutaConexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;
        private static SqlDataReader reader;
    
        static CrudClaseNormalita()
        {
            rutaConexion = @"Server=localhost;Database=bd-modelo-sp;Trusted_Connection=True;";
            conexion = new SqlConnection(rutaConexion);
            comando = new SqlCommand();
            comando.Connection = conexion;
            comando.CommandType = System.Data.CommandType.Text;
        }

        public static bool ProbarConexion()
        {
            bool rta = true;

            try
            {
                conexion.Open();
            }
            catch (Exception)
            {
                rta = false;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public static List<ClaseNormalita> LeerData()
        {
            List<ClaseNormalita> listaRetorno = new List<ClaseNormalita>();
            String consulta;
            Int32 id;
            Int32 edad;
            String nombre;

            try
            {
                consulta = "SELECT * FROM dbo.usuario";
                comando.CommandText = consulta;

                conexion.Open();

                using (reader = comando.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id = (int)reader["id"];
                        edad = (int)reader["edad"];
                        nombre = reader["nombre"].ToString();

                        listaRetorno.Add(new ClaseNormalita(id, nombre, edad));
                    }
                }                    
            }
            catch(Exception ex)
            {
                throw new Exception($"Error en el metodo Leer la base de datos\nERROR: {ex.Message}", ex);
            }
            finally
            {
                if(conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return listaRetorno;
        }

        public static bool AgregarDato(ClaseNormalita clase)
        {
            bool rta = true;
            String consulta;
            Int32 filasAfectadas;

            try
            {
                comando.Parameters.Clear();
                consulta = "INSERT INTO dbo.usuario (nombre , edad) VALUES(@nomb , @ed)";
                comando.Parameters.AddWithValue("@nomb" , clase.Nombre);
                comando.Parameters.AddWithValue("@ed", clase.Edad);

                comando.CommandText = consulta;

                conexion.Open();

                filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el metodo Agregar a la base de datos\nERROR: {ex.Message}", ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public static bool ModificarDato(ClaseNormalita clase)
        {
            bool rta = true;
            String consulta;

            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@nom", clase.Nombre);
                comando.Parameters.AddWithValue("@ed", clase.Edad);
                comando.Parameters.AddWithValue("@ID", clase.Id);

                consulta = "UPDATE dbo.usuario SET nombre = @nom, edad = @ed WHERE id = @ID";
                comando.CommandText = consulta;

                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el metodo Modificar a la base de datos\nERROR: {ex.Message}", ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }

        public static bool EliminarDato(int id)
        {
            bool rta = true;
            String consulta;

            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("@ID", id);

                consulta = "DELETE FROM dbo.usuario WHERE id = @ID";
                comando.CommandText = consulta;
                
                conexion.Open();

                int filasAfectadas = comando.ExecuteNonQuery();

                if (filasAfectadas == 0)
                {
                    rta = false;
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Error en el metodo Eliminar a la base de datos\nERROR: {ex.Message}", ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }

            return rta;
        }
    }
}
