using DomainModels.Contracts;
using EntityFrameworkRepository.Mapper.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Contracts;

namespace EntityFrameworkRepository
{
    public class GroupEntityFrameworkRepository : IGroupRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IGroupDataMapper _grpDataMapper;

        public GroupEntityFrameworkRepository(AppDbContext dbContext, IGroupDataMapper grpDataMapper)
        {
            _dbContext = dbContext;
            _grpDataMapper = grpDataMapper;
        }

        public async Task<IGroupDomainModel> CreateGroupAsync(IGroupDomainModel grpDomainModel)
        {
            var grpEntityModel = _grpDataMapper.ToEntityModel(grpDomainModel);

            _dbContext.Groups.Add(grpEntityModel);
            await _dbContext.SaveChangesAsync();

            return await GetGroupByIdAsync(grpEntityModel.Id);
        }

        public async Task<IGroupDomainModel> GetGroupByIdAsync(Guid grpId)
        {
            var grpEntityModel = await _dbContext.Groups
                .AsNoTracking()
                .SingleOrDefaultAsync(c => c.Id == grpId);

            return _grpDataMapper.ToDomainModel(grpEntityModel);
        }

        public async Task UpdateGroupAsync(IGroupDomainModel grpDomainModel)
        {
            var grpEntityModel = await _dbContext.Groups
                .SingleOrDefaultAsync(c => c.Id == grpDomainModel.Id);

            grpEntityModel.Name = grpDomainModel.Name;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteGroupByIdAsync(Guid grpId)
        {
            var grpEntityModel = await _dbContext.Groups.SingleOrDefaultAsync(c => c.Id == grpId);

            _dbContext.Groups.Remove(grpEntityModel);
            await _dbContext.SaveChangesAsync();
        }
    }
}
