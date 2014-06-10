using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MF0493_3.Models;

namespace PruebasUnitarias
{
    [TestClass]
    public class EmpresaManagerTest
    {
        [TestMethod]
        public void GetTest()
        {
            Empresa emp = EmpresaManager.get("75719295Y");
            Assert.AreEqual(emp.nombre, "nector");
        }

        [TestMethod]
        public void NuevaTest()
        {
            
            Empresa emp = new Empresa();
            emp.nombre = "nector";
            emp.nif = "75719295Y";
            bool creada = EmpresaManager.Nueva(emp);
            Assert.AreEqual(creada, true);
            bool eliminado = EmpresaManager.Eliminar("75719295Y");
            /*Empresa empresa = EmpresaManager.get("75723521T");
            Assert.AreEqual(empresa.nombre, "Laura");*/
        }

        [TestMethod]
        public void ModificarTest()
        {
            Empresa emp = new Empresa();
            emp.nif = "75719295Y";
            emp.nombre = "Pepe";

            bool modificada = EmpresaManager.Modificar(emp);
            Assert.AreEqual(modificada, true);
            Empresa empresa = EmpresaManager.get("75719295Y");
            Assert.AreEqual(empresa.nombre, "Pepe");
        }

        [TestMethod]
        public void EliminarTest()
        {

            bool eliminado = EmpresaManager.Eliminar("75719295Y");
            Assert.AreEqual(eliminado, true);

        }

    }
}
