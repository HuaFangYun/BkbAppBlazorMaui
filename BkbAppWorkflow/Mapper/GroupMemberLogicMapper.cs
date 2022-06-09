using BkbAppWorkflow.Contracts.Mapper;
using DomainModels.Contracts;
using DomainModels.Contracts.Factories;
using ViewModels.Contracts;
using ViewModels.Contracts.Factories;

namespace BkbAppWorkflow.Mapper
{
    public class GroupMemberLogicMapper : IGroupMemberLogicMapper
    {
        private readonly IGroupMemberDomainModelFactory _grpMmbDomainModelFactory;
        private readonly IGroupMemberViewModelFactory _grpMmbViewModelFactory;
        private readonly IUserLogicMapper _usrLogicMapper;
        private readonly IGroupLogicMapper _grpLogicMapper;

        public GroupMemberLogicMapper(IGroupMemberDomainModelFactory grpMmbDomainModelFactory, IGroupMemberViewModelFactory grpMmbViewModelFactory, IUserLogicMapper usrLogicMapper, IGroupLogicMapper grpLogicMapper)
        {
            _grpMmbDomainModelFactory = grpMmbDomainModelFactory;
            _grpMmbViewModelFactory = grpMmbViewModelFactory;
            _usrLogicMapper = usrLogicMapper;
            _grpLogicMapper = grpLogicMapper;
        }

        public IGroupMemberDomainModel ToDomainModel(IGroupMemberViewModel grpMmbViewModel)
        {
            if (grpMmbViewModel == null)
                return null;

            var grpMmbDomainModel = _grpMmbDomainModelFactory.Create();
            grpMmbDomainModel.Id = grpMmbViewModel.Id;
            grpMmbDomainModel.User = _usrLogicMapper.ToDomainModel(grpMmbViewModel.User);
            grpMmbDomainModel.Group = _grpLogicMapper.ToDomainModel(grpMmbViewModel.Group);

            return grpMmbDomainModel;
        }

        public IGroupMemberViewModel ToViewModel(IGroupMemberDomainModel grpMmbDomainModel)
        {
            if (grpMmbDomainModel == null)
                return null;

            var grpMmbViewModel = _grpMmbViewModelFactory.Create();
            grpMmbViewModel.Id = grpMmbDomainModel.Id;
            grpMmbViewModel.User = _usrLogicMapper.ToViewModel(grpMmbDomainModel.User);
            grpMmbViewModel.Group = _grpLogicMapper.ToViewModel(grpMmbDomainModel.Group);

            return grpMmbViewModel;
        }
    }
}
