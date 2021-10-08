using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarNS;

namespace CarTests
{
    [TestClass]
    public class CarTests
    {
        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(10, 10, .001);
        }
        
        Car test_car;
        [TestInitialize]
        public void CreateCarObject()
        {
            test_car = new Car("Toyota", "Prius", 10, 50);
        }
        
        [TestMethod]
        public void TestInitialGasTank()
        {
            Assert.AreEqual(10, test_car.GasTankLevel, .001);
        }
        [TestMethod]
        public void TestGasTankAfterDriving()
        {
            test_car.Drive(50);
            Assert.AreEqual(9, test_car.GasTankLevel, .001);
        }
        [TestMethod]
        public void GasTankAfterMaxMilage()
        {
            test_car.Drive(501);
            Assert.AreEqual(0, test_car.GasTankLevel, .001);
        }
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void TestGasOverfillException()
        {
            test_car.AddGas(5);
            Assert.Fail("Car can't hold more gas than size of tank.");
        }
        //TODO: add emptyTest so we can configure our runtime environment (remove this test before pushing to your personal GitHub account)
        //TODO: constructor sets gasTankLevel properly
        //TODO: gasTankLevel is accurate after driving within tank range
        //TODO: gasTankLevel is accurate after attempting to drive past tank range
        //TODO: can't have more gas than tank size, expect an exception

    }
}
