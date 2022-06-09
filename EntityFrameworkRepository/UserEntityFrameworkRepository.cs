using DomainModels.Contracts;
using EntityFrameworkRepository.Mapper.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Contracts;

namespace EntityFrameworkRepository
{
    public class UserEntityFrameworkRepository : IUserRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IUserDataMapper _usrDataMapper;

        public UserEntityFrameworkRepository(AppDbContext dbContext, IUserDataMapper usrDataMapper)
        {
            _dbContext = dbContext;
            _usrDataMapper = usrDataMapper;
        }

        public async Task<IUserDomainModel> CreateUserAsync(IUserDomainModel usrDomainModel)
        {
            var usrEntityModel = _usrDataMapper.ToEntityModel(usrDomainModel);

            _dbContext.Users.Add(usrEntityModel);
            await _dbContext.SaveChangesAsync();

            return await GetUserByIdAsync(usrEntityModel.Id);
        }

        public async Task<IUserDomainModel> GetUserByIdAsync(Guid usrId)
        {
            var usrEntityModel = await _dbContext.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(c => c.Id == usrId);

            return _usrDataMapper.ToDomainModel(usrEntityModel);
        }

        public async Task UpdateUserAsync(IUserDomainModel usrDomainModel)
        {
            var usrEntityModel = await _dbContext.Users
                .SingleOrDefaultAsync(c => c.Id == usrDomainModel.Id);

            usrEntityModel.Name = usrDomainModel.Name;
            usrEntityModel.Email = usrDomainModel.Email;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteUserByIdAsync(Guid usrId)
        {
            var usrEntityModel = await _dbContext.Users.SingleOrDefaultAsync(c => c.Id == usrId);

            _dbContext.Users.Remove(usrEntityModel);
            await _dbContext.SaveChangesAsync();
        }
    }
}
