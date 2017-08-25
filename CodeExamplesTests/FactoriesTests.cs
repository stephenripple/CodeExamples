using Microsoft.VisualStudio.TestTools.UnitTesting;
using CodeExamples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeExamples.Tests
{
    [TestClass()]
    public class FactoriesTests
    {
        [TestMethod()]
        public void CreateBoatTest()
        {
            var boat = Factories.Create(Factories.VehicleProcessorType.Boat);
            Assert.IsTrue(boat.StartVehicle("boat"));
        }

        [TestMethod()]
        public void EngineStartTest()
        {
            var car = Factories.Create(Factories.VehicleProcessorType.Car);
            Assert.IsFalse(car.StartVehicle("boat"));
        }
    }
}