using System;
using System.Collections.Generic;

namespace PostalSystem
{
    public class PostOffice : Entity
    {
        public string? Address { get; set; }

        public List<Parcel> Parcels { get; set; } = new List<Parcel>();
        public List<Client> Clients { get; set; } = new List<Client>();

        public override string FileName => "PostOffice.txt";

        public PostOffice()
        {
            Address = string.Empty;
        }

        public PostOffice(Guid id, string address) : base(id)
        {
            Address = address;
        }

        public override string Format()
        {
            return $"{base.Format()}[{Address}][Parcels: {Parcels.Count}][Clients: {Clients.Count}]";
        }
    }
}