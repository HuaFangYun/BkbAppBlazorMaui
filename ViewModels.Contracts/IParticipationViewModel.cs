namespace ViewModels.Contracts
{
    public interface IParticipationViewModel
    {
        Guid Id { get; set; }

        bool Participate { get; set; }

        string Reason { get; set; }

        IUserViewModel User { get; set; }

        Guid? UserId { get; set; }

        IEventViewModel Event { get; set; }

        Guid? EventId { get; set; }
    }
}
