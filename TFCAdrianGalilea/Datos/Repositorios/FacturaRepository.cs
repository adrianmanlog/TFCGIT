using Datos.Infraestructure;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Repositorios
{
    public class FacturaRepository
    {
        public List<Factura> ObtenerFacturas()
        {
            List<Factura> facturas = new List<Factura>();
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    facturas = contexto.Factura.Include(f => f.Reparaciones).ToList();
                }
                return facturas;
            }
            catch (Exception)
            {
                return facturas;
            }
        }
        public List<Factura> ObtenerFacturasPorDniCliente(string dniCliente)
        {
            List<Factura> facturas = new List<Factura>();
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    facturas = contexto.Factura
                        .Include(f => f.Reparaciones)
                        .Where(f => f.dni_cliente == dniCliente)
                        .ToList();
                }
                return facturas;
            }
            catch (Exception)
            {
                return facturas;
            }
        }

        public Factura ObtenerFacturaPorId(int idFactura)
        {
            using (var contexto = new reparaciones_gorostiagaEntities())
            {
                return contexto.Factura
                    .Include(f => f.Reparaciones)
                    .FirstOrDefault(f => f.id_factura == idFactura);
            }
        }
        public bool InsertarFactura(Factura factura)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    contexto.Factura.Add(factura);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ModificarFactura(Factura factura)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    var existente = contexto.Factura.FirstOrDefault(f => f.id_factura == factura.id_factura);
                    if (existente != null)
                    {
                        existente.fecha = factura.fecha;
                        existente.dni_cliente = factura.dni_cliente;
                        existente.id_reparacion = factura.id_reparacion;

                        contexto.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EliminarFactura(int idFactura)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    var factura = contexto.Factura.FirstOrDefault(f => f.id_factura == idFactura);
                    if (factura != null)
                    {
                        contexto.Factura.Remove(factura);
                        contexto.SaveChanges();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
