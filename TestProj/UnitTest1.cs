using BisnessLayer.Interfaces;
using NUnit.Framework;
using StoreWeb.Models;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

            IProductable prod = new ProductViewModel
            {
                Id=1,
                Name="Spring",
                Price=15f,
                Category="Somecat",
                Description="SomePRod"
            };



        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}