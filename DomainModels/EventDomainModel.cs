using DomainModels.Contracts;

namespace DomainModels
{
    public class EventDomainModel : IEventDomainModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public IGroupDomainModel Group { get; set; }
    }
}
