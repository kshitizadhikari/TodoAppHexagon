namespace TodoAppHexagon.Core.Primitives
{
    public abstract class Entity : IEquatable<Entity>
    {
        //init similar to set but can set value only once.. at the timme the object is initialized
        //private .. so that guid can be set from only the entity class
        public Guid Id { get; private init; }

        //abstract methods by definition public.. only classes inheriting from Entity should be able to use so protected
        protected Entity(Guid id)
        {
            Id = id;
        }

        public static bool operator ==(Entity? first, Entity? second)
        {
            return first is not null && second is not null && first.Equals(second);
        }


        public static bool operator !=(Entity? first, Entity? second)
        {
            return !(first == second);
        }


        public bool Equals(Entity? other)
        {
            if(other == null) return false;

            if(other.GetType() != GetType()) return false;

            return other.Id == Id;
        }

        //override because 
        public override bool Equals(object? obj)
        {
            if(obj == null) return false;

            if(obj.GetType() != typeof(Entity)) return false;

            if(obj is not Entity entity) return false;

            return entity.Id == Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() * 7;
        }

        
    }
}
