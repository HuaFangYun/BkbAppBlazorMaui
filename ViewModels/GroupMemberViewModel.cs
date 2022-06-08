using ViewModels.Contracts;

namespace ViewModels
{
    public class GroupMemberViewModel : IGroupMemberViewModel
    {
        public Guid Id { get; set; }

        public IUserViewModel User { get; set; }

        public IGroupViewModel Group { get; set; }
    }
}
