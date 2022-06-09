using DomainModels.Contracts;

namespace Repository.Contracts
{
    public interface IParticipationRepository
    {
        Task<IParticipationDomainModel> CreateParticipationAsync(IParticipationDomainModel ptpDomainModel);

        Task<IParticipationDomainModel> GetParticipationByIdAsync(Guid ptpId);

        Task UpdateParticipationAsync(IParticipationDomainModel ptpDomainModel);

        Task DeleteParticipationByIdAsync(Guid ptpId);
    }
}
