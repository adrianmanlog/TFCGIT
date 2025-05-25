using Datos.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Repositorios
{
    public class ClientesRepository
    {
        public List<Clientes> ObtenerClientes()
        {
            List<Clientes> clientes = new List<Clientes>();
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities1())
                {
                    clientes = contexto.Clientes.ToList();
                }
                return clientes;
            }
            catch (Exception)
            {
                return clientes;
            }
        }

        public bool InsertarCliente(Clientes cliente)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities1())
                {
                    contexto.Clientes.Add(cliente);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ModificarCliente(Clientes cliente)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities1())
                {
                    var clienteExistente = contexto.Clientes.FirstOrDefault(c => c.dni == cliente.dni);
                    if (clienteExistente != null)
                    {
                        clienteExistente.nombre = cliente.nombre;
                        clienteExistente.apellido = cliente.apellido;
                        clienteExistente.correo_electronico = cliente.correo_electronico;
                        clienteExistente.telefono = cliente.telefono;
                        clienteExistente.domicilio = cliente.domicilio;
                        clienteExistente.codigo_postal = cliente.codigo_postal;
                        clienteExistente.dni_usuario = cliente.dni_usuario;

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

        public bool EliminarCliente(string dni)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities1())
                {
                    var cliente = contexto.Clientes.FirstOrDefault(c => c.dni == dni);
                    if (cliente != null)
                    {
                        contexto.Clientes.Remove(cliente);
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
