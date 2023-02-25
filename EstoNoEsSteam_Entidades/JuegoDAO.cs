using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace EstoNoEsSteam_Entidades
{
    public static class JuegoDao
    {
        private static String cadenaConexion;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static JuegoDao()
        {
            JuegoDao.cadenaConexion = @"Server=localhost;Database=EJERCICIOS_UTN;Trusted_Connection=True;";
            JuegoDao.conexion = new SqlConnection(JuegoDao.cadenaConexion);            
            JuegoDao.comando = new SqlCommand();
            JuegoDao.comando.Connection = JuegoDao.conexion;
            JuegoDao.comando.CommandType = CommandType.Text;
        }

        public static bool ProbarConexion()
        {            
            try
            {
                JuegoDao.conexion.Open(); 
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (JuegoDao.conexion.State == ConnectionState.Open) 
                {
                    JuegoDao.conexion.Close();
                }
            }
            return true;
        }

        public static bool Eliminar(Int32 id)
        {
            bool ret = true;
            Int32 modificaciones;

            try
            {
                JuegoDao.comando.Parameters.Clear();

                String consulta = $"DELETE FROM dbo.JUEGOS WHERE CODIGO_JUEGO = @codigoJuego";
                JuegoDao.comando.Parameters.AddWithValue("@codigoJuego" , id);

                JuegoDao.comando.CommandText = consulta;
                JuegoDao.conexion.Open();

                modificaciones = JuegoDao.comando.ExecuteNonQuery();

                if(modificaciones == 0)
                {
                    ret = false;
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Excepcion, metodo Eliminar, clase JuegoDao\nERROR: {ex.Message}", ex);
            }
            finally
            {
                if (JuegoDao.conexion.State == ConnectionState.Open)
                {
                    JuegoDao.conexion.Close();
                }
            }
            return ret;
        }

        public static bool Guardar(Juego juego)
        {
            bool ret = true;
            Int32 modificaciones;

            if(!(juego is null))
            {
                try
                {
                    JuegoDao.comando.Parameters.Clear(); //limpio el buffer de coleccion de parametros

                    String consulta = "INSERT INTO dbo.JUEGOS (CODIGO_USUARIO,NOMBRE,PRECIO,GENERO)";
                    consulta += "VALUES (@codigoUsuaio , @nombre , @precio , @genero)";

                    JuegoDao.comando.Parameters.AddWithValue("@codigoUsuaio", juego.CodigoUsuario);
                    JuegoDao.comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                    JuegoDao.comando.Parameters.AddWithValue("@precio", juego.Precio);
                    JuegoDao.comando.Parameters.AddWithValue("@genero", juego.Genero);

                    JuegoDao.comando.CommandText = consulta;
                    JuegoDao.conexion.Open();

                    modificaciones = JuegoDao.comando.ExecuteNonQuery();

                    if(modificaciones == 0)
                    {
                        ret = false;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception($"Excepcion, metodo Guardar, clase JuegoDao\nERROR: {ex.Message}", ex);
                }
                finally
                {
                    if (JuegoDao.conexion.State == ConnectionState.Open)
                    {
                        JuegoDao.conexion.Close();
                    }
                }
            }
            return ret;
        }

        public static Juego LeerPorId(Int32 idJuego)
        {
            Juego auxJ = default;
            Int32 codigoJuego;
            Int32 codigoUsuario;
            String genero;
            String nombre;
            Double precio;

            try
            {
                JuegoDao.comando.Parameters.Clear();

                String consulta = "SELECT * FROM dbo.JUEGOS WHERE CODIGO_JUEGO = @codigoJuego";
                JuegoDao.comando.Parameters.AddWithValue("@codigoJuego", idJuego);

                JuegoDao.comando.CommandText = consulta;
                JuegoDao.conexion.Open();

                using (SqlDataReader reader = JuegoDao.comando.ExecuteReader()) //lo abro con using asi se cierra solo,
                {                                           //sino lo abro fuera del using y lo cierro a manopla
                    while(reader.Read())
                    {
                        codigoJuego = reader.GetInt32(0);
                        codigoUsuario = reader.GetInt32(1);
                        nombre = reader.GetString(2);
                        precio = reader.GetDouble(3);
                        genero = reader.GetString(4);

                        auxJ = new(nombre, precio, genero, codigoJuego, codigoUsuario);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Excepcion, metodo LeerPorId, clase JuegoDao\nERROR: {ex.Message}", ex);
            }
            finally
            {
                if (JuegoDao.conexion.State == ConnectionState.Open)
                {
                    JuegoDao.conexion.Close();
                }
            }
            return auxJ;
        }

        public static List<Biblioteca> Leer()
        {
            List<Biblioteca> listaRetorno = new List<Biblioteca>();
            Int32 codigoJuego;
            String genero;
            String nombreJuego;
            String nombreUsuario;

            try
            {
                //Tengo que usar join para relacionar tablas, preguntar el sabado..
                /*el join es unir las 2 tablas juegos y usuarios para obtener datos de las 2 y generar una nueva tabla,
                 yo necesito la info: nombre del juego, genero del juego , codigo del juego y nombre del usuario relacionado*/
                String consulta = "SELECT JUEGOS.NOMBRE as juego, JUEGOS.GENERO as genero, JUEGOS.CODIGO_JUEGO as codigoJuego, " +
                    "USUARIOS.USERNAME as usuario FROM dbo.JUEGOS JOIN dbo.USUARIOS ON dbo.JUEGOS.CODIGO_USUARIO = dbo.USUARIOS.CODIGO_USUARIO";

                JuegoDao.comando.CommandText = consulta;
                JuegoDao.conexion.Open();

                using (SqlDataReader reader = JuegoDao.comando.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        codigoJuego = Convert.ToInt32(reader["codigoJuego"]);
                        genero = reader["genero"].ToString();
                        nombreJuego = reader["juego"].ToString();
                        nombreUsuario = reader["usuario"].ToString();

                        listaRetorno.Add(new Biblioteca(nombreUsuario,genero,nombreJuego,codigoJuego));
                    }
                }

            }
            catch (Exception ex)
            {
                throw new Exception($"Excepcion, metodo Leer, clase JuegoDao\nERROR: {ex.Message}", ex);
            }
            finally
            {
                if (JuegoDao.conexion.State == ConnectionState.Open)
                {
                    JuegoDao.conexion.Close();
                }
            }
            return listaRetorno;
        }

        public static bool Modificar(Juego juego)
        {
            bool ret = true;
            Int32 modificaciones;

            try
            {
                JuegoDao.comando.Parameters.Clear();

                String consulta = $"UPDATE dbo.JUEGOS SET NOMBRE = @nombre , PRECIO = @precio , GENERO = @genero WHERE CODIGO_JUEGO = @codigoJuego";
                JuegoDao.comando.Parameters.AddWithValue("@nombre", juego.Nombre);
                JuegoDao.comando.Parameters.AddWithValue("@genero", juego.Genero);
                JuegoDao.comando.Parameters.AddWithValue("@precio", juego.Precio);
                JuegoDao.comando.Parameters.AddWithValue("@codigoJuego", juego.CodigoJuego);

                JuegoDao.comando.CommandText = consulta;

                JuegoDao.conexion.Open();

                modificaciones = JuegoDao.comando.ExecuteNonQuery();

                if(modificaciones == 0)
                {
                    ret = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Excepcion, metodo Modificar, clase JuegoDao\nERROR: {ex.Message}", ex);
            }
            finally
            {
                if (JuegoDao.conexion.State == ConnectionState.Open)
                {
                    JuegoDao.conexion.Close();
                }
            }
            return ret;
        }
    }
}
