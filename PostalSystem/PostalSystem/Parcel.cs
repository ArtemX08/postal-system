using System;

namespace PostalSystem
{
    public sealed class Parcel : Entity
    {
        public double Weight { get; set; }
        public decimal Cost { get; set; }
        public DateTime? ShipmentDate { get; set; }
        public DateTime? DeliveryDate { get; set; }

        public override string FileName => "Parcel.txt";

        public Parcel()
        {
            Weight = 0;
            Cost = 0;
            ShipmentDate = DateTime.Now;
            DeliveryDate = null;
        }

        public Parcel(Guid id, double weight, decimal cost, DateTime? shipmentDate, DateTime? deliveryDate)
            : base(id)
        {
            Weight = weight;
            Cost = cost;
            ShipmentDate = shipmentDate;
            DeliveryDate = deliveryDate;
        }

        public new bool IsValid()
        {
            return base.IsValid() && Weight > 0 && Cost >= 0;
        }

        public override string Format()
        {
            return $"{base.Format()}[{Weight}][{Cost}][{ShipmentDate?.ToString("dd/MM/yyyy")}][{DeliveryDate?.ToString("dd/MM/yyyy")}]";
        }
    }
}