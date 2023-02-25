using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_Archivos_Neiner
{
    class Serializacion
    {
        /*Se guarda la data con un formato especifico, para recuperar data de manera mas facil
         no es dependiente de un so o lenguaje en particular, esto independiza y permite recuperar
        la data desde distintos dispositivos.
        
         Serializarlo seria sacarle una foto a un objeto determinado, y guardarlo en bytes digamos
        esa foto solo se podran recuperar estados, atributos y propiedades, los metodos no se guardan!!
        
         Sirve para pasar a otro proceso
        a otro lenguaje
        a otra maquina
        grabarlo en un disco
        grabarlo en una base de datos etc..
        */

        /*Formatters:
        
        el framework nos brinda las clases para serializar o deserializar, todas son multiplataforma
        en .net...

        Serializacion a XML, incluye propiedades y atributos publicos, es un lenguaje de etiquetas
                    como html, y estas dejan guardar distintos tipos de datos y guardar la info ahi,estas
                    etiquetas si serializo en c# al deserializarlo en otro lenguaje va a buscar el tipo
                    equivalente en ese lenguaje, brinda esto de multiplataforma al extremo. La cagada es
                    que xml solo lee atributos publicos o propiedades de lectura y escritura publicas.Si no
                    son publicos, fuiste!

        Serializacion eb JSON: Es una notacion de objetos generada en javaScript, es un estandard de como se debe
                    escribir x objeto, con sus atributos y valores, este es muy sencillo para interpretar tanto
                    por nosotros como por la maquina, es multiplataforma, convierte al equivalente de
                    su tipo de dato, onda de donde lo escribo a donde lo leo...
                    La cagada es que JSON 

        Java script object notation: 
         */


        /*                           
         * Serializacion XML:
         * 
         * Para serializar: Clase XmlSerializer , metodos Serialize, Deserialize
         * 
         * Cumple los estandard W3C
         * 
         * XmlSerializer(typeof(tipoDato))
         * 
         * Serialize(Stream stream , ruta) , si o si atributos publicos y un constructor vacio publico!!
         * para serializar se necesita un objeto que sepa escribir a xml, el XmlTextWriter lo hace
         * 
         * using(XmlTextWriter writer = new("ruta nombreArchivo.xml",System.Text.Encoding.UTF8), la codificacion va si o si!!!
        {
                ***primero escribo, despues creo el objeto serializador pasandole el tipo y despues le paso al metodo serialize, el escritor y el objeto a guardar
                
                XmlSerializer ser = new(typeof(objeto)); //aca con cuidado, que valida y lanza 800 excepciones sino
            
                ser.Serialize(writer,objeto);
        }* 
         * Deserialize(ruta);
         */


        /*
         * Serializacion JSON
         * 
         * Es de facil lectura, liviano, trabaja con valoires clave valor.         
         * Es multiplataforma ya que como js deciende de C, todo lo que labure con C, c#,php,java etc, lo soporta
         * y puede procesarlo.       
         * Se usa principalmente para transferencia de datos en la web
         * 
         * 
         * Todas las hgerramientas estan en namespace System.Text.Json
         * 
         * Es mas facil de manipular, se serializa solo con el jSonSerializer.Serialize(obj), sin type ni nada
         * esto me devuelve un string y eso lo guardo en un archivo como se me cante el orto, o lo muestro y fue
         
         
         ****Dato: para que json labure, los objetos que quieras serializar tienen que tener si o si propiedades!!!
         *sino no los serializa, no importa que los atributos sean publicos, si o si propiedades get publicas, las
         *sets si bien son necesarias, puede serializarlo solo con gets, pero se recomienda dejarles gets , sets, publicos!!!
         *
         *pero si puede trabajar sin la necesidad de que la clase sea publica y no tenga constructor por default, siempre
         *y cuando tenga propiedades get
         *
         
         ****AGREGAR OPCIONES DE IDENTACION, ASI NO SE VE TODO EN UNA LINEA...
         */
    }
}
