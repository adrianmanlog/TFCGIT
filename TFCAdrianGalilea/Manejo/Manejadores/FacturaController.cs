using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo.Manejadores
{
    using Datos.Infraestructure;
    using Datos.Repositorios;
    using Manejo.EntidadesDTO;
    using System.Collections.Generic;
    using System.Linq;

    namespace Controladores
    {
        public class FacturaController
        {
            private readonly FacturaRepository repo = new FacturaRepository();

            public bool InsertarFactura(FacturaDTO dto)
            {
                var factura = new Factura
                {
                    fecha = dto.FechaDTO,
                    dni_cliente = dto.DniClienteDTO,
                    id_reparacion = dto.IdReparacionDTO
                };
                return repo.InsertarFactura(factura);
            }

            public bool ModificarFactura(FacturaDTO dto)
            {
                var factura = new Factura
                {
                    id_factura = dto.IdFacturaDTO,
                    fecha = dto.FechaDTO,
                    dni_cliente = dto.DniClienteDTO,
                    id_reparacion = dto.IdReparacionDTO
                };
                return repo.ModificarFactura(factura);
            }

            public bool EliminarFactura(int id)
            {
                return repo.EliminarFactura(id);
            }

            public List<FacturaDTO> ObtenerFacturasPorDniCliente(string dniCliente)
            {
                var facturas = repo.ObtenerFacturasPorDniCliente(dniCliente);

                return facturas.Select(f => new FacturaDTO
                {
                    IdFacturaDTO = f.id_factura,
                    FechaDTO = f.fecha,
                    DniClienteDTO = f.dni_cliente,
                    IdReparacionDTO = (int)f.id_reparacion
                }).ToList();
            }

            public FacturaDTO ObtenerFacturaPorId(int idFactura)
            {
                var factura = repo.ObtenerFacturaPorId(idFactura);
                if (factura == null) return null;

                ReparacionDTO reparacionDTO = null;

                if (factura.Reparaciones != null)
                {
                    var reparacion = factura.Reparaciones;
                    reparacionDTO = new ReparacionDTO(
                        reparacion.id_reparacion,
                        reparacion.fecha,
                        reparacion.modelo_vehiculo,
                        reparacion.matricula_vehiculo,
                        reparacion.descripcion,
                        (decimal)reparacion.precio,
                        reparacion.dni_cliente
                    );
                }

                return new FacturaDTO(
                    factura.id_factura,
                    factura.fecha,
                    factura.dni_cliente,
                    factura.id_reparacion ?? 0,
                    reparacionDTO
                );
            }

            public List<FacturaDTO> ObtenerFacturas()
            {
                var facturas = repo.ObtenerFacturas();

                return facturas.Select(f =>
                {
                    ReparacionDTO reparacionDTO = null;

                    if (f.Reparaciones != null)
                    {
                        reparacionDTO = new ReparacionDTO(
                            f.Reparaciones.id_reparacion,
                            f.Reparaciones.fecha,
                            f.Reparaciones.modelo_vehiculo,
                            f.Reparaciones.matricula_vehiculo,
                            f.Reparaciones.descripcion,
                            (decimal)f.Reparaciones.precio,
                            f.Reparaciones.dni_cliente
                        );
                    }

                    return new FacturaDTO
                    {
                        IdFacturaDTO = f.id_factura,
                        FechaDTO = f.fecha,
                        DniClienteDTO = f.dni_cliente,
                        IdReparacionDTO = f.id_reparacion,
                        ReparacionDTO = reparacionDTO
                    };
                }).ToList();
            }

        }
    }

}
