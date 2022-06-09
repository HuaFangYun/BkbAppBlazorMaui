using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace ViewModels.Factories
{
    public class ParticipationViewModelFactory : IParticipationViewModelFactory
    {
        public IParticipationViewModel Create()
        {
            return new ParticipationViewModel();
        }
    }
}
