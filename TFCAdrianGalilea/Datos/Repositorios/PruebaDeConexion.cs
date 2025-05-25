using Datos.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositorios
{
    public class PruebaDeConexion
    {
        public Boolean ProbarConexion()
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities1())
                {
                    List<Clientes> productos = contexto.Clientes.ToList();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

    }
}
