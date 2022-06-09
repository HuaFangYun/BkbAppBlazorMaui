using DomainModels.Contracts;
using DomainModels.Contracts.Factories;

namespace DomainModels.Factories
{
    public class ParticipationDomainModelFactory : IParticipationDomainModelFactory
    {
        public IParticipationDomainModel Create()
        {
            return new ParticipationDomainModel();
        }
    }
}
