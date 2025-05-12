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
    public class ClienteController
    {
        private readonly ClientesRepository repo = new ClientesRepository();

        public bool InsertarCliente(ClienteDTO dto)
        {
            var cliente = new Clientes
            {
                dni = dto.DniDTO,
                nombre = dto.NombreDTO,
                apellido = dto.ApellidoDTO,
                correo_electronico = dto.CorreoElectronicoDTO,
                telefono = dto.TelefonoDTO,
                domicilio = dto.DomicilioDTO,
                codigo_postal = dto.CodigoPostalDTO,
                dni_usuario = dto.DniUsuarioDTO
            };
            return repo.InsertarCliente(cliente);
        }

        public bool ModificarCliente(ClienteDTO dto)
        {
            var cliente = new Clientes
            {
                dni = dto.DniDTO,
                nombre = dto.NombreDTO,
                apellido = dto.ApellidoDTO,
                correo_electronico = dto.CorreoElectronicoDTO,
                telefono = dto.TelefonoDTO,
                domicilio = dto.DomicilioDTO,
                codigo_postal = dto.CodigoPostalDTO,
                dni_usuario = dto.DniUsuarioDTO
            };
            return repo.ModificarCliente(cliente);
        }

        public bool EliminarCliente(string dni)
        {
            return repo.EliminarCliente(dni);
        }

        public List<ClienteDTO> ObtenerClientes()
        {
            return repo.ObtenerClientes()
                       .Select(c => new ClienteDTO(
                           c.dni, c.nombre, c.apellido, c.correo_electronico,
                           c.telefono, c.domicilio, c.codigo_postal, c.dni_usuario))
                       .ToList();
        }
    }
}
