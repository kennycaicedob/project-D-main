using Microsoft.VisualStudio.TestTools.UnitTesting;
using Capa_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Datos.Tests
{
    [TestClass()]
    public class ClaseDatosTests
    {
        [TestMethod()]
        public void D_mantenimiento_conductorTest()
        {
            {
                // Arrange
                ClaseEntidad obje = new ClaseEntidad();
                obje.codigo2 = 1;
                obje.nombres = "Juan Perez";
                obje.cedula = "123456789";
                obje.telefono = "1234567";
                obje.cbancaria = "1234567890";
                obje.fnacimiento = "12/11/2001";
                obje.direccion = "Calle 123";
                obje.estado = "Activo";
                obje.servicios = "Ninguno";
                obje.accion2 = "Insertar";

                String resultado = D_mantenimiento_clientes(obje);

                // Assert
                Assert.IsNotNull(resultado);
                Assert.AreNotEqual("", resultado);
                Assert.IsFalse(resultado.StartsWith("Error"));
                // Act
               
            }
        }

        private string D_mantenimiento_clientes(ClaseEntidad obje)
        {
            throw new NotImplementedException();
        }

        [TestMethod()]
        public void D_mantenimiento_clientesTest()
        {
            ClaseEntidad obje = new ClaseEntidad();
            obje.codigo2 = 1;
            obje.nombres = "Juan Perez";
            obje.cedula = "1234567890";
            obje.telefono = "1234567";
            obje.cbancaria = "123456";
            obje.fnacimiento = "12/12/1999";
            obje.direccion = "Calle 123";
            obje.estado = "Activo";
            obje.servicios = "Servicio1";
            obje.accion2 = "Insertar";

            // Act
            String resultado = D_mantenimiento_clientes(obje);

            // Assert
            Assert.IsNotNull(resultado);
            Assert.AreNotEqual("", resultado);
            Assert.IsFalse(resultado.StartsWith("Error"));
            
        }
    }
}