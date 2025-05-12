using Datos.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Repositorios
{
    public class ReparacionesRepository
    {
        public List<Reparaciones> ObtenerReparaciones()
        {
            List<Reparaciones> reparaciones = new List<Reparaciones>();
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    reparaciones = contexto.Reparaciones.ToList();
                }
                return reparaciones;
            }
            catch (Exception)
            {
                return reparaciones;
            }
        }

        public bool InsertarReparacion(Reparaciones reparacion)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    contexto.Reparaciones.Add(reparacion);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ModificarReparacion(Reparaciones reparacion)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    var existente = contexto.Reparaciones.FirstOrDefault(r => r.id_reparacion == reparacion.id_reparacion);
                    if (existente != null)
                    {
                        existente.fecha = reparacion.fecha;
                        existente.modelo_vehiculo = reparacion.modelo_vehiculo;
                        existente.matricula_vehiculo = reparacion.matricula_vehiculo;
                        existente.descripcion = reparacion.descripcion;
                        existente.precio = reparacion.precio;
                        existente.dni_cliente = reparacion.dni_cliente;

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

        public bool EliminarReparacion(int idReparacion)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    var reparacion = contexto.Reparaciones.FirstOrDefault(r => r.id_reparacion == idReparacion);
                    if (reparacion != null)
                    {
                        contexto.Reparaciones.Remove(reparacion);
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
        public Reparaciones ObtenerReparacionPorId(int idReparacion)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    var reparacion = contexto.Reparaciones.FirstOrDefault(r => r.id_reparacion == idReparacion);
                    return reparacion;
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
