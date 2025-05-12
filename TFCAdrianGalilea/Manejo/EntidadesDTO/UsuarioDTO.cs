using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manejo.EntidadesDTO
{
    public class UsuarioDTO
    {
        public string DniDTO { get; set; }
        public string NombreDTO { get; set; }
        public string ApellidoDTO { get; set; }
        public string CorreoElectronicoDTO { get; set; }
        public string ContraseñaDTO { get; set; }

        public UsuarioDTO() { }

        public UsuarioDTO(string dniDTO, string nombreDTO, string apellidoDTO, string correoElectronicoDTO, string contraseñaDTO)
        {
            DniDTO = dniDTO;
            NombreDTO = nombreDTO;
            ApellidoDTO = apellidoDTO;
            CorreoElectronicoDTO = correoElectronicoDTO;
            ContraseñaDTO = contraseñaDTO;
        }
    }
}
