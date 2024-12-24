using HeartinessBellows.Domain.Entities.Quest.ValueObject;

namespace HeartinessBellows.Domain.Entities.Quest
{
    public sealed class Quest : BaseEntity
    {
        public Quest(Guid id) : base(id)
        {
        }
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public int Points { get; private set; }
        public Period Period { get; private set; }
        public HeartinessBellows.Domain.Entities.User.User Resiver { get; private set; }
        public HeartinessBellows.Domain.Entities.User.User Giver { get; private set; }
        public bool isCompleeted { get; private set; }
    }
}
