namespace ViewModels.Contracts
{
    public interface IEventViewModel
    {
        Guid Id { get; set; }

        string Name { get; set; }

        string Description { get; set; }

        DateTime Date { get; set; }

        IGroupViewModel Group { get; set; }
    }
}
