using System;
using System.IO;

namespace PostalSystem
{
    public static class FileManager
    {
        public static void Add(Entity entity)
        {
            if (entity == null)
                throw new ArgumentNullException(nameof(entity));

            if (!entity.IsValid())
                throw new Exception("Entity data is invalid and cannot be saved.");

            string record = entity.Format();

            using (StreamWriter sw = new StreamWriter(entity.FileName, true))
            {
                sw.WriteLine(record);
            }
        }
    }
}