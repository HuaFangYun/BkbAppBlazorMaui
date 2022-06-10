using DomainModels.Contracts;
using EntityFrameworkRepository.Mapper.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Contracts;

namespace EntityFrameworkRepository
{
    public class GroupMemberEntityFrameworkRepository : IGroupMemberRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IGroupMemberDataMapper _grpMmbDataMapper;

        public GroupMemberEntityFrameworkRepository(AppDbContext dbContext, IGroupMemberDataMapper grpMmbDataMapper)
        {
            _dbContext = dbContext;
            _grpMmbDataMapper = grpMmbDataMapper;
        }

        public async Task<IGroupMemberDomainModel> CreateGroupMemberAsync(IGroupMemberDomainModel grpMmbDomainModel)
        {
            var grpMmbEntityModel = _grpMmbDataMapper.ToEntityModel(grpMmbDomainModel);

            if (grpMmbDomainModel.User != null)
            {
                grpMmbEntityModel.UserId = grpMmbDomainModel.User.Id;
            }
            if (grpMmbDomainModel.Group != null)
            {
                grpMmbEntityModel.GroupId = grpMmbDomainModel.Group.Id;
            }

            _dbContext.GroupMembers.Add(grpMmbEntityModel);
            await _dbContext.SaveChangesAsync();

            return await GetGroupMemberByIdAsync(grpMmbEntityModel.Id);
        }

        public async Task<IGroupMemberDomainModel> GetGroupMemberByIdAsync(Guid grpMmbId)
        {
            var grpMmbEntityModel = await _dbContext.GroupMembers
                .AsNoTracking()
                .Include(c => c.User)
                .Include(c => c.Group)
                .SingleOrDefaultAsync(c => c.Id == grpMmbId);

            return _grpMmbDataMapper.ToDomainModel(grpMmbEntityModel);
        }

        public async Task UpdateGroupMemberAsync(IGroupMemberDomainModel grpMmbDomainModel)
        {
            var grpMmbEntityModel = await _dbContext.GroupMembers
                .Include(c => c.User)
                .Include(c => c.Group)
                .SingleOrDefaultAsync(c => c.Id == grpMmbDomainModel.Id);

            if (grpMmbEntityModel.User != null)
                _dbContext.Entry(grpMmbEntityModel.User);

            if (grpMmbDomainModel.User == null)
                grpMmbEntityModel.UserId = null;
            else if (grpMmbEntityModel.UserId != grpMmbDomainModel.User?.Id)
                grpMmbEntityModel.UserId = grpMmbDomainModel.User.Id;

            if (grpMmbEntityModel.Group != null)
                _dbContext.Entry(grpMmbEntityModel.Group);

            if (grpMmbDomainModel.Group == null)
                grpMmbEntityModel.GroupId = null;
            else if (grpMmbEntityModel.GroupId != grpMmbDomainModel.Group?.Id)
                grpMmbEntityModel.GroupId = grpMmbDomainModel.Group.Id;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteGroupMemberByIdAsync(Guid grpMmbId)
        {
            var grpMmbEntityModel = await _dbContext.GroupMembers.SingleOrDefaultAsync(c => c.Id == grpMmbId);

            _dbContext.GroupMembers.Remove(grpMmbEntityModel);
            await _dbContext.SaveChangesAsync();
        }
    }
}
