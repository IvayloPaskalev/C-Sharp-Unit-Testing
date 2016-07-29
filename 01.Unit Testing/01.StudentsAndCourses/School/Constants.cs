namespace School
{
    using System;

    public static class Constants
    {
        public const int MinSchoolNameLength = 5;
        public const int MaxSchoolNameLength = 25;
        public const int MinStudentNameLength = 2;
        public const int MaxStudentNameLength = 30;
        public const int MinCourseNameLength = 2;
        public const int MaxCourseNameLength = 40;
        public const int MinStudentID = 10000;
        public const int MaxStudentID = 99999;
        public const int MaxStudentsInClass = 30;

        public const string NameCannotBeNullOrEmpty = "{0} name cannot be null or empty!";

        public const string CourseCannotBeNull = "Course cannot be null";
        public const string StudentCannotBeNull = "Student cannot be null";
        public const string SchoolCannotBeNull = "School cannot be null";

        public const string CourseCannotBeAdded = "This course cannot be added more than once";
        public const string CourseCannotBeRemoved = "This course cannot be remove because he is not exist";
        public const string StudentCannotBeAdded = "This student cannot be added more than once";
        public const string StudentCannotBeRemoved = "This student cannot be remove because he is not exist";

        public const string SchoolNameRangeMustBeBetween = "School name must be between {0} and {1} characters long";
        public const string StudentNameRangeMustBeBetween = "Student name must be between {0} and {1} characters long";
        public const string CourseNameRangeMustBeBetween = "Course name must be between {0} and {1} characters long";

        public const string StudentIDRangeMustBeBetween = "Student ID must be between {0} and {1}";
        public const string StudentsMustBeLessThan = "Students in this course must be less than {0}";
    }
}
