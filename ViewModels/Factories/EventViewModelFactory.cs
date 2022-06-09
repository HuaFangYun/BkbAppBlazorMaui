using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace ViewModels.Factories
{
    public class EventViewModelFactory : IEventViewModelFactory
    {
        public IEventViewModel Create()
        {
            return new EventViewModel();
        }
    }
}
