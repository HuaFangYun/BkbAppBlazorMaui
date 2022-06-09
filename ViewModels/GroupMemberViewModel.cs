using ViewModels.Contracts;

namespace ViewModels
{
    public class GroupMemberViewModel : IGroupMemberViewModel
    {
        public Guid Id { get; set; }

        public virtual IUserViewModel User { get; set; }

        public Guid? UserId { get; set; }

        public virtual IGroupViewModel Group { get; set; }

        public Guid? GroupId { get; set; }
    }
}
