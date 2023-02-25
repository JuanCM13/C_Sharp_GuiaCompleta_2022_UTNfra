using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace EstoNoEsSteam_Entidades
{
    public static class UsuarioDao
    {
        private static String ruta;
        private static SqlCommand comando;
        private static SqlConnection conexion;

        static UsuarioDao()
        {
            UsuarioDao.ruta = @"Server=localhost;Database=EJERCICIOS_UTN;Trusted_Connection=True;";
            UsuarioDao.conexion = new SqlConnection(ruta);
            UsuarioDao.comando = new SqlCommand();
            UsuarioDao.comando.Connection = UsuarioDao.conexion;
            UsuarioDao.comando.CommandType = CommandType.Text;
        }

        public static bool ProbarConexion()
        {
            try
            {
                UsuarioDao.conexion.Open();
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                if (UsuarioDao.conexion.State == ConnectionState.Open)
                {
                    UsuarioDao.conexion.Close();
                }
            }
            return true;
        }

        public static List<Usuario> Leer()
        {
            List<Usuario> usuarios = new List<Usuario>();
            String nombreUsuario;
            Int32 codigoUsuario;

            try
            {
                String consulta = "SELECT USERNAME , CODIGO_USUARIO FROM dbo.USUARIOS";
                UsuarioDao.comando.CommandText = consulta;

                UsuarioDao.conexion.Open();

                using (SqlDataReader reader = UsuarioDao.comando.ExecuteReader())
                {
                    while(reader.Read() == true)
                    {
                        nombreUsuario = reader["USERNAME"].ToString();
                        codigoUsuario = Convert.ToInt32(reader["CODIGO_USUARIO"]);

                        usuarios.Add(new Usuario(nombreUsuario , codigoUsuario));
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Excepcion, metodo Leer, clase UsuarioDao\nERROR: {ex.Message}", ex);
            }
            finally
            {
                if(UsuarioDao.conexion.State == ConnectionState.Open)
                {
                    UsuarioDao.conexion.Close();
                }
            }
            return usuarios;
        }


    }
}
