using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Entidades;
using Formularios;

namespace UnitTesting_Companion
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test Unitario para el método AgregarCompanion() de la clase Factory.
        /// </summary>
        [TestMethod]
        public void Test_AgregarCompanion()
        {
            bool response;
            
            Housekeeper hk = new Housekeeper(new List<ETarea>() { ETarea.Barrer, ETarea.Limpiar, ETarea.Ordenar });
            response = Factory.AgregarCompanionConsola(hk);

            Assert.IsTrue(response);
        }

        /// <summary>
        /// Test Unitario para el método RealizarGuardadoTxt() de la clase FrmPrincipal.
        /// </summary>
        [TestMethod]
        public void Test_GuardarTxt()
        {
            bool response = false;

            FrmPrincipal frmPrincipal = new FrmPrincipal();
            response = frmPrincipal.RealizarGuardadoTxt();

            Assert.IsTrue(response);
        }
    }
}
