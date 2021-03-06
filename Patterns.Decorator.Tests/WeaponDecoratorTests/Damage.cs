﻿namespace Patterns.Decorator.Tests.WeaponDecoratorTests
{
    using Moq;
    using NUnit.Framework;

    [TestFixture]
    public class Damage
    {
        private Mock<IWeapon> _mockedWeapon;

        [SetUp]
        public void Setup()
        {
            _mockedWeapon = new Mock<IWeapon>();
            _mockedWeapon.Setup(weapon => weapon.Damage).Returns(80);
        }

        [Test]
        public void IsEighty()
        {
            // Arrange
            var decorator = new WeaponDecorator(_mockedWeapon.Object);

            // Act
            var result = decorator.Damage;

            // Assert
            Assert.That(result, Is.EqualTo(80));
        }
    }
}