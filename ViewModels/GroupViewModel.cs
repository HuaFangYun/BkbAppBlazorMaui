using ViewModels.Contracts;

namespace ViewModels
{
    public class GroupViewModel : IGroupViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
