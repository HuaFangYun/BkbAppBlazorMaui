using DomainModels.Contracts;

namespace DomainModels
{
    public class EventDomainModel : IEventDomainModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public virtual IGroupDomainModel Group { get; set; }

        public Guid? GroupId { get; set; }
    }
}
