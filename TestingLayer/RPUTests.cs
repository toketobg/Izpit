namespace TestingLayer
{
    [TestClass]
    public class RPUTests
    {
        RPUContext ctx = DBContextManager.GetRPUContext();
        RPU RPU;

        [TestInitialize]
        public void Setup()
        {
            try
            {
                ctx.Delete("customid");
                //tries to delete the test user if tests have been ran before
            }
            catch (Exception e) { }
            RPU customitem = new RPU("customid", "Plovdiv", 2);
            ctx.Create(customitem);
            RPU = customitem;
        }
        [TestCleanup]
        public void Cleanup()
        {
            ctx.Delete("customid");
            ctx.Create(RPU);
        }
        [TestMethod]
        public void CreateTest()
        {
            Assert.IsNotNull(ctx.Read("customid"));
        }
        [TestMethod]
        public void ReadTest()
        {
            Assert.AreEqual("Plovdiv", ctx.Read("customid").City);
        }
        [TestMethod]
        public void ReadAllTest()
        {
            Assert.IsNotNull(ctx.ReadAll());
        }
        [TestMethod]
        public void UpdateTest()
        {
            RPU newrpu = new RPU("customid", "Sofia", 3);
            ctx.Update(newrpu);
            Assert.AreEqual("Sofia", ctx.Read("customid").City);
        }
        [TestMethod]
        public void DeleteTest()
        {
            ctx.Delete("customid");
            Assert.IsNull(ctx.Read("customid"));
            ctx.Create(RPU);
        }

    }
}
