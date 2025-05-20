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
    public class UsuarioController
    {
        private readonly UsuariosRepository repo = new UsuariosRepository();

        public bool InsertarUsuario(UsuarioDTO dto)
        {
            var usuario = new Usuarios
            {
                dni = dto.DniDTO,
                nombre = dto.NombreDTO,
                apellido = dto.ApellidoDTO,
                correo_electronico = dto.CorreoElectronicoDTO,
                contraseña = dto.ContraseñaDTO
            };
            return repo.InsertarUsuario(usuario);
        }

        public bool ModificarUsuario(UsuarioDTO dto)
        {
            var usuario = new Usuarios
            {
                dni = dto.DniDTO,
                nombre = dto.NombreDTO,
                apellido = dto.ApellidoDTO,
                correo_electronico = dto.CorreoElectronicoDTO,
                contraseña = dto.ContraseñaDTO
            };
            return repo.ModificarUsuario(usuario);
        }

        public bool EliminarUsuario(string dni)
        {
            return repo.EliminarUsuario(dni);
        }

        public List<UsuarioDTO> ObtenerUsuarios()
        {
            return repo.ObtenerUsuarios()
                       .Select(u => new UsuarioDTO(u.dni, u.nombre, u.apellido, u.correo_electronico, u.contraseña))
                       .ToList();
        }
        public List<string> ObtenerDnisUsuarios()
        {
            return repo.ObtenerDnisUsuarios();
        }
        public List<string> ObtenerCorreosUsuarios()
        {
            return repo.ObtenerCorreosUsuarios();
        }

        public bool ValidarCredenciales(string dni, string contraseña)
        {
            var usuarios = repo.ObtenerUsuarios();
            var usuario = usuarios.FirstOrDefault(u => u.dni == dni);

            return usuario != null && usuario.contraseña == contraseña;
        }
    }
}
