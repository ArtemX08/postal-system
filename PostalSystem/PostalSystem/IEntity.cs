using System;

namespace PostalSystem
{
    public interface IEntity
    {
        Guid Id { get; } 
        bool Search(string searchString);
    }
}