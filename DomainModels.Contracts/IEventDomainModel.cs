namespace DomainModels.Contracts
{
    public interface IEventDomainModel
    {
        Guid Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        DateTime Date { get; set; }

        IGroupDomainModel Group { get; set; }
    }
}
