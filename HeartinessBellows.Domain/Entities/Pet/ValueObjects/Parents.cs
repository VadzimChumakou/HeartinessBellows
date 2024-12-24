namespace HeartinessBellows.Domain.Entities.Pet.ValueObjects
{
    public record Parents(
        HeartinessBellows.Domain.Entities.User.User First,
        HeartinessBellows.Domain.Entities.User.User Second
        );
}
