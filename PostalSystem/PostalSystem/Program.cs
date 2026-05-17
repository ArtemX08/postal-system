using System;
using System.Linq;

namespace PostalSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Working with Entity Framework Core Database ===");

            using (ApplicationContext db = new ApplicationContext())
            {
                Parcel parcel1 = new Parcel { Description = "TV", Weight = 12.5, Cost = 15000 };
                Parcel parcel2 = new Parcel { Description = "Books", Weight = 3.0, Cost = 800 };

                db.Parcels.AddRange(parcel1, parcel2);
                db.SaveChanges();
                Console.WriteLine("\n[CREATE] Parcels successfully added to the database.");
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Console.WriteLine("\n[READ] List of parcels in the database:");
                var parcels = db.Parcels.ToList();
                foreach (var p in parcels)
                {
                    Console.WriteLine($"- {p.Description} (Weight: {p.Weight} kg, Cost: {p.Cost} UAH)");
                }
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Parcel parcelToUpdate = db.Parcels.FirstOrDefault(p => p.Description == "Books");
                if (parcelToUpdate != null)
                {
                    parcelToUpdate.Cost = 950; 
                    db.SaveChanges(); 
                    Console.WriteLine("\n[UPDATE] Cost for 'Books' successfully changed to 950 UAH.");
                }
            }

            using (ApplicationContext db = new ApplicationContext())
            {
                Parcel parcelToDelete = db.Parcels.FirstOrDefault(p => p.Description == "TV");
                if (parcelToDelete != null)
                {
                    db.Parcels.Remove(parcelToDelete); 
                    db.SaveChanges(); 
                    Console.WriteLine("\n[DELETE] Parcel 'TV' successfully deleted from the database.");
                }

                Console.WriteLine("\n[FINAL] Remaining parcels in the database:");
                var finalParcels = db.Parcels.ToList();
                foreach (var p in finalParcels)
                {
                    Console.WriteLine($"- {p.Description} (Cost: {p.Cost} UAH)");
                }
            }

            Console.ReadLine();
        }
    }
}