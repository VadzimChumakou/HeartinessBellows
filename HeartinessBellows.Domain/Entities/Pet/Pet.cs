using HeartinessBellows.Domain.Entities.Pet.ValueObjects;

namespace HeartinessBellows.Domain.Entities.Pet
{
    public sealed class Pet : BaseEntity
    {
        public Pet(Guid id) : base(id)
        {
        }

        public string Name { get; private set; }
        public DateTime Birtday { get; private set; }
        public Condition Condition { get; private set; }
        public Parents Parents { get; private set; }

    }
}
