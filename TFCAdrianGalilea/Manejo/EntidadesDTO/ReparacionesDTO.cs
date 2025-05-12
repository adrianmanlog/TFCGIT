using System;

namespace Manejo.EntidadesDTO
{
    public class ReparacionDTO
    {
        public int IdReparacionDTO { get; set; }
        public DateTime FechaDTO { get; set; }
        public string ModeloVehiculoDTO { get; set; }
        public string MatriculaVehiculoDTO { get; set; }
        public string DescripcionDTO { get; set; }
        public decimal PrecioDTO { get; set; }
        public string DniClienteDTO { get; set; }
        public int Id_reparacion { get; }
        public DateTime Fecha { get; }
        public string Modelo_vehiculo { get; }
        public string Matricula_vehiculo { get; }
        public string Descripcion { get; }
        public decimal Precio { get; }
        public string Dni_cliente { get; }

        public ReparacionDTO() { }

        public ReparacionDTO(DateTime fechaDTO, string modeloVehiculoDTO, string matriculaVehiculoDTO, string descripcionDTO, decimal precioDTO, string dniClienteDTO)
        {
            FechaDTO = fechaDTO;
            ModeloVehiculoDTO = modeloVehiculoDTO;
            MatriculaVehiculoDTO = matriculaVehiculoDTO;
            DescripcionDTO = descripcionDTO;
            PrecioDTO = precioDTO;
            DniClienteDTO = dniClienteDTO;
        }

        public ReparacionDTO(int id_reparacion, DateTime fecha, string modelo_vehiculo,string matricula_vehiculo, string descripcion, decimal precio, string dni_cliente)
        {
            IdReparacionDTO = id_reparacion; // ← AÑADE ESTO
            FechaDTO = fecha;
            ModeloVehiculoDTO = modelo_vehiculo;
            MatriculaVehiculoDTO = matricula_vehiculo;
            DescripcionDTO = descripcion;
            PrecioDTO = precio;
            DniClienteDTO = dni_cliente;
        }
    }
}
