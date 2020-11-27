using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lemon.AutoMapper;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            AutoMapperExtensions.AddAutoMapperProfile<TestProfile>();
            Source source = new Source()
            {
                One = "1",
                Two = "2"
            };

            Destination destination = ObjectMapper.Map<Source, Destination>(source);

            Assert.AreEqual(source.One, destination.One);
            Assert.AreEqual(source.Two, destination.Two);
        }

    }
}
