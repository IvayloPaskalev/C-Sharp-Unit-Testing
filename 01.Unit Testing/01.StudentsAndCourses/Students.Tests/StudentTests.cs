namespace Students.Tests
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using School;

    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void Student_CreateStudent_ShouldNotThrowException()
        {
            var student = new Student("Pesho");
        }

        [TestMethod]
        public void Student_CreateStudent_ShouldReturnExpectedName()
        {
            var student = new Student("Pesho");

            Assert.AreEqual("Pesho", student.Name);
        }

        [TestMethod]
        public void Student_CreateStudent_ShouldReturnExpectedID()
        {
            var student = new Student("Pesho");
            student.ID = 10000;

            Assert.AreEqual(10000, student.ID);
        }

        [TestMethod]
        public void Student_CreateStudent_ShouldThrowExceptionWhenNameIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Student(null));
        }

        [TestMethod]
        public void Student_CreateStudent_ShouldThrowExceptionWhenNameIsEmpty()
        {
            Assert.ThrowsException<ArgumentException>(() => new Student(string.Empty));
        }

        [TestMethod]
        public void Student_SetId_ShouldThrowExceptionWhenIdIsLowerThanExpected()
        {
            var student = new Student("Pesho");

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => student.ID = 100);
        }

        [TestMethod]
        public void Student_SetId_ShouldThrowExceptionWhenIdIsHigherThanExpected()
        {
            var student = new Student("Pesho");

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => student.ID = 100000);
        }
    }
}
