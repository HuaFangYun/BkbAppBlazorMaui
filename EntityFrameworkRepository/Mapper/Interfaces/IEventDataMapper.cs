using DomainModels.Contracts;
using EntityFrameworkRepository.Models;

namespace EntityFrameworkRepository.Mapper.Interfaces
{
    public interface IEventDataMapper
    {
        EventEntityModel ToEntityModel(IEventDomainModel evtDomainModel);

        IEventDomainModel ToDomainModel(EventEntityModel evtEntityModel);
    }
}
