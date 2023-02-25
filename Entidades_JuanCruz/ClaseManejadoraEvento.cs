using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades_JuanCruz
{
    public class ClaseManejadoraEvento
    {
        private static String rutaArchivo;

        static ClaseManejadoraEvento()
        {
            rutaArchivo = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"CarpetaTxt\"; 
        }

        public ClaseManejadoraEvento()
        {
            ClaseConEvento.Evento += Guardar_Manejador;
            ClaseConEvento cla = new ClaseConEvento();
            cla.ToString();
        }

        public void Guardar_Manejador(String dato)
        {
            String aux = DateTime.Now.ToLongDateString() + "\n" + dato;
            this.GuardarArchivoTxt(aux);
        }

        private void GuardarArchivoTxt(String dato)
        {
            string rutaCompleta = rutaArchivo + @"File.txt";

            try
            {
                if (!(Directory.Exists(rutaArchivo)))
                {
                    Directory.CreateDirectory(rutaArchivo);
                }

                File.WriteAllText(rutaCompleta, dato);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al guardar archivo txt, clase manejadora de evento, metodo guardarArchivo\nError: {ex.Message}", ex);
            }
        }

    }
}
