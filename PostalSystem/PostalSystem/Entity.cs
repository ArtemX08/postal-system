using System;
using System.ComponentModel.DataAnnotations; 
using System.ComponentModel.DataAnnotations.Schema; 

namespace PostalSystem
{
    public class Entity
    {
        [Key] 
        public Guid Id { get; set; }

        [NotMapped] 
        public virtual string FileName => "Entity.txt";

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public Entity(Guid id)
        {
            Id = id;
        }

        public virtual bool IsValid()
        {
            return Id != Guid.Empty;
        }

        public virtual string Format()
        {
            return $"[{Id}]";
        }
    }
}