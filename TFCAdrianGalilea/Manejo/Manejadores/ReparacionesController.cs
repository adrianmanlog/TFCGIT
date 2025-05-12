using Datos.Infraestructure;
using Datos.Repositorios;
using Manejo.EntidadesDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo.Manejadores
{
    public class ReparacionesController
    {
        private readonly ReparacionesRepository repo = new ReparacionesRepository();

        public bool InsertarReparacion(ReparacionDTO dto)
        {
            var reparacion = new Reparaciones
            {
                fecha = dto.FechaDTO,
                modelo_vehiculo = dto.ModeloVehiculoDTO,
                matricula_vehiculo = dto.MatriculaVehiculoDTO,
                descripcion = dto.DescripcionDTO,
                precio = (decimal?)dto.PrecioDTO,
                dni_cliente = dto.DniClienteDTO
            };
            return repo.InsertarReparacion(reparacion);
        }

        public bool ModificarReparacion(ReparacionDTO dto)
        {
            var reparacion = new Reparaciones
            {
                id_reparacion = dto.IdReparacionDTO,
                fecha = dto.FechaDTO,
                modelo_vehiculo = dto.ModeloVehiculoDTO,
                matricula_vehiculo = dto.MatriculaVehiculoDTO,
                descripcion = dto.DescripcionDTO,
                precio = (decimal?)dto.PrecioDTO,
                dni_cliente = dto.DniClienteDTO
            };
            return repo.ModificarReparacion(reparacion);
        }

        public bool EliminarReparacion(int id)
        {
            return repo.EliminarReparacion(id);
        }

        public List<ReparacionDTO> ObtenerReparaciones()
        {
            return repo.ObtenerReparaciones()
                       .Select(r => new ReparacionDTO(
                           r.id_reparacion, r.fecha, r.modelo_vehiculo,
                           r.matricula_vehiculo, r.descripcion, (decimal)r.precio, r.dni_cliente))
                       .ToList();
        }
        public ReparacionDTO ObtenerReparacionPorId(int idReparacion)
        {
            var reparacion = repo.ObtenerReparacionPorId(idReparacion);

            if (reparacion != null)
            {
                return new ReparacionDTO(
                    reparacion.id_reparacion,
                    reparacion.fecha,
                    reparacion.modelo_vehiculo,
                    reparacion.matricula_vehiculo,
                    reparacion.descripcion,
                    (decimal)reparacion.precio,
                    reparacion.dni_cliente
                );
            }
            return null;
        }
    }
}
