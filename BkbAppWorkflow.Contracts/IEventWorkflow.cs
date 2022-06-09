using ViewModels.Contracts;

namespace BkbAppWorkflow.Contracts
{
    public interface IEventWorkflow
    {
        IEventViewModel CreateEvent(IEventViewModel evtViewModel);

        IEventViewModel GetEventById(Guid evtId);

        void UpdateEvent(IEventViewModel evtViewModel);

        void DeleteEventById(Guid evtId);
    }
}
