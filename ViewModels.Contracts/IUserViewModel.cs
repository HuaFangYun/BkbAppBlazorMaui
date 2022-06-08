namespace ViewModels.Contracts
{
    public interface IUserViewModel
    {
        Guid Id { get; set; }

        string Name { get; set; }

        string Email { get; set; }
    }
}
