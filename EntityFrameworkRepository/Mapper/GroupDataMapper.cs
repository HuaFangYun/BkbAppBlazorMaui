using DomainModels.Contracts;
using DomainModels.Contracts.Factories;
using EntityFrameworkRepository.Mapper.Interfaces;
using EntityFrameworkRepository.Models;

namespace EntityFrameworkRepository.Mapper
{
    public class GroupDataMapper : IGroupDataMapper
    {
        private readonly IGroupDomainModelFactory _grpDomainModelFactory;

        public GroupDataMapper(IGroupDomainModelFactory grpDomainModelFactory)
        {
            _grpDomainModelFactory = grpDomainModelFactory;
        }

        public IGroupDomainModel ToDomainModel(GroupEntityModel grpEntityModel)
        {
            if (grpEntityModel == null)
                return null;

            var grpDomainModel = _grpDomainModelFactory.Create();
            grpDomainModel.Id = grpEntityModel.Id;
            grpDomainModel.Name = grpEntityModel.Name;

            return grpDomainModel;
        }

        public GroupEntityModel ToEntityModel(IGroupDomainModel grpDomainModel)
        {
            if (grpDomainModel == null)
                return null;

            var grpEntityModel = new GroupEntityModel();
            grpEntityModel.Id = grpDomainModel.Id;
            grpEntityModel.Name = grpDomainModel.Name;

            return grpEntityModel;
        }
    }
}
