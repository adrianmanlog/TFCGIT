using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo.Manejadores
{
    public class PruebaDeConexion
    {
        public Boolean GetPruebaDeConexion()
        {
            return new Datos.Repositorios.PruebaDeConexion().ProbarConexion();
        }

    }
}
