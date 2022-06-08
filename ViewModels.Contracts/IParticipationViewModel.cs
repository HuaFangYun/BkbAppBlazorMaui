namespace ViewModels.Contracts
{
    public interface IParticipationViewModel
    {
        Guid Id { get; set; }

        bool Participate { get; set; }

        string Reason { get; set; }

        IUserViewModel User { get; set; }

        IEventViewModel Event { get; set; }
    }
}
