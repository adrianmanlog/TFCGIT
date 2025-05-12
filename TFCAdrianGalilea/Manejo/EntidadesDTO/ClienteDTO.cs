using System;

namespace Manejo.EntidadesDTO
{
    public class ClienteDTO
    {
        public string DniDTO { get; set; }
        public string NombreDTO { get; set; }
        public string ApellidoDTO { get; set; }
        public string CorreoElectronicoDTO { get; set; }
        public string TelefonoDTO { get; set; }
        public string DomicilioDTO { get; set; }
        public string CodigoPostalDTO { get; set; }
        public string DniUsuarioDTO { get; set; }

        public ClienteDTO() { }

        public ClienteDTO(string dniDTO, string nombreDTO, string apellidoDTO, string correoElectronicoDTO, string telefonoDTO, string domicilioDTO, string codigoPostalDTO, string dniUsuarioDTO)
        {
            DniDTO = dniDTO;
            NombreDTO = nombreDTO;
            ApellidoDTO = apellidoDTO;
            CorreoElectronicoDTO = correoElectronicoDTO;
            TelefonoDTO = telefonoDTO;
            DomicilioDTO = domicilioDTO;
            CodigoPostalDTO = codigoPostalDTO;
            DniUsuarioDTO = dniUsuarioDTO;
        }
    }
}
