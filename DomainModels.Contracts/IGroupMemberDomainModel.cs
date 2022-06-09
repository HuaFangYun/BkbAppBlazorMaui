namespace DomainModels.Contracts
{
    public interface IGroupMemberDomainModel
    {
        Guid Id { get; set; }

        IUserDomainModel User { get; set; }

        Guid? UserId { get; set; }
        
        IGroupDomainModel Group { get; set; }

        Guid? GroupId { get; set; }

    }
}
