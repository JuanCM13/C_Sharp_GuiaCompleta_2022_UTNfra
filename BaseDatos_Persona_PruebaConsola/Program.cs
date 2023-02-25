using System;
using MiPrimerCruz_BaseDatos;
using System.Collections.Generic;

namespace BaseDatos_Persona_PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonaDAO per = new();
            List<Persona> auxListado;

            if( !per.ProbarConexion())                      //prueba conexion
            {
                Console.WriteLine("No funco");
            }
            else
            {
                auxListado = per.Leer();                        //prueba lectura

                try
                {

                    if (auxListado.Count > 0)
                    {
                        foreach(Persona item in auxListado)
                        {
                            Console.WriteLine(item);
                        }

                        /*Console.WriteLine("Oprima cualquier letra para testear Guardado");
                        Console.ReadKey();
                        Console.Clear();

                        if (per.Guardar(new Persona("Matias", "Spartan")))  //prueba guardado
                        {
                            Console.WriteLine("PASO LA PRUEBA GUARDADO..");

                            auxListado = per.Leer(); //si pasa el guardado, la muestro para ver cambios
                            foreach(Persona item in auxListado)
                            {
                                Console.WriteLine(item);
                            }
                        }*/

                        Console.WriteLine("Oprima cualquier letra para testear Busqueda por ID");
                        Console.ReadKey();
                        Console.Clear();

                        Persona auxPersona = per.LeerPorID(4);
                        Console.WriteLine("PASO PRUEBA DE BUSQUEDA POR ID");
                        Console.WriteLine(auxPersona);

                        Console.WriteLine("Oprima cualquier letra para testear Modificacion por ID");
                        Console.ReadKey();
                        Console.Clear();

                        if (!per.ModificarPorID(3, "Usuario Modificado", "Modificated"))
                        {
                            Console.WriteLine("Fallo el metodo ModificarPorID");
                        }
                        else
                        {
                            Console.WriteLine("PASO PRUEBA DE MODIFICACION POR ID");
                            foreach (Persona item in per.Leer())
                            {
                                Console.WriteLine(item);
                            }
                        }

                        Console.WriteLine("Oprima cualquier letra para testear Eliminacion por ID");
                        Console.ReadKey();
                        Console.Clear();

                        if ( !per.Borrar(6))
                        {
                            Console.WriteLine("Fallo la eliminacion por ID");
                        }
                        else
                        {
                            Console.WriteLine("PASO PRUEBA DE ELIMINACION POR ID");
                            foreach (Persona item in per.Leer())
                            {
                                Console.WriteLine(item);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sin elementos al momento");
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Fallo critico\n{0}",ex.Message);                    
                }
                
            }
        }
    }
}
