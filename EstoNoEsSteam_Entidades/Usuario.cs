using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoNoEsSteam_Entidades
{
    public class Usuario
    {
        private Int32 codigoUsuario;
        private String userName;

        public Int32 CodigoUsuario
        {
            get { return this.codigoUsuario; }
        }

        public Usuario(String userName , Int32 codigoUsuario)
        {
            this.codigoUsuario = codigoUsuario;
            this.userName = userName;
        }

        public override string ToString()
        {
            return this.userName;
        }
    }
}
