using DomainModels.Contracts;

namespace Repository.Contracts
{
    public interface IEventRepository
    {
        Task<IEventDomainModel> CreateEventAsync(IEventDomainModel evtDomainModel);

        Task<IEventDomainModel> GetEventByIdAsync(Guid evtId);

        Task UpdateEventAsync(IEventDomainModel evtDomainModel);

        Task DeleteEventByIdAsync(Guid evtId);
    }
}
