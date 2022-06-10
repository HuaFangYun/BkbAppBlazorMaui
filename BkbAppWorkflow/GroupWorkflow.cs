using BkbAppWorkflow.Contracts;
using BkbAppWorkflow.Contracts.Mapper;
using Repository.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow
{
    public class GroupWorkflow : IGroupWorkflow
    {
        private readonly IGroupLogicMapper _grpLogicMapper;
        private readonly IGroupRepository _grpRepository;

        public GroupWorkflow(IGroupLogicMapper grpLogicMapper, IGroupRepository grpRepository)
        {
            _grpLogicMapper = grpLogicMapper;
            _grpRepository = grpRepository;
        }

        public async Task<IGroupViewModel> CreateGroupAsync(IGroupViewModel grpViewModel)
        {
            var grpDomainModel = await _grpRepository.CreateGroupAsync(_grpLogicMapper.ToDomainModel(grpViewModel));
            return _grpLogicMapper.ToViewModel(grpDomainModel);
        }

        public async Task<IGroupViewModel> GetGroupByIdAsync(Guid grpId)
        {
            var grpDomainModel = await _grpRepository.GetGroupByIdAsync(grpId);
            return _grpLogicMapper.ToViewModel(grpDomainModel);
        }

        public async Task UpdateGroupAsync(IGroupViewModel grpViewModel)
        {
            await _grpRepository.UpdateGroupAsync(_grpLogicMapper.ToDomainModel(grpViewModel));
        }

        public async Task DeleteGroupByIdAsync(Guid grpId)
        {
            await _grpRepository.DeleteGroupByIdAsync(grpId);
        }
    }
}
