using System;

namespace Manejo.EntidadesDTO
{
    public class FacturaDTO
    {
        private string dni_cliente;
        private int id_reparacion;
        private object value;
        public int IdFacturaDTO { get; set; }

        public DateTime FechaDTO { get; set; }
        public string DniClienteDTO { get; set; }
        public int? IdReparacionDTO { get; set; }

        public ReparacionDTO ReparacionDTO { get; set; }

        public FacturaDTO() { }

        public FacturaDTO(DateTime fechaDTO, string dniClienteDTO, int? idReparacionDTO, ReparacionDTO reparacionDTO)
        {
            FechaDTO = fechaDTO;
            DniClienteDTO = dniClienteDTO;
            IdReparacionDTO = idReparacionDTO;
            ReparacionDTO = reparacionDTO;
        }

        public FacturaDTO(DateTime fecha, string dni_cliente, int id_reparacion)
        {
            this.dni_cliente = dni_cliente;
            this.id_reparacion = id_reparacion;
            this.FechaDTO = fecha;
        }

        public FacturaDTO(int id_factura, DateTime fecha, string dni_cliente, int id_reparacion, object value)
        {
            this.dni_cliente = dni_cliente;
            this.id_reparacion = id_reparacion;
            this.value = value;
        }
    }
}
