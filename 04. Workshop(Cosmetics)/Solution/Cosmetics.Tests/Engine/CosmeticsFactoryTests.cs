namespace Cosmetics.Tests.Engine
{
    using System;
    using NUnit.Framework;
    using Cosmetics.Engine;
    using Cosmetics.Common;

    [TestFixture]
    public class CosmeticsFactoryTests
    {
        [TestCase(null)]
        [TestCase("")]
        public void CreateShampoo_ShouldThrowNullReferenceException_WhenNameIsNullOrEmpty(string name)
        {
            // Arrange
            var cosmeticsFactory = new CosmeticsFactory();

            // Act and Assert
            Assert.Throws<NullReferenceException>
                (() => cosmeticsFactory.CreateShampoo(name, "eexample", 10.0M, GenderType.Women, 124, UsageType.EveryDay));
        }
    }
}
