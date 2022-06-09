using BkbAppWorkflow.Contracts.Mapper;
using DomainModels.Contracts;
using DomainModels.Contracts.Factories;
using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace BkbAppWorkflow.Mapper
{
    public class EventLogicMapper : IEventLogicMapper
    {
        private readonly IEventDomainModelFactory _evtDomainModelFactory;
        private readonly IEventViewModelFactory _evtViewModelFactory;
        private readonly IGroupLogicMapper _grpLogicMapper;

        public EventLogicMapper(IEventDomainModelFactory evtDomainModelFactory, IEventViewModelFactory evtViewModelFactory, IGroupLogicMapper usrLogicMapper)
        {
            _evtDomainModelFactory = evtDomainModelFactory;
            _evtViewModelFactory = evtViewModelFactory;
            _grpLogicMapper = usrLogicMapper;
        }

        public IEventDomainModel ToDomainModel(IEventViewModel evtViewModel)
        {
            if (evtViewModel == null)
                return null;

            var evtDomainModel = _evtDomainModelFactory.Create();
            evtDomainModel.Id = evtViewModel.Id;
            evtDomainModel.Name = evtViewModel.Name;
            evtDomainModel.Description = evtViewModel.Description;
            evtDomainModel.Date = evtViewModel.Date;
            evtDomainModel.Group = _grpLogicMapper.ToDomainModel(evtViewModel.Group);

            return evtDomainModel;
        }

        public IEventViewModel ToViewModel(IEventDomainModel evtDomainModel)
        {
            if (evtDomainModel == null)
                return null;

            var evtViewModel = _evtViewModelFactory.Create();
            evtViewModel.Id = evtDomainModel.Id;
            evtViewModel.Name = evtDomainModel.Name;
            evtViewModel.Description = evtDomainModel.Description;
            evtViewModel.Date = evtDomainModel.Date;
            evtViewModel.Group = _grpLogicMapper.ToViewModel(evtDomainModel.Group);

            return evtViewModel;
        }
    }
}
