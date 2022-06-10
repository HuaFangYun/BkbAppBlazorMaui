using DomainModels.Contracts;
using EntityFrameworkRepository.Mapper.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Contracts;

namespace EntityFrameworkRepository
{
    public class EventEntityFrameworkRepository : IEventRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IEventDataMapper _evtDataMapper;

        public EventEntityFrameworkRepository(AppDbContext dbContext, IEventDataMapper evtDataMapper)
        {
            _dbContext = dbContext;
            _evtDataMapper = evtDataMapper;
        }

        public async Task<IEventDomainModel> CreateEventAsync(IEventDomainModel evtDomainModel)
        {
            var evtEntityModel = _evtDataMapper.ToEntityModel(evtDomainModel);

            if (evtDomainModel.Group != null)
            {
                evtEntityModel.GroupId = evtDomainModel.Group.Id;
            }

            _dbContext.Events.Add(evtEntityModel);
            await _dbContext.SaveChangesAsync();

            return await GetEventByIdAsync(evtEntityModel.Id);
        }

        public async Task<IEventDomainModel> GetEventByIdAsync(Guid evtId)
        {
            var evtEntityModel = await _dbContext.Events
                .AsNoTracking()
                .Include(c => c.Group)
                .SingleOrDefaultAsync(c => c.Id == evtId);

            return _evtDataMapper.ToDomainModel(evtEntityModel);
        }

        public async Task UpdateEventAsync(IEventDomainModel evtDomainModel)
        {
            var evtEntityModel = await _dbContext.Events
                .Include(c => c.Group)
                .SingleOrDefaultAsync(c => c.Id == evtDomainModel.Id);

            evtEntityModel.Name = evtDomainModel.Name;
            evtEntityModel.Description = evtDomainModel.Description;
            evtEntityModel.Date = evtDomainModel.Date;

            if (evtEntityModel.Group!= null)
                _dbContext.Entry(evtEntityModel.Group);

            if (evtDomainModel.Group == null)
                evtEntityModel.GroupId = null;
            else if (evtEntityModel.GroupId != evtDomainModel.Group?.Id)
                evtEntityModel.GroupId = evtDomainModel.Group.Id;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteEventByIdAsync(Guid evtId)
        {
            var evtEntityModel = await _dbContext.Events.SingleOrDefaultAsync(c => c.Id == evtId);

            _dbContext.Events.Remove(evtEntityModel);
            await _dbContext.SaveChangesAsync();
        }
    }
}
