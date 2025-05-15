using Microsoft.VisualStudio.TestTools.UnitTesting;
using Manejo.Manejadores.Controladores;
using Manejo.Manejadores;
using Manejo.EntidadesDTO;
namespace TestTFC
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ClienteDTO cliente = new ClienteDTO("14778945G","pruebas","unittes","pruebas@gmail.com","458798564","avenida burgos","26007","16636730W");

            // Arrange
            var controlador = new ClienteController();

            // Act
            var resultado = controlador.InsertarCliente(cliente);

            // Assert
            Assert.AreEqual(true, resultado);
        }
    }
}
