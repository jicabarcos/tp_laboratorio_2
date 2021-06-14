using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Entidades;

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
            
            Housekeeper hk1 = new Housekeeper("HK-DUMMY", 
                new List<ETarea>() { ETarea.Barrer, ETarea.Limpiar, ETarea.Ordenar });

            response = Factory.AgregarCompanion(hk1);

            Assert.IsTrue(response);
        }

        /// <summary>
        /// Test Unitario para el método EliminarCompanion() de la clase Factory.
        /// </summary>
        [TestMethod]
        public void Test_EliminarCompanion()
        {
            bool response;

            Cook c1 = new Cook("C-DUMMY", 
                new List<ETarea>() { ETarea.Barrer, ETarea.Limpiar, ETarea.Ordenar }, 
                new List<EUtensilio>() { EUtensilio.Cubiertos, EUtensilio.Ollas, EUtensilio.Sartenes });
            
            Factory.AgregarCompanion(c1);
            response = Factory.EliminarCompanion(c1);

            Assert.IsTrue(response);
        }
    }
}
