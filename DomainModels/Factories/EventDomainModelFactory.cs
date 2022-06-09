using DomainModels.Contracts;
using DomainModels.Contracts.Factories;

namespace DomainModels.Factories
{
    public class EventDomainModelFactory : IEventDomainModelFactory
    {
        public IEventDomainModel Create()
        {
            return new EventDomainModel();
        }
    }
}
