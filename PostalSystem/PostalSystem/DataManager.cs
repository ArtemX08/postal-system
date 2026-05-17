using System;
using System.Collections.Generic;
using System.Linq; 
namespace PostalSystem
{
    public static class DataManager
    {
        public static Repository<IEntity> Entities { get; private set; } = new Repository<IEntity>();

        public static void Add(IEntity entity)
        {
            Entities.Add(entity);
        }

        public static IEnumerable<IEntity> Search(string searchString)
        {
            return Entities.Where(it => it.Search(searchString));
        }

        public static IEnumerable<IEntity> Filter(Func<IEntity, bool> filter)
        {
            return Entities.Where(filter);
        }

        public static IEntity? GetById(Guid id)
        {
            return Entities.FirstOrDefault(e => e.Id == id);
        }
    }
}