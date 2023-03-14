using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Entidad;

namespace Test
{
    public class Class1
    {
    }
   
    public void D_mantenimiento_clientes_Test()
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

        // Act
        string result = D_mantenimiento_clientes(obje);

        
        // Assert
        object value = Assert.AreEqual("Registro insertado correctamente", result);
    }

}
