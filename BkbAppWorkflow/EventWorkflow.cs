using BkbAppWorkflow.Contracts;
using BkbAppWorkflow.Contracts.Mapper;
using Repository.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow
{
    public class EventWorkflow : IEventWorkflow
    {
        private readonly IEventLogicMapper _evtLogicMapper;
        private readonly IEventRepository _evtRepository;

        public EventWorkflow(IEventLogicMapper evtLogicMapper, IEventRepository evtRepository)
        {
            _evtLogicMapper = evtLogicMapper;
            _evtRepository = evtRepository;
        }

        public async Task<IEventViewModel> CreateEventAsync(IEventViewModel evtViewModel)
        {
            var evtDomainModel = await _evtRepository.CreateEventAsync(_evtLogicMapper.ToDomainModel(evtViewModel));
            return _evtLogicMapper.ToViewModel(evtDomainModel);
        }

        public async Task<IEventViewModel> GetEventByIdAsync(Guid evtId)
        {
            var evtDomainModel = await _evtRepository.GetEventByIdAsync(evtId);
            return _evtLogicMapper.ToViewModel(evtDomainModel);
        }

        public async Task UpdateEventAsync(IEventViewModel evtViewModel)
        {
            await _evtRepository.UpdateEventAsync(_evtLogicMapper.ToDomainModel(evtViewModel));
        }

        public async Task DeleteEventByIdAsync(Guid evtId)
        {
            await _evtRepository.DeleteEventByIdAsync(evtId);
        }
    }
}
