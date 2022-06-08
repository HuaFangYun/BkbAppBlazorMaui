namespace DomainModels.Contracts
{
    public interface IUserDomainModel
    {
        Guid Id { get; set; }

        string Name { get; set; }

        string Email { get; set; }
    }
}
