using System;

namespace PostalSystem
{
    public sealed class Client : Person, IEntity
    {
        public string? PaymentMethod { get; set; }

        public override string FileName => "Client.txt";

        public Client()
        {
            PaymentMethod = string.Empty;
        }

        public Client(Guid id, string firstName, string lastName, string phoneNumber, string paymentMethod)
            : base(id, firstName, lastName, phoneNumber)
        {
            PaymentMethod = paymentMethod;
        }

        public new bool IsValid()
        {
            return base.IsValid() && !string.IsNullOrEmpty(PaymentMethod);
        }

        public override string Format()
        {
            return $"{base.Format()}[{PaymentMethod}]";
        }

        public bool Search(string searchString)
        {
            return FirstName!.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                   LastName!.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                   PhoneNumber!.Contains(searchString, StringComparison.OrdinalIgnoreCase);
        }
    }
}