namespace Cosmetics.Tests
{
    using System;
    using NUnit.Framework;
    using Cosmetics.Common;

    [TestFixture]
    public class ValidatorTests
    {
        [Test]
        public void CheckIfNull_ShouldThrowNullReferenceException_WhenNullObjectIsPassed()
        {
            // Arrange
            Object testObject = null;

            // Act and Assert
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfNull(testObject));
        }

        [Test]
        public void CheckIfNull_ShouldNotThrowException_WhenObjectIsCorrectlyPassed()
        {
            // Arrange
            Object testObject = new Object();

            // Act and Assert
            Assert.DoesNotThrow(() => Validator.CheckIfNull(testObject));
        }

        [TestCase(null)]
        [TestCase("")]
        public void CheckStringIsNullOrEmpty_ShouldThrowNullRefferenceException_WhenParamaeterIsNullOrEmptyString(string text)
        {
            // Act and Assert
            Assert.Throws<NullReferenceException>(() => Validator.CheckIfStringIsNullOrEmpty(text));
        }

        [Test]
        public void CheckStringIsNullOrEmpty_ShouldNotThrow_WhenStringIsCorrectlyPassed()
        {
            // Arrange
            var strText = "Alabalanicadyrtapanica";

            // Act and Assert
            Assert.DoesNotThrow(() => Validator.CheckIfStringIsNullOrEmpty(strText));
        }

        [TestCase(25, 25)]
        [TestCase(15, 25)]
        [TestCase(15, 5)]
        [TestCase(15, 0)]
        public void CheckIfStringLengthIsValid_WhenTextParamHasInvalidLenght_ShouldThrowIndexOutOfRangeException(int maxLenght, int minLenght)
        {
            // Arrange
            var exampleString = "20CharactersLongText";

            // Act && Assert
            Assert.Throws<IndexOutOfRangeException>(() => Validator.CheckIfStringLengthIsValid(exampleString, maxLenght, minLenght));
        }

        [TestCase(25, 20)]
        [TestCase(25, 15)]
        [TestCase(20, 20)]
        [TestCase(20, 0)]
        public void CheckIfStringLengthIsValid_WhenTextParamHasValidlenght_ShouldNotThrow(int maxLenght, int minLenght)
        {
            // Arrange
            var exampleString = "20CharactersLongText";

            // Act && Assert
            Assert.DoesNotThrow(() => Validator.CheckIfStringLengthIsValid(exampleString, maxLenght, minLenght));
        }
    }
}
