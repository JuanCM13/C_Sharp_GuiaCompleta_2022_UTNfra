using System;

namespace Entidades_Archivos_Neiner
{
    public class Class1
    {
        /*Archivos de texto, se suede usar, es texto plano que se guarda sobre un documento que no
         tiene formato,el formato se lo  tenemos que dar nosotros, donde colocar cada informacion
        asi, despues podemos serializarlo o recuperar la info, sino seria casi imposible ya que no
        tiene un formato, sino que es texto plano en un archivo...*/

        /*streamWriter y StreamReader, using System.IO*/

        /*anteponer el using cierra automaticamente el archivo, recordar clase del sabado de archivos..
         * no tiene nada que ver con el using para incluir biblios, es un bloque de codigo, onda un if, while etc
         * que dentro de este, el objeto que vaya a crear, cualquier objeto, garantiza que al llegar a la llave de
         * cierre de este bloque, el bloque invoca al dispose, que se encarga de cerrar las conexiones que esten
         * abiertas por el bloque, en este caso si abro el archivo, lo cierra...
            es como si englobara entre llaves.. sino usar el .Close() al finalizar de usarlo*/

        /*recordar poner la \\ para que tome las secuencias de escape..
         sino uso el @ y le indico que no voy a usar secuencias de escape... mejor usar este..*/

        /*Archivos, bases de datos etc son propensos a lanzar excepciones, englobar en catch al utilizarlos..*/
    }
}
