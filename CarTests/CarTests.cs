using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;
namespace CarTests
{
    [TestClass] public class CarTests
    {
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        Car test_car;
        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
            
        }


        [TestMethod]
        public void emptyTest()
        {
            Assert.AreEqual(12,12,.001);
        }

        //TODO: constructor sets gasTankLevel properly

        [TestMethod]
        public void conTankLevelTest()
        {
            Assert.AreEqual(test_car.GasTankLevel, test_car.GasTankSize, .001);
        }
        //TODO: gasTankLevel is accurate after driving within tank range
        [TestMethod]
        public void driveTankLevelTest()
        {
            double startingGas = test_car.GasTankLevel;
            startingGas = (test_car.GasTankLevel - .4);
            test_car.Drive(20);
            Assert.AreEqual (test_car.GasTankLevel, startingGas, .001);
        }
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        [TestMethod]
        public void nonZeroPossTest()
        {
            test_car.Drive(5000);
            Assert.IsFalse(test_car.GasTankLevel < 0);
        }

        //TODO: can't have more gas than tank size, expect an exception
        [TestMethod]
        public void tankSizeConstraintTest()
        {
            test_car.AddGas(55);
            Assert.IsFalse(test_car.GasTankLevel > test_car.GasTankSize);

        }

        
    }
   
}
