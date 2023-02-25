using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Entidades_JuanCruz
{
    public class ClaseGenerica<T , U> : ISerializadoraXml<T , U>
    {
        protected List<T> listaT;
        protected U tipoU;
        private static String ruta;

        static ClaseGenerica()
        {
            ClaseGenerica<T ,U>.ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"CarpetaXml\";
        }

        public ClaseGenerica()
        {
            this.ListaT = new List<T>();
        }

        public ClaseGenerica(U tipoU)
            :this()
        {
            this.TipoU = tipoU;
        }

        public U TipoU
        {
            get { return this.tipoU; }
            set { this.tipoU = value; }
        }

        public List<T> ListaT
        {
            get { return this.listaT; }
            set { this.listaT = value; }
        }

        public List<T> Agregar(T tipoT)
        {
            if (!(tipoT is null))
            {
                this.ListaT.Add(tipoT);
            }
            return this.ListaT;
        }

        public List<T> Remover(T tipoT)
        {
            if(!(tipoT is null))
            {
                foreach (T item in this.ListaT)
                {
                    if(item.Equals(tipoT))
                    {
                        this.ListaT.Remove(item);
                        break;
                    }
                }
            }
            return this.ListaT;
        }

        public override string ToString()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"{this.TipoU}");
            foreach (T item in this.ListaT)
            {
                str.AppendLine(item.ToString());
            }
            return str.ToString();
        }

        public bool Serializar(String nombreArchivo)
        {
            String rutaCompleta = ClaseGenerica<T, U>.ruta + "_" + nombreArchivo + ".xml";
            bool ret = false;

            try
            {
                if (!Directory.Exists(ClaseGenerica<T, U>.ruta))
                {
                    Directory.CreateDirectory(ClaseGenerica<T, U>.ruta);
                }

                using (StreamWriter sw = new(rutaCompleta))
                {
                    XmlSerializer xmlAux = new(typeof(ClaseGenerica<T, U>));
                    xmlAux.Serialize(sw, this);
                }

                ret = true;
            }
            catch(Exception ex)
            {
                throw new SerializadoXmlException($"Error al serializar ClaseGenerica en .xml\nError tipo: {ex.Message}", ex);
            }
            return ret;
        }

        public bool Deserializar(String nombreArchivo , out ClaseGenerica<T,U> generico)
        {
            string archivo = string.Empty;
            ClaseGenerica<T, U> genericoRetornado = default;
            String[] archivosGuardadosEnCarpetaDeRuta;
            bool ret = false;

            try
            {
                if (Directory.Exists(ClaseGenerica<T, U>.ruta))
                {
                    archivosGuardadosEnCarpetaDeRuta = Directory.GetFiles(ClaseGenerica<T, U>.ruta);
                    foreach (String file in archivosGuardadosEnCarpetaDeRuta)
                    {
                        if (file == nombreArchivo)
                        {
                            archivo = file;
                            break;
                        }
                    }

                    if (!String.IsNullOrWhiteSpace(archivo))
                    {
                        using (StreamReader str = new StreamReader(archivo))
                        {
                            XmlSerializer xmlAux = new XmlSerializer(typeof(ClaseGenerica<T, U>));
                            genericoRetornado = ((ClaseGenerica<T, U>)xmlAux.Deserialize(str));
                            ret = true;
                        }
                    }
                }
            }    
            catch(Exception ex)
            {
                throw new SerializadoXmlException($"Error al Deserializar en la clase ClaseGenerica\nError: {ex.Message}", ex);
            }

            generico = genericoRetornado;
            return ret;
        }
    }
}
