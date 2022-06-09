using ViewModels.Contracts;

namespace ViewModels
{
    public class EventViewModel : IEventViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public virtual IGroupViewModel Group { get; set; }

        public Guid? GroupId { get; set; }
    }
}
