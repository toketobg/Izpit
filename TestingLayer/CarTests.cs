namespace TestingLayer
{
    [TestClass]
    public class CarTests
    {
        CarContext ctx = DBContextManager.GetCarContext();
        Car CAR;
        
        [TestInitialize]
        public void Setup()
        {
            try
            {
                ctx.Delete("custom");
            }
            catch (Exception e) { Console.WriteLine("Not Deleted"); }
            Car customitem = new Car("custom", "Mercedes", "S Class", "Black", 2022);
            CAR = customitem;
            ctx.Create(customitem);
        }
        [TestCleanup]
        public void Cleanup()
        {
            ctx.Delete("custom");
            ctx.Create(CAR);
        }
        [TestMethod]
        public void CreateTest()
        {
            Assert.IsNotNull(ctx.Read("custom"));
        }
        [TestMethod]
        public void ReadTest()
        {
            Assert.AreEqual("Mercedes", ctx.Read("custom").Make);
        }
        [TestMethod]
        public void ReadAllTest()
        {
            Assert.IsNotNull(ctx.ReadAll());
        }
        [TestMethod]
        public void UpdateTest()
        {
            Car newcompany = new Car("custom", "BMW", "M5 CS", "Black", 2021);
            ctx.Update(newcompany);
            Assert.AreEqual("BMW", ctx.Read("custom").Make);
        }
        [TestMethod]
        public void DeleteTest()
        {
            ctx.Delete("custom");
            Assert.IsNull(ctx.Read("custom"));
            ctx.Create(CAR);
        }

    }
}
