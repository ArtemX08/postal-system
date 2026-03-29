using System;

namespace PostalSystem
{
    public sealed class Client : Person
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
    }
}