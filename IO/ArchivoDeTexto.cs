using System;
using System.IO;

namespace IO
{
    public static class ArchivoDeTextoa
    {
        private static String ruta;

        static ArchivoDeTextoa()
        {
            ArchivoDeTextoa.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ArchivoDeTextoa.ruta += @"\Carpeta_A_Borrar\";
        }

        public static void Guardar(String nombreArchivo , String info)
        {
            String rutaCompleta = ArchivoDeTextoa.ruta += nombreArchivo + ".txt";

            try
            {
                if (!Directory.Exists(ArchivoDeTextoa.ruta))
                {
                    Directory.CreateDirectory(ArchivoDeTextoa.ruta);
                }

                File.WriteAllText(rutaCompleta, info);                
            }            
            catch(Exception ex)
            {
                throw new Exception($"Error en el metodo Guardar, Clase ArchivoDeTexto\nError: {ex.Message}", ex);
            }
        }

        public static String Leer(String nombreArchivo)
        {
            String rutaCompleta = String.Empty;
            String retorno = String.Empty;
            String[] archivos;

            try
            {
                if(Directory.Exists(ArchivoDeTextoa.ruta))
                {
                    archivos = Directory.GetFiles(ArchivoDeTextoa.ruta);
                    foreach(String item in archivos)
                    {
                        if(item == nombreArchivo)
                        {
                            rutaCompleta = item;
                            break;
                        }
                    }

                    if( !String.IsNullOrEmpty(rutaCompleta) )
                    {
                        retorno = File.ReadAllText(rutaCompleta);
                    }
                }
                else
                {
                    throw new FileNotFoundException("Error el archivo deseado, no se encontro...");
                }

                return rutaCompleta;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error en el metodo Leer, Clase ArchivoDeTexto\nError: {ex.Message}", ex);
            }
        }

    }
}
