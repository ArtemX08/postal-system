using System;

namespace PostalSystem
{
    public class Person : Entity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }

        public Person()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
            PhoneNumber = string.Empty;
        }

        public Person(Guid id, string firstName, string lastName, string phoneNumber) : base(id)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }

        public override string Format()
        {
            return $"{base.Format()}[{FirstName}][{LastName}][{PhoneNumber}]";
        }
    }
}