using ViewModels.Contracts;

namespace ViewModels
{
    public class ParticipationViewModel : IParticipationViewModel
    {
        public Guid Id { get; set; }

        public bool Participate { get; set; }

        public string Reason { get; set; }

        public virtual IUserViewModel User { get; set; }

        public Guid? UserId { get; set; }

        public virtual IEventViewModel Event { get; set; }

        public Guid? EventId { get; set; }
    }
}
