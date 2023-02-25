using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Centralita_Parte5_Interfaz
{
    public class Centralita : IGuardar<String> 
    {
        private List<Llamada> listaLlamadas;
        protected String razonSocial;

        private Centralita()
        {
            this.listaLlamadas = new List<Llamada>();
        }

        public Centralita(String nombre)
            : this()
        {
            this.razonSocial = nombre;
        }

        public Single GananciaPorLocal
        {
            get { return this.CalcularGanancias(TipoLlamada.Local); }
        }

        public Single GananciaPorProvincial
        {
            get { return this.CalcularGanancias(TipoLlamada.Provincial); }
        }

        public Single GananciaPorTotal
        {
            get { return this.CalcularGanancias(TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaLlamadas; }
        }

        private Single CalcularGanancias(TipoLlamada tipo)
        {
            Single recaudado = 0;
            String auxTipo = Enum.GetName(typeof(TipoLlamada), tipo);
            String auxLlamada;

            foreach (Llamada item in this.Llamadas)
            {
                auxLlamada = (item.GetType().Name).ToString();
                if (auxTipo == "Todas" || auxTipo == auxLlamada)
                {
                    recaudado += item.CostoLlamada;
                }
            }
            return recaudado;
        }

        private String Mostrar()
        {
            StringBuilder str = new StringBuilder();
            Int32 index = 0;

            str.AppendLine($"Razon Social: {this.razonSocial}\nGanancia Total: ${this.GananciaPorTotal.ToString("#.#,00")}\n" +
                $"Ganancia Llamadas Locales: ${this.GananciaPorLocal.ToString("#.#,00")}\n" +
                $"Ganancia Llamadas Provinciales: ${this.GananciaPorProvincial.ToString("#.#,00")}");

            str.AppendLine("-----------------------------------------------------------");
            str.AppendLine("                        LLAMADAS");
            str.AppendLine("-----------------------------------------------------------");

            if (this.Llamadas.Count > 0)
            {
                foreach (Llamada item in this.Llamadas)
                {
                    index++;
                    str.AppendLine("-----------------------------------------------------------");
                    str.AppendLine($"                        LLAMADA: {index}");
                    str.AppendLine("-----------------------------------------------------------");
                    str.AppendLine(item.ToString());
                }
            }
            else
            {
                str.AppendLine("No hay llamadas por el momento...");
            }
            return str.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.Llamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        public override string ToString()
        {
            return this.Mostrar();
        }

        public static bool operator ==(Centralita c, Llamada l)
        {
            bool ret = false;
            if (!(c is null) && !(l is null))
            {
                foreach (Llamada item in c.Llamadas)
                {
                    if (item == l)
                    {
                        ret = true;
                        break;
                    }
                }
            }
            return ret;
        }

        public static bool operator !=(Centralita c, Llamada l)
        {
            return !(c == l);
        }

        public static Centralita operator +(Centralita c, Llamada l)
        {
            if (!(c is null) && !(l is null))
            {
                if (c != l)
                {
                    c.AgregarLlamada(l);
                    if(!c.Guardar())
                    {
                        throw new FallaLogException("Falla de log");
                    }
                }
                else
                {
                    throw new CentralitaException("Error, llamada ya registrada..", l.GetType().Name, "Metodo: Centralita + Llamada");
                }
            }
            return c;
        }

        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            this.Llamadas.Add(nuevaLlamada);
        }

        public String RutaDeArchivo
        {
            get { return String.Empty; }
            set { }
        }

        public bool Guardar()
        {
            bool ret = true;
            String ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Centralita6_Archivos_\RegistroLlamadas\";
            String rutaCompleta = String.Empty;
            StreamWriter stw;

            if(!String.IsNullOrEmpty(this.razonSocial) && !(this.Llamadas is null) && this.Llamadas.Count > 0)
            {
                try
                {
                    if( !Directory.Exists(ruta))
                    {
                        Directory.CreateDirectory(ruta);
                    }

                    rutaCompleta = ruta + @"Llamadas.txt";

                    if( !File.Exists(rutaCompleta))
                    {
                        stw = new StreamWriter(rutaCompleta);
                    }
                    else
                    {
                        stw = File.AppendText(rutaCompleta);
                    }

                    stw.WriteLine($"-{DateTime.Now.ToLongDateString()} -- SE REALIZO UNA LLAMADA\n");

                    stw.Close();
                }
                catch(Exception ex)
                {
                    ret = false;
                }
            }

            return ret;
        }

        public String Leer()
        {
            String retorno = String.Empty;

            String archivoRuta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\Centralita6_Archivos_\RegistroLlamadas\";
            String nombreDoc = "Llamadas.txt";
            String rutaCompleta = String.Empty;
            String[] documentos;

            try
            {
                if (Directory.Exists(archivoRuta))
                {
                    documentos = Directory.GetFiles(archivoRuta);
                    archivoRuta += nombreDoc;
                    foreach(String item in documentos)
                    {
                        if(item == archivoRuta)
                        {
                            rutaCompleta = item;
                            break;
                        }
                    }

                    if( !String.IsNullOrEmpty(rutaCompleta))
                    {
                        retorno = File.ReadAllText(rutaCompleta);
                    }
                }
                else
                {
                    throw new Exception("EEEE ROMPIMO TODO");
                }

                return retorno;
            }    
            catch(Exception ex)
            {
                throw new Exception($"Error en metodo Leer, Centralita\nError: {ex.Message}", ex);
            }
        }

    }
}
