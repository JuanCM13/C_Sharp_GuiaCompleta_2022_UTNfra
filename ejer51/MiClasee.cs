using System;

namespace ExcepcionesEjer1
{
    public class MiClasee
    {
        public MiClasee()
        {
            try
            {
                MiClasee.LanzarExcepcion();
            }
            catch(DivideByZeroException ex)
            {
                MiClasee mc = new MiClasee(ex);
            }

        }

        public MiClasee(DivideByZeroException ex)
        {
            throw new UnaExcepcion("Error de tipo UnaExcepcion!" , ex);
        }

        public static MiClasee LanzarExcepcion()
        {
            throw new DivideByZeroException();
        }
    }
}
