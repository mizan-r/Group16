using Autofac.Extras.Moq;
using NUnit.Framework;
using ProjectDeathStar.Core.Models.Equipments.Weapons;
using ProjectDeathStar.Core.Models.Ships;
using System.Diagnostics.CodeAnalysis;

namespace ShipTests.BattleShipTests
{
    [TestFixture, ExcludeFromCodeCoverage]
    public class BattleshipTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void InstallWeapon_setWeaponInSlot_setsWeaponInCorrectSlot()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange
                //var weapon = mock.Mock<IWeapon>();
                //weapon.Setup(a => a.Damage).Returns(500);
                //var ship = mock.Create<Raven>();

                ShipFactory<Battleship> factory = new ShipFactory<Battleship>();
                var raven = factory.CreateShip(BattleShips.Raven);
                var cannon = Weapon.CreateWeapon("Cannon", WeaponType.Large);

                //Act
                raven.InstallWeapon(cannon, 3);

                //ship.Weapons = new List<IWeapon>() { weapon.Object, weapon.Object };

                //var damage = ship.FireWeapon();

                //weapon.VerifyAll();

                //Assert
                Assert.AreEqual(raven.WeaponSlots[2], cannon);


            }
        }

        [Test]
        public void CreateBattleShip_GivenProperNameOfBattleShip_CreatesCorrectShip()
        {
            using (var mock = AutoMock.GetLoose())
            {
                //Arrange
                ShipFactory<Battleship> factory = new ShipFactory<Battleship>();

                //Act
                var raven = factory.CreateShip(BattleShips.Raven);


                //Assert
                Assert.AreEqual(BattleShips.Raven.ToString(), raven.Name);
                Assert.AreEqual(8, raven.WeaponSlots.Length);
            }
        }


    }
}