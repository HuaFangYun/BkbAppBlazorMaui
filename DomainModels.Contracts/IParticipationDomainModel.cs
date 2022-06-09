namespace DomainModels.Contracts
{
    public interface IParticipationDomainModel
    {
        Guid Id { get; set; }

        bool Participate { get; set; }

        string Reason { get; set; }

        IUserDomainModel User { get; set; }

        Guid? UserId { get; set; }

        IEventDomainModel Event { get; set; }

        Guid? EventId { get; set; }
    }
}
