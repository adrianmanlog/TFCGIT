using Datos.Infraestructure;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Repositorios
{
    public class UsuariosRepository
    {
        public List<Usuarios> ObtenerUsuarios()
        {
            List<Usuarios> usuarios = new List<Usuarios>();
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    usuarios = contexto.Usuarios.ToList();
                }
                return usuarios;
            }
            catch (Exception)
            {
                return usuarios;
            }
        }

        public bool InsertarUsuario(Usuarios usuario)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    contexto.Usuarios.Add(usuario);
                    contexto.SaveChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool ModificarUsuario(Usuarios usuario)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    var existente = contexto.Usuarios.FirstOrDefault(u => u.dni == usuario.dni);
                    if (existente != null)
                    {
                        existente.nombre = usuario.nombre;
                        existente.apellido = usuario.apellido;
                        existente.correo_electronico = usuario.correo_electronico;
                        existente.contraseña = usuario.contraseña;

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

        public bool EliminarUsuario(string dni)
        {
            try
            {
                using (var contexto = new reparaciones_gorostiagaEntities())
                {
                    var usuario = contexto.Usuarios.FirstOrDefault(u => u.dni == dni);
                    if (usuario != null)
                    {
                        contexto.Usuarios.Remove(usuario);
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
        public List<string> ObtenerDnisUsuarios()
        {
            using (var contexto = new reparaciones_gorostiagaEntities())
            {
                return contexto.Usuarios.Select(u => u.dni).ToList();
            }
        }
    }
}
