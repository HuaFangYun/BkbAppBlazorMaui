using BkbAppWorkflow.Contracts;
using BkbAppWorkflow.Contracts.Mapper;
using Repository.Contracts;
using ViewModels.Contracts;

namespace BkbAppWorkflow
{
    public class GroupMemberWorkflow : IGroupMemberWorkflow
    {
        private readonly IGroupMemberLogicMapper _grpMmbLogicMapper;
        private readonly IGroupMemberRepository _grpMmbRepository;

        public GroupMemberWorkflow(IGroupMemberLogicMapper grpMmbLogicMapper, IGroupMemberRepository grpMmbRepository)
        {
            _grpMmbLogicMapper = grpMmbLogicMapper;
            _grpMmbRepository = grpMmbRepository;
        }

        public async Task<IGroupMemberViewModel> CreateGroupMemberAsync(IGroupMemberViewModel grpMmbViewModel)
        {
            var grpMmbDomainModel = await _grpMmbRepository.CreateGroupMemberAsync(_grpMmbLogicMapper.ToDomainModel(grpMmbViewModel));
            return _grpMmbLogicMapper.ToViewModel(grpMmbDomainModel);
        }

        public async Task<IGroupMemberViewModel> GetGroupMemberByIdAsync(Guid grpMmbId)
        {
            var grpMmbDomainModel = await _grpMmbRepository.GetGroupMemberByIdAsync(grpMmbId);
            return _grpMmbLogicMapper.ToViewModel(grpMmbDomainModel);
        }

        public async Task UpdateGroupMemberAsync(IGroupMemberViewModel grpMmbViewModel)
        {
            await _grpMmbRepository.UpdateGroupMemberAsync(_grpMmbLogicMapper.ToDomainModel(grpMmbViewModel));
        }

        public async Task DeleteGroupMemberByIdAsync(Guid grpMmbId)
        {
            await _grpMmbRepository.DeleteGroupMemberByIdAsync(grpMmbId);
        }
    }
}
