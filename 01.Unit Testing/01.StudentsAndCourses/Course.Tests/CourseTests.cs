namespace Course.Tests
{
    using System;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using School;

    [TestClass]
    public class CourseTests
    {
        [TestMethod]
        public void Course_CreateCourse_ShouldNotThrowException()
        {
            var course = new Course("Unit Testing");
        }

        [TestMethod]
        public void Course_CreateCourse_ShouldThrowExceptionWhenArgumentIsOutOfRange()
        {
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Course("T"));
        }

        [TestMethod]
        public void Course_CreateCourse_ShouldThrowExceptionWhenNameIsNull()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Course(null));
        }

        [TestMethod]
        public void Course_CreateCourse_ShouldThrowExceptionWhenNameIsEmpty()
        {
            Assert.ThrowsException<ArgumentException>(() => new Course(string.Empty));
        }

        [TestMethod]
        public void Course_CheckCourseGetter_ShoudReturnCorrectName()
        {
            var course = new Course("Unit Testing");

            Assert.AreSame("Unit Testing", course.Name);
        }

        [TestMethod]
        public void Course_AddStudent_ShouldAddStudentCorrectly()
        {
            var course = new Course("Unit Testing");
            var student = new Student("Pesho");

            course.AddStudent(student);

            Assert.AreSame(student, course.Students.First());
        }

        [TestMethod]
        public void Course_AddStudent_ShouldThrowExceptionWhenNullStudentAdded()
        {
            var course = new Course("Unit Testing");

            Assert.ThrowsException<ArgumentNullException>(() => course.AddStudent(null));
        }

        [TestMethod]
        public void Course_AddStudent_ShouldThrowExceptionWhenAddedMoreThan30Students()
        {
            var course = new Course("Unit Testing");

            for (int i = 0; i < 31; i++)
            {
                course.AddStudent(new Student(string.Format("Student {0}", i)));
            }

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => course.AddStudent(new Student("Pesho Faila")));
        }

        [TestMethod]
        public void Course_AddStudent_ShouldThrowExceptionWhenAddingSameStudentMoreThanOnce()
        {
            var course = new Course("Unit Testing");
            var student = new Student("Pesho");

            course.AddStudent(student);

            Assert.ThrowsException<ArgumentException>(() => course.AddStudent(student));
        }

        [TestMethod]
        public void Course_RemoveStudent_ShouldRemoveStudentCorrectly()
        {
            var course = new Course("Unit Testing");
            var student = new Student("Pesho");

            course.AddStudent(student);
            course.RemoveStudent(student);

            Assert.AreEqual(0, course.Students.Count);
        }

        [TestMethod]
        public void Course_RemoveStudent_ShouldThrowExceptionWhenNullStudentRemoved()
        {
            var course = new Course("Unit Testing");

            Assert.ThrowsException<ArgumentNullException>(() => course.RemoveStudent(null));      
        }

        [TestMethod]
        public void Course_RemoveStudent_ShouldThrowExceptionWhenRemovingNonExistentStudent()
        {
            var course = new Course("Unit Testing");

            var student = new Student("Pesho");

            Assert.ThrowsException<ArgumentException>(() => course.RemoveStudent(student));
        }
    }
}