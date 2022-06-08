using DomainModels.Contracts;

namespace DomainModels
{
    public class GroupDomainModel : IGroupDomainModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
