using NUnit.Framework;
using ProjectDeathStar.Core.Models.Planets;
using System.Diagnostics.CodeAnalysis;

namespace PlanetTests.PandoraTests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class InstanceTests
    {

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void a()
        {
            //Arrange
            var pandora = new Planet(Planets.Pandora);
            //Act

            //Assert
            Assert.AreEqual(20, pandora.CivilProduction);
            Assert.AreEqual(10, pandora.MilitaryProduction);
            Assert.AreEqual(1, pandora.Offense);
            Assert.AreEqual(2, pandora.Defense);
        }
    }
}
