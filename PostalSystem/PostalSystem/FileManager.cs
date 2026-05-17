using System;
using System.Collections.Generic;
using System.IO;

namespace PostalSystem
{
    public static class FileManager
    {
        private const string DefaultFilePath = "parcels.txt";

        public static void Add(IEntity entity)
        {
            var parcel = entity as Parcel;
            if (parcel == null) return;

            string line = $"{parcel.Id};{parcel.Description};{parcel.Weight};{parcel.Cost};{parcel.ShipmentDate?.ToString("yyyy-MM-dd")}";

            File.AppendAllText(DefaultFilePath, line + Environment.NewLine);
        }

        public static List<T> GetEntities<T>(string filePath) where T : class, IEntity
        {
            var list = new List<T>();

            if (!File.Exists(filePath)) return list;

            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var parts = line.Split(';');

                if (typeof(T) == typeof(Parcel) && parts.Length >= 5)
                {
                    if (Guid.TryParse(parts[0], out Guid id))
                    {
                        string description = parts[1];
                        double weight = double.Parse(parts[2]);
                        decimal cost = decimal.Parse(parts[3]);
                        DateTime date = DateTime.Parse(parts[4]);

                        var parcel = new Parcel(id, description, weight, cost, date, null) as T;
                        if (parcel != null)
                        {
                            list.Add(parcel);
                        }
                    }
                }
            }
            return list;
        }
    }
}