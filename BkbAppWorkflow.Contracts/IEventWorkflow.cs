using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts
{
    public interface IEventWorkflow
    {
        Task<IEventViewModel> CreateEventAsync(IEventViewModel evtViewModel);

        Task<IEventViewModel> GetEventByIdAsync(Guid evtId);

        Task UpdateEventAsync(IEventViewModel evtViewModel);

        Task DeleteEventByIdAsync(Guid evtId);
    }
}
