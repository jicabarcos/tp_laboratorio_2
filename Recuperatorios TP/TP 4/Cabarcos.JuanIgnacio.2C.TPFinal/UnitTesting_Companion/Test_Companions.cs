using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Entidades;
using Formularios;
using System.IO;
using Entidades.Excepciones;

namespace UnitTesting_Companion
{
    [TestClass]
    public class Test_Companions
    {
        /// <summary>
        /// Test Unitario para probar el correcto funcionamiento de una excepción de tipo FabricaApagadaException.
        /// </summary>
        [TestMethod]
        public void Test_FabricaApagadaException()
        {
            bool response = false;

            if (new FabricaApagadaException("Archivo no válido") != null)
            {
                response = true;
            }

            Assert.IsTrue(response);

        }

        /// <summary>
        /// Test Unitario para el método RealizarGuardadoTxt() de la clase FrmPrincipal.
        /// </summary>
        [TestMethod]
        public void Test_GuardarTxt()
        {
            FrmPrincipal frmPrincipal = new FrmPrincipal();
            
            frmPrincipal.RealizarGuardadoTxt();             

            Assert.IsTrue(File.Exists("Archivos\\listado_companions.txt"));
        }
    }
}
