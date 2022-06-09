using DomainModels.Contracts;
using DomainModels.Contracts.Factories;
using EntityFrameworkRepository.Mapper.Interfaces;
using EntityFrameworkRepository.Models;

namespace EntityFrameworkRepository.Mapper
{
    public class GroupMemberDataMapper : IGroupMemberDataMapper
    {
        private readonly IGroupMemberDomainModelFactory _grpMmbDomainModelFactory;
        private readonly IUserDataMapper _usrDataMapper;
        private readonly IGroupDataMapper _grpDataMapper;

        public GroupMemberDataMapper(IGroupMemberDomainModelFactory grpMmbDomainModelFactory, IUserDataMapper usrDataMapper, IGroupDataMapper grpDataMapper)
        {
            _grpMmbDomainModelFactory = grpMmbDomainModelFactory;
            _usrDataMapper = usrDataMapper;
            _grpDataMapper = grpDataMapper;
        }

        public IGroupMemberDomainModel ToDomainModel(GroupMemberEntityModel grpMmbEntityModel)
        {
            if (grpMmbEntityModel == null)
                return null;

            var grpMmbDomainModel = _grpMmbDomainModelFactory.Create();
            grpMmbDomainModel.Id = grpMmbEntityModel.Id;
            grpMmbDomainModel.User = _usrDataMapper.ToDomainModel(grpMmbEntityModel.User);
            grpMmbDomainModel.UserId = grpMmbEntityModel.UserId;
            grpMmbDomainModel.Group = _grpDataMapper.ToDomainModel(grpMmbEntityModel.Group);
            grpMmbDomainModel.GroupId = grpMmbEntityModel.GroupId;

            return grpMmbDomainModel;
        }

        public GroupMemberEntityModel ToEntityModel(IGroupMemberDomainModel grpMmbDomainModel)
        {
            if (grpMmbDomainModel == null)
                return null;

            var grpMmbEntityModel = new GroupMemberEntityModel();
            grpMmbEntityModel.Id = grpMmbDomainModel.Id;
            grpMmbEntityModel.User = _usrDataMapper.ToEntityModel(grpMmbDomainModel.User);
            grpMmbEntityModel.UserId = grpMmbDomainModel.UserId;
            grpMmbEntityModel.Group = _grpDataMapper.ToEntityModel(grpMmbDomainModel.Group);
            grpMmbEntityModel.GroupId = grpMmbDomainModel.GroupId;

            return grpMmbEntityModel;
        }
    }
}
