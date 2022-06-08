using ViewModels.Contracts;

namespace ViewModels
{
    public class ParticipationViewModel : IParticipationViewModel
    {
        public Guid Id { get; set; }

        public bool Participate { get; set; }

        public string Reason { get; set; }

        public IUserViewModel User { get; set; }

        public IEventViewModel Event { get; set; }
    }
}
