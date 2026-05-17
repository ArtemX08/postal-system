using System.Collections.Generic;

namespace PostalSystem
{
    public static class DataManager
    {
        public static Repository<IEntity> Entities { get; private set; } = new Repository<IEntity>();

        public static void Add(IEntity entity)
        {
            Entities.Add(entity);
        }

        public static IEnumerable<IEntity> Filter(GenericFilterDelegate<IEntity> filter)
        {
            return Entities.Filter(filter);
        }
    }
}