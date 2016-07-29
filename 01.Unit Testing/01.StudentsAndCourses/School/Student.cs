namespace School
{
    using System;

    public class Student
    {
        private string name;
        private int id;

        public Student(string name)
        {
            this.Name = name;
            this.ID = School.ID++;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.ValidateNull(value, Constants.StudentCannotBeNull);
                Validator.ValidateStringNullorEmpty(value.Trim(), string.Format(Constants.NameCannotBeNullOrEmpty, this.GetType().Name));
                Validator.ValidateIntRange(
                    value.Length,
                    Constants.MinStudentNameLength,
                    Constants.MaxStudentNameLength,
                    string.Format(Constants.StudentNameRangeMustBeBetween, Constants.MinStudentNameLength, Constants.MaxStudentNameLength));

                this.name = value;
            }
        }

        public int ID
        {
            get
            {
                return this.id;
            }

            set
            {
                Validator.ValidateIntRange(
                    value,
                    Constants.MinStudentID,
                    Constants.MaxStudentID,
                    string.Format(Constants.StudentIDRangeMustBeBetween, Constants.MinStudentID, Constants.MaxStudentID));

                this.id = value;
            }
        }
    }
}
