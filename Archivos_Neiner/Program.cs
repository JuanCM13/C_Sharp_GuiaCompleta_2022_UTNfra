using System;
using System.IO;

namespace Archivos_Neiner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Crud, editar agregar y relacionar elementos en una base de datos

            /*
             * Ejemplo creacion de Archivo.txt con StreamWriter
             
            try 
            {
                using (StreamWriter aux = new StreamWriter("@path//C://etc"))
                {
                    aux.WriteLine("holacomo estas");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Algo fallo!!\n{ex.Message}");
            }


            para leer:

            StramReader

            try 
            {
                using (StreamReader aux = new StreamReader("@path//C://etc"))
                {
                    String linea;
                    while((linea = aux.ReadLine()) != null))
                    {
                        console.writeLine(linea);
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Algo fallo!!\n{ex.Message}");
            }
            */


            /*Excepciones, ruta no existe, sin permiso, ruta mas puesta,path con demasiados caracteres,
             falta de . \ en la ruta,
            por eso siempre usamos trycatch, puede romperse muchas veces..*/

            /*
             * Objetos utiles:
                *File.Exists(String path); si tiene acceso y el path existe da true
                *File.Copy(String c1,Srting c2) //copia un archivo en 2 paths...
                *File.Delete(String path) elimina archivo..
                *
                *En los File. se gestiona solo el open y close de los archivos..
                *
                *
                *Directory.Delete(path)
                *Directorio.Delete(bool)
                *Directory.Exists()
                *etc..
             */

            /*
             * SpecialFolders
             * para que encuentre rutas y carpetas clasicas, son enumerados e indican la carpeta general
             * que se crean en windows, usuario
             * 
             * Enumerado = Environment.SpecialFolder
             * 
             * Environment.GetFolderPath(Enviorenment.SpecialFolder.Desktop) //retorna path del escritorio por defecto de windows
             *  Environment.GetFolderPath(Enviorenment.SpecialFolder.MyDocuments) //retorna path de carpeta documentos  por defecto de windows
            Environment.GetFolderPath(Enviorenment.SpecialFolder.Desktop) //retorna path del escritorio por defecto de windows
             */
            Environment.GetFolderPath(Enviorenment.SpecialFolder.Desktop) //retorna path del escritorio por defecto de windows

        }
    }
}
