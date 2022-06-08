namespace ViewModels.Contracts
{
    public interface IGroupMemberViewModel
    {
        Guid Id { get; set; }

        IUserViewModel User { get; set; }
        
        IGroupViewModel Group { get; set; }

    }
}
