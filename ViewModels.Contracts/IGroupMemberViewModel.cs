namespace ViewModels.Contracts
{
    public interface IGroupMemberViewModel
    {
        Guid Id { get; set; }

        IUserViewModel User { get; set; }

        Guid? UserId { get; set; }
        
        IGroupViewModel Group { get; set; }

        Guid? GroupId { get; set; }

    }
}
