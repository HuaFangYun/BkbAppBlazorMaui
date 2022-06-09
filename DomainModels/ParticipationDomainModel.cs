using DomainModels.Contracts;

namespace DomainModels
{
    public class ParticipationDomainModel : IParticipationDomainModel
    {
        public Guid Id { get; set; }

        public bool Participate { get; set; }

        public string Reason { get; set; }

        public virtual IUserDomainModel User { get; set; }

        public Guid? UserId { get; set; }

        public virtual IEventDomainModel Event { get; set; }

        public Guid? EventId { get; set; }
    }
}
