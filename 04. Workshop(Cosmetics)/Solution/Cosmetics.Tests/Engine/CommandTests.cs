namespace Cosmetics.Tests.Engine
{
    using System;
    using NUnit.Framework;
    using Cosmetics.Engine;
    using System.Collections.Generic;

    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void Parse_ShouldReturnNewCommand_WhenTheInputStringIsValid()
        {
            // Arrange
            string strInput = "Input";

            // Act
            var executionResult = Command.Parse(strInput);

            // Assert
            Assert.IsInstanceOf<Command>(executionResult);
        }

        [Test]
        public void Parse_ShouldSetCorrectValue_WhenInputParameterIsValid()
        {
            // Arrange
            var strInput = "RemoveFromCategory ForMale Cool";
            var expectedNameValue = "RemoveFromCategory";

            // Act
            var executionResult = Command.Parse(strInput);

            // Assert
            Assert.AreEqual(expectedNameValue, executionResult.Name);
        }  
        
        [Test]
        public void Parse_ShouldSetCorrectProperties_WhenInputIsValid()
        {
            // Arrange
            var strInput = "RemoveFromCategory ForMale Cool";
            var expectedPropertyOne = "ForMale";
            var expectedPropertyTwo = "Cool";
            var expectedProperties = new List<string>();
            expectedProperties.Add(expectedPropertyOne);
            expectedProperties.Add(expectedPropertyTwo);

            // Act
            var exexutionResult = Command.Parse(strInput);

            // Assert
            CollectionAssert.AreEqual(expectedProperties, exexutionResult.Parameters);
        } 
    }
}
