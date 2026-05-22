using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 

namespace PostalSystem
{
    public class PostOffice : Entity
    {
        [Required]
        [MaxLength(200)]
        public string? Address { get; set; }

        public List<Parcel> Parcels { get; set; } = new List<Parcel>();
        public List<Client> Clients { get; set; } = new List<Client>();

        [NotMapped] 
        public Parcel this[int index]
        {
            get
            {
                return Parcels[index];
            }
            set
            {
                Parcels[index] = value;
            }
        }

        [NotMapped] 
        public override string FileName => "PostOffice.txt";

        public PostOffice()
        {
            Address = string.Empty;
        }

        public PostOffice(Guid id, string address) : base(id)
        {
            Address = address;
        }

        [MaxLength(50)]
        public string? CityName { get; set; }

        public override string Format()
        {
            return $"{base.Format()}[{Address}][Parcels: {Parcels.Count}][Clients: {Clients.Count}]";
        }
    }
}