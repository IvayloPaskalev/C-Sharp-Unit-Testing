namespace School
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private static int id = 10000;
        private string name;
        private ICollection<Course> courses;

        public School(string name)
        {
            this.Name = name;
            this.courses = new List<Course>();
        }

        public static int ID
        {
            get
            {
                return id;
            }

            internal set
            {
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.ValidateNull(value, Constants.SchoolCannotBeNull);
                Validator.ValidateStringNullorEmpty(value.Trim(), string.Format(Constants.NameCannotBeNullOrEmpty, this.GetType().Name));
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinSchoolNameLength,
                    Constants.MaxSchoolNameLength,
                    string.Format(Constants.SchoolNameRangeMustBeBetween, Constants.MinSchoolNameLength, Constants.MaxSchoolNameLength));

                this.name = value;
            }
        }

        public ICollection<Course> Courses
        {
            get
            {
                return new List<Course>(this.courses);
            }
        }

        public void AddCourse(Course course)
        {
            Validator.ValidateNull(course, Constants.CourseCannotBeNull);

            if (this.courses.Contains(course))
            {
                throw new ArgumentException(Constants.CourseCannotBeAdded);
            }

            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            Validator.ValidateNull(course, Constants.CourseCannotBeNull);

            if (!this.courses.Contains(course))
            {
                throw new ArgumentException(Constants.CourseCannotBeRemoved);
            }

            this.courses.Remove(course);
        }
    }
}
