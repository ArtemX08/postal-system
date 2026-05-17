using System.Collections.Generic;
using System.Linq;

namespace PostalSystem
{
    public delegate bool EntityFilterDelegate(IEntity entity);

    public static class DataManager
    {
        public static IEnumerable<IEntity> Entities { get; private set; } = new List<IEntity>();

        public static void Add(IEntity entity)
        {
            Entities = Entities.Append(entity);
        }

        public static IEnumerable<IEntity> Filter(EntityFilterDelegate filter)
        {
            foreach (var entity in Entities)
            {
                if (filter(entity))
                {
                    yield return entity;
                }
            }
        }
    }
}