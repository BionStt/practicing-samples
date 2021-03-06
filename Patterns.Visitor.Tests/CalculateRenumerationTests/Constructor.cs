﻿namespace Patterns.Visitor.Tests.CalculateRenumerationTests
{
    using NUnit.Framework;

    [TestFixture]
    public class Constructor
    {
        [Test]
        public void InheritsIEmployeeVisitor()
        {
            // Arrange | Act
            var result = new CalculateRenumeration();

            // Assert
            Assert.IsInstanceOf<IEmployeeVisitor>(result);
        }
    }
}