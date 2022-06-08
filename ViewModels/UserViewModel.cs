using ViewModels.Contracts;

namespace ViewModels
{
    public class UserViewModel : IUserViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
