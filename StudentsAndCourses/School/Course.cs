namespace School
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private string name;
        private ICollection<Student> students;

        public Course(string name)
        {
            this.Name = name;
            this.students = new List<Student>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.ValidateNull(value, Constants.CourseCannotBeNull);
                Validator.ValidateStringNullorEmpty(value, string.Format(Constants.NameCannotBeNullOrEmpty, this.GetType().Name));
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinCourseNameLength,
                    Constants.MaxCourseNameLength,
                    string.Format(Constants.CourseNameRangeMustBeBetween, Constants.MinCourseNameLength, Constants.MaxCourseNameLength));

                this.name = value;
            }
        }

        public ICollection<Student> Students
        {
            get
            {
                return new List<Student>(this.students);
            }
        }

        public void AddStudent(Student student)
        {
            Validator.ValidateNull(student, Constants.StudentCannotBeNull);

            if (this.students.Contains(student))
            {
                throw new ArgumentException(Constants.CourseCannotBeAdded);
            }

            if (this.students.Count > Constants.MaxStudentsInClass)
            {
                throw new ArgumentOutOfRangeException(string.Format(Constants.StudentsMustBeLessThan, Constants.MaxStudentsInClass));
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            Validator.ValidateNull(student, Constants.StudentCannotBeNull);

            if (!this.students.Contains(student))
            {
                throw new ArgumentException(Constants.CourseCannotBeRemoved);
            }

            this.students.Remove(student);
        }
    }
}
