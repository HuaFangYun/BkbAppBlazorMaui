using DomainModels.Contracts;

namespace DomainModels
{
    public class UserDomainModel : IUserDomainModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }
    }
}
