using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnciendanSusMotores3._0
{
    public class Competencia
    {
        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private static Random auxR;
        private TipoCompetencia tipo;

        public List<VehiculoDeCarrera> Competidores
        {
            get { return this.competidores; }
        }
        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }

        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public VehiculoDeCarrera this[Int32 index]
        {
            get { return this.competidores[index]; }
            set { this.competidores[index] = value; }
        }

        public TipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }

        static Competencia()
        {
            Competencia.auxR = new Random();
        }

        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }

        public Competencia(short cantCompe, short cantidVuelta, TipoCompetencia tipo) : this()
        {
            this.CantidadCompetidores = cantCompe;
            this.CantidadVueltas = cantidVuelta;
            this.Tipo = tipo;
        }

        public String MostrarDatos()
        {
            StringBuilder str = new StringBuilder();

            str.AppendLine($"Tipo competencia: {Enum.GetName(this.Tipo)}\nCantidad Competidores: {this.cantidadCompetidores}\nCantidad Vueltas: {this.cantidadVueltas}");
            if (this.competidores.Count > 0)
            {
                foreach (VehiculoDeCarrera item in this.competidores)
                {
                    str.AppendLine(item.MostrarDatos());
                }
            }
            else
            {
                str.AppendLine("Sin competidores al momento..");
            }

            return str.ToString();
        }

        public static bool operator ==(Competencia com, VehiculoDeCarrera v)
        {
            bool ret = false;
            Int32 tipo = (Int32)com.Tipo;

            if (!(com is null) && !(v is null))
            {
                if (tipo == 0 && v is AutoF1 || tipo == 1 && v is MotoCross)
                {
                    foreach (VehiculoDeCarrera item in com.competidores)
                    {
                        if (item.Equals(v))
                        {
                            ret = true;
                            break;
                        }
                    }
                }
                else
                {
                    throw new CompetenciaNoDisponibleException("El vehiculo no corresponde a la competencia..", (v.GetType().Name).ToString(), "Metodo == Competencia" );
                }              
            } 
            return ret;
        }

        public static bool operator !=(Competencia com, VehiculoDeCarrera v)
        {
            return !(com == v);
        }

        public static bool operator +(Competencia com, VehiculoDeCarrera v)
        {
            bool ret = false;

            if (!(com is null) && !(v is null))
            {
                if (com.competidores.Count + 1 <= com.cantidadCompetidores)
                {
                    try
                    {
                        if(com != v)
                        {
                            v.CantidadCombustible = (short)Competencia.auxR.Next(15, 100);
                            v.EnCompetencia = true;
                            v.VueltasRestantes = com.cantidadVueltas;
                            com.competidores.Add(v);
                            ret = true;
                        }
                    }
                    catch(CompetenciaNoDisponibleException ex)
                    {
                        throw new CompetenciaNoDisponibleException("Competencia incorrecta..", (com.GetType().Name).ToString(), "Metodo + Competencia", ex);
                    }
                }
            }
            return ret;
        }

        public static bool operator -(Competencia com, VehiculoDeCarrera v)
        {
            bool ret = false;
            Int32 counter;

            //if (!(com is null) && !(au is null))
            //{
            if (com == v)
            {
                counter = 0;
                foreach (VehiculoDeCarrera item in com.competidores)
                {
                    if (item == v)
                    {
                        com.competidores.RemoveAt(counter);
                        ret = true;
                        break;
                    }
                    counter++;
                }
            }
            //}
            return ret;
        }
    }
}
