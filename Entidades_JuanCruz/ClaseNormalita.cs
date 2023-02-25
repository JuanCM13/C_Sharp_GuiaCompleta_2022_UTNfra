using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades_JuanCruz
{
    public class ClaseNormalita : ISerializadoraJson
    {
        private Int32 id;
        private String nombre;
        private Int32 edad;
        private static String ruta;

        static ClaseNormalita()
        {
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"CarpetaXml\";
        }

        public ClaseNormalita()
        { }

        public ClaseNormalita(String nombre, Int32 edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public ClaseNormalita(Int32 id, String nombre, Int32 edad)
            :this(nombre , edad)
        {
            this.id = id;
        }

        public Int32 Id
        {
            get { return this.id; }
        }

        public Int32 Edad
        {
            get { return this.edad; }
        }

        public String Nombre
        {
            get { return this.nombre; }
        }

        public bool SerializarJson(String nombreArchivo)
        {
            bool ret = false;
            String rutaCompleta = ClaseNormalita.ruta + "_" + nombreArchivo + ".json";
            
            try
            {
                if (!Directory.Exists(ClaseNormalita.ruta))
                {
                    Directory.CreateDirectory(ClaseNormalita.ruta);
                }

                File.WriteAllText(rutaCompleta, JsonSerializer.Serialize(this));
                ret = true;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error lanzado en metodo SerializarJson de la clase ClaseNormalita\nError: {ex.Message}",ex);
            }
            return ret;
        }

        public bool DeserializarJson(String nombreArchivo ,out ClaseNormalita clase)
        {
            string archivo = string.Empty;
            ClaseNormalita auxClase = default;
            String[] archivosGuardadosEnCarpetaDeRuta;
            bool ret = false;

            try
            {
                if (Directory.Exists(ClaseNormalita.ruta))
                {
                    archivosGuardadosEnCarpetaDeRuta = Directory.GetFiles(ClaseNormalita.ruta);
                    foreach (String item in archivosGuardadosEnCarpetaDeRuta)
                    {
                        if (item.Contains(nombreArchivo))
                        {
                            archivo = item;
                            break;
                        }
                    }

                    if (!String.IsNullOrEmpty(archivo))
                    {
                        auxClase = JsonSerializer.Deserialize<ClaseNormalita>(File.ReadAllText(archivo), new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                        ret = true;
                    }
                }
                clase = auxClase;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error lanzado en metodo DeserializarJson de la clase ClaseNormalita\nError: {ex.Message}", ex);
            }
            return ret;
        }
    }
}
