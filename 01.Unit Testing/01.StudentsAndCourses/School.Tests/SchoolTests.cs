namespace School.Tests
{
    using System;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SchoolTests
    {
        [TestMethod]
        public void School_CreateSchool_ShouldNotThrowException()
        {
            var school = new School("telerik academy");
        }

        [TestMethod]
        public void School_CreateSchool_ShouldThrowExceptionWhenNameLengthIsOutOfRange()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new School("TA"));
        }

        [TestMethod]
        public void School_CheckSchoolGetter_SchouldReturnCorrectName()
        {
            School school = new School("Telerik Academy");
            Assert.AreEqual("Telerik Academy", school.Name);
        }

        [TestMethod]
        public void School_CheckSchoolIsNull_ShouldThrowExceptionWhenNameIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new School(null));
        }

        [TestMethod]
        public void School_CheckSchoolNameIsEmpty_ShouldThrowExceptionWhenNameIsEmpty()
        {
            Assert.ThrowsException<ArgumentException>(() => new School(string.Empty));
        }

        [TestMethod]
        public void School_AddCourse_ShouldAddCourseCorrectly()
        {
            var school = new School("Telerik Academy");
            var course = new Course("Unit testing");

            school.AddCourse(course);

            Assert.AreSame(course, school.Courses.First());
        }

        [TestMethod]
        public void School_AddCourse_ShouldThrowExceptionWhenNullCourseAdded()
        {
            var school = new School("Telerik Academy");

            Assert.ThrowsException<ArgumentNullException>(() => school.AddCourse(null));
        }

        [TestMethod]
        public void School_AddCourse_ShouldThrowExceptionWhenAddingExistingCourse()
        {
            var school = new School("Telerik Academy");
            var course = new Course("Unit Testing");

            school.AddCourse(course);

            Assert.ThrowsException<ArgumentException>(() => school.AddCourse(course));
        }

        [TestMethod]
        public void School_RemoveCourse_ShouldRemoveCourseCorrectly()
        {
            var school = new School("Telerik Academy");
            var course = new Course("Unit Testing");

            school.AddCourse(course);
            school.RemoveCourse(course);

            Assert.AreEqual(0, school.Courses.Count);
        }

        [TestMethod]
        public void School_RemoveCourse_ShouldThrowExceptionWhenNullCourseRemoved()
        {
            School school = new School("Telerik Academy");

            Assert.ThrowsException<ArgumentNullException>(() => school.RemoveCourse(null));
        }

        [TestMethod]
        public void School_RemoveCourse_ShouldThrowExceptionWhenRemovingNonExistentCourse()
        {
            var school = new School("Telerik Academy");

            var course = new Course("Unit Testing");

            Assert.ThrowsException<ArgumentException>(() => school.RemoveCourse(course));
        }

        [TestMethod]
        public void School_bachka()
        {
            School pesho = new School("Peshos's school");
        }
    }
}