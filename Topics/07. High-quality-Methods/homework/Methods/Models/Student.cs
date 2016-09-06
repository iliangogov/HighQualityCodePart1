namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private string placeOfBirth;
        private DateTime dateOfBirth;

        public Student(string firstname, string lastname, string placeofbirth, DateTime dateofbirth)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.PlaceOfBirth = placeofbirth;
            this.DateOfBirth = dateofbirth;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Firstname must have value!");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Lastname must have value!");
                }

                this.lastName = value;
            }
        }

        public string PlaceOfBirth
        {
            get
            {
                return this.placeOfBirth;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Placeofbirth must have value!");
                }

                this.placeOfBirth = value;
            }
        }

        public DateTime DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Dateofbirth must have value!");
                }

                this.dateOfBirth = value;
            }
        }

        public bool IsOlderThan(Student other)
        {
            if (other == null)
            {
                throw new ArgumentNullException("Invalid parameter Student is provided. Must have correct value!");
            }

            DateTime firstDate = this.dateOfBirth;
            DateTime secondDate = other.dateOfBirth;

            return firstDate < secondDate;
        }

        public override string ToString()
        {
            return string.Format(
                "{0} {1} from {2}, born at {3}.{4}.{5}",
                this.FirstName,
                this.LastName,
                this.PlaceOfBirth,
                this.DateOfBirth.Day,
                this.DateOfBirth.Month,
                this.DateOfBirth.Year);
        }
    }
}
