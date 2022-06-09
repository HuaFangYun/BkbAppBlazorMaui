using DomainModels.Contracts;

namespace Repository.Contracts
{
    public interface IEventRepository
    {
        IEventDomainModel CreateEvent(IEventDomainModel evtDomainModel);

        IEventDomainModel GetEventById(Guid evtId);

        void UpdateEvent(IEventDomainModel evtDomainModel);

        void DeleteEventById(Guid evtId);
    }
}
