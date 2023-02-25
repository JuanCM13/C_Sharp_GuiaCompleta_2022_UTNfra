using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace MiPrimerCruz_BaseDatos
{
    public class PersonaDAO
    {
        private static String ruta;
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader reader;

        static PersonaDAO()
        {
            PersonaDAO.ruta = @"Server=localhost;Database=Base_Persona;Trusted_Connection=True;"; //siempre mantener asi, cambiar el database nomas
        }
    
        public PersonaDAO()
        {
            this.conexion = new SqlConnection(PersonaDAO.ruta); //seteo la conexion
        }

        public bool ProbarConexion()
        {
            try
            {
                this.conexion.Open(); //trato de abrir la conexion a la ruta pasadas, si existe la abre, sino excepcion
            }
            catch(Exception)
            {
                return false;
            }
            finally
            {
                if(this.conexion.State == ConnectionState.Open) //siempre chequear, sino lanza ex y nadie la ataja
                {
                    this.conexion.Close();
                }
            }
            return true;
        }

        public List<Persona> Leer()
        {
            List<Persona> listado = new();
            String nombreAux;
            String apellidoAux;
            Int32 idAux;

            try
            {
                this.comando = new SqlCommand(); //instancio la herramienta que me habilita a escribir en sintaxis sql

                this.comando.CommandType = CommandType.Text;  //indico que voy a leer en texto, literal en sintaxis sql
                this.comando.CommandText = "SELECT * FROM Persona"; //indico la accion, en este caso retorno toda la info de la tabla
                this.comando.Connection = this.conexion; //le indico la ruta digamos, de donde voy a sacar todo...

                this.conexion.Open(); //abro la conexion, siempre tratar de hacerlo al final de todo, asi se aprovecha el entorno
                                      //desconectado

                this.reader = this.comando.ExecuteReader(); //instancio el lector, a travez del command, el reader no tiene constructor propio
            
                while(this.reader.Read() == true) //esto va desapilando a medida que lee, mientras siga teniendo lineas se ejecuta, sino corta el while
                {
                    idAux = this.reader.GetInt32(0);
                    nombreAux = this.reader.GetString(1); //castear datos leidos con los getter de la clase sqlDataReader
                    apellidoAux = this.reader.GetString(2);

                    listado.Add(new Persona(nombreAux, apellidoAux, idAux)); //asigno a la lista creando nueva persona
                }

            }                           
            catch(Exception ex)
            {               //relanzo la excepcion y la manejo depende si es consola o form, asi la hago independiente esta clase
                throw new Exception($"Error, en el metodo leer de la clase PersonaDao\nError: {ex.Message}", ex);
            }
            finally
            {
                if(this.conexion.State == ConnectionState.Open) //siempre que abro cierro, antes verifico sino lanza ex
                {
                    this.conexion.Close();
                }
            }

            return listado;
        }

        public bool Guardar(Persona p)
        {
            bool ret = true;
            String auxS;
            Int32 modificaciones;

            if(!(p is null))
            {
                try
                {
                    this.comando = new SqlCommand();
                    
                    auxS = "INSERT INTO dbo.Persona (Nombre , Apelliido) VALUES (@Nombre ,  @Apellido)";

                    this.comando.Parameters.AddWithValue("@ID", p.id);
                    this.comando.Parameters.AddWithValue("@Nombre", p.nombre);
                    this.comando.Parameters.AddWithValue("@Apellido", p.apellido);
                   
                    this.comando.CommandType = CommandType.Text;
                    this.comando.CommandText = auxS;
                    this.comando.Connection = this.conexion;

                    this.conexion.Open();

                    modificaciones = this.comando.ExecuteNonQuery();

                    if(modificaciones == 0)
                    {
                        ret = false;
                    }
                }
                catch(Exception ex)
                {
                    ret = false;
                    throw new Exception($"Fallo metodo Guardar, clase PersonaDao\nError: {ex.Message}", ex);
                }
                finally
                {
                    if(this.conexion.State == ConnectionState.Open)
                    {
                        this.conexion.Close();
                    }
                }
            }
            return ret;
        }

        public Persona LeerPorID(Int32 id)
        {
            Persona persona = default;
            String nombreAux;
            String apellidoAux;
            Int32 idAux;

            try
            {
                this.comando = new SqlCommand(); //instancio la herramienta que me habilita a escribir en sintaxis sql

                this.comando.CommandType = CommandType.Text;  //indico que voy a leer en texto, literal en sintaxis sql
                this.comando.CommandText = "SELECT * FROM Persona WHERE ID =  " + id.ToString(); //indico la accion, en este caso retorno toda la info de la tabla
                this.comando.Connection = this.conexion; //le indico la ruta digamos, de donde voy a sacar todo...

                this.conexion.Open(); //abro la conexion, siempre tratar de hacerlo al final de todo, asi se aprovecha el entorno
                                      //desconectado

                this.reader = this.comando.ExecuteReader(); //instancio el lector, a travez del command, el reader no tiene constructor propio

                while (this.reader.Read() == true) //esto va desapilando a medida que lee, mientras siga teniendo lineas se ejecuta, sino corta el while
                {
                    idAux = this.reader.GetInt32(0);
                    nombreAux = this.reader.GetString(1); //castear datos leidos con los getter de la clase sqlDataReader
                    apellidoAux = this.reader.GetString(2);

                    persona = new Persona(nombreAux, apellidoAux, idAux); //asigno a la lista creando nueva persona
                }

            }
            catch (Exception ex)
            {               //relanzo la excepcion y la manejo depende si es consola o form, asi la hago independiente esta clase
                throw new Exception($"Error, en el metodo leer de la clase PersonaDao\nError: {ex.Message}", ex);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open) //siempre que abro cierro, antes verifico sino lanza ex
                {
                    this.conexion.Close();
                }
            }

            return persona;
        }

        public bool ModificarPorID(Int32 id , String nombre , String Apellido)
        {
            bool ret = true;
            String auxS;
            Int32 filasAfectadas;

            try
            {
                this.comando = new SqlCommand();

                auxS = $"UPDATE Persona SET Nombre = @Nombre , Apelliido = @Apellido WHERE ID = {id}";    

                comando.Parameters.AddWithValue("@Nombre", nombre);
                comando.Parameters.AddWithValue("@Apellido", Apellido);

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = auxS;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                filasAfectadas = this.comando.ExecuteNonQuery();

                if(filasAfectadas == 0)
                {
                    ret = false;
                }
            }
            catch (Exception ex)
            {
                ret = false;
                throw new Exception($"Error en Metodo Modificar por ID, Clase PersonaDAO\nERROR: {ex.Message}", ex);
            }
            finally
            {
                if(this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }
            return ret;
        }

        public bool Borrar(Int32 id)
        {
            bool ret = true;
            String auxS;
            Int32 filasAfectadas;

            try
            {
                this.comando = new SqlCommand();

                auxS = "DELETE FROM Persona WHERE ID = @Id";

                comando.Parameters.AddWithValue("@id", id);

                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = auxS;
                this.comando.Connection = this.conexion;

                this.conexion.Open();

                filasAfectadas = comando.ExecuteNonQuery();

                if(filasAfectadas == 0)
                {
                    ret = false;
                }
            }
            catch (Exception ex)
            {
                ret = false;
                throw new Exception($"Error en Metodo Modificar por ID, Clase PersonaDAO\nERROR: {ex.Message}", ex);
            }
            finally
            {
                if (this.conexion.State == ConnectionState.Open)
                {
                    this.conexion.Close();
                }
            }

            return ret;
        }
    }
}
