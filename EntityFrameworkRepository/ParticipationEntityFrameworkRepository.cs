using DomainModels.Contracts;
using EntityFrameworkRepository.Mapper.Interfaces;
using Microsoft.EntityFrameworkCore;
using Repository.Contracts;

namespace EntityFrameworkRepository
{
    public class ParticipationEntityFrameworkRepository : IParticipationRepository
    {
        private readonly AppDbContext _dbContext;
        private readonly IParticipationDataMapper _ptpDataMapper;

        public ParticipationEntityFrameworkRepository(AppDbContext dbContext, IParticipationDataMapper ptpDataMapper)
        {
            _dbContext = dbContext;
            _ptpDataMapper = ptpDataMapper;
        }

        public async Task<IParticipationDomainModel> CreateParticipationAsync(IParticipationDomainModel ptpDomainModel)
        {
            var ptpEntityModel = _ptpDataMapper.ToEntityModel(ptpDomainModel);

            if (ptpDomainModel.User != null)
            {
                ptpEntityModel.UserId = ptpDomainModel.User.Id;
            }
            if (ptpDomainModel.Event != null)
            {
                ptpEntityModel.EventId = ptpDomainModel.Event.Id;
            }

            _dbContext.Participations.Add(ptpEntityModel);
            await _dbContext.SaveChangesAsync();

            return await GetParticipationByIdAsync(ptpEntityModel.Id);
        }

        public async Task<IParticipationDomainModel> GetParticipationByIdAsync(Guid ptpId)
        {
            var ptpEntityModel = await _dbContext.Participations
                .AsNoTracking()
                .Include(c => c.User)
                .Include(c => c.Event)
                .SingleOrDefaultAsync(c => c.Id == ptpId);

            return _ptpDataMapper.ToDomainModel(ptpEntityModel);
        }

        public async Task UpdateParticipationAsync(IParticipationDomainModel ptpDomainModel)
        {
            var ptpEntityModel = await _dbContext.Participations
                .Include(c => c.User)
                .Include(c => c.Event)
                .SingleOrDefaultAsync(c => c.Id == ptpDomainModel.Id);

            ptpEntityModel.Participate = ptpDomainModel.Participate;
            ptpEntityModel.Reason = ptpDomainModel.Reason;

            if (ptpEntityModel.User != null)
                _dbContext.Entry(ptpEntityModel.User);

            if (ptpDomainModel.User == null)
                ptpEntityModel.UserId = null;
            else if (ptpEntityModel.UserId != ptpDomainModel.User?.Id)
                ptpEntityModel.UserId = ptpDomainModel.User.Id;

            if (ptpEntityModel.Event != null)
                _dbContext.Entry(ptpEntityModel.Event);

            if (ptpDomainModel.Event == null)
                ptpEntityModel.EventId = null;
            else if (ptpEntityModel.EventId != ptpDomainModel.Event?.Id)
                ptpEntityModel.EventId = ptpDomainModel.Event.Id;

            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteParticipationByIdAsync(Guid ptpId)
        {
            var ptpEntityModel = await _dbContext.Participations.SingleOrDefaultAsync(c => c.Id == ptpId);

            _dbContext.Participations.Remove(ptpEntityModel);
            await _dbContext.SaveChangesAsync();
        }
    }
}
