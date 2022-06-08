using DomainModels.Contracts;

namespace DomainModels
{
    public class ParticipationDomainModel : IParticipationDomainModel
    {
        public Guid Id { get; set; }

        public bool Participate { get; set; }

        public string Reason { get; set; }

        public IUserDomainModel User { get; set; }

        public IEventDomainModel Event { get; set; }
    }
}
