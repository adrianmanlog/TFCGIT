using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manejo.Manejadores.Controladores;
using Manejo.Manejadores;
using Manejo.EntidadesDTO;
using System;
namespace TestTFC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void InsertarCliente()
        {
            ClienteDTO cliente = new ClienteDTO("14778945G","pruebas","unittes","pruebas@gmail.com","458798564","avenida burgos","26007","16636730W");

            // Arrange
            var controlador = new ClienteController();

            // Act
            var resultado = controlador.InsertarCliente(cliente);

            // Assert
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void InsertarCliente_Nulo()
        {
            var controlador = new ClienteController();
            ClienteDTO cliente = null;

            var resultado = controlador.InsertarCliente(cliente);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void InsertarCliente_DniVacio()
        {
            var controlador = new ClienteController();
            ClienteDTO cliente = new ClienteDTO("", "adrian", "galilea", "test@test.com", "123456", "avnd", "00000", "99999999X");

            var resultado = controlador.InsertarCliente(cliente);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void InsertarCliente_DniDuplicado()
        {
            var controlador = new ClienteController();
            ClienteDTO cliente = new ClienteDTO("16636730W", "adrian", "galilea", "email@test.com", "123456", "direccion", "00000", "99999999X");

            controlador.InsertarCliente(cliente);

            var resultado = controlador.InsertarCliente(cliente);

            Assert.AreEqual(false, resultado);
        }


        [TestMethod]
        public void ModificarCliente()
        {
            ClienteDTO cliente = new ClienteDTO("14778945G", "Modificar", "modificar", "pruebas@gmail.com", "458798564", "avenida burgos", "26007", "16636730W");

            // Arrange
            var controlador = new ClienteController();

            // Act
            var resultado = controlador.ModificarCliente(cliente);

            // Assert
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void ModificarCliente_DniNoExiste()
        {
            var controlador = new ClienteController();
            ClienteDTO cliente = new ClienteDTO("00000000Z", "adrian", "galilea", "pruebas@test.com", "123456", "avddd", "12345", "99999999X");

            var resultado = controlador.ModificarCliente(cliente);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void EliminarCliente()
        {
            ClienteDTO cliente = new ClienteDTO("14778945G", "pruebas", "unittes", "pruebas@gmail.com", "458798564", "avenida burgos", "26007", "16636730W");

            // Arrange
            var controlador = new ClienteController();

            // Act
            var resultado = controlador.EliminarCliente(cliente.DniDTO);

            // Assert
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void EliminarCliente_DniNoExiste()
        {
            var controlador = new ClienteController();
            string dniInexistente = "00000000Z";

            var resultado = controlador.EliminarCliente(dniInexistente);

            Assert.AreEqual(false, resultado);
        }


        [TestMethod]
        public void InsertarReparacion()
        {
            decimal precio = 1000;
            ClienteDTO cliente = new ClienteDTO("14778945G", "pruebas", "unittes", "pruebas@gmail.com", "458798564", "avenida burgos", "26007", "16636730W");
            ReparacionDTO reparacion = new ReparacionDTO(DateTime.Now,"BMW","1548FGG","Esta es la reparacion test",precio,cliente.DniDTO);
            // Arrange
            var controlador = new ReparacionesController();

            // Act
            var resultado = controlador.InsertarReparacion(reparacion);

            // Assert
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void InsertarReparacion_ClienteNoExiste()
        {
            var controlador = new ReparacionesController();
            ReparacionDTO reparacion = new ReparacionDTO(DateTime.Now, "BMW", "XYZ1234", "Descripción test", 100, "00000000Z");

            var resultado = controlador.InsertarReparacion(reparacion);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void InsertarReparacion_DescripcionVacia()
        {
            var controlador = new ReparacionesController();
            ReparacionDTO reparacion = new ReparacionDTO(DateTime.Now, "BMW", "XYZ1234", "", 100, "14778945G");

            var resultado = controlador.InsertarReparacion(reparacion);

            Assert.AreEqual(false, resultado);
        }


        [TestMethod]
        public void ModificarReparacion()
        {
            decimal precio = 1000;
            ClienteDTO cliente = new ClienteDTO("14778945G", "pruebas", "unittes", "pruebas@gmail.com", "458798564", "avenida burgos", "26007", "16636730W");
            ReparacionDTO reparacion = new ReparacionDTO(7,DateTime.Now, "BMW", "1548FGG", "Prueba de modificar", precio, cliente.DniDTO);
            // Arrange
            var controlador = new ReparacionesController();

            // Act
            var resultado = controlador.ModificarReparacion(reparacion);

            // Assert
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void ModificarReparacion_IdNoExiste()
        {
            var controlador = new ReparacionesController();
            ReparacionDTO reparacion = new ReparacionDTO(9999, DateTime.Now, "BMW", "XYZ1234", "Modificación fallida", 100, "14778945G");

            var resultado = controlador.ModificarReparacion(reparacion);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void EliminarReparacion()
        {
            decimal precio = 1000;
            ClienteDTO cliente = new ClienteDTO("14778945G", "pruebas", "unittes", "pruebas@gmail.com", "458798564", "avenida burgos", "26007", "16636730W");
            ReparacionDTO reparacion = new ReparacionDTO(7, DateTime.Now, "BMW", "1548FGG", "Prueba de modificar", precio, cliente.DniDTO);
            // Arrange
            var controlador = new ReparacionesController();

            // Act
            var resultado = controlador.EliminarReparacion(reparacion.IdReparacionDTO);

            // Assert
            Assert.AreEqual(true, resultado);
        }
        [TestMethod]
        public void EliminarReparacion_IdNoExiste()
        {
            var controlador = new ReparacionesController();
            int idInexistente = 9999;

            var resultado = controlador.EliminarReparacion(idInexistente);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void InsertarFactura()
        {
            decimal precio = 1000;
            ClienteDTO cliente = new ClienteDTO("14778945G", "pruebas", "unittes", "pruebas@gmail.com", "458798564", "avenida burgos", "26007", "16636730W");
            ReparacionDTO reparacion = new ReparacionDTO(7, DateTime.Now, "BMW", "1548FGG", "Prueba de modificar", precio, cliente.DniDTO);
            FacturaDTO factura = new FacturaDTO(DateTime.Now,cliente.DniDTO, reparacion.IdReparacionDTO);

            var controladorcli = new ClienteController();

            // Act
            var resultadocli = controladorcli.InsertarCliente(cliente);

            var controlador = new ReparacionesController();

            // Act
            var resultado = controlador.InsertarReparacion(reparacion);
            // Arrange
            var controlador2 = new FacturaController();

            // Act
            var resultado2 = controlador2.InsertarFactura(factura);

            // Assert
            Assert.AreEqual(true, resultado2);
        }
        [TestMethod]
        public void InsertarFactura_ReparacionNoExiste()
        {
            var controlador = new FacturaController();
            FacturaDTO factura = new FacturaDTO(DateTime.Now, "14778945G", 9999); // ID reparación inexistente

            var resultado = controlador.InsertarFactura(factura);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void InsertarFactura_ClienteNoExiste()
        {
            var controlador = new FacturaController();
            FacturaDTO factura = new FacturaDTO(DateTime.Now, "11111111C", 7); // DNI inexistente

            var resultado = controlador.InsertarFactura(factura);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void ModificarFactura()
        {
            decimal precio = 1000;
            ClienteDTO cliente = new ClienteDTO("14778945G", "pruebas", "unittes", "pruebas@gmail.com", "458798564", "avenida burgos", "26007", "16636730W");
            ReparacionDTO reparacion = new ReparacionDTO(7, DateTime.Now, "BMW", "1548FGG", "Prueba de modificar", precio, cliente.DniDTO);
            FacturaDTO factura = new FacturaDTO(DateTime.Now, cliente.DniDTO, reparacion.IdReparacionDTO);
            // Arrange
            var controlador2 = new FacturaController();
            factura.IdFacturaDTO = 17;
            // Act
            var resultado2 = controlador2.ModificarFactura(factura);

            // Assert
            Assert.AreEqual(true, resultado2);
        }
        [TestMethod]
        public void ModificarFactura_IdNoExiste()
        {
            var controlador = new FacturaController();
            FacturaDTO factura = new FacturaDTO(DateTime.Now, "14778945G", 7);
            factura.IdFacturaDTO = 9999;

            var resultado = controlador.ModificarFactura(factura);

            Assert.AreEqual(false, resultado);
        }

        [TestMethod]
        public void EliminarFactura()
        {
            decimal precio = 1000;
            ClienteDTO cliente = new ClienteDTO("14778945G", "pruebas", "unittes", "pruebas@gmail.com", "458798564", "avenida burgos", "26007", "16636730W");
            ReparacionDTO reparacion = new ReparacionDTO(7, DateTime.Now, "BMW", "1548FGG", "Prueba de modificar", precio, cliente.DniDTO);
            FacturaDTO factura = new FacturaDTO(DateTime.Now, cliente.DniDTO, reparacion.IdReparacionDTO);
            // Arrange
            var controlador2 = new FacturaController();
            factura.IdFacturaDTO = 17;
            // Act
            var resultado2 = controlador2.EliminarFactura(factura.IdFacturaDTO);

            // Assert
            Assert.AreEqual(true, resultado2);
        }
        [TestMethod]
        public void EliminarFactura_IdNoExiste()
        {
            var controlador = new FacturaController();
            int idInexistente = 9999;

            var resultado = controlador.EliminarFactura(idInexistente);

            Assert.AreEqual(false, resultado);
        }

    }
}
