using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PostalSystem
{
    public sealed class Parcel : Entity, IEntity
    {
        public override string FileName => "Parcel.txt";

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        public double Weight { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Cost { get; set; }

        public DateTime? ShipmentDate { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public string? ReceiverName { get; set; }

        public Parcel()
        {
            Description = "";
            Weight = 0;
            Cost = 0;
            ShipmentDate = DateTime.Now;
            DeliveryDate = null;
        }

        public Parcel(Guid id, string description, double weight, decimal cost, DateTime? shipmentDate, DateTime? deliveryDate)
            : base(id)
        {
            Description = description;
            Weight = weight;
            Cost = cost;
            ShipmentDate = shipmentDate ?? DateTime.Now;
            DeliveryDate = deliveryDate;
        }

        public bool Search(string searchString)
        {
            return Description!.Contains(searchString, StringComparison.OrdinalIgnoreCase) ||
                   Weight.ToString().Contains(searchString, StringComparison.OrdinalIgnoreCase);
        }

        public override string Format()
        {
            return $"{base.Format()}[{Description}][{Weight}][{Cost}][{ShipmentDate?.ToString("dd/MM/yyyy")}]";
        }


    }
}