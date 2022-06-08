namespace DomainModels.Contracts
{
    public interface IGroupDomainModel
    {
        Guid Id { get; set; }

        string Name { get; set; }
    }
}
